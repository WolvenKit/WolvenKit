using AutoUpdaterDotNET;
using Dfust.Hotkeys;
using SharpPresence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Wwise.Wwise;
using SearchOption = System.IO.SearchOption;


namespace WolvenKit
{
    using Bundles;
    using Cache;
    using Common;
    using Common.Services;
    using Common.Wcc;
    using CR2W;
    using CR2W.Types;
    using Extensions;
    using Forms;
    using System.CodeDom;
    using WolvenKit.App;
    using WolvenKit.Common.Model;
    using WolvenKit.Render;
    using WolvenKit.Scaleform;
    using Wwise.Player;
    using Enums = Dfust.Hotkeys.Enums;

    public partial class frmMain : Form
    {
        #region Forms
        private frmCR2WDocument _activedocument;
        private List<frmCR2WDocument> OpenDocuments { get; set; } = new List<frmCR2WDocument>();
        private frmModExplorer ModExplorer { get; set; }
        private frmStringsGui stringsGui { get; set; }
        private frmOutput Output { get; set; }
        private frmConsole Console { get; set; }

        private frmImportUtility ImportUtility { get; set; }
        private frmRadish RadishUtility { get; set; }
        private frmProgress m_frmProgress { get; set; }


        private frmScriptEditor ScriptPreview { get; set; }
        private List<frmScriptEditor> OpenScripts { get; set; } = new List<frmScriptEditor>();
        private frmImagePreview ImagePreview { get; set; }
        private List<frmImagePreview> OpenImages { get; set; } = new List<frmImagePreview>();

        #endregion



        public LoggerService Logger { get; set; }




        public frmCR2WDocument ActiveDocument
        {
            get => _activedocument;
            set
            {
                _activedocument = value;
                UpdateTitle();
            }
        }

        

        #region Fields
        private readonly string BaseTitle = "Wolven kit";
        private readonly bool COOKINPLACE = true;
        public static Task Packer;
        private HotkeyCollection hotkeys;
        private readonly ToolStripRenderer toolStripRenderer = new ToolStripProfessionalRenderer();

        
        private WccLite WccHelper;

        private delegate void strDelegate(string t);
        private delegate void logDelegate(string t, Logtype type);
        #endregion

        #region Properties
        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set
            {
                MainController.Get().ActiveMod = value;
                UpdateTitle();
            }
        }
        public string Version => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();


            this.dockPanel.Theme.Extender.FloatWindowFactory = new CustomFloatWindowFactory();
            visualStudioToolStripExtender1.DefaultRenderer = toolStripRenderer;
            UIController.Get().ToolStripExtender = visualStudioToolStripExtender1;
            ApplyCustomTheme();

            UpdateTitle();
            MainController.Get().PropertyChanged += MainControllerUpdated;

