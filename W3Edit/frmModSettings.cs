using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.Mod;

namespace W3Edit
{
    public partial class frmModSettings : Form
    {
        private W3Mod mod;

        public W3Mod Mod { 
            get {
                return mod;
            }
            set {
                mod = value;

                txName.Text = mod.Name;
                cbInstallAsDLC.Checked = mod.InstallAsDLC;
            }
        }

        public frmModSettings()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (mod == null)
                return;

            mod.Name = txName.Text;
            mod.InstallAsDLC = cbInstallAsDLC.Checked;
        }
    }
}
