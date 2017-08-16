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
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Mod;
using SearchOption = System.IO.SearchOption;
using WolvenKit.Interfaces;
using WolvenKit.Cache;
using WolvenKit.Bundles;

namespace WolvenKit
{
    public partial class frmMain : Form
    {
        private readonly string BaseTitle = "Wolven kit";
        private frmCR2WDocument _activedocument;
        public List<frmCR2WDocument> OpenDocuments = new List<frmCR2WDocument>();
        public static Task Packer;

        public frmMain()
        {
            InitializeComponent();
            UpdateTitle();
            buildDateToolStripMenuItem.Text = Assembly.GetExecutingAssembly().GetLinkerTime().ToString("yyyy MMMM dd");
            MainController.Get().PropertyChanged += MainControllerUpdated;

        }

        public W3Mod ActiveMod
        {
            get { return ModManager.Get().ActiveMod; }
            set
            {
                ModManager.Get().ActiveMod = value;
                UpdateTitle();
            }
        }

        public string Version
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileVersion;
            }
        }

        public frmModExplorer ModExplorer { get; set; }

        public frmOutput Output { get; set; }

        public frmCR2WDocument ActiveDocument
        {
            get { return _activedocument; }
            set
            {
                _activedocument = value;
                UpdateTitle();
            }
        }

        public frmStringsGui stringsGui;

        private void MainControllerUpdated(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ProjectStatus")
                statusLBL.Text = ((MainController)sender).ProjectStatus;
        }

        private void UpdateTitle()
        {
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainController.Get().ProjectUnsaved)
                if (MessageBox.Show("There are unsaved changes in your project. Would you like to save them?","WolvenKit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    saveAllFiles();

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
        }

        public IDockContent DeserializeDockContent(string persistString)
        {
            return null;
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
                    {
                        doc.flowDiagram = new frmChunkFlowDiagram
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
                        doc.RenderViewer = new Render.frmRender
                        {
                            File = doc.File,
                            DockAreas = DockAreas.Document
                        };
                        doc.RenderViewer.Show(doc.FormPanel, DockState.Document);
                        break;
                    }
                //TODO: Remove this once it's done
#if DEBUG
                case ".redfur":
                case ".redcloth":
                    {
                        var apexfile = new Apex(doc.File);
                        using (var sf = new SaveFileDialog())
                        {
                            sf.Filter = "XML Files | *.xml";
                            if (sf.ShowDialog() == DialogResult.OK)
                            {
                                apexfile.Write(sf.FileName);
                            }
                        }
                        break;
                    }
#endif
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


        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (sender is frmCR2WDocument)
            {
                doc_Activated(sender, e);
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

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addModFile(false);
        }

        private void addModFile(bool loadmods, string browseToPath = "")
        {
            if (ActiveMod == null)
                return;
            if (Application.OpenForms.OfType<frmAssetBrowser>().Any())
            {
                var frm = Application.OpenForms.OfType<frmAssetBrowser>().First();
                if(!string.IsNullOrEmpty(browseToPath))
                    frm.OpenPath(browseToPath);
                frm.WindowState = FormWindowState.Minimized;
                frm.Show();
                frm.WindowState = FormWindowState.Normal;
                return;
            }
            var explorer = new frmAssetBrowser(loadmods ? new List<IWitcherArchive> { MainController.Get().ModBundleManager, MainController.Get().ModSoundManager, MainController.Get().ModTextureManager } : new List<IWitcherArchive> { MainController.Get().BundleManager, MainController.Get().SoundManager, MainController.Get().TextureManager });
            explorer.RequestFileAdd += Assetbrowser_FileAdd;
            explorer.OpenPath(browseToPath);
            explorer.Show();
        }

        private void Assetbrowser_FileAdd(object sender, Tuple<List<IWitcherArchive>, ListView.ListViewItemCollection,bool> Details)
        {
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show(@"Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MainController.Get().ProjectStatus = "Busy";
            var skipping = false;
            foreach (ListViewItem depotpath in Details.Item2)
            {
                skipping = AddToMod(depotpath.Text, skipping, Details.Item1,Details.Item3);
            }
            SaveMod();
            MainController.Get().ProjectStatus = "Ready";
        }

        /// <summary>
        /// Scans the given archivemanagers for a file. If found, extracts it to the project.
        /// </summary>
        /// <param name="depotpath">Filename.</param>
        /// <param name="managers">The managers.</param>
        private bool AddToMod(string depotpath, bool skipping, List<IWitcherArchive> managers,bool AddAsDLC)
        {
            bool skip = skipping;
            foreach (var manager in managers.Where(manager => manager.Items.Any(x => x.Value.Any(y => y.Name == depotpath))))
            {
                if (manager.Items.Any(x => x.Value.Any(y => y.Name == depotpath)))
                {
                    var archives = manager.FileList.Where(x => x.Name == depotpath).Select(y => new KeyValuePair<string, IWitcherFile>(y.Bundle.FileName, y));
                    var filename = Path.Combine(ActiveMod.FileDirectory,AddAsDLC ? "DLC":"Mod",archives.First().Value.Bundle.TypeName, depotpath);
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
                        } catch { }
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
                    catch { }
                    return skip;
                }
            }
            return skip;
        }

        /// <summary>
        /// Update the list of files in the ModExplorer
        /// </summary>
        /// <param name="clear">if true files or completely redrawn</param>
        private void UpdateModFileList(bool clear = false)
        {
            ModExplorer.UpdateModFileList(true, clear);
        }

        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private void openMod(string file = "")
        {
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
            MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(file);

            var ser = new XmlSerializer(typeof(W3Mod));
            var modfile = new FileStream(file, FileMode.Open, FileAccess.Read);
            ActiveMod = (W3Mod)ser.Deserialize(modfile);
            ActiveMod.FileName = file;
            modfile.Close();
            ResetWindows();
            UpdateModFileList(true);
            AddOutput("\"" + ActiveMod.Name + "\" loaded successfully!\n");
            MainController.Get().ProjectStatus = "Ready";
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
            addModFile(false, e.File);
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
            var ser = new XmlSerializer(typeof(W3Mod));
            var modfile = new FileStream(ActiveMod.FileName, FileMode.Create, FileAccess.Write);
            ser.Serialize(modfile, ActiveMod);
            modfile.Close();
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

        private void PackProject()
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
            var packedDir = Path.Combine(ActiveMod.ProjectDirectory, "packed");
            var modName = ActiveMod.Name;

            foreach (var folder in Directory.GetDirectories(packedDir,"*",SearchOption.TopDirectoryOnly))
            {
                Commonfunctions.MoveDirectory(folder, MainController.Get().Configuration.GameRootDir);
            }
            AddOutput(modName + " installed!" + "\n", frmOutput.Logtype.Success);
        }

        private void CreateInstaller()
        {
            throw new NotImplementedException("Not implemented yet!");
            //TODO: Once we have a GUI and such enable this.
            // We should probably wait with this untill we have the Mod/Dlc project thing going on for us and no wcc_lite.
            if (ActiveMod == null)
                return;
            ShowOutput();
            var packeddir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\");
            var contentdir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\content\");
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
            var taskPackMod = packBundles();
            while (!taskPackMod.IsCompleted)
            {
                Application.DoEvents();
            }

            var taskMetaData = createModMetaData();
            while (!taskMetaData.IsCompleted)
            {
                Application.DoEvents();
            }
            var installdir = Path.Combine(ActiveMod.ProjectDirectory, @"Installer/");
            if (!Directory.Exists(installdir))
                Directory.CreateDirectory(installdir);
            FileStream fsOut = File.Create(Path.Combine(installdir, ActiveMod.Name + ".wkp"));
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);
            int folderOffset = packeddir.Length + (packeddir.EndsWith("\\") ? 0 : 1);
            Commonfunctions.CompressFolder(packeddir, zipStream, folderOffset);
            Commonfunctions.CompressFile(ActiveMod.FileName, zipStream);
            zipStream.IsStreamOwner = true;
            zipStream.Close();
            AddOutput("Installer created: " + fsOut.Name + "\n", frmOutput.Logtype.Success);
            if (!File.Exists(fsOut.Name))
            {
                AddOutput("Couldn't create installer. Something went wrong.", frmOutput.Logtype.Error);
                return;
            }
            MainController.Get().ProjectStatus = "Ready";
            Commonfunctions.ShowFileInExplorer(fsOut.Name);
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

        private void frmMain_Load(object sender, EventArgs e)
        {
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
                Close();
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
            addModFile(false);
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
                    //Save the new settings and update the title
                    UpdateTitle();
                    SaveMod();
                    if (File.Exists(ModManager.Get().ActiveMod?.FileName))
                    {
                        openMod(ModManager.Get().ActiveMod?.FileName);
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
                if(of.ShowDialog() == DialogResult.OK)
                    using (var pi = new frmInstallPackage(of.FileName))
                        pi.ShowDialog();
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

        private void wcclitePatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var pw = new frmWCCPatch())
                pw.ShowDialog();
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
            if (File.Exists(ModManager.Get().ActiveMod?.FileName))
            {
                openMod(ModManager.Get().ActiveMod?.FileName);
            }
        }

        private void AddFileFromOtherModToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addModFile(true);
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

            var scriptsdirectory = (ActiveMod.DlcDirectory + "\\scripts");
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

            var scriptsdirectory = (ActiveMod.ModDirectory + "\\scripts");
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

        private async Task PackAndInstallMod()
        {
            try
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
                        await packBundles();
                    }

                    //Handle texture caching
                    if (packsettings.GenTexCache)
                    {
                        await cookMod();
                        await packTextures();
                    }

                    //Handle metadata generation.
                    if (packsettings.GenMetadata)
                    {
                        await createModMetaData();
                    }

                    //Handle sound caching
                    if (packsettings.Sound)
                    {
                        if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, MainController.Get().SoundManager.TypeName), "*.wem | *.bnk").Any())
                            SoundCache.Write(Directory.EnumerateFiles(Path.Combine(ActiveMod.ModDirectory, MainController.Get().SoundManager.TypeName))
                                .Where(file => file.ToLower().EndsWith("wem") || file.ToLower().EndsWith("bnk"))
                                .ToList(), Path.Combine(ActiveMod.ProjectDirectory, @"packed\\Mods\\content\\soundspc.cache"));
                        if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, MainController.Get().SoundManager.TypeName), "*.wem | *.bnk").Any())
                            SoundCache.Write(Directory.EnumerateFiles(Path.Combine(ActiveMod.DlcDirectory, MainController.Get().SoundManager.TypeName))
                                .Where(file => file.ToLower().EndsWith("wem") || file.ToLower().EndsWith("bnk"))
                                .ToList(), Path.Combine(ActiveMod.ProjectDirectory, @"packed\\DLC\\content\\soundspc.cache"));
                    }

                    //Handle scripts
                    if (Directory.Exists((ActiveMod.ModDirectory + "\\scripts")) && Directory.GetFiles((ActiveMod.ModDirectory + "\\scripts")).Any())
                    {
                        if (!Directory.Exists(Path.Combine(ActiveMod.ModDirectory, "scripts")))
                            Directory.CreateDirectory(Path.Combine(ActiveMod.ModDirectory, "scripts"));
                        Directory.GetFiles((ActiveMod.ModDirectory + "\\scripts")).ToList().ForEach(x =>
                        {
                            File.Copy(x, Path.Combine(ActiveMod.ProjectDirectory, @"packed\\DLC\\" + ActiveMod.Name + @"\\content\\scripts\\", Path.GetFileName(x)), true);
                        });
                    }

                    if (Directory.Exists((ActiveMod.DlcDirectory + "\\scripts")) && Directory.GetFiles((ActiveMod.DlcDirectory + "\\scripts")).Any())
                    {
                        if (!Directory.Exists(Path.Combine(ActiveMod.DlcDirectory, "scripts")))
                            Directory.CreateDirectory(Path.Combine(ActiveMod.DlcDirectory, "scripts"));
                        Directory.GetFiles((ActiveMod.DlcDirectory + "\\scripts")).ToList().ForEach(x =>
                        {
                            File.Copy(x, Path.Combine(ActiveMod.ProjectDirectory, @"packed\\Mods\\" + ActiveMod.Name + @"\\content\\scripts\\", Path.GetFileName(x)), true);
                        });
                    }

                    if (packsettings.Strings)
                    {
                        var files = Directory.GetFiles((ActiveMod.ProjectDirectory + "\\strings")).Where(s => Path.GetExtension(s) == ".w3strings").ToList();

                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.ProjectDirectory, @"packed\\DLC\\content\\") + Path.GetFileName(x)));
                        files.ForEach(x => File.Copy(x, Path.Combine(ActiveMod.ProjectDirectory, @"packed\\Mods\\content\\") + Path.GetFileName(x)));
                    }

                    InstallMod();
                    MainController.Get().ProjectStatus = "Mod Packed&Installed";
                    btPack.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        /// <summary>
        /// Packs the bundles for the DLC and the Mod. Always call this first since this cleans the direactories.
        /// </summary>
        private async Task packBundles()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\" + ActiveMod.Name + @"\content\");
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
            if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName)).Any())
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
            #endregion
            #region DLC Bundle Packing
            if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName)).Any())
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
            #endregion
        }

        private async Task createModMetaData()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\" + ActiveMod.Name + @"\content\");
            #region Mod metadata Packing
            //We only pack this if we have bundles.
            if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName)).Any())
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
            #endregion
            #region DLC metadata Packing
            //We only pack this if we have bundles.
            if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new Bundle().TypeName)).Any())
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
            #endregion
        }

        private async Task cookMod()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mod\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\");
            #region Cook Mod
            if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new TextureCache().TypeName)).Any())
            {
                MainController.Get().ProjectStatus = "Cooking mod";
                proc.Arguments = $"cook -platform=pc -mod={Path.Combine(ActiveMod.ModDirectory,MainController.Get().TextureManager.TypeName)} -basedir={Path.Combine(ActiveMod.ModDirectory, MainController.Get().TextureManager.TypeName)}  -outdir={cookedModDir}";
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
            #endregion
            #region Cook DLC
            if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new TextureCache().TypeName)).Any())
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
            #endregion
        }

        private async Task packTextures()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) { WorkingDirectory = Path.GetDirectoryName(config.WccLite) };
            var modpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\Mods\" + ActiveMod.Name + @"\content\");
            var DlcpackDir = Path.Combine(ActiveMod.ProjectDirectory, @"packed\DLC\" + ActiveMod.Name + @"\content\");
            var cookedModDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\Mod\");
            var cookedDLCDir = Path.Combine(ActiveMod.ProjectDirectory, @"cooked\DLC\");
            #region Mod texture caching
            if (Directory.GetFiles(Path.Combine(ActiveMod.ModDirectory, new TextureCache().TypeName)).Any())
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
            #endregion
            #region DLC texture caching
            if (Directory.GetFiles(Path.Combine(ActiveMod.DlcDirectory, new TextureCache().TypeName)).Any())
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
            #endregion
        }
    }
}