            #region Load recent files into toolstrip
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            if (File.Exists("recent_files.xml"))
            {
                var doc = XDocument.Load("recent_files.xml");
                recentFilesToolStripMenuItem.Enabled = doc.Descendants("recentfile").Any();
                foreach (var f in doc.Descendants("recentfile"))
                {
                    recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(f.Value, null, RecentFile_click));
                }
            }
            else
            {
                recentFilesToolStripMenuItem.Enabled = false;
            }
            #endregion
            hotkeys = new HotkeyCollection(Enums.Scope.Application);
            hotkeys.RegisterHotkey(Keys.Control | Keys.S, HKSave, "Save");
            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.S, HKSaveAll, "SaveAll");
            hotkeys.RegisterHotkey(Keys.F1, HKHelp, "Help");
            hotkeys.RegisterHotkey(Keys.Control | Keys.C, HKCopy, "Copy");
            hotkeys.RegisterHotkey(Keys.Control | Keys.V, HKPaste, "Paste");
            UIController.InitForm(this);

            MainBackgroundWorker.WorkerReportsProgress = true;
            MainBackgroundWorker.WorkerSupportsCancellation = true;
            MainBackgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            MainBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            MainBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }
        #endregion

        #region Methods
        Func<object, DoWorkEventArgs, object> workerAction;
        Func<object, object> workerCompletedAction;
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwAsync = sender as BackgroundWorker;
            e.Result = workerAction(sender, e);

            // add a result
            //e.Result
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            m_frmProgress?.SetProgressBarValue(e.ProgressPercentage, e.UserState);
        }
        frmCR2WDocument HACK_bwform = null;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // has errors
            if (e.Error != null)
            {
                // do not continue to the completed action
            }
            else // has completed successfully
            {
                if (workerCompletedAction != null)
                {
                    HACK_bwform = (frmCR2WDocument)workerCompletedAction(e.Result);
                }
                workerCompletedAction = null;
            }

            m_frmProgress.Close();
        }
        

        public void GlobalApplyTheme()
        {
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));

            CloseWindows();

            this.ApplyCustomTheme();

            dockPanel.LoadFromXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"), DeserializeDockContent);

            ReopenWindows();
        }
        private void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            this.dockPanel.Theme = theme;
            visualStudioToolStripExtender1.SetStyle(menuStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);
            visualStudioToolStripExtender1.SetStyle(toolbarToolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);
        }

        
        /// <summary>
        /// Deprecated. Use MainController.QueueLog 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggerUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Log")
            {
                Invoke(new logDelegate(AddOutput), ((LoggerService)sender).Log + "\n", ((LoggerService)sender).Logtype);
            }
            if (e.PropertyName == "Progress")
            {
                if (MainBackgroundWorker != null)
                {
                    if (string.IsNullOrEmpty(Logger.Progress.Item2))
                        MainBackgroundWorker.ReportProgress(Logger.Progress.Item1);
                    else
                        MainBackgroundWorker.ReportProgress(Logger.Progress.Item1, Logger.Progress.Item2);
                }
            }
        }
        /// <summary>
        /// Occurs when something in the maincontroller is updated that is INotifyProeprtyChanged
        /// Thread safe and always should be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainControllerUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ProjectStatus")
                Invoke(new strDelegate(SetStatusLabelText), ((MainController)sender).ProjectStatus);
            if (e.PropertyName == "LogMessage")
                Invoke(new logDelegate(AddOutput), ((MainController) sender).LogMessage.Key + "\n",
                    ((MainController) sender).LogMessage.Value);
        }

        private void SetStatusLabelText(string text)
        {
            statusLBL.Text = text;
        }

        private void HKSave(HotKeyEventArgs e)
        {
            if(ActiveDocument != null)
                saveFile(ActiveDocument);
        }

        private void HKSaveAll(HotKeyEventArgs e)
        {
            if(OpenDocuments != null && OpenDocuments.Count > 0)
                saveAllFiles();
        }

        private void HKHelp(HotKeyEventArgs e)
        {
            Process.Start("https://github.com/Traderain/Wolven-kit/wiki");
        }

        private void HKCopy(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
            {
                if (ActiveDocument.chunkList.IsActivated)
                {
                    ActiveDocument.chunkList.CopyChunks();
                    AddOutput("Selected chunk(s) copied!\n");
                }
                else if(ActiveDocument.propertyWindow.IsActivated)
                {
                    ActiveDocument.propertyWindow.copyVariable();
                    AddOutput("Selected propertie(s) copied!\n");
                }
            }
        }

        private void HKPaste(HotKeyEventArgs e)
        {
            if (ActiveDocument != null)
            {
                if (ActiveDocument.chunkList.IsActivated)
                {
                    ActiveDocument.chunkList.PasteChunks();
                    AddOutput("Copied chunk(s) pasted!\n");
                }
                else if(ActiveDocument.propertyWindow.IsActivated)
                {
                    ActiveDocument.propertyWindow.pasteVariable();
                    AddOutput("Copied propertie(s) pasted!\n");
                }
            }
        }


        private void UpdateTitle()
        {
            buildDateToolStripMenuItem.Text = $"v{Version}: {Assembly.GetExecutingAssembly().GetLinkerTime().ToString("yyyy MMMM dd")}";
            MenuLabelProject.Text = ActiveMod != null ? ActiveMod.Name : "<No Mod Loaded!>";

            Text = BaseTitle + " v" + Version;
            if (ActiveMod != null)
            {
                Text += " [" + ActiveMod.Name + "] ";
            }

            if (ActiveDocument != null && !ActiveDocument.IsDisposed)
            {
                Text += Path.GetFileName(ActiveDocument.FileName);
            }
        }

        private void saveAllFiles()
        {
            foreach (var d in OpenDocuments.Where(d => d.SaveTarget != null))
            {
                saveFile(d);
            }

            foreach (var d in OpenDocuments.Where(d => d.SaveTarget == null))
            {
                saveFile(d);
            }
            AddOutput("All files saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = "Item(s) Saved";
            MainController.Get().ProjectUnsaved = false;
        }

        private void saveFile(frmCR2WDocument d)
        {
            d.SaveFile();
            AddOutput(d.FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = "Saved";
        }

        private void btPack_Click(object sender, EventArgs e)
        {
            PackProject();
        }

        private void ClearOutput()
        {
            if (Output != null && !Output.IsDisposed)
            {
                Output.Clear();
            }
            MainController.Get().ProjectStatus = "Output cleared";
        }

        private void AddOutput(string text, Logtype type = Logtype.Normal)
        {
            if (Output != null && !Output.IsDisposed)
            {
                if (string.IsNullOrWhiteSpace(text))
                    return;

                Output.AddText(text, type);
            }
        }
        
        private void OnOutput(object sender, string output) {
            AddOutput(output);
        }

        public void PackProject()
        {
            if (Packer != null && (Packer.Status == TaskStatus.Running || Packer.Status == TaskStatus.WaitingToRun || Packer.Status == TaskStatus.WaitingForActivation))
            {
                MessageBox.Show("Packing task already running. Please wait!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Packer = PackAndInstallMod();
        }

        /// <summary>
        /// Installs the project from the packed folder of the project to the game
        /// </summary>
        private void InstallMod()
        {
            try
            {
                //Check if we have installed this mod before. If so do a little cleanup.
                if (File.Exists(ActiveMod.ProjectDirectory + "\\install_log.xml"))
                {
                    XDocument log = XDocument.Load(ActiveMod.ProjectDirectory + "\\install_log.xml");
                    var dirs = log.Root.Element("Files")?.Descendants("Directory");
                    if (dirs != null)
                    {
                        //Loop throught dirs and delete the old files in them.
                        foreach (var d in dirs)
                        {
                            foreach (var f in d.Elements("file"))
                            {
                                if (File.Exists(f.Value))
                                {
                                    File.Delete(f.Value);
                                    Debug.WriteLine("File delete: " + f.Value);
                                }
                            }
                        }
                        //Delete the empty directories.
                        foreach (var d in dirs)
                        {
                            if (d.Attribute("Path") != null)
                            {
                                if (Directory.Exists(d.Attribute("Path").Value))
                                {
                                    if (!(Directory.GetFiles(d.Attribute("Path").Value, "*", SearchOption.AllDirectories).Any()))
                                    {
                                        Directory.Delete(d.Attribute("Path").Value, true);
                                        Debug.WriteLine("Directory delete: " + d.Attribute("Path").Value);
                                    }
                                }
                            }
                        }
                    }
                    //Delete the old install log. We will make a new one so this is not needed anymore.
                    File.Delete(ActiveMod.ProjectDirectory + "\\install_log.xml");
                }
                XDocument installlog = new XDocument(new XElement("InstalLog", new XAttribute("Project", ActiveMod.Name), new XAttribute("Build_date", DateTime.Now.ToString())));
                var fileroot = new XElement("Files");
                //Copy and log the files.
                if (!Directory.Exists(Path.Combine(ActiveMod.ProjectDirectory, "packed")))
                {
                    AddOutput("Failed to install the mod! The packed directory doesn't exist! You forgot to tick any of the packing options?",Logtype.Important);
                    return;
                }
                fileroot.Add(Commonfunctions.DirectoryCopy(Path.Combine(ActiveMod.ProjectDirectory, "packed"), MainController.Get().Configuration.GameRootDir, true));
                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(ActiveMod.ProjectDirectory + "\\install_log.xml");
                AddOutput(ActiveMod.Name + " installed!" + "\n", Logtype.Success);
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                AddOutput(ex.ToString() + "\n", Logtype.Error);
            }
        }

        private void CreateInstaller()
        {
            var cif = new frmCreateInstaller();
            cif.ShowDialog();
        }

        private async void executeGame(string args = "")
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Game is already running!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.ExecutablePath)
            {
                WorkingDirectory = Path.GetDirectoryName(config.ExecutablePath),
                Arguments = args == "" ? "-net -debugscripts" : args,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };


            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            if (File.Exists(scriptlog))
                File.Delete(scriptlog);

            using (var process = Process.Start(proc))
            {
                var task2 = RedirectScriptlogOutput(process);
                await task2;
            }
        }

        private async Task RedirectScriptlogOutput(Process process)
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            using (var fs = new FileStream(scriptlog, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var fsr = new StreamReader(fs))
                {
                    while (!process.HasExited)
                    {
                        var result = await fsr.ReadToEndAsync();

                        AddOutput(result);

                        Application.DoEvents();
                    }
                }
                fs.Close();
            }
        }

        private void removeFromMod(string filename)
        {
            // Close open documents
            foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
            {
                t.Close();
                break;
            }

            ModExplorer?.PauseMonitoring();
            // Delete from file structure
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            try
            {
                if (File.Exists(fullpath))
                {
                    File.Delete(fullpath);
                }
                else
                {
                    Directory.Delete(fullpath, true);
                }
            }
            catch (Exception)
            {
                AddOutput("Failed to delete " + fullpath + "!\r\n");
            }
            ModExplorer?.ResumeMonitoring();


            SaveMod();
        }

        public void AddToOpenScripts(frmScriptEditor frmScriptEditor)
        {
            if (!OpenScripts.Any(_ => _.Text == frmScriptEditor.Text))
            {
                frmScriptEditor.Show(dockPanel, DockState.Document);
                OpenScripts.Add(frmScriptEditor);
                //ScriptPreview.Close();
                ScriptPreview = null;
            }
        }
        public void RemoveFromOpenScrips(frmScriptEditor frmScriptEditor)
        {
            if (OpenScripts.Any(_ => _.Text == frmScriptEditor.Text))
            {
                OpenScripts.Remove(frmScriptEditor);
            }
        }

        private void ModExplorer_RequestFileOpen(object sender, RequestFileArgs e)
        {
            var fullpath = e.File;

            var ext = Path.GetExtension(fullpath).ToUpper() ;

            // click
            if (e.Inspect)
            {
                switch (ext)
                {
                    case ".CSV":
                    case ".XML":
                    case ".TXT":
                    case ".BAT":

                    case ".WS":
                    case ".YML":
                    case ".LOG":
                    case ".INI":
                        {
                            if (OpenScripts.Any(_ => _.FileName == Path.GetFileName(fullpath)))
                            {
                                OpenScripts.First(_ => _.FileName == Path.GetFileName(fullpath)).Activate();
                            }
                            else
                            {
                                ShowScriptPreview();
                                ScriptPreview.LoadFile(fullpath);
                            }
                            break;
                        }
                    case ".PNG":
                    case ".JPG":
                    case ".TGA":
                    case ".BMP":
                    case ".JPEG":
                    case ".DDS":
                        {
                            if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
                            {
                                OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
                            }
                            else
                            {
                                ShowImagePreview();
                                ImagePreview.SetImage(fullpath);
                            }
                            break;
                        }
                    default:
                        break;
                }
                return;
            }

            // double click
            switch (ext)
            {
                case ".CSV":
                case ".XML":
                case ".TXT":
                    ShellExecute(fullpath);
                    break;
                case ".BAT":
                case ".WS":
                case ".YML":
                case ".LOG":
                case ".INI":
                    {
                        if (OpenScripts.Any(_ => _.FileName == Path.GetFileName(fullpath)))
                        {
                            OpenScripts.First(_ => _.FileName == Path.GetFileName(fullpath)).Activate();
                        }
                        else
                        {
                            if (ScriptPreview.FileName == Path.GetFileName(fullpath))
                            {
                                ScriptPreview.Close();
                            }
                            var se = new frmScriptEditor();
                            se.Show(dockPanel, DockState.Document);
                            se.LoadFile(fullpath);
                            OpenScripts.Add(se);
                        }
                        break;
                    }
                case ".WEM":
                    {
                        using (var sp = new frmAudioPlayer(fullpath))
                        {
                            sp.ShowDialog();
                        }
                        break;
                    }
                case ".SUBS":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".USM":
                    LoadUsmFile(fullpath);
                    break;
                case ".BNK":
                    {
                        using (var sp = new frmAudioPlayer(fullpath))
                        {
                            sp.ShowDialog();
                        }
                        break;
                    }
                case ".PNG":
                case ".JPG":
                case ".TGA":
                case ".BMP":
                case ".JPEG":
                case ".DDS":
                    {
                        if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
                        {
                            OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
                        }
                        else
                        {
                            if (ImagePreview.Text == Path.GetFileName(fullpath))
                            {
                                ImagePreview.Close();
                            }
                            var dockedImage = new frmImagePreview();
                            dockedImage.Show(dockPanel, DockState.Document);
                            dockedImage.SetImage(fullpath);
                            OpenImages.Add(dockedImage);
                        }
                        break;
                    }
                default:
                    LoadDocument(fullpath);
                    break;
            }
        }

        private static void ShellExecute(string fullpath)
        {
            var proc = new ProcessStartInfo(fullpath) { UseShellExecute = true };
            Process.Start(proc);
        }

        private static void PolymorphExecute(string fullpath, string extension)
        {
            File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
            var programname = new StringBuilder();
            NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
            if (programname.ToString().ToUpper().Contains(".EXE"))
            {
                Process.Start(programname.ToString(), fullpath);
            }
            else
            {
                throw new InvalidFileTypeException("Invalid file type");
            }
        }

        public void LoadUsmFile(string path)
        {
            if (!File.Exists(path) || Path.GetExtension(path) != ".usm")
                return;
            var usmplayer = new frmUsmPlayer(path);
            usmplayer.Show(dockPanel, DockState.Document);

        }

        private void ShowOutput()
        {
            if (Output == null || Output.IsDisposed)
            {
                Output = new frmOutput();
                Output.Show(dockPanel, DockState.DockBottom);
            }

            Output.Activate();
        }
        private void ShowConsole()
        {
            if (Console == null || Console.IsDisposed)
            {
                Console = new frmConsole();
                Console.Show(dockPanel, DockState.DockBottom);
            }

            Console.Activate();
        }

        private void ShowImportUtility()
        {
            if (ImportUtility == null || ImportUtility.IsDisposed)
            {
                ImportUtility = new frmImportUtility();
                ImportUtility.Show(dockPanel, DockState.Document);
            }

            ImportUtility.Activate();
        }
        private void ShowRadishUtility()
        {
            var filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            var radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
            if (radishdir == null)
            {
                Logger.LogString("ERROR! No radish mod directory found.\r\n", Logtype.Error);
                return;
            }


            if (RadishUtility == null || RadishUtility.IsDisposed)
            {
                RadishUtility = new frmRadish();
                RadishUtility.Show(dockPanel, DockState.Document);
            }

            RadishUtility.Activate();
        }
        private void ShowImagePreview()
        {
            if (ImagePreview == null || ImagePreview.IsDisposed)
            {
                ImagePreview = new frmImagePreview();
                ImagePreview.Show(dockPanel, DockState.Document);
            }
            ImagePreview.Activate();
        }
        private void ShowScriptPreview()
        {
            if (ScriptPreview == null || ScriptPreview.IsDisposed)
            {
                ScriptPreview = new frmScriptEditor();
                ScriptPreview.Show(dockPanel, DockState.Document);
            }
            
            ScriptPreview.Activate();
        }

        private void newModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewMod();
        }

        public void createNewMod()
        {
            var dlg = new SaveFileDialog
            {
                Title = @"Create Witcher 3 Mod Project",
                Filter = @"Witcher 3 Mod|*.w3modproj",
                InitialDirectory = MainController.Get().Configuration.InitialModDirectory
            };

            while (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains(' '))
                {
                    MessageBox.Show(
                        @"The mod path should not contain spaces because wcc_lite.exe will have trouble with that.",
                        "Invalid path");
                    continue;
                }

                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(dlg.FileName);
                var modname = Path.GetFileNameWithoutExtension(dlg.FileName);
                var dirname = Path.GetDirectoryName(dlg.FileName);

                var moddir = Path.Combine(dirname, modname);
                try
                {
                    Directory.CreateDirectory(moddir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create mod directory: \n" + moddir + "\n\n" + ex.Message);
                    return;
                }

                ActiveMod = new W3Mod
                {
                    FileName = dlg.FileName,
                    Name = modname
                };
                // create default directories
                ActiveMod.CreateDefaultDirectories();
                ResetWindows();

                // detect if radish-mod
                var filedir = new DirectoryInfo(MainController.Get().ActiveMod.ProjectDirectory).Parent;
                var radishdir = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat")?.Directory;
                if (radishdir != null)
                {
                    switch (MessageBox.Show(
                        "WolvenKit detected a radish mod project installation in this directory. Would you like to add the radish files to the Mod Project?",
                        "Radish Tool Integration",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        default:
                            return;
                        case DialogResult.Yes:
                            {
                                if (!Directory.Exists(ActiveMod.RadishDirectory))
                                    Directory.CreateDirectory(ActiveMod.RadishDirectory);
                                //move radish files into Modfiledir
                                foreach (var file in radishdir.GetFiles("*", SearchOption.TopDirectoryOnly))
                                {
                                    File.Move(file.FullName, Path.Combine(ActiveMod.RadishDirectory, file.Name));
                                }
                                foreach (var dir in radishdir.GetDirectories("*", SearchOption.TopDirectoryOnly))
                                {
                                    if (dir.FullName == ActiveMod.ProjectDirectory)
                                        continue;
                                    Directory.Move(dir.FullName, Path.Combine(ActiveMod.RadishDirectory, dir.Name));
                                }
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                }
                SaveMod();
                AddOutput("\"" + ActiveMod.Name + "\" sucesfully created and loaded!\n", Logtype.Success);
                break;
            }
        }

        private void SaveMod()
        {
            if (ActiveMod != null)
            {
                if(ActiveMod.LastOpenedFiles != null)
                    ActiveMod.LastOpenedFiles = OpenDocuments.Select(x => x.File.FileName).ToList();
                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(ActiveMod.FileName, FileMode.Create, FileAccess.Write);
                ser.Serialize(modfile, ActiveMod);
                modfile.Close();
            }
        }

        public IDockContent DeserializeDockContent(string persistString)
        {
            if (persistString == typeof(frmOutput).ToString())
                return Output;
            else if(persistString == typeof(frmModExplorer).ToString())
                return ModExplorer;
            else
            {
                return null;
            }
        }

        public void openMod(string file = "")
        {
            try
            {
                //Opening the file from a dialog
                if (file == "")
                {
                    var dlg = new OpenFileDialog
                    {
                        Title = "Open Witcher 3 Mod Project",
                        Filter = "Witcher 3 Mod|*.w3modproj",
                        InitialDirectory = MainController.Get().Configuration.InitialModDirectory
                    };
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        file = dlg.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                var old = XDocument.Load(file);
                if (old.Descendants("InstallAsDLC").Any())
                {
                    //This is an old "Sarcen's W3Edit"-project. We need to upgrade it.
                    //Put the files into their respective folder.
                    switch (MessageBox.Show(
                        "The project you are opening has been made with an older version of Wolven Kit or Sarcen's Witcher 3 Edit.\nIt needs to be upgraded for use with Wolvenkit.\nTo load as a mod please press yes. To load as a DLC project please press no.\n You can manually do the upgrade if you check the project structure: https://github.com/Traderain/Wolven-kit/wiki/Project-structure press cancel if you desire to do so. This may not always work but I tried my best.",
                        "Out of date project", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        default:
                            return;
                        case DialogResult.Yes:
                            {
                                Commonfunctions.DirectoryMove(Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files"), Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files", "Mod","Bundle"));
                                break;
                            }
                        case DialogResult.No:
                            {
                                Commonfunctions.DirectoryMove(Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files"), Path.Combine(Path.GetDirectoryName(file), old.Root.Element("Name").Value, "files", "DLC","Bundle"));
                                break;
                            }

                    }
                    //Upgrade the project xml
                    var nw = new W3Mod
                    {
                        Name = old.Root.Element("Name")?.Value,
                        FileName = file,
                        version = "1.0"
                    };
                    
                    File.Delete(file);
                    XmlSerializer xs = new XmlSerializer(typeof(W3Mod));
                    var mf = new FileStream(file, FileMode.Create);
                    xs.Serialize(mf, nw);
                    mf.Close();
                }

                //Close all docs
                OpenDocuments.ToList().ForEach(x => x.Close());

                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);
                

                //Loading the project
                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(file, FileMode.Open, FileAccess.Read);
                ActiveMod = (W3Mod)ser.Deserialize(modfile);
                ActiveMod.FileName = file;
                ActiveMod.CreateDefaultDirectories();
                modfile.Close();
                ResetWindows();
                AddOutput("\"" + ActiveMod.Name + "\" loaded successfully!\n", Logtype.Success);
                MainController.Get().ProjectStatus = "Ready";

                //Hash all filepaths
                var relativepaths = ActiveMod.ModFiles
                    .Select(_ => _.Substring(_.IndexOf(Path.DirectorySeparatorChar) + 1))
                    .ToList();
                Cr2wResourceManager.Get().RegisterAndWriteCustomPaths(relativepaths);

                //Update the recent files.
                var files = new List<string>();
                if (File.Exists("recent_files.xml"))
                {
                    var doc = XDocument.Load("recent_files.xml");
                    files.AddRange(doc.Descendants("recentfile").Take(4).Select(x => x.Value));
                }
                files.Add(file);
                new XDocument(new XElement("RecentFiles", files.Distinct().Select(x => new XElement("recentfile", x)))).Save("recent_files.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to upgrade the project!\n" + ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (ActiveMod?.LastOpenedFiles != null)
            {
                foreach (var doc in ActiveMod.LastOpenedFiles)
                {
                    if (File.Exists(doc))
                    {
                        LoadDocument(doc);
                    }
                }
            }
        }

        /// <summary>
        /// Scans the given archivemanagers for a file. If found, extracts it to the project.
        /// </summary>
        /// <param name="depotpath">Filename.</param>
        /// <param name="managers">The managers.</param>
        private bool AddToMod(WitcherListViewItem item, bool skipping, List<IWitcherArchive> managers, bool AddAsDLC)
        {
            bool skip = skipping;
            var depotpath = item.ExplorerPath ?? item.FullPath ?? "";
            foreach (var manager in managers.Where(manager => depotpath.StartsWith(Path.Combine("Root", manager.TypeName))))
            {
                if (manager.Items.Any(x => x.Value.Any(y => y.Name == item.FullPath)))
                {
                    var archives = manager.FileList.Where(x => x.Name == item.FullPath).Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.FileName, y));
                    string filename;
                    if (archives.First().Value.Bundle.TypeName == MainController.Get().CollisionManager.TypeName ||
                        archives.First().Value.Bundle.TypeName == MainController.Get().TextureManager.TypeName)
                    {
                        filename = Path.Combine(ActiveMod.RawDirectory, AddAsDLC ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName, "dlc", ActiveMod.Name, item.FullPath) : Path.Combine("Mod", archives.First().Value.Bundle.TypeName, item.FullPath));
                    }
                    else
                    {
                        filename = Path.Combine(ActiveMod.FileDirectory, AddAsDLC ? Path.Combine("DLC", archives.First().Value.Bundle.TypeName, "dlc", ActiveMod.Name, item.FullPath) : Path.Combine("Mod", archives.First().Value.Bundle.TypeName, item.FullPath));
                    }
                    if (archives.Count() > 1)
                    {

                        var dlg = new frmExtractAmbigious(archives.Select(x => x.Key).ToList());
                        if (!skip)
                        {
                            var res = dlg.ShowDialog();
                            skip = dlg.Skip;
                            if (res == DialogResult.Cancel)
                            {
                                return skip;
                            }
                        }
                        var selectedBundle = archives.FirstOrDefault(x => x.Key == dlg.SelectedBundle).Value;
                        try
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(filename));
                            if (File.Exists(filename))
                            {
                                File.Delete(filename);
                            }
                            selectedBundle.Extract(new BundleFileExtractArgs(filename, MainController.Get().Configuration.UncookExtension));
                        }
                        catch { }
                        return skip;
                    }

                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(filename));
                        if (File.Exists(filename))
                        {
                            File.Delete(filename);
                        }

                        archives.FirstOrDefault().Value.Extract(new BundleFileExtractArgs(filename, MainController.Get().Configuration.UncookExtension));
                    }
                    catch (Exception ex)
                    {
                        AddOutput(ex.ToString(),Logtype.Error);
                    }
                    return skip;
                }
            }
            return skip;
        }

        /// <summary>
        /// Opens the asset browser in the background
        /// </summary>
        /// <param name="loadmods">Load the mod files</param>
        /// <param name="browseToPath">The path to browse to</param>
        private void AddModFile(bool loadmods, string browseToPath = "")
        {
            if (ActiveMod == null)
                return;
            if (Application.OpenForms.OfType<frmAssetBrowser>().Any())
            {
                var frm = Application.OpenForms.OfType<frmAssetBrowser>().First();
                if (!string.IsNullOrEmpty(browseToPath))
                    frm.OpenPath(browseToPath);
                frm.WindowState = FormWindowState.Minimized;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
                return;
            }
            var managers = new List<IWitcherArchive>();
            var exeDir = Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath);
            if (loadmods)
            {
                if (MainController.Get().ModBundleManager != null)
                {
                    MainController.Get().ModBundleManager.LoadModsBundles(exeDir); // load mods added after WK was started
                    managers.Add(MainController.Get().ModBundleManager);
                }
                if (MainController.Get().ModSoundManager != null)
                {
                    MainController.Get().ModSoundManager.LoadModsBundles(exeDir);
                    managers.Add(MainController.Get().ModSoundManager);
                }
                if (MainController.Get().ModTextureManager != null)
                {
                    MainController.Get().ModTextureManager.LoadModsBundles(exeDir);
                    managers.Add(MainController.Get().ModTextureManager);
                }
            }
            else
            {
                if (MainController.Get().BundleManager != null) managers.Add(MainController.Get().BundleManager);
                if (MainController.Get().SoundManager != null) managers.Add(MainController.Get().SoundManager);
                if (MainController.Get().TextureManager != null) managers.Add(MainController.Get().TextureManager);
                if (MainController.Get().CollisionManager != null) managers.Add(MainController.Get().CollisionManager);
                if (MainController.Get().SpeechManager != null) managers.Add(MainController.Get().SpeechManager);
            }
            
            //if (MainController.Get().ModCollisionManager != null) managers.Add(MainController.Get().ModCollisionManager);

            var explorer = new frmAssetBrowser(managers);
            explorer.RequestFileAdd += Assetbrowser_FileAdd;
            explorer.OpenPath(browseToPath);
            Point location = dockPanel.Location;
            location.X += (dockPanel.Size.Width / 2 - explorer.Size.Width / 2);
            location.Y += (dockPanel.Size.Height / 2 - explorer.Size.Height / 2);
            Rectangle floatWindowBounds = new Rectangle() { Location=location, Width = 827, Height = 564 };
            explorer.Show(dockPanel, floatWindowBounds);
            
        }

        /// <summary>
        /// Closes all the "file documents", resets modexplorer and clears the output.
        /// </summary>
        private void ResetWindows()
        {
            CloseWindows();

            ShowModExplorer();
            ShowConsole();
            ShowOutput();
            ClearOutput();
        }

        /// <summary>
        /// Closes and saves all the "file documents", resets modexplorer.
        /// </summary>
        private void CloseWindows()
        {
            if (ActiveMod != null)
            {
                foreach (var t in OpenDocuments.ToList())
                {
                    t.SaveFile();
                    t.Close();
                }
            }
            ModExplorer?.Close();
            ModExplorer = null;
            Output?.Close();
            Output = null;
            Console?.Close();
            Console = null;
            ImportUtility?.Close();
            ImportUtility = null;
            RadishUtility?.Close();
            RadishUtility = null;
            ScriptPreview = null;
            ScriptPreview?.Close();
            ImagePreview = null;
            ImagePreview?.Close();

            foreach (var t in OpenScripts.ToList())
            {
                t.SaveFile();
                t.Close();
            }
            foreach (var t in OpenImages.ToList())
            {
                t.Close();
            }

            foreach (var window in dockPanel.FloatWindows.ToList())
            {
                window.Dispose();
                window.Close();
            }
        }

        /// <summary>
        /// Closes and saves all the "file documents", resets modexplorer.
        /// </summary>
        private void ReopenWindows()
        {
            if (ActiveMod?.LastOpenedFiles != null)
            {
                foreach (var doc in ActiveMod.LastOpenedFiles)
                {
                    if (File.Exists(doc))
                    {
                        LoadDocument(doc);
                    }
                }
            }
            ShowModExplorer();
            ShowConsole();
            ShowOutput();
        }

        private void ShowModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
            {
                ModExplorer = new frmModExplorer(Logger);
                ModExplorer.Show(dockPanel, DockState.DockLeft);
                
                ModExplorer.RequestFileOpen += ModExplorer_RequestFileOpen;
                ModExplorer.RequestFileDelete += ModExplorer_RequestFileDelete;
                ModExplorer.RequestAssetBrowser += ModExplorer_RequestAssetBrowser;
                ModExplorer.RequestFileRename += ModExplorer_RequestFileRename;
                ModExplorer.RequestFileCook += ModExplorer_RequestFileCook;
                ModExplorer.RequestFileDumpfile += ModExplorer_RequestFileDumpfile;
                ModExplorer.RequestFastRender += ModExplorer_RequestFastRender;
            }
            ModExplorer.Activate();
        }

        public void ScanAndRegisterCustomClasses()
        {
            if (ActiveMod == null)
                return;

            foreach (var wsfile in ActiveMod.ModFiles.Where(_ => Path.GetExtension(_) == ".ws"))
            {
                string fullpath = Path.Combine(ActiveMod.ModDirectory, wsfile);
                var lines = File.ReadAllLines(fullpath);
                foreach (var line in lines)
                {
                    var reg = new Regex(@"^.*(?:class)\s+(\w+)\s*(.*)");
                    var match = reg.Match(line);
                    if (match.Success)
                    {
                        // check for extends
                        string classname = match.Groups[1].Value;
                        string extends = match.Groups[2].Value;
                        if (!string.IsNullOrEmpty(extends))
                        {
                            var ireg = new Regex(@"^.*(?:extends)\s+(\w+)");
                            var imatch = ireg.Match(extends);
                            if (imatch.Success)
                            {
                                string parent = imatch.Groups[1].Value;
                                if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                                {
                                    CR2WTypeManager.Get().RegisterAs(classname, parent);
                                    AddOutput($"Registering custom class {classname} as {parent}.\r\n", Logtype.Success);
                                }
                            }
                            else
                            {
                                if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                                {
                                    CR2WTypeManager.Get().Register(classname, new CVector(null));
                                    AddOutput($"Registering custom class {classname} as CVector.\r\n", Logtype.Success);
                                }
                            }
                        }
                        else
                        {
                            if (!CR2WTypeManager.Get().AvailableTypes.Contains(classname))
                            {
                                CR2WTypeManager.Get().Register(classname, new CVector(null));
                                AddOutput($"Registering custom class {classname} as CVector.\r\n", Logtype.Success);
                            }
                        }
                    }
                }
            }
        }

        internal class LoadFileArgs
        {
            public string Filename { get; set; }
            public MemoryStream Stream { get; set; }
            public frmCR2WDocument Doc { get; set; }
            public bool SuppressErrors { get; set; }
            public LoadFileArgs(string filename, frmCR2WDocument doc, MemoryStream stream = null, bool suppressErrors = false)
            {
                Filename = filename;
                Doc = doc;
                if (stream != null)
                    Stream = stream;
                SuppressErrors = suppressErrors;
            }
        }

        /// <summary>
        /// Opens a document in the background
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="memoryStream"></param>
        /// <param name="suppressErrors"></param>
        public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
        {
            if (memoryStream == null && !File.Exists(filename))
                return null;

            foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
            {
                t.Activate();
                return null;
            }

            // check and register custom classes
            // we do it here because people might edit the .ws files at any time
            // todo: what do I do if the .ws file has been edited while the cr2w file is open?
            ScanAndRegisterCustomClasses();


            var doc = new frmCR2WDocument();
            OpenDocuments.Add(doc);

            WorkerLoadFileSetup(new LoadFileArgs(filename, doc, memoryStream, suppressErrors));

            // wait for the backgroundworker to finish
            // this is not good practice since I am blocking
            // but there are some functions (the renderer etc) that rely on a return document
            // also I am blocking with the progress form regardless so it's already bad
            if (MainBackgroundWorker.IsBusy)
            {
                throw new NotImplementedException();
            }
            else
            {
                
            }
            var ret = HACK_bwform;
            HACK_bwform = null;
            return ret;
        }


        /// <summary>
        /// Setup the backgroundworker and progress forms (Main thread)
        /// </summary>
        /// <param name="args"></param>
        private void WorkerLoadFileSetup(LoadFileArgs args)
        {
            MainController.Get().ProjectStatus = "Busy";

            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {

                m_frmProgress = new frmProgress()
                {
                    Text = "Loading File...",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.None
                };

                workerAction = WorkerLoadFile;
                MainBackgroundWorker.RunWorkerAsync(args);
                DialogResult dr = m_frmProgress.ShowDialog();


            }
            else
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);

            MainController.Get().ProjectStatus = "Ready";
        }

        /// <summary>
        /// This runs on a worker thread in the background and 
        /// returns the LoadFileArgs it reveived if succesfull, null otherwise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        protected private object WorkerLoadFile(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;
            if (!(arg is LoadFileArgs))
                throw new NotImplementedException();
            var Args = (LoadFileArgs)arg;

            var doc = Args.Doc;
            var filename = Args.Filename;
            var suppressErrors = Args.SuppressErrors;

            try
            {
                if (Args.Stream != null)
                    Args.Doc.LoadFile(Args.Filename, Args.Stream);
                else
                    Args.Doc.LoadFile(Args.Filename);
            }
            catch (InvalidFileTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                OpenDocuments.Remove(doc);
                //doc.Dispose();
                return null;
            }
            catch (MissingTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                OpenDocuments.Remove(doc);
                //doc.Dispose();
                return null;
            }
            catch (FormatException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                OpenDocuments.Remove(doc);
                //doc.Dispose();
                throw ex;
                return null;
            }

            workerCompletedAction = WorkerLoadFileCompleted;
            return Args;
        }

        /// <summary>
        /// This is called if the backgroundworker has completed sucessfully. 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        protected private object WorkerLoadFileCompleted(object arg)
        {
            if (!(arg is LoadFileArgs))
                throw new NotImplementedException();
            var Args = (LoadFileArgs)arg;
            var doc = Args.Doc;
            var filename = Args.Filename;

            #region SetupFile
            // Backgroundwork Start
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            switch (Path.GetExtension(filename))
            {
                case ".w2scene":
                case ".w2quest":
                case ".w2phase":
                    {
                        doc.flowDiagram = new frmChunkFlowDiagram();
                        doc.flowDiagram.OnOutput += OnOutput;
                        doc.flowDiagram.File = doc.File;
                        doc.flowDiagram.DockAreas = DockAreas.Document;

                        doc.flowDiagram.OnSelectChunk += doc.frmCR2WDocument_OnSelectChunk;
                        doc.flowDiagram.Show(doc.FormPanel, DockState.Document);
                        break;
                    }

                case ".journal":
                    {
                        doc.JournalEditor = new frmJournalEditor
                        {
                            File = doc.File,
                            DockAreas = DockAreas.Document
                        };
                        doc.JournalEditor.Show(doc.FormPanel, DockState.Document);
                        break;
                    }
                case ".xbm":
                    {
                        doc.ImageViewer = new frmImagePreview
                        {
                            DockAreas = DockAreas.Document
                        };
                        doc.ImageViewer.Show(doc.FormPanel, DockState.Document);
                        CR2WExportWrapper imagechunk = doc.File?.chunks?.FirstOrDefault(_ => _.data.Type.Contains("CBitmapTexture"));
                        doc.ImageViewer.SetImage(imagechunk);
                        break;
                    }
                case ".w2mesh":
                    {
                        if (bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()))
                        {
                            try
                            {
                                doc.RenderViewer = new Render.frmRender
                                {
                                    LoadDocument = LoadDocumentAndGetFile,
                                    MeshFile = doc.File,
                                    DockAreas = DockAreas.Document,
                                    renderHelper = new Render.RenderHelper(MainController.Get().ActiveMod, MainController.Get().Logger)
                                };
                                doc.RenderViewer.Show(doc.FormPanel, DockState.Document);
                            }
                            catch (Exception ex)
                            {
                                AddOutput(ex.ToString());
                            }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (doc.File.embedded.Count > 0)
            {
                doc.embeddedFiles = new frmEmbeddedFiles
                {
                    File = doc.File,
                    DockAreas = DockAreas.Document
                };
                doc.embeddedFiles.Show(doc.FormPanel, DockState.Document);
            }
            doc.Activated += doc_Activated;
            doc.Show(dockPanel, DockState.Document);
            doc.FormClosed += doc_FormClosed;

            var output = new StringBuilder();

            if (doc.File.UnknownTypes.Any())
            {
                ShowConsole();
                ShowOutput();

                output.Append(doc.FileName + ": contains " + doc.File.UnknownTypes.Count + " unknown type(s):\n");
                foreach (var unk in doc.File.UnknownTypes)
                {
                    output.Append("\"" + unk + "\", \n");
                }

                output.Append("-------\n\n");
            }

            var hasUnknownBytes = false;

            foreach (var t in doc.File.chunks.Where(t => t.unknownBytes?.Bytes != null && t.unknownBytes.Bytes.Length > 0))
            {
                output.Append(t.Name + " contains " + t.unknownBytes.Bytes.Length + " unknown bytes. \n");
                hasUnknownBytes = true;
            }

            if (hasUnknownBytes)
                output.Append("-------\n\n");

            output.Append($"File {filename} loaded in: {stopwatch.Elapsed}\n\n");
            stopwatch.Stop();

            AddOutput(output.ToString(), Logtype.Important);
            return doc;
            #endregion
        }

        public CR2WFile LoadDocumentAndGetFile(string filename)
        {
            foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
                return t.File;
            var activedoc = OpenDocuments.FirstOrDefault(d => d.IsActivated);
            var doc = LoadDocument(filename);
            activedoc.Activate();
            return doc != null ? doc.File : null;
        }

        async Task DumpFile(string folder, string outfolder)
        {
            try
            {
                var cmd = new Wcc_lite.dumpfile()
                {
                    Dir = folder,
                    Out = outfolder
                };
                await Task.Run(() => WccHelper.RunCommand(cmd));
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File dumped succesfully!";

        }

        async Task ImportFile(string infile, string outfile)
        {
            try
            {
                var importwdir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.WccLite), "WolvenKitWorkingDir");
                if(Directory.Exists(importwdir))
                    Directory.Delete(importwdir,true);
                Directory.CreateDirectory(importwdir);
                File.Copy(infile,Path.Combine(importwdir,Path.GetFileName(infile)));
                MainController.Get().ProjectStatus = "Importing file";
                if (!Directory.Exists(Path.GetDirectoryName(outfile)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(outfile));
                }
                var import = new Wcc_lite.import()
                {
                    Depot = MainController.DepotDir,
                    File = Path.Combine(importwdir, Path.GetFileName(infile)),
                    Out = outfile
                };
                await Task.Run(() => WccHelper.RunCommand(import));
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File imported succesfully!";

        }

        #endregion //Methods

        #region  Control events
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Load/Setup the config
            var Exit = false;
            while (!File.Exists(MainController.Get().Configuration.ExecutablePath))
            {
                var sets = new frmSettings();
                if (sets.ShowDialog() != DialogResult.OK)
                {
                    Exit = true;
                    break;
                }
                else
                    MainController.Get().ProjectStatus = "Ready";
            }

            if (Exit)
            {
                Visible = false;
                Close();
            }

            //Start loading if everything is set up.
            var frmload = new frmLoading();
            frmload.ShowDialog();

            WccHelper = MainController.Get().WccHelper;
            Logger = MainController.Get().Logger;
            Logger.PropertyChanged += LoggerUpdated;

            //Update check should be after we are all set up. It goes on in the background.
            AutoUpdater.Start("https://raw.githubusercontent.com/Traderain/Wolven-kit/master/Update.xml");
            richpresenceworker.RunWorkerAsync();
        }
        private void richpresenceworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string project = "non";

            Discord.EventHandlers handlers = new Discord.EventHandlers();
            Discord.Initialize("482179494862651402", handlers);
            while (!richpresenceworker.CancellationPending)
            {
                Thread.Sleep(1000); 
                if (MainController.Get().ActiveMod != null)
                {
                    if (project != MainController.Get().ActiveMod.Name.ToString())
                    {
                        project = MainController.Get().ActiveMod.Name.ToString();
                        Discord.RichPresence rp = new Discord.RichPresence();
                        rp.state = "";
                        rp.details = "Developing " + project;
                        rp.largeImageKey = "logo_wkit";
                        Discord.UpdatePresence(rp);
                    }
                }
            }
        }

        public EventHandler errored;

        private void richpresenceworker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void richpresenceworker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (sender is frmCR2WDocument)
            {
                doc_Activated(sender, e);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = "Please select a location to save the json dump of the cr2w file";
                sf.Filter = "JSON Files | *.json";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    throw new NotImplementedException("TODO");
                }
            }
        }

        private void extractCollisioncacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select the collision.cache file to extract";
                of.Filter = "Collision caches | collision.cache";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new FolderBrowserDialog())
                    {
                        sf.Description = "Please specify a location to save the extracted files";
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            var ccf = new Cache.CollisionCache(of.FileName);
                            var outdir = sf.SelectedPath.EndsWith("\\") ? sf.SelectedPath : sf.SelectedPath + "\\";
                            foreach (var f in ccf.Files)
                            {
                                string extractedfilename = Path.ChangeExtension(Path.Combine(outdir, f.Name), "apb");
                                f.Extract(new BundleFileExtractArgs(extractedfilename, MainController.Get().Configuration.UncookExtension));
                                AddOutput($"Extracted {extractedfilename}.\n");
                            }
                        }
                    }
                }
            }
        }

        private async void fbxWithCollisionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"For this to work make sure your model has either of both of these layers:
