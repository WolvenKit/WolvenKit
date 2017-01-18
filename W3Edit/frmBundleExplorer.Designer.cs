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
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txPath = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressionRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressiontype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // lblFilePath
            // 
            this.lblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(14, 438);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(34, 13);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File(s)";
            // 
            // txPath
            // 
            this.txPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPath.Location = new System.Drawing.Point(54, 435);
            this.txPath.Name = "txPath";
            this.txPath.Size = new System.Drawing.Size(623, 20);
            this.txPath.TabIndex = 2;
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOpen.Location = new System.Drawing.Point(572, 468);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(105, 23);
            this.btOpen.TabIndex = 3;
            this.btOpen.Text = "Add to Mod";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(12, 468);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // fileListView
            // 
            this.fileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileSize,
            this.colCompressionRatio,
            this.colCompressiontype,
            this.colTimeStamp});
            this.fileListView.FullRowSelect = true;
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(12, 78);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(665, 351);
            this.fileListView.SmallImageList = this.treeImages;
            this.fileListView.TabIndex = 5;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileListView_ItemSelectionChanged);
            this.fileListView.SelectedIndexChanged += new System.EventHandler(this.fileListView_SelectedIndexChanged);
            this.fileListView.DoubleClick += new System.EventHandler(this.fileListView_DoubleClick);
            this.fileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileListView_MouseDoubleClick);
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
            // pathPanel
            // 
            this.pathPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathPanel.Location = new System.Drawing.Point(12, 12);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(665, 20);
            this.pathPanel.TabIndex = 6;
            this.pathPanel.Click += new System.EventHandler(this.pathPanel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(452, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Deselect all";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmBundleExplorer
            // 
            this.AcceptButton = this.btOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(689, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pathPanel);
            this.Controls.Add(this.fileListView);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.txPath);
            this.Controls.Add(this.lblFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBundleExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bundle Explorer";
            this.Load += new System.EventHandler(this.frmBundleExplorer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txPath;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ImageList treeImages;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.Panel pathPanel;
        private System.Windows.Forms.ColumnHeader colCompressionRatio;
        private System.Windows.Forms.ColumnHeader colCompressiontype;
        private System.Windows.Forms.ColumnHeader colTimeStamp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}