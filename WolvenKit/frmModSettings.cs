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
                txVersion.Text = mod.version;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (mod == null)
                return;
            mod.version = txVersion.Text;
            mod.Name = txName.Text;
            mod.FileName = Path.Combine(Path.GetDirectoryName(Mod.FileName), mod.Name) + ".w3modproj";
        }
    }
}