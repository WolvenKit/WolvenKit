using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Services;
using WolvenKit.Common.Wcc;
using WolvenKit.Properties;
using WolvenKit.Services;

namespace WolvenKit
{
    using BrightIdeasSoftware;
    using Common;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading.Tasks;
    using App;
    using App.Commands;
    using App.ViewModels;
    using Common.Extensions;
    using Common.Model;
    using CR2W;
    using Render;
    using Dfust.Hotkeys;

    public partial class frmModExplorer : DockContent, IThemedContent
    {
        private readonly ModExplorerViewModel vm;

        public frmModExplorer()
        {
            // initialize Viewmodel
            vm = MockKernel.Get().GetModExplorerModel();
            vm.PropertyChanged += ViewModel_PropertyChanged;
            //vm.UpdateMonitoringRequest += (sender, e) => this.ViewModel_UpdateMonitoringRequest(e);

            InitializeComponent();
            ApplyCustomTheme();

            // Init ObjectListView
            this.treeListView.CanExpandGetter = delegate (object x) {
                return (x is DirectoryInfo) && vm.IsTreeview && (x as DirectoryInfo).HasFilesOrFolders();
            };
            this.treeListView.ChildrenGetter = delegate (object x) {
                DirectoryInfo dir = (DirectoryInfo)x;
                return dir.Exists ? new ArrayList(dir.GetFileSystemInfos()
                    .Where(_ => _.Extension != ".bat")
                    .ToArray()) : new ArrayList();
            };
            treeListView.SmallImageList = new ImageList();
            this.olvColumnName.ImageGetter = delegate (object row) {
                string extension = this.GetFileExtension(row);
                if (!this.treeListView.SmallImageList.Images.ContainsKey(extension))
                {
                    Image smallImage = GetSmallIconForFileType(extension);
                    this.treeListView.SmallImageList.Images.Add(extension, smallImage);
                }
                return extension;
            };
            treeListView.RevealAfterExpand=false;

            // Update the TreeView
            vm.RepopulateTreeView();
            treeListView.ExpandAll();
        }

        #region Properties

        private static W3Mod ActiveMod => MainController.Get().ActiveMod;

