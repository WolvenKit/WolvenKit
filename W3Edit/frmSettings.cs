using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WolvenKit
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            var config = MainController.Get().Configuration;
            txExecutablePath.Text = config.ExecutablePath;
            txTextLanguage.Text = config.TextLanguage;
            txVoiceLanguage.Text = config.VoiceLanguage;
            txWCC_Lite.Text = config.WccLite;
        }

        private void btnBrowseExe_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select Witcher 3 Executable.";
            dlg.FileName = txExecutablePath.Text;
            dlg.Filter = "witcher3.exe|witcher3.exe";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txExecutablePath.Text = dlg.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txExecutablePath.Text))
            {
                DialogResult = DialogResult.None;
                txExecutablePath.Focus();
                MessageBox.Show("Invalid witcher3.exe path", "failed to save.");
                return;
            }

            if (!File.Exists(txWCC_Lite.Text))
            {
                DialogResult = DialogResult.None;
                txWCC_Lite.Focus();
                MessageBox.Show("Invalid wcc_lite.exe path", "failed to save.");
                return;
            }
            var config = MainController.Get().Configuration;
            config.ExecutablePath = txExecutablePath.Text;
            config.WccLite = txWCC_Lite.Text;
            config.TextLanguage = txTextLanguage.Text;
            config.VoiceLanguage = txVoiceLanguage.Text;
            MainController.Get().ReloadStringManager();

            config.Save();
        }

        private void btBrowseWCC_Lite_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Title = "Select wcc_lite.exe.",
                FileName = txExecutablePath.Text,
                Filter = "wcc_lite.exe|wcc_lite.exe"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txWCC_Lite.Text = dlg.FileName;
            }
        }

        private void locateButton_Click(object sender, EventArgs e)
        {
            var locations = GetInstallLocations();
            if (File.Exists(locations.Item1))
            {
                txExecutablePath.Text = locations.Item1;
            }
            if (File.Exists(locations.Item2))
            {
                txWCC_Lite.Text = locations.Item2;
            }
        }

        public static Tuple<string,string> GetInstallLocations()
        {
            var witcherexe = "";
            var wccLiteexe = "";
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\"; 
            try
            {
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey).GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item).GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item).GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().StartsWith("Witcher 3 Mod Tools"))
                        {
                            wccLiteexe = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe", SearchOption.AllDirectories).First();
                        }
                        if (Equals(programName, "The Witcher 3 - Wild Hunt"))
                        {
                            witcherexe = Directory.GetFiles(installLocation.ToString(), "witcher3.exe", SearchOption.AllDirectories).First();
                        }
                    }
                });
                return new Tuple<string,string>(witcherexe,wccLiteexe);
            }
            catch (Exception)
            {
                return new Tuple<string,string>("","");
            }           
        }
    }
}