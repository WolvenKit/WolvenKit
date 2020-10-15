using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmChunkList : DockContent, IThemedContent
    {
        #region Fields
        private bool isLargefile;
        private readonly Dictionary<int, int> childrencountDict = new Dictionary<int, int>();
        private readonly Dictionary<int, List<CR2WExportWrapper>> childrenDict = new Dictionary<int, List<CR2WExportWrapper>>();
        private readonly CR2WDocumentViewModel viewModel;
        private enum EChunkDisplayMode
        {
            Linear,
            Parent,
            VirtualParent
        }
        private EChunkDisplayMode ChunkDisplayValue;
        #endregion

        #region Properties
        //public event EventHandler<SelectChunkArgs> OnSelectChunk;

        private CR2WFile File => viewModel.File as CR2WFile;


        #endregion

        public frmChunkList(CR2WDocumentViewModel _viewmodel)
        {
            InitializeComponent();
            ApplyCustomTheme();
            ChunkDisplayValue = EChunkDisplayMode.VirtualParent;
            //limitTB.Enabled = limitCB.Checked;
            treeListView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;

            viewModel = _viewmodel;
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(viewModel.SelectedChunk):
                {
                    if (treeListView.SelectedObject != viewModel.SelectedChunk)
                        treeListView.SelectedObject = viewModel.SelectedChunk;
                    break;
                }
            }
        }

        #region UI Methods
        private void UpdateHelperList()
        {
            childrenDict.Clear();
            childrencountDict.Clear();

            if (File == null) return;

            File.GenerateChunksDict();

            var dParentids = new Dictionary<int, int>();
            if (ChunkDisplayValue == EChunkDisplayMode.Parent)
            {
                dParentids = File.chunks.ToDictionary(_ => _.ChunkIndex, _ => _.ParentChunkIndex);
            }
            else if (ChunkDisplayValue == EChunkDisplayMode.VirtualParent)
            {
                dParentids = File.chunks.ToDictionary(_ => _.ChunkIndex, _ => _.VirtualParentChunkIndex);
            }

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

            treeListView.CanExpandGetter = delegate (object x) {
                var idx = ((CR2WExportWrapper)x).ChunkIndex;
                return ChunkDisplayValue != EChunkDisplayMode.Linear && childrencountDict[idx] > 0;
            };
            treeListView.ChildrenGetter = delegate (object x) {
                var idx = ((CR2WExportWrapper)x).ChunkIndex;
                return ChunkDisplayValue != EChunkDisplayMode.Linear ? childrenDict[idx] : new List<CR2WExportWrapper>();
            };
        }

        public void UpdateList()
        {
            if (File == null)
                return;

            // Could be done only once... TODO decouple background worker result
            isLargefile = File.chunks.Count > 1000;
            if(isLargefile)
            {
                ChunkDisplayMenuItemLinear.Checked = true;
                ChunkDisplayMenuItemVirtualParent.Checked = true;
                ChunkDisplayMenuItemParent.Enabled = false;
                ChunkDisplayMenuItemVirtualParent.Enabled = false;
            }

            if (ChunkDisplayValue == EChunkDisplayMode.Linear)
                treeListView.Roots = File.chunks;
            else if (ChunkDisplayValue == EChunkDisplayMode.Parent)
            {
                UpdateHelperList();
                var model = File.chunks.Where(_ => _.GetParentChunk() == null).ToList();
                treeListView.Roots = model;

                treeListView.ExpandAll();
            }
            else if (ChunkDisplayValue == EChunkDisplayMode.VirtualParent)
            {
                UpdateHelperList();
                var model = File.chunks.Where(_ => _.GetVirtualParentChunk() == null).ToList();
                treeListView.Roots = model;

                treeListView.ExpandAll();
            }

            // select the first item
            //treeListView.SelectedIndex = 0; // TODO: doesn't work? why?
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
        #endregion

        #region Events
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            var selectedNodes = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList();
            if (selectedNodes.ToArray().Length <= 0)
            {
                e.Cancel = true;
                return;
            }

            pasteChunkToolStripMenuItem.Enabled = CopyController.Source != null
                                                  && CopyController.Source.Count == 1
                                                  && CopyController.Source.First() is CVariable ccopy
                                                  && selectedNodes.Count == 1 
                                                  && selectedNodes.First().data is CVariable csel
                                                  && csel.GetType() == ccopy.GetType();
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            viewModel.SelectedChunk = (CR2WExportWrapper) treeListView.SelectedObject;
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

        private void copyChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyController.Source = new List<IEditableVariable>() {viewModel.SelectedChunk.data};
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyController.Target = viewModel.SelectedChunk.data;
            viewModel.PasteVariableCommand.SafeExecute();
        }

        private void ExpandBTN_Click(object sender, EventArgs e) => treeListView.ExpandAll();

        private void CollapseBTN_Click(object sender, EventArgs e) => treeListView.CollapseAll();

        private void ChunkDisplayMenuItemLinear_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemParent.Checked = false;
            ChunkDisplayMenuItemVirtualParent.Checked = false;
            ChunkDisplayValue = EChunkDisplayMode.Linear;
            UpdateList();
        }

        private void ChunkDisplayMenuItemParent_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemLinear.Checked = false;
            ChunkDisplayMenuItemVirtualParent.Checked = false;
            ChunkDisplayValue = EChunkDisplayMode.Parent;
            UpdateList();
        }

        private void ChunkDisplayMenuItemVirtualParent_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemLinear.Checked = false;
            ChunkDisplayMenuItemParent.Checked = false;
            ChunkDisplayValue = EChunkDisplayMode.VirtualParent;
            UpdateList();
        }
        #endregion
    }
}
 