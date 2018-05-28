using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit.Forms
{
    public partial class frmCreateInstaller : Form
    {
        private Color headercolor = Color.Red;
        private Color iconbg = Color.Black;
        

        public frmCreateInstaller()
        {
            InitializeComponent();
        }

        private void visualButton1_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog()
            {
                Title = "Please select a place to save the package",
                Filter = "WolvenKit package file | *.wkp"
            })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    CreatePackage(sf.FileName);
                }
            }
        }

        private void visualButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualTextBox1_ButtonClicked()
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            var imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
            using (var of = new OpenFileDialog()
            {
                Title = "Pick an icon for your mod package",
                Filter = string.Format("Images|{0}|All Files|*.*", imageExtensions)
            })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    iconpathTB.Text = of.FileName;
                    iconImgBox.Image = Image.FromFile(of.FileName);
                }
            }
        }

        async Task CreatePackage(string outpath)
        {
            if (MainController.Get().ActiveMod == null)
            {
                MessageBox.Show("No project loaded!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            var packeddir = Path.Combine(MainController.Get().ActiveMod.ProjectDirectory, @"packed\");
            var contentdir = Path.Combine(MainController.Get().ActiveMod.ProjectDirectory, @"packed\content\");
            if (!Directory.Exists(contentdir))
            {
                Directory.CreateDirectory(contentdir);
            }
            else
            {
                var di = new DirectoryInfo(contentdir);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            var packtask = MainController.Get().Window.PackAndInstallMod();
            await packtask;
            var installdir = Path.Combine(MainController.Get().ActiveMod.ProjectDirectory, @"Installer/");
            if (!Directory.Exists(installdir))
                Directory.CreateDirectory(installdir);
            var asm = WKPackage.CreateModAssembly(modversionTB.Text,modnameTB.Text,new Tuple<string, string, string, string, string, string>(authorTB.Text,null,null,null,null,null),descriptionRTB.Text,largedescRTB.Text,licenseTB.Text,new Tuple<Color, bool, Color>(headercolor,useblackCB.Checked,iconbg), new List<XElement>());
            var pkg = new WKPackage(asm,iconpathTB.Text,Path.Combine(MainController.Get().ActiveMod.ProjectDirectory, @"packed"));

            pkg.Save(outpath);
            MainController.Get().LogMessage = new KeyValuePair<string, frmOutput.Logtype>("Installer created: " + outpath + "\n", frmOutput.Logtype.Success);
            if (!File.Exists(outpath))
            {
                MainController.Get().LogMessage = new KeyValuePair<string, frmOutput.Logtype>("Couldn't create installer. Something went wrong.", frmOutput.Logtype.Error);
                return;
            }
            MainController.Get().ProjectStatus = "Ready";
            Commonfunctions.ShowFileInExplorer(outpath);
        }

        private void visualTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void visualLabel8_Click(object sender, EventArgs e)
        {

        }

        private void headerBTN_Click(object sender, EventArgs e)
        {
            var cp = new ColorDialog();
            cp.ShowDialog();
            headercolor = cp.Color;
        }

        private void iconbgBTN_Click(object sender, EventArgs e)
        {
            var cp = new ColorDialog();
            cp.ShowDialog();
            iconbg = cp.Color;
        }
    }
}
