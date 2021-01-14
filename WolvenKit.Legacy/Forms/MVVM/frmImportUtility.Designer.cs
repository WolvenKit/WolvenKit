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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportUtility));
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnSelected = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnImportType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTexturegroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
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
            this.objectListView.CellPadding = new System.Drawing.Rectangle(6, 0, 6, 0);
            this.objectListView.CheckBoxes = true;
            this.objectListView.CheckedAspectName = "IsSelected";
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnSelected,
            this.olvColumnName,
            this.olvColumnImportType,
            this.olvColumnTexturegroup});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.HasCollapsibleGroups = false;
            this.objectListView.HeaderMinimumHeight = 30;
            this.objectListView.HideSelection = false;
            this.objectListView.Location = new System.Drawing.Point(0, 35);
            this.objectListView.Name = "objectListView";
            this.objectListView.RowHeight = 20;
            this.objectListView.ShowGroups = false;
            this.objectListView.Size = new System.Drawing.Size(801, 423);
            this.objectListView.TabIndex = 0;
            this.objectListView.UseAlternatingBackColors = true;
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
            this.olvColumnSelected.MaximumWidth = 28;
            this.olvColumnSelected.MinimumWidth = 28;
            this.olvColumnSelected.Text = "";
            this.olvColumnSelected.Width = 28;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Groupable = false;
            this.olvColumnName.IsEditable = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 38;
            // 
            // olvColumnImportType
            // 
            this.olvColumnImportType.AspectName = "ImportType";
            this.olvColumnImportType.FillsFreeSpace = true;
            this.olvColumnImportType.Groupable = false;
            this.olvColumnImportType.MaximumWidth = 90;
            this.olvColumnImportType.Sortable = false;
            this.olvColumnImportType.Text = "File Type";
            this.olvColumnImportType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnImportType.Width = 38;
            // 
            // olvColumnTexturegroup
            // 
            this.olvColumnTexturegroup.AspectName = "TextureGroup";
            this.olvColumnTexturegroup.FillsFreeSpace = true;
            this.olvColumnTexturegroup.Groupable = false;
            this.olvColumnTexturegroup.MaximumWidth = 180;
            this.olvColumnTexturegroup.Text = "Texturegroup";
            this.olvColumnTexturegroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnTexturegroup.Width = 38;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonImport,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh,
            this.toolStripComboBox1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolStrip.Size = new System.Drawing.Size(800, 38);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.Image = global::WolvenKit.Properties.Resources.ImportPackage_16x;
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(71, 28);
            this.toolStripButtonImport.Text = "Import";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::WolvenKit.Properties.Resources.Refresh_16x;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(159, 28);
            this.toolStripButtonRefresh.Text = "Auto-Fill Texturegroups";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Wcc_lite",
            "WolvenKit"});
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private BrightIdeasSoftware.OLVColumn olvColumnImportType;
        private BrightIdeasSoftware.OLVColumn olvColumnTexturegroup;
        private BrightIdeasSoftware.OLVColumn olvColumnSelected;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}