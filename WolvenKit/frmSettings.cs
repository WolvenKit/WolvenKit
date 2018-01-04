using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParserLTK;
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
            exeSearcherSlave.RunWorkerAsync();
            btSave.Enabled =
                (File.Exists(txWCC_Lite.Text) && Path.GetExtension(txWCC_Lite.Text) == ".exe" && txWCC_Lite.Text.Contains("wcc_lite.exe")) &&
                (File.Exists(txExecutablePath.Text) && Path.GetExtension(txExecutablePath.Text) == ".exe" && txExecutablePath.Text.Contains("witcher3.exe"));
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
            IniParser ip = new IniParser(Path.Combine(MainController.Get().Configuration.GameRootDir, "bin\\config\\base\\general.ini"));
            if (!ip.HasSection("General") || ip.GetSetting("General", "DBGConsoleOn", true) != "true")
            {
                if (MessageBox.Show(
                        "WolvenKit has detected that your game has the debug console disabled. It is a usefull tool when testing mods. Would you like it to be enabled?",
                        "Debug console enabling", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ip.AddSetting("General", "DBGConsoleOn","true");
                    ip.Save();
                }
            }

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

        private void exeSearcherSlave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            var w3 = "";
            var wcc = "";
            //Debug.WriteLine("Scanning: " + "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\:");
            try
            {
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe", SearchOption.AllDirectories).First();
                        }
                        else
                        {
                            //Debug.WriteLine("\t" + programName + "-> Not wcc_lite!");
                        }
                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") || programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe", SearchOption.AllDirectories).First();
                        }
                    }
                    exeSearcherSlave.ReportProgress(0, new Tuple<string, string, int, int>(w3, wcc, 0, 0));
                });
                //Debug.WriteLine("Scanning: " + "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\:");
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe", SearchOption.AllDirectories).First();
                        }
                        else
                        {
                            //Debug.WriteLine("\t" + programName + "-> Not wcc_lite!");
                        }
                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") || programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe", SearchOption.AllDirectories).First();
                        }
                    }
                    exeSearcherSlave.ReportProgress(0, new Tuple<string, string, int, int>(w3, wcc, 0, 0));
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
        }

        private void exeSearcherSlave_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            var report = (e.UserState as Tuple<string, string, int, int>);
            witcherexe = report?.Item1;
            wccLiteexe = report?.Item2;

        }

        private void txWCC_Lite_TextChanged(object sender, EventArgs e)
        {
            var path = txWCC_Lite.Text;
            if (File.Exists(path) && Path.GetExtension(path) == ".exe" && path.Contains("wcc_lite.exe"))
            {
                WCCexeTickLBL.Text = "✓";
                WCCexeTickLBL.ForeColor = Color.Green;
            }
            else
            {
                WCCexeTickLBL.Text = "X";
                WCCexeTickLBL.ForeColor = Color.Red;
            }
            btSave.Enabled =
                (File.Exists(txWCC_Lite.Text) && Path.GetExtension(txWCC_Lite.Text) == ".exe" && txWCC_Lite.Text.Contains("wcc_lite.exe")) &&
                (File.Exists(txExecutablePath.Text) && Path.GetExtension(txExecutablePath.Text) == ".exe" && txExecutablePath.Text.Contains("witcher3.exe"));
        }

        private void txExecutablePath_TextChanged(object sender, EventArgs e)
        {
            var path = txExecutablePath.Text;
            if (File.Exists(path) && Path.GetExtension(path) == ".exe" && path.Contains("witcher3.exe"))
            {
                W3exeTickLBL.Text = "✓";
                W3exeTickLBL.ForeColor = Color.Green;
            }
            else
            {
                W3exeTickLBL.Text = "X";
                W3exeTickLBL.ForeColor = Color.Red;
            }
            btSave.Enabled =
                (File.Exists(txWCC_Lite.Text) && Path.GetExtension(txWCC_Lite.Text) == ".exe" && txWCC_Lite.Text.Contains("wcc_lite.exe")) &&
                (File.Exists(txExecutablePath.Text) && Path.GetExtension(txExecutablePath.Text) == ".exe" && txExecutablePath.Text.Contains("witcher3.exe"));
        }
    }
}