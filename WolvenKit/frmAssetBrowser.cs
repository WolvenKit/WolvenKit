using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Interfaces;

namespace WolvenKit
{
    public partial class frmAssetBrowser : Form
    {
        public List<string> Autocompletelist;
        public List<IWitcherFile> FileList = new List<IWitcherFile>();
        public List<IWitcherArchive> Managers;

        public List<string> Files { get; set; }
        public WitcherTreeNode ActiveNode { get; set; }
        public WitcherTreeNode RootNode { get; set; }

        public List<WitcherListViewItem> SelectedPaths
        {
            get
            {
                var ret = new List<WitcherListViewItem>();
                foreach (WitcherListViewItem item in pathlistview.Items)
                    ret.Add(item);
                return ret;
            }
        }

        public event EventHandler<Tuple<List<IWitcherArchive>, List<WitcherListViewItem>, bool>> RequestFileAdd;

        public frmAssetBrowser(List<IWitcherArchive> archives)
        {
            InitializeComponent();
            Managers = archives;
            RootNode = new WitcherTreeNode();
            RootNode.Name = "Root";
            foreach (var arch in archives)
            {
                FileList.AddRange(arch.FileList);
                RootNode.Directories[arch.RootNode.Name] = arch.RootNode;
                arch.RootNode.Parent = RootNode;
                extensionCB.Items.Add(arch.TypeName);
                extensionCB.SelectedIndex = 0;
                filetypeCB.Items.AddRange(arch.Extensions.ToArray());
                filetypeCB.SelectedIndex = 0;
                for (int i = 0; i < arch.AutocompleteSource.Count; i++)
                {
                    SearchBox.AutoCompleteCustomSource.Add(arch.AutocompleteSource[i]);
                }
            }
        }

        private void frmBundleExplorer_Load(object sender, EventArgs e)
        {
        }

        public void OpenNode(WitcherTreeNode node,bool reset = false)
        {
            if (ActiveNode != node || reset)
            {
                ActiveNode = node;

                UpdatePathPanel();

                fileListView.Items.Clear();
                List<WitcherListViewItem> res = new List<WitcherListViewItem>();
                if (node.Parent != null)
                {
                    res.Add(new WitcherListViewItem
                    {
                        Node = node.Parent,
                        Text = "..",
                        IsDirectory = true,
                        ImageKey = "openFolder"
                    });
                }

                res.AddRange(node.Directories.OrderBy(x => x.Key).Select(item => new WitcherListViewItem
                {
                    Node = item.Value,
                    Text = item.Key,
                    IsDirectory = true,
                    ImageKey = "openFolder"
                }));


                foreach (var item in node.Files.OrderBy(x => x.Key))
                {
                    var lastItem = item.Value[item.Value.Count - 1];
                    var listItem = new WitcherListViewItem
                    {
                        Node = node,
                        FullPath = lastItem.Name,
                        Text = item.Key,
                        IsDirectory = false,
                        ImageKey = GetImageKey(item.Key)
                    };
                    listItem.SubItems.Add(lastItem.Size.ToString());
                    listItem.SubItems.Add(string.Format("{0}%",
                        (100 - (int)(lastItem.ZSize / (float)lastItem.Size * 100.0f))));
                    listItem.SubItems.Add(lastItem.CompressionType);
                    listItem.SubItems.Add(lastItem.Bundle.TypeName);
                    res.Add(listItem);
                }
                fileListView.Items.AddRange(res.ToArray());
            }
        }

        private void UpdatePathPanel()
        {
            var nodes = new List<WitcherTreeNode>();
            var c = ActiveNode;
            while (c != null)
            {
                nodes.Add(c);
                c = c.Parent;
            }

            pathPanel.Controls.Clear();
            var x = 0;
            nodes.Reverse();
            foreach (var link in nodes)
            {
                var button = new Label();
                button.Text = link.Name + " >";
                button.Location = new Point(x, -3);
                button.Padding = new Padding(0);
                button.Margin = new Padding(0);
                var textSize = TextRenderer.MeasureText(button.Text, button.Font);
                button.Width = textSize.Width;
                button.Height = 23;
                button.BackColor = Color.Transparent;
                button.MouseLeave += button_MouseLeave;
                button.MouseEnter += button_MouseEnter;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Cursor = Cursors.Hand;
                button.Click += delegate { OpenNode(link); };

                pathPanel.Controls.Add(button);

                x += button.Width;
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label) sender;
            label.BackColor = Color.LightBlue;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label) sender;
            label.BackColor = Color.Transparent;
        }

