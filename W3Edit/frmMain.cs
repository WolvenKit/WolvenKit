using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using W3Edit.Bundles;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;
using W3Edit.Mod;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmMain : Form
    {
        private readonly string BaseTitle = "Wolven kit";
        private frmCR2WDocument _activedocument;
        public List<frmCR2WDocument> OpenDocuments = new List<frmCR2WDocument>();

        public frmMain()
        {
            InitializeComponent();
            UpdateTitle();
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
            ActiveDocument = (frmCR2WDocument) sender;
        }

        private void doc_FormClosed(object sender, FormClosedEventArgs e)
        {
            var doc = (frmCR2WDocument) sender;
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

        private void addModFile(bool loadmods,string browseToPath = "")
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show("Please close The Witcher 3 before tinkering with the files!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var explorer = new frmBundleExplorer(loadmods ? MainController.Get().ModBundleManager : MainController.Get().BundleManager);
            explorer.OpenPath(browseToPath);
            if (explorer.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem depotpath in explorer.SelectedPaths)
                {
                    AddToMod(depotpath.Text, loadmods ? MainController.Get().ModBundleManager : MainController.Get().BundleManager);
                }
                UpdateModFileList(true);
                SaveMod();
            }
        }

        private void AddToMod(string depotpath,BundleManager bmanager)
        {
            var manager = bmanager;

            if (!manager.Items.ContainsKey(depotpath))
                return;

            BundleItem selectedBundle = null;

            if (manager.Items[depotpath].Count > 1)
            {
                var bundles = manager.Items[depotpath].ToDictionary(bundle => bundle.Bundle.FileName);

                var dlg = new frmExtractAmbigious(bundles.Keys);
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                selectedBundle = bundles[dlg.SelectedBundle];
            }
            else
            {
                selectedBundle = manager.Items[depotpath].Last();
            }

            var filename = Path.Combine(ActiveMod.FileDirectory, depotpath);

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            catch
            {

            }

            if (File.Exists(filename))
            {
                if (MessageBox.Show(filename + " already exists, do you want to overwrite it?", "Add mod file error.", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                File.Delete(filename);
            }

            selectedBundle.Extract(filename);
        }

        private void UpdateModFileList(bool clear = false)
        {
            ModExplorer?.UpdateModFileList(true,clear);
        }

        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private void openMod(string file = "")
        {
            if (file == "")
            {
                var dlg = new OpenFileDialog();
                dlg.Title = "Open Witcher 3 Mod Project";
                dlg.Filter = "Witcher 3 Mod|*.w3modproj";
                dlg.InitialDirectory = MainController.Get().Configuration.InitialModDirectory;
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

            ShowModExplorer();
            UpdateModFileList(true);
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

            var dlg = new frmRenameDialog();
            dlg.FileName = filename;
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
                    ModExplorer.UpdateModFileList(true,true);
                }
            }
        }

        private void ModExplorer_RequestAddFile(object sender, RequestFileArgs e)
        {
            addModFile(false,e.File);
        }

        private void ModExplorer_RequestFileDelete(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            if (
                MessageBox.Show("Are you sure you want to permanently delete this?", "Confirmation",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                    MessageBox.Show(@"These are the movie files of The Witcher 3.
You need a Video demultiplexer to convert these files to usable ones.
I recommend: https://sourceforge.net/projects/vgmtoolbox/",@"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                default:
                    LoadDocument(fullpath);
                    break;
            }
        }

        private static void ShellExecute(string fullpath)
        {
            var proc = new ProcessStartInfo(fullpath) {UseShellExecute = true};
            Process.Start(proc);
        }

        private static void PolymorphExecute(string fullpath, string extension)
        {
            File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] {0x01});
            var programname = new StringBuilder();
            Win32.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
            if (programname.ToString().ToUpper().Contains(".EXE"))
            {
                Process.Start(programname.ToString(), fullpath);
            }
            else
            {
                throw new InvalidFileTypeException("Invalid file type");
            }
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

                ShowModExplorer();
                UpdateModFileList(true);
                SaveMod();
                break;
            }
        }

        private void SaveMod()
        {
            var ser = new XmlSerializer(typeof (W3Mod));
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
            var dlg = new OpenFileDialog();
            dlg.Title = "Open CR2W File";
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
            }
        }

        private void tbtSaveAll_Click(object sender, EventArgs e)
        {
            saveAllFiles();
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
        }

        private void saveFile(frmCR2WDocument d)
        {
            d.SaveFile();
        }

        private void tbtAddFile_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            addModFile(false);
        }

        private void btPack_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                MessageBox.Show("Please close The Witcher 3 before tinkering with the files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btPack.Enabled = false;

            ShowOutput();

            ClearOutput();

            saveAllFiles();

            var taskPackMod = packMod();
            while (!taskPackMod.IsCompleted)
            {
                Application.DoEvents();
            }

            var taskMetaData = createModMetaData();
            while (!taskMetaData.IsCompleted)
            {
                Application.DoEvents();
            }

            installMod();

            btPack.Enabled = true;
        }

        private void ClearOutput()
        {
            if (Output != null && !Output.IsDisposed)
            {
                Output.Clear();
            }
        }

        private void AddOutput(string text)
        {
            if (Output != null && !Output.IsDisposed)
            {
                if (string.IsNullOrWhiteSpace(text))
                    return;

                Output.AddText(text);
            }
        }

        private void installMod()
        {
            var packedDir = Path.Combine(ActiveMod.Directory, "packed");


            var modName = ActiveMod.Name;

            if (!ActiveMod.InstallAsDLC && !modName.StartsWith("mod"))
                modName = "mod" + modName;

            string gameModDir = null;

            gameModDir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath),
                ActiveMod.InstallAsDLC ? @"..\..\DLC\" : @"..\..\Mods\", modName);

            if (!Directory.Exists(gameModDir))
                Directory.CreateDirectory(gameModDir);

            var dirs = Directory.GetDirectories(packedDir, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativePath = dir.Substring(packedDir.Length + 1);

                var fulldir = Path.Combine(gameModDir, relativePath);

                if (!Directory.Exists(fulldir))
                    Directory.CreateDirectory(fulldir);
            }

            var files = Directory.GetFiles(packedDir, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativePath = file.Substring(packedDir.Length + 1);

                var fullpath = Path.Combine(gameModDir, relativePath);

                File.Copy(file, fullpath, true);
            }

            AddOutput("Mod Installed to " + gameModDir + "\n");
        }

        private async Task packMod()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) {WorkingDirectory = Path.GetDirectoryName(config.WccLite)};
            var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");
            var uncookedDir = ActiveMod.FileDirectory;
            if (!Directory.Exists(packedDir))
                Directory.CreateDirectory(packedDir);

            proc.Arguments = $"pack -dir={uncookedDir} -outdir={packedDir}";
            proc.UseShellExecute = false;
            proc.RedirectStandardOutput = true;
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.CreateNoWindow = true;

            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            using (var process = Process.Start(proc))
            {
                using (var reader = process.StandardOutput)
                {
                    while (true)
                    {
                        var result = await reader.ReadLineAsync();

                        AddOutput(result + "\n");

                        Application.DoEvents();

                        if (reader.EndOfStream)
                            break;
                    }
                }
            }
        }

        private async Task createModMetaData()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WccLite) {WorkingDirectory = Path.GetDirectoryName(config.WccLite)};
            var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");

            proc.Arguments = $"metadatastore -path={packedDir}";
            proc.UseShellExecute = false;
            proc.RedirectStandardOutput = true;
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.CreateNoWindow = true;

            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            using (var process = Process.Start(proc))
            {
                using (var reader = process.StandardOutput)
                {
                    while (true)
                    {
                        var result = await reader.ReadLineAsync();

                        AddOutput(result + "\n");

                        Application.DoEvents();

                        if (reader.EndOfStream)
                            break;
                    }
                }
            }
        }

        private void btRunGame_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                if (MessageBox.Show(@"The Witcher 3 is already running would you like to close it and restart it with the proper arguments?","", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var killer = Process.Start("taskkill", "/F /IM witcher3.exe");
                    killer?.WaitForExit();
                }
                else
                    return;
            }
            ClearOutput();
            ShowOutput();
            executeGame();
        }

        private async void executeGame()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.ExecutablePath)
            {
                WorkingDirectory = Path.GetDirectoryName(config.ExecutablePath),
                Arguments = "-debugscripts",
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
                //var task1 = RedirectProcessOutput(process);
                var task2 = RedirectScriptlogOutput(process);

                //await task1;
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

        private void addFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addModFile(false);
        }

        private void modSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            using (var dlg = new frmModSettings())
            {
                dlg.Mod = ActiveMod;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    UpdateTitle();
                    SaveMod();
                }
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cf = new frmAbout())
                cf.ShowDialog();
        }

        private void addFileToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Open CR2W File";
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialFileDirectory = Path.GetDirectoryName(dlg.FileName);
                LoadDocument(dlg.FileName);
            }
        }

        private void saveExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sef = new frmSaveEditor())
                sef.ShowDialog();
        }

        private void joinOurDiscordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Are you sure you would like to join the modding discord?", @"Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start("https://discord.gg/qBNgDEX");
        }

        private void TbtRefresh(object sender, EventArgs e)
        {
            UpdateModFileList(true);
        }

        private void wcclitePatcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var pw = new frmWCCPatch())
                pw.ShowDialog();
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput();
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tf = new frmTutorials();
                tf.Show(this);
        }

        private void reloadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(ModManager.Get().ActiveMod?.FileName))
            {
                openMod(ModManager.Get().ActiveMod?.FileName);
            }
        }

        private void addFileFromOtherModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addModFile(true);
        }
    }
}