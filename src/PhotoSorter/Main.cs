namespace PhotoSorter
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        private readonly SortInfo core;
        private readonly FrmAdd dlgAdd;

        public Main()
        {
            this.core = new SortInfo();
            this.dlgAdd = new FrmAdd();
            this.InitializeComponent();

            // menuMove
            this.menuMove.Checked = this.core.Move;
        }

        private void MenuExit_Click(object sender, EventArgs e) => Application.Exit();

        private void MenuSetWD_Click(object sender, EventArgs e)
        {
            if (this.fbdWd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.core.WorkingDirectory = this.fbdWd.SelectedPath;
            this.ApplyNewWd();
        }

        private void ApplyNewWd()
        {
            this.core.Files = Directory.GetFiles(this.core.WorkingDirectory).Select(a => new ProcessFile(a)).ToArray();
            this.lstFiles.DataSource = this.core.Files;
        }

        private void BtnAddMap_Click(object sender, EventArgs e)
        {
            if (this.dlgAdd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var k = new Map
            {
                Key = (Keys)this.dlgAdd.cmbKey.SelectedItem,
                Path = this.dlgAdd.txtPath.Text,
            };
            if (!this.core.AddMap(k))
            {
                _ = MessageBox.Show("Failed to add map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.RefreshKeymaps();
        }

        private void RefreshKeymaps() => this.lstMaps.DataSource = this.core.Mappings;

        private void BtnDelMap_Click(object sender, EventArgs e)
        {
            var ms = this.lstMaps.SelectedIndices.OfType<int>().Reverse().ToArray();
            foreach (var m in ms)
            {
                this.core.RemoveMap((this.lstMaps.Items[m] as Map).Key);
            }

            this.RefreshKeymaps();
        }

        private void LstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ind = this.lstFiles.SelectedIndex;
            if (this.lstFiles.Items[ind] is not ProcessFile it)
            {
                return;
            }

            if (it.Deleted)
            {
                this.pctView.Image = null;
                return;
            }

            this.core.SetActive(ind);
            this.LoadPic(it.Path);
        }

        private void LoadPic(string path)
        {
            try
            {
                this.pctView.LoadAsync(path);
                this.Text = Path.GetFileName(path);
            }
            catch (Exception)
            {
            }
        }

        private void ControlKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.SF(1);
                    break;
                case Keys.Up:
                    this.SF(-1);
                    break;
            }

            // alt+ctrl hotkeys
            if (e.Modifiers != Keys.None)
            {
                if (e.KeyCode == Keys.E && e.Modifiers.HasFlag(Keys.Control))
                {
                    Process.Start("explorer", $"/select,\"{(this.lstFiles.Items[this.lstFiles.SelectedIndex] as ProcessFile).Path}\"");
                }
            }

            if (this.core.ProcessKey(e.KeyCode))
            {
                this.SF(1);
                return;
            }
        }

        private void SF(int delta)
        {
            var qi = this.lstFiles.SelectedIndex + delta;
            if (qi < this.lstFiles.Items.Count && qi >= 0)
            {
                this.lstFiles.SelectedIndex = qi;
            }

            return;
        }

        // disable key navigation
        private void LstMaps_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void LstFiles_KeyDown(object sender, KeyEventArgs e) => e.SuppressKeyPress = true;

        private void SaveKeymapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.sfdMap.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.core.SaveMap(this.sfdMap.FileName);
        }

        private void LoadKeymapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ofdMap.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.core.LoadMap(this.ofdMap.FileName);
            this.RefreshKeymaps();
        }

        private void LoadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ofdCsv.ShowDialog() == DialogResult.OK)
            {
                this.core.Files = File.ReadAllLines(this.ofdCsv.FileName)
                    .Select(a => a.Split(',')[0])
                    .Where(a => File.Exists(a))
                    .Select(a => new ProcessFile(a))
                    .ToArray();
                this.lstFiles.DataSource = this.core.Files;
            }
        }

        private void MenuMove_Click(object sender, EventArgs e) => this.menuMove.Checked = this.core.Move ^= true;
    }
}
