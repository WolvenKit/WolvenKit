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
			this.generateStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGenerateXML = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonGenerateScripts = new System.Windows.Forms.ToolStripButton();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.SuspendLayout();
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
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// generateStringsToolStripMenuItem
			// 
			this.generateStringsToolStripMenuItem.Name = "generateStringsToolStripMenuItem";
			this.generateStringsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
			this.generateStringsToolStripMenuItem.Text = "Generate Strings";
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
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(56, 22);
			this.toolStripButtonOpen.Text = "Open";
			// 
			// toolStripButtonGenerateXML
			// 
			this.toolStripButtonGenerateXML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateXML.Image")));
			this.toolStripButtonGenerateXML.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGenerateXML.Name = "toolStripButtonGenerateXML";
			this.toolStripButtonGenerateXML.Size = new System.Drawing.Size(132, 22);
			this.toolStripButtonGenerateXML.Text = "Generate From XML";
			// 
			// toolStripButtonGenerateScripts
			// 
			this.toolStripButtonGenerateScripts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGenerateScripts.Image")));
			this.toolStripButtonGenerateScripts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonGenerateScripts.Name = "toolStripButtonGenerateScripts";
			this.toolStripButtonGenerateScripts.Size = new System.Drawing.Size(143, 22);
			this.toolStripButtonGenerateScripts.Text = "Generate From Scripts";
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.IsSplitterFixed = true;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainerMain.Size = new System.Drawing.Size(1086, 488);
			this.splitContainerMain.SplitterDistance = 25;
			this.splitContainerMain.TabIndex = 2;
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
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
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
	}
}