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

            // Bundles + Metadata
            if (Directory.GetFiles(activemod.ModCookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                modBDL.Checked = true;
                modMD.Checked = true;
            }
            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                modBDL.Checked = true;
                modMD.Checked = true;
            }

            if (Directory.GetFiles(activemod.DlcCookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                dlcBDL.Checked = true;
                dlcMD.Checked = true;
            }
            if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                dlcBDL.Checked = true;
                dlcMD.Checked = true;
            }

            // Textures
            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*.xbm", SearchOption.AllDirectories).Any())
                modTEX.Checked = true;
            if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*.xbm", SearchOption.AllDirectories).Any())
                dlcTEX.Checked = true;

            // Sound
            var allowedExtensions = new[] { ".wem", ".bnk" };
            if (Directory
                .GetFiles(activemod.ModDirectory, "*", SearchOption.AllDirectories)
                .Any(file => allowedExtensions.Any(file.ToLower().EndsWith)))
                modSND.Checked = true;
            if (Directory
                .GetFiles(activemod.ModDirectory, "*", SearchOption.AllDirectories)
                .Any(file => allowedExtensions.Any(file.ToLower().EndsWith)))
                dlcSND.Checked = true;

            // Scripts  
            if (Directory.GetFiles(activemod.ModDirectory, "*.ws", SearchOption.AllDirectories).Any())
                modSCR.Checked = true;
            if (Directory.GetFiles(activemod.DlcDirectory, "*.ws", SearchOption.AllDirectories).Any())
                dlcSCR.Checked = true;

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

            this.Icon = UIController.GetThemedWkitIcon();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (modBDL.Checked | modMD.Checked | dlcBDL.Checked | dlcMD.Checked 
            | modTEX.Checked | dlcTEX.Checked | modSND.Checked | dlcSND.Checked
            | modSCR.Checked | dlcSCR.Checked | modSTR.Checked | modCOL.Checked | dlcCOL.Checked)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
