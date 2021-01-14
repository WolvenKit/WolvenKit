namespace WolvenKit.Forms
{
    partial class frmBulkEditor
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnRun = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(0, 28);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(416, 368);
            this.propertyGrid.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRun});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(416, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbtnRun
            // 
            this.tsbtnRun.Image = global::WolvenKit.Properties.Resources.Run_16x;
            this.tsbtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRun.Name = "tsbtnRun";
            this.tsbtnRun.Size = new System.Drawing.Size(48, 22);
            this.tsbtnRun.Text = "Run";
            this.tsbtnRun.Click += new System.EventHandler(this.tsbtnRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 47);
            this.progressBar1.TabIndex = 7;
            // 
            // frmBulkEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 449);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmBulkEditor";
            this.Text = "Bulk Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtnRun;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}