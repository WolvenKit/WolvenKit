using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WolvenKit.App;
using System.Drawing;

namespace WolvenKit
{
    public partial class frmPackSettings : Form
    {
        public (bool, bool) PackBundles => (modBDL.Checked, dlcBDL.Checked);
        public (bool, bool) GenMetadata => (modMD.Checked, dlcMD.Checked);
        public (bool, bool) GenTexCache => (modTEX.Checked, dlcTEX.Checked);
        public (bool, bool) GenCollCache => (modCOL.Checked, dlcCOL.Checked);
        public (bool, bool) Scripts => (modSCR.Checked, dlcSCR.Checked);
        public (bool, bool) Sound => (modSND.Checked, dlcSND.Checked);
        public (bool, bool) Strings => (modSTR.Checked, dlcSTR.Checked);

        public frmPackSettings()
        {
            var activemod = MainController.Get().ActiveMod;

            InitializeComponent();

            // Textures
            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*.xbm", SearchOption.AllDirectories).Any())
                modTEX.Checked = true;
            if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*.xbm", SearchOption.AllDirectories).Any())
                dlcTEX.Checked = true;

            // Sound
            var allowedExtensions = new[] { ".wem", ".bnk" };
            if (Directory
                .GetFiles(activemod.ModDirectory)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .Any())
                modSND.Checked = true;
            if (Directory
                .GetFiles(activemod.DlcDirectory)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .Any())
                dlcSPEECH.Checked = true;

            // Scripts  
            // if (activemod.Files.Any(x => x.EndsWith(".ws")))
            if (Directory.GetFiles(activemod.ModDirectory, "*.ws", SearchOption.AllDirectories).Any())
                modSCR.Checked = true;
            //if (Directory.GetFiles(activemod.DlcDirectory, "*.ws", SearchOption.AllDirectories).Any())
            //    dlcSTR.Checked = true;

            // Strings
            if (Directory.Exists(UIController.Get().Window.ActiveMod.ProjectDirectory + "\\strings")
                && Directory.GetFiles(UIController.Get().Window.ActiveMod.ProjectDirectory + "\\strings")
                .Any(x => x.EndsWith(".w3strings")))
                modSTR.Checked = true;

            // Collision
            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*", SearchOption.AllDirectories).Any())
                modCOL.Checked = true;
            if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*", SearchOption.AllDirectories).Any())
                dlcCOL.Checked = true;

            this.Icon = new Icon(@"Resources\Icons\GUI\Wkit_dark_16x.ico", new Size(16, 16));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
