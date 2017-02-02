using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using W3Edit.Bundles;

namespace W3Edit
{
    public partial class frmBundleExplorer : Form
    {
        public List<string> Autocompletelist;
        public List<BundleItem> FileList;

        public frmBundleExplorer(BundleManager manager)
        {
            InitializeComponent();
            RootNode = manager.RootNode;
            FileList = manager.FileList;
            filetypeCB.Items.AddRange(manager.Extensions.ToArray());
            filetypeCB.SelectedIndex = 0;
            SearchBox.AutoCompleteCustomSource = manager.AutocompleteSource;
        }

        public List<string> Files { get; set; }
        public BundleTreeNode ActiveNode { get; set; }
        public BundleTreeNode RootNode { get; set; }

        public ListView.ListViewItemCollection SelectedPaths => pathlistview.Items;

        private void frmBundleExplorer_Load(object sender, EventArgs e)
        {
        }

        public void OpenNode(BundleTreeNode node)
        {
            if (ActiveNode != node)
            {
                ActiveNode = node;

                UpdatePathPanel();

                fileListView.Items.Clear();

                if (node.Parent != null)
                {
                    fileListView.Items.Add(new BundleListItem
                    {
                        Node = node.Parent,
                        Text = "..",
                        IsDirectory = true,
                        ImageKey = "openFolder"
                    });
                }

                foreach (var item in node.Directories.OrderBy(x => x.Key))
                {
                    fileListView.Items.Add(new BundleListItem
                    {
                        Node = item.Value,
                        Text = item.Key,
                        IsDirectory = true,
                        ImageKey = "openFolder"
                    });
                }


                foreach (var item in node.Files.OrderBy(x => x.Key))
                {
                    var lastItem = item.Value[item.Value.Count - 1];
                    var listItem = fileListView.Items.Add(new BundleListItem
                    {
                        Node = null,
                        FullPath = lastItem.Name,
                        Text = item.Key,
                        IsDirectory = false,
                        ImageKey = "genericFile"
                    });
                    listItem.SubItems.Add(lastItem.Size.ToString());
                    listItem.SubItems.Add(string.Format("{0}%",
                        (100 - (int) (lastItem.ZSize/(float) lastItem.Size*100.0f))));
                    listItem.SubItems.Add(lastItem.CompressionType);
                    listItem.SubItems.Add(lastItem.DateString);
                }
            }
        }

        private void UpdatePathPanel()
        {
            var nodes = new List<BundleTreeNode>();
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
                var item = (BundleListItem) fileListView.SelectedItems[0];
                if (item.IsDirectory)
                {
                    OpenNode(item.Node);
                }
                else
                {
                    var cont = false;
                    foreach (ListViewItem i in pathlistview.Items)
                    {
                        if (i.Text == item.FullPath)
                            cont = true;
                    }
                    if (!cont)
                    {
                        var tempnode = new ListViewItem();
                        tempnode.ImageKey = "genericFile";
                        tempnode.Text = item.FullPath;
                        tempnode.ToolTipText = item.FullPath;
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

            if (success)
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

        public void Search(string s, int i)
        {
            var found = SearchFiles(FileList.ToArray(), s, filetypeCB.Items[i].ToString());
            if (found.Length > 1000)
                found = found.Take(1000).ToArray();
            fileListView.Items.Clear();
            foreach (var file in found)
            {
                var lastItem = file;
                var listItem = fileListView.Items.Add(new BundleListItem
                {
                    Node = null,
                    FullPath = lastItem.Name,
                    Text = file.Name,
                    IsDirectory = false,
                    ImageKey = "genericFile"
                });
                listItem.SubItems.Add(lastItem.Size.ToString());
                listItem.SubItems.Add($"{(100 - (int) (lastItem.ZSize/(float) lastItem.Size*100.0f))}%");
                listItem.SubItems.Add(lastItem.CompressionType);
                listItem.SubItems.Add(lastItem.DateString);
            }
        }

        public List<BundleItem> GetFiles(BundleTreeNode mainnode)
        {
            var bundfiles = new List<BundleItem>();
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

        public BundleItem[] SearchFiles(BundleItem[] files, string searchkeyword, string Extension)
        {
            return files.Where(file => (file.Name.EndsWith(Extension) && file.Name.ToUpper().Contains(searchkeyword.ToUpper())) || (file.Name.ToUpper().Contains(searchkeyword.ToUpper()) && Extension.ToUpper() == "ANY")).ToArray();
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
                foreach (BundleListItem item in fileListView.SelectedItems)
                {
                    if (!item.IsDirectory)
                    {
                        var cont = false;
                        foreach (ListViewItem i in pathlistview.Items)
                        {
                            if (i.Text == item.FullPath)
                                cont = true;
                        }
                        if (!cont)
                        {
                            var tempnode = new ListViewItem();
                            tempnode.ImageKey = "genericFile";
                            tempnode.ToolTipText = item.FullPath;
                            tempnode.Text = item.FullPath;
                            pathlistview.Items.Add(tempnode);
                        }
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search(SearchBox.Text, filetypeCB.SelectedIndex);
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
                    OpenPath(ActiveNode.Parent.FullPath);
            }
        }

        private void SearchBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(SearchBox.Text, filetypeCB.SelectedIndex);
            }
        }

        public class BundleListItem : ListViewItem
        {
            public bool IsDirectory { get; set; }
            public BundleTreeNode Node { get; set; }
            public string FullPath { get; set; }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (pathlistview.Items.Count < 1)
            {
                if (fileListView.SelectedItems.Count > 0)
                {
                    foreach (BundleListItem item in fileListView.SelectedItems)
                    {
                        if (!item.IsDirectory)
                        {
                            var cont = false;
                            foreach (ListViewItem i in pathlistview.Items)
                            {
                                if (i.Text == item.FullPath)
                                    cont = true;
                            }
                            if (!cont)
                            {
                                var tempnode = new ListViewItem();
                                tempnode.ImageKey = "genericFile";
                                tempnode.ToolTipText = item.FullPath;
                                tempnode.Text = item.FullPath;
                                pathlistview.Items.Add(tempnode);
                            }
                        }
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void copyPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                var item = ((BundleListItem) fileListView.SelectedItems[0]);
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
                foreach (BundleListItem item in fileListView.SelectedItems)
                {
                    if (!item.IsDirectory)
                    {
                        var cont = false;
                        foreach (ListViewItem i in pathlistview.Items)
                        {
                            if (i.Text == item.FullPath)
                                cont = true;
                        }
                        if (!cont)
                        {
                            var tempnode = new ListViewItem();
                            tempnode.ImageKey = "genericFile";
                            tempnode.ToolTipText = item.FullPath;
                            tempnode.Text = item.FullPath;
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
                foreach (ListViewItem item in fileListView.Items)
                {
                    item.Selected = true;
                }
            }
        }
    }
}