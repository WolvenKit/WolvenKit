namespace WolvenKit.Forms
{
    partial class frmRadish
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadish));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_ReCreateLinks = new System.Windows.Forms.ToolStripButton();
            this.tsb_LaunchQuestEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_RunSelected = new System.Windows.Forms.ToolStripButton();
            this.tsb_FullRebuild = new System.Windows.Forms.ToolStripButton();
            this.tsb_BuildUntilPack = new System.Windows.Forms.ToolStripButton();
            this.tsb_Pack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_StartGame = new System.Windows.Forms.ToolStripButton();
            this.olvColumnSelected = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnImportType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTexturegroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.WorkflowobjectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.WorkflowcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemovetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainerBats = new System.Windows.Forms.SplitContainer();
            this.PropertyGridSettings = new System.Windows.Forms.PropertyGrid();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkflowobjectListView)).BeginInit();
            this.WorkflowcontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBats)).BeginInit();
            this.splitContainerBats.Panel1.SuspendLayout();
            this.splitContainerBats.Panel2.SuspendLayout();
            this.splitContainerBats.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_ReCreateLinks,
            this.tsb_LaunchQuestEditor,
            this.toolStripSeparator2,
            this.tsb_RunSelected,
            this.tsb_FullRebuild,
            this.tsb_BuildUntilPack,
            this.tsb_Pack,
            this.toolStripSeparator1,
            this.tsb_StartGame});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsb_ReCreateLinks
            // 
            this.tsb_ReCreateLinks.Image = global::WolvenKit.Properties.Resources.LinkValidator_16x;
            this.tsb_ReCreateLinks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ReCreateLinks.Name = "tsb_ReCreateLinks";
            this.tsb_ReCreateLinks.Size = new System.Drawing.Size(99, 22);
            this.tsb_ReCreateLinks.Text = "Recreate links";
            this.tsb_ReCreateLinks.Click += new System.EventHandler(this.tsb_ReCreateLinks_Click);
            // 
            // tsb_LaunchQuestEditor
            // 
            this.tsb_LaunchQuestEditor.Image = global::WolvenKit.Properties.Resources.EditTableRow_16x;
            this.tsb_LaunchQuestEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_LaunchQuestEditor.Name = "tsb_LaunchQuestEditor";
            this.tsb_LaunchQuestEditor.Size = new System.Drawing.Size(132, 22);
            this.tsb_LaunchQuestEditor.Text = "Launch quest editor";
            this.tsb_LaunchQuestEditor.Click += new System.EventHandler(this.tsb_LaunchQuestEditor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_RunSelected
            // 
            this.tsb_RunSelected.Image = global::WolvenKit.Properties.Resources.Run_16x;
            this.tsb_RunSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_RunSelected.Name = "tsb_RunSelected";
            this.tsb_RunSelected.Size = new System.Drawing.Size(100, 22);
            this.tsb_RunSelected.Text = "Run workflow";
            this.tsb_RunSelected.Click += new System.EventHandler(this.tsb_RunSelected_Click);
            // 
            // tsb_FullRebuild
            // 
            this.tsb_FullRebuild.Image = global::WolvenKit.Properties.Resources.RunUpdate_16x;
            this.tsb_FullRebuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FullRebuild.Name = "tsb_FullRebuild";
            this.tsb_FullRebuild.Size = new System.Drawing.Size(86, 22);
            this.tsb_FullRebuild.Text = "Full rebuild";
            this.tsb_FullRebuild.Click += new System.EventHandler(this.tsb_FullRebuild_Click);
            // 
            // tsb_BuildUntilPack
            // 
            this.tsb_BuildUntilPack.Image = global::WolvenKit.Properties.Resources.RunPause_16x;
            this.tsb_BuildUntilPack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BuildUntilPack.Name = "tsb_BuildUntilPack";
            this.tsb_BuildUntilPack.Size = new System.Drawing.Size(109, 22);
            this.tsb_BuildUntilPack.Text = "Build until pack";
            this.tsb_BuildUntilPack.Click += new System.EventHandler(this.tsb_BuildUntilPack_Click);
            // 
            // tsb_Pack
            // 
            this.tsb_Pack.Image = global::WolvenKit.Properties.Resources.package_16xLG;
            this.tsb_Pack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Pack.Name = "tsb_Pack";
            this.tsb_Pack.Size = new System.Drawing.Size(52, 22);
            this.tsb_Pack.Text = "Pack";
            this.tsb_Pack.Click += new System.EventHandler(this.tsb_Pack_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_StartGame
            // 
            this.tsb_StartGame.Image = global::WolvenKit.Properties.Resources.package_16xLG;
            this.tsb_StartGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_StartGame.Name = "tsb_StartGame";
            this.tsb_StartGame.Size = new System.Drawing.Size(85, 22);
            this.tsb_StartGame.Text = "Start Game";
            this.tsb_StartGame.Click += new System.EventHandler(this.tsb_StartGame_Click);
            // 
            // olvColumnSelected
            // 
            this.olvColumnSelected.AspectName = "IsSelected";
            this.olvColumnSelected.CheckBoxes = true;
            this.olvColumnSelected.Groupable = false;
            this.olvColumnSelected.HeaderCheckBox = true;
            this.olvColumnSelected.Text = "Import";
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Groupable = false;
            this.olvColumnName.IsEditable = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 300;
            // 
            // olvColumnImportType
            // 
            this.olvColumnImportType.AspectName = "ImportType";
            this.olvColumnImportType.Groupable = false;
            this.olvColumnImportType.Text = "Import as";
            // 
            // olvColumnTexturegroup
            // 
            this.olvColumnTexturegroup.AspectName = "Texturegroup";
            this.olvColumnTexturegroup.FillsFreeSpace = true;
            this.olvColumnTexturegroup.Groupable = false;
            this.olvColumnTexturegroup.Text = "Texturegroup";
            this.olvColumnTexturegroup.Width = 150;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.PropertyGrid);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBats);
            this.splitContainerMain.Size = new System.Drawing.Size(1013, 644);
            this.splitContainerMain.SplitterDistance = 370;
            this.splitContainerMain.TabIndex = 3;
            // 
            // WorkflowobjectListView
            // 
            this.WorkflowobjectListView.AllColumns.Add(this.olvColumn2);
            this.WorkflowobjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2});
            this.WorkflowobjectListView.ContextMenuStrip = this.WorkflowcontextMenuStrip;
            this.WorkflowobjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.WorkflowobjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkflowobjectListView.FullRowSelect = true;
            this.WorkflowobjectListView.HasCollapsibleGroups = false;
            this.WorkflowobjectListView.HideSelection = false;
            this.WorkflowobjectListView.Location = new System.Drawing.Point(0, 0);
            this.WorkflowobjectListView.Name = "WorkflowobjectListView";
            this.WorkflowobjectListView.ShowGroups = false;
            this.WorkflowobjectListView.Size = new System.Drawing.Size(639, 321);
            this.WorkflowobjectListView.TabIndex = 20;
            this.WorkflowobjectListView.UseAlternatingBackColors = true;
            this.WorkflowobjectListView.UseCompatibleStateImageBehavior = false;
            this.WorkflowobjectListView.View = System.Windows.Forms.View.Details;
            this.WorkflowobjectListView.SelectionChanged += new System.EventHandler(this.WorkflowobjectListView_SelectionChanged);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Name";
            // 
            // WorkflowcontextMenuStrip
            // 
            this.WorkflowcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddtoolStripMenuItem,
            this.RemovetoolStripMenuItem});
            this.WorkflowcontextMenuStrip.Name = "contextMenuStrip1";
            this.WorkflowcontextMenuStrip.Size = new System.Drawing.Size(170, 48);
            this.WorkflowcontextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.WorkflowcontextMenuStrip_Opening);
            // 
            // AddtoolStripMenuItem
            // 
            this.AddtoolStripMenuItem.Name = "AddtoolStripMenuItem";
            this.AddtoolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.AddtoolStripMenuItem.Text = "Add workflow";
            this.AddtoolStripMenuItem.Click += new System.EventHandler(this.AddtoolStripMenuItem_Click);
            // 
            // RemovetoolStripMenuItem
            // 
            this.RemovetoolStripMenuItem.Name = "RemovetoolStripMenuItem";
            this.RemovetoolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.RemovetoolStripMenuItem.Text = "Remove workflow";
            this.RemovetoolStripMenuItem.Click += new System.EventHandler(this.RemovetoolStripMenuItem_Click);
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(370, 644);
            this.PropertyGrid.TabIndex = 19;
            // 
            // splitContainerBats
            // 
            this.splitContainerBats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBats.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBats.Name = "splitContainerBats";
            this.splitContainerBats.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBats.Panel1
            // 
            this.splitContainerBats.Panel1.Controls.Add(this.WorkflowobjectListView);
            // 
            // splitContainerBats.Panel2
            // 
            this.splitContainerBats.Panel2.Controls.Add(this.PropertyGridSettings);
            this.splitContainerBats.Size = new System.Drawing.Size(639, 644);
            this.splitContainerBats.SplitterDistance = 321;
            this.splitContainerBats.TabIndex = 3;
            // 
            // PropertyGridSettings
            // 
            this.PropertyGridSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridSettings.Location = new System.Drawing.Point(0, 0);
            this.PropertyGridSettings.Name = "PropertyGridSettings";
            this.PropertyGridSettings.Size = new System.Drawing.Size(639, 319);
            this.PropertyGridSettings.TabIndex = 0;
            this.PropertyGridSettings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGridSettings_PropertyValueChanged);
            this.PropertyGridSettings.SelectedObjectsChanged += new System.EventHandler(this.PropertyGridSettings_SelectedObjectsChanged);
            // 
            // frmRadish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 669);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRadish";
            this.Text = "Radish Tools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRadish_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkflowobjectListView)).EndInit();
            this.WorkflowcontextMenuStrip.ResumeLayout(false);
            this.splitContainerBats.Panel1.ResumeLayout(false);
            this.splitContainerBats.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBats)).EndInit();
            this.splitContainerBats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsb_BuildUntilPack;
        private System.Windows.Forms.ToolStripButton tsb_FullRebuild;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Pack;
        private System.Windows.Forms.ToolStripButton tsb_LaunchQuestEditor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private BrightIdeasSoftware.OLVColumn olvColumnSelected;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnImportType;
        private BrightIdeasSoftware.OLVColumn olvColumnTexturegroup;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerBats;
        private System.Windows.Forms.ToolStripButton tsb_RunSelected;
        private System.Windows.Forms.ToolStripButton tsb_ReCreateLinks;
        private System.Windows.Forms.ToolStripButton tsb_StartGame;
        private System.Windows.Forms.PropertyGrid PropertyGrid;
        private System.Windows.Forms.ContextMenuStrip WorkflowcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddtoolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView WorkflowobjectListView;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.ToolStripMenuItem RemovetoolStripMenuItem;
        private System.Windows.Forms.PropertyGrid PropertyGridSettings;
    }
}