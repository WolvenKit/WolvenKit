using System.ComponentModel;

namespace W3Edit
{
    partial class frmUsmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsmPlayer));
            this.videoConverter = new System.ComponentModel.BackgroundWorker();
            this.statusLabel = new System.Windows.Forms.Label();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.usmPlayer = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoConverter
            // 
            this.videoConverter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.videoConverter_DoWork);
            this.videoConverter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.videoConverter_RunWorkerCompleted);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(168, 25);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Converting file...";
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(0, 0);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // usmPlayer
            // 
            this.usmPlayer.BackColor = System.Drawing.Color.Black;
            this.usmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usmPlayer.Location = new System.Drawing.Point(0, 0);
            this.usmPlayer.Name = "usmPlayer";
            this.usmPlayer.Size = new System.Drawing.Size(630, 287);
            this.usmPlayer.Spu = -1;
            this.usmPlayer.TabIndex = 2;
            this.usmPlayer.Text = "USM Player";
            this.usmPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("usmPlayer.VlcLibDirectory")));
            this.usmPlayer.VlcMediaplayerOptions = null;
            // 
            // frmUsmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 287);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.usmPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmUsmPlayer";
            this.ShowIcon = false;
            this.Text = "Video preview";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BackgroundWorker videoConverter;
        private System.Windows.Forms.Label statusLabel;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Vlc.DotNet.Forms.VlcControl usmPlayer;
    }
}