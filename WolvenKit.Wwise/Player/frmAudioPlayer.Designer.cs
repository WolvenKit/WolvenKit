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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenConverter = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 536);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 1;
            // 
            // FilesListView
            // 
            this.FilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesListView.HideSelection = false;
            this.FilesListView.Location = new System.Drawing.Point(0, 0);
            this.FilesListView.MultiSelect = false;
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(233, 536);
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
            this.AudioPlayer.Size = new System.Drawing.Size(793, 370);
            this.AudioPlayer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnReplace);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOpenConverter);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 166);
            this.panel1.TabIndex = 6;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(347, 134);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(156, 26);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace file";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "4. Replace the file with the file converted in wwise (.cache directory)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "3. Open your file in wwise and set the project setting to high vorbis after that " +
    "right click the file and convert it\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "1. It is recommended to use this coverter to convert your music to wav:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Prepare your wav file for wwise:";
            // 
            // btnOpenConverter
            // 
            this.btnOpenConverter.Location = new System.Drawing.Point(370, 27);
            this.btnOpenConverter.Name = "btnOpenConverter";
            this.btnOpenConverter.Size = new System.Drawing.Size(92, 23);
            this.btnOpenConverter.TabIndex = 5;
            this.btnOpenConverter.Text = "Open converter";
            this.btnOpenConverter.UseVisualStyleBackColor = true;
            this.btnOpenConverter.Click += new System.EventHandler(this.btnOpenConverter_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(198, 57);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 28);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Prepare .wav for wwise";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // frmAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAudioPlayer";
            this.ShowIcon = false;
            this.Text = "Sound preview";
            this.Shown += new System.EventHandler(this.frmAudioPlayer_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NAudioDemo.AudioPlaybackDemo.AudioPlaybackPanel AudioPlayer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpenConverter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}