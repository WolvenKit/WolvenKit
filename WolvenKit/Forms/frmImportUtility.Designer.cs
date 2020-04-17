namespace WolvenKit.Forms
{
    partial class frmImportUtility
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
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnSelected = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnImportType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTexturegroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLocalResources = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.olvColumnSelected);
            this.objectListView.AllColumns.Add(this.olvColumnName);
            this.objectListView.AllColumns.Add(this.olvColumnImportType);
            this.objectListView.AllColumns.Add(this.olvColumnTexturegroup);
            this.objectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.objectListView.CheckBoxes = true;
            this.objectListView.CheckedAspectName = "IsSelected";
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnSelected,
            this.olvColumnName,
            this.olvColumnImportType,
            this.olvColumnTexturegroup});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.GridLines = true;
            this.objectListView.HasCollapsibleGroups = false;
            this.objectListView.HeaderUsesThemes = true;
            this.objectListView.HideSelection = false;
            this.objectListView.Location = new System.Drawing.Point(0, 28);
            this.objectListView.Name = "objectListView";
            this.objectListView.ShowGroups = false;
            this.objectListView.Size = new System.Drawing.Size(800, 422);
            this.objectListView.TabIndex = 0;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(this.objectListView_CellEditFinished);
            this.objectListView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.objectListView_FormatRow);
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
            this.olvColumnTexturegroup.Groupable = false;
            this.olvColumnTexturegroup.Text = "Texturegroup";
            this.olvColumnTexturegroup.Width = 150;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLocalResources,
            this.toolStripButtonOpenFolder,
            this.toolStripSeparator2,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonImport});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonLocalResources
            // 
            this.toolStripButtonLocalResources.Image = global::WolvenKit.Properties.Resources.RemoteServer_16x;
            this.toolStripButtonLocalResources.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLocalResources.Name = "toolStripButtonLocalResources";
            this.toolStripButtonLocalResources.Size = new System.Drawing.Size(98, 22);
            this.toolStripButtonLocalResources.Text = "Use mod files";
            this.toolStripButtonLocalResources.Click += new System.EventHandler(this.toolStripButtonLocalResources_Click);
            // 
            // toolStripButtonOpenFolder
            // 
            this.toolStripButtonOpenFolder.Image = global::WolvenKit.Properties.Resources.OpenFolder_16x;
            this.toolStripButtonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFolder.Name = "toolStripButtonOpenFolder";
            this.toolStripButtonOpenFolder.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonOpenFolder.Text = "Open folder";
            this.toolStripButtonOpenFolder.Click += new System.EventHandler(this.toolStripButtonOpenFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::WolvenKit.Properties.Resources.Refresh_16x;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(148, 22);
            this.toolStripButtonRefresh.Text = "Auto-fill texturegroups";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.Image = global::WolvenKit.Properties.Resources.ImportPackage_16x;
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonImport.Text = "Import";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // frmImportUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.objectListView);
            this.Name = "frmImportUtility";
            this.Text = "Import Utility";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private System.Windows.Forms.ToolStripButton toolStripButtonLocalResources;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private BrightIdeasSoftware.OLVColumn olvColumnImportType;
        private BrightIdeasSoftware.OLVColumn olvColumnTexturegroup;
        private BrightIdeasSoftware.OLVColumn olvColumnSelected;
    }
}