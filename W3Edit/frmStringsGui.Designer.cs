namespace W3Edit
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
			this.generateStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGenerateXML = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGenerateScripts = new System.Windows.Forms.ToolStripButton();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.splitContainerTabs = new System.Windows.Forms.SplitContainer();
			this.tabControlLanguages = new System.Windows.Forms.TabControl();
			this.tabPageAllLanguages = new System.Windows.Forms.TabPage();
			this.comboBoxLanguagesMode = new System.Windows.Forms.ComboBox();
			this.dataGridViewStrings = new System.Windows.Forms.DataGridView();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStringKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLocalisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.generateStringsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
			this.fromXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.fromXMLToolStripMenuItem.Text = "From XML";
			this.fromXMLToolStripMenuItem.Click += new System.EventHandler(this.fromXMLToolStripMenuItem_Click);
			// 
			// fromScriptsToolStripMenuItem
			// 
			this.fromScriptsToolStripMenuItem.Name = "fromScriptsToolStripMenuItem";
			this.fromScriptsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.fromScriptsToolStripMenuItem.Text = "From Scripts";
			this.fromScriptsToolStripMenuItem.Click += new System.EventHandler(this.fromScriptsToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonOpen,
            this.toolStripButtonGenerateXML,
            this.toolStripButtonGenerateScripts});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1086, 25);
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
			this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(56, 22);
			this.toolStripButtonOpen.Text = "Open";
			this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
			// 
			// toolStripButtonGenerateXML
			// 
			this.toolStripButtonGenerateXML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateXML.Image")));
			this.toolStripButtonGenerateXML.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGenerateXML.Name = "toolStripButtonGenerateXML";
			this.toolStripButtonGenerateXML.Size = new System.Drawing.Size(132, 22);
			this.toolStripButtonGenerateXML.Text = "Generate From XML";
			this.toolStripButtonGenerateXML.Click += new System.EventHandler(this.toolStripButtonGenerateXML_Click);
			// 
			// toolStripButtonGenerateScripts
			// 
			this.toolStripButtonGenerateScripts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateScripts.Image")));
			this.toolStripButtonGenerateScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGenerateScripts.Name = "toolStripButtonGenerateScripts";
			this.toolStripButtonGenerateScripts.Size = new System.Drawing.Size(143, 22);
			this.toolStripButtonGenerateScripts.Text = "Generate From Scripts";
			this.toolStripButtonGenerateScripts.Click += new System.EventHandler(this.toolStripButtonGenerateScripts_Click);
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
			this.splitContainerMain.Size = new System.Drawing.Size(1086, 488);
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
			this.splitContainerTabs.Size = new System.Drawing.Size(1086, 25);
			this.splitContainerTabs.SplitterDistance = 923;
			this.splitContainerTabs.TabIndex = 0;
			// 
			// tabControlLanguages
			// 
			this.tabControlLanguages.Controls.Add(this.tabPageAllLanguages);
			this.tabControlLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlLanguages.Location = new System.Drawing.Point(0, 0);
			this.tabControlLanguages.Name = "tabControlLanguages";
			this.tabControlLanguages.SelectedIndex = 0;
			this.tabControlLanguages.Size = new System.Drawing.Size(923, 25);
			this.tabControlLanguages.TabIndex = 0;
			// 
			// tabPageAllLanguages
			// 
			this.tabPageAllLanguages.Location = new System.Drawing.Point(4, 22);
			this.tabPageAllLanguages.Name = "tabPageAllLanguages";
			this.tabPageAllLanguages.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAllLanguages.Size = new System.Drawing.Size(915, 0);
			this.tabPageAllLanguages.TabIndex = 0;
			this.tabPageAllLanguages.Text = "All Languages";
			this.tabPageAllLanguages.UseVisualStyleBackColor = true;
			// 
			// comboBoxLanguagesMode
			// 
			this.comboBoxLanguagesMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxLanguagesMode.FormattingEnabled = true;
			this.comboBoxLanguagesMode.Items.AddRange(new object[] {
            "All Languages",
            "Separate Languages"});
			this.comboBoxLanguagesMode.Location = new System.Drawing.Point(0, 0);
			this.comboBoxLanguagesMode.Name = "comboBoxLanguagesMode";
			this.comboBoxLanguagesMode.Size = new System.Drawing.Size(159, 21);
			this.comboBoxLanguagesMode.TabIndex = 0;
			this.comboBoxLanguagesMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguagesMode_SelectedIndexChanged);
			// 
			// dataGridViewStrings
			// 
			this.dataGridViewStrings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStrings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStrings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnStringKey,
            this.ColumnLocalisation});
			this.dataGridViewStrings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewStrings.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewStrings.Name = "dataGridViewStrings";
			this.dataGridViewStrings.Size = new System.Drawing.Size(1086, 459);
			this.dataGridViewStrings.TabIndex = 0;
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
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
			// frmStringsGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 537);
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStringKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalisation;
	}
}