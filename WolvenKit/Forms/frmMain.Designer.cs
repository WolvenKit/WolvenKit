using System;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolbarToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNewMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAssetbrowser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnPack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRunGame = new System.Windows.Forms.ToolStripDropDownButton();
            this.launchGameForDebuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packProjectAndLaunchGameCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchWithCustomParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packProjectAndRunGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnImportUtil = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRadishUtil = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCr2wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractCollisioncacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbxWithCollisionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvidiaClothFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w2rigjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w2animsjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ModscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modwwise = new System.Windows.Forms.ToolStripMenuItem();
            this.ModchunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlcwwise = new System.Windows.Forms.ToolStripMenuItem();
            this.DLCChunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileFromBundleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileFromOtherModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPackedInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsEncoderGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderW2meshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cR2WToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terrainViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.importUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radishUtilitytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDebuggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinOurDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.witcherIIIModdingToolLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordStepsToReproduceBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutRedkit2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLabelProject = new System.Windows.Forms.ToolStripMenuItem();
            this.DLCScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.statusToolStrip = new System.Windows.Forms.ToolStrip();
            this.statusLBL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.richpresenceworker = new System.ComponentModel.BackgroundWorker();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.MainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.visualStudioToolStripExtender2 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.toolbarToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusToolStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarToolStrip
            // 
            this.toolbarToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbarToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNewMod,
            this.toolStripBtnOpenMod,
            this.toolStripBtnOpenFile,
            this.toolStripSeparator1,
            this.toolStripBtnSave,
            this.toolStripBtnSaveAll,
            this.toolStripBtnAssetbrowser,
            this.toolStripSeparator2,
            this.toolStripBtnPack,
            this.toolStripBtnRunGame,
            this.toolStripSeparator10,
            this.toolStripBtnImportUtil,
            this.toolStripBtnRadishUtil});
            this.toolbarToolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolbarToolStrip.Name = "toolbarToolStrip";
            this.toolbarToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolbarToolStrip.Size = new System.Drawing.Size(36, 340);
            this.toolbarToolStrip.Stretch = true;
            this.toolbarToolStrip.TabIndex = 6;
            this.toolbarToolStrip.Text = "topTS";
            // 
            // toolStripBtnNewMod
            // 
            this.toolStripBtnNewMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNewMod.Image = global::WolvenKit.Properties.Resources.NewSolutionFolder_16x;
            this.toolStripBtnNewMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNewMod.Name = "toolStripBtnNewMod";
            this.toolStripBtnNewMod.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnNewMod.Text = "New mod";
            this.toolStripBtnNewMod.Click += new System.EventHandler(this.newModToolStripMenuItem_Click);
            // 
            // toolStripBtnOpenMod
            // 
            this.toolStripBtnOpenMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpenMod.Image = global::WolvenKit.Properties.Resources.OpenFolder_16x;
            this.toolStripBtnOpenMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenMod.Name = "toolStripBtnOpenMod";
            this.toolStripBtnOpenMod.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnOpenMod.Text = "Open mod";
            this.toolStripBtnOpenMod.Click += new System.EventHandler(this.openModToolStripMenuItem_Click);
            // 
            // toolStripBtnOpenFile
            // 
            this.toolStripBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpenFile.Image = global::WolvenKit.Properties.Resources.OpenFile_16x;
            this.toolStripBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenFile.Name = "toolStripBtnOpenFile";
            this.toolStripBtnOpenFile.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnOpenFile.Text = "Open file";
            this.toolStripBtnOpenFile.Click += new System.EventHandler(this.tbtOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(32, 6);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Image = global::WolvenKit.Properties.Resources.SaveStatusBar1_16x_c;
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnSave.Text = "Save";
            this.toolStripBtnSave.Click += new System.EventHandler(this.tbtSave_Click);
            // 
            // toolStripBtnSaveAll
            // 
            this.toolStripBtnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSaveAll.Image = global::WolvenKit.Properties.Resources.SaveAll_16x;
            this.toolStripBtnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveAll.Name = "toolStripBtnSaveAll";
            this.toolStripBtnSaveAll.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnSaveAll.Text = "toolStripButton5";
            this.toolStripBtnSaveAll.ToolTipText = "Save all";
            this.toolStripBtnSaveAll.Click += new System.EventHandler(this.tbtSaveAll_Click);
            // 
            // toolStripBtnAssetbrowser
            // 
            this.toolStripBtnAssetbrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAssetbrowser.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.toolStripBtnAssetbrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAssetbrowser.Name = "toolStripBtnAssetbrowser";
            this.toolStripBtnAssetbrowser.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnAssetbrowser.Text = "toolStripButton7";
            this.toolStripBtnAssetbrowser.ToolTipText = "Add file from bundle";
            this.toolStripBtnAssetbrowser.Click += new System.EventHandler(this.addFileFromBundleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(32, 6);
            // 
            // toolStripBtnPack
            // 
            this.toolStripBtnPack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPack.Image = global::WolvenKit.Properties.Resources.package_16xLG;
            this.toolStripBtnPack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPack.Name = "toolStripBtnPack";
            this.toolStripBtnPack.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnPack.Text = "btPack";
            this.toolStripBtnPack.ToolTipText = "Pack and install mod";
            this.toolStripBtnPack.Click += new System.EventHandler(this.toolStripBtnPack_Click);
            // 
            // toolStripBtnRunGame
            // 
            this.toolStripBtnRunGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRunGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchGameForDebuggingToolStripMenuItem,
            this.packProjectAndLaunchGameCustomToolStripMenuItem,
            this.launchWithCustomParametersToolStripMenuItem,
            this.packProjectToolStripMenuItem,
            this.packProjectAndRunGameToolStripMenuItem});
            this.toolStripBtnRunGame.Image = global::WolvenKit.Properties.Resources.witcher3;
            this.toolStripBtnRunGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRunGame.Name = "toolStripBtnRunGame";
            this.toolStripBtnRunGame.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnRunGame.Text = "Launch game";
            // 
            // launchGameForDebuggingToolStripMenuItem
            // 
            this.launchGameForDebuggingToolStripMenuItem.Name = "launchGameForDebuggingToolStripMenuItem";
            this.launchGameForDebuggingToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.launchGameForDebuggingToolStripMenuItem.Text = "Launch game for debugging";
            this.launchGameForDebuggingToolStripMenuItem.Click += new System.EventHandler(this.LaunchGameForDebuggingToolStripMenuItem_Click);
            // 
            // packProjectAndLaunchGameCustomToolStripMenuItem
            // 
            this.packProjectAndLaunchGameCustomToolStripMenuItem.Name = "packProjectAndLaunchGameCustomToolStripMenuItem";
            this.packProjectAndLaunchGameCustomToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.packProjectAndLaunchGameCustomToolStripMenuItem.Text = "Pack project and launch game with custom parameters";
            this.packProjectAndLaunchGameCustomToolStripMenuItem.Click += new System.EventHandler(this.packProjectAndLaunchGameCustomToolStripMenuItem_Click);
            // 
            // launchWithCustomParametersToolStripMenuItem
            // 
            this.launchWithCustomParametersToolStripMenuItem.Name = "launchWithCustomParametersToolStripMenuItem";
            this.launchWithCustomParametersToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.launchWithCustomParametersToolStripMenuItem.Text = "Launch with custom parameters";
            this.launchWithCustomParametersToolStripMenuItem.Click += new System.EventHandler(this.launchWithCostumParametersToolStripMenuItem_Click);
            // 
            // packProjectToolStripMenuItem
            // 
            this.packProjectToolStripMenuItem.Name = "packProjectToolStripMenuItem";
            this.packProjectToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.packProjectToolStripMenuItem.Text = "Pack project";
            this.packProjectToolStripMenuItem.Click += new System.EventHandler(this.packProjectToolStripMenuItem_Click);
            // 
            // packProjectAndRunGameToolStripMenuItem
            // 
            this.packProjectAndRunGameToolStripMenuItem.Name = "packProjectAndRunGameToolStripMenuItem";
            this.packProjectAndRunGameToolStripMenuItem.Size = new System.Drawing.Size(365, 22);
            this.packProjectAndRunGameToolStripMenuItem.Text = "Pack project and run game";
            this.packProjectAndRunGameToolStripMenuItem.Click += new System.EventHandler(this.PackProjectAndRunGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(32, 6);
            // 
            // toolStripBtnImportUtil
            // 
            this.toolStripBtnImportUtil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnImportUtil.Image = global::WolvenKit.Properties.Resources.ImportPackage_16x;
            this.toolStripBtnImportUtil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnImportUtil.Name = "toolStripBtnImportUtil";
            this.toolStripBtnImportUtil.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnImportUtil.Text = "Import Utility";
            this.toolStripBtnImportUtil.Click += new System.EventHandler(this.toolStripButtonImportUtil_Click);
            // 
            // toolStripBtnRadishUtil
            // 
            this.toolStripBtnRadishUtil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRadishUtil.Image = global::WolvenKit.Properties.Resources.radish_32x;
            this.toolStripBtnRadishUtil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRadishUtil.Name = "toolStripBtnRadishUtil";
            this.toolStripBtnRadishUtil.Size = new System.Drawing.Size(32, 24);
            this.toolStripBtnRadishUtil.Text = "Radish Utility";
            this.toolStripBtnRadishUtil.Click += new System.EventHandler(this.toolStripButtonRadishUtil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.modToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.buildDateToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.MenuLabelProject});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "topMS";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown_1);
            // 
            // iconToolStripMenuItem
            // 
            this.iconToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iconToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.wolven_kit_icon;
            this.iconToolStripMenuItem.Name = "iconToolStripMenuItem";
            this.iconToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.iconToolStripMenuItem.Click += new System.EventHandler(this.iconToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModToolStripMenuItem,
            this.openModToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator6,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // newModToolStripMenuItem
            // 
            this.newModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.NewSolutionFolder_16x;
            this.newModToolStripMenuItem.Name = "newModToolStripMenuItem";
            this.newModToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.newModToolStripMenuItem.Text = "New mod";
            this.newModToolStripMenuItem.Click += new System.EventHandler(this.tbtNewMod_Click);
            // 
            // openModToolStripMenuItem
            // 
            this.openModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.OpenFolder_16x;
            this.openModToolStripMenuItem.Name = "openModToolStripMenuItem";
            this.openModToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openModToolStripMenuItem.Text = "Open mod";
            this.openModToolStripMenuItem.Click += new System.EventHandler(this.tbtOpenMod_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.OpenFile_16x;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Enabled = false;
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent files";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(200, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCr2wToolStripMenuItem,
            this.extractCollisioncacheToolStripMenuItem});
            this.exportToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.wooden_box__arrow;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportCr2wToolStripMenuItem
            // 
            this.exportCr2wToolStripMenuItem.Name = "exportCr2wToolStripMenuItem";
            this.exportCr2wToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exportCr2wToolStripMenuItem.Text = "Export Cr2w";
            this.exportCr2wToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // extractCollisioncacheToolStripMenuItem
            // 
            this.extractCollisioncacheToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.t_shirt_gray;
            this.extractCollisioncacheToolStripMenuItem.Name = "extractCollisioncacheToolStripMenuItem";
            this.extractCollisioncacheToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.extractCollisioncacheToolStripMenuItem.Text = "Extract collision.cache";
            this.extractCollisioncacheToolStripMenuItem.Click += new System.EventHandler(this.extractCollisioncacheToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fbxWithCollisionsToolStripMenuItem,
            this.nvidiaClothFileToolStripMenuItem,
            this.w2rigjsonToolStripMenuItem,
            this.w2animsjsonToolStripMenuItem});
            this.importToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.box__arrow;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // fbxWithCollisionsToolStripMenuItem
            // 
            this.fbxWithCollisionsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.stickman;
            this.fbxWithCollisionsToolStripMenuItem.Name = "fbxWithCollisionsToolStripMenuItem";
            this.fbxWithCollisionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fbxWithCollisionsToolStripMenuItem.Text = "Fbx with collisions";
            this.fbxWithCollisionsToolStripMenuItem.Click += new System.EventHandler(this.fbxWithCollisionsToolStripMenuItem_Click);
            // 
            // nvidiaClothFileToolStripMenuItem
            // 
            this.nvidiaClothFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.t_shirt_gray;
            this.nvidiaClothFileToolStripMenuItem.Name = "nvidiaClothFileToolStripMenuItem";
            this.nvidiaClothFileToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.nvidiaClothFileToolStripMenuItem.Text = "Nvidia cloth file";
            this.nvidiaClothFileToolStripMenuItem.Click += new System.EventHandler(this.nvidiaClothFileToolStripMenuItem_Click);
            // 
            // w2rigjsonToolStripMenuItem
            // 
            this.w2rigjsonToolStripMenuItem.Name = "w2rigjsonToolStripMenuItem";
            this.w2rigjsonToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.w2rigjsonToolStripMenuItem.Text = "w2rig.json";
            this.w2rigjsonToolStripMenuItem.Click += new System.EventHandler(this.w2rigjsonToolStripMenuItem_Click);
            // 
            // w2animsjsonToolStripMenuItem
            // 
            this.w2animsjsonToolStripMenuItem.Name = "w2animsjsonToolStripMenuItem";
            this.w2animsjsonToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.w2animsjsonToolStripMenuItem.Text = "w2anims.json";
            this.w2animsjsonToolStripMenuItem.Click += new System.EventHandler(this.w2animsjsonToolStripMenuItem_Click);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modToolStripMenuItem1,
            this.dLCToolStripMenuItem});
            this.newFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.newFileToolStripMenuItem.Text = "New file";
            // 
            // modToolStripMenuItem1
            // 
            this.modToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModscriptToolStripMenuItem,
            this.modwwise,
            this.ModchunkToolStripMenuItem});
            this.modToolStripMenuItem1.Name = "modToolStripMenuItem1";
            this.modToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.modToolStripMenuItem1.Text = "Mod";
            // 
            // ModscriptToolStripMenuItem
            // 
            this.ModscriptToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.ModscriptToolStripMenuItem.Name = "ModscriptToolStripMenuItem";
            this.ModscriptToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ModscriptToolStripMenuItem.Text = "Script";
            this.ModscriptToolStripMenuItem.Click += new System.EventHandler(this.ModscriptToolStripMenuItem_Click);
            // 
            // modwwise
            // 
            this.modwwise.Image = global::WolvenKit.Properties.Resources.bug;
            this.modwwise.Name = "modwwise";
            this.modwwise.Size = new System.Drawing.Size(178, 22);
            this.modwwise.Text = "Wwise sound(bank)";
            this.modwwise.Click += new System.EventHandler(this.ModWwiseNew_Click);
            // 
            // ModchunkToolStripMenuItem
            // 
            this.ModchunkToolStripMenuItem.Enabled = false;
            this.ModchunkToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.ModchunkToolStripMenuItem.Name = "ModchunkToolStripMenuItem";
            this.ModchunkToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ModchunkToolStripMenuItem.Text = "Chunk file";
            // 
            // dLCToolStripMenuItem
            // 
            this.dLCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlcwwise,
            this.DLCChunkToolStripMenuItem});
            this.dLCToolStripMenuItem.Name = "dLCToolStripMenuItem";
            this.dLCToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dLCToolStripMenuItem.Text = "DLC";
            // 
            // dlcwwise
            // 
            this.dlcwwise.Image = global::WolvenKit.Properties.Resources.bug;
            this.dlcwwise.Name = "dlcwwise";
            this.dlcwwise.Size = new System.Drawing.Size(178, 22);
            this.dlcwwise.Text = "Wwise sound(bank)";
            this.dlcwwise.Click += new System.EventHandler(this.DLCWwise_Click);
            // 
            // DLCChunkToolStripMenuItem
            // 
            this.DLCChunkToolStripMenuItem.Enabled = false;
            this.DLCChunkToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.DLCChunkToolStripMenuItem.Name = "DLCChunkToolStripMenuItem";
            this.DLCChunkToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DLCChunkToolStripMenuItem.Text = "Chunk file";
            // 
            // addFileFromBundleToolStripMenuItem
            // 
            this.addFileFromBundleToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileFromBundleToolStripMenuItem.Name = "addFileFromBundleToolStripMenuItem";
            this.addFileFromBundleToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addFileFromBundleToolStripMenuItem.Text = "Asset browser";
            this.addFileFromBundleToolStripMenuItem.Click += new System.EventHandler(this.addFileFromBundleToolStripMenuItem_Click);
            // 
            // addFileFromOtherModToolStripMenuItem
            // 
            this.addFileFromOtherModToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileFromOtherModToolStripMenuItem.Name = "addFileFromOtherModToolStripMenuItem";
            this.addFileFromOtherModToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addFileFromOtherModToolStripMenuItem.Text = "Add file from other mod";
            this.addFileFromOtherModToolStripMenuItem.Click += new System.EventHandler(this.AddFileFromOtherModToolStripMenuItem_Click_1);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.AddNodefromFile_354;
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addFileToolStripMenuItem.Text = "Add file";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(200, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.SaveStatusBar1_16x_c;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.SaveAll_16x;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveAllToolStripMenuItem.Text = "Save all";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPackedInstallerToolStripMenuItem,
            this.reloadProjectToolStripMenuItem,
            this.toolStripSeparator4,
            this.settingsToolStripMenuItem});
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.modToolStripMenuItem.Text = "Project";
            this.modToolStripMenuItem.DropDownOpening += new System.EventHandler(this.modToolStripMenuItem_DropDownOpening);
            // 
            // createPackedInstallerToolStripMenuItem
            // 
            this.createPackedInstallerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.box__arrow;
            this.createPackedInstallerToolStripMenuItem.Name = "createPackedInstallerToolStripMenuItem";
            this.createPackedInstallerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.createPackedInstallerToolStripMenuItem.Text = "Create Packed Installer";
            this.createPackedInstallerToolStripMenuItem.Click += new System.EventHandler(this.createPackedInstallerToolStripMenuItem_Click);
            // 
            // reloadProjectToolStripMenuItem
            // 
            this.reloadProjectToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Refresh_16x;
            this.reloadProjectToolStripMenuItem.Name = "reloadProjectToolStripMenuItem";
            this.reloadProjectToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.reloadProjectToolStripMenuItem.Text = "Reload project";
            this.reloadProjectToolStripMenuItem.Click += new System.EventHandler(this.ReloadProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Settings_Inverse_16x;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.modSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageInstallerToolStripMenuItem,
            this.saveExplorerToolStripMenuItem,
            this.stringsEncoderGUIToolStripMenuItem,
            this.menuCreatorToolStripMenuItem,
            this.renderW2meshToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.experimentalToolStripMenuItem,
            this.toolStripSeparator5,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolsToolStripMenuItem_DropDownOpening);
            // 
            // packageInstallerToolStripMenuItem
            // 
            this.packageInstallerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.box;
            this.packageInstallerToolStripMenuItem.Name = "packageInstallerToolStripMenuItem";
            this.packageInstallerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.packageInstallerToolStripMenuItem.Text = "Package Installer";
            this.packageInstallerToolStripMenuItem.Click += new System.EventHandler(this.packageInstallerToolStripMenuItem_Click);
            // 
            // saveExplorerToolStripMenuItem
            // 
            this.saveExplorerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.properties_16xLG;
            this.saveExplorerToolStripMenuItem.Name = "saveExplorerToolStripMenuItem";
            this.saveExplorerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveExplorerToolStripMenuItem.Text = "Save explorer";
            this.saveExplorerToolStripMenuItem.Click += new System.EventHandler(this.saveExplorerToolStripMenuItem_Click);
            // 
            // stringsEncoderGUIToolStripMenuItem
            // 
            this.stringsEncoderGUIToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.edit_letter_spacing;
            this.stringsEncoderGUIToolStripMenuItem.Name = "stringsEncoderGUIToolStripMenuItem";
            this.stringsEncoderGUIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stringsEncoderGUIToolStripMenuItem.Text = "Strings Encoder GUI";
            this.stringsEncoderGUIToolStripMenuItem.Click += new System.EventHandler(this.StringsGUIToolStripMenuItem_Click);
            // 
            // menuCreatorToolStripMenuItem
            // 
            this.menuCreatorToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.ui_menu_blue;
            this.menuCreatorToolStripMenuItem.Name = "menuCreatorToolStripMenuItem";
            this.menuCreatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.menuCreatorToolStripMenuItem.Text = "Menu creator";
            this.menuCreatorToolStripMenuItem.Click += new System.EventHandler(this.menuCreatorToolStripMenuItem_Click);
            // 
            // renderW2meshToolStripMenuItem
            // 
            this.renderW2meshToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.ui_check_box_uncheck;
            this.renderW2meshToolStripMenuItem.Name = "renderW2meshToolStripMenuItem";
            this.renderW2meshToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.renderW2meshToolStripMenuItem.Tag = "false";
            this.renderW2meshToolStripMenuItem.Text = "Render w2mesh";
            this.renderW2meshToolStripMenuItem.Click += new System.EventHandler(this.renderW2meshToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verifyFileToolStripMenuItem,
            this.cR2WToTextToolStripMenuItem,
            this.dumpFileToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // verifyFileToolStripMenuItem
            // 
            this.verifyFileToolStripMenuItem.Name = "verifyFileToolStripMenuItem";
            this.verifyFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.verifyFileToolStripMenuItem.Text = "Verify File";
            this.verifyFileToolStripMenuItem.Click += new System.EventHandler(this.verifyFileToolStripMenuItem_Click);
            // 
            // cR2WToTextToolStripMenuItem
            // 
            this.cR2WToTextToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.TextFileIcon64px;
            this.cR2WToTextToolStripMenuItem.Name = "cR2WToTextToolStripMenuItem";
            this.cR2WToTextToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cR2WToTextToolStripMenuItem.Text = "CR2W To Text";
            this.cR2WToTextToolStripMenuItem.Click += new System.EventHandler(this.cR2WToTextToolStripMenuItem_Click);
            // 
            // dumpFileToolStripMenuItem
            // 
            this.dumpFileToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.bug;
            this.dumpFileToolStripMenuItem.Name = "dumpFileToolStripMenuItem";
            this.dumpFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dumpFileToolStripMenuItem.Text = "Dump game assets";
            this.dumpFileToolStripMenuItem.Click += new System.EventHandler(this.dumpFileToolStripMenuItem_Click);
            // 
            // experimentalToolStripMenuItem
            // 
            this.experimentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terrainViewerToolStripMenuItem});
            this.experimentalToolStripMenuItem.Name = "experimentalToolStripMenuItem";
            this.experimentalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.experimentalToolStripMenuItem.Text = "Experimental";
            // 
            // terrainViewerToolStripMenuItem
            // 
            this.terrainViewerToolStripMenuItem.Name = "terrainViewerToolStripMenuItem";
            this.terrainViewerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.terrainViewerToolStripMenuItem.Text = "Terrain viewer";
            this.terrainViewerToolStripMenuItem.Click += new System.EventHandler(this.terrainViewerToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(175, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Settings_Inverse_16x;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modExplorerToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.scriptToolStripMenuItem,
            this.toolStripSeparator9,
            this.importUtilityToolStripMenuItem,
            this.radishUtilitytoolStripMenuItem,
            this.gameDebuggerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
            // 
            // modExplorerToolStripMenuItem
            // 
            this.modExplorerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.RemoteServer_16x;
            this.modExplorerToolStripMenuItem.Name = "modExplorerToolStripMenuItem";
            this.modExplorerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.modExplorerToolStripMenuItem.Text = "Mod explorer";
            this.modExplorerToolStripMenuItem.Click += new System.EventHandler(this.modExplorerToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Output_16x;
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.outputToolStripMenuItem.Text = "Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.Console_16x;
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.PlayStep_16x;
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.scriptToolStripMenuItem.Text = "Script Manager";
            this.scriptToolStripMenuItem.Click += new System.EventHandler(this.scriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(181, 6);
            // 
            // importUtilityToolStripMenuItem
            // 
            this.importUtilityToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.ImportPackage_16x;
            this.importUtilityToolStripMenuItem.Name = "importUtilityToolStripMenuItem";
            this.importUtilityToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.importUtilityToolStripMenuItem.Text = "Import Utility";
            this.importUtilityToolStripMenuItem.Click += new System.EventHandler(this.importUtilityToolStripMenuItem_Click);
            // 
            // radishUtilitytoolStripMenuItem
            // 
            this.radishUtilitytoolStripMenuItem.Image = global::WolvenKit.Properties.Resources.radish_32x;
            this.radishUtilitytoolStripMenuItem.Name = "radishUtilitytoolStripMenuItem";
            this.radishUtilitytoolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.radishUtilitytoolStripMenuItem.Text = "Radish Utility";
            this.radishUtilitytoolStripMenuItem.Click += new System.EventHandler(this.RadishUtilitytoolStripMenuItem_Click);
            // 
            // gameDebuggerToolStripMenuItem
            // 
            this.gameDebuggerToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.bug;
            this.gameDebuggerToolStripMenuItem.Name = "gameDebuggerToolStripMenuItem";
            this.gameDebuggerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.gameDebuggerToolStripMenuItem.Text = "Game debugger";
            this.gameDebuggerToolStripMenuItem.Click += new System.EventHandler(this.GameDebuggerToolStripMenuItem_Click);
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
            this.aboutRedkit2ToolStripMenuItem,
            this.donateToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // joinOurDiscordToolStripMenuItem
            // 
            this.joinOurDiscordToolStripMenuItem.Image = global::WolvenKit.Properties.Resources._2c21aeda16de354ba5334551a883b481;
            this.joinOurDiscordToolStripMenuItem.Name = "joinOurDiscordToolStripMenuItem";
            this.joinOurDiscordToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.joinOurDiscordToolStripMenuItem.Text = "Join our discord";
            this.joinOurDiscordToolStripMenuItem.Click += new System.EventHandler(this.joinOurDiscordToolStripMenuItem_Click_1);
            // 
            // tutorialsToolStripMenuItem
            // 
            this.tutorialsToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.info_icon_23818;
            this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
            this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tutorialsToolStripMenuItem.Text = "Witcherscript documentation";
            this.tutorialsToolStripMenuItem.Click += new System.EventHandler(this.WitcherScriptToolStripMenuItem_Click);
            // 
            // witcherIIIModdingToolLicenseToolStripMenuItem
            // 
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.witcher3;
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Name = "witcherIIIModdingToolLicenseToolStripMenuItem";
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Text = "Witcher III Modding Tool License";
            this.witcherIIIModdingToolLicenseToolStripMenuItem.Click += new System.EventHandler(this.witcherIIIModdingToolLicenseToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.mail;
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.ReportABugToolStripMenuItem_Click);
            // 
            // recordStepsToReproduceBugToolStripMenuItem
            // 
            this.recordStepsToReproduceBugToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.player_record;
            this.recordStepsToReproduceBugToolStripMenuItem.Name = "recordStepsToReproduceBugToolStripMenuItem";
            this.recordStepsToReproduceBugToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.recordStepsToReproduceBugToolStripMenuItem.Text = "Record steps to reproduce bug";
            this.recordStepsToReproduceBugToolStripMenuItem.Click += new System.EventHandler(this.RecordStepsToReproduceBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(243, 6);
            // 
            // aboutRedkit2ToolStripMenuItem
            // 
            this.aboutRedkit2ToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.info_icon_23818;
            this.aboutRedkit2ToolStripMenuItem.Name = "aboutRedkit2ToolStripMenuItem";
            this.aboutRedkit2ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutRedkit2ToolStripMenuItem.Text = "About Wolven kit";
            this.aboutRedkit2ToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donateToolStripMenuItem.Image")));
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // buildDateToolStripMenuItem
            // 
            this.buildDateToolStripMenuItem.Enabled = false;
            this.buildDateToolStripMenuItem.Name = "buildDateToolStripMenuItem";
            this.buildDateToolStripMenuItem.ShowShortcutKeys = false;
            this.buildDateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.buildDateToolStripMenuItem.Text = "Build date";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximizeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maximizeToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.maximize1;
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.maximizeToolStripMenuItem.Text = "Maximize";
            this.maximizeToolStripMenuItem.ToolTipText = "Restore";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimizeToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.minimize;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.ToolTipText = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItem_Click);
            // 
            // MenuLabelProject
            // 
            this.MenuLabelProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuLabelProject.Enabled = false;
            this.MenuLabelProject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuLabelProject.Name = "MenuLabelProject";
            this.MenuLabelProject.ShowShortcutKeys = false;
            this.MenuLabelProject.Size = new System.Drawing.Size(72, 24);
            this.MenuLabelProject.Text = "Build date";
            // 
            // DLCScriptToolStripMenuItem
            // 
            this.DLCScriptToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.FileGroup_10135_16x;
            this.DLCScriptToolStripMenuItem.Name = "DLCScriptToolStripMenuItem";
            this.DLCScriptToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DLCScriptToolStripMenuItem.Text = "Script";
            this.DLCScriptToolStripMenuItem.Click += new System.EventHandler(this.DLCScriptToolStripMenuItem_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.ShowDocumentIcon = true;
            this.dockPanel.Size = new System.Drawing.Size(788, 340);
            this.dockPanel.TabIndex = 9;
            this.dockPanel.ActiveDocumentChanged += new System.EventHandler(this.dockPanel_ActiveDocumentChanged);
            // 
            // statusToolStrip
            // 
            this.statusToolStrip.BackColor = System.Drawing.SystemColors.Desktop;
            this.statusToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.statusToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLBL,
            this.toolStripProgressBar1});
            this.statusToolStrip.Location = new System.Drawing.Point(0, 393);
            this.statusToolStrip.Name = "statusToolStrip";
            this.statusToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.statusToolStrip.Size = new System.Drawing.Size(824, 25);
            this.statusToolStrip.TabIndex = 12;
            this.statusToolStrip.Text = "bottomTS";
            // 
            // statusLBL
            // 
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(39, 22);
            this.statusLBL.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Visible = false;
            // 
            // richpresenceworker
            // 
            this.richpresenceworker.WorkerSupportsCancellation = true;
            this.richpresenceworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.richpresenceworker_DoWork);
            this.richpresenceworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.richpresenceworker_ProgressChanged);
            this.richpresenceworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.richpresenceworker_RunWorkerCompleted);
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dockPanel);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(788, 340);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolbarToolStrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(824, 365);
            this.toolStripContainer1.TabIndex = 14;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // visualStudioToolStripExtender2
            // 
            this.visualStudioToolStripExtender2.DefaultRenderer = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 418);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(575, 365);
            this.Name = "frmMain";
            this.Text = "Wolven kit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.toolbarToolStrip.ResumeLayout(false);
            this.toolbarToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusToolStrip.ResumeLayout(false);
            this.statusToolStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolbarToolStrip;
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
        private ToolStripButton toolStripBtnNewMod;
        private ToolStripButton toolStripBtnOpenMod;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBtnOpenFile;
        private ToolStripButton toolStripBtnSave;
        private ToolStripButton toolStripBtnSaveAll;
        private ToolStripButton toolStripBtnAssetbrowser;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripBtnPack;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
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
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripDropDownButton toolStripBtnRunGame;
        private ToolStripMenuItem launchWithCustomParametersToolStripMenuItem;
        private ToolStripMenuItem launchGameForDebuggingToolStripMenuItem;
        private ToolStripMenuItem addFileFromBundleToolStripMenuItem;
        private ToolStripMenuItem addFileFromOtherModToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
		private ToolStripMenuItem stringsEncoderGUIToolStripMenuItem;
        private ToolStripMenuItem menuCreatorToolStripMenuItem;
        private ToolStripMenuItem recordStepsToReproduceBugToolStripMenuItem;
        private ToolStripMenuItem reportABugToolStripMenuItem;
        private ToolStripMenuItem packageInstallerToolStripMenuItem;
        private ToolStrip statusToolStrip;
        private ToolStripLabel statusLBL;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripMenuItem packProjectToolStripMenuItem;
        private ToolStripMenuItem modToolStripMenuItem1;
        private ToolStripMenuItem ModscriptToolStripMenuItem;
        private ToolStripMenuItem ModchunkToolStripMenuItem;
        private ToolStripMenuItem dLCToolStripMenuItem;
        private ToolStripMenuItem DLCChunkToolStripMenuItem;
        private ToolStripMenuItem recentFilesToolStripMenuItem;
        private ToolStripMenuItem donateToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem fbxWithCollisionsToolStripMenuItem;
        private ToolStripMenuItem nvidiaClothFileToolStripMenuItem;
        private ToolStripMenuItem renderW2meshToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem modwwise;
        private ToolStripMenuItem dlcwwise;
        private BackgroundWorker richpresenceworker;
        private ToolStripMenuItem packProjectAndLaunchGameCustomToolStripMenuItem;
        private ToolStripMenuItem packProjectAndRunGameToolStripMenuItem;
        private ToolStripMenuItem exportCr2wToolStripMenuItem;
        private ToolStripMenuItem extractCollisioncacheToolStripMenuItem;
        private VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private ToolStripMenuItem addFileToolStripMenuItem;
        private ToolStripMenuItem iconToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem experimentalToolStripMenuItem;
        private ToolStripMenuItem terrainViewerToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem consoleToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
        private ToolStripMenuItem w2rigjsonToolStripMenuItem;
        private ToolStripMenuItem w2animsjsonToolStripMenuItem;
        private ToolStripMenuItem importUtilityToolStripMenuItem;
        private DockPanel dockPanel;
        private ToolStripMenuItem DLCScriptToolStripMenuItem;
        private ToolStripMenuItem radishUtilitytoolStripMenuItem;
        private BackgroundWorker MainBackgroundWorker;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton toolStripBtnImportUtil;
        private ToolStripButton toolStripBtnRadishUtil;
        private ToolStripMenuItem MenuLabelProject;
        private ToolStripMenuItem advancedToolStripMenuItem;
        private ToolStripMenuItem verifyFileToolStripMenuItem;
        private ToolStripMenuItem cR2WToTextToolStripMenuItem;
        private ToolStripMenuItem dumpFileToolStripMenuItem;
        private ToolStripMenuItem gameDebuggerToolStripMenuItem;
        private VisualStudioToolStripExtender visualStudioToolStripExtender2;
    }
}
