namespace W3Edit
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.txExecutablePath = new System.Windows.Forms.TextBox();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.btnBrowseExe = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txTextLanguage = new System.Windows.Forms.TextBox();
            this.lblVoiceLanguage = new System.Windows.Forms.Label();
            this.txVoiceLanguage = new System.Windows.Forms.TextBox();
            this.btBrowseWCC_Lite = new System.Windows.Forms.Button();
            this.lblWCC_Lite = new System.Windows.Forms.Label();
            this.txWCC_Lite = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbFlowDiagram = new System.Windows.Forms.CheckBox();
            this.themeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txExecutablePath
            // 
            this.txExecutablePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txExecutablePath.Location = new System.Drawing.Point(17, 34);
            this.txExecutablePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txExecutablePath.Name = "txExecutablePath";
            this.txExecutablePath.Size = new System.Drawing.Size(652, 22);
            this.txExecutablePath.TabIndex = 0;
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Location = new System.Drawing.Point(17, 11);
            this.lblExecutable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(176, 17);
            this.lblExecutable.TabIndex = 1;
            this.lblExecutable.Text = "Witcher 3 executable path:";
            // 
            // btnBrowseExe
            // 
            this.btnBrowseExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExe.Location = new System.Drawing.Point(679, 32);
            this.btnBrowseExe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseExe.Name = "btnBrowseExe";
            this.btnBrowseExe.Size = new System.Drawing.Size(100, 28);
            this.btnBrowseExe.TabIndex = 2;
            this.btnBrowseExe.Text = "Browse...";
            this.btnBrowseExe.UseVisualStyleBackColor = true;
            this.btnBrowseExe.Click += new System.EventHandler(this.btnBrowseExe_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(677, 214);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 28);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(16, 114);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(164, 17);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Text Language (e.g. EN)";
            // 
            // txTextLanguage
            // 
            this.txTextLanguage.Location = new System.Drawing.Point(16, 138);
            this.txTextLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txTextLanguage.Name = "txTextLanguage";
            this.txTextLanguage.Size = new System.Drawing.Size(179, 22);
            this.txTextLanguage.TabIndex = 4;
            // 
            // lblVoiceLanguage
            // 
            this.lblVoiceLanguage.AutoSize = true;
            this.lblVoiceLanguage.Location = new System.Drawing.Point(204, 114);
            this.lblVoiceLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoiceLanguage.Name = "lblVoiceLanguage";
            this.lblVoiceLanguage.Size = new System.Drawing.Size(185, 17);
            this.lblVoiceLanguage.TabIndex = 7;
            this.lblVoiceLanguage.Text = "Speech Language (e.g. EN)";
            // 
            // txVoiceLanguage
            // 
            this.txVoiceLanguage.Location = new System.Drawing.Point(204, 138);
            this.txVoiceLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txVoiceLanguage.Name = "txVoiceLanguage";
            this.txVoiceLanguage.Size = new System.Drawing.Size(179, 22);
            this.txVoiceLanguage.TabIndex = 6;
            // 
            // btBrowseWCC_Lite
            // 
            this.btBrowseWCC_Lite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowseWCC_Lite.Location = new System.Drawing.Point(677, 82);
            this.btBrowseWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBrowseWCC_Lite.Name = "btBrowseWCC_Lite";
            this.btBrowseWCC_Lite.Size = new System.Drawing.Size(100, 28);
            this.btBrowseWCC_Lite.TabIndex = 10;
            this.btBrowseWCC_Lite.Text = "Browse...";
            this.btBrowseWCC_Lite.UseVisualStyleBackColor = true;
            this.btBrowseWCC_Lite.Click += new System.EventHandler(this.btBrowseWCC_Lite_Click);
            // 
            // lblWCC_Lite
            // 
            this.lblWCC_Lite.AutoSize = true;
            this.lblWCC_Lite.Location = new System.Drawing.Point(16, 63);
            this.lblWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWCC_Lite.Name = "lblWCC_Lite";
            this.lblWCC_Lite.Size = new System.Drawing.Size(133, 17);
            this.lblWCC_Lite.TabIndex = 9;
            this.lblWCC_Lite.Text = "WCC_Lite.exe Path:";
            // 
            // txWCC_Lite
            // 
            this.txWCC_Lite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txWCC_Lite.Location = new System.Drawing.Point(16, 82);
            this.txWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txWCC_Lite.Name = "txWCC_Lite";
            this.txWCC_Lite.Size = new System.Drawing.Size(652, 22);
            this.txWCC_Lite.TabIndex = 8;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(16, 212);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 28);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbFlowDiagram
            // 
            this.cbFlowDiagram.AutoSize = true;
            this.cbFlowDiagram.Location = new System.Drawing.Point(16, 171);
            this.cbFlowDiagram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFlowDiagram.Name = "cbFlowDiagram";
            this.cbFlowDiagram.Size = new System.Drawing.Size(289, 21);
            this.cbFlowDiagram.TabIndex = 12;
            this.cbFlowDiagram.Text = "Show flow diagram tab (work in progress)";
            this.cbFlowDiagram.UseVisualStyleBackColor = true;
            this.cbFlowDiagram.CheckedChanged += new System.EventHandler(this.cbFlowDiagram_CheckedChanged);
            // 
            // themeBox
            // 
            this.themeBox.FormattingEnabled = true;
            this.themeBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.themeBox.Location = new System.Drawing.Point(399, 138);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(156, 24);
            this.themeBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Theme:";
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(795, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.cbFlowDiagram);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btBrowseWCC_Lite);
            this.Controls.Add(this.lblWCC_Lite);
            this.Controls.Add(this.txWCC_Lite);
            this.Controls.Add(this.lblVoiceLanguage);
            this.Controls.Add(this.txVoiceLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txTextLanguage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btnBrowseExe);
            this.Controls.Add(this.lblExecutable);
            this.Controls.Add(this.txExecutablePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txExecutablePath;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Button btnBrowseExe;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox txTextLanguage;
        private System.Windows.Forms.Label lblVoiceLanguage;
        private System.Windows.Forms.TextBox txVoiceLanguage;
        private System.Windows.Forms.Button btBrowseWCC_Lite;
        private System.Windows.Forms.Label lblWCC_Lite;
        private System.Windows.Forms.TextBox txWCC_Lite;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.CheckBox cbFlowDiagram;
        private System.Windows.Forms.ComboBox themeBox;
        private System.Windows.Forms.Label label2;
    }
}