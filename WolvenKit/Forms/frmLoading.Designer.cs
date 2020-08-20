namespace WolvenKit.Forms
{
    partial class frmLoading
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
            this.VersionLbl = new System.Windows.Forms.Label();
            this.LoadLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.BackColor = System.Drawing.Color.Transparent;
            this.VersionLbl.Font = new System.Drawing.Font("PF Transport Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VersionLbl.Location = new System.Drawing.Point(28, 275);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(140, 22);
            this.VersionLbl.TabIndex = 0;
            this.VersionLbl.Text = "Version {version}";
            // 
            // LoadLbl
            // 
            this.LoadLbl.AutoSize = true;
            this.LoadLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoadLbl.Font = new System.Drawing.Font("PF Transport Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadLbl.Location = new System.Drawing.Point(29, 297);
            this.LoadLbl.Name = "LoadLbl";
            this.LoadLbl.Size = new System.Drawing.Size(71, 18);
            this.LoadLbl.TabIndex = 1;
            this.LoadLbl.Text = "Loading...";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.AutoSize = true;
            this.copyrightLbl.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLbl.Font = new System.Drawing.Font("PF Transport Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyrightLbl.Location = new System.Drawing.Point(29, 337);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(79, 18);
            this.copyrightLbl.TabIndex = 2;
            this.copyrightLbl.Text = "{copyright}";
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WolvenKit.Properties.Resources.loading_black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(962, 574);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.LoadLbl);
            this.Controls.Add(this.VersionLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.Text = "frmLoading";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.Shown += new System.EventHandler(this.frmLoading_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.Label LoadLbl;
        private System.Windows.Forms.Label copyrightLbl;
    }
}