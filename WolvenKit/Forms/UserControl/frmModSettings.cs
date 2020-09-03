using System;
using System.IO;
using System.Windows.Forms;
using WolvenKit.Common;
using System.Drawing;

namespace WolvenKit
{
    public partial class frmModSettings : Form
    {
        private W3Mod mod;

        public frmModSettings()
        {
            InitializeComponent();

            this.Icon = new Icon(@"Resources\Icons\GUI\Wkit_dark_16x.ico", new Size(16, 16));

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