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
using W3Edit.Bundles;

namespace W3Edit
{
    public partial class frmBundleExplorer : Form
    {
        public class BundleListItem : ListViewItem
        {
            public bool IsDirectory { get; set; }
            public BundleTreeNode Node { get; set; }

            public string FullPath { get; set; }
        }

        public BundleTreeNode ActiveNode { get; set; }
        public BundleTreeNode RootNode { get; set; }

        public string[] SelectedPaths { 
            get { return txPath.Text.Split(';'); } 
        }

        public frmBundleExplorer()
        {
            InitializeComponent();

            var manager = MainController.Get().BundleManager;
            RootNode = manager.RootNode;
        }

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
                    fileListView.Items.Add(new BundleListItem()
                    {
                        Node = node.Parent,
                        Text = "..",
                        IsDirectory = true,
                        ImageKey = "openFolder"
                    });
                }

                foreach(var item in node.Directories)
                {
                    fileListView.Items.Add(new BundleListItem()
                    {
                        Node = item.Value,
                        Text = item.Key,
                        IsDirectory = true,
                        ImageKey = "openFolder"
                    });
                }


                foreach (var item in node.Files)
                {
                    var lastItem = item.Value[item.Value.Count-1];
                    var listItem = fileListView.Items.Add(new BundleListItem()
                    {
                        Node = null,
                        FullPath = lastItem.Name,
                        Text = item.Key,
                        IsDirectory = false,
                        ImageKey = "genericFile"
                    });
                    listItem.SubItems.Add(lastItem.Size.ToString());
                    listItem.SubItems.Add(string.Format("{0}%", (100 - (int)((float)lastItem.ZSize / (float)lastItem.Size * 100.0f))) );
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
                button.Padding = new System.Windows.Forms.Padding(0);
                button.Margin = new System.Windows.Forms.Padding(0);
                var textSize = TextRenderer.MeasureText(button.Text, button.Font);
                button.Width = textSize.Width;
                button.Height = 23;
                button.BackColor = Color.Transparent;
                button.MouseLeave += button_MouseLeave;
                button.MouseEnter += button_MouseEnter;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Cursor = Cursors.Hand;
                button.Click += delegate(object sender, EventArgs e)
                {
                    OpenNode(link);
                };

                pathPanel.Controls.Add(button);

                x += button.Width;
            }
        }

        void button_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.LightBlue;
        }

        void button_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.Transparent;
        }

        private void fileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                var item = (BundleListItem)fileListView.SelectedItems[0];
                if (item.IsDirectory) 
                {
                    OpenNode(item.Node);
                }
                else
                {
                    txPath.Text = item.FullPath;
                }
            }
        }

        private void fileListView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void fileListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (fileListView.SelectedItems.Count > 0)
            {
                var paths = new List<string>();
                foreach(BundleListItem item in fileListView.SelectedItems)
                {
                    if (!item.IsDirectory)
                    {
                        paths.Add(item.FullPath);
                    }
                }

                txPath.Text = string.Join(";", paths);
            }
        }

        private void fileListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pathPanel_Click(object sender, EventArgs e)
        {
            pathPanel.Controls.Clear();
            var textbox = new TextBox();
            textbox.Location = new Point(16, 2);
            textbox.Width = pathPanel.Width;
            textbox.Height = pathPanel.Height;
            textbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            textbox.BorderStyle = BorderStyle.None;
            pathPanel.Controls.Add(textbox);
            textbox.Focus();

            textbox.LostFocus += textbox_LostFocus;
            textbox.KeyDown += textbox_KeyDown;
            textbox.PreviewKeyDown += textbox_PreviewKeyDown;
            textbox.Margin = new Padding(3);
            textbox.Text = ActiveNode.FullPath;
            textbox.SelectAll();
            textbox.AcceptsReturn = true;
        }

        void textbox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var textbox = (TextBox)sender;
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
            for (int i = 0; i < parts.Length; i++)
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

        void textbox_LostFocus(object sender, EventArgs e)
        {
            UpdatePathPanel();
        }

        void textbox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
