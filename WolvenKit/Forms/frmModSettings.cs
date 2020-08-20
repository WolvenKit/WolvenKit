using System;
using System.IO;
using System.Windows.Forms;
using WolvenKit.Common;

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
            get => mod;
            set
            {
                mod = value;
                pgModMain.SelectedObject = mod;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            mod = pgModMain.SelectedObject as W3Mod;
            if (mod == null)
                return;
            mod.FileName = Path.Combine(Path.GetDirectoryName(Mod.FileName), mod.Name) + ".w3modproj";
        }
    }
}