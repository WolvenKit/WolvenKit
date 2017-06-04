using System;
using System.IO;
using System.Windows.Forms;
using WolvenKit.Mod;

namespace WolvenKit
{
    public partial class frmModSettings : Form
    {
        private W3Mod mod;

        public frmModSettings()
        {
            InitializeComponent();
        }

        public W3Mod Mod
        {
            get { return mod; }
            set
            {
                mod = value;

                txName.Text = mod.Name;
                cbInstallAsDLC.Checked = mod.InstallAsDLC;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (mod == null)
                return;

            mod.Name = txName.Text;
            mod.FileName = Path.Combine(Path.GetDirectoryName(Mod.FileName), mod.Name) + ".w3modproj";
            mod.InstallAsDLC = cbInstallAsDLC.Checked;
        }
    }
}