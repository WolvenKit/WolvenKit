using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W3Edit.Mod;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmModExplorer : DockContent
    {
        public frmModExplorer()
        {
            InitializeComponent();

            UpdateModFileList();
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

        public void UpdateModFileList(bool clear = false)
        {
            if (clear)
                modFileList.Nodes.Clear();

            if (ActiveMod == null)
                return;

            foreach (var item in ActiveMod.Files)
            {
                var current = modFileList.Nodes;
                var parts = item.Split('\\');
                for (var i = 0; i < parts.Length; i++)
                {
                    if (!current.ContainsKey(parts[i]))
                    {
                        var newNode = current.Add(parts[i], parts[i]);
                        if (i == parts.Length - 1)
                        {
                            newNode.ImageKey = "genericFile";
                            newNode.SelectedImageKey = "genericFile";
                        }
                        else
                        {
                            newNode.ImageKey = "openFolder";
                            newNode.SelectedImageKey = "openFolder";
                        }

                        // auto expand new nodes;
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

        private void modFileList_DoubleClick(object sender, EventArgs e)
        {
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
            RequestFileAdd(this,
                new RequestFileArgs {File = modFileList.SelectedNode?.FullPath ?? ""});
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
            if(File.Exists(Clipboard.GetText()))
                SafeCopy(Clipboard.GetText(),Clipboard.GetText());
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
    }
}