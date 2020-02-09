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
            this.resetBTN = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.MaskedTextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.limitCB = new System.Windows.Forms.CheckBox();
            this.limitTB = new System.Windows.Forms.MaskedTextBox();
            this.treeListView = new BrightIdeasSoftware.TreeListView();
            this.olvcolName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvcolPreview = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChunkToolStripMenuItem,
            this.deleteChunkToolStripMenuItem,
            this.copyChunkToolStripMenuItem,
            this.pasteChunkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 92);
            // 
            // addChunkToolStripMenuItem
            // 
            this.addChunkToolStripMenuItem.Name = "addChunkToolStripMenuItem";
            this.addChunkToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addChunkToolStripMenuItem.Text = "Add Chunk";
            this.addChunkToolStripMenuItem.Click += new System.EventHandler(this.addChunkToolStripMenuItem_Click);
            // 
            // deleteChunkToolStripMenuItem
            // 
            this.deleteChunkToolStripMenuItem.Name = "deleteChunkToolStripMenuItem";
            this.deleteChunkToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteChunkToolStripMenuItem.Text = "Delete Chunk";
            this.deleteChunkToolStripMenuItem.Click += new System.EventHandler(this.deleteChunkToolStripMenuItem_Click);
            // 
            // copyChunkToolStripMenuItem
            // 
            this.copyChunkToolStripMenuItem.Name = "copyChunkToolStripMenuItem";
            this.copyChunkToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.copyChunkToolStripMenuItem.Text = "Copy Chunk";
            this.copyChunkToolStripMenuItem.Click += new System.EventHandler(this.copyChunkToolStripMenuItem_Click);
            // 
            // pasteChunkToolStripMenuItem
            // 
            this.pasteChunkToolStripMenuItem.Enabled = false;
            this.pasteChunkToolStripMenuItem.Name = "pasteChunkToolStripMenuItem";
            this.pasteChunkToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pasteChunkToolStripMenuItem.Text = "Paste Chunk";
            this.pasteChunkToolStripMenuItem.Click += new System.EventHandler(this.pasteChunkToolStripMenuItem_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBTN.BackgroundImage = global::WolvenKit.Properties.Resources.ExitIcon;
            this.resetBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetBTN.Location = new System.Drawing.Point(817, 7);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(25, 23);
            this.resetBTN.TabIndex = 6;
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.Location = new System.Drawing.Point(545, 8);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(185, 20);
            this.searchTB.TabIndex = 7;
            this.searchTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyUp);
            // 
            // searchBTN
            // 
            this.searchBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBTN.Location = new System.Drawing.Point(736, 7);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 9;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // limitCB
            // 
            this.limitCB.AutoSize = true;
            this.limitCB.Location = new System.Drawing.Point(12, 10);
            this.limitCB.Name = "limitCB";
            this.limitCB.Size = new System.Drawing.Size(80, 17);
            this.limitCB.TabIndex = 10;
            this.limitCB.Text = "Limit results";
            this.limitCB.UseVisualStyleBackColor = true;
            this.limitCB.CheckStateChanged += new System.EventHandler(this.limitCB_CheckStateChanged);
            // 
            // limitTB
            // 
            this.limitTB.Location = new System.Drawing.Point(99, 8);
            this.limitTB.Name = "limitTB";
            this.limitTB.Size = new System.Drawing.Size(100, 20);
            this.limitTB.TabIndex = 11;
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
            this.treeListView.GridLines = true;
            this.treeListView.HideSelection = false;
            this.treeListView.Location = new System.Drawing.Point(3, 36);
            this.treeListView.Name = "treeListView";
            this.treeListView.ShowGroups = false;
            this.treeListView.Size = new System.Drawing.Size(855, 681);
            this.treeListView.TabIndex = 0;
            this.treeListView.UseCompatibleStateImageBehavior = false;
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
            this.olvcolPreview.Text = "Preview";
            this.olvcolPreview.Width = 300;
            // 
            // frmChunkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 719);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.treeListView);
            this.Controls.Add(this.limitTB);
            this.Controls.Add(this.limitCB);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.resetBTN);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmChunkList";
            this.Text = "Chunk List";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addChunkToolStripMenuItem;
        private ToolStripMenuItem deleteChunkToolStripMenuItem;
        private ToolStripMenuItem copyChunkToolStripMenuItem;
        private ToolStripMenuItem pasteChunkToolStripMenuItem;
        private Button resetBTN;
        private MaskedTextBox searchTB;
        private Button searchBTN;
        private CheckBox limitCB;
        private MaskedTextBox limitTB;
        private TreeListView treeListView;
        private OLVColumn olvcolName;
        private OLVColumn olvcolPreview;
    }
}