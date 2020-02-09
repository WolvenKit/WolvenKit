namespace WolvenKit.Wwise.Player
{
    partial class frmAudioPlayer
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
            this.audioPlaybackPanel1 = new NAudioDemo.AudioPlaybackDemo.AudioPlaybackPanel();
            this.SuspendLayout();
            // 
            // audioPlaybackPanel1
            // 
            this.audioPlaybackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioPlaybackPanel1.Location = new System.Drawing.Point(0, 0);
            this.audioPlaybackPanel1.Name = "audioPlaybackPanel1";
            this.audioPlaybackPanel1.Size = new System.Drawing.Size(800, 450);
            this.audioPlaybackPanel1.TabIndex = 0;
            // 
            // frmAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.audioPlaybackPanel1);
            this.Name = "frmAudioPlayer";
            this.ShowIcon = false;
            this.Text = "Sound preview";
            this.ResumeLayout(false);

        }

        #endregion

        private NAudioDemo.AudioPlaybackDemo.AudioPlaybackPanel audioPlaybackPanel1;
    }
}