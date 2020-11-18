using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit.Forms
{
    partial class frmSettings
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
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.buttonBrowseGame = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblVoiceLanguage = new System.Windows.Forms.Label();
            this.buttonBrowseWcc = new System.Windows.Forms.Button();
            this.lblWCC_Lite = new System.Windows.Forms.Label();
            this.textBoxWcc = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.txTextLanguage = new System.Windows.Forms.TextBox();
            this.txVoiceLanguage = new System.Windows.Forms.TextBox();
            this.exeSearcherSlave = new System.ComponentModel.BackgroundWorker();
            this.W3exeTickLBL = new System.Windows.Forms.Label();
            this.WCCexeTickLBL = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.checkBoxDisableWelcomeForm = new System.Windows.Forms.CheckBox();
            this.lblDepot = new System.Windows.Forms.Label();
            this.textBoxDepot = new System.Windows.Forms.TextBox();
            this.labelCustomModDir = new System.Windows.Forms.Label();
            this.textBoxModDir = new System.Windows.Forms.TextBox();
            this.labelCustomDlcDir = new System.Windows.Forms.Label();
            this.textBoxDlcDir = new System.Windows.Forms.TextBox();
            this.buttonBrowseModDir = new System.Windows.Forms.Button();
            this.buttonBrowseDlcDir = new System.Windows.Forms.Button();
            this.checkBoxAutoInstall = new System.Windows.Forms.CheckBox();
            this.labelUpdateChannel = new System.Windows.Forms.Label();
            this.comboBoxUpdateChannel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxGame
            // 
            this.textBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGame.Location = new System.Drawing.Point(35, 27);
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.Size = new System.Drawing.Size(442, 20);
            this.textBoxGame.TabIndex = 0;
            this.textBoxGame.TextChanged += new System.EventHandler(this.txExecutablePath_TextChanged);
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Location = new System.Drawing.Point(35, 9);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(135, 13);
            this.lblExecutable.TabIndex = 1;
            this.lblExecutable.Text = "Witcher 3 executable path:";
            // 
            // buttonBrowseGame
            // 
            this.buttonBrowseGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseGame.Location = new System.Drawing.Point(483, 25);
            this.buttonBrowseGame.Name = "buttonBrowseGame";
            this.buttonBrowseGame.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseGame.TabIndex = 2;
            this.buttonBrowseGame.Text = "Browse...";
            this.buttonBrowseGame.UseVisualStyleBackColor = true;
            this.buttonBrowseGame.Click += new System.EventHandler(this.btnBrowseExe_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(483, 409);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Enabled = false;
            this.lblLanguage.Location = new System.Drawing.Point(35, 277);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(124, 13);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Text Language (e.g. EN)";
            // 
            // lblVoiceLanguage
            // 
            this.lblVoiceLanguage.AutoSize = true;
            this.lblVoiceLanguage.Enabled = false;
            this.lblVoiceLanguage.Location = new System.Drawing.Point(35, 303);
            this.lblVoiceLanguage.Name = "lblVoiceLanguage";
            this.lblVoiceLanguage.Size = new System.Drawing.Size(140, 13);
            this.lblVoiceLanguage.TabIndex = 7;
            this.lblVoiceLanguage.Text = "Speech Language (e.g. EN)";
            // 
            // buttonBrowseWcc
            // 
            this.buttonBrowseWcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseWcc.Location = new System.Drawing.Point(483, 65);
            this.buttonBrowseWcc.Name = "buttonBrowseWcc";
            this.buttonBrowseWcc.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseWcc.TabIndex = 10;
            this.buttonBrowseWcc.Text = "Browse...";
            this.buttonBrowseWcc.UseVisualStyleBackColor = true;
            this.buttonBrowseWcc.Click += new System.EventHandler(this.btBrowseWCC_Lite_Click);
            // 
            // lblWCC_Lite
            // 
            this.lblWCC_Lite.AutoSize = true;
            this.lblWCC_Lite.Location = new System.Drawing.Point(35, 50);
            this.lblWCC_Lite.Name = "lblWCC_Lite";
            this.lblWCC_Lite.Size = new System.Drawing.Size(102, 13);
            this.lblWCC_Lite.TabIndex = 9;
            this.lblWCC_Lite.Text = "WCC_Lite.exe path:";
            // 
            // textBoxWcc
            // 
            this.textBoxWcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWcc.Location = new System.Drawing.Point(35, 67);
            this.textBoxWcc.Name = "textBoxWcc";
            this.textBoxWcc.Size = new System.Drawing.Size(441, 20);
            this.textBoxWcc.TabIndex = 8;
            this.textBoxWcc.TextChanged += new System.EventHandler(this.txWCC_Lite_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(402, 409);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // txTextLanguage
            // 
            this.txTextLanguage.Enabled = false;
            this.txTextLanguage.Location = new System.Drawing.Point(186, 270);
            this.txTextLanguage.Name = "txTextLanguage";
            this.txTextLanguage.Size = new System.Drawing.Size(135, 20);
            this.txTextLanguage.TabIndex = 4;
            // 
            // txVoiceLanguage
            // 
            this.txVoiceLanguage.Enabled = false;
            this.txVoiceLanguage.Location = new System.Drawing.Point(186, 300);
            this.txVoiceLanguage.Name = "txVoiceLanguage";
            this.txVoiceLanguage.Size = new System.Drawing.Size(135, 20);
            this.txVoiceLanguage.TabIndex = 6;
            // 
            // exeSearcherSlave
            // 
            this.exeSearcherSlave.WorkerReportsProgress = true;
            this.exeSearcherSlave.WorkerSupportsCancellation = true;
            this.exeSearcherSlave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.exeSearcherSlave_DoWork);
            this.exeSearcherSlave.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.exeSearcherSlave_ProgressChanged);
            this.exeSearcherSlave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.exeSearcherSlave_RunWorkerCompleted);
            // 
            // W3exeTickLBL
            // 
            this.W3exeTickLBL.AutoSize = true;
            this.W3exeTickLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W3exeTickLBL.ForeColor = System.Drawing.Color.Red;
            this.W3exeTickLBL.Location = new System.Drawing.Point(14, 30);
            this.W3exeTickLBL.Name = "W3exeTickLBL";
            this.W3exeTickLBL.Size = new System.Drawing.Size(15, 13);
            this.W3exeTickLBL.TabIndex = 13;
            this.W3exeTickLBL.Text = "X";
            // 
            // WCCexeTickLBL
            // 
            this.WCCexeTickLBL.AutoSize = true;
            this.WCCexeTickLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCCexeTickLBL.ForeColor = System.Drawing.Color.Red;
            this.WCCexeTickLBL.Location = new System.Drawing.Point(14, 70);
            this.WCCexeTickLBL.Name = "WCCexeTickLBL";
            this.WCCexeTickLBL.Size = new System.Drawing.Size(15, 13);
            this.WCCexeTickLBL.TabIndex = 14;
            this.WCCexeTickLBL.Text = "X";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Enabled = false;
            this.labelTheme.Location = new System.Drawing.Point(35, 340);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(67, 13);
            this.labelTheme.TabIndex = 15;
            this.labelTheme.Text = "Color Theme";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(186, 337);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(135, 21);
            this.comboBoxTheme.TabIndex = 16;
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Location = new System.Drawing.Point(186, 370);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(135, 21);
            this.comboBoxExtension.TabIndex = 18;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Enabled = false;
            this.labelExtension.Location = new System.Drawing.Point(35, 373);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(138, 13);
            this.labelExtension.TabIndex = 17;
            this.labelExtension.Text = "Uncooked Image Extension";
            // 
            // checkBoxDisableWelcomeForm
            // 
            this.checkBoxDisableWelcomeForm.AutoSize = true;
            this.checkBoxDisableWelcomeForm.Location = new System.Drawing.Point(348, 339);
            this.checkBoxDisableWelcomeForm.Name = "checkBoxDisableWelcomeForm";
            this.checkBoxDisableWelcomeForm.Size = new System.Drawing.Size(135, 17);
            this.checkBoxDisableWelcomeForm.TabIndex = 19;
            this.checkBoxDisableWelcomeForm.Text = "Disable Welcome Form";
            this.checkBoxDisableWelcomeForm.UseVisualStyleBackColor = true;
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(35, 90);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(114, 13);
            this.lblDepot.TabIndex = 21;
            this.lblDepot.Text = "Uncooked depot path:";
            // 
            // textBoxDepot
            // 
            this.textBoxDepot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepot.Enabled = false;
            this.textBoxDepot.Location = new System.Drawing.Point(35, 106);
            this.textBoxDepot.Name = "textBoxDepot";
            this.textBoxDepot.Size = new System.Drawing.Size(441, 20);
            this.textBoxDepot.TabIndex = 20;
            // 
            // labelCustomModDir
            // 
            this.labelCustomModDir.AutoSize = true;
            this.labelCustomModDir.Location = new System.Drawing.Point(35, 129);
            this.labelCustomModDir.Name = "labelCustomModDir";
            this.labelCustomModDir.Size = new System.Drawing.Size(65, 13);
            this.labelCustomModDir.TabIndex = 23;
            this.labelCustomModDir.Text = "Mods folder:";
            // 
            // textBoxModDir
            // 
            this.textBoxModDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModDir.Enabled = false;
            this.textBoxModDir.Location = new System.Drawing.Point(35, 145);
            this.textBoxModDir.Name = "textBoxModDir";
            this.textBoxModDir.Size = new System.Drawing.Size(441, 20);
            this.textBoxModDir.TabIndex = 22;
            // 
            // labelCustomDlcDir
            // 
            this.labelCustomDlcDir.AutoSize = true;
            this.labelCustomDlcDir.Location = new System.Drawing.Point(35, 168);
            this.labelCustomDlcDir.Name = "labelCustomDlcDir";
            this.labelCustomDlcDir.Size = new System.Drawing.Size(55, 13);
            this.labelCustomDlcDir.TabIndex = 25;
            this.labelCustomDlcDir.Text = "Dlc folder:";
            // 
            // textBoxDlcDir
            // 
            this.textBoxDlcDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDlcDir.Enabled = false;
            this.textBoxDlcDir.Location = new System.Drawing.Point(35, 184);
            this.textBoxDlcDir.Name = "textBoxDlcDir";
            this.textBoxDlcDir.Size = new System.Drawing.Size(441, 20);
            this.textBoxDlcDir.TabIndex = 24;
            // 
            // buttonBrowseModDir
            // 
            this.buttonBrowseModDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseModDir.Location = new System.Drawing.Point(483, 143);
            this.buttonBrowseModDir.Name = "buttonBrowseModDir";
            this.buttonBrowseModDir.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseModDir.TabIndex = 26;
            this.buttonBrowseModDir.Text = "Browse...";
            this.buttonBrowseModDir.UseVisualStyleBackColor = true;
            this.buttonBrowseModDir.Click += new System.EventHandler(this.buttonBrowseModDir_Click);
            // 
            // buttonBrowseDlcDir
            // 
            this.buttonBrowseDlcDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDlcDir.Location = new System.Drawing.Point(483, 182);
            this.buttonBrowseDlcDir.Name = "buttonBrowseDlcDir";
            this.buttonBrowseDlcDir.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDlcDir.TabIndex = 27;
            this.buttonBrowseDlcDir.Text = "Browse...";
            this.buttonBrowseDlcDir.UseVisualStyleBackColor = true;
            this.buttonBrowseDlcDir.Click += new System.EventHandler(this.buttonBrowseDlcDir_Click);
            // 
            // checkBoxAutoInstall
            // 
            this.checkBoxAutoInstall.AutoSize = true;
            this.checkBoxAutoInstall.Checked = true;
            this.checkBoxAutoInstall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoInstall.Location = new System.Drawing.Point(348, 372);
            this.checkBoxAutoInstall.Name = "checkBoxAutoInstall";
            this.checkBoxAutoInstall.Size = new System.Drawing.Size(147, 17);
            this.checkBoxAutoInstall.TabIndex = 28;
            this.checkBoxAutoInstall.Text = "Automatically Install Mods";
            this.checkBoxAutoInstall.UseVisualStyleBackColor = true;
            // 
            // labelUpdateChannel
            // 
            this.labelUpdateChannel.AutoSize = true;
            this.labelUpdateChannel.Enabled = false;
            this.labelUpdateChannel.Location = new System.Drawing.Point(35, 224);
            this.labelUpdateChannel.Name = "labelUpdateChannel";
            this.labelUpdateChannel.Size = new System.Drawing.Size(84, 13);
            this.labelUpdateChannel.TabIndex = 29;
            this.labelUpdateChannel.Text = "Update Channel";
            // 
            // comboBoxUpdateChannel
            // 
            this.comboBoxUpdateChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateChannel.FormattingEnabled = true;
            this.comboBoxUpdateChannel.Location = new System.Drawing.Point(186, 221);
            this.comboBoxUpdateChannel.Name = "comboBoxUpdateChannel";
            this.comboBoxUpdateChannel.Size = new System.Drawing.Size(135, 21);
            this.comboBoxUpdateChannel.TabIndex = 30;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(588, 444);
            this.Controls.Add(this.comboBoxUpdateChannel);
            this.Controls.Add(this.labelUpdateChannel);
            this.Controls.Add(this.checkBoxAutoInstall);
            this.Controls.Add(this.buttonBrowseDlcDir);
            this.Controls.Add(this.buttonBrowseModDir);
            this.Controls.Add(this.labelCustomDlcDir);
            this.Controls.Add(this.textBoxDlcDir);
            this.Controls.Add(this.labelCustomModDir);
            this.Controls.Add(this.textBoxModDir);
            this.Controls.Add(this.lblDepot);
            this.Controls.Add(this.textBoxDepot);
            this.Controls.Add(this.checkBoxDisableWelcomeForm);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.WCCexeTickLBL);
            this.Controls.Add(this.W3exeTickLBL);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.buttonBrowseWcc);
            this.Controls.Add(this.lblWCC_Lite);
            this.Controls.Add(this.textBoxWcc);
            this.Controls.Add(this.lblVoiceLanguage);
            this.Controls.Add(this.txVoiceLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txTextLanguage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.buttonBrowseGame);
            this.Controls.Add(this.lblExecutable);
            this.Controls.Add(this.textBoxGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGame;
        private Label lblExecutable;
        private Button buttonBrowseGame;
        private Button btSave;
        private Label lblLanguage;
        private Label lblVoiceLanguage;
        private Button buttonBrowseWcc;
        private Label lblWCC_Lite;
        private TextBox textBoxWcc;
        private Button btCancel;
        private TextBox txTextLanguage;
        private TextBox txVoiceLanguage;
        private BackgroundWorker exeSearcherSlave;
        private Label W3exeTickLBL;
        private Label WCCexeTickLBL;
        private Label labelTheme;
        private ComboBox comboBoxTheme;
        private ComboBox comboBoxExtension;
        private Label labelExtension;
        private CheckBox checkBoxDisableWelcomeForm;
        private Label lblDepot;
        private TextBox textBoxDepot;
        private Label labelCustomModDir;
        private TextBox textBoxModDir;
        private Label labelCustomDlcDir;
        private TextBox textBoxDlcDir;
        private Button buttonBrowseModDir;
        private Button buttonBrowseDlcDir;
        private CheckBox checkBoxAutoInstall;
        private Label labelUpdateChannel;
        private ComboBox comboBoxUpdateChannel;
    }
}