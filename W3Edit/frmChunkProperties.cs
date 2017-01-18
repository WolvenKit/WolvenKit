using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;
using W3Edit.CR2W.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmChunkProperties : DockContent
    {
        public frmChunkProperties()
        {
            InitializeComponent();

            treeView.CanExpandGetter = delegate(object x) { return ((VariableListNode)x).ChildCount > 0; };
            treeView.ChildrenGetter = delegate(object x) { return ((VariableListNode)x).Children; };
        }

        private CR2WChunk chunk;
        public CR2WChunk Chunk { 
            get {
                return chunk; 
            }
            set {
                chunk = value;
                CreatePropertyLayout(chunk);
            }
        }


        internal class VariableListNode
        {
            public string Name
            {
                get
                {
                    if (Variable.Name != null)
                        return Variable.Name;

                    if (Parent == null)
                        return "";

                    return Parent.Children.IndexOf(this).ToString();
                }
                set
                {
                    if (Variable.Name != null)
                    {
                        Variable.Name = value;
                    }
                }
            }
            public string Value { get { return Variable.ToString(); } }
            public string Type { get { return Variable.Type; } }

            public int ChildCount { get { return Children.Count; } }
            public List<VariableListNode> Children { get; set; }
            public VariableListNode Parent { get; set; }
            public IEditableVariable Variable { get; set; }
        }

        public IEditableVariable EditObject { get; set; }

        public void CreatePropertyLayout(IEditableVariable v)
        {
            if (EditObject != v)
            {
                EditObject = v;


                if (v == null)
                {
                    treeView.Roots = null;
                    return;
                }

                var root = AddListViewItems(v);

                treeView.Roots = root.Children;
                treeView.RefreshObjects(root.Children);

                for (var depth = 0; ExpandOneLevel(depth, root.Children); depth++) { }
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

                    if ((Win32.GetWindowLong(treeView.Handle, Win32.GWL_STYLE) & Win32.WS_VSCROLL) == Win32.WS_VSCROLL)
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

        private VariableListNode AddListViewItems(IEditableVariable v, VariableListNode parent = null, int arrayindex = 0)
        {
            var node = new VariableListNode();
            node.Variable = v;
            node.Children = new List<VariableListNode>();
            node.Parent = parent;

            var vars = v.GetEditableVariables();
            if (vars != null)
            {
                for (int i = 0; i < vars.Count; i++)
                {
                    node.Children.Add(AddListViewItems(vars[i], node, i));
                }
            }

            return node;
        }

        private void treeView_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column.AspectName == "Value")
            {
                e.Control = ((VariableListNode)e.RowObject).Variable.GetEditor();
                if (e.Control != null)
                {
                    e.Control.Location = new Point(e.CellBounds.Location.X, e.CellBounds.Location.Y - 1);
                    e.Control.Width = e.CellBounds.Width;
                }
                e.Cancel = e.Control == null;
            }
            else if(e.Column.AspectName == "Name")
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmChunkProperties_Resize(object sender, EventArgs e)
        {

        }

        private void frmChunkProperties_Shown(object sender, EventArgs e)
        {

        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            var node = (VariableListNode[])treeView.SelectedObjects;
            if (node == null || node.ToArray().Length <= 0)
            {
                e.Cancel = true;
                return;
            }

          //  addVariableToolStripMenuItem.Enabled = node.Variable.CanAddVariable(null);
           // removeVariableToolStripMenuItem.Enabled = node.Parent != null && node.Parent.Variable.CanRemoveVariable(node.Variable);
           // pasteToolStripMenuItem.Enabled = CopyController.VariableTarget != null && node.Variable != null && node.Variable.CanAddVariable(CopyController.VariableTarget);
           // ptrPropertiesToolStripMenuItem.Visible = node.Variable is CPtr;
        }

        private void copyVariable()
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node == null || node.Variable == null)
            {
                return;
            }

            CopyController.VariableTarget = node.Variable;
        }

        private void pasteVariable()
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (CopyController.VariableTarget == null || node == null || node.Variable == null || !node.Variable.CanAddVariable(null))
            {
                return;
            }

            if (CopyController.VariableTarget is CVariable)
            {
                var cvar = (CVariable)CopyController.VariableTarget;

                var context = new CR2WCopyAction()
                {
                    SourceFile = cvar.cr2w,
                    DestinationFile = node.Variable.CR2WOwner,
                    MaxIterationDepth = 0,
                };

                var newvar = cvar.Copy(context);
                node.Variable.AddVariable(newvar);

                var subnode = AddListViewItems(newvar, node);
                node.Children.Add(subnode);

                treeView.RefreshObject(node);
                treeView.RefreshObject(subnode);
            }
        }

        private void addVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node == null || node.Variable == null || !node.Variable.CanAddVariable(null))
            {
                return;
            }

            CVariable newvar = null;

            if(node.Variable is CArray)
            {
                var nodearray = (CArray)node.Variable;
                newvar = CR2WTypeManager.Get().GetByName(nodearray.elementtype, "", Chunk.cr2w, false);
                if (newvar == null)
                    return;
            }
            else
            {
                var frm = new frmAddVariable();
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                newvar = CR2WTypeManager.Get().GetByName(frm.VariableType, frm.VariableName, Chunk.cr2w, false);
                if (newvar == null)
                    return;

                newvar.Name = frm.VariableName;
                newvar.Type = frm.VariableType;
            }

            if(newvar is CHandle)
            {
                var result = MessageBox.Show("Add as chunk handle? (Yes for chunk handle, No for normal handle)", "Adding handle.", MessageBoxButtons.YesNoCancel);
                if(result == System.Windows.Forms.DialogResult.Cancel)
                    return;

                ((CHandle)newvar).ChunkHandle = result == System.Windows.Forms.DialogResult.Yes;
            }

            node.Variable.AddVariable(newvar);

            var subnode = AddListViewItems(newvar, node);
            node.Children.Add(subnode);

            treeView.RefreshObject(node);
            treeView.RefreshObject(subnode);

        }

        private void removeVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node == null || node.Parent == null || !node.Parent.Variable.CanRemoveVariable(node.Variable))
            {
                return;
            }

            node.Parent.Variable.RemoveVariable(node.Variable);
            node.Parent.Children.Remove(node);

            treeView.RefreshObject(node.Parent);
        }



        public object Source { get; set; }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        private void expandAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if(node != null)
            {
                treeView.Expand(node);
                foreach(var c in node.Children)
                {
                    treeView.Expand(c);
                }
            }
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }

        private void collapseAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node != null)
            {
                foreach (var c in node.Children)
                {
                    treeView.Collapse(c);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyVariable();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteVariable();
        }

        private void editNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if (e.Column == null || e.Item == null)
                return;

            if (e.ClickCount == 2 && e.Column.AspectName == "Name")
            {
                treeView.StartCellEdit(e.Item, 0);
            }
            else if(e.Column.AspectName == "Value")
            {
                treeView.StartCellEdit(e.Item, 1);
            }
        }

        private void ptrPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node == null || !(node.Variable is CPtr) || ((CPtr)node.Variable).PtrTarget == null)
            {
                return;
            }

            Chunk = ((CPtr)node.Variable).PtrTarget;
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = (VariableListNode)treeView.SelectedObject;
            if (node == null || node.Parent == null || !node.Parent.Variable.CanRemoveVariable(node.Variable))
            {
                return;
            }

            Clipboard.SetText(node.Value);
        }


    }
}
