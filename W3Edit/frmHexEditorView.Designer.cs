using System.ComponentModel;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace WolvenKit
{
    partial class frmHexEditorView
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
            this.treeView = new BrightIdeasSoftware.TreeListView();
            this.colMethod = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEndAt = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView = new BrightIdeasSoftware.VirtualObjectListView();
            this.colPos = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.colPosition = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllColumns.Add(this.colMethod);
            this.treeView.AllColumns.Add(this.colName);
            this.treeView.AllColumns.Add(this.colValue);
            this.treeView.AllColumns.Add(this.colHex);
            this.treeView.AllColumns.Add(this.colType);
            this.treeView.AllColumns.Add(this.colEndAt);
            this.treeView.AlternateRowBackColor = System.Drawing.Color.LightCyan;
            this.treeView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.treeView.CellEditUseWholeCell = false;
            this.treeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMethod,
            this.colName,
            this.colValue,
            this.colHex,
            this.colType,
            this.colEndAt});
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView.Name = "treeView";
            this.treeView.ShowGroups = false;
            this.treeView.Size = new System.Drawing.Size(917, 209);
            this.treeView.TabIndex = 2;
            this.treeView.UseAlternatingBackColors = true;
            this.treeView.UseCompatibleStateImageBehavior = false;
            this.treeView.View = System.Windows.Forms.View.Details;
            this.treeView.VirtualMode = true;
            // 
            // colMethod
            // 
            this.colMethod.AspectName = "Method";
            this.colMethod.Text = "Method";
            this.colMethod.Width = 116;
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colValue
            // 
            this.colValue.AspectName = "Value";
            this.colValue.Text = "Value";
            this.colValue.Width = 200;
            // 
            // colHex
            // 
            this.colHex.AspectName = "HexValue";
            this.colHex.Text = "Hex";
            // 
            // colType
            // 
            this.colType.AspectName = "Type";
            this.colType.Text = "Type";
            this.colType.Width = 100;
            // 
            // colEndAt
            // 
            this.colEndAt.AspectName = "EndPosition";
            this.colEndAt.Text = "End Pos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(917, 521);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colPos);
            this.listView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listView.CellEditUseWholeCell = false;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPos});
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(917, 282);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listView_CellClick);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            // 
            // colPos
            // 
            this.colPos.AspectName = "Position";
            this.colPos.Groupable = false;
            this.colPos.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPos.IsEditable = false;
            this.colPos.Searchable = false;
            this.colPos.Sortable = false;
            this.colPos.Text = "Position";
            this.colPos.Width = 96;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spacer,
            this.lblPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 209);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(917, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "status";
            // 
            // spacer
            // 
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(866, 20);
            this.spacer.Spring = true;
            // 
            // lblPosition
            // 
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(31, 20);
            this.lblPosition.Text = "Pos";
            // 
            // colPosition
            // 
            this.colPosition.AspectName = "Position";
            this.colPosition.DisplayIndex = 0;
            this.colPosition.Text = "Position";
            // 
            // frmHexEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 521);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHexEditorView";
            this.Text = "Hex Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeListView treeView;
        private OLVColumn colName;
        private OLVColumn colValue;
        private OLVColumn colType;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spacer;
        private ToolStripStatusLabel lblPosition;
        private OLVColumn colEndAt;
        private OLVColumn colHex;
        private OLVColumn colMethod;
        private VirtualObjectListView listView;
        private OLVColumn colPosition;
        private OLVColumn colPos;

    }
}