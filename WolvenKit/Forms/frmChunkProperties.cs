using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmChunkProperties : DockContent, IThemedContent
    {
        internal class VariableListNode
        {
            public string Name
            {
                get
                {
                    if (Variable.REDName != null)
                        return Variable.REDName;
                    else
                        return Parent?.Children.IndexOf(this).ToString() ?? "";
                }
            }

            public string Value => Variable.REDValue;
            public string Type => Variable.REDType;
            public bool IsSerialized => Variable.IsSerialized;

            public int ChildCount => Children.Count;

            public List<VariableListNode> Children { get; set; }
            public VariableListNode Parent { get; set; }
            public IEditableVariable Variable { get; set; }
        }



        private CR2WExportWrapper chunk;
        private bool showOnlySerialized;

        public frmChunkProperties()
        {
            InitializeComponent();
            ApplyCustomTheme();

            treeView.CanExpandGetter = x => ((VariableListNode) x).ChildCount > 0;
            treeView.ChildrenGetter = x => ((VariableListNode) x).Children;

            toolStripButtonShowSerialized.Text = showOnlySerialized
                ? "Show all variables"
                : "Show edited variables";
        }

        public CR2WExportWrapper Chunk
        {
            get { return chunk; }
            set
            {
                chunk = value;
                UpdateTreeListView();
            }
        }

        public object Source { get; set; }

        public void UpdateTreeListView()
        {
            if (chunk == null)
            {
                treeView.Roots = null;
                return;
            }

            var root = AddListViewItems(chunk.data, showOnlySerialized);

            treeView.Roots = root.Children;
            //treeView.RefreshObjects(root.Children);



            // filter
            if (!string.IsNullOrEmpty(toolStripSearchBox.Text.ToUpper()))
            {
                this.treeView.ModelFilter = TextMatchFilter.Contains(treeView, toolStripSearchBox.Text.ToUpper());
            }
            else
            {
                this.treeView.ModelFilter = null;
                
            }

            for (var depth = 0; ExpandOneLevel(depth, root.Children); depth++)
            {
            }

        }

        private bool ExpandOneLevel(int depth, List<VariableListNode> children, int currentLevel = 0)
        {
            var expandedSomething = false;

            foreach (var c in children)
            {
                if (currentLevel == depth)
                {
                    treeView.Expand(c);

                    if ((NativeMethods.GetWindowLong(treeView.Handle, NativeMethods.GWL_STYLE) & NativeMethods.WS_VSCROLL) == NativeMethods.WS_VSCROLL)
                    {
                        treeView.Collapse(c);
                        return false;
                    }

                    expandedSomething = true;
                }
                else
                {
                    if (ExpandOneLevel(depth, c.Children, currentLevel + 1))
                        expandedSomething = true;
                }
            }

            return expandedSomething;
        }

        internal static VariableListNode AddListViewItems(IEditableVariable v
            , bool showOnlySerialized = false
            , VariableListNode parent = null
            , int arrayindex = 0
            )
        {
            var node = new VariableListNode()
            {
                Variable = v,
                Children = new List<VariableListNode>(),
                Parent = parent
            };
            List<IEditableVariable> vars = showOnlySerialized 
                ? v.GetEditableVariables().Where(_ => _.IsSerialized).ToList() 
                : v.GetEditableVariables();

            if (vars != null)
            {
                for (var i = 0; i < vars.Count; i++)
                {
                    node.Children.Add(AddListViewItems(vars[i], showOnlySerialized, node, i));
                }
            }

            return node;
        }


        private void frmChunkProperties_Resize(object sender, EventArgs e)
        {
        }

        private void frmChunkProperties_Shown(object sender, EventArgs e)
        {
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            var selectedNodes = treeView.SelectedObjects.Cast<VariableListNode>().Where(item => item?.Variable != null).ToList();
            if (selectedNodes.ToArray().Length <= 0)
            {
                e.Cancel = true;
                return;
            }

            // for carrays
            addVariableToolStripMenuItem.Enabled = selectedNodes.All(x => x.Variable.CanAddVariable(null));
            removeVariableToolStripMenuItem.Enabled = selectedNodes.All(x => x.Parent != null && x.Parent.Variable.CanRemoveVariable(x.Variable));

            //  paste variable is active if any one variable has been copied and if the one selected variable is of the same type
            pasteToolStripMenuItem.Enabled = CopyController.VariableTargets != null
                && CopyController.VariableTargets.Count == 1 && CopyController.VariableTargets.First() is CVariable ccopy
                && selectedNodes.Count == 1 && selectedNodes.First().Variable is CVariable csel
                && csel.GetType() == ccopy.GetType();

            ptrPropertiesToolStripMenuItem.Visible = selectedNodes.All(x => x.Variable is IPtrAccessor) && selectedNodes.Count == 1;
        }

        public void CopyVariable()
        {
            var tocopynodes = (from VariableListNode item in treeView.SelectedObjects where item?.Variable != null select item.Variable).ToList();
            if (tocopynodes.Count > 0)
                CopyController.VariableTargets = tocopynodes;
        }

        public void PasteVariable()
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (CopyController.VariableTargets == null || node?.Variable == null)
                return;

            if (CopyController.VariableTargets.Count == 1
                && CopyController.VariableTargets.First() is CVariable cvar
                && cvar.REDType == node.Variable.REDType
                && node.Variable is CVariable targetvar
                )
            {
                var context = new CR2WCopyAction()
                {
                    DestinationFile = targetvar.cr2w,
                    Parent = targetvar.ParentVar as CVariable
                };
                var copy = cvar.Copy(context);
                targetvar.SetValue(copy);
                targetvar.IsSerialized = true;

                UpdateTreeListView();

                return;
            }
        }

        private void addVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode) treeView.SelectedObject;
            if (node?.Variable == null || !node.Variable.CanAddVariable(null) || !(node.Variable is IArrayAccessor parentarray))
                return;

            // instantiate all child Cvars??
            CVariable newvar = CR2WTypeManager.Create(parentarray.Elementtype, "", Chunk.cr2w, node.Variable as CVariable, false);
            if (newvar == null)
                return;

            node.Variable.AddVariable(newvar);

            var subnode = AddListViewItems(newvar, showOnlySerialized, node);
            node.Children.Add(subnode);

            treeView.RefreshObject(node);
            treeView.RefreshObject(subnode);
        }

        private void removeVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // removing variables from arrays
            foreach (VariableListNode node in treeView.SelectedObjects)
            {
                if (node?.Parent != null && node.Parent.Variable.CanRemoveVariable(node.Variable))
                {
                    node.Parent.Variable.RemoveVariable(node.Variable);
                    node.Parent.Children.Remove(node);
                    try
                    {
                        treeView.RefreshObject(node.Parent);
                    }
                    catch { } //TODO: Do this better, works now but it shouldn't be done like this. :p
                }
            }
        }

        private void clearVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node?.Variable == null)
            {
                return;
            }
            else
            {
                throw new NotImplementedException();
            }

        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e) => treeView.ExpandAll();

        private void expandAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode) treeView.SelectedObject;
            if (node != null)
            {
                treeView.Expand(node);
                foreach (var c in node.Children)
                {
                    treeView.Expand(c);
                }
            }
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e) => treeView.CollapseAll();

        private void collapseAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode) treeView.SelectedObject;
            if (node != null)
            {
                foreach (var c in node.Children)
                {
                    treeView.Collapse(c);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => CopyVariable();

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => PasteVariable();

        private void treeView_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == null || e.Item == null)
                return;

            //if (e.ClickCount == 2 && e.Column.AspectName == nameof(VariableListNode.Name))
            //{
            //    treeView.StartCellEdit(e.Item, 0);
            //}
            //else 
            if (e.Column.AspectName == nameof(VariableListNode.Value))
            {
                treeView.StartCellEdit(e.Item, olvColumn4.Index);
            }
        }

        private void ptrPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode) treeView.SelectedObject;
            if ((node?.Variable as IPtrAccessor)?.Reference == null)
                return;

            Chunk = ((IPtrAccessor) node.Variable).Reference;
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode) treeView.SelectedObject;
            if (node?.Parent == null || !node.Parent.Variable.CanRemoveVariable(node.Variable))
                return;
            if (node.Value != null)
            {
                if(node.Value == "")
                    Clipboard.SetText(node.Type + ":??");
                else
                    Clipboard.SetText(node.Value);

            }
        }

        

        public event EventHandler OnItemsChanged;
        private void treeView_ItemsChanged(object sender, ItemsChangedEventArgs e) => MainController.Get().ProjectUnsaved = true;

        private void treeView_CellEditStarting(object sender, CellEditEventArgs e)
        {
            //var variable = (e.RowObject as VariableListNode).Variable;
            if (e.Column.AspectName == "Value")
            {
                e.Control = ((VariableListNode)e.RowObject).Variable.GetEditor();
                if (e.Control != null)
                {
                    e.Control.Location = new Point(e.CellBounds.Location.X, e.CellBounds.Location.Y - 1);
                    e.Control.Width = e.CellBounds.Width;
                    //e.Control.ForeColor = Control.Tex
                }
                e.Cancel = e.Control == null;
            }
            else if (e.Column.AspectName == "Name")
            {
                //Normal textbox is good for this.
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void treeView_CellEditFinished(object sender, CellEditEventArgs e)
        {
/*            if (chunk.ParentPtr.Reference != null)
                chunk.SetParentChunkId(chunk.ParentPtr.Reference.ChunkIndex + 1);*/
            OnItemsChanged(sender, e);

            // change the model's isserialized property to true when the user edits it,
            // this is to make sure only user-edited properties will get serialized
            var model = e.ListViewItem.RowObject as VariableListNode;
            if (model.Variable is CVariable cvar)
                cvar.SetIsSerialized();

        }

        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip1, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetTheme());
            toolStripSearchBox.BackColor = UIController.GetPalette().ToolWindowCaptionButtonInactiveHovered.Background;

            this.treeView.BackColor = UIController.GetBackColor();
            this.treeView.AlternateRowBackColor = UIController.GetPalette().OverflowButtonHovered.Background;

            this.treeView.ForeColor = UIController.GetForeColor();
            
            this.treeView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            treeView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
        }

        private void treeView_FormatRow(object sender, FormatRowEventArgs e)
        {
            VariableListNode model = (VariableListNode)e.Model;
            if (model != null && model.IsSerialized)
            {
                if (!showOnlySerialized)
                    e.Item.ForeColor = UIController.GetPalette().OverflowButtonPressed.Border; //Color.Green;
            }
            else
            {

            }
        }

        private void toolStripClearButton_Click(object sender, EventArgs e)
        {
            toolStripSearchBox.Clear();
            UpdateTreeListView();
        }

        private void toolStripSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTreeListView();
        }

        private void toolStripButtonShowSerialized_Click(object sender, EventArgs e)
        {
            // toggle
            showOnlySerialized = !showOnlySerialized;

            toolStripButtonShowSerialized.Text = showOnlySerialized
                ? "Show all variables"
                : "Show edited variables";

            UpdateTreeListView();
        }

        
    }
}