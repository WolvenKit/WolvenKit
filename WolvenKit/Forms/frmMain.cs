using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using AutoUpdaterDotNET;
using Dfust.Hotkeys;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using SharpPresence;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Mod;
using SearchOption = System.IO.SearchOption;
using WolvenKit.Common;
using WolvenKit.Cache;
using WolvenKit.Bundles;
using WolvenKit.Forms;
using Enums = Dfust.Hotkeys.Enums;

namespace WolvenKit
{
    public partial class frmMain : Form
    {
        #region Forms
        private frmCR2WDocument _activedocument;
        public List<frmCR2WDocument> OpenDocuments = new List<frmCR2WDocument>();
        public frmModExplorer ModExplorer { get; set; }
        public frmStringsGui stringsGui;
        public frmOutput Output { get; set; }

        public frmCR2WDocument ActiveDocument
        {
            get => _activedocument;
            set
            {
                _activedocument = value;
                UpdateTitle();
            }
        }
        #endregion
        private readonly string BaseTitle = "Wolven kit";
        public static Task Packer;
        private HotkeyCollection hotkeys;

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

        public frmMain()
        {
            InitializeComponent();
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
            hotkeys.RegisterHotkey(Keys.Control | Keys.Shift | Keys.S, HKSaveAll , "SaveAll");
            hotkeys.RegisterHotkey(Keys.F1, HKHelp, "Help");
            hotkeys.RegisterHotkey(Keys.Control | Keys.C, HKCopy, "Copy");
            hotkeys.RegisterHotkey(Keys.Control | Keys.V, HKPaste,"Paste");            
            MainController.Get().InitForm(this);
        }

        private delegate void strDelegate(string t);

        private delegate void logDelegate(string t, frmOutput.Logtype type);

        #region Methods
        /// <summary>
        /// Occurs when something in the maincontroller is updated that is INotifyProeprtyChanged
        /// Thread safe and always should be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainControllerUpdated(object sender, System.ComponentModel.PropertyChangedEventArgs e)
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
            buildDateToolStripMenuItem.Text = Assembly.GetExecutingAssembly().GetLinkerTime().ToString("yyyy MMMM dd");
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
            AddOutput("All files saved!\n");
            MainController.Get().ProjectStatus = "Item(s) Saved";
            MainController.Get().ProjectUnsaved = false;
        }

        private void saveFile(frmCR2WDocument d)
        {
            d.SaveFile();
            AddOutput(d.FileName + " saved!\n");
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

        private void AddOutput(string text, frmOutput.Logtype type = frmOutput.Logtype.Normal)
        {
            if (Output != null && !Output.IsDisposed)
            {
                if (string.IsNullOrWhiteSpace(text))
                    return;

                Output.AddText(text, type);
            }
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
                    AddOutput("Failed to install the mod! The packed directory doesn't exist! You forgot to tick any of the packing options?",frmOutput.Logtype.Important);
                    return;
                }
                fileroot.Add(Commonfunctions.DirectoryCopy(Path.Combine(ActiveMod.ProjectDirectory, "packed"), MainController.Get().Configuration.GameRootDir, true));
                installlog.Root.Add(fileroot);
                //Save the log.
                installlog.Save(ActiveMod.ProjectDirectory + "\\install_log.xml");
                AddOutput(ActiveMod.Name + " installed!" + "\n", frmOutput.Logtype.Success);
            }
            catch (Exception ex)
            {
                //If we screwed up something. Log it.
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
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


            // Delete from file structure
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }
            else
            {
                try
                {
                    Directory.Delete(fullpath, true);
                }
                catch (Exception)
                {
                    AddOutput("Failed to delete " + fullpath + "!");
                }
            }

            // Delete from mod explorer
            ModExplorer?.DeleteNode(filename);

