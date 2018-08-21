namespace WolvenKit.Forms
{
    partial class frmMergeMetadataStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMergeMetadataStore));
            this.listViewModList = new System.Windows.Forms.ListView();
            this.columnHeaderModName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModBundle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModCache = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModMerged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModLoadOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnSelectAllMods = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUnselectAllMods = new System.Windows.Forms.ToolStripButton();
            this.tsDDBtnUnmergeDLC = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_DLC_UnmergeMetdadata = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DLC_UnmergeBundles = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DLC_UnmrgeTextures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDDBtnMergeDLC = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_DLC_MergeMetdadata = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DLC_MergeBundles = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_DLC_MergeTextures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnUnselectAllDLC = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSelectAllDLC = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDDMergeMod = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_Mod_MergeMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Mod_MergeBundles = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Mod_MergeTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDDBtnUnmergeMod = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_Mod_UnmergeMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Mod_UnmergeBundles = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Mod_UnmergeTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewDLCList = new System.Windows.Forms.ListView();
            this.columnHeaderDLCName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDLCBundle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDLCCache = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMergedDLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDLCLoadOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerList = new System.Windows.Forms.SplitContainer();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerList)).BeginInit();
            this.splitContainerList.Panel1.SuspendLayout();
            this.splitContainerList.Panel2.SuspendLayout();
            this.splitContainerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewModList
            // 
            this.listViewModList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewModList.AllowDrop = true;
            this.listViewModList.CheckBoxes = true;
            this.listViewModList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderModName,
            this.columnHeaderModBundle,
            this.columnHeaderModCache,
            this.columnHeaderModMerged,
            this.columnHeaderModLoadOrder});
            this.listViewModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewModList.FullRowSelect = true;
            this.listViewModList.GridLines = true;
            this.listViewModList.Location = new System.Drawing.Point(0, 0);
            this.listViewModList.MultiSelect = false;
            this.listViewModList.Name = "listViewModList";
            this.listViewModList.Size = new System.Drawing.Size(792, 806);
            this.listViewModList.TabIndex = 0;
            this.listViewModList.UseCompatibleStateImageBehavior = false;
            this.listViewModList.View = System.Windows.Forms.View.Details;
            this.listViewModList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewModList_ItemCheck);
            this.listViewModList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewModList_ItemDrag);
            this.listViewModList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewModList_ItemSelectionChanged);
            this.listViewModList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewModList_DragDrop);
            this.listViewModList.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewModList_DragEnter);
            this.listViewModList.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewModList_DragOver);
            this.listViewModList.DragLeave += new System.EventHandler(this.listViewModList_DragLeave);
            // 
            // columnHeaderModName
            // 
            this.columnHeaderModName.Text = "Mod Name";
            this.columnHeaderModName.Width = 150;
            // 
            // columnHeaderModBundle
            // 
            this.columnHeaderModBundle.Text = "Bundle";
            this.columnHeaderModBundle.Width = 70;
            // 
            // columnHeaderModCache
            // 
            this.columnHeaderModCache.Text = "Cache";
            this.columnHeaderModCache.Width = 70;
            // 
            // columnHeaderModMerged
            // 
            this.columnHeaderModMerged.Text = "Merged Files";
            // 
            // columnHeaderModLoadOrder
            // 
            this.columnHeaderModLoadOrder.Text = "LO";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1678, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsMenuHelp
            // 
            this.tsMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItemHelp});
            this.tsMenuHelp.Name = "tsMenuHelp";
            this.tsMenuHelp.Size = new System.Drawing.Size(61, 29);
            this.tsMenuHelp.Text = "Help";
            // 
            // helpToolStripMenuItemHelp
            // 
            this.helpToolStripMenuItemHelp.Name = "helpToolStripMenuItemHelp";
            this.helpToolStripMenuItemHelp.Size = new System.Drawing.Size(133, 30);
            this.helpToolStripMenuItemHelp.Text = "Help";
            this.helpToolStripMenuItemHelp.Click += new System.EventHandler(this.helpToolStripMenuItemHelp_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSelectAllMods,
            this.tsBtnUnselectAllMods,
            this.tsDDBtnUnmergeDLC,
            this.tsDDBtnMergeDLC,
            this.tsBtnUnselectAllDLC,
            this.tsBtnSelectAllDLC,
            this.tsBtnDDMergeMod,
            this.tsDDBtnUnmergeMod});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1678, 32);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsBtnSelectAllMods
            // 
            this.tsBtnSelectAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSelectAllMods.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSelectAllMods.Image")));
            this.tsBtnSelectAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelectAllMods.Name = "tsBtnSelectAllMods";
            this.tsBtnSelectAllMods.Size = new System.Drawing.Size(87, 29);
            this.tsBtnSelectAllMods.Text = "Select All";
            this.tsBtnSelectAllMods.Click += new System.EventHandler(this.tsBtnSelectAllMods_Click);
            // 
            // tsBtnUnselectAllMods
            // 
            this.tsBtnUnselectAllMods.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnUnselectAllMods.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUnselectAllMods.Image")));
            this.tsBtnUnselectAllMods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnselectAllMods.Name = "tsBtnUnselectAllMods";
            this.tsBtnUnselectAllMods.Size = new System.Drawing.Size(107, 29);
            this.tsBtnUnselectAllMods.Text = "Unselect All";
            this.tsBtnUnselectAllMods.Click += new System.EventHandler(this.tsBtnUnselectAllMods_Click);
            // 
            // tsDDBtnUnmergeDLC
            // 
            this.tsDDBtnUnmergeDLC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDDBtnUnmergeDLC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDDBtnUnmergeDLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_DLC_UnmergeMetdadata,
            this.ts_DLC_UnmergeBundles,
            this.ts_DLC_UnmrgeTextures});
            this.tsDDBtnUnmergeDLC.Image = ((System.Drawing.Image)(resources.GetObject("tsDDBtnUnmergeDLC.Image")));
            this.tsDDBtnUnmergeDLC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDDBtnUnmergeDLC.Name = "tsDDBtnUnmergeDLC";
            this.tsDDBtnUnmergeDLC.Size = new System.Drawing.Size(139, 29);
            this.tsDDBtnUnmergeDLC.Text = "Unmerge DLC";
            // 
            // ts_DLC_UnmergeMetdadata
            // 
            this.ts_DLC_UnmergeMetdadata.Name = "ts_DLC_UnmergeMetdadata";
            this.ts_DLC_UnmergeMetdadata.Size = new System.Drawing.Size(249, 30);
            this.ts_DLC_UnmergeMetdadata.Text = "Unmerge Metadata";
            this.ts_DLC_UnmergeMetdadata.Click += new System.EventHandler(this.ts_DLC_UnmergeMetdadata_Click);
            // 
            // ts_DLC_UnmergeBundles
            // 
            this.ts_DLC_UnmergeBundles.Enabled = false;
            this.ts_DLC_UnmergeBundles.Name = "ts_DLC_UnmergeBundles";
            this.ts_DLC_UnmergeBundles.Size = new System.Drawing.Size(249, 30);
            this.ts_DLC_UnmergeBundles.Text = "Unmerge Bundles";
            this.ts_DLC_UnmergeBundles.Visible = false;
            this.ts_DLC_UnmergeBundles.Click += new System.EventHandler(this.ts_DLC_UnmergeBundles_Click);
            // 
            // ts_DLC_UnmrgeTextures
            // 
            this.ts_DLC_UnmrgeTextures.Enabled = false;
            this.ts_DLC_UnmrgeTextures.Name = "ts_DLC_UnmrgeTextures";
            this.ts_DLC_UnmrgeTextures.Size = new System.Drawing.Size(249, 30);
            this.ts_DLC_UnmrgeTextures.Text = "Unmerge Textures";
            this.ts_DLC_UnmrgeTextures.Click += new System.EventHandler(this.ts_DLC_UnmrgeTextures_Click);
            // 
            // tsDDBtnMergeDLC
            // 
            this.tsDDBtnMergeDLC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDDBtnMergeDLC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDDBtnMergeDLC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_DLC_MergeMetdadata,
            this.ts_DLC_MergeBundles,
            this.ts_DLC_MergeTextures});
            this.tsDDBtnMergeDLC.Image = ((System.Drawing.Image)(resources.GetObject("tsDDBtnMergeDLC.Image")));
            this.tsDDBtnMergeDLC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDDBtnMergeDLC.Name = "tsDDBtnMergeDLC";
            this.tsDDBtnMergeDLC.Size = new System.Drawing.Size(117, 29);
            this.tsDDBtnMergeDLC.Text = "Merge DLC";
            // 
            // ts_DLC_MergeMetdadata
            // 
            this.ts_DLC_MergeMetdadata.Name = "ts_DLC_MergeMetdadata";
            this.ts_DLC_MergeMetdadata.Size = new System.Drawing.Size(227, 30);
            this.ts_DLC_MergeMetdadata.Text = "Merge Metadata";
            this.ts_DLC_MergeMetdadata.Click += new System.EventHandler(this.ts_DLC_MergeMetdadata_Click);
            // 
            // ts_DLC_MergeBundles
            // 
            this.ts_DLC_MergeBundles.Enabled = false;
            this.ts_DLC_MergeBundles.Name = "ts_DLC_MergeBundles";
            this.ts_DLC_MergeBundles.Size = new System.Drawing.Size(227, 30);
            this.ts_DLC_MergeBundles.Text = "Merge Bundles";
            this.ts_DLC_MergeBundles.Visible = false;
            this.ts_DLC_MergeBundles.Click += new System.EventHandler(this.ts_DLC_MergeBundles_Click);
            // 
            // ts_DLC_MergeTextures
            // 
            this.ts_DLC_MergeTextures.Enabled = false;
            this.ts_DLC_MergeTextures.Name = "ts_DLC_MergeTextures";
            this.ts_DLC_MergeTextures.Size = new System.Drawing.Size(227, 30);
            this.ts_DLC_MergeTextures.Text = "Merge Textures";
            this.ts_DLC_MergeTextures.Click += new System.EventHandler(this.ts_DLC_MergeTextures_Click);
            // 
            // tsBtnUnselectAllDLC
            // 
            this.tsBtnUnselectAllDLC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnUnselectAllDLC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnUnselectAllDLC.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUnselectAllDLC.Image")));
            this.tsBtnUnselectAllDLC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnselectAllDLC.Name = "tsBtnUnselectAllDLC";
            this.tsBtnUnselectAllDLC.Size = new System.Drawing.Size(107, 29);
            this.tsBtnUnselectAllDLC.Text = "Unselect All";
            this.tsBtnUnselectAllDLC.Click += new System.EventHandler(this.tsBtnUnselectAllDLC_Click);
            // 
            // tsBtnSelectAllDLC
            // 
            this.tsBtnSelectAllDLC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSelectAllDLC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSelectAllDLC.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSelectAllDLC.Image")));
            this.tsBtnSelectAllDLC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelectAllDLC.Name = "tsBtnSelectAllDLC";
            this.tsBtnSelectAllDLC.Size = new System.Drawing.Size(87, 29);
            this.tsBtnSelectAllDLC.Text = "Select All";
            this.tsBtnSelectAllDLC.Click += new System.EventHandler(this.tsBtnSelectAllDLC_Click);
            // 
            // tsBtnDDMergeMod
            // 
            this.tsBtnDDMergeMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDDMergeMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Mod_MergeMetadata,
            this.ts_Mod_MergeBundles,
            this.ts_Mod_MergeTexture});
            this.tsBtnDDMergeMod.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDDMergeMod.Image")));
            this.tsBtnDDMergeMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDDMergeMod.Name = "tsBtnDDMergeMod";
            this.tsBtnDDMergeMod.Size = new System.Drawing.Size(132, 29);
            this.tsBtnDDMergeMod.Text = "Merge Mods";
            // 
            // ts_Mod_MergeMetadata
            // 
            this.ts_Mod_MergeMetadata.Name = "ts_Mod_MergeMetadata";
            this.ts_Mod_MergeMetadata.Size = new System.Drawing.Size(227, 30);
            this.ts_Mod_MergeMetadata.Text = "Merge Metadata";
            this.ts_Mod_MergeMetadata.Click += new System.EventHandler(this.ts_Mod_MergeMetadata_Click);
            // 
            // ts_Mod_MergeBundles
            // 
            this.ts_Mod_MergeBundles.Enabled = false;
            this.ts_Mod_MergeBundles.Name = "ts_Mod_MergeBundles";
            this.ts_Mod_MergeBundles.Size = new System.Drawing.Size(227, 30);
            this.ts_Mod_MergeBundles.Text = "Merge Bundles";
            this.ts_Mod_MergeBundles.Visible = false;
            this.ts_Mod_MergeBundles.Click += new System.EventHandler(this.ts_Mod_MergeBundles_Click);
            // 
            // ts_Mod_MergeTexture
            // 
            this.ts_Mod_MergeTexture.Enabled = false;
            this.ts_Mod_MergeTexture.Name = "ts_Mod_MergeTexture";
            this.ts_Mod_MergeTexture.Size = new System.Drawing.Size(227, 30);
            this.ts_Mod_MergeTexture.Text = "Merge Texture";
            this.ts_Mod_MergeTexture.Click += new System.EventHandler(this.ts_Mod_MergeTexture_Click);
            // 
            // tsDDBtnUnmergeMod
            // 
            this.tsDDBtnUnmergeMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDDBtnUnmergeMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Mod_UnmergeMetadata,
            this.ts_Mod_UnmergeBundles,
            this.ts_Mod_UnmergeTexture});
            this.tsDDBtnUnmergeMod.Image = ((System.Drawing.Image)(resources.GetObject("tsDDBtnUnmergeMod.Image")));
            this.tsDDBtnUnmergeMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDDBtnUnmergeMod.Name = "tsDDBtnUnmergeMod";
            this.tsDDBtnUnmergeMod.Size = new System.Drawing.Size(154, 29);
            this.tsDDBtnUnmergeMod.Text = "Unmerge Mods";
            // 
            // ts_Mod_UnmergeMetadata
            // 
            this.ts_Mod_UnmergeMetadata.Name = "ts_Mod_UnmergeMetadata";
            this.ts_Mod_UnmergeMetadata.Size = new System.Drawing.Size(249, 30);
            this.ts_Mod_UnmergeMetadata.Text = "Unmerge Metadata";
            this.ts_Mod_UnmergeMetadata.Click += new System.EventHandler(this.ts_Mod_UnmergeMetadata_Click);
            // 
            // ts_Mod_UnmergeBundles
            // 
            this.ts_Mod_UnmergeBundles.Enabled = false;
            this.ts_Mod_UnmergeBundles.Name = "ts_Mod_UnmergeBundles";
            this.ts_Mod_UnmergeBundles.Size = new System.Drawing.Size(249, 30);
            this.ts_Mod_UnmergeBundles.Text = "Unmerge Bundles";
            this.ts_Mod_UnmergeBundles.Visible = false;
            this.ts_Mod_UnmergeBundles.Click += new System.EventHandler(this.ts_Mod_UnmergeBundles_Click);
            // 
            // ts_Mod_UnmergeTexture
            // 
            this.ts_Mod_UnmergeTexture.Enabled = false;
            this.ts_Mod_UnmergeTexture.Name = "ts_Mod_UnmergeTexture";
            this.ts_Mod_UnmergeTexture.Size = new System.Drawing.Size(249, 30);
            this.ts_Mod_UnmergeTexture.Text = "Unmerge Textures";
            this.ts_Mod_UnmergeTexture.Click += new System.EventHandler(this.ts_Mod_UnmergeTexture_Click);
            // 
            // listViewDLCList
            // 
            this.listViewDLCList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewDLCList.AllowDrop = true;
            this.listViewDLCList.CheckBoxes = true;
            this.listViewDLCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDLCName,
            this.columnHeaderDLCBundle,
            this.columnHeaderDLCCache,
            this.columnHeaderMergedDLC,
            this.columnHeaderDLCLoadOrder});
            this.listViewDLCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDLCList.FullRowSelect = true;
            this.listViewDLCList.GridLines = true;
            this.listViewDLCList.Location = new System.Drawing.Point(0, 0);
            this.listViewDLCList.MultiSelect = false;
            this.listViewDLCList.Name = "listViewDLCList";
            this.listViewDLCList.Size = new System.Drawing.Size(882, 806);
            this.listViewDLCList.TabIndex = 3;
            this.listViewDLCList.UseCompatibleStateImageBehavior = false;
            this.listViewDLCList.View = System.Windows.Forms.View.Details;
            this.listViewDLCList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewDLCList_ItemCheck);
            this.listViewDLCList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewDLCList_ItemDrag);
            this.listViewDLCList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewDLCList_ItemSelectionChanged);
            this.listViewDLCList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewDLCList_DragDrop);
            this.listViewDLCList.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewDLCList_DragEnter);
            this.listViewDLCList.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewDLCList_DragOver);
            this.listViewDLCList.DragLeave += new System.EventHandler(this.listViewDLCList_DragLeave);
            // 
            // columnHeaderDLCName
            // 
            this.columnHeaderDLCName.Text = "DLC Name";
            this.columnHeaderDLCName.Width = 150;
            // 
            // columnHeaderDLCBundle
            // 
            this.columnHeaderDLCBundle.Text = "Bundle";
            this.columnHeaderDLCBundle.Width = 70;
            // 
            // columnHeaderDLCCache
            // 
            this.columnHeaderDLCCache.Text = "Cache";
            this.columnHeaderDLCCache.Width = 70;
            // 
            // columnHeaderMergedDLC
            // 
            this.columnHeaderMergedDLC.Text = "Merged Files";
            // 
            // columnHeaderDLCLoadOrder
            // 
            this.columnHeaderDLCLoadOrder.Text = "LO";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.tsLblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 1114);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1678, 30);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // tsLblStatus
            // 
            this.tsLblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsLblStatus.Name = "tsLblStatus";
            this.tsLblStatus.Size = new System.Drawing.Size(459, 25);
            this.tsLblStatus.Text = "MOD: 0/0 bundles merged. DLC: 0/0 bundles merged";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 65);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.splitContainerList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.richTextBox);
            this.splitContainer.Size = new System.Drawing.Size(1678, 1049);
            this.splitContainer.SplitterDistance = 806;
            this.splitContainer.TabIndex = 6;
            // 
            // splitContainerList
            // 
            this.splitContainerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerList.Location = new System.Drawing.Point(0, 0);
            this.splitContainerList.Name = "splitContainerList";
            // 
            // splitContainerList.Panel1
            // 
            this.splitContainerList.Panel1.Controls.Add(this.listViewModList);
            // 
            // splitContainerList.Panel2
            // 
            this.splitContainerList.Panel2.Controls.Add(this.listViewDLCList);
            this.splitContainerList.Size = new System.Drawing.Size(1678, 806);
            this.splitContainerList.SplitterDistance = 792;
            this.splitContainerList.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(1678, 239);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // frmMergeMetadataStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1144);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1700, 1200);
            this.Name = "frmMergeMetadataStore";
            this.Text = "Mod and DLC Merger";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerList.Panel1.ResumeLayout(false);
            this.splitContainerList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerList)).EndInit();
            this.splitContainerList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewModList;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsMenuHelp;
        private System.Windows.Forms.ColumnHeader columnHeaderModName;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ListView listViewDLCList;
        private System.Windows.Forms.ToolStripButton tsBtnSelectAllMods;
        private System.Windows.Forms.ToolStripButton tsBtnUnselectAllMods;
        private System.Windows.Forms.ToolStripButton tsBtnSelectAllDLC;
        private System.Windows.Forms.ToolStripButton tsBtnUnselectAllDLC;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItemHelp;
        private System.Windows.Forms.ColumnHeader columnHeaderModMerged;
        private System.Windows.Forms.ColumnHeader columnHeaderDLCName;
        private System.Windows.Forms.ColumnHeader columnHeaderMergedDLC;
        private System.Windows.Forms.ColumnHeader columnHeaderModBundle;
        private System.Windows.Forms.ColumnHeader columnHeaderModCache;
        private System.Windows.Forms.ColumnHeader columnHeaderDLCBundle;
        private System.Windows.Forms.ColumnHeader columnHeaderDLCCache;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripDropDownButton tsBtnDDMergeMod;
        private System.Windows.Forms.ToolStripDropDownButton tsDDBtnUnmergeMod;
        private System.Windows.Forms.ToolStripDropDownButton tsDDBtnUnmergeDLC;
        private System.Windows.Forms.ToolStripDropDownButton tsDDBtnMergeDLC;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_MergeBundles;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_MergeMetadata;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_MergeTexture;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_UnmergeMetadata;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_UnmergeBundles;
        private System.Windows.Forms.ToolStripMenuItem ts_Mod_UnmergeTexture;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_MergeMetdadata;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_MergeBundles;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_MergeTextures;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_UnmergeMetdadata;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_UnmergeBundles;
        private System.Windows.Forms.ToolStripMenuItem ts_DLC_UnmrgeTextures;
        private System.Windows.Forms.ColumnHeader columnHeaderModLoadOrder;
        private System.Windows.Forms.ColumnHeader columnHeaderDLCLoadOrder;
        private System.Windows.Forms.ToolStripStatusLabel tsLblStatus;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitContainerList;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}