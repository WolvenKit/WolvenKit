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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGit = new System.Windows.Forms.LinkLabel();
            this.labelVersionJato = new System.Windows.Forms.Label();
            this.labelLoadingJato = new System.Windows.Forms.Label();
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
            this.labelVersion.Location = new System.Drawing.Point(1001, 698);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(197, 29);
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
            this.labelLoading.Location = new System.Drawing.Point(476, 464);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(118, 29);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "Loading...";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(735, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(476, 108);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "WolvenKit";
            this.labelTitle.Visible = false;
            // 
            // labelGit
            // 
            this.labelGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGit.AutoSize = true;
            this.labelGit.BackColor = System.Drawing.Color.Transparent;
            this.labelGit.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelGit.LinkColor = System.Drawing.Color.DarkGray;
            this.labelGit.Location = new System.Drawing.Point(852, 198);
            this.labelGit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGit.Name = "labelGit";
            this.labelGit.Size = new System.Drawing.Size(334, 24);
            this.labelGit.TabIndex = 4;
            this.labelGit.TabStop = true;
            this.labelGit.Text = "https://github.com/Traderain/Wolven-kit";
            this.labelGit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGit.Visible = false;
            this.labelGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelVersionJato
            // 
            this.labelVersionJato.AutoSize = true;
            this.labelVersionJato.BackColor = System.Drawing.Color.Transparent;
            this.labelVersionJato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersionJato.ForeColor = System.Drawing.Color.DarkGray;
            this.labelVersionJato.Location = new System.Drawing.Point(949, 165);
            this.labelVersionJato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersionJato.Name = "labelVersionJato";
            this.labelVersionJato.Size = new System.Drawing.Size(237, 33);
            this.labelVersionJato.TabIndex = 5;
            this.labelVersionJato.Text = "Version {version}";
            this.labelVersionJato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVersionJato.Visible = false;
            // 
            // labelLoadingJato
            // 
            this.labelLoadingJato.AutoSize = true;
            this.labelLoadingJato.BackColor = System.Drawing.Color.Transparent;
            this.labelLoadingJato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingJato.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLoadingJato.Location = new System.Drawing.Point(1044, 117);
            this.labelLoadingJato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoadingJato.Name = "labelLoadingJato";
            this.labelLoadingJato.Size = new System.Drawing.Size(142, 33);
            this.labelLoadingJato.TabIndex = 6;
            this.labelLoadingJato.Text = "Loading...";
            this.labelLoadingJato.Visible = false;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WolvenKit.Properties.Resources.wkit_splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1224, 756);
            this.Controls.Add(this.labelLoadingJato);
            this.Controls.Add(this.labelVersionJato);
            this.Controls.Add(this.labelGit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.labelVersion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel labelGit;
        private System.Windows.Forms.Label labelVersionJato;
        private System.Windows.Forms.Label labelLoadingJato;
    }
}