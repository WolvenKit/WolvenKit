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
            this.usmPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.videoConverter = new System.ComponentModel.BackgroundWorker();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // usmPlayer
            // 
            this.usmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usmPlayer.Enabled = true;
            this.usmPlayer.Location = new System.Drawing.Point(0, 0);
            this.usmPlayer.Name = "usmPlayer";
            this.usmPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("usmPlayer.OcxState")));
            this.usmPlayer.Size = new System.Drawing.Size(630, 287);
            this.usmPlayer.TabIndex = 0;
            this.usmPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.usmPlayer_PlayStateChange);
            this.usmPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.usmPlayer_MediaError);
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
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer usmPlayer;
        private BackgroundWorker videoConverter;
        private System.Windows.Forms.Label statusLabel;
    }
}