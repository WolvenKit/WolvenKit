using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Bundles;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Services;

namespace WolvenKit
{
    using Common;
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using WolvenKit.CR2W;
    using WolvenKit.Render;

    public partial class frmModExplorer : DockContent, IThemedContent
    {
        public frmModExplorer(ILoggerService logger)
        {
            InitializeComponent();
            UpdateModFileList(true,true);
            LastChange = DateTime.Now;
            ApplyCustomTheme();

            importAsToolStripMenuItem.DropDown.MouseClick += DropDown_Click;
            Logger = logger;
        }

        public W3Mod ActiveMod
        {
            get { return MainController.Get().ActiveMod; }
            set { MainController.Get().ActiveMod = value; }
        }

        public event EventHandler<RequestFileArgs> RequestFileOpen;
        public event EventHandler<RequestFileArgs> RequestFileDelete;
        public event EventHandler<RequestFileArgs> RequestAssetBrowser;
        public event EventHandler<RequestFileArgs> RequestFileRename;
        public event EventHandler<RequestImportArgs> RequestFileImport;
        public event EventHandler<RequestFileArgs> RequestFileCook;
        public event EventHandler<RequestFileArgs> RequestFileDumpfile;
        public List<string> FilteredFiles; 
        public bool FoldersShown = true;

        public static DateTime LastChange;
        public static TimeSpan mindiff = TimeSpan.FromMilliseconds(500);
        private ILoggerService Logger;

        public void PauseMonitoring()
        {
            modexplorerSlave.EnableRaisingEvents = false;
        }

        public void ResumeMonitoring()
        {
            modexplorerSlave.EnableRaisingEvents = true;
        }

        public bool DeleteNode(string fullpath)
        {
            var parts = fullpath.Split('\\');
            var current = modFileList.Nodes;
            for (var i = 0; i < parts.Length; i++)
            {
                if (current.ContainsKey(parts[i]))
                {
                    var node = current[parts[i]];
                    current = node.Nodes;

                    if (i == parts.Length - 1)
                    {
                        node.Remove();
                        return true;
                    }
                }
                else
                {
                    break;
                }
            }

            return false;
        }

        public void UpdateModFileList(bool showfolders,bool clear = false)
        {
            if (ActiveMod == null)
                return;
            modFileList.BeginUpdate();
            if (FilteredFiles == null || FilteredFiles.Count == 0)
            {
                FilteredFiles = ActiveMod.Files;
            }
            if (clear)
            {
                modFileList.Nodes.Clear();
            }

            foreach (var item in FilteredFiles)
            {
                var current = modFileList.Nodes;
                if (!showfolders)
                {
                    var newNode = current.Add(item, item);
                    if (treeImages.Images.ContainsKey(Path.GetExtension(item).Replace(".", "")))
                    {
                        newNode.ImageKey = Path.GetExtension(item).Replace(".", "");
                        newNode.ImageKey = Path.GetExtension(item).Replace(".", "");
                    }
                    else
                    {
                        newNode.ImageKey = "genericFile";
                        newNode.ImageKey = "genericFile";
                    }
                }
                else
                {
                    var parts = item.Split('\\');
                    for (var i = 0; i < parts.Length; i++)
                    {
                        if (!current.ContainsKey(parts[i]))
                        {

                            var newNode = current.Add(parts[i], parts[i]);
                            if (i == parts.Length - 1)
                            {
                                if (treeImages.Images.ContainsKey(Path.GetExtension(item).Replace(".", "")))
                                {
                                    newNode.ImageKey = Path.GetExtension(item).Replace(".", "");
                                    newNode.ImageKey = Path.GetExtension(item).Replace(".", "");
                                }
                                else
                                {
                                    newNode.ImageKey = "genericFile";
                                    newNode.ImageKey = "genericFile";
                                }
                            }
                            else
                            {
                                newNode.ImageKey = "FolderOpened";
                                newNode.SelectedImageKey = "FolderOpened";
                            }
                            newNode.Parent?.Expand();
                            current = newNode.Nodes;
                        }
                        else
                        {
                            current = current[parts[i]].Nodes;
                        }
                    }

                }
            }
            modFileList.EndUpdate();
        }

        private void modFileList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            RequestFileOpen?.Invoke(this, new RequestFileArgs {File = e.Node.FullPath});
        }

