using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmAssetBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetBrowser));
            this.btOpen = new System.Windows.Forms.Button();
            this.fileListView = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressionRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompressiontype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filebrowserMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAllFilesOfFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
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
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lExtension = new System.Windows.Forms.Label();
            this.extensionCB = new System.Windows.Forms.ComboBox();
            this.addDLCFile = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.fileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.limitCheckBox = new System.Windows.Forms.CheckBox();
            this.limitUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUncook = new System.Windows.Forms.CheckBox();
            this.checkBoxExport = new System.Windows.Forms.CheckBox();
            this.filebrowserMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).BeginInit();
            this.fileSplitContainer.Panel1.SuspendLayout();
            this.fileSplitContainer.Panel2.SuspendLayout();
            this.fileSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOpen.Location = new System.Drawing.Point(9, 499);
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
            this.fileListView.CausesValidation = false;
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileSize,
            this.colCompressionRatio,
            this.colCompressiontype,
            this.colType});
            this.fileListView.ContextMenuStrip = this.filebrowserMenuStrip;
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.FullRowSelect = true;
            this.fileListView.HideSelection = false;
            this.fileListView.LargeImageList = this.treeImages;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(523, 374);
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
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 77;
            // 
            // filebrowserMenuStrip
            // 
            this.filebrowserMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filebrowserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPathToolStripMenuItem,
            this.markToolStripMenuItem,
            this.markAllFilesOfFolderToolStripMenuItem});
            this.filebrowserMenuStrip.Name = "filebrowserMenuStrip";
            this.filebrowserMenuStrip.Size = new System.Drawing.Size(189, 70);
            // 
            // copyPathToolStripMenuItem
            // 
            this.copyPathToolStripMenuItem.Name = "copyPathToolStripMenuItem";
            this.copyPathToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.copyPathToolStripMenuItem.Text = "Copy Path";
            this.copyPathToolStripMenuItem.Click += new System.EventHandler(this.copyPathToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // markAllFilesOfFolderToolStripMenuItem
            // 
            this.markAllFilesOfFolderToolStripMenuItem.Name = "markAllFilesOfFolderToolStripMenuItem";
            this.markAllFilesOfFolderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.markAllFilesOfFolderToolStripMenuItem.Text = "Mark all files of folder";
            this.markAllFilesOfFolderToolStripMenuItem.Click += new System.EventHandler(this.markAllFilesOfFolderToolStripMenuItem_Click);
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
            this.treeImages.Images.SetKeyName(13, "FolderOpened");
            // 
            // pathPanel
            // 
            this.pathPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pathPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathPanel.Location = new System.Drawing.Point(38, 42);
            this.pathPanel.Name = "pathPanel";
            this.pathPanel.Size = new System.Drawing.Size(762, 20);
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
            this.SearchBox.Location = new System.Drawing.Point(72, 72);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(291, 20);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SearchBox_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // ClearFiles
            // 
            this.ClearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFiles.Location = new System.Drawing.Point(583, 499);
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
            this.MarkSelected.Location = new System.Drawing.Point(694, 499);
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
            this.filetypeCB.Location = new System.Drawing.Point(605, 72);
            this.filetypeCB.Name = "filetypeCB";
            this.filetypeCB.Size = new System.Drawing.Size(104, 21);
            this.filetypeCB.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 70);
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
            this.label2.Location = new System.Drawing.Point(543, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Extension:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marked files:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(623, 96);
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
            this.pathlistview.CausesValidation = false;
            this.pathlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPath});
            this.pathlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathlistview.FullRowSelect = true;
            this.pathlistview.GridLines = true;
            this.pathlistview.HideSelection = false;
            this.pathlistview.LargeImageList = this.treeImages;
            this.pathlistview.Location = new System.Drawing.Point(0, 0);
            this.pathlistview.Name = "pathlistview";
            this.pathlistview.ShowItemToolTips = true;
            this.pathlistview.Size = new System.Drawing.Size(265, 374);
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
            this.clearSearch.Location = new System.Drawing.Point(366, 70);
            this.clearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(22, 24);
            this.clearSearch.TabIndex = 18;
            this.clearSearch.UseVisualStyleBackColor = false;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // regexCheckbox
            // 
            this.regexCheckbox.AutoSize = true;
            this.regexCheckbox.Location = new System.Drawing.Point(17, 98);
            this.regexCheckbox.Name = "regexCheckbox";
            this.regexCheckbox.Size = new System.Drawing.Size(57, 17);
            this.regexCheckbox.TabIndex = 21;
            this.regexCheckbox.Text = "Regex";
            this.regexCheckbox.UseVisualStyleBackColor = true;
            // 
            // currentfolderCheckBox
            // 
            this.currentfolderCheckBox.AutoSize = true;
            this.currentfolderCheckBox.Location = new System.Drawing.Point(80, 98);
            this.currentfolderCheckBox.Name = "currentfolderCheckBox";
            this.currentfolderCheckBox.Size = new System.Drawing.Size(181, 17);
            this.currentfolderCheckBox.TabIndex = 22;
            this.currentfolderCheckBox.Text = "Search only in current mod folder";
            this.currentfolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // caseCheckBox
            // 
            this.caseCheckBox.AutoSize = true;
            this.caseCheckBox.Location = new System.Drawing.Point(266, 97);
            this.caseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.caseCheckBox.Name = "caseCheckBox";
            this.caseCheckBox.Size = new System.Drawing.Size(94, 17);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "View";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.largeIconToolStripMenuItem.Text = "LargeIcon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.smallIconToolStripMenuItem.Text = "SmallIcon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Enabled = false;
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.Enabled = false;
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // lExtension
            // 
            this.lExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lExtension.AutoSize = true;
            this.lExtension.Location = new System.Drawing.Point(393, 76);
            this.lExtension.Name = "lExtension";
            this.lExtension.Size = new System.Drawing.Size(34, 13);
            this.lExtension.TabIndex = 25;
            this.lExtension.Text = "Type:";
            // 
            // extensionCB
            // 
            this.extensionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extensionCB.FormattingEnabled = true;
            this.extensionCB.Items.AddRange(new object[] {
            "Any"});
            this.extensionCB.Location = new System.Drawing.Point(433, 72);
            this.extensionCB.Name = "extensionCB";
            this.extensionCB.Size = new System.Drawing.Size(104, 21);
            this.extensionCB.TabIndex = 26;
            // 
            // addDLCFile
            // 
            this.addDLCFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addDLCFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addDLCFile.Location = new System.Drawing.Point(160, 499);
            this.addDLCFile.Name = "addDLCFile";
            this.addDLCFile.Size = new System.Drawing.Size(145, 23);
            this.addDLCFile.TabIndex = 27;
            this.addDLCFile.TabStop = false;
            this.addDLCFile.Text = "Add marked files to DLC";
            this.addDLCFile.UseVisualStyleBackColor = true;
            this.addDLCFile.Click += new System.EventHandler(this.AddDLCFile_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.BackgroundImage = global::WolvenKit.Properties.Resources.home;
            this.homeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBTN.Location = new System.Drawing.Point(9, 40);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(28, 23);
            this.homeBTN.TabIndex = 28;
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.Home_Click);
            // 
            // fileSplitContainer
            // 
            this.fileSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSplitContainer.Location = new System.Drawing.Point(9, 120);
            this.fileSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.fileSplitContainer.Name = "fileSplitContainer";
            // 
            // fileSplitContainer.Panel1
            // 
            this.fileSplitContainer.Panel1.Controls.Add(this.fileListView);
            // 
            // fileSplitContainer.Panel2
            // 
            this.fileSplitContainer.Panel2.Controls.Add(this.pathlistview);
            this.fileSplitContainer.Size = new System.Drawing.Size(791, 374);
            this.fileSplitContainer.SplitterDistance = 523;
            this.fileSplitContainer.SplitterWidth = 3;
            this.fileSplitContainer.TabIndex = 29;
            // 
            // limitCheckBox
            // 
            this.limitCheckBox.AutoSize = true;
            this.limitCheckBox.Checked = true;
            this.limitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.limitCheckBox.Location = new System.Drawing.Point(366, 97);
            this.limitCheckBox.Name = "limitCheckBox";
            this.limitCheckBox.Size = new System.Drawing.Size(98, 17);
            this.limitCheckBox.TabIndex = 30;
            this.limitCheckBox.Text = "Limit results to :";
            this.limitCheckBox.UseVisualStyleBackColor = true;
            // 
            // limitUpDown
            // 
            this.limitUpDown.Location = new System.Drawing.Point(464, 96);
            this.limitUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.limitUpDown.Name = "limitUpDown";
            this.limitUpDown.Size = new System.Drawing.Size(64, 20);
            this.limitUpDown.TabIndex = 32;
            this.limitUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.limitUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBoxUncook
            // 
            this.checkBoxUncook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxUncook.AutoSize = true;
            this.checkBoxUncook.Location = new System.Drawing.Point(314, 503);
            this.checkBoxUncook.Name = "checkBoxUncook";
            this.checkBoxUncook.Size = new System.Drawing.Size(64, 17);
            this.checkBoxUncook.TabIndex = 33;
            this.checkBoxUncook.Text = "Uncook";
            this.checkBoxUncook.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            this.checkBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxExport.AutoSize = true;
            this.checkBoxExport.Location = new System.Drawing.Point(384, 503);
            this.checkBoxExport.Name = "checkBoxExport";
            this.checkBoxExport.Size = new System.Drawing.Size(56, 17);
            this.checkBoxExport.TabIndex = 34;
            this.checkBoxExport.Text = "Export";
            this.checkBoxExport.UseVisualStyleBackColor = true;
            this.checkBoxExport.CheckedChanged += new System.EventHandler(this.checkBoxExport_CheckedChanged);
            // 
            // frmAssetBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxExport);
            this.Controls.Add(this.checkBoxUncook);
            this.Controls.Add(this.limitUpDown);
            this.Controls.Add(this.limitCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileSplitContainer);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.addDLCFile);
            this.Controls.Add(this.extensionCB);
            this.Controls.Add(this.lExtension);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.caseCheckBox);
            this.Controls.Add(this.currentfolderCheckBox);
            this.Controls.Add(this.regexCheckbox);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filetypeCB);
            this.Controls.Add(this.MarkSelected);
            this.Controls.Add(this.ClearFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pathPanel);
            this.Controls.Add(this.btOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAssetBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asset browser";
            this.Load += new System.EventHandler(this.frmBundleExplorer_Load);
            this.filebrowserMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fileSplitContainer.Panel1.ResumeLayout(false);
            this.fileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).EndInit();
            this.fileSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).EndInit();
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
        private ColumnHeader colType;
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
        private Label lExtension;
        private ComboBox extensionCB;
        private Button addDLCFile;
        private Button homeBTN;
        private SplitContainer fileSplitContainer;
        private CheckBox limitCheckBox;
        private NumericUpDown limitUpDown;
        private CheckBox checkBoxUncook;
        private CheckBox checkBoxExport;
    }
}