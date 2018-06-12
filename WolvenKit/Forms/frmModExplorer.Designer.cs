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
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRelativePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsModDlcFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showFileInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.resetfilesButton = new System.Windows.Forms.ToolStripButton();
            this.showhideButton = new System.Windows.Forms.ToolStripButton();
            this.ExpandBTN = new System.Windows.Forms.ToolStripButton();
            this.CollapseBTN = new System.Windows.Forms.ToolStripButton();
            this.modexplorerSlave = new System.IO.FileSystemWatcher();
            this.contextMenu.SuspendLayout();
            this.searchstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modexplorerSlave)).BeginInit();
            this.SuspendLayout();
            // 
            // modFileList
            // 
            this.modFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modFileList.ImageIndex = 0;
            this.modFileList.ImageList = this.treeImages;
            this.modFileList.Location = new System.Drawing.Point(0, 31);
            this.modFileList.Margin = new System.Windows.Forms.Padding(2);
            this.modFileList.Name = "modFileList";
            this.modFileList.SelectedImageIndex = 0;
            this.modFileList.Size = new System.Drawing.Size(777, 414);
            this.modFileList.TabIndex = 0;
            this.modFileList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseClick);
            this.modFileList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.modFileList_NodeMouseDoubleClick);
            this.modFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modFileList_KeyDown);
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
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.removeFileToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.copyRelativePathToolStripMenuItem,
            this.markAsModDlcFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.showFileInExplorerToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(264, 250);
            this.contextMenu.Opened += new System.EventHandler(this.contextMenu_Opened);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.removeFileToolStripMenuItem.Text = "Delete";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // copyRelativePathToolStripMenuItem
            // 
            this.copyRelativePathToolStripMenuItem.Name = "copyRelativePathToolStripMenuItem";
            this.copyRelativePathToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.copyRelativePathToolStripMenuItem.Text = "Copy relative path";
            this.copyRelativePathToolStripMenuItem.Click += new System.EventHandler(this.copyRelativePathToolStripMenuItem_Click);
            // 
            // markAsModDlcFileToolStripMenuItem
            // 
            this.markAsModDlcFileToolStripMenuItem.Name = "markAsModDlcFileToolStripMenuItem";
            this.markAsModDlcFileToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.markAsModDlcFileToolStripMenuItem.Text = "Mark as [Mod/Dlc] file";
            this.markAsModDlcFileToolStripMenuItem.Click += new System.EventHandler(this.markAsModDlcFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // showFileInExplorerToolStripMenuItem
            // 
            this.showFileInExplorerToolStripMenuItem.Name = "showFileInExplorerToolStripMenuItem";
            this.showFileInExplorerToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.showFileInExplorerToolStripMenuItem.Text = "Show file in explorer";
            this.showFileInExplorerToolStripMenuItem.Click += new System.EventHandler(this.showFileInExplorerToolStripMenuItem_Click);
            // 
            // searchstrip
            // 
            this.searchstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchBox,
            this.resetfilesButton,
            this.showhideButton,
            this.ExpandBTN,
            this.CollapseBTN});
            this.searchstrip.Location = new System.Drawing.Point(0, 0);
            this.searchstrip.Name = "searchstrip";
            this.searchstrip.Size = new System.Drawing.Size(777, 31);
            this.searchstrip.TabIndex = 1;
            this.searchstrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 28);
            this.toolStripLabel1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(76, 31);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // resetfilesButton
            // 
            this.resetfilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetfilesButton.Image = global::WolvenKit.Properties.Resources.ExitIcon;
            this.resetfilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetfilesButton.Name = "resetfilesButton";
            this.resetfilesButton.Size = new System.Drawing.Size(24, 28);
            this.resetfilesButton.Text = "Reset filelist";
            this.resetfilesButton.Click += new System.EventHandler(this.UpdatefilelistButtonClick);
            // 
            // showhideButton
            // 
            this.showhideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showhideButton.Image = global::WolvenKit.Properties.Resources.LayerGroupVisibled;
            this.showhideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showhideButton.Name = "showhideButton";
            this.showhideButton.Size = new System.Drawing.Size(24, 28);
            this.showhideButton.Text = "Show/Hide folders";
            this.showhideButton.ToolTipText = "Show/Hide folders";
            this.showhideButton.Click += new System.EventHandler(this.showhideButton_Click);
            // 
            // ExpandBTN
            // 
            this.ExpandBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExpandBTN.Image = global::WolvenKit.Properties.Resources.Editing_Expand_icon;
            this.ExpandBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExpandBTN.Name = "ExpandBTN";
            this.ExpandBTN.Size = new System.Drawing.Size(24, 28);
            this.ExpandBTN.Text = "Expand all";
            this.ExpandBTN.Click += new System.EventHandler(this.ExpandBTN_Click);
            // 
            // CollapseBTN
            // 
            this.CollapseBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CollapseBTN.Image = global::WolvenKit.Properties.Resources.Editing_Collapse_icon;
            this.CollapseBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CollapseBTN.Name = "CollapseBTN";
            this.CollapseBTN.Size = new System.Drawing.Size(24, 28);
            this.CollapseBTN.Text = "Collapse all";
            this.CollapseBTN.ToolTipText = "Collapse all";
            this.CollapseBTN.Click += new System.EventHandler(this.CollapseBTN_Click);
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
            // frmModExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 445);
            this.Controls.Add(this.modFileList);
            this.Controls.Add(this.searchstrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStrip searchstrip;
        private ToolStripLabel toolStripLabel1;
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
    }
}