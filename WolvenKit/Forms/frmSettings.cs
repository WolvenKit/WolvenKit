using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParserLTK;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using WolvenKit.App;
using WolvenKit.Common.Model;

namespace WolvenKit
{
    public partial class frmSettings : Form
    {
        public string witcherexe = "";
        public string wccLiteexe = "";

        public const string wcc_sha256 = "fb20d7aa45b95446baac9b376533b06b86add732cbe40fd0620e4a4feffae47b";
        public const string wcc_sha256_patched = "275faa214c6263287deea47ddbcd7afcf6c2503a76ff57f2799bc158f5af7c5d";
        public const string wcc_sha256_patched2 = "104f50142fde883337d332d319d205701e8a302197360f5237e6bb426984212a";

        public frmSettings()
        {
            InitializeComponent();
            var config = MainController.Get().Configuration;
            txExecutablePath.Text = config.ExecutablePath;
            txTextLanguage.Text = config.TextLanguage;
            txVoiceLanguage.Text = config.VoiceLanguage;
            txWCC_Lite.Text = config.WccLite;
            
            



            checkBoxDisableWelcomeForm.Checked = config.IsWelcomeFormDisabled;
            checkBoxOverflow.Checked = config.OverflowEnabled;
            
            comboBoxTheme.Items.AddRange(Enum.GetValues(typeof(EColorThemes)).Cast<object>().ToArray());
            comboBoxTheme.SelectedItem = UIController.Get().Configuration.ColorTheme;
            
            comboBoxExtension.Items.AddRange(Enum.GetValues(typeof(EUncookExtension)).Cast<object>().ToArray());
            comboBoxExtension.SelectedItem = MainController.Get().Configuration.UncookExtension;

            exeSearcherSlave.RunWorkerAsync();

            // get the depot path
            // if depot path is empty, get the r4data from wcc_lite
            if (string.IsNullOrEmpty(config.DepotPath) || !Directory.Exists(config.DepotPath))
            {
                if (File.Exists(txWCC_Lite.Text) && Path.GetExtension(txWCC_Lite.Text) == ".exe" && txWCC_Lite.Text.Contains("wcc_lite.exe"))
                {
                    DirectoryInfo wccDir = new FileInfo(txWCC_Lite.Text).Directory.Parent.Parent;
                    string wcc_r4data = Path.Combine(wccDir.FullName, "r4data");
                    if (Directory.Exists(wcc_r4data))
                    {
                        config.DepotPath = wcc_r4data;
                    }
                }
            }
            txDepot.Text = config.DepotPath;

            btSave.Enabled =
                (File.Exists(txWCC_Lite.Text) && Path.GetExtension(txWCC_Lite.Text) == ".exe" && txWCC_Lite.Text.Contains("wcc_lite.exe")) &&
                (File.Exists(txExecutablePath.Text) && Path.GetExtension(txExecutablePath.Text) == ".exe" && txExecutablePath.Text.Contains("witcher3.exe")) &&
                Directory.Exists(txDepot.Text);
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

            // get configs
            var config = MainController.Get().Configuration;
            var uiconfig = UIController.Get().Configuration;

            // Apply Theme
            bool applyTheme = uiconfig.ColorTheme != (EColorThemes)comboBoxTheme.SelectedItem;
            
            // save settings
            config.ExecutablePath = txExecutablePath.Text;
            config.WccLite = txWCC_Lite.Text;

            // double check that r4depot exists
            if (string.IsNullOrEmpty(config.DepotPath))
            {
                DirectoryInfo wccDir = new FileInfo(txWCC_Lite.Text).Directory.Parent.Parent;
                string wcc_r4data = Path.Combine(wccDir.FullName, "r4data");
                if (Directory.Exists(wcc_r4data))
                {
                    config.DepotPath = wcc_r4data;
                }
            }
            config.DepotPath = txDepot.Text;

            config.TextLanguage = txTextLanguage.Text;
            config.VoiceLanguage = txVoiceLanguage.Text;
            config.UncookExtension = (EUncookExtension)comboBoxExtension.SelectedItem;
            config.IsWelcomeFormDisabled = checkBoxDisableWelcomeForm.Checked;
            config.OverflowEnabled = checkBoxOverflow.Checked;


            uiconfig.ColorTheme = (EColorThemes)comboBoxTheme.SelectedItem;

            // save configs
            config.Save();
            uiconfig.Save();

            MainController.Get().UpdateWccHelper(config.WccLite);


            if (applyTheme)
            {
                UIController.Get().Window.GlobalApplyTheme();
            }
                
            /// debug console enabling
            try
            {
                IniParser ip = new IniParser(Path.Combine(MainController.Get().Configuration.GameRootDir, "bin\\config\\base\\general.ini"));
                if (!ip.HasSection("General") || ip.GetSetting("General", "DBGConsoleOn", true) != "true")
                {
                    if (MessageBox.Show(
                            "WolvenKit has detected that your game has the debug console disabled. It is a useful tool when testing mods. Would you like it to be enabled?",
                            "Debug console enabling", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ip.AddSetting("General", "DBGConsoleOn", "true");
                        ip.Save();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            // patch wcc_lite
            try
            {
                using (var fs = new FileStream(txWCC_Lite.Text, FileMode.Open))
                using (var bw = new BinaryWriter(fs))
                {
                    var shawcc = SHA256.Create().ComputeHash(fs).Aggregate("", (c, n) => c += n.ToString("x2"));
                    switch (shawcc)
                    {
                        case wcc_sha256:
                        {
                            if (MessageBox.Show(@"wcc_lite is a great tool by CD Projekt red but
due to some internal problems they didn't really have time to properly develop it.
Due to this the tool takes an age to start up since it is searching for a CD Projekt red mssql server.
WolvenKit can patch this with a method figured out by blobbins on the witcher 3 forums.
Would you like to perform this patch?", "wcc_lite faster patch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                DialogResult.Yes)
                            {
                                //We perform the patch
                                bw.BaseStream.Seek(0x00713CD0, SeekOrigin.Begin);
                                bw.Write(new byte[0xDD].Select(x => x = 0x90).ToArray());
                            }

                            //Recompute hash
                            fs.Seek(0, SeekOrigin.Begin);
                            shawcc = SHA256.Create().ComputeHash(fs).Aggregate("", (c, n) => c += n.ToString("x2"));
                            if (shawcc == wcc_sha256_patched)
                            {
                                MessageBox.Show("Succesfully patched!", "Patch completed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to patch! Please reinstall wcc_lite and try again",
                                    "Patch completed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }

                            break;
                        }
                        case wcc_sha256_patched2:
                        case wcc_sha256_patched:
                        {
                            //Do nothing we are cool.
                            break;
                        }
                        default:
                        {
                            DialogResult = DialogResult.None;
                            txExecutablePath.Focus();
                            MessageBox.Show("Invalid wcc_lite.exe path you seem to have on older version",
                                "failed to save.");
                            return;
                        }
                    }

                }
            }
            catch (UnauthorizedAccessException)
            {
                //wcc_lite is installed to C:\\Program files
                MessageBox.Show("Please restart WolvenKit as administrator. Couldn't access " + txWCC_Lite.Text,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Exit with error code 0 so we don't raise a windows error and the user can restart it so we have access to the files.
                Environment.Exit(0);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

        }

        private void btnBrowseExe_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.Title = "Select Witcher 3 Executable.";
            dlg.FileName = txExecutablePath.Text;
            dlg.Filter = "witcher3.exe|witcher3.exe";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txExecutablePath.Text = dlg.FileName;
            }
        }

        private void btBrowseWCC_Lite_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog
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

        private void btBrowseDepot_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txDepot.Text = dlg.FileName;
            }
        }

        #region Events
        private void exeSearcherSlave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            const string uninstallkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            const string uninstallkey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
            var w3 = "";
            var wcc = "";
            try
            {
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                                SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }
                    }

                    exeSearcherSlave.ReportProgress(0, new Tuple<string, string, int, int>(w3, wcc, 0, 0));
                });
                Parallel.ForEach(Registry.LocalMachine.OpenSubKey(uninstallkey2)?.GetSubKeyNames(), item =>
                {
                    var programName = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("DisplayName");
                    var installLocation = Registry.LocalMachine.OpenSubKey(uninstallkey2 + item)
                        ?.GetValue("InstallLocation");
                    if (programName != null && installLocation != null)
                    {
                        if (programName.ToString().Contains("Witcher 3 Mod Tools"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                wcc = Directory.GetFiles(installLocation.ToString(), "wcc_lite.exe",
                                    SearchOption.AllDirectories).First();
                        }

                        if (programName.ToString().Contains("The Witcher 3 - Wild Hunt") ||
                            programName.ToString().Contains("The Witcher 3: Wild Hunt"))
                        {
                            if (Directory.Exists(installLocation.ToString()))
                                w3 = Directory.GetFiles(installLocation.ToString(), "witcher3.exe",
                                SearchOption.AllDirectories).First();
                        }
                    }

                    exeSearcherSlave.ReportProgress(0, new Tuple<string, string, int, int>(w3, wcc, 0, 0));
                });
            }
            catch (Exception ex)
            {
                System.Console.Error.WriteLine(ex.ToString());
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
        #endregion
    }
}