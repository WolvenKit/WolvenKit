using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WolvenKit
{
    public partial class frmPackSettings : Form
    {
        public bool PackBundles => bundlesCHB.Checked;
        public bool GenMetadata => metadatastoreCHB.Checked;
        public bool GenTexCache => texturecachecCHB.Checked;
        public bool Scripts => scriptsCHB.Checked;
        public bool Sound => soundCHB.Checked;
        public bool Strings => stringsCHB.Checked;

        public frmPackSettings()
        {
            InitializeComponent();
            if (MainController.Get().Window.ActiveMod.Files.Any(x => x.EndsWith(".xbm")))
                texturecachecCHB.Checked = true;
            if (MainController.Get().Window.ActiveMod.Files.Any(x => x.EndsWith(".ws")))
                scriptsCHB.Checked = true;
            if (MainController.Get().Window.ActiveMod.Files.Any(x => x.EndsWith(".wem") || x.EndsWith(".bnk")))
                scriptsCHB.Checked = true;
            if (Directory.Exists((MainController.Get().Window.ActiveMod.Directory + "\\strings")) && Directory.GetFiles((MainController.Get().Window.ActiveMod.Directory + "\\strings")).Any(x => x.EndsWith(".w3strings")))
                stringsCHB.Checked = true;
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
