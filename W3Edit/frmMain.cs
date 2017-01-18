using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;
using W3Edit.Mod;
using WeifenLuo.WinFormsUI.Docking;
using System.Diagnostics;
using W3Edit.CR2W.Types;
using W3Edit.Bundles;

namespace W3Edit
{
    public partial class frmMain : Form
    {
        private string BaseTitle = "Sarcen's Witcher 3 Mod Editor";

        public W3Mod ActiveMod 
        {
            get { return ModManager.Get().ActiveMod; }
            set { ModManager.Get().ActiveMod = value; UpdateTitle(); }
        }

        public string Version
        {
            get
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileVersion;
            }
        }

        private void UpdateTitle()
        {
            Text = BaseTitle + " v" + Version;
            if(ActiveMod != null) {
                Text += " [" + ActiveMod.Name + "] ";
            }

            if(ActiveDocument != null && !ActiveDocument.IsDisposed)
            {
                Text += Path.GetFileName(ActiveDocument.FileName);
            }
        }

        public frmModExplorer ModExplorer
        {
            get;
            set;
        }

        public frmOutput Output
        {
            get;
            set;
        }

        public frmMain()
        {
            InitializeComponent();

            UpdateTitle();
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
                dockPanel.LoadFromXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "main_layout.xml"), DeserializeDockContent);
            }
            catch
            {

            }
        }

        public IDockContent DeserializeDockContent(string persistString)
        {
            return null;
        }

        public List<frmCR2WDocument> OpenDocuments = new List<frmCR2WDocument>();

        public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream = null, bool suppressErrors = false)
        {
            if (memoryStream == null && !File.Exists(filename))
                return null;

            for(int i=0; i<OpenDocuments.Count; i++)
            {
                if(OpenDocuments[i].FileName == filename)
                {
                    OpenDocuments[i].Activate();
                    return null;
                }
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
            catch(InvalidFileTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this ,ex.Message, "Error opening file.");

                OpenDocuments.Remove(doc);
                doc.Dispose();
                return null;
            }
            catch(MissingTypeException ex)
            {
                if (!suppressErrors)
                    MessageBox.Show(this, ex.Message, "Error opening file.");

                OpenDocuments.Remove(doc);
                doc.Dispose();
                return null;
            }

            doc.Activated += doc_Activated;
            doc.Show(dockPanel, DockState.Document);
            doc.FormClosed += doc_FormClosed;

            var output = new StringBuilder();

            if (doc.File.UnknownTypes.Count() > 0)
            {
                ShowOutput();

                output.Append(doc.FileName + ": contains " + doc.File.UnknownTypes.Count + " unknown type(s):\n");
                foreach(var unk in doc.File.UnknownTypes)
                {
                    output.Append("\"" + unk + "\", \n");
                }

                output.Append("-------\n\n");
            }

            var hasUnknownBytes = false;

            for (int i = 0; i < doc.File.chunks.Count;i++ )
            {
                if (doc.File.chunks[i].unknownBytes != null && doc.File.chunks[i].unknownBytes.Bytes != null && doc.File.chunks[i].unknownBytes.Bytes.Length > 0)
                {
                    output.Append(doc.File.chunks[i].Name + " contains " + doc.File.chunks[i].unknownBytes.Bytes.Length + " unknown bytes. \n");
                    hasUnknownBytes = true;
                }
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

        void doc_Activated(object sender, EventArgs e)
        {
            ActiveDocument = (frmCR2WDocument)sender;
        }

        void doc_FormClosed(object sender, FormClosedEventArgs e)
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
            addModFile();
        }

        private void addModFile(string browseToPath = "")
        {
            if (ActiveMod == null)
                return;

            var explorer = new frmBundleExplorer();

            explorer.OpenPath(browseToPath);

            if (explorer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var depotpath in explorer.SelectedPaths)
                {
                    AddToMod(depotpath);
                }


                UpdateModFileList();
                SaveMod();
            }
        }

        private void AddToMod(string depotpath)
        {
            var manager = MainController.Get().BundleManager;

            if (!manager.Items.ContainsKey(depotpath))
                return;

            BundleItem selectedBundle = null;

            if(manager.Items[depotpath].Count > 1)
            {
                var bundles = new Dictionary<string, BundleItem>();
                foreach(var bundle in manager.Items[depotpath]) 
                {
                    bundles.Add(bundle.Bundle.FileName, bundle);
                }

                var dlg = new frmExtractAmbigious(bundles.Keys);
                if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
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

        private void UpdateModFileList(bool clear=false)
        {
            if (ModExplorer != null)
            {
                ModExplorer.UpdateModFileList(clear);
            }
        }

        private void openModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMod();
        }

        private void openMod()
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Open Witcher 3 Mod Project";
            dlg.Filter = "Witcher 3 Mod|*.w3modproj";
            dlg.InitialDirectory = MainController.Get().Configuration.InitialModDirectory;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MainController.Get().Configuration.InitialModDirectory = Path.GetDirectoryName(dlg.FileName);

                var ser = new XmlSerializer(typeof(W3Mod));
                var modfile = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                ActiveMod = (W3Mod)ser.Deserialize(modfile);
                ActiveMod.FileName = dlg.FileName;
                modfile.Close();

                ShowModExplorer();
                UpdateModFileList(true);
            }
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

        void ModExplorer_RequestFileRename(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath))
                return;

            var dlg = new frmRenameDialog();
            dlg.FileName = filename;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != filename)
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
                    ModExplorer.UpdateModFileList();
                }               
            }
        }

        void ModExplorer_RequestAddFile(object sender, RequestFileArgs e)
        {
            addModFile(e.File);
        }

        void ModExplorer_RequestFileDelete(object sender, RequestFileArgs e)
        {
            var filename = e.File;

            if (MessageBox.Show("Are you sure you want to permanently delete this?", "Confirmation", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                removeFromMod(filename);
            }
        }

        private void removeFromMod(string filename)
        {
            // Close open documents
            for(int i=0; i< OpenDocuments.Count; i++)
            {
                if(OpenDocuments[i].FileName == filename)
                {
                    OpenDocuments[i].Close();
                    break;
                }
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
                catch(Exception)
                {

                }
            }

            // Delete from mod explorer
            if (ModExplorer != null)
            {
                ModExplorer.DeleteNode(filename);
            }

            SaveMod();
        }

        void ModExplorer_RequestFileOpen(object sender, RequestFileArgs e)
        {
            var fullpath = Path.Combine(ActiveMod.FileDirectory, e.File);

            var ext = Path.GetExtension(fullpath);

            switch (ext) { 
                case ".csv":
                case ".xml":
                case ".txt":
                    ShellExecute(fullpath);
                break;
                default:
                    LoadDocument(fullpath);
                break;
            }
        }

        private void ShellExecute(string fullpath)
        {
            var proc = new ProcessStartInfo(fullpath);
            proc.UseShellExecute = true;
            Process.Start(proc);
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
            var dlg = new SaveFileDialog();
            dlg.Title = "Create Witcher 3 Mod Project";
            dlg.Filter = "Witcher 3 Mod|*.w3modproj";
            dlg.InitialDirectory = MainController.Get().Configuration.InitialModDirectory;

            while (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                if(dlg.FileName.Contains(' '))
                {
                    MessageBox.Show("The mod path should not contain spaces because wcc_lite.exe will have trouble with that.", "Invalid path");
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

                ActiveMod = new W3Mod()
                {
                    FileName = dlg.FileName,
                    Name = modname,
                };

                ShowModExplorer();
                UpdateModFileList(true);
                SaveMod();
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

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

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
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            foreach(var d in OpenDocuments)
            {
                if(d.SaveTarget != null)
                    saveFile(d);
            }

            foreach (var d in OpenDocuments)
            {
                if (d.SaveTarget == null)
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

            addModFile();
        }

        private void btPack_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            btPack.Enabled = false;

            ShowOutput();

            ClearOutput();

            saveAllFiles();

            var taskPackMod = packMod();
            while (!taskPackMod.IsCompleted) { Application.DoEvents(); }

            var taskMetaData = createModMetaData();
            while (!taskMetaData.IsCompleted) { Application.DoEvents(); }

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
            if(Output != null && !Output.IsDisposed)
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

            if (ActiveMod.InstallAsDLC)
            {
                gameModDir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath), @"..\..\DLC\", modName);
            }
            else
            {
                gameModDir = Path.Combine(Path.GetDirectoryName(MainController.Get().Configuration.ExecutablePath), @"..\..\Mods\", modName);
            }

            if (!Directory.Exists(gameModDir))
                Directory.CreateDirectory(gameModDir);

            var dirs = Directory.GetDirectories(packedDir, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativePath = dir.Substring(packedDir.Length+1);

                var fulldir = Path.Combine(gameModDir, relativePath);

                if (!Directory.Exists(fulldir))
                    Directory.CreateDirectory(fulldir);
            }

            var files = Directory.GetFiles(packedDir, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativePath = file.Substring(packedDir.Length+1);

                var fullpath = Path.Combine(gameModDir, relativePath);

                File.Copy(file, fullpath, true);
            }

            AddOutput("Mod Installed to "+gameModDir+"\n");
        }

        private async Task packMod()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.WCC_Lite);
            proc.WorkingDirectory = Path.GetDirectoryName(config.WCC_Lite);
            var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");
            var uncookedDir = ActiveMod.FileDirectory;
            if (!Directory.Exists(packedDir))
                Directory.CreateDirectory(packedDir);

            proc.Arguments = string.Format("pack -dir={0} -outdir={1}", uncookedDir, packedDir);
            proc.UseShellExecute = false;
            proc.RedirectStandardOutput = true;
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.CreateNoWindow = true;

            AddOutput("Executing " + proc.FileName + " " +proc.Arguments + "\n");

            using (Process process = Process.Start(proc))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    while (true)
                    {
                        string result = await reader.ReadLineAsync();

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
            var proc = new ProcessStartInfo(config.WCC_Lite);
            proc.WorkingDirectory = Path.GetDirectoryName(config.WCC_Lite);
            var packedDir = Path.Combine(ActiveMod.Directory, @"packed\content\");

            proc.Arguments = string.Format("metadatastore -path={0}", packedDir);
            proc.UseShellExecute = false;
            proc.RedirectStandardOutput = true;
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.CreateNoWindow = true;

            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            using (Process process = Process.Start(proc))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    while (true)
                    {
                        string result = await reader.ReadLineAsync();

                        AddOutput(result + "\n");

                        Application.DoEvents();

                        if (reader.EndOfStream)
                            break;
                    }
                }
            }
        }

        private frmCR2WDocument activedocument;
        public frmCR2WDocument ActiveDocument {
            get 
            { 
                return activedocument; 
            }
            set
            {
                activedocument = value;
                UpdateTitle();
            }
        }

        private void btRunGame_Click(object sender, EventArgs e)
        {
            ClearOutput();
            ShowOutput();

            executeGame();
        }

        private async void executeGame()
        {
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.ExecutablePath);
            proc.WorkingDirectory = Path.GetDirectoryName(config.ExecutablePath);

            proc.Arguments = "-debugscripts";

            proc.UseShellExecute = false;
            proc.RedirectStandardOutput = true;

            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            var documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            if(File.Exists(scriptlog))
                File.Delete(scriptlog);

            using (Process process = Process.Start(proc))
            {
                //var task1 = RedirectProcessOutput(process);
                var task2 = RedirectScriptlogOutput(process);

                //await task1;
                await task2;
            }
        }

        private async Task RedirectScriptlogOutput(Process process)
        {
            var documents = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            using (FileStream fs = new FileStream(scriptlog, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var fsr = new StreamReader(fs))
                {

                    while (!process.HasExited)
                    {
                        string result = await fsr.ReadToEndAsync();

                        AddOutput(result);

                        Application.DoEvents();
                    }
                }

                fs.Close();
            }
        }

        private async Task RedirectProcessOutput(Process process)
        {
            using (StreamReader reader = process.StandardOutput)
            {
                while (true)
                {
                    string result = await reader.ReadLineAsync();

                    AddOutput(result + "\n");

                    Application.DoEvents();

                    if (reader.EndOfStream)
                        break;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var Exit = false;
            while (!File.Exists(MainController.Get().Configuration.ExecutablePath))
            {
                var sets = new frmSettings();
                if (sets.ShowDialog() != System.Windows.Forms.DialogResult.OK)
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
            addModFile();
        }

        private void modSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            using (var dlg = new frmModSettings())
            {
                dlg.Mod = ActiveMod;

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    UpdateTitle();
                    SaveMod();
                }
            }
        }


    }
}
