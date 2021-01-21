using System;
using System.Windows.Forms;

namespace PhotoSorter {
    public partial class FrmAdd : Form {
        public FrmAdd() {
            InitializeComponent();
            cmbKey.DataSource = Enum.GetValues( typeof( Keys ) );
        }

        private void Cancel_Click( object sender, EventArgs e ) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnBrowse_Click( object sender, EventArgs e ) {
            if ( fbdPath.ShowDialog() != DialogResult.OK )
            {
                return;
            }

            txtPath.Text = fbdPath.SelectedPath;
        }

        private void Ok_Click( object sender, EventArgs e ) {
            DialogResult = DialogResult.OK;
        }
    }
}