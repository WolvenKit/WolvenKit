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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.chkLocalizedString = new System.Windows.Forms.CheckBox();
            this.labNumThreads = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.chkCreateFolders = new System.Windows.Forms.CheckBox();
            this.chkDumpEmbedded = new System.Windows.Forms.CheckBox();
            this.grpExistingFiles = new System.Windows.Forms.GroupBox();
            this.radExistingSkip = new System.Windows.Forms.RadioButton();
            this.radExistingOverwrite = new System.Windows.Forms.RadioButton();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prgProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.dataStatus = new System.Windows.Forms.DataGridView();
            this.colAllFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNonCR2W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchingFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProcessedFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkipped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.grpExistingFiles.SuspendLayout();
            this.grpRadioOutputMode.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Image = global::WolvenKit.Properties.Resources.Output_16x;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(292, 791);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(630, 35);
            this.btnRun.TabIndex = 30;
            this.btnRun.Text = "Run CR2W Dump";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtfDescription
            // 
            this.rtfDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfDescription.CausesValidation = false;
            this.rtfDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtfDescription.Font = new System.Drawing.Font("Calibri", 9F);
            this.rtfDescription.Location = new System.Drawing.Point(18, 18);
            this.rtfDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.ReadOnly = true;
            this.rtfDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfDescription.Size = new System.Drawing.Size(1110, 262);
            this.rtfDescription.TabIndex = 20;
            this.rtfDescription.TabStop = false;
            this.rtfDescription.Text = resources.GetString("rtfDescription.Text");
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chkLocalizedString);
            this.pnlControls.Controls.Add(this.labNumThreads);
            this.pnlControls.Controls.Add(this.numThreads);
            this.pnlControls.Controls.Add(this.chkCreateFolders);
            this.pnlControls.Controls.Add(this.chkDumpEmbedded);
            this.pnlControls.Controls.Add(this.grpExistingFiles);
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
            this.pnlControls.Location = new System.Drawing.Point(18, 295);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1110, 483);
            this.pnlControls.TabIndex = 21;
            // 
            // chkLocalizedString
            // 
            this.chkLocalizedString.AutoSize = true;
            this.chkLocalizedString.Checked = true;
            this.chkLocalizedString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLocalizedString.Location = new System.Drawing.Point(216, 352);
            this.chkLocalizedString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLocalizedString.Name = "chkLocalizedString";
            this.chkLocalizedString.Size = new System.Drawing.Size(297, 24);
            this.chkLocalizedString.TabIndex = 15;
            this.chkLocalizedString.Text = "Dump localized strings instead of IDs";
            this.chkLocalizedString.UseVisualStyleBackColor = true;
            // 
            // labNumThreads
            // 
            this.labNumThreads.AutoSize = true;
            this.labNumThreads.Location = new System.Drawing.Point(458, 82);
            this.labNumThreads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNumThreads.Name = "labNumThreads";
            this.labNumThreads.Size = new System.Drawing.Size(145, 20);
            this.labNumThreads.TabIndex = 37;
            this.labNumThreads.Text = "Number of threads:";
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(609, 78);
            this.numThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(54, 26);
            this.numThreads.TabIndex = 6;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chkCreateFolders
            // 
            this.chkCreateFolders.AutoSize = true;
            this.chkCreateFolders.Checked = true;
            this.chkCreateFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateFolders.Location = new System.Drawing.Point(216, 195);
            this.chkCreateFolders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCreateFolders.Name = "chkCreateFolders";
            this.chkCreateFolders.Size = new System.Drawing.Size(227, 24);
            this.chkCreateFolders.TabIndex = 10;
            this.chkCreateFolders.Text = "Create intermediate folders";
            this.chkCreateFolders.UseVisualStyleBackColor = true;
            // 
            // chkDumpEmbedded
            // 
            this.chkDumpEmbedded.AutoSize = true;
            this.chkDumpEmbedded.Checked = true;
            this.chkDumpEmbedded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpEmbedded.Location = new System.Drawing.Point(216, 258);
            this.chkDumpEmbedded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDumpEmbedded.Name = "chkDumpEmbedded";
            this.chkDumpEmbedded.Size = new System.Drawing.Size(172, 24);
            this.chkDumpEmbedded.TabIndex = 12;
            this.chkDumpEmbedded.Text = "List embedded files";
            this.chkDumpEmbedded.UseVisualStyleBackColor = true;
            // 
            // grpExistingFiles
            // 
            this.grpExistingFiles.Controls.Add(this.radExistingSkip);
            this.grpExistingFiles.Controls.Add(this.radExistingOverwrite);
            this.grpExistingFiles.Location = new System.Drawing.Point(216, 392);
            this.grpExistingFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExistingFiles.Name = "grpExistingFiles";
            this.grpExistingFiles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExistingFiles.Size = new System.Drawing.Size(213, 86);
            this.grpExistingFiles.TabIndex = 20;
            this.grpExistingFiles.TabStop = false;
            // 
            // radExistingSkip
            // 
            this.radExistingSkip.AutoSize = true;
            this.radExistingSkip.Location = new System.Drawing.Point(9, 51);
            this.radExistingSkip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radExistingSkip.Name = "radExistingSkip";
            this.radExistingSkip.Size = new System.Drawing.Size(154, 24);
            this.radExistingSkip.TabIndex = 22;
            this.radExistingSkip.TabStop = true;
            this.radExistingSkip.Text = "Skip existing files";
            this.radExistingSkip.UseVisualStyleBackColor = true;
            // 
            // radExistingOverwrite
            // 
            this.radExistingOverwrite.AutoSize = true;
            this.radExistingOverwrite.Checked = true;
            this.radExistingOverwrite.Location = new System.Drawing.Point(9, 18);
            this.radExistingOverwrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radExistingOverwrite.Name = "radExistingOverwrite";
            this.radExistingOverwrite.Size = new System.Drawing.Size(189, 24);
            this.radExistingOverwrite.TabIndex = 21;
            this.radExistingOverwrite.TabStop = true;
            this.radExistingOverwrite.Text = "Overwrite existing files";
            this.radExistingOverwrite.UseVisualStyleBackColor = true;
            // 
            // chkPrefixFileName
            // 
            this.chkPrefixFileName.AutoSize = true;
            this.chkPrefixFileName.Checked = true;
            this.chkPrefixFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrefixFileName.Location = new System.Drawing.Point(216, 228);
            this.chkPrefixFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPrefixFileName.Name = "chkPrefixFileName";
            this.chkPrefixFileName.Size = new System.Drawing.Size(241, 24);
            this.chkPrefixFileName.TabIndex = 11;
            this.chkPrefixFileName.Text = "Prefix each line with file name";
            this.chkPrefixFileName.UseVisualStyleBackColor = true;
            // 
            // chkDumpFCD
            // 
            this.chkDumpFCD.AutoSize = true;
            this.chkDumpFCD.Location = new System.Drawing.Point(216, 322);
            this.chkDumpFCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDumpFCD.Name = "chkDumpFCD";
            this.chkDumpFCD.Size = new System.Drawing.Size(205, 24);
            this.chkDumpFCD.TabIndex = 14;
            this.chkDumpFCD.Text = "Dump flatCompiledData";
            this.chkDumpFCD.UseVisualStyleBackColor = true;
            // 
            // chkDumpSDB
            // 
            this.chkDumpSDB.AutoSize = true;
            this.chkDumpSDB.Checked = true;
            this.chkDumpSDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDumpSDB.Location = new System.Drawing.Point(216, 291);
            this.chkDumpSDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDumpSDB.Name = "chkDumpSDB";
            this.chkDumpSDB.Size = new System.Drawing.Size(267, 24);
            this.chkDumpSDB.TabIndex = 13;
            this.chkDumpSDB.Text = "Dump SharedDataBuffer buffers";
            this.chkDumpSDB.UseVisualStyleBackColor = true;
            // 
            // labOutputFileMode
            // 
            this.labOutputFileMode.AutoSize = true;
            this.labOutputFileMode.Location = new System.Drawing.Point(82, 82);
            this.labOutputFileMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOutputFileMode.Name = "labOutputFileMode";
            this.labOutputFileMode.Size = new System.Drawing.Size(130, 20);
            this.labOutputFileMode.TabIndex = 30;
            this.labOutputFileMode.Text = "Output file mode:";
            this.labOutputFileMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPickOutput
            // 
            this.btnPickOutput.Location = new System.Drawing.Point(904, 143);
            this.btnPickOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPickOutput.Name = "btnPickOutput";
            this.btnPickOutput.Size = new System.Drawing.Size(112, 35);
            this.btnPickOutput.TabIndex = 8;
            this.btnPickOutput.Text = "Set output";
            this.btnPickOutput.UseVisualStyleBackColor = true;
            this.btnPickOutput.Click += new System.EventHandler(this.btnPickOutput_Click);
            // 
            // labOverwrite
            // 
            this.labOverwrite.AutoSize = true;
            this.labOverwrite.Location = new System.Drawing.Point(93, 428);
            this.labOverwrite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOverwrite.Name = "labOverwrite";
            this.labOverwrite.Size = new System.Drawing.Size(117, 20);
            this.labOverwrite.TabIndex = 22;
            this.labOverwrite.Text = "File overwriting:";
            this.labOverwrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labDumpOptions
            // 
            this.labDumpOptions.AutoSize = true;
            this.labDumpOptions.Location = new System.Drawing.Point(100, 258);
            this.labDumpOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDumpOptions.Name = "labDumpOptions";
            this.labDumpOptions.Size = new System.Drawing.Size(112, 20);
            this.labDumpOptions.TabIndex = 22;
            this.labDumpOptions.Text = "Dump options:";
            this.labDumpOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labOutputFile
            // 
            this.labOutputFile.AutoSize = true;
            this.labOutputFile.Location = new System.Drawing.Point(82, 149);
            this.labOutputFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOutputFile.Name = "labOutputFile";
            this.labOutputFile.Size = new System.Drawing.Size(131, 20);
            this.labOutputFile.TabIndex = 23;
            this.labOutputFile.Text = "Output results to:";
            this.labOutputFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Location = new System.Drawing.Point(104, 22);
            this.labPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(108, 20);
            this.labPath.TabIndex = 21;
            this.labPath.Text = "Source folder:";
            this.labPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDestination
            // 
            this.txtOutputDestination.Location = new System.Drawing.Point(216, 145);
            this.txtOutputDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutputDestination.Name = "txtOutputDestination";
            this.txtOutputDestination.Size = new System.Drawing.Size(678, 26);
            this.txtOutputDestination.TabIndex = 7;
            this.txtOutputDestination.TextChanged += new System.EventHandler(this.txtOutputDestination_TextChanged);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(904, 17);
            this.btnChoosePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(112, 31);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "Select path";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(216, 17);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(678, 26);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // grpRadioOutputMode
            // 
            this.grpRadioOutputMode.Controls.Add(this.radOutputModeSeparateFiles);
            this.grpRadioOutputMode.Controls.Add(this.radOutputModeSingleFile);
            this.grpRadioOutputMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRadioOutputMode.Location = new System.Drawing.Point(216, 51);
            this.grpRadioOutputMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRadioOutputMode.Name = "grpRadioOutputMode";
            this.grpRadioOutputMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRadioOutputMode.Size = new System.Drawing.Size(213, 78);
            this.grpRadioOutputMode.TabIndex = 3;
            this.grpRadioOutputMode.TabStop = false;
            // 
            // radOutputModeSeparateFiles
            // 
            this.radOutputModeSeparateFiles.AutoSize = true;
            this.radOutputModeSeparateFiles.Checked = true;
            this.radOutputModeSeparateFiles.Location = new System.Drawing.Point(9, 17);
            this.radOutputModeSeparateFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOutputModeSeparateFiles.Name = "radOutputModeSeparateFiles";
            this.radOutputModeSeparateFiles.Size = new System.Drawing.Size(191, 24);
            this.radOutputModeSeparateFiles.TabIndex = 4;
            this.radOutputModeSeparateFiles.TabStop = true;
            this.radOutputModeSeparateFiles.Text = "One file per source file";
            this.radOutputModeSeparateFiles.UseVisualStyleBackColor = true;
            this.radOutputModeSeparateFiles.CheckedChanged += new System.EventHandler(this.RadioOutputModeChanged);
            // 
            // radOutputModeSingleFile
            // 
            this.radOutputModeSingleFile.AutoSize = true;
            this.radOutputModeSingleFile.Location = new System.Drawing.Point(9, 45);
            this.radOutputModeSingleFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOutputModeSingleFile.Name = "radOutputModeSingleFile";
            this.radOutputModeSingleFile.Size = new System.Drawing.Size(102, 24);
            this.radOutputModeSingleFile.TabIndex = 5;
            this.radOutputModeSingleFile.Text = "Single file";
            this.radOutputModeSingleFile.UseVisualStyleBackColor = true;
            this.radOutputModeSingleFile.CheckedChanged += new System.EventHandler(this.RadioOutputModeChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgProgressBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 1305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1146, 33);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.prgProgressBar.Size = new System.Drawing.Size(1140, 25);
            // 
            // dataStatus
            // 
            this.dataStatus.AllowUserToAddRows = false;
            this.dataStatus.AllowUserToDeleteRows = false;
            this.dataStatus.AllowUserToResizeColumns = false;
            this.dataStatus.AllowUserToResizeRows = false;
            this.dataStatus.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAllFiles,
            this.colNonCR2W,
            this.colMatchingFiles,
            this.colProcessedFiles,
            this.colSkipped,
            this.colExceptions});
            this.dataStatus.Location = new System.Drawing.Point(292, 843);
            this.dataStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataStatus.MultiSelect = false;
            this.dataStatus.Name = "dataStatus";
            this.dataStatus.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStatus.RowHeadersVisible = false;
            this.dataStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataStatus.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataStatus.RowTemplate.ReadOnly = true;
            this.dataStatus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataStatus.ShowEditingIcon = false;
            this.dataStatus.Size = new System.Drawing.Size(630, 88);
            this.dataStatus.TabIndex = 31;
            this.dataStatus.TabStop = false;
            // 
            // colAllFiles
            // 
            this.colAllFiles.Frozen = true;
            this.colAllFiles.HeaderText = "All Files";
            this.colAllFiles.MinimumWidth = 8;
            this.colAllFiles.Name = "colAllFiles";
            this.colAllFiles.ReadOnly = true;
            this.colAllFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAllFiles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAllFiles.Width = 70;
            // 
            // colNonCR2W
            // 
            this.colNonCR2W.Frozen = true;
            this.colNonCR2W.HeaderText = "Non-CR2W Files";
            this.colNonCR2W.MinimumWidth = 8;
            this.colNonCR2W.Name = "colNonCR2W";
            this.colNonCR2W.ReadOnly = true;
            this.colNonCR2W.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNonCR2W.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNonCR2W.Width = 70;
            // 
            // colMatchingFiles
            // 
            this.colMatchingFiles.Frozen = true;
            this.colMatchingFiles.HeaderText = "Matching Files";
            this.colMatchingFiles.MinimumWidth = 8;
            this.colMatchingFiles.Name = "colMatchingFiles";
            this.colMatchingFiles.ReadOnly = true;
            this.colMatchingFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMatchingFiles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMatchingFiles.Width = 70;
            // 
            // colProcessedFiles
            // 
            this.colProcessedFiles.Frozen = true;
            this.colProcessedFiles.HeaderText = "Processed Files";
            this.colProcessedFiles.MinimumWidth = 8;
            this.colProcessedFiles.Name = "colProcessedFiles";
            this.colProcessedFiles.ReadOnly = true;
            this.colProcessedFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProcessedFiles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colProcessedFiles.Width = 70;
            // 
            // colSkipped
            // 
            this.colSkipped.Frozen = true;
            this.colSkipped.HeaderText = "Skipped Files";
            this.colSkipped.MinimumWidth = 8;
            this.colSkipped.Name = "colSkipped";
            this.colSkipped.ReadOnly = true;
            this.colSkipped.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSkipped.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSkipped.Width = 70;
            // 
            // colExceptions
            // 
            this.colExceptions.Frozen = true;
            this.colExceptions.HeaderText = "Files with exceptions";
            this.colExceptions.MinimumWidth = 8;
            this.colExceptions.Name = "colExceptions";
            this.colExceptions.ReadOnly = true;
            this.colExceptions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colExceptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExceptions.Width = 70;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(18, 943);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1108, 347);
            this.txtLog.TabIndex = 32;
            this.txtLog.TabStop = false;
            this.txtLog.WordWrap = false;
            // 
            // frmCR2WtoText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 1338);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataStatus);
            this.Controls.Add(this.rtfDescription);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCR2WtoText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dump CR2W Files To Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCR2WtoText_FormClosing);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.grpExistingFiles.ResumeLayout(false);
            this.grpExistingFiles.PerformLayout();
            this.grpRadioOutputMode.ResumeLayout(false);
            this.grpRadioOutputMode.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtfDescription;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.CheckBox chkDumpFCD;
        private System.Windows.Forms.CheckBox chkDumpSDB;
        private System.Windows.Forms.Label labOutputFileMode;
        private System.Windows.Forms.Button btnPickOutput;
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
        private System.Windows.Forms.Label labOverwrite;
        private System.Windows.Forms.GroupBox grpExistingFiles;
        private System.Windows.Forms.RadioButton radExistingSkip;
        private System.Windows.Forms.RadioButton radExistingOverwrite;
        private System.Windows.Forms.CheckBox chkDumpEmbedded;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prgProgressBar;
        private System.Windows.Forms.CheckBox chkCreateFolders;
        private System.Windows.Forms.DataGridView dataStatus;
        private System.Windows.Forms.Label labNumThreads;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNonCR2W;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchingFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProcessedFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptions;
        private System.Windows.Forms.CheckBox chkLocalizedString;
    }
}