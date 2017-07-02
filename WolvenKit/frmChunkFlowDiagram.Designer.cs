using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmChunkFlowDiagram
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
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDisplayTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.copyDisplayTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // copyDisplayTextToolStripMenuItem
            // 
            this.copyDisplayTextToolStripMenuItem.Name = "copyDisplayTextToolStripMenuItem";
            this.copyDisplayTextToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.copyDisplayTextToolStripMenuItem.Text = "Copy Display Text";
            this.copyDisplayTextToolStripMenuItem.Click += new System.EventHandler(this.copyDisplayTextToolStripMenuItem_Click);
            // 
            // frmChunkFlowDiagram
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = false;
            this.ClientSize = new System.Drawing.Size(795, 460);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChunkFlowDiagram";
            this.ShowIcon = false;
            this.Text = "Flow Diagram";
            this.Load += new System.EventHandler(this.frmChunkFlowDiagram_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmChunkFlowView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChunkFlowDiagram_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_Scroll);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem copyDisplayTextToolStripMenuItem;
    }
}