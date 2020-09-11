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
        private CR2WExportWrapper chunk;
        private bool showOnlySerialized;

        

        public frmChunkProperties()
        {
            InitializeComponent();
            ApplyCustomTheme();

            treeView.CanExpandGetter = x =>
            {
                var root = showOnlySerialized
                    ? ((IEditableVariable)x).GetEditableVariables().Where(_ => _.IsSerialized)
                    : ((IEditableVariable)x).GetEditableVariables();
                return root.Count() > 0;
            };
            treeView.ChildrenGetter = x =>
            {
                var root = showOnlySerialized
                    ? ((IEditableVariable)x).GetEditableVariables().Where(_ => _.IsSerialized)
                    : ((IEditableVariable)x).GetEditableVariables();
                return root;
            };

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

            var root = showOnlySerialized 
                ? chunk.GetEditableVariables().Where(_ => _.IsSerialized) 
                : chunk.GetEditableVariables();

            treeView.Roots = root;

            // filter
            if (!string.IsNullOrEmpty(toolStripSearchBox.Text.ToUpper()))
            {
                this.treeView.ModelFilter = TextMatchFilter.Contains(treeView, toolStripSearchBox.Text.ToUpper());
            }
            else
            {
                this.treeView.ModelFilter = null;
            }

            treeView.ExpandAll();
        }


        private void frmChunkProperties_Resize(object sender, EventArgs e)
        {
        }

        private void frmChunkProperties_Shown(object sender, EventArgs e)
        {
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            var selectedNodes = treeView.SelectedObjects.Cast<IEditableVariable>().ToList();
            if (selectedNodes.ToArray().Length <= 0)
            {
                e.Cancel = true;
                return;
            }

            // for carrays
            addVariableToolStripMenuItem.Enabled = selectedNodes.All(x => x.CanAddVariable(null));
            removeVariableToolStripMenuItem.Enabled = selectedNodes.All(x => x.Parent != null && x.Parent.CanRemoveVariable(x));

            //  paste variable is active if any one variable has been copied and if the one selected variable is of the same type
            pasteToolStripMenuItem.Enabled = CopyController.VariableTargets != null
                && CopyController.VariableTargets.Count == 1 && CopyController.VariableTargets.First() is CVariable ccopy
                && selectedNodes.Count == 1 && selectedNodes.First() is CVariable csel
                && csel.GetType() == ccopy.GetType();

            ptrPropertiesToolStripMenuItem.Visible = selectedNodes.All(x => x is IPtrAccessor) && selectedNodes.Count == 1;
        }

        public void CopyVariable()
        {
            var tocopynodes = (from IEditableVariable item in treeView.SelectedObjects where item != null select item).ToList();
            if (tocopynodes.Count > 0)
                CopyController.VariableTargets = tocopynodes;
        }

        public void PasteVariable()
        {
            var node = (IEditableVariable)treeView.SelectedObject;
            if (CopyController.VariableTargets == null || node == null)
                return;

            if (CopyController.VariableTargets.Count == 1
                && CopyController.VariableTargets.First() is CVariable cvar
                && cvar.REDType == node.REDType
                && node is CVariable targetvar
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
            var node = (IEditableVariable) treeView.SelectedObject;
            if (node == null || !node.CanAddVariable(null) || !(node is IArrayAccessor parentarray))
                return;

            // instantiate all child Cvars??
            CVariable newvar = CR2WTypeManager.Create(parentarray.Elementtype, "", Chunk.cr2w, node as CVariable, false);
            if (newvar == null)
                return;

            node.AddVariable(newvar);
            treeView.RefreshObject(node);
        }

        private void removeVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // removing variables from arrays
            foreach (IEditableVariable node in treeView.SelectedObjects)
            {
                if (node?.Parent != null && node.Parent.CanRemoveVariable(node))
                {
                    node.Parent.RemoveVariable(node);
                    treeView.RefreshObject(node.Parent);
                }
            }
        }

        private void clearVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (IEditableVariable)treeView.SelectedObject;
            if (node == null)
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
            var node = (IEditableVariable) treeView.SelectedObject;
            if (node != null)
            {
                treeView.Expand(node);
            }
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e) => treeView.CollapseAll();

        private void collapseAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (IEditableVariable) treeView.SelectedObject;
            if (node != null)
            {
                treeView.Collapse(node);
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
            if (e.Column.AspectName == nameof(IEditableVariable.REDValue))
            {
                treeView.StartCellEdit(e.Item, olvColumn4.Index);
            }
        }

        private void ptrPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (IEditableVariable) treeView.SelectedObject;
            if ((node as IPtrAccessor)?.Reference == null)
                return;

            Chunk = ((IPtrAccessor) node).Reference;
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (IEditableVariable) treeView.SelectedObject;
            if (node?.Parent == null || !node.Parent.CanRemoveVariable(node))
                return;
            if (node.REDValue != null)
            {
                if(node.REDValue == "")
                    Clipboard.SetText(node.REDType + ":??");
                else
                    Clipboard.SetText(node.REDValue);

            }
        }

        

        public event EventHandler OnItemsChanged;
        private void treeView_ItemsChanged(object sender, ItemsChangedEventArgs e) => MainController.Get().ProjectUnsaved = true;

        private void treeView_CellEditStarting(object sender, CellEditEventArgs e)
        {
            //var variable = (e.RowObject as VariableListNode).Variable;
            if (e.Column.AspectName == "REDValue")
            {
                e.Control = ((IEditableVariable)e.RowObject).GetEditor();
                if (e.Control != null)
                {
                    e.Control.Location = new Point(e.CellBounds.Location.X, e.CellBounds.Location.Y - 1);
                    e.Control.Width = e.CellBounds.Width;
                    //e.Control.ForeColor = Control.Tex
                }
                e.Cancel = e.Control == null;
            }
            else if (e.Column.AspectName == "REDName")
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
            var model = e.ListViewItem.RowObject as IEditableVariable;
            if (model is CVariable cvar)
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
            IEditableVariable model = (IEditableVariable)e.Model;
            if (model != null && model.IsSerialized)
            {
                //if (!showOnlySerialized)
                {
                    int themeID = (int)UIController.Get().Configuration.ColorTheme;
                    Color forecolor = Color.FromArgb(UIController.Get().Configuration.CustomHighlightColor[themeID]);
                    e.Item.ForeColor = forecolor;
                }
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

        private void toolStripButtonColorPicker_Click(object sender, EventArgs e)
        {
            int themeID = (int)UIController.Get().Configuration.ColorTheme;
            Color forecolor = Color.FromArgb(UIController.Get().Configuration.CustomHighlightColor[themeID]);


            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = true,
                ShowHelp = true,
                Color = forecolor
            };

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                UIController.Get().Configuration.CustomHighlightColor[themeID] = MyDialog.Color.ToArgb();
                UIController.Get().Configuration.Save();
            }
        }
    }
}