namespace W3Edit
{
    partial class frmBundleExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBundleExplorer));
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.btOpen = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressionRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressiontype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filebrowserMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearFiles = new System.Windows.Forms.Button();
            this.MarkSelected = new System.Windows.Forms.Button();
            this.filetypeCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pathlistview = new System.Windows.Forms.ListView();
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filebrowserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "genericFile");
            this.treeImages.Images.SetKeyName(1, "normalFolder");
            this.treeImages.Images.SetKeyName(2, "openFolder");
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOpen.Location = new System.Drawing.Point(12, 452);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(145, 23);
            this.btOpen.TabIndex = 3;
            this.btOpen.TabStop = false;
            this.btOpen.Text = "Add marked files to mod";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // fileListView
            // 
            this.fileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListView.CausesValidation = false;
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileSize,
            this.colCompressionRatio,
            this.colCompressiontype,
            this.colTimeStamp});
            this.fileListView.ContextMenuStrip = this.filebrowserMenuStrip;
            this.fileListView.FullRowSelect = true;
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(12, 78);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(678, 369);
            this.fileListView.SmallImageList = this.treeImages;
            this.fileListView.TabIndex = 5;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileListView_KeyDown);
            this.fileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileListView_MouseDoubleClick);
            this.fileListView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.fileListView_PreviewKeyDown);
            // 
            // colFileName
            // 
            this.colFileName.Text = "Name";
            this.colFileName.Width = 322;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "Size";
            this.colFileSize.Width = 65;
            // 
            // colCompressionRatio
            // 
            this.colCompressionRatio.Text = "Compression Ratio";
            this.colCompressionRatio.Width = 108;
            // 
            // colCompressiontype
            // 
            this.colCompressiontype.Text = "Compression Type";
            this.colCompressiontype.Width = 83;
            // 
            // colTimeStamp
            // 
            this.colTimeStamp.Text = "TimeStamp";
            this.colTimeStamp.Width = 77;
            // 
            // filebrowserMenuStrip
            // 
            this.filebrowserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPathToolStripMenuItem,
            this.markToolStripMenuItem});
            this.filebrowserMenuStrip.Name = "filebrowserMenuStrip";
            this.filebrowserMenuStrip.Size = new System.Drawing.Size(130, 48);
            // 
            // copyPathToolStripMenuItem
            // 
            this.copyPathToolStripMenuItem.Name = "copyPathToolStripMenuItem";
            this.copyPathToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.copyPathToolStripMenuItem.Text = "Copy Path";
            this.copyPathToolStripMenuItem.Click += new System.EventHandler(this.copyPathToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // pathPanel
            // 
            this.pathPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pathPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathPanel.Location = new System.Drawing.Point(12, 12);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(665, 20);
            this.pathPanel.TabIndex = 6;
            this.pathPanel.Click += new System.EventHandler(this.pathPanel_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBox.CausesValidation = false;
            this.SearchBox.Location = new System.Drawing.Point(72, 43);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(343, 20);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SearchBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filename:";
            // 
            // ClearFiles
            // 
            this.ClearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFiles.Location = new System.Drawing.Point(583, 453);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(105, 23);
            this.ClearFiles.TabIndex = 9;
            this.ClearFiles.TabStop = false;
            this.ClearFiles.Text = "Unmark selected";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // MarkSelected
            // 
            this.MarkSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkSelected.Location = new System.Drawing.Point(694, 453);
            this.MarkSelected.Name = "MarkSelected";
            this.MarkSelected.Size = new System.Drawing.Size(105, 23);
            this.MarkSelected.TabIndex = 10;
            this.MarkSelected.TabStop = false;
            this.MarkSelected.Text = "Mark selected";
            this.MarkSelected.UseVisualStyleBackColor = true;
            this.MarkSelected.Click += new System.EventHandler(this.MarkSelected_Click);
            // 
            // filetypeCB
            // 
            this.filetypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filetypeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filetypeCB.FormattingEnabled = true;
            this.filetypeCB.Items.AddRange(new object[] {
            "Any"});
            this.filetypeCB.Location = new System.Drawing.Point(461, 43);
            this.filetypeCB.Name = "filetypeCB";
            this.filetypeCB.Size = new System.Drawing.Size(121, 21);
            this.filetypeCB.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(591, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marked files:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(472, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 17;
            this.button2.TabStop = false;
            this.button2.Text = "Clear marks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pathlistview
            // 
            this.pathlistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathlistview.CausesValidation = false;
            this.pathlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPath});
            this.pathlistview.FullRowSelect = true;
            this.pathlistview.GridLines = true;
            this.pathlistview.HideSelection = false;
            this.pathlistview.Location = new System.Drawing.Point(696, 41);
            this.pathlistview.Name = "pathlistview";
            this.pathlistview.ShowItemToolTips = true;
            this.pathlistview.Size = new System.Drawing.Size(105, 406);
            this.pathlistview.SmallImageList = this.treeImages;
            this.pathlistview.TabIndex = 14;
            this.pathlistview.UseCompatibleStateImageBehavior = false;
            this.pathlistview.View = System.Windows.Forms.View.Details;
            // 
            // columnPath
            // 
            this.columnPath.Text = "Path";
            this.columnPath.Width = 105;
            // 
            // frmBundleExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathlistview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filetypeCB);
            this.Controls.Add(this.MarkSelected);
            this.Controls.Add(this.ClearFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pathPanel);
            this.Controls.Add(this.fileListView);
            this.Controls.Add(this.btOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBundleExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bundle Explorer";
            this.Load += new System.EventHandler(this.frmBundleExplorer_Load);
            this.filebrowserMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ImageList treeImages;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.ColumnHeader colCompressionRatio;
        private System.Windows.Forms.ColumnHeader colCompressiontype;
        private System.Windows.Forms.ColumnHeader colTimeStamp;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button MarkSelected;
        private System.Windows.Forms.ComboBox filetypeCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView pathlistview;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ContextMenuStrip filebrowserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
    }
}