            SaveMod();
        }

        private void ModExplorer_RequestFileOpen(object sender, RequestFileArgs e)
        {
            var fullpath = Path.Combine(ActiveMod.FileDirectory, e.File);

            var ext = Path.GetExtension(fullpath);

            switch (ext)
            {
                case ".csv":
                case ".xml":
                case ".txt":
                    ShellExecute(fullpath);
                    break;
                case ".subs":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".usm":
                    LoadUsmFile(fullpath);
                    break;
                case ".ws":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".dds":
                    LoadDDSFile(fullpath);
                    break;
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

        public void LoadDDSFile(string path)
        {
            var dockedImage = new frmTextureFile();
            dockedImage.Show(dockPanel, DockState.Document);
            dockedImage.Text = Path.GetFileName(path);
            dockedImage.LoadImage(path);
        }

        private void ShowOutput()
        {
            if (Output == null || Output.IsDisposed)
            {
                Output = new frmOutput();
                Output.Show(dockPanel, DockState.DockBottom);
            }

            Output.Focus();
        }

        private void newModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewMod();
        }

        private void createNewMod()
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
                ResetWindows();
                UpdateModFileList(true);
                SaveMod();
                AddOutput("\"" + ActiveMod.Name + "\" sucesfully created and loaded!\n");
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
            return null;
        }

        private void openMod(string file = "")
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
                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);

                //Loading the project
                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(file, FileMode.Open, FileAccess.Read);
                ActiveMod = (W3Mod)ser.Deserialize(modfile);
                ActiveMod.FileName = file;
                modfile.Close();
                ResetWindows();
                UpdateModFileList(true);
                AddOutput("\"" + ActiveMod.Name + "\" loaded successfully!\n");
                MainController.Get().ProjectStatus = "Ready";

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
                    var filename = Path.Combine(ActiveMod.FileDirectory, AddAsDLC ? Path.Combine("DLC",archives.First().Value.Bundle.TypeName,"dlc",ActiveMod.Name,item.FullPath) : Path.Combine("Mod",archives.First().Value.Bundle.TypeName,item.FullPath));
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
                            selectedBundle.Extract(filename);
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

                        archives.FirstOrDefault().Value.Extract(filename);
                    }
                    catch (Exception ex)
                    {
                        AddOutput(ex.ToString(),frmOutput.Logtype.Error);
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
            var explorer = new frmAssetBrowser(loadmods ? 
                new List<IWitcherArchive>
                {
                    MainController.Get().ModBundleManager, 
                    MainController.Get().ModSoundManager, 
                    MainController.Get().ModTextureManager
                } : 
                new List<IWitcherArchive>
                {
                    MainController.Get().BundleManager, 
                    MainController.Get().SoundManager, 
                    MainController.Get().TextureManager
                });
            explorer.RequestFileAdd += Assetbrowser_FileAdd;
            explorer.OpenPath(browseToPath);
            explorer.Show();
        }

        /// <summary>
        /// Update the list of files in the ModExplorer
        /// </summary>
        /// <param name="clear">if true files or completely redrawn</param>
        private void UpdateModFileList(bool clear = false)
        {
            ModExplorer.UpdateModFileList(true, clear);
        }

        /// <summary>
        /// Closes all the "file documents", resets modexplorer and clears the output.
        /// </summary>
        private void ResetWindows()
        {
            if (ActiveMod != null)
            {
                foreach (var t in OpenDocuments)
                {
                    t.Close();
                    break;
                }
            }
            ModExplorer?.Close();
            ModExplorer = null;
            ShowModExplorer();
            ShowOutput();
            ClearOutput();
        }

        private void ShowModExplorer()
        {
            if (ModExplorer == null || ModExplorer.IsDisposed)
            {
                ModExplorer = new frmModExplorer();
                ModExplorer.Show(dockPanel, DockState.DockLeft);
                ModExplorer.RequestFileOpen += ModExplorer_RequestFileOpen;
                ModExplorer.RequestFileDelete += ModExplorer_RequestFileDelete;
                ModExplorer.RequestFileAdd += ModExplorer_RequestAddFile;
                ModExplorer.RequestFileRename += ModExplorer_RequestFileRename;
            }
            ModExplorer.Activate();
        }

        public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
        {
            if (memoryStream == null && !File.Exists(filename))
                return null;

            foreach (var t in OpenDocuments.Where(t => t.FileName == filename))
            {
                t.Activate();
                return null;
            }

            var doc = new frmCR2WDocument();
            OpenDocuments.Add(doc);

            try
            {
                if (memoryStream != null)
                {
                    doc.LoadFile(filename, memoryStream);
                }
                else
                {
                    doc.LoadFile(filename);
                }
            }
            catch (InvalidFileTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                OpenDocuments.Remove(doc);
                doc.Dispose();
                return null;
            }
            catch (MissingTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, @"Error opening file.");

                OpenDocuments.Remove(doc);
                doc.Dispose();
                return null;
            }
            switch (Path.GetExtension(filename))
            {
                case ".w2scene":
                case ".w2quest":
                case ".w2phase":
                    {
                        doc.flowDiagram = new frmChunkFlowDiagram()
                        {
                            File = doc.File,
                            DockAreas = DockAreas.Document
                        };
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
                            File = doc.File,
                            DockAreas = DockAreas.Document
                        };
                        doc.ImageViewer.Show(doc.FormPanel, DockState.Document);
                        break;
                    }
                /*case ".w2ent":
                    {
                        CHandle mesh = doc.File.chunks[2].GetVariableByName("mesh") as CHandle;
                        var docW2Mesh = LoadDocument(Path.GetDirectoryName(filename) + @"\model\" + Path.GetFileName(mesh.Handle));
                        if (docW2Mesh == null)
                            MessageBox.Show(".w2mesh file not found in model folder!" + "\n" + "Have you extracted it properly?");
                        break;
                    }*/
                case ".w2mesh":
                    {
                        if (bool.Parse(renderW2meshToolStripMenuItem.Tag.ToString()))
                        {
                            doc.RenderViewer = new Render.frmRender
                            {
                                LoadDocument = LoadDocumentAndGetFile,
                                MeshFile = doc.File,
                                DockAreas = DockAreas.Document
                            };
                            doc.RenderViewer.Show(doc.FormPanel, DockState.Document);
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (doc.File.block7.Count > 0)
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

            AddOutput(output.ToString());
            return doc;
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
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            try
            {
                MainController.Get().ProjectStatus = "Dumping folder";
                proc.Arguments = $"dumpfile -dir={folder} -out={outfolder}";
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.CreateNoWindow = true;
                AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                using (var process = Process.Start(proc))
                {
                    using (var reader = process.StandardOutput)
                    {
                        while (true)
                        {
                            var result = await reader.ReadLineAsync();

                            AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                            Application.DoEvents();

                            if (reader.EndOfStream)
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File dumped succesfully!";

        }

        async Task ImportFile(string infile, string outfile)
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            try
            {
                var importwdir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.WccLite), "WolvenKitWorkingDir");
                if(Directory.Exists(importwdir))
                    Directory.Delete(importwdir,true);
                Directory.CreateDirectory(importwdir);
                File.Copy(infile,Path.Combine(importwdir,Path.GetFileName(infile)));
                MainController.Get().ProjectStatus = "Importing file";
                proc.Arguments = $"import -depot=\"{importwdir}\" -file={Path.Combine(importwdir,Path.GetFileName(infile))} -out={outfile}";
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.CreateNoWindow = true;
                if (!Directory.Exists(Path.GetDirectoryName(outfile)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(outfile));
                }
                AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                using (var process = Process.Start(proc))
                {
                    using (var reader = process.StandardOutput)
                    {
                        while (true)
                        {
                            var result = await reader.ReadLineAsync();

                            AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                            Application.DoEvents();

                            if (reader.EndOfStream)
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }

            MainController.Get().ProjectStatus = "File imported succesfully!";

        }

        #endregion //Methods

        #region  Control events
        private void richpresenceworker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string project = "non";

            Discord.EventHandlers handlers = new Discord.EventHandlers();
            Discord.Initialize("482179494862651402", handlers);
            while (!richpresenceworker.CancellationPending)
            {
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

        private void fbxWithCollisionsToolStripMenuItem_Click(object sender, EventArgs e)
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
                            ImportFile(of.FileName, sf.FileName);
                        }
                    }
                }
            }
        }

        private void dumpFileToolStripMenuItem_Click(object sender, EventArgs e)
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
                            DumpFile(of.SelectedPath.EndsWith("\\") ? of.SelectedPath : of.SelectedPath + "\\",
                                sf.SelectedPath.EndsWith("\\") ? sf.SelectedPath : sf.SelectedPath + "\\");
                        }
                    }
                }
            }
        }

        private void nvidiaClothFileToolStripMenuItem_Click(object sender, EventArgs e)
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
                            ImportFile(of.FileName, sf.FileName);
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
                if (MessageBox.Show("There are unsaved changes in your project. Would you like to save them?", "WolvenKit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    saveAllFiles();

            SaveMod();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            var config = MainController.Get().Configuration;

            config.MainState = WindowState;

            WindowState = FormWindowState.Normal;
            config.MainSize = Size;
            config.MainLocation = Location;

            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"));
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            ResetWindows();
            var config = MainController.Get().Configuration;
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
            if (!string.IsNullOrEmpty(MainController.Get().InitialWKP))
            {
                using (var pi = new frmInstallPackage(MainController.Get().InitialWKP))
                    pi.ShowDialog();
            }
        }


        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModFile(false);
        }

        private void donateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Every last bit helps and everything donated is distributed between the core developers evenly.","Thank you",MessageBoxButtons.OK,MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://www.paypal.me/traderain");
        }

        private void Assetbrowser_FileAdd(object sender, Tuple<List<IWitcherArchive>, List<WitcherListViewItem>,bool> Details)
        {
            ModExplorer.PauseMonitoring();
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MainController.Get().ProjectStatus = "Busy";
            var skipping = false;
            foreach (WitcherListViewItem item in Details.Item2)
            {
                skipping = AddToMod(item, skipping, Details.Item1,Details.Item3);
            }
            SaveMod();
            MainController.Get().ProjectStatus = "Ready";
            ModExplorer.FoldersShown = true;
            ModExplorer.FilteredFiles = ActiveMod.Files;
            ModExplorer.UpdateModFileList(true,true);
            ModExplorer.ResumeMonitoring();
        }

        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private void ModExplorer_RequestFileRename(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath))
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

                File.Move(fullpath, newfullpath);

                // Rename file in mod explorer
                if (ModExplorer != null)
                {
                    ModExplorer.DeleteNode(filename);
                    ModExplorer.UpdateModFileList(true, true);
                }
            }
            MainController.Get().ProjectStatus = "File renamed";
        }

        private void ModExplorer_RequestAddFile(object sender, RequestFileArgs e)
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
                AddOutput("Saved!\n");
            }

        }

        private void tbtSaveAll_Click(object sender, EventArgs e)
        {
            saveAllFiles();
            MainController.Get().ProjectStatus = "Item saved";
            AddOutput("Saved!\n");
        }

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
            
            //Update check should be after we are all set up. It goes on in the background.
            AutoUpdater.Start("https://raw.githubusercontent.com/Traderain/Wolven-kit/master/Update.xml");
            richpresenceworker.RunWorkerAsync();
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
                            MainController.Get()?.Window?.ModExplorer?.StopMonitoringDirectory();
                            //Close all docs so they won't cause problems
                            OpenDocuments.ForEach(x => x.Close());
                            //Move the files directory
                            Directory.Move(oldmod.ProjectDirectory, Path.Combine(Path.GetDirectoryName(oldmod.ProjectDirectory), dlg.Mod.Name));
                            //Delete the old directory
                            if (Directory.Exists(oldmod.ProjectDirectory))
                                Commonfunctions.DeleteFilesAndFoldersRecursively(oldmod.ProjectDirectory);
                            //Delete the old mod project file
                            if (File.Exists(oldmod.FileName))
                                File.Delete(oldmod.FileName);
                        }
                        catch (System.IO.IOException exception)
                        {
                            MessageBox.Show("Sorry but there already exist a folder/mod with that name.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    Commonfunctions.SendNotification("Succesfully updated mod settings!");
                }
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cf = new frmAbout())
                cf.ShowDialog();
        }

        private void addFileToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    Commonfunctions.SendNotification("Invalid file!");
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
                Process.Start("https://discord.gg/qBNgDEX");
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput();
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
            gdb.Show();
        }

        private void RecentFile_click(object sender, EventArgs e)
        {
            openMod(sender.ToString());
        }

        private void packProjectAndLaunchGameToolStripMenuItem_Click(object sender, EventArgs e)
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
                        var result = MessageBox.Show("There are not encoded CSV files in your mod, do you want to open Strings Encoder GUI?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                            stringsGui.ShowDialog();
                    }
                }

                //Handle bundle packing.
                if (packsettings.PackBundles)
                {
                    await PackBundles();
                }

                //------------------------- COOKING -------------------------------------//

                //Cook the mod
                await CookMod();

                //------------------------POST COOKING------------------------------------//

                //Generate collision cache
                if (packsettings.GenCollCache)
                {
                    await GenerateCollisionCache();
                }

                //Handle texture caching
                if (packsettings.GenTexCache)
                {
                    await PackTextures();
                }

                //Handle metadata generation.
                if (packsettings.GenMetadata)
                {
                    await CreateModMetaData();
                }

                //Handle sound caching
                if (packsettings.Sound)
                {
                    if (new DirectoryInfo(Path.Combine(ActiveMod.ModDirectory, MainController.Get().SoundManager.TypeName)).GetFiles("*.*",SearchOption.AllDirectories).Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                    {
                        SoundCache.Write(new DirectoryInfo(Path.Combine(ActiveMod.ModDirectory, MainController.Get().SoundManager.TypeName)).GetFiles("*.*", SearchOption.AllDirectories).Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(), Path.Combine(modpackDir, @"soundspc.cache"));
                        AddOutput("Mod soundcache generated!\n", frmOutput.Logtype.Important);
                    }
                    else
                    {
                        AddOutput("Mod soundcache wasn't generated!\n", frmOutput.Logtype.Important);
                    }
                    if (new DirectoryInfo(Path.Combine(ActiveMod.DlcDirectory, MainController.Get().SoundManager.TypeName)).GetFiles("*.*", SearchOption.AllDirectories).Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).Any())
                    {
                        SoundCache.Write(new DirectoryInfo(Path.Combine(ActiveMod.DlcDirectory, MainController.Get().SoundManager.TypeName)).GetFiles("*.*", SearchOption.AllDirectories).Where(file => file.Name.ToLower().EndsWith("wem") || file.Name.ToLower().EndsWith("bnk")).ToList().Select(x => x.FullName).ToList(), Path.Combine(DlcpackDir, @"soundspc.cache"));
                        AddOutput("DLC soundcache generated!\n", frmOutput.Logtype.Important);
                    }
                    else
                    {
                        AddOutput("DLC soundcache wasn't generated!\n", frmOutput.Logtype.Important);
                    }
                }

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
        /// Packs the bundles for the DLC and the Mod. Always call this first since this cleans the direactories.
        /// </summary>
        private async Task PackBundles()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
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
            #region Mod Bundle Packing
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Packing mod bundles";
                    proc.Arguments = $"pack -dir={Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName)} -outdir={modpackDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("Mod Bundle directory not found. Bundles will not be packed for mod. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
            #region DLC Bundle Packing
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName),"*",SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Packing dlc bundles";
                    proc.Arguments = $"pack -dir={Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName)} -outdir={DlcpackDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("DLC Bundle directory not found. Bundles will not packed for DLC. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }            
            #endregion
        }

        private async Task CreateModMetaData()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            #region Mod metadata Packing
            try
            {
                //We only pack this if we have bundles.
                if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Packing mod metadata";
                    proc.Arguments = $"metadatastore -path={modpackDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("Mod wasn't bundled. Metadata won't be generated. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
            #region DLC metadata Packing
            try
            {
                //We only pack this if we have bundles.
                if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Packing DLC metadata";
                    proc.Arguments = $"metadatastore -path={DlcpackDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch(DirectoryNotFoundException)
            {
                AddOutput("DLC wasn't bundled. Metadata won't be generated. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
        }

        private async Task CookMod()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            #region Cook Mod
            try
            {
                var modtexcachedir = Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName);
                if (Directory.Exists(modtexcachedir) && Directory.GetFiles(modtexcachedir, "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Cooking mod";
                    proc.Arguments = $"cook -platform=pc -mod={Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName)} -basedir={Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName)}  -outdir={cookedModDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;
                    if (!Directory.Exists(cookedModDir))
                    {
                        Directory.CreateDirectory(cookedModDir);
                    }
                    else
                    {
                        var di = new DirectoryInfo(cookedModDir);
                        foreach (var file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (var dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                    }
                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("Mod TextureCache folder not found. Mod won't be cooked. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
            #region Cook DLC
            try
            {
                var dlctxcachedir = Path.Combine(ActiveMod.DlcDirectory, MainController.Get().TextureManager.TypeName);
                if (Directory.Exists(dlctxcachedir) && Directory.GetFiles(dlctxcachedir, "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Cooking DLC";
                    proc.Arguments = $"cook -platform=pc -mod={Path.Combine(ActiveMod.DlcDirectory, MainController.Get().TextureManager.TypeName)} -basedir={Path.Combine(ActiveMod.DlcDirectory, MainController.Get().TextureManager.TypeName)}  -outdir={cookedDLCDir}";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;
                    if (!Directory.Exists(cookedDLCDir))
                    {
                        Directory.CreateDirectory(cookedDLCDir);
                    }
                    else
                    {
                        var di = new DirectoryInfo(cookedDLCDir);
                        foreach (var file in di.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (var dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }
                    }
                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("DLC TextureCache folder not found. DLC won't be cooked. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
        }

        private async Task GenerateCollisionCache()
        {
                        var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            #region Mod texture caching
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new TextureCache().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Generating collision cache";
                    proc.Arguments = $"buildcache physics -basedir={Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName)} -platform=pc -db={cookedModDir}\\cook.db  -out={modpackDir}\\collision.cache";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("Collision cache was not generated because mod was not cooked. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
            #region DLC texture caching
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new TextureCache().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Generating DLC collision cache";
                    proc.Arguments = $"buildcache physics -basedir={Path.Combine(ActiveMod.DlcDirectory, MainController.Get().TextureManager.TypeName)} -platform=pc -db={cookedDLCDir}\\cook.db  -out={DlcpackDir}\\collision.cache";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("DLC wasn't cooked. Couldn't generate collision cache. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }            
            #endregion
        }

        private async Task PackTextures()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\mod" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\dlc" + ActiveMod.Name + @"\content\");
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mods\mod" + ActiveMod.Name + @"\content\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\dlc" + ActiveMod.Name + @"\content\");
            #region Mod texture caching
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new TextureCache().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Caching mod textures";
                    proc.Arguments = $"buildcache textures -basedir={Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName)} -platform=pc -db={cookedModDir}\\cook.db  -out={modpackDir}\\texture.cache";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("Mod wasn't cooked. Textures won't be cached. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }
            #endregion
            #region DLC texture caching
            try
            {
                if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new TextureCache().TypeName), "*", SearchOption.AllDirectories).Any())
                {
                    MainController.Get().ProjectStatus = "Caching DLC textures";
                    proc.Arguments = $"buildcache textures -basedir={Path.Combine(ActiveMod.DlcDirectory, MainController.Get().TextureManager.TypeName)} -platform=pc -db={cookedDLCDir}\\cook.db  -out={DlcpackDir}\\texture.cache";
                    proc.UseShellExecute = false;
                    proc.RedirectStandardOutput = true;
                    proc.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.CreateNoWindow = true;

                    AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n", frmOutput.Logtype.Important);

                    using (var process = Process.Start(proc))
                    {
                        using (var reader = process.StandardOutput)
                        {
                            while (true)
                            {
                                var result = await reader.ReadLineAsync();

                                AddOutput(result + "\n", frmOutput.Logtype.Wcc);

                                Application.DoEvents();

                                if (reader.EndOfStream)
                                    break;
                            }
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                AddOutput("DLC wasn't cooked. Textures won't be cached. \n", frmOutput.Logtype.Important);
            }
            catch (Exception ex)
            {
                AddOutput(ex.ToString() + "\n", frmOutput.Logtype.Error);
            }            
            #endregion
        }
        #endregion // Mod Pack

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
                if(of.ShowDialog() == DialogResult.OK)
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
                        var newfilepath = Path.Combine(ActiveMod.DlcDirectory, new SoundManager().TypeName,"dlc", ActiveMod.Name, Path.GetFileName(f));
                        //Create the directory because it will crash if it doesn't exist.
                        Directory.CreateDirectory(Path.GetDirectoryName(newfilepath));
                        File.Copy(f, newfilepath, true);
                    }
                }
            }
        }
    }
}