        private void fileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                var item = (WitcherListViewItem) fileListView.SelectedItems[0].Clone();
                if (item.IsDirectory)
                {
                    OpenNode(item.Node);
                }
                else
                {
                    var cont = false;
                    foreach (WitcherListViewItem i in pathlistview.Items)
                    {
                        if (i.Text == item.FullPath)
                            cont = true;
                    }
                    if (!cont)
                    {
                        var tempnode = new WitcherListViewItem
                        {
                            ImageKey = GetImageKey(item.FullPath),
                            Text = item.FullPath,
                            ToolTipText = item.FullPath,
                            IsDirectory = item.IsDirectory,
                            Node = item.Node,
                            FullPath = item.FullPath
                        };
                        pathlistview.Items.Add(tempnode);
                    }
                }
            }
        }

        private void pathPanel_Click(object sender, EventArgs e)
        {
            pathPanel.Controls.Clear();
            var textbox = new TextBox
            {
                Location = new Point(16, 2),
                Width = pathPanel.Width,
                Height = pathPanel.Height,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                BorderStyle = BorderStyle.None
            };
            pathPanel.Controls.Add(textbox);
            textbox.Focus();

            textbox.PreviewKeyDown += textbox_PreviewKeyDown;
            textbox.LostFocus += textbox_LostFocus;
            textbox.Margin = new Padding(3);
            textbox.Text = ActiveNode.FullPath;
            textbox.SelectAll();
            textbox.AcceptsReturn = true;
        }

        private void textbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var textbox = (TextBox) sender;
            if (e.KeyCode == Keys.Enter)
            {
                var browsePath = textbox.Text;
                OpenPath(browsePath);
            }
        }

        public string GetImageKey(string filename)
        {
            try
            {
                if (treeImages.Images.ContainsKey(Path.GetExtension(filename).Replace(".", "")))
                {
                    return Path.GetExtension(filename).Replace(".", "");
                }
            }
            catch  { }

            return "genericFile";
        }

        public void OpenPath(string browsePath)
        {
            var currentNode = RootNode;
            var parts = browsePath.Split('\\');
            var success = false;
            for (var i = 0; i < parts.Length; i++)
            {
                if (currentNode.Directories.ContainsKey(parts[i]))
                {
                    currentNode = currentNode.Directories[parts[i]];

                    success = true;
                }
                else if (i == parts.Length - 1 && (currentNode.Files.ContainsKey(parts[i]) || parts[i] == ""))
                {
                    success = true;
                }
                else
                {
                    success = false;
                    break;
                }
            }

            if (success || currentNode != RootNode)
            {
                OpenNode(currentNode);
            }
        }

        private void textbox_LostFocus(object sender, EventArgs e)
        {
            UpdatePathPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in pathlistview.SelectedItems)
            {
                pathlistview.Items.Remove(item);
            }
        }

        public void Search(string s, int bundleTypeIdx, int fileTypeIdx)
        {
            var extension = "";
            var bundletype = "";
            if (filetypeCB.SelectedIndex != -1)
                extension = filetypeCB.Items[fileTypeIdx].ToString();
            if (extensionCB.SelectedIndex != -1)
                bundletype = extensionCB.Items[bundleTypeIdx].ToString();
            var found = SearchFiles(FileList.ToArray(), s, bundletype, extension);
            if (found.Length > 1000)
                found = found.Take(1000).ToArray();
            fileListView.Items.Clear();
            var results = new List<WitcherListViewItem>();
            foreach (var file in found)
            {
                var lastItem = file;
                var listItem = new WitcherListViewItem
                {
                    Node = null,
                    FullPath = lastItem.Name,
                    Text = file.Name,
                    IsDirectory = false,
                    ImageKey = GetImageKey(file.Name)
                };
                listItem.SubItems.Add(lastItem.Size.ToString());
                listItem.SubItems.Add($"{(100 - (int) (lastItem.ZSize/(float) lastItem.Size*100.0f))}%");
                listItem.SubItems.Add(lastItem.CompressionType);
                listItem.SubItems.Add(lastItem.Bundle.TypeName);
                results.Add(listItem);
            }
            fileListView.Items.AddRange(results.ToArray());
        }

        public List<IWitcherFile> GetFiles(WitcherTreeNode mainnode)
        {
            var bundfiles = new List<IWitcherFile>();
            if (mainnode?.Files != null)
            {
                foreach (var wfile in mainnode.Files)
                {
                    bundfiles.AddRange(wfile.Value);
                }
                bundfiles.AddRange(mainnode.Directories.Values.SelectMany(GetFiles));
            }
            return bundfiles;
        }

        public IWitcherFile[] SearchFiles(IWitcherFile[] files, string searchkeyword, string bundletype, string extension)
        {
            if (regexCheckbox.Checked)
            {
                return files.Where(item => new Regex(searchkeyword).IsMatch(item.Name)).ToArray();
            }
            if (currentfolderCheckBox.Checked)
            {
                return caseCheckBox.Checked ? files.Where(item => item.Name.StartsWith(ActiveNode.FullPath) && item.Name.ToUpper().Contains(searchkeyword.ToUpper()) &&(item.Name.ToUpper().EndsWith(extension.ToUpper()) || extension.ToUpper() == "ANY")).Distinct().ToArray() : files.Where(item => item.Name.StartsWith(ActiveNode.FullPath) && item.Name.Contains(searchkeyword) && (item.Name.EndsWith(extension) || extension.ToUpper() == "ANY")).Distinct().ToArray();
            }
            return caseCheckBox.Checked ? files.Where(item =>  item.Name.ToUpper().Contains(searchkeyword.ToUpper()) && (item.Name.ToUpper().EndsWith(extension.ToUpper()) || extension.ToUpper() == "ANY")).ToArray() : files.Where(item => item.Name.Contains(searchkeyword) && (item.Name.EndsWith(extension) || extension.ToUpper() == "ANY")).ToArray();
        }

        public WitcherListViewItem[] CollectFiles(WitcherTreeNode root)
        {
            var res = root.Files.Select(file => file.Key).Select(x => new WitcherListViewItem()
            {
                ImageKey = GetImageKey(x),
                ToolTipText = x,
                Text = x
            }).ToList();
            foreach (var dr in root.Directories)
            {
                res.AddRange(CollectFiles(dr.Value));
            }
            return res.ToArray();
        }

        public string[] GetExtensions(params string[] filename)
        {
            var extensions = new List<string>();
            foreach (var file in filename.Where(file => !extensions.Contains(file.Split('.').Last())))
            {
                extensions.Add(file.Split('.').Last());
            }
            return extensions.ToArray();
        }

        private void MarkSelected_Click(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                foreach (WitcherListViewItem item in fileListView.SelectedItems)
                {
                    if (!item.IsDirectory)
                    {
                        var cont = false;
                        foreach (WitcherListViewItem i in pathlistview.Items)
                        {
                            if (i.Text == item.FullPath)
                                cont = true;
                        }
                        if (!cont)
                        {
                            var tempnode = new WitcherListViewItem
                            {
                                ImageKey = GetImageKey(item.FullPath),
                                Text = item.FullPath,
                                ToolTipText = item.FullPath,
                                IsDirectory = item.IsDirectory,
                                Node = item.Node,
                                FullPath = item.FullPath
                            };
                            pathlistview.Items.Add(tempnode);
                        }
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(SearchBox.Text, extensionCB.SelectedIndex, filetypeCB.SelectedIndex);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pathlistview.Items.Clear();
        }

        private void fileListView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (ActiveNode != RootNode)
                    OpenNode(ActiveNode.Parent);
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (fileListView.SelectedItems.Count > 0)
                {
                    var item = (WitcherListViewItem)fileListView.SelectedItems[0];
                    if (item.IsDirectory)
                    {
                        OpenNode(item.Node);
                    }
                }
            }
        }

        private void SearchBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(SearchBox.Text, extensionCB.SelectedIndex, filetypeCB.SelectedIndex);
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (pathlistview.Items.Count < 1)
            {
                if (fileListView.SelectedItems.Count > 0)
                {
                    foreach (WitcherListViewItem item in fileListView.SelectedItems)
                    {
                        if (!item.IsDirectory)
                        {
                            var cont = false;
                            foreach (WitcherListViewItem i in pathlistview.Items)
                            {
                                if (i.Text == item.FullPath)
                                    cont = true;
                            }
                            if (!cont)
                            {
                                var tempnode = new WitcherListViewItem
                                {
                                    ImageKey = GetImageKey(item.FullPath),
                                    Text = item.FullPath,
                                    ToolTipText = item.FullPath,
                                    IsDirectory = item.IsDirectory,
                                    Node = item.Node,
                                    FullPath = item.FullPath
                                };
                                pathlistview.Items.Add(tempnode);
                            }
                        }
                    }
                }
            }
            RequestFileAdd.Invoke(this, new Tuple<List<IWitcherArchive>, List<WitcherListViewItem>,bool>(Managers, SelectedPaths,false));
            pathlistview.Items.Clear();
        }

        private void AddDLCFile_Click(object sender, EventArgs e)
        {
            if (pathlistview.Items.Count < 1)
            {
                if (fileListView.SelectedItems.Count > 0)
                {
                    foreach (WitcherListViewItem item in fileListView.SelectedItems)
                    {
                        if (!item.IsDirectory)
                        {
                            var cont = false;
                            foreach (WitcherListViewItem i in pathlistview.Items)
                            {
                                if (i.Text == item.FullPath)
                                    cont = true;
                            }
                            if (!cont)
                            {
                                var tempnode = new WitcherListViewItem
                                {
                                    ImageKey = GetImageKey(item.FullPath),
                                    Text = item.FullPath,
                                    ToolTipText = item.FullPath,
                                    IsDirectory = item.IsDirectory,
                                    Node = item.Node,
                                    FullPath = item.FullPath
                                };
                                pathlistview.Items.Add(tempnode);
                            }
                        }
                    }
                }
            }
            RequestFileAdd.Invoke(this, new Tuple<List<IWitcherArchive>, List<WitcherListViewItem>,bool>(Managers, SelectedPaths,true));
            pathlistview.Items.Clear();
        }

        private void copyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                var item = ((WitcherListViewItem) fileListView.SelectedItems[0]);
                if (item?.IsDirectory == false)
                {
                    Clipboard.SetText(item.FullPath);
                }
            }
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                foreach (WitcherListViewItem item in fileListView.SelectedItems)
                {
                    if (!item.IsDirectory)
                    {
                        var cont = false;
                        foreach (WitcherListViewItem i in pathlistview.Items)
                        {
                            if (i.Text == item.FullPath)
                                cont = true;
                        }
                        if (!cont)
                        {
                            var tempnode = new WitcherListViewItem
                            {
                                ImageKey = GetImageKey(item.FullPath),
                                Text = item.FullPath,
                                ToolTipText = item.FullPath,
                                IsDirectory = item.IsDirectory,
                                Node = item.Node,
                                FullPath = item.FullPath
                            };
                            pathlistview.Items.Add(tempnode);
                        }
                    }
                }
            }
        }

        private void fileListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                fileListView.MultiSelect = true;
                foreach (WitcherListViewItem item in fileListView.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void clearSearch_Click(object sender, EventArgs e)
        {
            OpenNode(RootNode,true);
        }

        private void markAllFilesOfFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                foreach (WitcherListViewItem item in fileListView.SelectedItems)
                {
                    if (item.IsDirectory)
                    {
                        var files = CollectFiles(item.Node);
                        if (files.Length > 1000)
                            pathlistview.Items.AddRange(files.Take(1000).ToArray());
                        else
                            pathlistview.Items.AddRange(files);
                    }
                }
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileListView.View = View.Details; 
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileListView.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileListView.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileListView.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileListView.View = View.Tile;
        }
    }
}