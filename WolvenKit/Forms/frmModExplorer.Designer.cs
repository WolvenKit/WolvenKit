using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmModExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModExplorer));
            this.modFileList = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createW2animsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportW2cutscenejsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportW2animsjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportw2rigjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportW3facjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportW3facposejsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRelativePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsModDlcFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.assetBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dumpXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpChunksToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showFileInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.searchstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.showhideButton = new System.Windows.Forms.ToolStripButton();
            this.ExpandBTN = new System.Windows.Forms.ToolStripButton();
            this.CollapseBTN = new System.Windows.Forms.ToolStripButton();
            this.resetfilesButton = new System.Windows.Forms.ToolStripButton();
            this.modexplorerSlave = new System.IO.FileSystemWatcher();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fastRenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.searchstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modexplorerSlave)).BeginInit();
            this.SuspendLayout();
            // 
            // modFileList
            // 
            this.modFileList.BackColor = System.Drawing.SystemColors.Control;
            this.modFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modFileList.ContextMenuStrip = this.contextMenu;
            this.modFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modFileList.ForeColor = System.Drawing.SystemColors.Control;
            this.modFileList.ImageIndex = 0;
            this.modFileList.ImageList = this.treeImages;
            this.modFileList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modFileList.Location = new System.Drawing.Point(0, 27);
            this.modFileList.Margin = new System.Windows.Forms.Padding(1);
            this.modFileList.Name = "modFileList";
            this.modFileList.SelectedImageIndex = 0;
            this.modFileList.Size = new System.Drawing.Size(164, 194);
            this.modFileList.TabIndex = 0;
            this.modFileList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseClick);
            this.modFileList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseDoubleClick);
            this.modFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modFileList_KeyDown);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createW2animsToolStripMenuItem,
            this.exportW2cutscenejsonToolStripMenuItem,
            this.exportW2animsjsonToolStripMenuItem,
            this.exportw2rigjsonToolStripMenuItem,
            this.exportW3facjsonToolStripMenuItem,
            this.exportW3facposejsonToolStripMenuItem,
            this.cookToolStripMenuItem,
            this.importAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.fastRenderToolStripMenuItem,
            this.toolStripSeparator5,
            this.removeFileToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.copyRelativePathToolStripMenuItem,
            this.markAsModDlcFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.assetBrowserToolStripMenuItem,
            this.addFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.dumpXMLToolStripMenuItem,
            this.dumpChunksToXMLToolStripMenuItem,
            this.toolStripSeparator4,
            this.showFileInExplorerToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(203, 576);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // createW2animsToolStripMenuItem
            // 
            this.createW2animsToolStripMenuItem.Name = "createW2animsToolStripMenuItem";
            this.createW2animsToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.createW2animsToolStripMenuItem.Text = "Create w2anims";
            this.createW2animsToolStripMenuItem.Click += new System.EventHandler(this.createW2animsToolStripMenuItem_Click);
            // 
            // exportW2cutscenejsonToolStripMenuItem
            // 
            this.exportW2cutscenejsonToolStripMenuItem.Name = "exportW2cutscenejsonToolStripMenuItem";
            this.exportW2cutscenejsonToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportW2cutscenejsonToolStripMenuItem.Text = "Export w2cutscene.json";
            this.exportW2cutscenejsonToolStripMenuItem.Click += new System.EventHandler(this.exportW2cutscenejsonToolStripMenuItem_Click);
            // 
            // exportW2animsjsonToolStripMenuItem
            // 
            this.exportW2animsjsonToolStripMenuItem.Name = "exportW2animsjsonToolStripMenuItem";
            this.exportW2animsjsonToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportW2animsjsonToolStripMenuItem.Text = "Export w2anims.json";
            this.exportW2animsjsonToolStripMenuItem.Visible = false;
            this.exportW2animsjsonToolStripMenuItem.Click += new System.EventHandler(this.exportW2animsjsonToolStripMenuItem_Click);
            // 
            // exportw2rigjsonToolStripMenuItem
            // 
            this.exportw2rigjsonToolStripMenuItem.Name = "exportw2rigjsonToolStripMenuItem";
            this.exportw2rigjsonToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportw2rigjsonToolStripMenuItem.Text = "Export w2rig.json";
            this.exportw2rigjsonToolStripMenuItem.Visible = false;
            this.exportw2rigjsonToolStripMenuItem.Click += new System.EventHandler(this.exportw2rigjsonToolStripMenuItem_Click);
            // 
            // exportW3facjsonToolStripMenuItem
            // 
            this.exportW3facjsonToolStripMenuItem.Name = "exportW3facjsonToolStripMenuItem";
            this.exportW3facjsonToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportW3facjsonToolStripMenuItem.Text = "Export w3fac.json";
            this.exportW3facjsonToolStripMenuItem.Click += new System.EventHandler(this.exportW3facjsonToolStripMenuItem_Click);
            // 
            // exportW3facposejsonToolStripMenuItem
            // 
            this.exportW3facposejsonToolStripMenuItem.Name = "exportW3facposejsonToolStripMenuItem";
            this.exportW3facposejsonToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.exportW3facposejsonToolStripMenuItem.Text = "Export w3fac.pose.json";
            this.exportW3facposejsonToolStripMenuItem.Click += new System.EventHandler(this.exportW3facposejsonToolStripMenuItem_Click);
            // 
            // cookToolStripMenuItem
            // 
            this.cookToolStripMenuItem.Enabled = false;
            this.cookToolStripMenuItem.Name = "cookToolStripMenuItem";
            this.cookToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cookToolStripMenuItem.Text = "Cook files in directory";
            this.cookToolStripMenuItem.Click += new System.EventHandler(this.cookToolStripMenuItem_Click);
            // 
            // importAsToolStripMenuItem
            // 
            this.importAsToolStripMenuItem.Name = "importAsToolStripMenuItem";
            this.importAsToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.importAsToolStripMenuItem.Text = "Import as ...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.removeFileToolStripMenuItem.Text = "Delete";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // copyRelativePathToolStripMenuItem
            // 
            this.copyRelativePathToolStripMenuItem.Name = "copyRelativePathToolStripMenuItem";
            this.copyRelativePathToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.copyRelativePathToolStripMenuItem.Text = "Copy relative path";
            this.copyRelativePathToolStripMenuItem.Click += new System.EventHandler(this.copyRelativePathToolStripMenuItem_Click);
            // 
            // markAsModDlcFileToolStripMenuItem
            // 
            this.markAsModDlcFileToolStripMenuItem.Enabled = false;
            this.markAsModDlcFileToolStripMenuItem.Name = "markAsModDlcFileToolStripMenuItem";
            this.markAsModDlcFileToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.markAsModDlcFileToolStripMenuItem.Text = "Mark as [Mod/Dlc] file";
            this.markAsModDlcFileToolStripMenuItem.Click += new System.EventHandler(this.markAsModDlcFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // assetBrowserToolStripMenuItem
            // 
            this.assetBrowserToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.assetBrowserToolStripMenuItem.Name = "assetBrowserToolStripMenuItem";
            this.assetBrowserToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.assetBrowserToolStripMenuItem.Text = "Asset Browser here";
            this.assetBrowserToolStripMenuItem.Click += new System.EventHandler(this.openAssetBrowserToolStripMenuItem_Click);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // dumpXMLToolStripMenuItem
            // 
            this.dumpXMLToolStripMenuItem.Name = "dumpXMLToolStripMenuItem";
            this.dumpXMLToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.dumpXMLToolStripMenuItem.Text = "Dump XML";
            this.dumpXMLToolStripMenuItem.Click += new System.EventHandler(this.dumpXMLToolStripMenuItem_Click);
            // 
            // dumpChunksToXMLToolStripMenuItem
            // 
            this.dumpChunksToXMLToolStripMenuItem.Name = "dumpChunksToXMLToolStripMenuItem";
            this.dumpChunksToXMLToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.dumpChunksToXMLToolStripMenuItem.Text = "Dump Chunks to XML";
            this.dumpChunksToXMLToolStripMenuItem.Click += new System.EventHandler(this.dumpChunksToXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // showFileInExplorerToolStripMenuItem
            // 
            this.showFileInExplorerToolStripMenuItem.Name = "showFileInExplorerToolStripMenuItem";
            this.showFileInExplorerToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.showFileInExplorerToolStripMenuItem.Text = "Show file in explorer";
            this.showFileInExplorerToolStripMenuItem.Click += new System.EventHandler(this.showFileInExplorerToolStripMenuItem_Click);
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "csv");
            this.treeImages.Images.SetKeyName(1, "redswf");
            this.treeImages.Images.SetKeyName(2, "env");
            this.treeImages.Images.SetKeyName(3, "journal");
            this.treeImages.Images.SetKeyName(4, "w2beh");
            this.treeImages.Images.SetKeyName(5, "xml");
            this.treeImages.Images.SetKeyName(6, "w2behtree");
            this.treeImages.Images.SetKeyName(7, "w2scene");
            this.treeImages.Images.SetKeyName(8, "w2p");
            this.treeImages.Images.SetKeyName(9, "w2rig");
            this.treeImages.Images.SetKeyName(10, "normalFolder");
            this.treeImages.Images.SetKeyName(11, "FolderOpened_grey");
            this.treeImages.Images.SetKeyName(12, "FolderOpened");
            this.treeImages.Images.SetKeyName(13, "genericFile");
            // 
            // searchstrip
            // 
            this.searchstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchBox,
            this.showhideButton,
            this.ExpandBTN,
            this.CollapseBTN,
            this.resetfilesButton});
            this.searchstrip.Location = new System.Drawing.Point(0, 0);
            this.searchstrip.Name = "searchstrip";
            this.searchstrip.Size = new System.Drawing.Size(164, 27);
            this.searchstrip.TabIndex = 1;
            this.searchstrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 24);
            this.toolStripLabel1.Text = "Filter: ";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(54, 27);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // showhideButton
            // 
            this.showhideButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.showhideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showhideButton.Image = global::WolvenKit.Properties.Resources.LayerGroupVisibled;
            this.showhideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showhideButton.Name = "showhideButton";
            this.showhideButton.Size = new System.Drawing.Size(24, 24);
            this.showhideButton.Text = "Show/Hide folders";
            this.showhideButton.ToolTipText = "Show/Hide folders";
            this.showhideButton.Click += new System.EventHandler(this.showhideButton_Click);
            // 
            // ExpandBTN
            // 
            this.ExpandBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExpandBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExpandBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExpandBTN.Image")));
            this.ExpandBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExpandBTN.Name = "ExpandBTN";
            this.ExpandBTN.Size = new System.Drawing.Size(24, 24);
            this.ExpandBTN.Text = "Expand all";
            this.ExpandBTN.Click += new System.EventHandler(this.ExpandBTN_Click);
            // 
            // CollapseBTN
            // 
            this.CollapseBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CollapseBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CollapseBTN.Image = ((System.Drawing.Image)(resources.GetObject("CollapseBTN.Image")));
            this.CollapseBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CollapseBTN.Name = "CollapseBTN";
            this.CollapseBTN.Size = new System.Drawing.Size(24, 24);
            this.CollapseBTN.Text = "Collapse all";
            this.CollapseBTN.ToolTipText = "Collapse all";
            this.CollapseBTN.Click += new System.EventHandler(this.CollapseBTN_Click);
            // 
            // resetfilesButton
            // 
            this.resetfilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetfilesButton.Image = global::WolvenKit.Properties.Resources.ExitIcon;
            this.resetfilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetfilesButton.Name = "resetfilesButton";
            this.resetfilesButton.Size = new System.Drawing.Size(24, 24);
            this.resetfilesButton.Text = "Reset filelist";
            this.resetfilesButton.Click += new System.EventHandler(this.UpdatefilelistButtonClick);
            // 
            // modexplorerSlave
            // 
            this.modexplorerSlave.EnableRaisingEvents = true;
            this.modexplorerSlave.IncludeSubdirectories = true;
            this.modexplorerSlave.SynchronizingObject = this;
            this.modexplorerSlave.Created += new System.IO.FileSystemEventHandler(this.FileChanges_Detected);
            this.modexplorerSlave.Deleted += new System.IO.FileSystemEventHandler(this.FileChanges_Detected);
            this.modexplorerSlave.Renamed += new System.IO.RenamedEventHandler(this.FileChanges_Detected);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // fastRenderToolStripMenuItem
            // 
            this.fastRenderToolStripMenuItem.Name = "fastRenderToolStripMenuItem";
            this.fastRenderToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.fastRenderToolStripMenuItem.Text = "Fast Render";
            this.fastRenderToolStripMenuItem.Click += new System.EventHandler(this.fastRenderToolStripMenuItem_Click);
            // 
            // frmModExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 221);
            this.Controls.Add(this.modFileList);
            this.Controls.Add(this.searchstrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmModExplorer";
            this.Text = "Mod Explorer";
            this.Shown += new System.EventHandler(this.frmModExplorer_Shown);
            this.contextMenu.ResumeLayout(false);
            this.searchstrip.ResumeLayout(false);
            this.searchstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modexplorerSlave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView modFileList;
        private ImageList treeImages;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem removeFileToolStripMenuItem;
        private ToolStripMenuItem assetBrowserToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStrip searchstrip;
        private ToolStripTextBox searchBox;
        private ToolStripButton showhideButton;
        private ToolStripButton resetfilesButton;
        private FileSystemWatcher modexplorerSlave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem showFileInExplorerToolStripMenuItem;
        private ToolStripButton ExpandBTN;
        private ToolStripButton CollapseBTN;
        private ToolStripMenuItem copyRelativePathToolStripMenuItem;
        private ToolStripMenuItem markAsModDlcFileToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cookToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem importAsToolStripMenuItem;
        private ToolStripMenuItem dumpXMLToolStripMenuItem;
        private ToolStripMenuItem dumpChunksToXMLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem exportw2rigjsonToolStripMenuItem;
        private ToolStripMenuItem exportW2animsjsonToolStripMenuItem;
        private ToolStripMenuItem exportW2cutscenejsonToolStripMenuItem;
        private ToolStripMenuItem exportW3facjsonToolStripMenuItem;
        private ToolStripMenuItem exportW3facposejsonToolStripMenuItem;
        private ToolStripMenuItem createW2animsToolStripMenuItem;
        private ToolStripMenuItem fastRenderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
    }
}