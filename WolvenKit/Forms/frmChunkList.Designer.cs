using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace WolvenKit.Forms
{
    partial class frmChunkList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChunkList));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteChunktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.olvcolName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcolPreview = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.ChunkDisplayMode = new System.Windows.Forms.ToolStripSplitButton();
            this.ChunkDisplayMenuItemLinear = new System.Windows.Forms.ToolStripMenuItem();
            this.ChunkDisplayMenuItemParent = new System.Windows.Forms.ToolStripMenuItem();
            this.ChunkDisplayMenuItemVirtualParent = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpandBTN = new System.Windows.Forms.ToolStripButton();
            this.CollapseBTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItemAddChunk = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.expandAllChildrenToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.collapseAllChildrenToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyChunkToolStripMenuItem,
            this.pasteChunkToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteChunktoolStripMenuItem,
            this.toolStripMenuItemAddChunk});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 278);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.ExpandAll_16x;
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // expandAllChildrenToolStripMenuItem
            // 
            this.expandAllChildrenToolStripMenuItem.Name = "expandAllChildrenToolStripMenuItem";
            this.expandAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.expandAllChildrenToolStripMenuItem.Text = "Expand All Children";
            this.expandAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.expandAllChildrenToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.CollapseAll_16x;
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // collapseAllChildrenToolStripMenuItem
            // 
            this.collapseAllChildrenToolStripMenuItem.Name = "collapseAllChildrenToolStripMenuItem";
            this.collapseAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.collapseAllChildrenToolStripMenuItem.Text = "Collapse All Children";
            this.collapseAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.collapseAllChildrenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // copyChunkToolStripMenuItem
            // 
            this.copyChunkToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Copy_16x;
            this.copyChunkToolStripMenuItem.Name = "copyChunkToolStripMenuItem";
            this.copyChunkToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.copyChunkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyChunkToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.copyChunkToolStripMenuItem.Text = "Copy Chunk";
            this.copyChunkToolStripMenuItem.Click += new System.EventHandler(this.copyChunkToolStripMenuItem_Click);
            // 
            // pasteChunkToolStripMenuItem
            // 
            this.pasteChunkToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Paste_16x;
            this.pasteChunkToolStripMenuItem.Name = "pasteChunkToolStripMenuItem";
            this.pasteChunkToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.pasteChunkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteChunkToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.pasteChunkToolStripMenuItem.Text = "Paste Chunk";
            this.pasteChunkToolStripMenuItem.Click += new System.EventHandler(this.pasteChunkToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // deleteChunktoolStripMenuItem
            // 
            this.deleteChunktoolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Close_red_16x;
            this.deleteChunktoolStripMenuItem.Name = "deleteChunktoolStripMenuItem";
            this.deleteChunktoolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteChunktoolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.deleteChunktoolStripMenuItem.Text = "Delete chunk";
            this.deleteChunktoolStripMenuItem.ToolTipText = "Delete chunk(s), and children chunks according to chunk display mode";
            this.deleteChunktoolStripMenuItem.Click += new System.EventHandler(this.deleteChunktoolStripMenuItem_Click);
            // 
            // treeListView
            // 
            this.treeListView.AllColumns.Add(this.olvcolName);
            this.treeListView.AllColumns.Add(this.olvcolPreview);
            this.treeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvcolName,
            this.olvcolPreview});
            this.treeListView.ContextMenuStrip = this.contextMenuStrip1;
            this.treeListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView.FullRowSelect = true;
            this.treeListView.HideSelection = false;
            this.treeListView.Location = new System.Drawing.Point(0, 27);
            this.treeListView.Margin = new System.Windows.Forms.Padding(2);
            this.treeListView.Name = "treeListView";
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(795, 522);
            this.treeListView.TabIndex = 0;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.UseFiltering = true;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            this.treeListView.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.listView_ItemsChanged);
            // 
            // olvcolName
            // 
            this.olvcolName.AspectName = "REDName";
            this.olvcolName.Text = "Name";
            this.olvcolName.Width = 300;
            // 
            // olvcolPreview
            // 
            this.olvcolPreview.AspectName = "Preview";
            this.olvcolPreview.FillsFreeSpace = true;
            this.olvcolPreview.Text = "Preview";
            this.olvcolPreview.Width = 300;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSearchBox,
            this.toolStripClearButton,
            this.ChunkDisplayMode,
            this.ExpandBTN,
            this.CollapseBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 31);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::WolvenKit.Properties.Resources.Filter_16x;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(24, 28);
            this.toolStripLabel1.Text = "Filter: ";
            // 
            // toolStripSearchBox
            // 
            this.toolStripSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSearchBox.Name = "toolStripSearchBox";
            this.toolStripSearchBox.Size = new System.Drawing.Size(122, 31);
            this.toolStripSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyUp);
            // 
            // toolStripClearButton
            // 
            this.toolStripClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClearButton.Image = global::WolvenKit.Properties.Resources.Close_red_16x;
            this.toolStripClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearButton.Name = "toolStripClearButton";
            this.toolStripClearButton.Size = new System.Drawing.Size(28, 28);
            this.toolStripClearButton.Text = "Clear";
            this.toolStripClearButton.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // ChunkDisplayMode
            // 
            this.ChunkDisplayMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ChunkDisplayMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChunkDisplayMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChunkDisplayMenuItemLinear,
            this.ChunkDisplayMenuItemParent,
            this.ChunkDisplayMenuItemVirtualParent});
            this.ChunkDisplayMode.Image = global::WolvenKit.Properties.Resources.ui_menu_blue;
            this.ChunkDisplayMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChunkDisplayMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChunkDisplayMode.Name = "ChunkDisplayMode";
            this.ChunkDisplayMode.Size = new System.Drawing.Size(32, 28);
            this.ChunkDisplayMode.Text = "Chunk display mode";
            this.ChunkDisplayMode.ToolTipText = "Chunk display mode";
            this.ChunkDisplayMode.ButtonClick += new System.EventHandler(this.ChunkDisplayMode_ButtonClick);
            // 
            // ChunkDisplayMenuItemLinear
            // 
            this.ChunkDisplayMenuItemLinear.CheckOnClick = true;
            this.ChunkDisplayMenuItemLinear.Name = "ChunkDisplayMenuItemLinear";
            this.ChunkDisplayMenuItemLinear.Size = new System.Drawing.Size(145, 22);
            this.ChunkDisplayMenuItemLinear.Text = "Linear";
            this.ChunkDisplayMenuItemLinear.Click += new System.EventHandler(this.ChunkDisplayMenuItemLinear_Click);
            // 
            // ChunkDisplayMenuItemParent
            // 
            this.ChunkDisplayMenuItemParent.CheckOnClick = true;
            this.ChunkDisplayMenuItemParent.Name = "ChunkDisplayMenuItemParent";
            this.ChunkDisplayMenuItemParent.Size = new System.Drawing.Size(145, 22);
            this.ChunkDisplayMenuItemParent.Text = "Parent";
            this.ChunkDisplayMenuItemParent.Click += new System.EventHandler(this.ChunkDisplayMenuItemParent_Click);
            // 
            // ChunkDisplayMenuItemVirtualParent
            // 
            this.ChunkDisplayMenuItemVirtualParent.Checked = true;
            this.ChunkDisplayMenuItemVirtualParent.CheckOnClick = true;
            this.ChunkDisplayMenuItemVirtualParent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChunkDisplayMenuItemVirtualParent.Name = "ChunkDisplayMenuItemVirtualParent";
            this.ChunkDisplayMenuItemVirtualParent.Size = new System.Drawing.Size(145, 22);
            this.ChunkDisplayMenuItemVirtualParent.Text = "Virtual Parent";
            this.ChunkDisplayMenuItemVirtualParent.Click += new System.EventHandler(this.ChunkDisplayMenuItemVirtualParent_Click);
            // 
            // ExpandBTN
            // 
            this.ExpandBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExpandBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExpandBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExpandBTN.Image")));
            this.ExpandBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExpandBTN.Name = "ExpandBTN";
            this.ExpandBTN.Size = new System.Drawing.Size(28, 28);
            this.ExpandBTN.Text = "Expand all";
            this.ExpandBTN.Click += new System.EventHandler(this.ExpandBTN_Click);
            // 
            // CollapseBTN
            // 
            this.CollapseBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CollapseBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CollapseBTN.Image = ((System.Drawing.Image)(resources.GetObject("CollapseBTN.Image")));
            this.CollapseBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CollapseBTN.Name = "CollapseBTN";
            this.CollapseBTN.Size = new System.Drawing.Size(28, 28);
            this.CollapseBTN.Text = "Collapse all";
            this.CollapseBTN.ToolTipText = "Collapse all";
            this.CollapseBTN.Click += new System.EventHandler(this.CollapseBTN_Click);
            // 
            // toolStripMenuItemAddChunk
            // 
            this.toolStripMenuItemAddChunk.Name = "toolStripMenuItemAddChunk";
            this.toolStripMenuItemAddChunk.Size = new System.Drawing.Size(192, 30);
            this.toolStripMenuItemAddChunk.Text = "Add Chunk";
            // 
            // frmChunkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 547);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeListView);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(66, 79);
            this.Name = "frmChunkList";
            this.Text = "Chunk List";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TreeListView treeListView;
        private OLVColumn olvcolName;
        private OLVColumn olvcolPreview;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripSearchBox;
        private ToolStripButton toolStripClearButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem expandAllToolStripMenuItem;
        private ToolStripMenuItem expandAllChildrenToolStripMenuItem;
        private ToolStripMenuItem collapseAllToolStripMenuItem;
        private ToolStripMenuItem collapseAllChildrenToolStripMenuItem;
        private ToolStripMenuItem copyChunkToolStripMenuItem;
        private ToolStripMenuItem pasteChunkToolStripMenuItem;
        private ToolStripButton ExpandBTN;
        private ToolStripButton CollapseBTN;
        private ToolStripSplitButton ChunkDisplayMode;
        private ToolStripMenuItem ChunkDisplayMenuItemLinear;
        private ToolStripMenuItem ChunkDisplayMenuItemParent;
        private ToolStripMenuItem ChunkDisplayMenuItemVirtualParent;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem deleteChunktoolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemAddChunk;
    }
}