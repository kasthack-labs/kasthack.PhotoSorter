using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhotoSorter
{
    public partial class Main : Form
    {
        private readonly SortInfo _core;
        private readonly FrmAdd _dlgAdd;

        public Main()
        {
            _core = new SortInfo();
            _dlgAdd = new FrmAdd();
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e) => Application.Exit();

        private void menuSetWD_Click(object sender, EventArgs e)
        {
            if (fbdWd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _core.WorkingDirectory = fbdWd.SelectedPath;
            ApplyNewWd();
        }

        private void ApplyNewWd()
        {
            _core.Files = Directory.GetFiles(_core.WorkingDirectory).Select(a => new ProcessFile(a)).ToArray();
            lstFiles.DataSource = _core.Files;
        }

        private void btnAddMap_Click(object sender, EventArgs e)
        {
            if (_dlgAdd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var k = new Map
            {
                Key = (Keys)_dlgAdd.cmbKey.SelectedItem,
                Path = _dlgAdd.txtPath.Text
            };
            if (!_core.AddMap(k))
            {
                MessageBox.Show("Failed to add map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshKeymaps();
        }

        private void RefreshKeymaps() => lstMaps.DataSource = _core.Mappings;

        private void btnDelMap_Click(object sender, EventArgs e)
        {
            var ms = lstMaps.SelectedIndices.OfType<int>().Reverse().ToArray();
            foreach (var m in ms)
            {
                _core.RemoveMap((lstMaps.Items[m] as Map).Key);
            }

            RefreshKeymaps();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ind = lstFiles.SelectedIndex;
            if (!(lstFiles.Items[ind] is ProcessFile it))
            {
                return;
            }

            if (it.Deleted)
            {
                pctView.Image = null;
                return;
            }
            _core.SetActive(ind);
            LoadPic(it.Path);
        }

        private void LoadPic(string path)
        {
            try
            {
                pctView.LoadAsync(path);
                Text = Path.GetFileName(path);
            }
            catch (Exception) { }
        }

        private void ControlKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    SF(1);
                    break;
                case Keys.Up:
                    SF(-1);
                    break;
            }
            //alt+ctrl hotkeys
            if (e.Modifiers != Keys.None)
            {
                return;
            }

            if (_core.ProcessKey(e.KeyCode))
            {
                SF(1);
                return;
            }
        }

        private void SF(int delta)
        {
            var qi = lstFiles.SelectedIndex + delta;
            if (qi < lstFiles.Items.Count && qi >= 0)// && !lstFiles.Focused )
            {
                lstFiles.SelectedIndex = qi;
            }

            return;
        }
        //disable key navigation
        private void lstMaps_KeyDown(object sender, KeyEventArgs e) { }
        private void lstFiles_KeyDown(object sender, KeyEventArgs e) => e.SuppressKeyPress = true;

        private void saveKeymapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdMap.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _core.SaveMap(sfdMap.FileName);
        }

        private void loadKeymapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdMap.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _core.LoadMap(ofdMap.FileName);
            RefreshKeymaps();
        }
    }
}