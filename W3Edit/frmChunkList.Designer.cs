using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace W3Edit
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
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.colIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colDisplay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.copyChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
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
            this.addChunkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addChunkToolStripMenuItem.Text = "Add Chunk";
            this.addChunkToolStripMenuItem.Click += new System.EventHandler(this.addChunkToolStripMenuItem_Click);
            // 
            // deleteChunkToolStripMenuItem
            // 
            this.deleteChunkToolStripMenuItem.Name = "deleteChunkToolStripMenuItem";
            this.deleteChunkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteChunkToolStripMenuItem.Text = "Delete Chunk";
            this.deleteChunkToolStripMenuItem.Click += new System.EventHandler(this.deleteChunkToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colIndex);
            this.listView.AllColumns.Add(this.colName);
            this.listView.AllColumns.Add(this.colDisplay);
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colName,
            this.colDisplay});
            this.listView.ContextMenuStrip = this.contextMenuStrip1;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(528, 253);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.AspectName = "ChunkIndex";
            this.colIndex.Text = "Index";
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 300;
            // 
            // colDisplay
            // 
            this.colDisplay.AspectName = "Preview";
            this.colDisplay.Text = "Preview";
            this.colDisplay.Width = 352;
            // 
            // copyChunkToolStripMenuItem
            // 
            this.copyChunkToolStripMenuItem.Name = "copyChunkToolStripMenuItem";
            this.copyChunkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // frmChunkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 253);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.listView);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmChunkList";
            this.Text = "Chunk List";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addChunkToolStripMenuItem;
        private ToolStripMenuItem deleteChunkToolStripMenuItem;
        private ObjectListView listView;
        private OLVColumn colIndex;
        private OLVColumn colName;
        private OLVColumn colDisplay;
        private ToolStripMenuItem copyChunkToolStripMenuItem;
        private ToolStripMenuItem pasteChunkToolStripMenuItem;
    }
}