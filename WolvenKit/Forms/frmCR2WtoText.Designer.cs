namespace WolvenKit.Forms
{
    partial class frmCR2WtoText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCR2WtoText));
            this.btnRun = new System.Windows.Forms.Button();
            this.labProcessedFiles = new System.Windows.Forms.Label();
            this.labProcessedCount = new System.Windows.Forms.Label();
            this.labProcessedDivider = new System.Windows.Forms.Label();
            this.labProcessedTotal = new System.Windows.Forms.Label();
            this.prgProgressBar = new System.Windows.Forms.ProgressBar();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.chkDumpEmbedded = new System.Windows.Forms.CheckBox();
            this.grpExistingFiles = new System.Windows.Forms.GroupBox();
            this.radExistingSkip = new System.Windows.Forms.RadioButton();
            this.radExistingOverwrite = new System.Windows.Forms.RadioButton();
            this.pnlFileCount = new System.Windows.Forms.Panel();
            this.labFileCountDesc = new System.Windows.Forms.Label();
            this.labFileCount = new System.Windows.Forms.Label();
            this.chkPrefixFileName = new System.Windows.Forms.CheckBox();
            this.chkDumpFCD = new System.Windows.Forms.CheckBox();
            this.chkDumpSDB = new System.Windows.Forms.CheckBox();
            this.labOutputFileMode = new System.Windows.Forms.Label();
            this.btnPickOutput = new System.Windows.Forms.Button();
            this.labOverwrite = new System.Windows.Forms.Label();
            this.labDumpOptions = new System.Windows.Forms.Label();
            this.labOutputFile = new System.Windows.Forms.Label();
            this.labPath = new System.Windows.Forms.Label();
            this.txtOutputDestination = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grpRadioOutputMode = new System.Windows.Forms.GroupBox();
            this.radOutputModeSeparateFiles = new System.Windows.Forms.RadioButton();
            this.radOutputModeSingleFile = new System.Windows.Forms.RadioButton();
            this.pnlProcessedFiles = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.grpExistingFiles.SuspendLayout();
            this.pnlFileCount.SuspendLayout();
            this.grpRadioOutputMode.SuspendLayout();
            this.pnlProcessedFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Image = global::WolvenKit.Properties.Resources.Output_16x;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(45, 532);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(421, 23);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run CR2W Dump";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // labProcessedFiles
            // 
            this.labProcessedFiles.AutoSize = true;
            this.labProcessedFiles.Location = new System.Drawing.Point(26, 5);
            this.labProcessedFiles.Name = "labProcessedFiles";
            this.labProcessedFiles.Size = new System.Drawing.Size(81, 13);
            this.labProcessedFiles.TabIndex = 11;
            this.labProcessedFiles.Text = "Processed files:";
            this.labProcessedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labProcessedCount
            // 
            this.labProcessedCount.AutoSize = true;
            this.labProcessedCount.Location = new System.Drawing.Point(113, 5);
            this.labProcessedCount.Name = "labProcessedCount";
            this.labProcessedCount.Size = new System.Drawing.Size(13, 13);
            this.labProcessedCount.TabIndex = 12;
            this.labProcessedCount.Text = "0";
            // 
            // labProcessedDivider
            // 
            this.labProcessedDivider.AutoSize = true;
            this.labProcessedDivider.Location = new System.Drawing.Point(132, 5);
            this.labProcessedDivider.Name = "labProcessedDivider";
            this.labProcessedDivider.Size = new System.Drawing.Size(12, 13);
            this.labProcessedDivider.TabIndex = 13;
            this.labProcessedDivider.Text = "/";
            // 
            // labProcessedTotal
            // 
            this.labProcessedTotal.AutoSize = true;
            this.labProcessedTotal.Location = new System.Drawing.Point(152, 5);
            this.labProcessedTotal.Name = "labProcessedTotal";
            this.labProcessedTotal.Size = new System.Drawing.Size(13, 13);
            this.labProcessedTotal.TabIndex = 14;
            this.labProcessedTotal.Text = "0";
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.Location = new System.Drawing.Point(45, 474);
            this.prgProgressBar.Minimum = 1;
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Size = new System.Drawing.Size(421, 22);
            this.prgProgressBar.TabIndex = 15;
            this.prgProgressBar.Value = 1;
            this.prgProgressBar.Visible = false;
            // 
            // rtfDescription
            // 
            this.rtfDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfDescription.CausesValidation = false;
            this.rtfDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDescription.Font = new System.Drawing.Font("Calibri", 9F);
            this.rtfDescription.Location = new System.Drawing.Point(12, 12);
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.ReadOnly = true;
            this.rtfDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDescription.Size = new System.Drawing.Size(476, 139);
            this.rtfDescription.TabIndex = 20;
            this.rtfDescription.Text = resources.GetString("rtfDescription.Text");
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chkDumpEmbedded);
            this.pnlControls.Controls.Add(this.grpExistingFiles);
            this.pnlControls.Controls.Add(this.pnlFileCount);
            this.pnlControls.Controls.Add(this.chkPrefixFileName);
            this.pnlControls.Controls.Add(this.chkDumpFCD);
            this.pnlControls.Controls.Add(this.chkDumpSDB);
            this.pnlControls.Controls.Add(this.labOutputFileMode);
            this.pnlControls.Controls.Add(this.btnPickOutput);
            this.pnlControls.Controls.Add(this.labOverwrite);
            this.pnlControls.Controls.Add(this.labDumpOptions);
            this.pnlControls.Controls.Add(this.labOutputFile);
            this.pnlControls.Controls.Add(this.labPath);
            this.pnlControls.Controls.Add(this.txtOutputDestination);
            this.pnlControls.Controls.Add(this.btnChoosePath);
            this.pnlControls.Controls.Add(this.txtPath);
            this.pnlControls.Controls.Add(this.grpRadioOutputMode);
            this.pnlControls.Location = new System.Drawing.Point(12, 159);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(476, 303);
            this.pnlControls.TabIndex = 21;
            // 
            // chkDumpEmbedded
            // 
            this.chkDumpEmbedded.AutoSize = true;
            this.chkDumpEmbedded.Checked = true;
            this.chkDumpEmbedded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpEmbedded.Location = new System.Drawing.Point(95, 177);
            this.chkDumpEmbedded.Name = "chkDumpEmbedded";
            this.chkDumpEmbedded.Size = new System.Drawing.Size(116, 17);
            this.chkDumpEmbedded.TabIndex = 34;
            this.chkDumpEmbedded.Text = "List embedded files";
            this.chkDumpEmbedded.UseVisualStyleBackColor = true;
            // 
            // grpExistingFiles
            // 
            this.grpExistingFiles.Controls.Add(this.radExistingSkip);
            this.grpExistingFiles.Controls.Add(this.radExistingOverwrite);
            this.grpExistingFiles.Location = new System.Drawing.Point(95, 238);
            this.grpExistingFiles.Name = "grpExistingFiles";
            this.grpExistingFiles.Size = new System.Drawing.Size(142, 56);
            this.grpExistingFiles.TabIndex = 33;
            this.grpExistingFiles.TabStop = false;
            // 
            // radExistingSkip
            // 
            this.radExistingSkip.AutoSize = true;
            this.radExistingSkip.Location = new System.Drawing.Point(6, 33);
            this.radExistingSkip.Name = "radExistingSkip";
            this.radExistingSkip.Size = new System.Drawing.Size(105, 17);
            this.radExistingSkip.TabIndex = 0;
            this.radExistingSkip.Text = "Skip existing files";
            this.radExistingSkip.UseVisualStyleBackColor = true;
            // 
            // radExistingOverwrite
            // 
            this.radExistingOverwrite.AutoSize = true;
            this.radExistingOverwrite.Checked = true;
            this.radExistingOverwrite.Location = new System.Drawing.Point(6, 12);
            this.radExistingOverwrite.Name = "radExistingOverwrite";
            this.radExistingOverwrite.Size = new System.Drawing.Size(129, 17);
            this.radExistingOverwrite.TabIndex = 0;
            this.radExistingOverwrite.TabStop = true;
            this.radExistingOverwrite.Text = "Overwrite existing files";
            this.radExistingOverwrite.UseVisualStyleBackColor = true;
            // 
            // pnlFileCount
            // 
            this.pnlFileCount.Controls.Add(this.labFileCountDesc);
            this.pnlFileCount.Controls.Add(this.labFileCount);
            this.pnlFileCount.Location = new System.Drawing.Point(96, 41);
            this.pnlFileCount.Name = "pnlFileCount";
            this.pnlFileCount.Size = new System.Drawing.Size(294, 18);
            this.pnlFileCount.TabIndex = 32;
            this.pnlFileCount.Visible = false;
            // 
            // labFileCountDesc
            // 
            this.labFileCountDesc.AutoSize = true;
            this.labFileCountDesc.Location = new System.Drawing.Point(90, 1);
            this.labFileCountDesc.Name = "labFileCountDesc";
            this.labFileCountDesc.Size = new System.Drawing.Size(120, 13);
            this.labFileCountDesc.TabIndex = 26;
            this.labFileCountDesc.Text = "Number of files in folder:";
            this.labFileCountDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labFileCount
            // 
            this.labFileCount.AutoSize = true;
            this.labFileCount.Location = new System.Drawing.Point(216, 1);
            this.labFileCount.Name = "labFileCount";
            this.labFileCount.Size = new System.Drawing.Size(13, 13);
            this.labFileCount.TabIndex = 28;
            this.labFileCount.Text = "0";
            // 
            // chkPrefixFileName
            // 
            this.chkPrefixFileName.AutoSize = true;
            this.chkPrefixFileName.Checked = true;
            this.chkPrefixFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrefixFileName.Location = new System.Drawing.Point(95, 157);
            this.chkPrefixFileName.Name = "chkPrefixFileName";
            this.chkPrefixFileName.Size = new System.Drawing.Size(165, 17);
            this.chkPrefixFileName.TabIndex = 31;
            this.chkPrefixFileName.Text = "Prefix each line with file name";
            this.chkPrefixFileName.UseVisualStyleBackColor = true;
            // 
            // chkDumpFCD
            // 
            this.chkDumpFCD.AutoSize = true;
            this.chkDumpFCD.Location = new System.Drawing.Point(95, 219);
            this.chkDumpFCD.Name = "chkDumpFCD";
            this.chkDumpFCD.Size = new System.Drawing.Size(137, 17);
            this.chkDumpFCD.TabIndex = 29;
            this.chkDumpFCD.Text = "Dump flatCompiledData";
            this.chkDumpFCD.UseVisualStyleBackColor = true;
            // 
            // chkDumpSDB
            // 
            this.chkDumpSDB.AutoSize = true;
            this.chkDumpSDB.Checked = true;
            this.chkDumpSDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpSDB.Location = new System.Drawing.Point(95, 198);
            this.chkDumpSDB.Name = "chkDumpSDB";
            this.chkDumpSDB.Size = new System.Drawing.Size(142, 17);
            this.chkDumpSDB.TabIndex = 27;
            this.chkDumpSDB.Text = "Dump SharedDataBuffer";
            this.chkDumpSDB.UseVisualStyleBackColor = true;
            // 
            // labOutputFileMode
            // 
            this.labOutputFileMode.AutoSize = true;
            this.labOutputFileMode.Location = new System.Drawing.Point(6, 85);
            this.labOutputFileMode.Name = "labOutputFileMode";
            this.labOutputFileMode.Size = new System.Drawing.Size(87, 13);
            this.labOutputFileMode.TabIndex = 30;
            this.labOutputFileMode.Text = "Output file mode:";
            this.labOutputFileMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPickOutput
            // 
            this.btnPickOutput.Location = new System.Drawing.Point(396, 124);
            this.btnPickOutput.Name = "btnPickOutput";
            this.btnPickOutput.Size = new System.Drawing.Size(75, 23);
            this.btnPickOutput.TabIndex = 25;
            this.btnPickOutput.Text = "Set output";
            this.btnPickOutput.UseVisualStyleBackColor = true;
            this.btnPickOutput.Click += new System.EventHandler(this.btnPickOutput_Click);
            // 
            // labOverwrite
            // 
            this.labOverwrite.AutoSize = true;
            this.labOverwrite.Location = new System.Drawing.Point(13, 261);
            this.labOverwrite.Name = "labOverwrite";
            this.labOverwrite.Size = new System.Drawing.Size(80, 13);
            this.labOverwrite.TabIndex = 22;
            this.labOverwrite.Text = "File overwriting:";
            this.labOverwrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDumpOptions
            // 
            this.labDumpOptions.AutoSize = true;
            this.labDumpOptions.Location = new System.Drawing.Point(18, 186);
            this.labDumpOptions.Name = "labDumpOptions";
            this.labDumpOptions.Size = new System.Drawing.Size(75, 13);
            this.labDumpOptions.TabIndex = 22;
            this.labDumpOptions.Text = "Dump options:";
            this.labDumpOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labOutputFile
            // 
            this.labOutputFile.AutoSize = true;
            this.labOutputFile.Location = new System.Drawing.Point(6, 129);
            this.labOutputFile.Name = "labOutputFile";
            this.labOutputFile.Size = new System.Drawing.Size(87, 13);
            this.labOutputFile.TabIndex = 23;
            this.labOutputFile.Text = "Output results to:";
            this.labOutputFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Location = new System.Drawing.Point(20, 18);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(73, 13);
            this.labPath.TabIndex = 21;
            this.labPath.Text = "Source folder:";
            this.labPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDestination
            // 
            this.txtOutputDestination.Location = new System.Drawing.Point(95, 126);
            this.txtOutputDestination.Name = "txtOutputDestination";
            this.txtOutputDestination.Size = new System.Drawing.Size(295, 20);
            this.txtOutputDestination.TabIndex = 24;
            this.txtOutputDestination.TextChanged += new System.EventHandler(this.txtOutputDestination_TextChanged);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(396, 14);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(75, 20);
            this.btnChoosePath.TabIndex = 19;
            this.btnChoosePath.Text = "Select path";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(95, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(295, 20);
            this.txtPath.TabIndex = 18;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // grpRadioOutputMode
            // 
            this.grpRadioOutputMode.Controls.Add(this.radOutputModeSeparateFiles);
            this.grpRadioOutputMode.Controls.Add(this.radOutputModeSingleFile);
            this.grpRadioOutputMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRadioOutputMode.Location = new System.Drawing.Point(95, 65);
            this.grpRadioOutputMode.Name = "grpRadioOutputMode";
            this.grpRadioOutputMode.Size = new System.Drawing.Size(142, 51);
            this.grpRadioOutputMode.TabIndex = 20;
            this.grpRadioOutputMode.TabStop = false;
            // 
            // radOutputModeSeparateFiles
            // 
            this.radOutputModeSeparateFiles.AutoSize = true;
            this.radOutputModeSeparateFiles.Location = new System.Drawing.Point(6, 28);
            this.radOutputModeSeparateFiles.Name = "radOutputModeSeparateFiles";
            this.radOutputModeSeparateFiles.Size = new System.Drawing.Size(130, 17);
            this.radOutputModeSeparateFiles.TabIndex = 5;
            this.radOutputModeSeparateFiles.Text = "One file per source file";
            this.radOutputModeSeparateFiles.UseVisualStyleBackColor = true;
            this.radOutputModeSeparateFiles.CheckedChanged += new System.EventHandler(this.radOutputModeSeparateFiles_CheckedChanged);
            // 
            // radOutputModeSingleFile
            // 
            this.radOutputModeSingleFile.AutoSize = true;
            this.radOutputModeSingleFile.Checked = true;
            this.radOutputModeSingleFile.Location = new System.Drawing.Point(6, 7);
            this.radOutputModeSingleFile.Name = "radOutputModeSingleFile";
            this.radOutputModeSingleFile.Size = new System.Drawing.Size(70, 17);
            this.radOutputModeSingleFile.TabIndex = 4;
            this.radOutputModeSingleFile.TabStop = true;
            this.radOutputModeSingleFile.Text = "Single file";
            this.radOutputModeSingleFile.UseVisualStyleBackColor = true;
            this.radOutputModeSingleFile.CheckedChanged += new System.EventHandler(this.radOutputModeSingleFile_CheckedChanged);
            // 
            // pnlProcessedFiles
            // 
            this.pnlProcessedFiles.Controls.Add(this.labProcessedFiles);
            this.pnlProcessedFiles.Controls.Add(this.labProcessedCount);
            this.pnlProcessedFiles.Controls.Add(this.labProcessedTotal);
            this.pnlProcessedFiles.Controls.Add(this.labProcessedDivider);
            this.pnlProcessedFiles.Location = new System.Drawing.Point(157, 502);
            this.pnlProcessedFiles.Name = "pnlProcessedFiles";
            this.pnlProcessedFiles.Size = new System.Drawing.Size(199, 24);
            this.pnlProcessedFiles.TabIndex = 22;
            this.pnlProcessedFiles.Visible = false;
            // 
            // frmCR2WtoText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 565);
            this.Controls.Add(this.pnlProcessedFiles);
            this.Controls.Add(this.rtfDescription);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.prgProgressBar);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCR2WtoText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dump CR2W Files To Text";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.grpExistingFiles.ResumeLayout(false);
            this.grpExistingFiles.PerformLayout();
            this.pnlFileCount.ResumeLayout(false);
            this.pnlFileCount.PerformLayout();
            this.grpRadioOutputMode.ResumeLayout(false);
            this.grpRadioOutputMode.PerformLayout();
            this.pnlProcessedFiles.ResumeLayout(false);
            this.pnlProcessedFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label labProcessedFiles;
        private System.Windows.Forms.Label labProcessedCount;
        private System.Windows.Forms.Label labProcessedDivider;
        private System.Windows.Forms.Label labProcessedTotal;
        private System.Windows.Forms.ProgressBar prgProgressBar;
        private System.Windows.Forms.RichTextBox rtfDescription;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.CheckBox chkDumpFCD;
        private System.Windows.Forms.CheckBox chkDumpSDB;
        private System.Windows.Forms.Label labOutputFileMode;
        private System.Windows.Forms.Button btnPickOutput;
        private System.Windows.Forms.Label labFileCount;
        private System.Windows.Forms.Label labFileCountDesc;
        private System.Windows.Forms.Label labDumpOptions;
        private System.Windows.Forms.Label labOutputFile;
        private System.Windows.Forms.Label labPath;
        private System.Windows.Forms.TextBox txtOutputDestination;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grpRadioOutputMode;
        private System.Windows.Forms.RadioButton radOutputModeSeparateFiles;
        private System.Windows.Forms.RadioButton radOutputModeSingleFile;
        private System.Windows.Forms.CheckBox chkPrefixFileName;
        private System.Windows.Forms.Panel pnlProcessedFiles;
        private System.Windows.Forms.Panel pnlFileCount;
        private System.Windows.Forms.Label labOverwrite;
        private System.Windows.Forms.GroupBox grpExistingFiles;
        private System.Windows.Forms.RadioButton radExistingSkip;
        private System.Windows.Forms.RadioButton radExistingOverwrite;
        private System.Windows.Forms.CheckBox chkDumpEmbedded;
    }
}