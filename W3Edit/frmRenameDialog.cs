using System;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class frmRenameDialog : Form
    {
        public frmRenameDialog()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return txFileName.Text; }
            set { txFileName.Text = value; }
        }

        private void txFileName_Enter(object sender, EventArgs e)
        {
        }

        private void frmRenameDialog_Activated(object sender, EventArgs e)
        {
            txFileName.Focus();
            var path = Path.GetDirectoryName(txFileName.Text);
            var filename = Path.GetFileNameWithoutExtension(txFileName.Text);

            txFileName.Select(path.Length + 1, filename.Length);
        }
    }
}