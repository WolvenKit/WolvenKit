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
    using BrightIdeasSoftware;
    using Common;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using UsefulThings;
    using WolvenKit.App;
    using WolvenKit.Common.Extensions;
    using WolvenKit.Common.Model;
    using WolvenKit.CR2W;
    using WolvenKit.Extensions;
    using WolvenKit.Render;

    public partial class frmModExplorer : DockContent, IThemedContent
    {

        public frmModExplorer(ILoggerService logger)
        {
            InitializeComponent();
            
            LastChange = DateTime.Now;
            ApplyCustomTheme();

            Logger = logger;

            this.treeListView.CanExpandGetter = delegate (object x) {
                return (x is DirectoryInfo) && IsTreeview && (x as DirectoryInfo).HasFilesOrFolders();
            };
            this.treeListView.ChildrenGetter = delegate (object x) {
                DirectoryInfo dir = (DirectoryInfo)x;
                return dir.Exists ? new ArrayList(dir.GetFileSystemInfos()
                    .Where(_ => _.Extension != ".bat")
                    .ToArray()) : new ArrayList();
            };
            treeListView.SmallImageList = new ImageList();
            this.olvColumnName.ImageGetter = delegate (object row) {
                FileSystemInfo file = (FileSystemInfo)row;
                string extension = this.GetFileExtension(file);
                if (!this.treeListView.SmallImageList.Images.ContainsKey(extension))
                {
                    Image smallImage = this.GetSmallIconForFileType(extension);
                    this.treeListView.SmallImageList.Images.Add(extension, smallImage);
                }
                return extension;
            };

            // load saved collapsed dirs
            ExpandedNodesDict = new Dictionary<string, List<string>>();
            //if (ExpandedNodes == null)
                RepopulateTreeView();
            //else
            //    UpdateTreeView();
            treeListView.ExpandAll();
        }

        private const string openDirImageKey = "<ODIR>";
        private const string closedDirImageKey = "<CDIR>";
        private Image GetSmallIconForFileType(string extension)
        {
            extension = extension.TrimStart('.');
            switch (extension)
            {
                case "w2ent": return WolvenKit.Properties.Resources.w2ent;
                case "w2faces": return WolvenKit.Properties.Resources.w2faces;
                case "w2fnt": return WolvenKit.Properties.Resources.w2fnt;
                case "w2je": return WolvenKit.Properties.Resources.w2je;
                case "w2job": return WolvenKit.Properties.Resources.w2job;
                case "w2l": return WolvenKit.Properties.Resources.w2l;
                case "w2mesh": return WolvenKit.Properties.Resources.w2mesh;
                case "w2mg": return WolvenKit.Properties.Resources.w2mg;
                case "w2mi": return WolvenKit.Properties.Resources.w2mi;
                case "w2p": return WolvenKit.Properties.Resources.w2p;
                case "w2phase": return WolvenKit.Properties.Resources.w2phase;
                case "w2quest": return WolvenKit.Properties.Resources.w2quest;
                case "w2rag": return WolvenKit.Properties.Resources.w2rag;
                case "w2ragdoll": return WolvenKit.Properties.Resources.w2ragdoll;
                case "w2rig": return WolvenKit.Properties.Resources.w2rig;
                case "w2scene": return WolvenKit.Properties.Resources.w2scene;
                case "w2steer": return WolvenKit.Properties.Resources.w2steer;
                case "w2w": return WolvenKit.Properties.Resources.w2w;
                case "csv": return WolvenKit.Properties.Resources.csv;
                case "env": return WolvenKit.Properties.Resources.env;
                case "journal": return WolvenKit.Properties.Resources.journal;
                case "redgame": return WolvenKit.Properties.Resources.redgame;
                case "redswf": return WolvenKit.Properties.Resources.redswf;
                case "spawntree": return WolvenKit.Properties.Resources.spawntree;
                case "swf": return WolvenKit.Properties.Resources.swf;
                case "vbrush": return WolvenKit.Properties.Resources.vbrush;
                case "w2anim": return WolvenKit.Properties.Resources.w2anim;
                case "w2animev": return WolvenKit.Properties.Resources.w2animev;
                case "w2anims": return WolvenKit.Properties.Resources.w2anims;
                case "w2beh": return WolvenKit.Properties.Resources.w2beh;
                case "w2behtree": return WolvenKit.Properties.Resources.w2behtree;
                case "w2cent": return WolvenKit.Properties.Resources.w2cent;
                case "w2comm": return WolvenKit.Properties.Resources.w2comm;
                case "w2conv": return WolvenKit.Properties.Resources.w2conv;
                case "w2cube": return WolvenKit.Properties.Resources.w2cube;
                case "w2cutscene": return WolvenKit.Properties.Resources.w2cutscene;

                case closedDirImageKey: return WolvenKit.Properties.Resources.FolderClosed_16x;
                case openDirImageKey: return WolvenKit.Properties.Resources.FolderOpened_16x;
                default: return WolvenKit.Properties.Resources.BlankFile_16x;

            }
        }

        private string GetFileExtension(FileSystemInfo node)
        {
            if (node.IsDirectory())
            {
                if (treeListView.IsExpanded(node))
                    return openDirImageKey;
                else
                    return closedDirImageKey;
            }
            else
                return (node as FileInfo).Extension;
        }

        public W3Mod ActiveMod
        {
            get => MainController.Get().ActiveMod;
            set => MainController.Get().ActiveMod = value;
        }

        public event EventHandler<RequestFileArgs> RequestFileOpen;
        public event EventHandler<RequestFileArgs> RequestFileDelete;
        public event EventHandler<RequestFileArgs> RequestAssetBrowser;
        public event EventHandler<RequestFileArgs> RequestFileRename;
        public event EventHandler<RequestFileArgs> RequestFileCook;
        public event EventHandler<RequestFileArgs> RequestFileDumpfile;
        public event EventHandler<RequestFileArgs> RequestFastRender;

        public bool IsTreeview { get; set; } = true;
        private ObservableCollection<FileSystemInfo> treenodes = new ObservableCollection<FileSystemInfo>();
        public Dictionary<string, List<string>> ExpandedNodesDict { get; set; }

        //private List<ModExplorerNode> treenodes = new List<ModExplorerNode>();
        public static DateTime LastChange;
        public static TimeSpan mindiff = TimeSpan.FromMilliseconds(500);
        private readonly ILoggerService Logger;



        public void PauseMonitoring()
        {
            modexplorerSlave.EnableRaisingEvents = false;
        }

        public void ResumeMonitoring()
        {
            modexplorerSlave.EnableRaisingEvents = true;
            usecachedNodeList = true;
            UpdateTreeView();
        }

        #region Methods
        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            UIController.Get().ToolStripExtender.SetStyle(searchstrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            this.treeListView.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.treeListView.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.DockTarget.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.OverflowButtonHovered.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                }
            };
            this.treeListView.HeaderFormatStyle = hfs;
            treeListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;


            this.searchBox.BackColor = theme.ColorPalette.ToolWindowCaptionButtonInactiveHovered.Background;
        }

        private void RepopulateTreeView()
        {
            if (ActiveMod == null)
                return;
            var di = new DirectoryInfo(ActiveMod.FileDirectory);

            if (IsTreeview)
            {
                treenodes = new ObservableCollection<FileSystemInfo>(di.GetFileSystemInfos("*", SearchOption.TopDirectoryOnly)
                    .Where(_ => _.Extension != ".bat")
                    .ToList());
                treeListView.SetObjects(treenodes);
                UpdateTreeView();
            }
            else
            {
                treenodes = new ObservableCollection<FileSystemInfo>(di.GetFiles("*", SearchOption.AllDirectories)
                    .Where(_ => _.Extension != ".bat")
                    .ToList());
                treeListView.SetObjects(treenodes);
            }
        }

        bool usecachedNodeList;
        private void UpdateTreeView(params string[] nodesToUpdate)
        {
            if (ActiveMod == null)
                return;

            // get branches to update
            var rootNodesToUpdate = new List<FileSystemInfo>();
            // if nodes are specified, update only these branches
            if (nodesToUpdate.Length > 0)
            {
                foreach (var node in nodesToUpdate)
                {
                    var splits = node.Substring(ActiveMod.FileDirectory.Length + 1).Split(Path.DirectorySeparatorChar);
                    var rn = treeListView.TreeModel.RootObjects.OfType<FileSystemInfo>()
                        .FirstOrDefault(_ => _.Name == splits.First());
                    if (!rootNodesToUpdate.Contains(rn))
                        rootNodesToUpdate.Add(rn);
                }
            }
            // if nothing is specified, update all branches
            else
                rootNodesToUpdate = treeListView.TreeModel.RootObjects.OfType<FileSystemInfo>().ToList();


            // rebuild the branches
            foreach (var rootNode in rootNodesToUpdate)
            {
                if (rootNode == null)
                    return;
                // log expanded state
                if (usecachedNodeList)
                {
                    usecachedNodeList = false;
                }   
                else
                {
                    var branch = treeListView.TreeModel.GetBranch(rootNode);
                    var fbr = branch.Flatten();
                    var expandedNodes = fbr.OfType<FileSystemInfo>()
                        .Select(_ => _.GetParent().FullName)
                        .Where(_ => _ != rootNode.FullName)
                        .Distinct()
                        .ToList();

                    if (ExpandedNodesDict.ContainsKey(rootNode.Name))
                        ExpandedNodesDict[rootNode.Name] = expandedNodes;
                    else
                        ExpandedNodesDict.Add(rootNode.Name, expandedNodes);
                }
                

                treeListView.RefreshObject(rootNode);

                // rebuild branch
                foreach (string fullpath in ExpandedNodesDict[rootNode.Name])
                {
                    var count = treeListView.TreeModel.GetObjectCount();
                    for (int i = 0; i < count; i++)
                    {
                        var nthobj = treeListView.TreeModel.GetNthObject(i);
                        if ((nthobj as FileSystemInfo).FullName == fullpath)
                        {
                            treeListView.Expand(nthobj);
                            break;
                        }
                    }
                }
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
        #endregion


        #region Control Events

        private void cookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestFileCook?.Invoke(this, new RequestFileArgs { File = selectedobject.FullName });
            }
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                if (!(selectedobject.FullName == ActiveMod.ModDirectory 
                    || selectedobject.FullName == ActiveMod.DlcDirectory
                    || selectedobject.FullName == ActiveMod.RawDirectory
                    || selectedobject.FullName == ActiveMod.RadishDirectory))
                RequestFileDelete?.Invoke(this, new RequestFileArgs {File = selectedobject.FullName });
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
                    if (treeListView.SelectedObject is FileSystemInfo selectedobject)
                    {
                        newfilepath = Path.Combine(ActiveMod.FileDirectory, selectedobject.FullName);
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
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
                RequestAssetBrowser?.Invoke(this,new RequestFileArgs {File = GetExplorerString(selectedobject.FullName ?? "")});

            string GetExplorerString(string s)
            {
                s = s.Substring(ActiveMod.FileDirectory.Length + 1);
                if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 1)
                {
                    var r = string.Join(Path.DirectorySeparatorChar.ToString(), new[] { "Root" }.Concat(s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(1)).ToArray());
                    return string.Join(Path.DirectorySeparatorChar.ToString(), new[] { "Root" }.Concat(s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(1)).ToArray());
                }
                else
                    return s;
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestFileRename?.Invoke(this, new RequestFileArgs {File = selectedobject.FullName });
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                Clipboard.SetText(selectedobject.FullName);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Clipboard.GetText()) && treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                FileAttributes attr = File.GetAttributes(selectedobject.FullName);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    SafeCopy(Clipboard.GetText(), selectedobject.FullName + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
                else
                {
                    SafeCopy(Clipboard.GetText(), Path.GetDirectoryName(selectedobject.FullName) + "\\" + Path.GetFileName(Clipboard.GetText()));
                }
            }
        }

        private void contextMenu_Opened(object sender, EventArgs e)
        {
            string ext = "";

            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var fi = new FileInfo(selectedobject.FullName);
                ext = fi.Extension.TrimStart('.');
                bool isbundle = Path.Combine(ActiveMod.FileDirectory, fi.ToString()).Contains(Path.Combine(ActiveMod.ModDirectory, new Bundle().TypeName));
                bool israw = Path.Combine(ActiveMod.FileDirectory, fi.ToString()).Contains(ActiveMod.RadishDirectory);
                bool isToplevelDir = selectedobject.FullName == ActiveMod.ModDirectory
                        || selectedobject.FullName == ActiveMod.DlcDirectory
                        || selectedobject.FullName == ActiveMod.RawDirectory
                        || selectedobject.FullName == ActiveMod.RadishDirectory;

                createW2animsToolStripMenuItem.Enabled = !isToplevelDir;
                exportToolStripMenuItem.Enabled = !isToplevelDir;

                removeFileToolStripMenuItem.Enabled = !isToplevelDir;
                renameToolStripMenuItem.Enabled = !isToplevelDir;
                copyRelativePathToolStripMenuItem.Enabled = !isToplevelDir;
                copyToolStripMenuItem.Enabled = !isToplevelDir;
                pasteToolStripMenuItem.Enabled = File.Exists(Clipboard.GetText());

                cookToolStripMenuItem.Enabled = (!Enum.GetNames(typeof(EImportable)).Contains(ext) && !isbundle && !israw);
                markAsModDlcFileToolStripMenuItem.Enabled = isbundle && !isToplevelDir;

                showFileInExplorerToolStripMenuItem.Text = selectedobject.IsDirectory() ? "Open Folder in Explorer" : "Open File in Explorer";
            }

            showFileInExplorerToolStripMenuItem.Enabled = treeListView.SelectedObject != null;
            dumpXMLToolStripMenuItem.Enabled = treeListView.SelectedObject != null && ext != "xml" && ext != "csv" && ext != "ws" && ext != "";
            dumpChunksToXMLToolStripMenuItem.Enabled = treeListView.SelectedObject != null && ext != "xml" && ext != "csv" && ext != "ws" && ext != "";

        }

        private void showhideButton_Click(object sender, EventArgs e)
        {
            IsTreeview = !IsTreeview;
            RepopulateTreeView();
        }

        private void UpdatefilelistButtonClick(object sender, EventArgs e)
        {
            searchBox.Clear();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(ActiveMod == null)
                return;

            if (!string.IsNullOrEmpty(searchBox.Text))
                treeListView.ModelFilter = TextMatchFilter.Contains(treeListView, searchBox.Text.ToUpper());
            else
                treeListView.ModelFilter = null;
        }

        private void FileChanges_Detected(object sender, FileSystemEventArgs e)
        {
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    {
                        UpdateTreeView(e.FullPath);
                        break;
                    }
                case WatcherChangeTypes.Deleted:
                    {
                        UpdateTreeView(e.FullPath);
                        break;
                    }
                case WatcherChangeTypes.Renamed:
                    {
                        UpdateTreeView((e as RenamedEventArgs).OldFullPath);
                        break;
                    }
                case WatcherChangeTypes.Changed:
                case WatcherChangeTypes.All:
                default:
                    throw new NotImplementedException();
            }
        }


        private void frmModExplorer_Shown(object sender, EventArgs e)
        {
            if(ActiveMod != null)
                modexplorerSlave.Path = ActiveMod.FileDirectory;
        }

        private void modFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestFileRename?.Invoke(this, new RequestFileArgs { File = selectedobject.FullName });
            }
        }

        private void showFileInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                Commonfunctions.ShowFileInExplorer(selectedobject.FullName);
            }
        }

        private void dumpXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                DumpXML(selectedobject.FullName);
            }

            void DumpXML(string filepath)
            {
                try
                {
                    string fileName = $"{filepath}.h.xml";
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
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                SaveFileDialog sFileDialog = new SaveFileDialog
                {
                    Filter = "XML File|*.xml",
                    Title = "Save XML File",
                    InitialDirectory = selectedobject.FullName,
                    OverwritePrompt = true,
                    FileName = selectedobject.FullName + ".chunk.xml"
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
                    
                    string filePath = selectedobject.FullName;
                    string fileName = writer.Name;

                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (var reader = new BinaryReader(fs))
                    {
                        var File = new CR2W.CR2WFile(reader);
                        File.FileName = selectedobject.FullName;
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
            treeListView.ExpandAll();
        }

        private void CollapseBTN_Click(object sender, EventArgs e)
        {
            treeListView.CollapseAll();
        }

        public void StopMonitoringDirectory()
        {
            modexplorerSlave.Dispose();
        }

        private void copyRelativePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
                Clipboard.SetText(GetArchivePath(selectedobject.FullName));

            string GetArchivePath(string s)
            {
                if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 2)
                {
                    var relpath = s.Substring(ActiveMod.FileDirectory.Length + 1);
                    return string.Join(Path.DirectorySeparatorChar.ToString(), relpath.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(2).ToArray());
                }
                else
                    return s;
            }
        }

        private void markAsModDlcFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var filename = selectedobject.FullName;
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

        private void exportw2rigjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                Console.WriteLine(selectedobject.FullName);
                string w2rigFilePath = selectedobject.FullName;
                using (var sf = new SaveFileDialog())
                {
                    sf.Filter = "W3 json | *.json";
                    sf.FileName = Path.GetFileName(selectedobject.FullName + ".json");
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
        }

        private void exportW2animsjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var settings = new frmAnims(selectedobject.FullName,
                                        ActiveMod.FileDirectory + "\\" + "Mod\\Bundle\\characters\\base_entities\\woman_base\\woman_base.w2rig");
                settings.ShowDialog();
            }
        }

        private void exportW2cutscenejsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var settings = new frmAnims(selectedobject.FullName,
                                        ActiveMod.FileDirectory + "\\" + "Mod\\Bundle\\characters\\base_entities\\woman_base\\woman_base.w2rig");
                settings.ShowDialog();
            }
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
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                exportw2rigjsonToolStripMenuItem.Visible = Path.GetExtension(selectedobject.Name) == ".w2rig";
                exportW2animsjsonToolStripMenuItem.Visible = Path.GetExtension(selectedobject.Name) == ".w2anims";
                exportW2cutscenejsonToolStripMenuItem.Visible = Path.GetExtension(selectedobject.Name) == ".w2cutscene";
                exportW3facjsonToolStripMenuItem.Visible = Path.GetExtension(selectedobject.Name) == ".w3fac";
                exportW3facposejsonToolStripMenuItem.Visible = Path.GetExtension(selectedobject.Name) == ".w3fac";
                fastRenderToolStripMenuItem.Enabled = Path.GetExtension(selectedobject.Name) == ".w2mesh";
            }
        }

        private void createW2animsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var filename = selectedobject.FullName;
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
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestFileDumpfile?.Invoke(this, new RequestFileArgs { File = selectedobject.FullName });
            }
        }
        private void fastRenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestFastRender?.Invoke(this, new RequestFileArgs { File = selectedobject.FullName });
            }
        }
        #endregion

        private void treeListView_CellClick(object sender, CellClickEventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject && e.Item != null)
            {
                var node = (FileSystemInfo)e.Item.RowObject;

                if (e.ClickCount == 1)
                {
                    if (!selectedobject.IsDirectory())
                        RequestFileOpen?.Invoke(this, new RequestFileArgs { File = node.FullName, Inspect = true });
                }
            }
        }

        private void treeListView_CellRightClick(object sender, CellRightClickEventArgs e)
        {

        }

        private void treeListView_Expanded(object sender, TreeBranchExpandedEventArgs e)
        {
        }

        private void treeListView_Collapsed(object sender, TreeBranchCollapsedEventArgs e)
        {
        }

        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                if (!selectedobject.IsDirectory())
                    RequestFileOpen?.Invoke(this, new RequestFileArgs { File = selectedobject.FullName });
                else
                    treeListView.ToggleExpansion(selectedobject);
            }
        }
    }
}