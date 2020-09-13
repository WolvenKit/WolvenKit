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
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelGit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVersion.Location = new System.Drawing.Point(667, 454);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(127, 20);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version {version}";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoading.Location = new System.Drawing.Point(317, 302);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(78, 20);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "Loading...";
            // 
            // labelGit
            // 
            this.labelGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGit.AutoSize = true;
            this.labelGit.BackColor = System.Drawing.Color.Transparent;
            this.labelGit.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelGit.LinkColor = System.Drawing.Color.DarkGray;
            this.labelGit.Location = new System.Drawing.Point(24, 457);
            this.labelGit.Name = "labelGit";
            this.labelGit.Size = new System.Drawing.Size(236, 17);
            this.labelGit.TabIndex = 4;
            this.labelGit.TabStop = true;
            this.labelGit.Text = "https://github.com/Traderain/Wolven-kit";
            this.labelGit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WolvenKit.Properties.Resources.wkit_splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.labelGit);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.labelVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.Text = "Loading";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.Shown += new System.EventHandler(this.frmLoading_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.LinkLabel labelGit;
    }
}