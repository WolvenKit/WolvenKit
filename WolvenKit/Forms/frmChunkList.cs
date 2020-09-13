using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.CR2W;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmChunkList : DockContent, IThemedContent
    {
        private bool listview;
        private bool isLargefile;
        private CR2WFile file;

        private readonly Dictionary<int, int> childrencountDict = new Dictionary<int, int>();
        private readonly Dictionary<int, List<CR2WExportWrapper>> childrenDict = new Dictionary<int, List<CR2WExportWrapper>>();
            
        public frmChunkList()
        {
            InitializeComponent();
            ApplyCustomTheme();
            //limitTB.Enabled = limitCB.Checked;
            treeListView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;

            treeListView.CanExpandGetter = delegate (object x) {
                var idx = ((CR2WExportWrapper)x).ChunkIndex;
                return !listview && childrencountDict[idx] > 0;
            };
            treeListView.ChildrenGetter = delegate (object x) {
                var idx = ((CR2WExportWrapper)x).ChunkIndex;
                return !listview ? childrenDict[idx] : new List<CR2WExportWrapper>();
            };
        }

        public CR2WFile File
        {
            get => file;
            set
            {
                file = value;
                UpdateList();
            }
        }

        public void SelectChunk(CR2WExportWrapper chunk)
        {
            // expand until :facepalm:
            treeListView.SelectedObject = chunk;
        }

        private void UpdateHelperList()
        {
            childrenDict.Clear();
            childrencountDict.Clear();

            if (File != null)
            {
                File.GenerateChunksDict();

                Dictionary<int, int> dParentids = File.chunks.ToDictionary(_ => _.ChunkIndex, _ => _.VirtualParentChunkIndex);
                foreach (var chunk in File.chunks)
                {
                    var childrenidxlist = dParentids.Where(_ => _.Value == chunk.ChunkIndex).Select(_ => _.Key);

                    IEnumerable<int> enumerable = childrenidxlist as int[] ?? childrenidxlist.ToArray();
                    if (enumerable.Any())
                    {
                        List<CR2WExportWrapper> children = enumerable.Select(childid => File.chunksdict[childid]).ToList();
                        childrenDict.Add(chunk.ChunkIndex, children);

                        var c = children.Count;
                        childrencountDict.Add(chunk.ChunkIndex, c);
                    }
                    else
                    {
                        childrenDict.Add(chunk.ChunkIndex, new List<CR2WExportWrapper>());
                        childrencountDict.Add(chunk.ChunkIndex, 0);

                    }
                }
            }
        }
        
        public event EventHandler<SelectChunkArgs> OnSelectChunk;

        public void UpdateList()
        {
            if (File == null)
                return;

            isLargefile = File.chunks.Count > 1000;
            if (isLargefile)
                listview = true;

            if (listview)
                treeListView.Roots = File.chunks;
            else
            {
                UpdateHelperList();
                treeListView.Roots = File.chunks.Where(_ => _.GetVirtualParentChunk() == null).ToList();
            }
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (OnSelectChunk != null && (CR2WExportWrapper)treeListView.SelectedObject != null)
            {
                OnSelectChunk(this, new SelectChunkArgs { Chunk = (CR2WExportWrapper)treeListView.SelectedObject });
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            toolStripSearchBox.Clear();
            treeListView.ModelFilter = null;
        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripSearchBox.Text))
                this.treeListView.ModelFilter = TextMatchFilter.Contains(treeListView, toolStripSearchBox.Text.ToUpper());
            else
                treeListView.ModelFilter = null;
        }

        private void listView_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            MainController.Get().ProjectUnsaved = true;
        }
        
        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetTheme());
            toolStripSearchBox.BackColor = UIController.GetPalette().ToolWindowCaptionButtonInactiveHovered.Background;

            this.treeListView.BackColor = UIController.GetBackColor();
            this.treeListView.ForeColor = UIController.GetForeColor();
            
            this.treeListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            treeListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
        }

        private void showTreetoolStripButton_Click(object sender, EventArgs e)
        {
            listview = !listview;
            UpdateList();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeListView.ExpandAll();
        }

        private void expandAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = treeListView.SelectedObject;
            if (node != null)
            {
                var children = treeListView.GetChildren(node);
                foreach (var c in children)
                {
                    treeListView.Expand(c);
                }
            }
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeListView.CollapseAll();
        }

        private void collapseAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = treeListView.SelectedObject;
            if (node != null)
            {
                var children = treeListView.GetChildren(node);
                foreach (var c in children)
                {
                    treeListView.Collapse(c);
                }
            }
        }
    }
}
 