        private void cookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                RequestFileCook?.Invoke(this, new RequestFileArgs { File = modFileList.SelectedNode.FullPath });
            }
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                RequestFileDelete?.Invoke(this, new RequestFileArgs {File = modFileList.SelectedNode.FullPath});
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
                    if (modFileList.SelectedNode != null)
                    {
                        newfilepath = Path.Combine(ActiveMod.FileDirectory, modFileList.SelectedNode.FullPath);
                        if (File.Exists(newfilepath))
                            newfilepath = Path.GetDirectoryName(newfilepath);
                        newfilepath = Path.Combine(newfilepath, fi.Name);
                    }
                    if (File.Exists(newfilepath))
                        newfilepath = $"{newfilepath.TrimEnd(fi.Extension.ToCharArray())} - copy{fi.Extension}";
                    fi.CopyTo(newfilepath, false);
                }
                catch (Exception)
                {
                }
            }
        }

        private void openAssetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestAssetBrowser?.Invoke(this,new RequestFileArgs {File = GetExplorerString(modFileList.SelectedNode?.FullPath ?? "")});
        }

        private void modFileList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                modFileList.SelectedNode = e.Node;
                //contextMenu.Show(modFileList, e.Location);
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                RequestFileRename?.Invoke(this, new RequestFileArgs {File = modFileList.SelectedNode.FullPath});
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                Clipboard.SetText(MainController.Get().ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Clipboard.GetText()))
            {
                FileAttributes attr = File.GetAttributes(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    SafeCopy(Clipboard.GetText(), ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
                else
                {
                    SafeCopy(Clipboard.GetText(), Path.GetDirectoryName(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath) + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
            }
        }

        private void contextMenu_Opened(object sender, EventArgs e)
        {
            var selectedNode = modFileList.SelectedNode;
            string ext = "";

            if (selectedNode != null)
            {
                var fi = new FileInfo(selectedNode.FullPath);
                ext = fi.Extension.TrimStart('.');

                bool isbundle = Path.Combine(ActiveMod.FileDirectory, fi.ToString()).Contains(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName));
                bool israw = Path.Combine(ActiveMod.FileDirectory, fi.ToString()).Contains(Path.Combine(ActiveMod.FileDirectory, "Raw"));


                cookToolStripMenuItem.Enabled = (!Enum.GetNames(typeof(EImportable)).Contains(ext) && !isbundle && !israw);
                markAsModDlcFileToolStripMenuItem.Enabled = isbundle;

                importAsToolStripMenuItem.Enabled = Enum.GetNames(typeof(EImportable)).Contains(ext) && !isbundle && israw;
                importAsToolStripMenuItem.DropDown.Items.Clear();
                var types = REDTypes.RawExtensionToRedImport(ext);
                foreach (var t in types)
                {
                    importAsToolStripMenuItem.DropDown.Items.Add(t);
                }
                
            } 

            pasteToolStripMenuItem.Enabled = File.Exists(Clipboard.GetText());

            removeFileToolStripMenuItem.Enabled = modFileList.SelectedNode != null;
            renameToolStripMenuItem.Enabled = modFileList.SelectedNode != null;
            copyRelativePathToolStripMenuItem.Enabled = modFileList.SelectedNode != null;
            copyToolStripMenuItem.Enabled = modFileList.SelectedNode != null;
            
            showFileInExplorerToolStripMenuItem.Enabled = modFileList.SelectedNode != null;
            dumpXMLToolStripMenuItem.Enabled = modFileList.SelectedNode != null && ext != "xml" && ext != "csv" && ext != "ws" && ext != "";
            dumpChunksToXMLToolStripMenuItem.Enabled = modFileList.SelectedNode != null && ext != "xml" && ext != "csv" && ext != "ws" && ext != "";

        }

        private async void DropDown_Click(object sender, EventArgs e)
        {
            ToolStripDropDownMenu menuitem = sender as ToolStripDropDownMenu;
            var items = menuitem.Items.Cast<ToolStripMenuItem>().ToList();
            var selectedItem = items.FirstOrDefault(_ => _.Selected);

            if (menuitem != null && selectedItem != null && modFileList.SelectedNode != null)
            {
                var ext = selectedItem.Text;
                RequestFileImport?.Invoke(this, new RequestImportArgs { File = modFileList.SelectedNode.FullPath, Extension = ext });
            }
        }

        public static IEnumerable<string> FallbackPaths(string path)
        {
            yield return path;

            var dir = Path.GetDirectoryName(path);
            var file = Path.GetFileNameWithoutExtension(path);
            var ext = Path.GetExtension(path);

            yield return Path.Combine(dir, file + " - Copy" + ext);
            for (var i = 2; ; i++)
            {
                yield return Path.Combine(dir, file + " - Copy " + i + ext);
            }
        }
        public static void SafeCopy(string src, string dest)
        {
            foreach (var path in FallbackPaths(dest).Where(path => !File.Exists(path)))
            {
                File.Copy(src, path);
                break;
            }
        }

        private void showhideButton_Click(object sender, EventArgs e)
        {
            FoldersShown = !FoldersShown;
            UpdateModFileList(FoldersShown,true);
        }

        private void UpdatefilelistButtonClick(object sender, EventArgs e)
        {
            FoldersShown = true;
            FilteredFiles = ActiveMod.Files;
            UpdateModFileList(true,true);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(ActiveMod == null)
                return;
            if (searchBox.Text == "")
            {
                FilteredFiles = ActiveMod.Files;
                UpdateModFileList(true, true);
                return;
            }
            FilteredFiles = ActiveMod.Files.Where(x => (x.Contains('\\') ? x.Split('\\').Last() : x).ToUpper().Contains(searchBox.Text.ToUpper())).ToList();
            UpdateModFileList(FoldersShown, true);
        }

        private void FileChanges_Detected(object sender, FileSystemEventArgs e)
        {
            FilteredFiles = ActiveMod.Files;
            UpdateModFileList(FoldersShown, true);
        }


        private void frmModExplorer_Shown(object sender, EventArgs e)
        {
            if(ActiveMod != null)
                modexplorerSlave.Path = ActiveMod.FileDirectory;
        }

        private void modFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && modFileList.SelectedNode != null)
            {
                RequestFileRename?.Invoke(this, new RequestFileArgs { File = modFileList.SelectedNode.FullPath });
            }
        }

        private void showFileInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                Commonfunctions.ShowFileInExplorer(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
            }
        }

        private void dumpXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                DumpXML(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
            }

            void DumpXML(string filepath)
            {
                try
                {
                    string fileName = filepath + ".xml";
                    using (var writer = new FileStream(fileName, FileMode.Create))
                    using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                    using (var reader = new BinaryReader(fs))
                    {
                        var File = new CR2W.CR2WFile(reader);
                        File.SerializeToXml(writer);
                    }
                    Logger.LogString("Dumping XML successful.", Logtype.Success);
                }
                catch (Exception ex)
                {
                    Logger.LogString("Dumping XML failed.", Logtype.Error);
                }
            }
        }

        private void dumpChunksToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                SaveFileDialog sFileDialog = new SaveFileDialog
                {
                    Filter = "XML File|*.xml",
                    Title = "Save XML File",
                    InitialDirectory = MainController.Get().Configuration.InitialFileDirectory + "\\" + modFileList.SelectedNode.FullPath,
                    OverwritePrompt = true,
                    FileName = ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath + ".chunk.xml"
                };
                
                DialogResult result = sFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream writer = new FileStream(sFileDialog.FileName, FileMode.Create);
                    DumpChunkXML(writer);
                }
            }

            void DumpChunkXML(FileStream writer)
            {
                try
                {
                    string filePath = ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath;
                    string fileName = writer.Name;
                    
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (var reader = new BinaryReader(fs))
                    {
                        var File = new CR2W.CR2WFile(reader);
                        File.FileName = modFileList.SelectedNode.FullPath;
                        File.SerializeChunksToXml(writer);

                        writer.Flush();
                        writer.Close();
                    }

                    //vl: ugly way to suppress ugly xmlns
                    string text = "";
                    using (StreamReader streamReader = File.OpenText(fileName)) //vl: TODO: what about encoding??
                    {
                        text = streamReader.ReadToEnd();
                        text = text.Replace(" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"", "");
                    }
                    File.WriteAllText(fileName, text);
                    
                    Logger.LogString("Dumping chunks XML successful.", Logtype.Success);
                }
                catch (Exception ex)
                {
                    Logger.LogString(ex.Message, Logtype.Error);
                    Logger.LogString(ex.StackTrace, Logtype.Error);
                    Logger.LogString("Dumping chunks XML failed.", Logtype.Error);
                }
            }
        }

        private void ExpandBTN_Click(object sender, EventArgs e)
        {
            modFileList.ExpandAll();
        }

        private void CollapseBTN_Click(object sender, EventArgs e)
        {
            modFileList.CollapseAll();
        }

        public void StopMonitoringDirectory()
        {
            modexplorerSlave.Dispose();
        }

        private void copyRelativePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(modFileList.SelectedNode != null)
                Clipboard.SetText(GetArchivePath(modFileList.SelectedNode.FullPath));
        }

        private void markAsModDlcFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                var filename = modFileList.SelectedNode.FullPath;
                var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
                if (!File.Exists(fullpath))
                    return;
                var newfullpath = Path.Combine(new[] { ActiveMod.FileDirectory, filename.Split('\\')[0] == "DLC" ? "Mod" : "DLC" }.Concat(filename.Split('\\').Skip(1).ToArray()).ToArray());

                if (File.Exists(newfullpath))
                    return;
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(newfullpath));
                }
                catch
                {
                }
                File.Move(fullpath, newfullpath);
                MainController.Get().ProjectStatus = "File moved";
            }
        }

        public string GetExplorerString(string s)
        {
            if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 1)
            {
                var r = string.Join(Path.DirectorySeparatorChar.ToString(), new[] { "Root" }.Concat(s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(1)).ToArray());
                return string.Join(Path.DirectorySeparatorChar.ToString(), new[] {"Root" }.Concat(s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(1)).ToArray());
            }
            else
                return s;
        }

        public string GetArchivePath(string s)
        {
            if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 2)
            {
                return string.Join(Path.DirectorySeparatorChar.ToString(), s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(2).ToArray());
            }
            else
                return s;
        }

        public void ApplyCustomTheme()
        {
            var theme = MainController.Get().GetTheme();
            MainController.Get().ToolStripExtender.SetStyle(searchstrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            this.modFileList.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;

            this.modFileList.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;

            this.searchBox.BackColor = theme.ColorPalette.ToolWindowCaptionButtonInactiveHovered.Background;
        }


        private void exportw2rigjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
                Console.WriteLine(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
            string w2rigFilePath = ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath;
            using (var sf = new SaveFileDialog())
            {
                sf.Filter = "W3 json | *.json";
                sf.FileName = Path.GetFileName(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath + ".json");
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    CommonData cdata = new CommonData();
                    Rig exportRig = new Rig(cdata);
                    byte[] data;
                    data = File.ReadAllBytes(w2rigFilePath);
                    using (MemoryStream ms = new MemoryStream(data))
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        CR2WFile rigFile = new CR2WFile(br);
                        exportRig.LoadData(rigFile);
                        exportRig.SaveRig(sf.FileName);
                    }
                    MessageBox.Show(this, "Sucessfully wrote file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void exportW2animsjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new frmAnims(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath,
                                        ActiveMod.FileDirectory + "\\" + "Mod\\Bundle\\characters\\base_entities\\woman_base\\woman_base.w2rig");
            settings.ShowDialog();
        }

        private void exportW2cutscenejsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new frmAnims(ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath,
                                        ActiveMod.FileDirectory + "\\" + "Mod\\Bundle\\characters\\base_entities\\woman_base\\woman_base.w2rig");
            settings.ShowDialog();
        }

        private void exportW3facjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportw2rigjsonToolStripMenuItem_Click(sender, e);
        }
        private void exportW3facposejsonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                exportw2rigjsonToolStripMenuItem.Visible = Path.GetExtension(modFileList.SelectedNode.Name) == ".w2rig";
                exportW2animsjsonToolStripMenuItem.Visible = Path.GetExtension(modFileList.SelectedNode.Name) == ".w2anims";
                exportW2cutscenejsonToolStripMenuItem.Visible = Path.GetExtension(modFileList.SelectedNode.Name) == ".w2cutscene";
                exportW3facjsonToolStripMenuItem.Visible = Path.GetExtension(modFileList.SelectedNode.Name) == ".w3fac";
                exportW3facposejsonToolStripMenuItem.Visible = Path.GetExtension(modFileList.SelectedNode.Name) == ".w3fac";
            }
        }

        private void createW2animsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                var filename = modFileList.SelectedNode.FullPath;
                var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
                if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                    return;
                string dir;
                if (File.Exists(fullpath))
                    dir = Path.GetDirectoryName(fullpath);
                else
                    dir = fullpath;
                var files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).ToList();
                var folderName = Path.GetFileName(fullpath);
                ConvertAnimation anim = new ConvertAnimation();
                if (File.Exists(fullpath+".w2anims"))
                {
                    if (MessageBox.Show(
                         folderName + ".w2anims already exists. This file will be overwritten. Are you sure you want to permanently overwrite "+ folderName +" w2anims?"
                         , "Confirmation", MessageBoxButtons.YesNo
                     ) != DialogResult.Yes)
                    {
                        return;
                    }
                }

                try
                {
                    anim.Load(files, fullpath + ".w2anims");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error cooking files.");
                }
            }
        }

        private async void dumpWccliteXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modFileList.SelectedNode != null)
            {
                RequestFileDumpfile?.Invoke(this, new RequestFileArgs { File = modFileList.SelectedNode.FullPath });
            }
        }
    }
}