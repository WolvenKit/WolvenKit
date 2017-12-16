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
        public string witcherexe = "";
        public string wccLiteexe = "";

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
            exeSearcherSlave.RunWorkerAsync();
        }

        private void exeSearcherSlave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            var w3 = "";
            var wcc = "";
            int count = Registry.LocalMachine.OpenSubKey(uninstallkey).GetSubKeyNames().Length;
            int index = 1;
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
                            wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe", SearchOption.AllDirectories).First();
                        }
                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") || programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe", SearchOption.AllDirectories).First();
                        }
                    }
                    index++;
                    exeSearcherSlave.ReportProgress(0, new Tuple<string, string, int, int>(w3, wcc, index, count));
                });
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void exeSearcherSlave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (File.Exists(witcherexe))
            {
                txExecutablePath.Text = witcherexe;
            }
            if (File.Exists(wccLiteexe))
            {
                txWCC_Lite.Text = wccLiteexe;
            }
            if (witcherexe != "" && wccLiteexe != "")
            {
                MessageBox.Show("Found the game and wcc_lite!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (wccLiteexe != "")
            {
                MessageBox.Show("Found wcc_lite!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (witcherexe != "")
            {
                MessageBox.Show("Found the game!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Couldn!t manage to find the game nor wcc_lite!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exeSearcherSlave_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            var report = (e.UserState as Tuple<string, string, int, int>);
            witcherexe = report.Item1;
            wccLiteexe = report.Item2;
            this.Text = "Settings | Locating Game and wcc_lite [" + report.Item3 + "/" + report.Item4 + "]";
        }
    }
}