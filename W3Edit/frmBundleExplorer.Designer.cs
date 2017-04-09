using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmBundleExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.markAllFilesOfFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.clearSearch = new System.Windows.Forms.Button();
            this.regexCheckbox = new System.Windows.Forms.CheckBox();
            this.currentfolderCheckBox = new System.Windows.Forms.CheckBox();
            this.caseCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.filebrowserMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOpen.Location = new System.Drawing.Point(16, 613);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(193, 28);
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
            this.fileListView.LargeImageList = this.treeImages;
            this.fileListView.Location = new System.Drawing.Point(16, 150);
            this.fileListView.Margin = new System.Windows.Forms.Padding(4);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(903, 456);
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
            this.filebrowserMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filebrowserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPathToolStripMenuItem,
            this.markToolStripMenuItem,
            this.markAllFilesOfFolderToolStripMenuItem});
            this.filebrowserMenuStrip.Name = "filebrowserMenuStrip";
            this.filebrowserMenuStrip.Size = new System.Drawing.Size(231, 82);
            // 
            // copyPathToolStripMenuItem
            // 
            this.copyPathToolStripMenuItem.Name = "copyPathToolStripMenuItem";
            this.copyPathToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.copyPathToolStripMenuItem.Text = "Copy Path";
            this.copyPathToolStripMenuItem.Click += new System.EventHandler(this.copyPathToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // markAllFilesOfFolderToolStripMenuItem
            // 
            this.markAllFilesOfFolderToolStripMenuItem.Name = "markAllFilesOfFolderToolStripMenuItem";
            this.markAllFilesOfFolderToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.markAllFilesOfFolderToolStripMenuItem.Text = "Mark all files of folder";
            this.markAllFilesOfFolderToolStripMenuItem.Click += new System.EventHandler(this.markAllFilesOfFolderToolStripMenuItem_Click);
            // 
            // pathPanel
            // 
            this.pathPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pathPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathPanel.Location = new System.Drawing.Point(16, 51);
            this.pathPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(886, 24);
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
            this.SearchBox.Location = new System.Drawing.Point(96, 89);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(416, 22);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SearchBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // ClearFiles
            // 
            this.ClearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFiles.Location = new System.Drawing.Point(777, 614);
            this.ClearFiles.Margin = new System.Windows.Forms.Padding(4);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(140, 28);
            this.ClearFiles.TabIndex = 9;
            this.ClearFiles.TabStop = false;
            this.ClearFiles.Text = "Unmark selected";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // MarkSelected
            // 
            this.MarkSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkSelected.Location = new System.Drawing.Point(925, 614);
            this.MarkSelected.Margin = new System.Windows.Forms.Padding(4);
            this.MarkSelected.Name = "MarkSelected";
            this.MarkSelected.Size = new System.Drawing.Size(140, 28);
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
            this.filetypeCB.Location = new System.Drawing.Point(615, 89);
            this.filetypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.filetypeCB.Name = "filetypeCB";
            this.filetypeCB.Size = new System.Drawing.Size(160, 24);
            this.filetypeCB.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(788, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marked files:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(629, 614);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 28);
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
            this.pathlistview.LargeImageList = this.treeImages;
            this.pathlistview.Location = new System.Drawing.Point(928, 80);
            this.pathlistview.Margin = new System.Windows.Forms.Padding(4);
            this.pathlistview.Name = "pathlistview";
            this.pathlistview.ShowItemToolTips = true;
            this.pathlistview.Size = new System.Drawing.Size(139, 525);
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
            // clearSearch
            // 
            this.clearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearch.BackColor = System.Drawing.Color.Transparent;
            this.clearSearch.BackgroundImage = global::WolvenKit.Properties.Resources.ExitIcon;
            this.clearSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearSearch.Location = new System.Drawing.Point(524, 85);
            this.clearSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(29, 30);
            this.clearSearch.TabIndex = 18;
            this.clearSearch.UseVisualStyleBackColor = false;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // regexCheckbox
            // 
            this.regexCheckbox.AutoSize = true;
            this.regexCheckbox.Location = new System.Drawing.Point(23, 121);
            this.regexCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.regexCheckbox.Name = "regexCheckbox";
            this.regexCheckbox.Size = new System.Drawing.Size(70, 21);
            this.regexCheckbox.TabIndex = 21;
            this.regexCheckbox.Text = "Regex";
            this.regexCheckbox.UseVisualStyleBackColor = true;
            // 
            // currentfolderCheckBox
            // 
            this.currentfolderCheckBox.AutoSize = true;
            this.currentfolderCheckBox.Location = new System.Drawing.Point(107, 121);
            this.currentfolderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentfolderCheckBox.Name = "currentfolderCheckBox";
            this.currentfolderCheckBox.Size = new System.Drawing.Size(196, 21);
            this.currentfolderCheckBox.TabIndex = 22;
            this.currentfolderCheckBox.Text = "Search from current folder";
            this.currentfolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // caseCheckBox
            // 
            this.caseCheckBox.AutoSize = true;
            this.caseCheckBox.Location = new System.Drawing.Point(316, 121);
            this.caseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.caseCheckBox.Name = "caseCheckBox";
            this.caseCheckBox.Size = new System.Drawing.Size(121, 21);
            this.caseCheckBox.TabIndex = 23;
            this.caseCheckBox.Text = "Case sensitive";
            this.caseCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.editToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.tabsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Enabled = false;
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.Enabled = false;
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.largeIconToolStripMenuItem.Text = "LargeIcon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.smallIconToolStripMenuItem.Text = "SmallIcon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "genericFile");
            this.treeImages.Images.SetKeyName(1, "normalFolder");
            this.treeImages.Images.SetKeyName(2, "openFolder");
            this.treeImages.Images.SetKeyName(3, "csv");
            this.treeImages.Images.SetKeyName(4, "redswf");
            this.treeImages.Images.SetKeyName(5, "env");
            this.treeImages.Images.SetKeyName(6, "journal");
            this.treeImages.Images.SetKeyName(7, "w2beh");
            this.treeImages.Images.SetKeyName(8, "xml");
            this.treeImages.Images.SetKeyName(9, "w2behtree");
            this.treeImages.Images.SetKeyName(10, "w2scene");
            this.treeImages.Images.SetKeyName(11, "w2p");
            this.treeImages.Images.SetKeyName(12, "w2rig");
            // 
            // frmBundleExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 646);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.caseCheckBox);
            this.Controls.Add(this.currentfolderCheckBox);
            this.Controls.Add(this.regexCheckbox);
            this.Controls.Add(this.clearSearch);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBundleExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asset browser";
            this.Load += new System.EventHandler(this.frmBundleExplorer_Load);
            this.filebrowserMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btOpen;
        private ListView fileListView;
        private ColumnHeader colFileName;
        private ColumnHeader colFileSize;
        private Panel pathPanel;
        private ColumnHeader colCompressionRatio;
        private ColumnHeader colCompressiontype;
        private ColumnHeader colTimeStamp;
        private TextBox SearchBox;
        private Label label1;
        private Button ClearFiles;
        private Button MarkSelected;
        private ComboBox filetypeCB;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private ListView pathlistview;
        private ColumnHeader columnPath;
        private ContextMenuStrip filebrowserMenuStrip;
        private ToolStripMenuItem copyPathToolStripMenuItem;
        private ToolStripMenuItem markToolStripMenuItem;
        private Button clearSearch;
        private CheckBox regexCheckbox;
        private CheckBox currentfolderCheckBox;
        private CheckBox caseCheckBox;
        private ToolStripMenuItem markAllFilesOfFolderToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
        private ToolStripMenuItem smallIconToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem bookmarkToolStripMenuItem;
        private ToolStripMenuItem tabsToolStripMenuItem;
        private ImageList treeImages;
    }
}