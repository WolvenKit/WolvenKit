namespace WolvenKit
{
	partial class frmStringsGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStringsGui));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGenerateXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGenerateScripts = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEncode = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerTabs = new System.Windows.Forms.SplitContainer();
            this.tabControlLanguages = new System.Windows.Forms.TabControl();
            this.tabPageAllLanguages = new System.Windows.Forms.TabPage();
            this.comboBoxLanguagesMode = new System.Windows.Forms.ComboBox();
            this.dataGridViewStrings = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHexKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStringKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxModID = new System.Windows.Forms.TextBox();
            this.labelModID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabs)).BeginInit();
            this.splitContainerTabs.Panel1.SuspendLayout();
            this.splitContainerTabs.Panel2.SuspendLayout();
            this.splitContainerTabs.SuspendLayout();
            this.tabControlLanguages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrings)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateStringsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // generateStringsToolStripMenuItem
            // 
            this.generateStringsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromXMLToolStripMenuItem,
            this.fromScriptsToolStripMenuItem});
            this.generateStringsToolStripMenuItem.Name = "generateStringsToolStripMenuItem";
            this.generateStringsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.generateStringsToolStripMenuItem.Text = "Generate Strings";
            // 
            // fromXMLToolStripMenuItem
            // 
            this.fromXMLToolStripMenuItem.Name = "fromXMLToolStripMenuItem";
            this.fromXMLToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fromXMLToolStripMenuItem.Text = "From XML";
            this.fromXMLToolStripMenuItem.Click += new System.EventHandler(this.fromXMLToolStripMenuItem_Click);
            // 
            // fromScriptsToolStripMenuItem
            // 
            this.fromScriptsToolStripMenuItem.Name = "fromScriptsToolStripMenuItem";
            this.fromScriptsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fromScriptsToolStripMenuItem.Text = "From Scripts";
            this.fromScriptsToolStripMenuItem.Click += new System.EventHandler(this.fromScriptsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripMenuItem,
            this.hexKeyToolStripMenuItem,
            this.stringKeyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Checked = true;
            this.idToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.idToolStripMenuItem.Text = "ID";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // hexKeyToolStripMenuItem
            // 
            this.hexKeyToolStripMenuItem.Checked = true;
            this.hexKeyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexKeyToolStripMenuItem.Name = "hexKeyToolStripMenuItem";
            this.hexKeyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.hexKeyToolStripMenuItem.Text = "Hex Key";
            this.hexKeyToolStripMenuItem.Click += new System.EventHandler(this.hexKeyToolStripMenuItem_Click);
            // 
            // stringKeyToolStripMenuItem
            // 
            this.stringKeyToolStripMenuItem.Checked = true;
            this.stringKeyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stringKeyToolStripMenuItem.Name = "stringKeyToolStripMenuItem";
            this.stringKeyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.stringKeyToolStripMenuItem.Text = "String Key";
            this.stringKeyToolStripMenuItem.Click += new System.EventHandler(this.stringKeyToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonOpen,
            this.toolStripButtonImport,
            this.toolStripButtonGenerateXML,
            this.toolStripButtonGenerateScripts,
            this.toolStripButtonEncode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.ToolTipText = "Save to CSV file.";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.ToolTipText = "Open CSV file.";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImport.Image")));
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonImport.Text = "Import";
            this.toolStripButtonImport.ToolTipText = "Import existing w3string file.";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // toolStripButtonGenerateXML
            // 
            this.toolStripButtonGenerateXML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateXML.Image")));
            this.toolStripButtonGenerateXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateXML.Name = "toolStripButtonGenerateXML";
            this.toolStripButtonGenerateXML.Size = new System.Drawing.Size(132, 22);
            this.toolStripButtonGenerateXML.Text = "Generate From XML";
            this.toolStripButtonGenerateXML.ToolTipText = "Generate strings from menu XML.";
            this.toolStripButtonGenerateXML.Click += new System.EventHandler(this.toolStripButtonGenerateXML_Click);
            // 
            // toolStripButtonGenerateScripts
            // 
            this.toolStripButtonGenerateScripts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateScripts.Image")));
            this.toolStripButtonGenerateScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateScripts.Name = "toolStripButtonGenerateScripts";
            this.toolStripButtonGenerateScripts.Size = new System.Drawing.Size(143, 22);
            this.toolStripButtonGenerateScripts.Text = "Generate From Scripts";
            this.toolStripButtonGenerateScripts.ToolTipText = "Generate strings from scripts (strings with specified prefix in scripts).";
            this.toolStripButtonGenerateScripts.Click += new System.EventHandler(this.toolStripButtonGenerateScripts_Click);
            // 
            // toolStripButtonEncode
            // 
            this.toolStripButtonEncode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEncode.Image")));
            this.toolStripButtonEncode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEncode.Name = "toolStripButtonEncode";
            this.toolStripButtonEncode.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonEncode.Text = "Encode";
            this.toolStripButtonEncode.ToolTipText = "Encode w3string files.";
            this.toolStripButtonEncode.Click += new System.EventHandler(this.toolStripButtonEncode_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTabs);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dataGridViewStrings);
            this.splitContainerMain.Size = new System.Drawing.Size(1184, 488);
            this.splitContainerMain.SplitterDistance = 25;
            this.splitContainerMain.TabIndex = 2;
            // 
            // splitContainerTabs
            // 
            this.splitContainerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTabs.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTabs.Name = "splitContainerTabs";
            // 
            // splitContainerTabs.Panel1
            // 
            this.splitContainerTabs.Panel1.Controls.Add(this.tabControlLanguages);
            // 
            // splitContainerTabs.Panel2
            // 
            this.splitContainerTabs.Panel2.Controls.Add(this.comboBoxLanguagesMode);
            this.splitContainerTabs.Size = new System.Drawing.Size(1184, 25);
            this.splitContainerTabs.SplitterDistance = 1006;
            this.splitContainerTabs.TabIndex = 0;
            // 
            // tabControlLanguages
            // 
            this.tabControlLanguages.Controls.Add(this.tabPageAllLanguages);
            this.tabControlLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLanguages.Location = new System.Drawing.Point(0, 0);
            this.tabControlLanguages.Name = "tabControlLanguages";
            this.tabControlLanguages.SelectedIndex = 0;
            this.tabControlLanguages.Size = new System.Drawing.Size(1006, 25);
            this.tabControlLanguages.TabIndex = 0;
            this.tabControlLanguages.Selected += new System.Windows.Forms.TabControlEventHandler(tabControlLanguages_Selected);
            // 
            // tabPageAllLanguages
            // 
            this.tabPageAllLanguages.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllLanguages.Name = "tabPageAllLanguages";
            this.tabPageAllLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllLanguages.Size = new System.Drawing.Size(998, 0);
            this.tabPageAllLanguages.TabIndex = 0;
            this.tabPageAllLanguages.Text = "All Languages";
            this.tabPageAllLanguages.UseVisualStyleBackColor = true;
            // 
            // comboBoxLanguagesMode
            // 
            this.comboBoxLanguagesMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLanguagesMode.FormattingEnabled = true;
            this.comboBoxLanguagesMode.Items.AddRange(new object[] {
            "All Languages",
            "Separate Languages"});
            this.comboBoxLanguagesMode.Location = new System.Drawing.Point(15, 0);
            this.comboBoxLanguagesMode.Name = "comboBoxLanguagesMode";
            this.comboBoxLanguagesMode.Size = new System.Drawing.Size(156, 21);
            this.comboBoxLanguagesMode.TabIndex = 0;
            this.comboBoxLanguagesMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguagesMode_SelectedIndexChanged);
            // 
            // dataGridViewStrings
            // 
            this.dataGridViewStrings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStrings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStrings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnHexKey,
            this.ColumnStringKey,
            this.ColumnLocalisation});
            this.dataGridViewStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStrings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStrings.Name = "dataGridViewStrings";
            this.dataGridViewStrings.Size = new System.Drawing.Size(1184, 459);
            this.dataGridViewStrings.TabIndex = 0;
            this.dataGridViewStrings.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStrings_CellValidated);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnHexKey
            // 
            this.ColumnHexKey.HeaderText = "Hex key";
            this.ColumnHexKey.Name = "ColumnHexKey";
            this.ColumnHexKey.Visible = false;
            // 
            // ColumnStringKey
            // 
            this.ColumnStringKey.HeaderText = "String Key";
            this.ColumnStringKey.Name = "ColumnStringKey";
            // 
            // ColumnLocalisation
            // 
            this.ColumnLocalisation.HeaderText = "Localisation";
            this.ColumnLocalisation.Name = "ColumnLocalisation";
            // 
            // textBoxModID
            // 
            this.textBoxModID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModID.Location = new System.Drawing.Point(1025, 25);
            this.textBoxModID.MaxLength = 0;
            this.textBoxModID.Name = "textBoxModID";
            this.textBoxModID.Size = new System.Drawing.Size(100, 20);
            this.textBoxModID.TabIndex = 3;
            this.textBoxModID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxModID_KeyDown);
            this.textBoxModID.Leave += new System.EventHandler(this.textBoxModID_Leave);
            // 
            // labelModID
            // 
            this.labelModID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModID.AutoSize = true;
            this.labelModID.Location = new System.Drawing.Point(832, 25);
            this.labelModID.Name = "labelModID";
            this.labelModID.Size = new System.Drawing.Size(187, 13);
            this.labelModID.TabIndex = 4;
            this.labelModID.Text = "Mod ID (separate multiple IDs with \";\")";
            // 
            // frmStringsGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 537);
            this.Controls.Add(this.labelModID);
            this.Controls.Add(this.textBoxModID);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 0);
            this.Name = "frmStringsGui";
            this.Text = "Automated Strings GUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerTabs.Panel1.ResumeLayout(false);
            this.splitContainerTabs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabs)).EndInit();
            this.splitContainerTabs.ResumeLayout(false);
            this.tabControlLanguages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStrings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateStringsToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
		private System.Windows.Forms.ToolStripButton toolStripButtonGenerateXML;
		private System.Windows.Forms.ToolStripButton toolStripButtonGenerateScripts;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainerTabs;
		private System.Windows.Forms.TabControl tabControlLanguages;
		private System.Windows.Forms.TabPage tabPageAllLanguages;
		private System.Windows.Forms.ComboBox comboBoxLanguagesMode;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromScriptsToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridViewStrings;
        private System.Windows.Forms.TextBox textBoxModID;
        private System.Windows.Forms.Label labelModID;
        private System.Windows.Forms.ToolStripButton toolStripButtonEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHexKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStringKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalisation;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringKeyToolStripMenuItem;
    }
}