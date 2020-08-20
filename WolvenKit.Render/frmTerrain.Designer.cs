namespace WolvenKit.Render
{
    partial class frmTerrain
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
            this.irrlichtPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // irrlichtPanel
            // 
            this.irrlichtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrlichtPanel.Location = new System.Drawing.Point(0, 0);
            this.irrlichtPanel.Margin = new System.Windows.Forms.Padding(2);
            this.irrlichtPanel.Name = "irrlichtPanel";
            this.irrlichtPanel.Size = new System.Drawing.Size(583, 527);
            this.irrlichtPanel.TabIndex = 2;
            this.irrlichtPanel.Click += new System.EventHandler(this.irrlichtPanel_Click);
            this.irrlichtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseMove);
            // 
            // frmTerrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 527);
            this.Controls.Add(this.irrlichtPanel);
            this.Name = "frmTerrain";
            this.ShowIcon = false;
            this.Text = "Terrain renderer";
            this.Load += new System.EventHandler(this.frmTerrain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTerrain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel irrlichtPanel;
    }
}