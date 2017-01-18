using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Edit
{
    public partial class frmRenameDialog : Form
    {

        public string FileName
        {
            get
            {
                return txFileName.Text;
            }
            set
            {
                txFileName.Text = value;
            }
        }

        public frmRenameDialog()
        {
            InitializeComponent();
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
