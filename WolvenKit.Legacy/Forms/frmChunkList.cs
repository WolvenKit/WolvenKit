using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit;
using WolvenKit.Commands;
using WolvenKit.Model;
using WolvenKit.ViewModels;
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
        #endregion

        #region Properties
        //public event EventHandler<SelectChunkArgs> OnSelectChunk;

        private CR2WFile File => viewModel.File as CR2WFile;


        #endregion

        public frmChunkList(CR2WDocumentViewModel _viewmodel)
        {
            InitializeComponent();
            ApplyCustomTheme();
            //limitTB.Enabled = limitCB.Checked;
            treeListView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;

            viewModel = _viewmodel;
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(viewModel.SelectedChunks):
                {
                    // ??
                    /*if (treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList() != viewModel.SelectedChunks)
                        {
                            var d1 = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList();
                            var d2 = viewModel.SelectedChunks;
                            var d3 = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList().Equals(viewModel.SelectedChunks);
                            var d4 = d1 == d2;*/

                    var left = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList();
                    var right = viewModel.SelectedChunks;
                    if (left.Count()==right.Count())
                    {
                        var equals = true;
                        for (int i = 0; i < left.Count(); i++)
                        {
                            if (left[i] != right[i]) { equals = false; break; }
                        }
                        if (!equals)
                        {
                            treeListView.SelectedObjects = viewModel.SelectedChunks;
                        }
                    }
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
            if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.Parent)
            {
                dParentids = File.Chunks.ToDictionary(_ => _.ChunkIndex, _ => _.ParentChunkIndex);
            }
            else if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.VirtualParent)
            {
                dParentids = File.Chunks.ToDictionary(_ => _.ChunkIndex, _ => _.VirtualParentChunkIndex);
            }

            foreach (var chunk in File.Chunks)
            {
                var childrenidxlist = dParentids.Where(_ => _.Value == chunk.ChunkIndex).Select(_ => _.Key);

                IEnumerable<int> enumerable = childrenidxlist as int[] ?? childrenidxlist.ToArray();
                if (enumerable.Any())
                {
                    List<CR2WExportWrapper> children = enumerable.Select(childid => File.Chunksdict[childid]).ToList();
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
                return viewModel.chunkDisplayMode != CR2WDocumentViewModel.EChunkDisplayMode.Linear && childrencountDict[idx] > 0;
            };
            treeListView.ChildrenGetter = delegate (object x) {
                var idx = ((CR2WExportWrapper)x).ChunkIndex;
                return viewModel.chunkDisplayMode != CR2WDocumentViewModel.EChunkDisplayMode.Linear ? childrenDict[idx] : new List<CR2WExportWrapper>();
            };
        }

        public void UpdateList()
        {
            if (File == null)
                return;

            // Could be done only once... TODO decouple background worker result
            isLargefile = File.Chunks.Count > 1000;
            if(isLargefile)
            {
                ChunkDisplayMenuItemLinear.Checked = true;
                ChunkDisplayMenuItemVirtualParent.Checked = true;
                ChunkDisplayMenuItemParent.Enabled = false;
                ChunkDisplayMenuItemVirtualParent.Enabled = false;
            }

            if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.Linear)
                treeListView.Roots = File.Chunks;
            else if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.Parent)
            {
                UpdateHelperList();
                var model = File.Chunks.Where(_ => _.ParentChunk == null).ToList();
                treeListView.Roots = model;

                treeListView.ExpandAll();
            }
            else if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.VirtualParent)
            {
                UpdateHelperList();
                var model = File.Chunks.Where(_ => _.VirtualParentChunk == null).ToList();
                treeListView.Roots = model;

                treeListView.ExpandAll();
            }

            // find selectedchunk index
            CR2WExportWrapper selectedChunk = viewModel.SelectedChunk;
            if (selectedChunk != null && selectedChunk.ChunkIndex <= treeListView.Items.Count)
                treeListView.SelectedIndex = selectedChunk.ChunkIndex;
            else
                treeListView.SelectedIndex = 0;
            this.Update();
        }

        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetThemeBase());
            toolStripSearchBox.BackColor = UIController.GetPalette().ToolWindowCaptionButtonInactiveHovered.Background;

            this.treeListView.BackColor = UIController.GetBackColor();
            this.treeListView.ForeColor = UIController.GetForeColor();

            this.treeListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            treeListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;

            this.toolStripSearchBox.BackColor = UIController.GetPalette().ToolWindowCaptionButtonInactiveHovered.Background;
            this.toolStripSearchBox.ForeColor = UIController.GetForeColor();
        }
        #endregion

        #region Events
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            List<CR2WExportWrapper> selectedNodes = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList();
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

            AddChunkPointers(toolStripMenuItemAddChunk, selectedNodes.FirstOrDefault());


        }

        private void AddChunkPointers(ToolStripMenuItem menu, CR2WExportWrapper chunk)
        {
            var chunkData = chunk.data;
            menu.DropDownItems.Clear();

            foreach (var variable in chunkData.GetEditableVariables())
            {
                if (variable is IHandleAccessor ihdl && ihdl.IsSerialized && !ihdl.ChunkHandle) continue;

                // single ptrs
                if (variable is IChunkPtrAccessor ptrAccessor)
                {
                    ToolStripItem item = new ToolStripMenuItem()
                    {
                        Text = ptrAccessor.REDName,
                        Name = ptrAccessor.REDName,
                        Tag = variable
                    };
                    item.Click += new EventHandler(ptr_Click);
                    menu.DropDownItems.Add(item);
                }

                // array ptrs
                if (variable is IArrayAccessor arrayAccessor 
                    && (arrayAccessor.Elementtype.Contains("handle:") || arrayAccessor.Elementtype.Contains("ptr:")))
                {
                    ToolStripItem item = new ToolStripMenuItem()
                    {
                        Text = arrayAccessor.REDName,
                        Name = arrayAccessor.REDName,
                        Tag = variable
                    };
                    item.Click += new EventHandler(arrayPtr_Click);
                    menu.DropDownItems.Add(item);
                }
            }


            void ptr_Click(object sender, EventArgs e)
            {
                if (sender is ToolStripItem item && item.Tag is IEditableVariable variable && variable is IChunkPtrAccessor ptrAccessor)
                {
                    viewModel.AddNewChunkFor(ptrAccessor);
                }
            }

            void arrayPtr_Click(object sender, EventArgs e)
            {
                if (sender is ToolStripItem item && item.Tag is IEditableVariable variable)
                {
                    viewModel.AddListElement(variable);
                }
            }

        }

        

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            viewModel.SelectedChunks = treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList();
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
            CopyController.Source = viewModel.SelectedChunks.Select(_=>_.data as IEditableVariable).ToList();
        }

        private void pasteChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewModel.SelectedChunks.Count()>1)
            {
                return;
            }
            CopyController.Target = viewModel.SelectedChunks.First().data;
            viewModel.PasteVariableCommand.SafeExecute();
        }

        private void ExpandBTN_Click(object sender, EventArgs e) => treeListView.ExpandAll();

        private void CollapseBTN_Click(object sender, EventArgs e) => treeListView.CollapseAll();

        private void ChunkDisplayMenuItemLinear_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemParent.Checked = false;
            ChunkDisplayMenuItemVirtualParent.Checked = false;
            viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.Linear;
            UpdateList();
        }

        private void ChunkDisplayMenuItemParent_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemLinear.Checked = false;
            ChunkDisplayMenuItemVirtualParent.Checked = false;
            viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.Parent;
            UpdateList();
        }

        private void ChunkDisplayMenuItemVirtualParent_Click(object sender, EventArgs e)
        {
            ChunkDisplayMenuItemLinear.Checked = false;
            ChunkDisplayMenuItemParent.Checked = false;
            viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.VirtualParent;
            UpdateList();
        }
        #endregion

        /// <summary>
        /// Tri-state toggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChunkDisplayMode_ButtonClick(object sender, EventArgs e)
        {
            if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.Linear)
            {
                ChunkDisplayMenuItemLinear.Checked = false;
                viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.Parent;
                ChunkDisplayMenuItemParent.Checked = true;
                UpdateList();
            }
            else if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.Parent)
            {
                ChunkDisplayMenuItemParent.Checked = false;
                viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.VirtualParent;
                ChunkDisplayMenuItemVirtualParent.Checked = true;
                UpdateList();
            }
            else if (viewModel.chunkDisplayMode == CR2WDocumentViewModel.EChunkDisplayMode.VirtualParent)
            {
                ChunkDisplayMenuItemVirtualParent.Checked = false;
                viewModel.chunkDisplayMode = CR2WDocumentViewModel.EChunkDisplayMode.Linear;
                ChunkDisplayMenuItemLinear.Checked = true;
                UpdateList();
            }
        }

        private void deleteChunktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.RemoveChunks(
                treeListView.SelectedObjects.Cast<CR2WExportWrapper>().ToList(),
                false,
                (CR2WFile.EChunkDisplayMode)viewModel.chunkDisplayMode);
        }
    }
}
 