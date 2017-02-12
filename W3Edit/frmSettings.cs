using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace W3Edit
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
            var wcc_liteexe = "";
            try
            {
                List<KeyValuePair<string, string>> InstalledPrograms = new List<KeyValuePair<string, string>>();
                foreach (var item in Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
                {
                    var programName = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + item).GetValue("DisplayName");
                    var InstallLocation = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + item).GetValue("InstallLocation");
                    if (programName != null && InstallLocation != null)
                    {
                        InstalledPrograms.Add(new KeyValuePair<string, string>(programName.ToString(), InstallLocation.ToString()));

                        if (programName.ToString().StartsWith("Witcher 3 Mod Tools"))
                        {
                            wcc_liteexe = Directory.GetFiles(InstallLocation.ToString(), "wcc_lite.exe", SearchOption.AllDirectories).First();
                        }
                        if (Equals(programName, "The Witcher 3 - Wild Hunt"))
                        {
                            witcherexe = Directory.GetFiles(InstallLocation.ToString(), "witcher3.exe", SearchOption.AllDirectories).First();
                        }
                    }
                }
                return new Tuple<string,string>(witcherexe,wcc_liteexe);
            }
            catch (Exception)
            {
                return new Tuple<string,string>("","");
            }           
        }
    }
}