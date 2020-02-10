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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FilesListView = new System.Windows.Forms.ListView();
            this.AudioPlayer = new NAudioDemo.AudioPlaybackDemo.AudioPlaybackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FilesListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AudioPlayer);
            this.splitContainer1.Size = new System.Drawing.Size(985, 450);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
            // 
            // FilesListView
            // 
            this.FilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListView.HideSelection = false;
            this.FilesListView.Location = new System.Drawing.Point(0, 0);
            this.FilesListView.MultiSelect = false;
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(225, 450);
            this.FilesListView.TabIndex = 0;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.View = System.Windows.Forms.View.List;
            this.FilesListView.DoubleClick += new System.EventHandler(this.FilesListView_DoubleClick);
            // 
            // AudioPlayer
            // 
            this.AudioPlayer.BackColor = System.Drawing.SystemColors.Desktop;
            this.AudioPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AudioPlayer.Location = new System.Drawing.Point(0, 0);
            this.AudioPlayer.Name = "AudioPlayer";
            this.AudioPlayer.Size = new System.Drawing.Size(756, 450);
            this.AudioPlayer.TabIndex = 0;
            // 
            // frmAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAudioPlayer";
            this.ShowIcon = false;
            this.Text = "Sound preview";
            this.Shown += new System.EventHandler(this.frmAudioPlayer_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NAudioDemo.AudioPlaybackDemo.AudioPlaybackPanel AudioPlayer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView FilesListView;
    }
}