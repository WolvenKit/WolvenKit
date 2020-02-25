using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace WolvenKit
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.olvcolName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcolPreview = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.showTreetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChunkToolStripMenuItem,
            this.deleteChunkToolStripMenuItem,
            this.copyChunkToolStripMenuItem,
            this.pasteChunkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 132);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // addChunkToolStripMenuItem
            // 
            this.addChunkToolStripMenuItem.Name = "addChunkToolStripMenuItem";
            this.addChunkToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.addChunkToolStripMenuItem.Text = "Add Chunk";
            this.addChunkToolStripMenuItem.Click += new System.EventHandler(this.addChunkToolStripMenuItem_Click);
            // 
            // deleteChunkToolStripMenuItem
            // 
            this.deleteChunkToolStripMenuItem.Name = "deleteChunkToolStripMenuItem";
            this.deleteChunkToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.deleteChunkToolStripMenuItem.Text = "Delete Chunk";
            this.deleteChunkToolStripMenuItem.Click += new System.EventHandler(this.deleteChunkToolStripMenuItem_Click);
            // 
            // copyChunkToolStripMenuItem
            // 
            this.copyChunkToolStripMenuItem.Name = "copyChunkToolStripMenuItem";
            this.copyChunkToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.copyChunkToolStripMenuItem.Text = "Copy Chunk";
            this.copyChunkToolStripMenuItem.Click += new System.EventHandler(this.copyChunkToolStripMenuItem_Click);
            // 
            // pasteChunkToolStripMenuItem
            // 
            this.pasteChunkToolStripMenuItem.Name = "pasteChunkToolStripMenuItem";
            this.pasteChunkToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.pasteChunkToolStripMenuItem.Text = "Paste Chunk";
            this.pasteChunkToolStripMenuItem.Click += new System.EventHandler(this.pasteChunkToolStripMenuItem_Click);
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
            this.treeListView.Location = new System.Drawing.Point(0, 41);
            this.treeListView.Name = "treeListView";
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(861, 678);
            this.treeListView.TabIndex = 0;
            this.treeListView.UseCompatibleStateImageBehavior = false;
            this.treeListView.UseFiltering = true;
            this.treeListView.View = System.Windows.Forms.View.Details;
            this.treeListView.VirtualMode = true;
            this.treeListView.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.listView_ItemsChanged);
            // 
            // olvcolName
            // 
            this.olvcolName.AspectName = "Name";
            this.olvcolName.Text = "Name";
            this.olvcolName.Width = 300;
            // 
            // olvcolPreview
            // 
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
            this.showTreetoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 38);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 28);
            this.toolStripLabel1.Text = "Filter: ";
            // 
            // toolStripSearchBox
            // 
            this.toolStripSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSearchBox.Name = "toolStripSearchBox";
            this.toolStripSearchBox.Size = new System.Drawing.Size(200, 33);
            this.toolStripSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyUp);
            // 
            // toolStripClearButton
            // 
            this.toolStripClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClearButton.Image = global::WolvenKit.Properties.Resources.ExitIcon;
            this.toolStripClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearButton.Name = "toolStripClearButton";
            this.toolStripClearButton.Size = new System.Drawing.Size(34, 28);
            this.toolStripClearButton.Text = "Clear";
            this.toolStripClearButton.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // showTreetoolStripButton
            // 
            this.showTreetoolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.showTreetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showTreetoolStripButton.Image = global::WolvenKit.Properties.Resources.LayerGroupVisibled;
            this.showTreetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showTreetoolStripButton.Name = "showTreetoolStripButton";
            this.showTreetoolStripButton.Size = new System.Drawing.Size(34, 28);
            this.showTreetoolStripButton.Text = "Show/Hide Tree";
            this.showTreetoolStripButton.Click += new System.EventHandler(this.showTreetoolStripButton_Click);
            // 
            // frmChunkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 719);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeListView);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
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
        private ToolStripMenuItem addChunkToolStripMenuItem;
        private ToolStripMenuItem deleteChunkToolStripMenuItem;
        private ToolStripMenuItem copyChunkToolStripMenuItem;
        private ToolStripMenuItem pasteChunkToolStripMenuItem;
        private TreeListView treeListView;
        private OLVColumn olvcolName;
        private OLVColumn olvcolPreview;
        private ToolStrip toolStrip1;
        private ToolStripTextBox toolStripSearchBox;
        private ToolStripButton toolStripClearButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton showTreetoolStripButton;
    }
}