_tri - trimesh
_col - for simple stuff like boxes and spheres","Information about importing models",MessageBoxButtons.OK,MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your fbx file with _col or _tri layers";
                of.Filter = "FBX files | *.fbx";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 mesh file | *.w2mesh";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            await ImportFile(of.FileName, sf.FileName);
                        }
                    }
                }
            }
        }

        private async void dumpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This will generate a file which will show what wcc_lite sees from a file. Please keep in mind this doesn't always work","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            using (var of = new FolderBrowserDialog())
            {
                of.Description = "Select the folder to dump";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new FolderBrowserDialog())
                    {
                        sf.Description = "Please specify a location to save the dumped file";
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            await DumpFile(of.SelectedPath.EndsWith("\\") ? of.SelectedPath : of.SelectedPath + "\\",
                                sf.SelectedPath.EndsWith("\\") ? sf.SelectedPath : sf.SelectedPath + "\\");
                        }
                    }
                }
            }
        }

        private async void nvidiaClothFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your cloth file for importing";
                of.Filter = "APB files | *.apb";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 cloth file | *.redcloth";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            await ImportFile(of.FileName, sf.FileName);
                        }
                    }
                }
            }
        }

        private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (dockPanel.ActiveDocument is frmCR2WDocument)
            {
                doc_Activated(dockPanel.ActiveDocument, e);
            }
        }

        private void doc_Activated(object sender, EventArgs e)
        {
            ActiveDocument = (frmCR2WDocument)sender;
        }

        private void doc_FormClosed(object sender, FormClosedEventArgs e)
        {
            var doc = (frmCR2WDocument)sender;
            OpenDocuments.Remove(doc);

            if (doc == ActiveDocument)
            {
                ActiveDocument = null;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            richpresenceworker.CancelAsync();
            if (MainController.Get().ProjectUnsaved)
            {
                var res = MessageBox.Show("There are unsaved changes in your project. Would you like to save them?", "WolvenKit",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    saveAllFiles();
                    SaveMod();
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {

                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            var config = UIController.Get().Configuration;

            config.MainState = WindowState;

            WindowState = FormWindowState.Normal;
            config.MainSize = Size;
            config.MainLocation = Location;

            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            ResetWindows();
            var config = UIController.Get().Configuration;
            Size = config.MainSize;
            Location = config.MainLocation;
            WindowState = config.MainState;
            try
            {
                dockPanel.LoadFromXml(
                    Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"),
                    DeserializeDockContent);
            }
            catch
            {
                // ignored
            }

            if (!string.IsNullOrEmpty(MainController.Get().InitialModProject))
                openMod(MainController.Get().InitialModProject);
            else if (!string.IsNullOrEmpty(MainController.Get().InitialWKP))
            {
                using (var pi = new frmInstallPackage(MainController.Get().InitialWKP))
                    pi.ShowDialog();
            }
            else
            {
                using(var ws = new frmWelcome(this))
                {
                    ws.ShowDialog();
                }
            }
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Add File to Project" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                try
                {
                    FileInfo fi = new FileInfo(dlg.FileName);
                    var newfilepath = Path.Combine(ActiveMod.FileDirectory, fi.Name);
                    if (File.Exists(newfilepath))
                        newfilepath = $"{newfilepath.TrimEnd(fi.Extension.ToCharArray())} - copy{fi.Extension}";
                    fi.CopyTo(newfilepath, false);
                }
                catch (Exception)
                {
                }
            }
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Every last bit helps and everything donated is distributed between the core developers evenly.","Thank you",MessageBoxButtons.OK,MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://www.patreon.com/bePatron?u=5458437");
        }

        private void Assetbrowser_FileAdd(object sender, Tuple<List<IWitcherArchive>, List<WitcherListViewItem>,bool> Details)
        {
            
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MainController.Get().ProjectStatus = "Busy";

            // Backgroundworker
            if (!MainBackgroundWorker.IsBusy)
            {
                ModExplorer.PauseMonitoring();
                
                m_frmProgress = new frmProgress()
                {
                    Text = "Adding Assets",
                    StartPosition = FormStartPosition.CenterParent,
                };

                workerAction = WorkerAssetBrowserAddFiles;
                MainBackgroundWorker.RunWorkerAsync(Details);

                DialogResult dr = m_frmProgress.ShowDialog(this);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        {
                            MainBackgroundWorker.CancelAsync();
                            m_frmProgress.Cancel = true;
                            break;
                        }
                    case DialogResult.None:
                    case DialogResult.OK:
                    case DialogResult.Abort:
                    case DialogResult.Retry:
                    case DialogResult.Ignore:
                    case DialogResult.Yes:
                    case DialogResult.No:
                    default:
                        break;
                }
                ModExplorer.ResumeMonitoring();
                SaveMod();
            }
            else
                Logger.LogString("The background worker is currently busy.\r\n", Logtype.Error);
           
            MainController.Get().ProjectStatus = "Ready";
            
        }
        protected object WorkerAssetBrowserAddFiles(object sender, DoWorkEventArgs e)
        {
            object arg = e.Argument;
            if (!(arg is Tuple<List<IWitcherArchive>, List<WitcherListViewItem>, bool>))
                throw new NotImplementedException();
            var Details = (Tuple<List<IWitcherArchive>, List<WitcherListViewItem>, bool>)arg;
            BackgroundWorker bwAsync = sender as BackgroundWorker;


            var skipping = false;
            var count = Details.Item2.Count;
            for (int i = 0; i < count; i++)
            {
                if (bwAsync.CancellationPending || m_frmProgress.Cancel)
                {
                    Logger.LogString("Background worker cancelled.\r\n", Logtype.Error);
                    e.Cancel = true;
                    return false;
                }

                WitcherListViewItem item = Details.Item2[i];
                skipping = AddToMod(item, skipping, Details.Item1, Details.Item3);


                int percentprogress = (int)((float)i / (float)count * 100.0);
                MainBackgroundWorker.ReportProgress(percentprogress, item.Text);
            }
            return true;
        }
        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private async void ModExplorer_RequestFileCook(object sender, RequestFileArgs e)
        {
            var filename = e.File;
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                return;
            string dir;
            if (File.Exists(fullpath))
                dir = Path.GetDirectoryName(fullpath);
            else
                dir = fullpath;
            string reldir = dir.Substring(ActiveMod.FileDirectory.Length + 1);

            // Trim working directories in path
            var reg = new Regex(@"^(Raw|Mod)\\(.*)");
            var match = reg.Match(reldir);
            if (match.Success)
                reldir = match.Groups[2].Value;
            reg = new Regex(@"^(CollisionCache)\\(.*)");
            match = reg.Match(reldir);
            if (match.Success)
                reldir = match.Groups[2].Value;
            reg = new Regex(@"^(TextureCache)\\(.*)");
            match = reg.Match(reldir);
            if (match.Success)
                reldir = match.Groups[2].Value;
            reg = new Regex(@"^(Uncooked)\\(.*)");
            match = reg.Match(reldir);
            if (match.Success)
                reldir = match.Groups[2].Value;

            // create cooked mod Dir
            var cookedModDir = Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName, reldir);
            if (!Directory.Exists(cookedModDir))
            {
                Directory.CreateDirectory(cookedModDir);
            }

            // lazy check for existing files in Active Mod
            var filenames = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
                .Select(_ => Path.GetFileName(_));
            var existingfiles = Directory.GetFiles(cookedModDir, "*.*", SearchOption.AllDirectories)
                .Select(_ => Path.GetFileName(_));

            if (existingfiles.Intersect(filenames).Any())
            {
                if (MessageBox.Show(
                     "Some of the files you are about to cook already exist in your mod. These files will be overwritten. Are you sure you want to permanently overwrite them?"
                     , "Confirmation", MessageBoxButtons.YesNo
                 ) != DialogResult.Yes)
                {
                    return;
                }
            }

            try
            {
                var cook = new Wcc_lite.cook()
                {
                    Platform = platform.pc,
                    mod = dir,
                    basedir = dir,
                    outdir = cookedModDir
                };
                await Task.Run(() => WccHelper.RunCommand(cook));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cooking files.");
            }
        }

        private async void ModExplorer_RequestFileDumpfile(object sender, RequestFileArgs e)
        {
            var filename = e.File;
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                return;
            string dir;
            if (File.Exists(fullpath))
                dir = Path.GetDirectoryName(fullpath);
            else
                dir = fullpath;


            await DumpFile(dir, dir);

        }

        private void ModExplorer_RequestFileRename(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            if (!File.Exists(filename))
                return;

            var dlg = new frmRenameDialog() { FileName = filename };
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != filename)
            {
                var newfullpath = Path.Combine(ActiveMod.FileDirectory, dlg.FileName);

                if (File.Exists(newfullpath))
                    return;

                // Rename file in file structure
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
                }
                catch
                {
                }

                File.Move(filename, newfullpath);
            }
            MainController.Get().ProjectStatus = "File renamed";
        }

        private void ModExplorer_RequestAssetBrowser(object sender, RequestFileArgs e)
        {
            AddModFile(false, e.File);
        }

        private void ModExplorer_RequestFileDelete(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            if (MessageBox.Show(
                     "Are you sure you want to permanently delete this?", "Confirmation", MessageBoxButtons.OKCancel
                 ) == DialogResult.OK)
            {
                removeFromMod(filename);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new frmSettings();
            settings.ShowDialog();
        }

        private void modExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModExplorer();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbtOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Open CR2W File" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                LoadDocument(dlg.FileName);
            }
        }

        private void tbtSave_Click(object sender, EventArgs e)
        {
            saveActiveFile();
        }

        private void saveActiveFile()
        {
            if (ActiveDocument != null && !ActiveDocument.IsDisposed)
            {
                saveFile(ActiveDocument);
                AddOutput("Saved!\n", Logtype.Success);
            }

        }

        private void tbtSaveAll_Click(object sender, EventArgs e)
        {
            saveAllFiles();
            MainController.Get().ProjectStatus = "Item saved";
            AddOutput("Saved!\n", Logtype.Success);
        }

        


        private void tbtNewMod_Click(object sender, EventArgs e)
        {
            createNewMod();
        }

        private void tbtOpenMod_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private void addFileFromBundleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModFile(false);
        }

        private void modSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;
            //With this cloned it won't get modified when we change it in dlg
            var oldmod = (W3Mod)ActiveMod.Clone();
            using (var dlg = new frmModSettings())
            {
                dlg.Mod = ActiveMod;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (oldmod.Name != dlg.Mod.Name)
                    {
                        try
                        {
                            UIController.Get()?.Window?.ModExplorer?.StopMonitoringDirectory();
                            //Close all docs so they won't cause problems
                            OpenDocuments.ToList().ForEach(x => x.Close());
                            //Move the files directory
                            Directory.Move(oldmod.ProjectDirectory, Path.Combine(Path.GetDirectoryName(oldmod.ProjectDirectory), dlg.Mod.Name));
                            //Delete the old directory
                            if (Directory.Exists(oldmod.ProjectDirectory))
                                Commonfunctions.DeleteFilesAndFoldersRecursively(oldmod.ProjectDirectory);
                            //Delete the old mod project file
                            if (File.Exists(oldmod.FileName))
                                File.Delete(oldmod.FileName);
                        }
                        catch (System.IO.IOException ex)
                        {
                            MessageBox.Show("Please check that you don't have Windows Explorer open at the old mod's path and that no folder/mod with that name already exists.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Save the new settings and update the title
                    UpdateTitle();
                    SaveMod();
                    if (File.Exists(MainController.Get().ActiveMod?.FileName))
                    {
                        openMod(MainController.Get().ActiveMod?.FileName);
                    }
                    CommonUIFunctions.SendNotification("Succesfully updated mod settings!");
                }
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cf = new frmAbout())
                cf.ShowDialog();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Title = "Open CR2W File" };
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                LoadDocument(dlg.FileName);
            }
        }

        private void packageInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Filter = "WolvenKit Package | *.wkp";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using(var pi = new frmInstallPackage(of.FileName))
                        pi.ShowDialog();
                }
                else
                    CommonUIFunctions.SendNotification("Invalid file!");
            }
        }

        private void saveExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sef = new frmSaveEditor())
                sef.ShowDialog();
        }

        private void StringsGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stringsGui == null)
            {
                stringsGui = new frmStringsGui();
                stringsGui.ShowDialog();
            }
            else
                stringsGui.ShowDialog();
        }

        private void joinOurDiscordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you would like to join the modding discord?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start("https://discord.gg/KnPMmBz");
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput();
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConsole();
        }

        private void WitcherScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://witcherscript.readthedocs.io");
        }

        private void ReloadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(MainController.Get().ActiveMod?.FileName))
            {
                openMod(MainController.Get().ActiveMod?.FileName);
            }
        }

        private void AddFileFromOtherModToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddModFile(true);
        }

        private void createPackedInstallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateInstaller();
        }

        private void witcherIIIModdingToolLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wcclicense = new frmWCCLicense();
            wcclicense.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveActiveFile();
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAllFiles();
        }

        private void DLCScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            var scriptsdirectory = (ActiveMod.DlcDirectory + "\\scripts\\local");
            if (!Directory.Exists(scriptsdirectory))
            {
                Directory.CreateDirectory(scriptsdirectory);
            }
            var fullPath = scriptsdirectory + "\\" + "blank_script.ws";
            var count = 1;
            var fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            var extension = Path.GetExtension(fullPath);
            var path = Path.GetDirectoryName(fullPath);
            var newFullPath = fullPath;
            while (File.Exists(newFullPath))
            {
                string tempFileName = $"{fileNameOnly}({count++})";
                if (path != null) newFullPath = Path.Combine(path, tempFileName + extension);
            }
            File.WriteAllLines(newFullPath, new[] { @"/*", $"Wolven kit - {Version}", DateTime.Now.ToString("d"), @"*/" });
        }

        private void ModscriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            var scriptsdirectory = (ActiveMod.ModDirectory + "\\scripts\\local");
            if (!Directory.Exists(scriptsdirectory))
            {
                Directory.CreateDirectory(scriptsdirectory);
            }
            var fullPath = scriptsdirectory + "\\" + "blank_script.ws";
            var count = 1;
            var fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            var extension = Path.GetExtension(fullPath);
            var path = Path.GetDirectoryName(fullPath);
            var newFullPath = fullPath;
            while (File.Exists(newFullPath))
            {
                string tempFileName = $"{fileNameOnly}({count++})";
                if (path != null) newFullPath = Path.Combine(path, tempFileName + extension);
            }
            File.WriteAllLines(newFullPath, new[] { @"/*", $"Wolven kit - {Version}", DateTime.Now.ToString("d"), @"*/" });
        }

        private void chunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Not implemented yet. I'm not sure how this should work yet.", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void launchWithCostumParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getparams = new Input("Please give the commands to launch the game with!");
            if (getparams.ShowDialog() == DialogResult.OK)
            {
                executeGame(getparams.Resulttext);
            }
        }

        private void LaunchGameForDebuggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executeGame();
        }

        private void menuCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fmc = new frmMenuCreator())
            {
                fmc.ShowDialog();
            }
        }

        private void renderW2meshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()))
            {
                renderW2meshToolStripMenuItem.Tag = false;
                renderW2meshToolStripMenuItem.Image = Properties.Resources.ui_check_box_uncheck;
            }
            else
            {
                renderW2meshToolStripMenuItem.Tag = true;
                renderW2meshToolStripMenuItem.Image = Properties.Resources.ui_check_box;
            }
        }
        private void cR2WToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fctt = new frmCR2WtoText();
            fctt.ShowDialog();
        }

        private void RecordStepsToReproduceBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"This will launch an app that will help you record the steps needed to reproduce the bug/problem.
