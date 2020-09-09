using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WolvenKit.App;

namespace WolvenKit
{
    public partial class frmPackSettings : Form
    {
        public bool PackBundles => bundlesCHB.Checked;
        public bool GenMetadata => metadatastoreCHB.Checked;
        public bool GenTexCache => texturecachecCHB.Checked;
        public bool GenCollCache => collisionCacheCHB.Checked;
        public bool Scripts => scriptsCHB.Checked;
        public bool Sound => soundCHB.Checked;
        public bool Strings => stringsCHB.Checked;

        public frmPackSettings()
        {
            var activemod = MainController.Get().ActiveMod;

            InitializeComponent();

            if (Directory.GetFiles(activemod.ModTextureCacheDirectory,"*", SearchOption.AllDirectories).Any() ||
                Directory.GetFiles(activemod.DlcTextureCacheDirectory, "*", SearchOption.AllDirectories).Any())
                texturecachecCHB.Checked = true;

            if (Directory.GetFiles(activemod.ModCookedDirectory, "*", SearchOption.AllDirectories).Any() ||
                Directory.GetFiles(activemod.DlcCookedDirectory, "*", SearchOption.AllDirectories).Any())
                scriptsCHB.Checked = true;

            if (activemod.Files.Any(x => x.EndsWith(".wem") || x.EndsWith(".bnk")))
                soundCHB.Checked = true;

            if (Directory.Exists((UIController.Get().Window.ActiveMod.ProjectDirectory + "\\strings")) && Directory.GetFiles((UIController.Get().Window.ActiveMod.ProjectDirectory + "\\strings")).Any(x => x.EndsWith(".w3strings")))
                stringsCHB.Checked = true;

            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*", SearchOption.AllDirectories).Any() ||
                Directory.GetFiles(activemod.DlcUncookedDirectory, "*", SearchOption.AllDirectories).Any())
                collisionCacheCHB.Checked = true;
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
