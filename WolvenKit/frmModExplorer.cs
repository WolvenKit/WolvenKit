using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Mod;

namespace WolvenKit
{
    public partial class frmModExplorer : DockContent
    {
        public frmModExplorer()
        {
            InitializeComponent();
            UpdateModFileList(true,true);
        }

        public W3Mod ActiveMod
        {
            get { return ModManager.Get().ActiveMod; }
            set { ModManager.Get().ActiveMod = value; }
        }

        public event EventHandler<RequestFileArgs> RequestFileOpen;
        public event EventHandler<RequestFileArgs> RequestFileDelete;
        public event EventHandler<RequestFileArgs> RequestFileAdd;
        public event EventHandler<RequestFileArgs> RequestFileRename;
        public List<string> FilteredFiles; 
        public bool FoldersShown = true;


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
                                newNode.ImageKey = "openFolder";
                                newNode.SelectedImageKey = "openFolder";
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
        }

        private void modFileList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            RequestFileOpen?.Invoke(this, new RequestFileArgs {File = e.Node.FullPath});
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
            RequestFileAdd?.Invoke(this,new RequestFileArgs {File = modFileList.SelectedNode?.FullPath ?? ""});
        }

        private void modFileList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                modFileList.SelectedNode = e.Node;
                contextMenu.Show(modFileList, e.Location);
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
                Clipboard.SetText(ModManager.Get().ActiveMod.FileDirectory + "\\" + modFileList.SelectedNode.FullPath);
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
            pasteToolStripMenuItem.Enabled = File.Exists(Clipboard.GetText());
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
                Clipboard.SetText(modFileList.SelectedNode.FullPath);
        }
    }
}