        public event EventHandler<RequestFileOpenArgs> RequestAssetBrowser;
        public event EventHandler<RequestFileOpenArgs> RequestFileOpen;
        public event EventHandler<RequestFileOpenArgs> RequestFileRename;
        public event EventHandler<RequestFileOpenArgs> RequestFastRender;
        public event EventHandler<RequestFileDeleteArgs> RequestFileDelete;
        #endregion



        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != nameof(vm.treenodes)) return;
            this.treeListView.SetObjects(vm.treenodes);
            UpdateTreeView(true);
        }

        private void frmModExplorer_Shown(object sender, EventArgs e)
        {
            
        }



        #region Methods
        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(searchstrip, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetTheme());

            this.treeListView.BackColor = UIController.GetBackColor();
            this.treeListView.ForeColor = UIController.GetForeColor();

            this.treeListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            treeListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;

            this.searchBox.BackColor = UIController.GetPalette().ToolWindowCaptionButtonInactiveHovered.Background;
            this.searchBox.ForeColor = UIController.GetForeColor();

        }

        public void UpdateTreeView(bool usecachedNodeList, params string[] nodesToUpdate)
        {
            if (MainController.Get().ActiveMod == null)
                return;

            // get branches to update
            var rootNodesToUpdate = new List<FileSystemInfo>();
            // if nodes are specified, update only these branches
            if (nodesToUpdate.Length > 0)
            {
                foreach (var node in nodesToUpdate)
                {
                    var splits = node.Substring(MainController.Get().ActiveMod.FileDirectory.Length + 1).Split(Path.DirectorySeparatorChar);
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
                //if (usecachedNodeList)
                //{
                //    usecachedNodeList = false;
                //}   
                //else
                {
                    var branch = treeListView.TreeModel.GetBranch(rootNode);
                    var fbr = branch.Flatten();
                    var expandedNodes = fbr.OfType<FileSystemInfo>()
                        .Select(_ => _.GetParent().FullName)
                        .Where(_ => _ != rootNode.FullName)
                        .Distinct()
                        .ToList();

                    if (vm.ExpandedNodesDict.ContainsKey(rootNode.Name))
                        vm.ExpandedNodesDict[rootNode.Name] = expandedNodes;
                    else
                        vm.ExpandedNodesDict.Add(rootNode.Name, expandedNodes);
                }
                

                treeListView.RefreshObject(rootNode);

                // rebuild branch
                if (vm.ExpandedNodesDict != null && vm.ExpandedNodesDict.Count > 0)
                    foreach (string fullpath in vm.ExpandedNodesDict[rootNode.Name])
                    {
                        var count = treeListView.TreeModel.GetObjectCount();
                        for (int i = 0; i < count; i++)
                        {
                            var nthobj = treeListView.TreeModel.GetNthObject(i);
                            if ((nthobj as FileSystemInfo)?.FullName == fullpath)
                            {
                                treeListView.Expand(nthobj);
                                break;
                            }
                        }
                    }
            }
        }

        private const string OpenDirImageKey = "<ODIR>";
        private const string ClosedDirImageKey = "<CDIR>";
        private static Image GetSmallIconForFileType(string extension)
        {
            extension = extension.TrimStart('.');
            switch (extension)
            {
                case "w2ent": return Resources.w2ent;
                case "w2faces": return Resources.w2faces;
                case "w2fnt": return Resources.w2fnt;
                case "w2je": return Resources.w2je;
                case "w2job": return Resources.w2job;
                case "w2l": return Resources.w2l;
                case "w2mesh": return Resources.w2mesh;
                case "w2mg": return Resources.w2mg;
                case "w2mi": return Resources.w2mi;
                case "w2p": return Resources.w2p;
                case "w2phase": return Resources.w2phase;
                case "w2quest": return Resources.w2quest;
                case "w2rag": return Resources.w2rag;
                case "w2ragdoll": return Resources.w2ragdoll;
                case "w2rig": return Resources.w2rig;
                case "w2scene": return Resources.w2scene;
                case "w2steer": return Resources.w2steer;
                case "w2w": return Resources.w2w;
                case "csv": return Resources.csv;
                case "env": return Resources.env;
                case "journal": return Resources.journal;
                case "redgame": return Resources.redgame;
                case "redswf": return Resources.redswf;
                case "spawntree": return Resources.spawntree;
                case "swf": return Resources.swf;
                case "vbrush": return Resources.vbrush;
                case "w2anim": return Resources.w2anim;
                case "w2animev": return Resources.w2animev;
                case "w2anims": return Resources.w2anims;
                case "w2beh": return Resources.w2beh;
                case "w2behtree": return Resources.w2behtree;
                case "w2cent": return Resources.w2cent;
                case "w2comm": return Resources.w2comm;
                case "w2conv": return Resources.w2conv;
                case "w2cube": return Resources.w2cube;
                case "w2cutscene": return Resources.w2cutscene;

                case "xbm": return Resources.xbm;

                case "fbx": return Resources.fbx;
                case "tga": return Resources.image;
                case "png": return Resources.image;
                case "dds": return Resources.image;
                case "jpg": return Resources.image;
                case "jpeg": return Resources.image;
                case "xml": return Resources.xml;
                case "apb": return Resources.apb;

                case ClosedDirImageKey: return Resources.FolderClosed_16x;
                case OpenDirImageKey: return Resources.FolderOpened_16x;
                default: return Resources.BlankFile_16x;

            }
        }
        private string GetFileExtension(object obj)
        {
            if (!(obj is FileSystemInfo node)) return OpenDirImageKey;
            if (node.IsDirectory())
            {
                return treeListView.IsExpanded(node) ? OpenDirImageKey : ClosedDirImageKey;
            }
            else
                return (node as FileInfo)?.Extension;
        }

        #endregion

        #region Control Events

        private void ExpandBTN_Click(object sender, EventArgs e) => treeListView.ExpandAll();
        private void CollapseBTN_Click(object sender, EventArgs e) => treeListView.CollapseAll();
        private void UpdatefilelistButtonClick(object sender, EventArgs e) => searchBox.Clear();

        private void showhideButton_Click(object sender, EventArgs e)
        {
            vm.IsTreeview = !vm.IsTreeview;
            vm.RepopulateTreeView();
        }
        private void modFileList_KeyDown(object sender, KeyEventArgs e)
        {
            //if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            //{
            //    if (e.KeyCode == Keys.F2)
            //    {
            //        RequestFileRename?.Invoke(this, new RequestFileOpenArgs { File = selectedobject.FullName });
            //    }
            //    else if (e.KeyCode == Keys.Delete)
            //    {
            //        RequestDelete();
            //    }
            //}
            
        }

        private void RequestDelete()
        {
            var selectedItems = vm.SelectedItems.Select(_ => _.FullName).ToList();
            List<string> itemstoDelete = new List<string>();
            foreach (var path in selectedItems)
            {
                if (MockKernel.Get().GetMainViewModel().GetOpenDocuments().Values.Any(_ => _.Cr2wFileName == path))
                {
                    MainController.LogString($"Please close the file in WolvenKit before deleting: {path}", Logtype.Error);
                }
                else
                {
                    itemstoDelete.Add(path);
                }
            }

            if (MessageBox.Show(
                "Are you sure you want to permanently delete this?", "Confirmation", MessageBoxButtons.OKCancel
            ) == DialogResult.OK)
            {
                RequestFileDelete?.Invoke(this, new RequestFileDeleteArgs(itemstoDelete));
            }
        }

        private bool singleclickflag;
        private async void treeListView_CellClick(object sender, CellClickEventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject && e.Item != null)
            {
                var node = (FileSystemInfo) e.Item.RowObject;

                if (e.ClickCount == 1)
                {
                    singleclickflag = true;
                    await Task.Delay(200);
                    
                    if (singleclickflag)
                    {
                        if (!selectedobject.IsDirectory())
                            RequestFileOpen?.Invoke(this, new RequestFileOpenArgs { File = node.FullName, Inspect = true });

                    }
                    else
                    {

                    }
                    singleclickflag = false;
                }
                else
                {

                }
            }
        }
        private void treeListView_ItemActivate(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                if (!selectedobject.IsDirectory())
                {
                    RequestFileOpen?.Invoke(this, new RequestFileOpenArgs { File = selectedobject.FullName });
                    singleclickflag = false;
                }
                else
                    treeListView.ToggleExpansion(selectedobject);
            }
        }





        private void contextMenu_Opened(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var fi = new FileInfo(selectedobject.FullName);
                var ext = fi.Extension.TrimStart('.');
                bool isbundle = Path.Combine(ActiveMod.FileDirectory, fi.ToString())
                    .Contains(Path.Combine(ActiveMod.ModDirectory, EBundleType.Bundle.ToString()));
                bool israw = Path.Combine(ActiveMod.FileDirectory, fi.ToString())
                    .Contains(ActiveMod.RadishDirectory);
                bool isToplevelDir = selectedobject.FullName == ActiveMod.ModDirectory
                        || selectedobject.FullName == ActiveMod.DlcDirectory
                        || selectedobject.FullName == ActiveMod.RawDirectory
                        || selectedobject.FullName == ActiveMod.RadishDirectory
                        || selectedobject.FullName == ActiveMod.ModUncookedDirectory
                        || selectedobject.FullName == ActiveMod.ModCookedDirectory
                        || selectedobject.FullName == ActiveMod.DlcCookedDirectory
                        || selectedobject.FullName == ActiveMod.DlcUncookedDirectory
                        ;

                createW2animsToolStripMenuItem.Enabled = !isToplevelDir;
                exportToolStripMenuItem.Enabled = !isToplevelDir && (ext == "w3fac" || ext == "w2cutscene" || ext == "w2anims" || ext == "w2rig" || ext == "xbm"
                    || Enum.GetNames(typeof(EExportable)).Contains(ext));

                exportW2animsjsonToolStripMenuItem.Visible = ext == "w2anims";
                exportW2cutscenejsonToolStripMenuItem.Visible = ext == "w2cutscene";
                exportw2rigjsonToolStripMenuItem.Visible = ext == "w2rig";
                exportW3facjsonToolStripMenuItem.Visible = ext == "w3fac";
                exportWithWccToolStripMenuItem.Visible = Enum.GetNames(typeof(EExportable)).Contains(ext) || ext == "xbm";

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
            

        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (ActiveMod == null) e.Cancel = true;

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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveMod == null)
                return;

            if (!string.IsNullOrEmpty(searchBox.Text))
                treeListView.ModelFilter = TextMatchFilter.Contains(treeListView, searchBox.Text.ToUpper());
            else
                treeListView.ModelFilter = null;
        }

        private void treeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = treeListView.SelectedObjects.Cast<FileSystemInfo>().ToList();
            vm.SelectedItems = s;
        }


        #endregion

        #region Context Menu
        private void openAssetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                RequestAssetBrowser?.Invoke(this, new RequestFileOpenArgs { File = GetExplorerString(selectedobject.FullName) });
            }

            string GetExplorerString(string s)
            {
                s = s.Substring(ActiveMod.FileDirectory.Length + 1);
                if (s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Length > 1)
                {
                    int skip = s.StartsWith("Raw") ? 2 : 1;
                    if (s.StartsWith("Mod\\Uncooked"))
                    {
                        s = s.Substring("Mod\\Uncooked".Length);
                        s = $"Mod\\Bundle{s}";
                    }
                    if (s.StartsWith("Mod\\Cooked"))
                    {
                        s = s.Substring("Mod\\Cooked".Length);
                        s = $"Mod\\Bundle{s}";
                    }

                    var r = string
                        .Join(Path.DirectorySeparatorChar.ToString(), new[] { "Root" }
                        .Concat(s.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar).Skip(skip)).ToArray());
                    return r;
                }
                else
                    return s;
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                if (MockKernel.Get().GetMainViewModel().GetOpenDocuments().Values.Any(_ => _.Cr2wFileName == selectedobject.FullName))
                {
                    MainController.LogString("Please close the file in WolvenKit before renaming.", Logtype.Error);
                    return;
                }
                RequestFileRename?.Invoke(this, new RequestFileOpenArgs { File = selectedobject.FullName });
            }
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestDelete();
        }

        


        private void addAllDependenciesToolStripMenuItem_Click(object sender, EventArgs e) => vm.AddAllImportsCommand.SafeExecute();

        private void cookToolStripMenuItem_Click(object sender, EventArgs e) => vm.CookCommand.SafeExecute();

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => vm.CopyFileCommand.SafeExecute();

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => vm.PasteFileCommand.SafeExecute();

        private void showFileInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                Commonfunctions.ShowFileInExplorer(selectedobject.FullName);
            }
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
            if (!(treeListView.SelectedObject is FileSystemInfo selectedobject)) return;
            var filename = selectedobject.FullName;
            var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
            if (!File.Exists(fullpath))
                return;
            var newfullpath = Path.Combine(new[] { ActiveMod.FileDirectory, filename.Split('\\')[0] == "DLC" ? "Mod" : "DLC" }.Concat(filename.Split('\\').Skip(1).ToArray()).ToArray());

            if (File.Exists(newfullpath))
                return;
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(newfullpath) ?? throw new InvalidOperationException());
            }
            catch
            {
                // ignored
            }

            File.Move(fullpath, newfullpath);
            MainController.Get().ProjectStatus = "File moved";
        }


        private void exportw2rigjsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                Console.WriteLine(selectedobject.FullName);
                string w2RigFilePath = selectedobject.FullName;
                using (var sf = new SaveFileDialog())
                {
                    sf.Filter = "W3 json | *.json";
                    sf.FileName = Path.GetFileName(selectedobject.FullName + ".json");
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        CommonData cdata = new CommonData();
                        Rig exportRig = new Rig(cdata);
                        byte[] data;
                        data = File.ReadAllBytes(w2RigFilePath);
                        using (MemoryStream ms = new MemoryStream(data))
                        using (BinaryReader br = new BinaryReader(ms))
                        {
                            CR2WFile rigFile = new CR2WFile();
                            rigFile.Read(br);
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
                                        Path.Combine(ActiveMod.ModCookedDirectory, "characters\\base_entities\\woman_base\\woman_base.w2rig"));
                settings.ShowDialog();
            }
        }
        private void exportW2cutscenejsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var settings = new frmAnims(selectedobject.FullName,
                                        Path.Combine(ActiveMod.ModCookedDirectory, "characters\\base_entities\\woman_base\\woman_base.w2rig"));
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
        private void createW2animsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                var filename = selectedobject.FullName;
                var fullpath = Path.Combine(ActiveMod.FileDirectory, filename);
                if (!File.Exists(fullpath) && !Directory.Exists(fullpath))
                    return;
                string dir;
                dir = File.Exists(fullpath) 
                    ? Path.GetDirectoryName(fullpath) 
                    : fullpath;
                var files = Directory.GetFiles(dir ?? throw new InvalidOperationException(), "*.*", SearchOption.AllDirectories).ToList();
                var folderName = Path.GetFileName(fullpath);
                ConvertAnimation anim = new ConvertAnimation();
                if (File.Exists(fullpath + ".w2anims"))
                {
                    if (MessageBox.Show(
                         folderName + ".w2anims already exists. This file will be overwritten. Are you sure you want to permanently overwrite " + folderName + " w2anims?"
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
        private void exportW2meshToFbxToolStripMenuItem_Click(object sender, EventArgs e) => vm.ExportMeshCommand.SafeExecute();

        private void fastRenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeListView.SelectedObject is FileSystemInfo selectedobject)
            {
                vm.AddAllImportsCommand.SafeExecute();
                RequestFastRender?.Invoke(this, new RequestFileOpenArgs { File = selectedobject.FullName });
            }
        }







        #endregion


    }
}