After its done it saves a zip file.
Please send that to hambalko.bence@gmail.com with a short description about the problem.
Would you like to open the problem steps recorder?", "Bug reporting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("psr.exe");
            }
        }

        private void ReportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When reporting a bug please create a reproducion file at Help->Record steps to reproduce.",
                "Bug reporting",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start($"mailto:{"hambalko.bence@gmail.com"}?Subject={"WolvenKit bug report"}&Body={"Short description of bug:"}");
        }

        private void GameDebuggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gdb = new frmDebug();
            Rectangle floatWindowBounds = new Rectangle() { Width = 827, Height = 564 };
            gdb.Show(dockPanel, floatWindowBounds);
        }

        private void RecentFile_click(object sender, EventArgs e)
        {
            openMod(sender.ToString());
        }

        private void packProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();
        }

        private void packProjectAndLaunchGameCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();
            var getparams = new Input("Please give the commands to launch the game with!");
            if (getparams.ShowDialog() == DialogResult.OK)
            {
                executeGame(getparams.Resulttext);
            }
        }

        private void PackProjectAndRunGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pack = PackAndInstallMod();
            while (!pack.IsCompleted)
                Application.DoEvents();

            executeGame();
        }

        private void wwiseSoundbankToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ModWwiseNew_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Wwise files | *.wem;*.bnk";
                of.Title = "Please select the wwise bank and sound files for importing them into your mod";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        var newfilepath = Path.Combine(ActiveMod.ModDirectory, new SoundManager().TypeName, Path.GetFileName(f));
                        //Create the directory because it will crash if it doesn't exist.
                        Directory.CreateDirectory(Path.GetDirectoryName(newfilepath));
                        File.Copy(f, newfilepath, true);
                    }
                }
            }
        }

        private void DLCWwise_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Wwise files | *.wem;*.bnk";
                of.Title = "Please select the wwise bank and sound files for importing them into your DLC";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        var newfilepath = Path.Combine(ActiveMod.DlcDirectory, new SoundManager().TypeName, "dlc", ActiveMod.Name, Path.GetFileName(f));
                        //Create the directory because it will crash if it doesn't exist.
                        Directory.CreateDirectory(Path.GetDirectoryName(newfilepath));
                        File.Copy(f, newfilepath, true);
                    }
                }
            }
        }

        private void verifyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Multiselect = true;
                of.Filter = "Cr2w files | *.*";
                of.Title = "Please select the Cr2w files for verifying.";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in of.FileNames)
                    {
                        CR2WVerify.VerifyFile(f);
                    }
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void terrainViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void terrainViewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Render.frmTerrain ter = new Render.frmTerrain();
            ter.Show(this.dockPanel, DockState.Document);
        }

        private void w2rigjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Select w2rig JSON.", "Information about importing rigs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your w2rig.json file";
                of.Filter = "w2rig JSON files | *w2rig.json";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 rig file | *.w2rig";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        sf.FileName = of.FileName;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                ConvertRig rig = new ConvertRig();
                                rig.Load(of.FileName);
                                rig.SaveToFile(sf.FileName);
                            }
                            catch (Exception ex)
                            {
                                AddOutput(ex.ToString() + "\n", Logtype.Error);
                            }

                            MainController.Get().ProjectStatus = "File imported succesfully!";
                        }
                    }
                }
            }
        }

        private void w2animsjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Select w2anims JSON.", "Information about importing rigs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var of = new OpenFileDialog())
            {
                of.Title = "Please select your w2anims.json file";
                of.Filter = "anims JSON files | *w2anims.json";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    using (var sf = new SaveFileDialog())
                    {
                        sf.Filter = "Witcher 3 w2anims file | *.w2anims";
                        sf.Title = "Please specify a location to save the imported file";
                        sf.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
                        sf.FileName = of.FileName;
                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                ConvertAnimation anim = new ConvertAnimation();
                                anim.Load(new List<string>(){of.FileName}, sf.FileName);
                            }
                            catch (Exception ex)
                            {
                                AddOutput(ex.ToString() + "\n", Logtype.Error);
                            }

                            MainController.Get().ProjectStatus = "File imported succesfully!";
                        }
                    }
                }
            }
        }

        private void importUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowImportUtility();
        }
        private void RadishUtilitytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRadishUtility();
        }

        private void ModExplorer_RequestFastRender(object sender, RequestFileArgs e)
        {
            Render.FastRender.frmFastRender ren = new Render.FastRender.frmFastRender(e.File, Logger, ActiveMod);
            ren.Show(this.dockPanel, DockState.Document);
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void menuStrip1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmLoading().Show();
        }
        #endregion

        #region Mod Pack
        public async Task PackAndInstallMod(bool install = true)
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show("Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var packsettings = new frmPackSettings();
            if (packsettings.ShowDialog() == DialogResult.OK)
            {
                btPack.Enabled = false;
                ShowConsole();
                ShowOutput();
                ClearOutput();
                saveAllFiles();
                var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
                var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
                
                //Create the dirs. So script only mods don't die.
                Directory.CreateDirectory(modpackDir);
                Directory.CreateDirectory(DlcpackDir);

                //------------------------PRE COOKING-------------------------------------//

                //Handle strings.
                if (packsettings.Strings)
                {
                    if (stringsGui == null)
                        stringsGui = new frmStringsGui();
                    if (stringsGui.AreHashesDifferent())
                    {
                        var result = MessageBox.Show("There are no encoded CSV files in your mod, do you want to open Strings Encoder GUI?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            stringsGui.ShowDialog();
                    }
                }

                //------------------------ PRE ------------------------------------//

                //Cleanup Directories
                CleanupDirectories();

                //------------------------- PACKING -------------------------------------//
                int statusPack = -1;
                int statusCookCol = -1;
                int statusCookTex = -1;
                int statusMetaData = -1;
                int statusCol = -1;
                int statusTex = -1;

                //Handle bundle packing.
                if (packsettings.PackBundles)
                {
                    // cooking
                    var taskCookCol = Task.Run(() => Cook(MainController.Get().CollisionManager.TypeName));
                    await taskCookCol.ContinueWith(antecedent =>
                    {
                        //Logger.LogString($"Cooking Collision ended with status: {antecedent.Result}", Logtype.Important);
                        statusCookCol = antecedent.Result; 
                    });
                    if (statusCookCol == 0)
                        Logger.LogString("Cooking collision failed. \n", Logtype.Error);

                    var taskCookTex = Task.Run(() => Cook(MainController.Get().TextureManager.TypeName));
                    await taskCookTex.ContinueWith(antecedent =>
                    {
                        //Logger.LogString($"Cooking Textures ended with status: {antecedent.Result}", Logtype.Important);
                        statusCookTex = antecedent.Result;
                    });
                    if (statusCookTex == 0)
                        Logger.LogString("Cooking textures failed. \n", Logtype.Error);

                    // packing
                    if (statusCookCol * statusCookTex != 0)
                    {
                        var t = Task.Run(() => PackBundles());
                        await t.ContinueWith(antecedent =>
                        {
                            //Logger.LogString($"Packing Bundles ended with status: {antecedent.Result}", Logtype.Important);
                            statusPack = antecedent.Result;
                        });
                        if (statusPack == 0)
                            Logger.LogString("Packing bundles failed. \n", Logtype.Error);
                    }
                    else
                        AddOutput("Cooking assets failed. No bundles will be packed!\n", Logtype.Error);
                }

                //------------------------ METADATA ------------------------------------//

                //Handle metadata generation.
                if (packsettings.GenMetadata)
                {
                    if (statusPack == 1)
                    {
                        var t = Task.Run(() => CreateMetaData());
                        await t.ContinueWith(antecedent =>
                        {
                            statusMetaData = antecedent.Result;
                            //Logger.LogString($"Creating metadata ended with status: {statusMetaData}", Logtype.Important);
                        });
                        if (statusMetaData == 0)
                            Logger.LogString("Creating metadata failed. \n", Logtype.Error);
                    }
                    else
                        Logger.LogString("Packing bundles failed. No metadata will be created!\n", Logtype.Error);
                }
                

                //------------------------POST COOKING------------------------------------//

                //Generate collision cache
                if (packsettings.GenCollCache)
                {
                    //statusCol = await Task.Run(() => GenerateCache(MainController.Get().CollisionManager.TypeName));
                    var t = Task.Run(() => GenerateCache(MainController.Get().CollisionManager.TypeName));
                    await t.ContinueWith(antecedent =>
                    {
                        statusCol = antecedent.Result;
                        //Logger.LogString($"Building collision cache ended with status: {statusCol}", Logtype.Important);
                    });
                    if (statusCol == 0)
                        Logger.LogString("Building collision cache failed. \n", Logtype.Error);
                }

                //Handle texture caching
                if (packsettings.GenTexCache)
                {
                    var t = Task.Run(() => GenerateCache(MainController.Get().TextureManager.TypeName));
                    await t.ContinueWith(antecedent =>
                    {
                        statusTex = antecedent.Result;
                        //Logger.LogString($"Building texture cache ended with status: {statusTex}", Logtype.Important);
                    });
                    if (statusTex == 0)
                        Logger.LogString("Building texture cache failed. \n", Logtype.Error);
                }
                

                //Handle sound caching
                if (packsettings.Sound)
                {

                    var soundmoddir = Path.Combine(ActiveMod.ModDirectory, MainController.Get().SoundManager.TypeName);

                    foreach (var bnk in Directory.GetFiles(soundmoddir, "*.bnk", SearchOption.AllDirectories))
                    {
                        Soundbank bank = new Soundbank(bnk);
                        bank.readFile();
                        bank.read_wems(soundmoddir);
                        bank.rebuild_data();
                        File.Delete(bnk);
                        bank.build_bnk(bnk);
                        Logger.LogString("Rebuilt modded bnk " + bnk, Logtype.Success);
                    }

                    //Create mod soundspc.cache
                    if(Directory.Exists(soundmoddir) && 
                        new DirectoryInfo(soundmoddir)
                        .GetFiles("*.*", SearchOption.AllDirectories)
                        .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                    {
                        SoundCache.Write(
                            new DirectoryInfo(soundmoddir)
                                .GetFiles("*.*", SearchOption.AllDirectories)
                                .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk"))
                                .ToList().Select(x => x.FullName).ToList(),
                                Path.Combine(modpackDir, @"soundspc.cache"));
                        AddOutput("Mod soundcache generated!\n", Logtype.Important);
                    }
                    else
                    {
                        AddOutput("Mod soundcache wasn't generated!\n", Logtype.Important);
                    }

                    var sounddlcdir = Path.Combine(ActiveMod.DlcDirectory, MainController.Get().SoundManager.TypeName);

                    //Create dlc soundspc.cache
                    if (Directory.Exists(sounddlcdir) && new DirectoryInfo(sounddlcdir)
                        .GetFiles("*.*", SearchOption.AllDirectories)
                        .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                    {
                        SoundCache.Write(
                            new DirectoryInfo(sounddlcdir)
                                .GetFiles("*.*", SearchOption.AllDirectories)
                                .Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(),
                            Path.Combine(DlcpackDir, @"soundspc.cache"));
                        AddOutput("DLC soundcache generated!\n", Logtype.Important);
                    }
                    else
                    {
                        AddOutput("DLC soundcache wasn't generated!\n", Logtype.Important);
                    }
                }

                #region Scripts
                //Handle mod scripts
                if (Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, "scripts"),"*.*",SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.ModDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.ModDirectory, "scripts"), "*.*", 
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.ModDirectory , "scripts"), Path.Combine(modpackDir, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory , "scripts"), "*.*", 
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.ModDirectory, "scripts"), Path.Combine(modpackDir, "scripts")), true);
                }

                //Handle the DLC scripts
                if (Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")) && Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"),"*.*",SearchOption.AllDirectories).Any())
                {
                    if (!Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")))
                        Directory.CreateDirectory(Path.Combine(ActiveMod.DlcDirectory, "scripts"));
                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*", 
                        SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(DlcpackDir, "scripts")));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, "scripts"), "*.*", 
                        SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(Path.Combine(ActiveMod.DlcDirectory, "scripts"), Path.Combine(DlcpackDir, "scripts")), true);
                }
                #endregion

                //Copy the generated w3strings
                if (packsettings.Strings)
                {
                    var files = Directory.GetFiles((ActiveMod.ProjectDirectory + "\\strings")).Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                    files.ForEach(x => File.Copy(x, Path.Combine(DlcpackDir + Path.GetFileName(x))));
                    files.ForEach(x => File.Copy(x, Path.Combine(modpackDir, Path.GetFileName(x))));
                }

                //Install the mod
                if(install)
                    InstallMod();

                //Report that we are done
                MainController.Get().ProjectStatus = install ? "Mod Packed&Installed" : "Mod packed!"; 
                btPack.Enabled = true;
            }           
        }

        /// <summary>
        /// Always call this first to clean the directories.
        /// </summary>
        private void CleanupDirectories()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");

            #region Directory cleanup
            if (!Directory.Exists(modpackDir))
            {
                Directory.CreateDirectory(modpackDir);
            }
            else
            {
                var di = new DirectoryInfo(modpackDir);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            if (!Directory.Exists(DlcpackDir))
            {
                Directory.CreateDirectory(DlcpackDir);
            }
            else
            {
                var di = new DirectoryInfo(DlcpackDir);
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            #endregion
        }

        /// <summary>
        /// Packs the bundles for the DLC and the Mod. IN: \Bundles, OUT: packed\Mods\mod
        /// </summary>
        private async Task<int> PackBundles()
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modDir = Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName);
            var dlcDir = Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName);
            int finished = 1;

            finished *= await Task.Run(() => PackBundleInternal(modDir, modpackDir));
            finished *= await Task.Run(() => PackBundleInternal(dlcDir, dlcpackDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> PackBundleInternal(string inputDir, string outputDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {
                    if (Directory.Exists(inputDir) && Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Packing {type} bundles";

                        var pack = new Wcc_lite.pack()
                        {
                            Directory = inputDir,
                            Outdir = outputDir
                        };
                        return await Task.Run(() => WccHelper.RunCommand(pack));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} Bundle directory not found. Bundles will not be packed for {type}. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        private async Task<int> CreateMetaData()  //IN: packed\Mods\mod, OUT: same dir
        {
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modDir = Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName);
            var dlcDir = Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName);
            int finished = 1;

            finished *= await Task.Run(() => CreateMetaDataInternal(modDir, modpackDir));
            finished *= await Task.Run(() => CreateMetaDataInternal(dlcDir, dlcpackDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> CreateMetaDataInternal(string dir, string outDir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    //We only pack this if we have bundles.
                    if (Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Packing {type} metadata";
                        var metadata = new Wcc_lite.metadatastore()
                        {
                            Directory = outDir
                        };

                        return await Task.Run(() => WccHelper.RunCommand(metadata));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    //AddOutput($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    Logger.LogString($"{type} wasn't bundled. Metadata won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    //AddOutput(ex.ToString() + "\n", Logtype.Error);
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }
        
        private async Task<int> Cook(string cachetype)    //IN: \TextureCache, OUT: \Bundle
        {
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            if (COOKINPLACE)
            {
                cookedModDir = Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName);
                cookedDLCDir = Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName);
            }
            var modcachedir = Path.Combine(ActiveMod.ModDirectory, cachetype);
            var dlccachedir = Path.Combine(ActiveMod.DlcDirectory, cachetype);

            int finished = 1;

            finished *= await Task.Run(() => CookInternal(modcachedir, cookedModDir));
            finished *= await Task.Run(() => CookInternal(dlccachedir, cookedDLCDir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> CookInternal(string cachedir, string outdir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";

                try
                {
                    if (Directory.Exists(cachedir) && Directory.GetFiles(cachedir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Cooking {type} {cachetype}";
                        if (!Directory.Exists(outdir))
                        {
                            Directory.CreateDirectory(outdir);
                        }
                        else
                        {
                            if (!COOKINPLACE)
                            {
                                var di = new DirectoryInfo(outdir);
                                foreach (var file in di.GetFiles())
                                {
                                    file.Delete();
                                }
                                foreach (var dir in di.GetDirectories())
                                {
                                    dir.Delete(true);
                                }
                            }
                        }
                        var cook = new Wcc_lite.cook()
                        {
                            Platform = platform.pc,
                            mod = cachedir,
                            basedir = cachedir,
                            outdir = outdir
                        };
                        return await Task.Run(() => WccHelper.RunCommand(cook));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} {cachetype} folder not found. {type} won't be cooked. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }

        private async Task<int> GenerateCache(string cachetype) //IN: \CollisionCache, cooked\Mods\mod\cook.db, OUT: packed\Mods\mod
        {
            // cooked to \cooked
            var moddbfileDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcdbfileDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            if (COOKINPLACE)
            {
                moddbfileDir = Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName);
                dlcdbfileDir = Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName);
            }

            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var dlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var modcachedir = Path.Combine(ActiveMod.ModDirectory, cachetype);
            var dlccachedir = Path.Combine(ActiveMod.DlcDirectory, cachetype);

            #region Buildcache settings
            cachebuilder cbuilder = cachebuilder.textures;
            string filename = "";
            if (cachetype == MainController.Get().TextureManager.TypeName)
            {
                cbuilder = cachebuilder.textures;
                filename = "texture.cache";
            }
            else if (cachetype == MainController.Get().CollisionManager.TypeName)
            {
                cbuilder = cachebuilder.physics;
                filename = "collision.cache";
            }
            else
            {
                cbuilder = cachebuilder.shaders;
                filename = "shader.cache";
            }
            #endregion

            int finished = 1;

            finished *= await Task.Run(() => GenerateCacheInternal(modpackDir, moddbfileDir, modcachedir));
            finished *= await Task.Run(() => GenerateCacheInternal(dlcpackDir, dlcdbfileDir, dlccachedir, true));

            return finished == 0 ? 0 : 1;

            async Task<int> GenerateCacheInternal(string packDir, string dbfile, string cachedir, bool dlc = false)
            {
                string type = dlc ? "Dlc" : "Mod";
                try
                {
                    
                    if (Directory.Exists(cachedir) && Directory.GetFiles(cachedir, "*", SearchOption.AllDirectories).Any())
                    {
                        MainController.Get().ProjectStatus = $"Generating {type} {cachetype} cache";

                        var buildcache = new Wcc_lite.buildcache()
                        {
                            Platform = platform.pc,
                            builder = cbuilder,
                            basedir = cachedir,
                            DataBase = $"{ dbfile }\\cook.db",
                            Out = $"{packDir}\\{filename}"
                        };
                        return await Task.Run(() => WccHelper.RunCommand(buildcache));
                    }
                    else return -1;
                }
                catch (DirectoryNotFoundException)
                {
                    Logger.LogString($"{type} {cachetype} folder not found. {type} {cachetype} won't be generated. \n", Logtype.Important);
                    return -1;
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.ToString() + "\n", Logtype.Error);
                    return 0;
                }
            }
        }



        #endregion // Mod Pack

        #region UI formborderstyle none

        private const long WS_SYSMENU = 0x00080000L;
        private const long WS_BORDER = 0x00800000L;
        private const long WS_SIZEBOX = 0x00040000L;
        private const long WS_CHILD = 0x40000000L;
        private const long WS_DLGFRAME = 0x00400000L;
        private const long WS_MAXIMIZEBOX = 0x00010000L;
        private const long WS_CAPTION = 0x00C00000L;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MONITORINFO lpmi);

        [System.Runtime.InteropServices.DllImport("user32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                {
                    cp.Style |= (int)WS_BORDER;
                    cp.Style |= (int)WS_SYSMENU;
                    cp.Style |= (int)WS_SIZEBOX;
                }
                return cp;
            }
        }
        private void MinimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Screen screen = Screen.FromControl(this);
            //int x = screen.WorkingArea.X - screen.Bounds.X;
            //int y = screen.WorkingArea.Y - screen.Bounds.Y;
            //this.MaximizedBounds = new Rectangle(x, y,
            //    screen.WorkingArea.Width, screen.WorkingArea.Height);

            if (this.WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        // https://stackoverflow.com/a/42806834
        protected override void WndProc(ref Message m)
        {
            Boolean handled = false;

            switch (m.Msg)
            {
                case 0x0024:
                    WmGetMinMaxInfo(m.HWnd, m.LParam);
                    
                    handled = true;
                    break;
            }
            m.Result = IntPtr.Zero;
            if (handled) DefWndProc(ref m); else base.WndProc(ref m);
        }

        private const int WINDOW_BORDER_BUFFER = 10;
        private static void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));
            int MONITOR_DEFAULTTONEAREST = 0x00000002;
            IntPtr monitor = MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);
            if (monitor != IntPtr.Zero)
            {
                MONITORINFO monitorInfo = new MONITORINFO();
                GetMonitorInfo(monitor, monitorInfo);
                RECT rcWorkArea = monitorInfo.rcWork;
                RECT rcMonitorArea = monitorInfo.rcMonitor;
                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.left - rcMonitorArea.left) - WINDOW_BORDER_BUFFER;
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.top - rcMonitorArea.top) - WINDOW_BORDER_BUFFER;
                mmi.ptMaxSize.x = Math.Abs(rcWorkArea.right - rcWorkArea.left) + (2 * WINDOW_BORDER_BUFFER);
                mmi.ptMaxSize.y = Math.Abs(rcWorkArea.bottom - rcWorkArea.top) + (2 * WINDOW_BORDER_BUFFER);
            }
            Marshal.StructureToPtr(mmi, lParam, true);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            /// <summary>x coordinate of point.</summary>
            public int x;
            /// <summary>y coordinate of point.</summary>
            public int y;
            /// <summary>Construct a point of coordinates (x,y).</summary>
            public POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class MONITORINFO
        {
            public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));
            public RECT rcMonitor = new RECT();
            public RECT rcWork = new RECT();
            public int dwFlags = 0;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 0)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            public static readonly RECT Empty = new RECT();
            public int Width { get { return Math.Abs(right - left); } }
            public int Height { get { return bottom - top; } }
            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }
            public RECT(RECT rcSrc)
            {
                left = rcSrc.left;
                top = rcSrc.top;
                right = rcSrc.right;
                bottom = rcSrc.bottom;
            }
            public bool IsEmpty { get { return left >= right || top >= bottom; } }
            public override string ToString()
            {
                if (this == Empty) { return "RECT {Empty}"; }
                return "RECT { left : " + left + " / top : " + top + " / right : " + right + " / bottom : " + bottom + " }";
            }
            public override bool Equals(object obj)
            {
                if (!(obj is System.Windows.Rect)) { return false; }
                return (this == (RECT)obj);
            }
            /// <summary>Return the HashCode for this struct (not garanteed to be unique)</summary>
            public override int GetHashCode() => left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
            /// <summary> Determine if 2 RECT are equal (deep compare)</summary>
            public static bool operator ==(RECT rect1, RECT rect2) { return (rect1.left == rect2.left && rect1.top == rect2.top && rect1.right == rect2.right && rect1.bottom == rect2.bottom); }
            /// <summary> Determine if 2 RECT are different(deep compare)</summary>
            public static bool operator !=(RECT rect1, RECT rect2) { return !(rect1 == rect2); }
        }


        #endregion

        private void toolStripButtonRadishUtil_Click(object sender, EventArgs e)
        {
            ShowRadishUtility();
        }

        private void toolStripButtonImportUtil_Click(object sender, EventArgs e)
        {
            ShowImportUtility();
        }
    }
}
