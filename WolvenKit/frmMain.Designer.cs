using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace WolvenKit
{
    partial class frmMain
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
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newmodButton = new System.Windows.Forms.ToolStripButton();
            this.openmodButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openfileButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.saveallButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btPack = new System.Windows.Forms.ToolStripButton();
            this.rungameToolStrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.launchGameForDebuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchWithCostumParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileFromBundleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileFromOtherModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPackedInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wcclitePatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsEncoderGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDebuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinOurDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witcherIIIModdingToolLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordStepsToReproduceBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRedkit2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.packageInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newmodButton,
            this.openmodButton,
            this.toolStripSeparator1,
            this.openfileButton,
            this.saveButton,
            this.saveallButton,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.btPack,
            this.rungameToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newmodButton
            // 
            this.newmodButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newmodButton.Image = global::WolvenKit.Properties.Resources.NewSolutionFolder_6289;
            this.newmodButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newmodButton.Name = "newmodButton";
            this.newmodButton.Size = new System.Drawing.Size(24, 24);
            this.newmodButton.Text = "New mod";
            this.newmodButton.Click += new System.EventHandler(this.newModToolStripMenuItem_Click);
            // 
            // openmodButton
            // 
            this.openmodButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openmodButton.Image = global::WolvenKit.Properties.Resources.Open_6529;
            this.openmodButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openmodButton.Name = "openmodButton";
            this.openmodButton.Size = new System.Drawing.Size(24, 24);
            this.openmodButton.Text = "Open mod";
            this.openmodButton.Click += new System.EventHandler(this.openModToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // openfileButton
            // 
            this.openfileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openfileButton.Image = global::WolvenKit.Properties.Resources.Open_6529;
            this.openfileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openfileButton.Name = "openfileButton";
            this.openfileButton.Size = new System.Drawing.Size(24, 24);
            this.openfileButton.Text = "Open file";
            this.openfileButton.Click += new System.EventHandler(this.tbtOpen_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::WolvenKit.Properties.Resources.Save_6530;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(24, 24);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.tbtSave_Click);
            // 
            // saveallButton
            // 
            this.saveallButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveallButton.Image = global::WolvenKit.Properties.Resources.Saveall_6518;
            this.saveallButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveallButton.Name = "saveallButton";
            this.saveallButton.Size = new System.Drawing.Size(24, 24);
            this.saveallButton.Text = "toolStripButton5";
            this.saveallButton.ToolTipText = "Save all";
            this.saveallButton.Click += new System.EventHandler(this.tbtSaveAll_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.ToolTipText = "Add file from bundle";
            this.toolStripButton7.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btPack
            // 
            this.btPack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPack.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.btPack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPack.Name = "btPack";
            this.btPack.Size = new System.Drawing.Size(24, 24);
            this.btPack.Text = "btPack";
            this.btPack.ToolTipText = "Pack and install mod";
            this.btPack.Click += new System.EventHandler(this.btPack_Click);
            // 
            // rungameToolStrip
            // 
            this.rungameToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rungameToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchGameForDebuggingToolStripMenuItem,
            this.launchWithCostumParametersToolStripMenuItem});
            this.rungameToolStrip.Image = global::WolvenKit.Properties.Resources.witcher3_101;
            this.rungameToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rungameToolStrip.Name = "rungameToolStrip";
            this.rungameToolStrip.Size = new System.Drawing.Size(33, 24);
            this.rungameToolStrip.Text = "Launch game";
            // 
            // launchGameForDebuggingToolStripMenuItem
            // 
            this.launchGameForDebuggingToolStripMenuItem.Name = "launchGameForDebuggingToolStripMenuItem";
            this.launchGameForDebuggingToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.launchGameForDebuggingToolStripMenuItem.Text = "Launch game for debugging";
            this.launchGameForDebuggingToolStripMenuItem.Click += new System.EventHandler(this.LaunchGameForDebuggingToolStripMenuItem_Click);
            // 
            // launchWithCostumParametersToolStripMenuItem
            // 
            this.launchWithCostumParametersToolStripMenuItem.Name = "launchWithCostumParametersToolStripMenuItem";
            this.launchWithCostumParametersToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.launchWithCostumParametersToolStripMenuItem.Text = "Launch with costum parameters";
            this.launchWithCostumParametersToolStripMenuItem.Click += new System.EventHandler(this.launchWithCostumParametersToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.buildDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModToolStripMenuItem,
            this.openModToolStripMenuItem,
            this.toolStripSeparator6,
            this.newFileToolStripMenuItem,
            this.addFileFromBundleToolStripMenuItem,
            this.addFileFromOtherModToolStripMenuItem,
            this.addFileToolStripMenuItem,
            this.toolStripSeparator8,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newModToolStripMenuItem
            // 
            this.newModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.NewSolutionFolder_6289;
            this.newModToolStripMenuItem.Name = "newModToolStripMenuItem";
            this.newModToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.newModToolStripMenuItem.Text = "New mod";
            this.newModToolStripMenuItem.Click += new System.EventHandler(this.tbtNewMod_Click);
            // 
            // openModToolStripMenuItem
            // 
            this.openModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Open_6529;
            this.openModToolStripMenuItem.Name = "openModToolStripMenuItem";
            this.openModToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.openModToolStripMenuItem.Text = "Open mod";
            this.openModToolStripMenuItem.Click += new System.EventHandler(this.tbtOpenMod_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(204, 6);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem,
            this.chunkToolStripMenuItem});
            this.newFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.newFileToolStripMenuItem.Text = "New file";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.scriptToolStripMenuItem.Text = "Script";
            this.scriptToolStripMenuItem.Click += new System.EventHandler(this.scriptToolStripMenuItem_Click);
            // 
            // chunkToolStripMenuItem
            // 
            this.chunkToolStripMenuItem.Enabled = false;
            this.chunkToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.chunkToolStripMenuItem.Name = "chunkToolStripMenuItem";
            this.chunkToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.chunkToolStripMenuItem.Text = "Chunk file";
            this.chunkToolStripMenuItem.Click += new System.EventHandler(this.chunkToolStripMenuItem_Click);
            // 
            // addFileFromBundleToolStripMenuItem
            // 
            this.addFileFromBundleToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileFromBundleToolStripMenuItem.Name = "addFileFromBundleToolStripMenuItem";
            this.addFileFromBundleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addFileFromBundleToolStripMenuItem.Text = "Asset browser";
            this.addFileFromBundleToolStripMenuItem.Click += new System.EventHandler(this.addFileFromBundleToolStripMenuItem_Click);
            // 
            // addFileFromOtherModToolStripMenuItem
            // 
            this.addFileFromOtherModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileFromOtherModToolStripMenuItem.Name = "addFileFromOtherModToolStripMenuItem";
            this.addFileFromOtherModToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addFileFromOtherModToolStripMenuItem.Text = "Add file from other mod";
            this.addFileFromOtherModToolStripMenuItem.Click += new System.EventHandler(this.AddFileFromOtherModToolStripMenuItem_Click_1);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addFileToolStripMenuItem.Text = "Add file";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(204, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Save_6530;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Saveall_6518;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.saveAllToolStripMenuItem.Text = "Save all";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPackedInstallerToolStripMenuItem,
            this.reloadProjectToolStripMenuItem,
            this.toolStripSeparator4,
            this.settingsToolStripMenuItem});
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.modToolStripMenuItem.Text = "Mod";
            // 
            // createPackedInstallerToolStripMenuItem
            // 
            this.createPackedInstallerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.ExpandIcon;
            this.createPackedInstallerToolStripMenuItem.Name = "createPackedInstallerToolStripMenuItem";
            this.createPackedInstallerToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.createPackedInstallerToolStripMenuItem.Text = "Create Packed Installer";
            this.createPackedInstallerToolStripMenuItem.Click += new System.EventHandler(this.createPackedInstallerToolStripMenuItem_Click);
            // 
            // reloadProjectToolStripMenuItem
            // 
            this.reloadProjectToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.refresh;
            this.reloadProjectToolStripMenuItem.Name = "reloadProjectToolStripMenuItem";
            this.reloadProjectToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.reloadProjectToolStripMenuItem.Text = "Reload project";
            this.reloadProjectToolStripMenuItem.Click += new System.EventHandler(this.ReloadProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.gear_16xLG;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.modSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageInstallerToolStripMenuItem,
            this.saveExplorerToolStripMenuItem,
            this.wcclitePatcherToolStripMenuItem,
            this.stringsEncoderGUIToolStripMenuItem,
            this.gameDebuggerToolStripMenuItem,
            this.menuCreatorToolStripMenuItem,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // saveExplorerToolStripMenuItem
            // 
            this.saveExplorerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.properties_16xLG;
            this.saveExplorerToolStripMenuItem.Name = "saveExplorerToolStripMenuItem";
            this.saveExplorerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveExplorerToolStripMenuItem.Text = "Save explorer";
            this.saveExplorerToolStripMenuItem.Click += new System.EventHandler(this.saveExplorerToolStripMenuItem_Click);
            // 
            // wcclitePatcherToolStripMenuItem
            // 
            this.wcclitePatcherToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.wcclitePatcherToolStripMenuItem.Name = "wcclitePatcherToolStripMenuItem";
            this.wcclitePatcherToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.wcclitePatcherToolStripMenuItem.Text = "wcc_lite patcher";
            this.wcclitePatcherToolStripMenuItem.Click += new System.EventHandler(this.wcclitePatcherToolStripMenuItem_Click);
            // 
            // stringsEncoderGUIToolStripMenuItem
            // 
            this.stringsEncoderGUIToolStripMenuItem.Name = "stringsEncoderGUIToolStripMenuItem";
            this.stringsEncoderGUIToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.stringsEncoderGUIToolStripMenuItem.Text = "Strings Encoder GUI";
            this.stringsEncoderGUIToolStripMenuItem.Click += new System.EventHandler(this.StringsGUIToolStripMenuItem_Click);
            // 
            // gameDebuggerToolStripMenuItem
            // 
            this.gameDebuggerToolStripMenuItem.Name = "gameDebuggerToolStripMenuItem";
            this.gameDebuggerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.gameDebuggerToolStripMenuItem.Text = "Game debugger";
            this.gameDebuggerToolStripMenuItem.Click += new System.EventHandler(this.GameDebuggerToolStripMenuItem_Click);
            // 
            // menuCreatorToolStripMenuItem
            // 
            this.menuCreatorToolStripMenuItem.Name = "menuCreatorToolStripMenuItem";
            this.menuCreatorToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.menuCreatorToolStripMenuItem.Text = "Menu creator";
            this.menuCreatorToolStripMenuItem.Click += new System.EventHandler(this.menuCreatorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(179, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.gear_16xLG;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modExplorerToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // modExplorerToolStripMenuItem
            // 
            this.modExplorerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.modExplorerToolStripMenuItem.Name = "modExplorerToolStripMenuItem";
            this.modExplorerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modExplorerToolStripMenuItem.Text = "Mod explorer";
            this.modExplorerToolStripMenuItem.Click += new System.EventHandler(this.modExplorerToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.outputToolStripMenuItem.Text = "Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinOurDiscordToolStripMenuItem,
            this.tutorialsToolStripMenuItem,
            this.witcherIIIModdingToolLicenseToolStripMenuItem,
            this.reportABugToolStripMenuItem,
            this.recordStepsToReproduceBugToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutRedkit2ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // joinOurDiscordToolStripMenuItem
            // 
            this.joinOurDiscordToolStripMenuItem.Image = global::WolvenKit.Properties.Resources._2c21aeda16de354ba5334551a883b481;
            this.joinOurDiscordToolStripMenuItem.Name = "joinOurDiscordToolStripMenuItem";
            this.joinOurDiscordToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.joinOurDiscordToolStripMenuItem.Text = "Join our discord";
            this.joinOurDiscordToolStripMenuItem.Click += new System.EventHandler(this.joinOurDiscordToolStripMenuItem_Click_1);
            // 
            // tutorialsToolStripMenuItem
            // 
            this.tutorialsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.info_icon_23818;
            this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
            this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.tutorialsToolStripMenuItem.Text = "Witcherscript documentation";
            this.tutorialsToolStripMenuItem.Click += new System.EventHandler(this.WitcherScriptToolStripMenuItem_Click);
            // 
            // witcherIIIModdingToolLicenseToolStripMenuItem
            // 
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.witcher3_101;
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Name = "witcherIIIModdingToolLicenseToolStripMenuItem";
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Text = "Witcher III Modding Tool License";
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Click += new System.EventHandler(this.witcherIIIModdingToolLicenseToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.mail;
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItem_Click);
            // 
            // recordStepsToReproduceBugToolStripMenuItem
            // 
            this.recordStepsToReproduceBugToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.player_record;
            this.recordStepsToReproduceBugToolStripMenuItem.Name = "recordStepsToReproduceBugToolStripMenuItem";
            this.recordStepsToReproduceBugToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.recordStepsToReproduceBugToolStripMenuItem.Text = "Record steps to reproduce bug";
            this.recordStepsToReproduceBugToolStripMenuItem.Click += new System.EventHandler(this.RecordStepsToReproduceBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(245, 6);
            // 
            // aboutRedkit2ToolStripMenuItem
            // 
            this.aboutRedkit2ToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.info_icon_23818;
            this.aboutRedkit2ToolStripMenuItem.Name = "aboutRedkit2ToolStripMenuItem";
            this.aboutRedkit2ToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.aboutRedkit2ToolStripMenuItem.Text = "About Wolven kit";
            this.aboutRedkit2ToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // buildDateToolStripMenuItem
            // 
            this.buildDateToolStripMenuItem.Enabled = false;
            this.buildDateToolStripMenuItem.Name = "buildDateToolStripMenuItem";
            this.buildDateToolStripMenuItem.ShowShortcutKeys = false;
            this.buildDateToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.buildDateToolStripMenuItem.Text = "Build date";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(824, 418);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanel.Skin = dockPanelSkin1;
            this.dockPanel.TabIndex = 9;
            this.dockPanel.ActiveDocumentChanged += new System.EventHandler(this.dockPanel_ActiveDocumentChanged);
            // 
            // packageInstallerToolStripMenuItem
            // 
            this.packageInstallerToolStripMenuItem.Name = "packageInstallerToolStripMenuItem";
            this.packageInstallerToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.packageInstallerToolStripMenuItem.Text = "Package Installer";
            this.packageInstallerToolStripMenuItem.Click += new System.EventHandler(this.packageInstallerToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 418);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dockPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(584, 393);
            this.Name = "frmMain";
            this.Text = "Wolven kit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newModToolStripMenuItem;
        private ToolStripMenuItem openModToolStripMenuItem;
        private ToolStripMenuItem modToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem saveExplorerToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem modExplorerToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutRedkit2ToolStripMenuItem;
        private ToolStripMenuItem joinOurDiscordToolStripMenuItem;
        private ToolStripButton newmodButton;
        private ToolStripButton openmodButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton openfileButton;
        private ToolStripButton saveButton;
        private ToolStripButton saveallButton;
        private ToolStripButton toolStripButton7;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btPack;
        private DockPanel dockPanel;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem wcclitePatcherToolStripMenuItem;
        private ToolStripMenuItem outputToolStripMenuItem;
        private ToolStripMenuItem tutorialsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem reloadProjectToolStripMenuItem;
        private ToolStripMenuItem createPackedInstallerToolStripMenuItem;
        private ToolStripMenuItem witcherIIIModdingToolLicenseToolStripMenuItem;
        private ToolStripMenuItem buildDateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
        private ToolStripMenuItem chunkToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripDropDownButton rungameToolStrip;
        private ToolStripMenuItem launchWithCostumParametersToolStripMenuItem;
        private ToolStripMenuItem launchGameForDebuggingToolStripMenuItem;
        private ToolStripMenuItem addFileFromBundleToolStripMenuItem;
        private ToolStripMenuItem addFileFromOtherModToolStripMenuItem;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
		private ToolStripMenuItem stringsEncoderGUIToolStripMenuItem;
        private ToolStripMenuItem menuCreatorToolStripMenuItem;
        private ToolStripMenuItem recordStepsToReproduceBugToolStripMenuItem;
        private ToolStripMenuItem reportABugToolStripMenuItem;
        private ToolStripMenuItem gameDebuggerToolStripMenuItem;
        private ToolStripMenuItem packageInstallerToolStripMenuItem;
    }
}