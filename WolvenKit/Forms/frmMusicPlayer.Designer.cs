namespace WolvenKit.Forms
{
    partial class frmMusicPlayer
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
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.progressLog1 = new NAudio.Utils.ProgressLog();
            this.RestartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumeMeter1.Location = new System.Drawing.Point(443, 420);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(180, 23);
            this.volumeMeter1.TabIndex = 0;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // waveViewer1
            // 
            this.waveViewer1.Location = new System.Drawing.Point(12, 12);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(611, 176);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 1;
            this.waveViewer1.WaveStream = null;
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(12, 427);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider1.TabIndex = 2;
            // 
            // progressLog1
            // 
            this.progressLog1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressLog1.Location = new System.Drawing.Point(12, 256);
            this.progressLog1.Name = "progressLog1";
            this.progressLog1.Padding = new System.Windows.Forms.Padding(1);
            this.progressLog1.Size = new System.Drawing.Size(611, 131);
            this.progressLog1.TabIndex = 3;
            // 
            // RestartBTN
            // 
            this.RestartBTN.Location = new System.Drawing.Point(178, 427);
            this.RestartBTN.Name = "RestartBTN";
            this.RestartBTN.Size = new System.Drawing.Size(67, 23);
            this.RestartBTN.TabIndex = 4;
            this.RestartBTN.Text = "Restart";
            this.RestartBTN.UseVisualStyleBackColor = true;
            this.RestartBTN.Click += new System.EventHandler(this.RestartBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Location = new System.Drawing.Point(291, 427);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(67, 23);
            this.StopBTN.TabIndex = 5;
            this.StopBTN.Text = "STOP";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(635, 462);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.RestartBTN);
            this.Controls.Add(this.progressLog1);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.volumeMeter1);
            this.Name = "frmMusicPlayer";
            this.Text = "frmMusicPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.WaveViewer waveViewer1;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private NAudio.Utils.ProgressLog progressLog1;
        private System.Windows.Forms.Button RestartBTN;
        private System.Windows.Forms.Button StopBTN;
    }
}