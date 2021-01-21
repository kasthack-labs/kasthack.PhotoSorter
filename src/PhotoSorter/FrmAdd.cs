namespace PhotoSorter
{
    using System;
    using System.Windows.Forms;

    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            this.InitializeComponent();
            this.cmbKey.DataSource = Enum.GetValues(typeof(Keys));
        }

        private void Cancel_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (this.fbdPath.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.txtPath.Text = this.fbdPath.SelectedPath;
        }

        private void Ok_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}