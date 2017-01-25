namespace W3Edit
{
    partial class frmChunkFlowDiagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // copyDisplayTextToolStripMenuItem
            // 
            this.copyDisplayTextToolStripMenuItem.Name = "copyDisplayTextToolStripMenuItem";
            this.copyDisplayTextToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.copyDisplayTextToolStripMenuItem.Text = "Copy Display Text";
            this.copyDisplayTextToolStripMenuItem.Click += new System.EventHandler(this.copyDisplayTextToolStripMenuItem_Click);
            // 
            // frmChunkFlowDiagram
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(715, 446);
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
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.frmChunkFlowDiagram_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmChunkFlowView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChunkFlowDiagram_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmChunkFlowDiagram_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDisplayTextToolStripMenuItem;
    }
}