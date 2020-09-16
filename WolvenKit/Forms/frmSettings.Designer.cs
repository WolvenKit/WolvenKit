using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
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
            this.txExecutablePath = new System.Windows.Forms.TextBox();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.btnBrowseExe = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblVoiceLanguage = new System.Windows.Forms.Label();
            this.btBrowseWCC_Lite = new System.Windows.Forms.Button();
            this.lblWCC_Lite = new System.Windows.Forms.Label();
            this.txWCC_Lite = new System.Windows.Forms.TextBox();
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
            this.txDepot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txExecutablePath
            // 
            this.txExecutablePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txExecutablePath.Location = new System.Drawing.Point(52, 42);
            this.txExecutablePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txExecutablePath.Name = "txExecutablePath";
            this.txExecutablePath.Size = new System.Drawing.Size(661, 26);
            this.txExecutablePath.TabIndex = 0;
            this.txExecutablePath.TextChanged += new System.EventHandler(this.txExecutablePath_TextChanged);
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Location = new System.Drawing.Point(52, 14);
            this.lblExecutable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(197, 20);
            this.lblExecutable.TabIndex = 1;
            this.lblExecutable.Text = "Witcher 3 executable path:";
            // 
            // btnBrowseExe
            // 
            this.btnBrowseExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExe.Location = new System.Drawing.Point(724, 40);
            this.btnBrowseExe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseExe.Name = "btnBrowseExe";
            this.btnBrowseExe.Size = new System.Drawing.Size(112, 35);
            this.btnBrowseExe.TabIndex = 2;
            this.btnBrowseExe.Text = "Browse...";
            this.btnBrowseExe.UseVisualStyleBackColor = true;
            this.btnBrowseExe.Click += new System.EventHandler(this.btnBrowseExe_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(724, 474);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 35);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Enabled = false;
            this.lblLanguage.Location = new System.Drawing.Point(44, 229);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(181, 20);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Text Language (e.g. EN)";
            // 
            // lblVoiceLanguage
            // 
            this.lblVoiceLanguage.AutoSize = true;
            this.lblVoiceLanguage.Enabled = false;
            this.lblVoiceLanguage.Location = new System.Drawing.Point(44, 269);
            this.lblVoiceLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoiceLanguage.Name = "lblVoiceLanguage";
            this.lblVoiceLanguage.Size = new System.Drawing.Size(206, 20);
            this.lblVoiceLanguage.TabIndex = 7;
            this.lblVoiceLanguage.Text = "Speech Language (e.g. EN)";
            // 
            // btBrowseWCC_Lite
            // 
            this.btBrowseWCC_Lite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowseWCC_Lite.Location = new System.Drawing.Point(724, 102);
            this.btBrowseWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBrowseWCC_Lite.Name = "btBrowseWCC_Lite";
            this.btBrowseWCC_Lite.Size = new System.Drawing.Size(112, 35);
            this.btBrowseWCC_Lite.TabIndex = 10;
            this.btBrowseWCC_Lite.Text = "Browse...";
            this.btBrowseWCC_Lite.UseVisualStyleBackColor = true;
            this.btBrowseWCC_Lite.Click += new System.EventHandler(this.btBrowseWCC_Lite_Click);
            // 
            // lblWCC_Lite
            // 
            this.lblWCC_Lite.AutoSize = true;
            this.lblWCC_Lite.Location = new System.Drawing.Point(52, 77);
            this.lblWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWCC_Lite.Name = "lblWCC_Lite";
            this.lblWCC_Lite.Size = new System.Drawing.Size(151, 20);
            this.lblWCC_Lite.TabIndex = 9;
            this.lblWCC_Lite.Text = "WCC_Lite.exe Path:";
            // 
            // txWCC_Lite
            // 
            this.txWCC_Lite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txWCC_Lite.Location = new System.Drawing.Point(52, 103);
            this.txWCC_Lite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txWCC_Lite.Name = "txWCC_Lite";
            this.txWCC_Lite.Size = new System.Drawing.Size(660, 26);
            this.txWCC_Lite.TabIndex = 8;
            this.txWCC_Lite.TextChanged += new System.EventHandler(this.txWCC_Lite_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(603, 474);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 35);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // txTextLanguage
            // 
            this.txTextLanguage.Enabled = false;
            this.txTextLanguage.Location = new System.Drawing.Point(270, 218);
            this.txTextLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTextLanguage.Name = "txTextLanguage";
            this.txTextLanguage.Size = new System.Drawing.Size(200, 26);
            this.txTextLanguage.TabIndex = 4;
            // 
            // txVoiceLanguage
            // 
            this.txVoiceLanguage.Enabled = false;
            this.txVoiceLanguage.Location = new System.Drawing.Point(270, 265);
            this.txVoiceLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txVoiceLanguage.Name = "txVoiceLanguage";
            this.txVoiceLanguage.Size = new System.Drawing.Size(200, 26);
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
            this.W3exeTickLBL.Location = new System.Drawing.Point(26, 48);
            this.W3exeTickLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.W3exeTickLBL.Name = "W3exeTickLBL";
            this.W3exeTickLBL.Size = new System.Drawing.Size(21, 20);
            this.W3exeTickLBL.TabIndex = 13;
            this.W3exeTickLBL.Text = "X";
            // 
            // WCCexeTickLBL
            // 
            this.WCCexeTickLBL.AutoSize = true;
            this.WCCexeTickLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCCexeTickLBL.ForeColor = System.Drawing.Color.Red;
            this.WCCexeTickLBL.Location = new System.Drawing.Point(26, 109);
            this.WCCexeTickLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WCCexeTickLBL.Name = "WCCexeTickLBL";
            this.WCCexeTickLBL.Size = new System.Drawing.Size(21, 20);
            this.WCCexeTickLBL.TabIndex = 14;
            this.WCCexeTickLBL.Text = "X";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Enabled = false;
            this.labelTheme.Location = new System.Drawing.Point(44, 326);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(99, 20);
            this.labelTheme.TabIndex = 15;
            this.labelTheme.Text = "Color Theme";
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Location = new System.Drawing.Point(270, 322);
            this.comboBoxTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(200, 28);
            this.comboBoxTheme.TabIndex = 16;
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Location = new System.Drawing.Point(270, 372);
            this.comboBoxExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(200, 28);
            this.comboBoxExtension.TabIndex = 18;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Enabled = false;
            this.labelExtension.Location = new System.Drawing.Point(44, 377);
            this.labelExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(205, 20);
            this.labelExtension.TabIndex = 17;
            this.labelExtension.Text = "Uncooked Image Extension";
            // 
            // checkBoxDisableWelcomeForm
            // 
            this.checkBoxDisableWelcomeForm.AutoSize = true;
            this.checkBoxDisableWelcomeForm.Location = new System.Drawing.Point(513, 325);
            this.checkBoxDisableWelcomeForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDisableWelcomeForm.Name = "checkBoxDisableWelcomeForm";
            this.checkBoxDisableWelcomeForm.Size = new System.Drawing.Size(199, 24);
            this.checkBoxDisableWelcomeForm.TabIndex = 19;
            this.checkBoxDisableWelcomeForm.Text = "Disable Welcome Form";
            this.checkBoxDisableWelcomeForm.UseVisualStyleBackColor = true;
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(48, 138);
            this.lblDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(171, 20);
            this.lblDepot.TabIndex = 21;
            this.lblDepot.Text = "Uncooked Depot Path:";
            // 
            // txDepot
            // 
            this.txDepot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDepot.Enabled = false;
            this.txDepot.Location = new System.Drawing.Point(48, 165);
            this.txDepot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txDepot.Name = "txDepot";
            this.txDepot.Size = new System.Drawing.Size(660, 26);
            this.txDepot.TabIndex = 20;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(882, 528);
            this.Controls.Add(this.lblDepot);
            this.Controls.Add(this.txDepot);
            this.Controls.Add(this.checkBoxDisableWelcomeForm);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.WCCexeTickLBL);
            this.Controls.Add(this.W3exeTickLBL);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txExecutablePath;
        private Label lblExecutable;
        private Button btnBrowseExe;
        private Button btSave;
        private Label lblLanguage;
        private Label lblVoiceLanguage;
        private Button btBrowseWCC_Lite;
        private Label lblWCC_Lite;
        private TextBox txWCC_Lite;
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
        private TextBox txDepot;
    }
}