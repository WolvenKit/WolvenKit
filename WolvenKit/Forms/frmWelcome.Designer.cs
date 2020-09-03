namespace WolvenKit.Forms
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.checkBoxDisable = new System.Windows.Forms.CheckBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.wolvenKitLbl = new System.Windows.Forms.Label();
            this.communityToolsLbl = new System.Windows.Forms.Label();
            this.learnLbl = new System.Windows.Forms.Label();
            this.getStartedLbl = new System.Windows.Forms.Label();
            this.openRecentLbl = new System.Windows.Forms.Label();
            this.helpWebBrowser = new System.Windows.Forms.WebBrowser();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.continueWithoutProjectBtn = new System.Windows.Forms.Label();
            this.newProjectBtn = new System.Windows.Forms.Button();
            this.openProjectBtn = new System.Windows.Forms.Button();
            this.preferencesBtn = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDisable
            // 
            this.checkBoxDisable.AutoSize = true;
            this.checkBoxDisable.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDisable.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisable.Location = new System.Drawing.Point(-24, 925);
            this.checkBoxDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDisable.Name = "checkBoxDisable";
            this.checkBoxDisable.Padding = new System.Windows.Forms.Padding(68, 15, 15, 15);
            this.checkBoxDisable.Size = new System.Drawing.Size(370, 61);
            this.checkBoxDisable.TabIndex = 5;
            this.checkBoxDisable.Text = "Don\'t show this form at startup";
            this.checkBoxDisable.UseCompatibleTextRendering = true;
            this.checkBoxDisable.UseVisualStyleBackColor = false;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.BackColor = System.Drawing.SystemColors.Control;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(60, 230);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(600, 500);
            this.objectListView1.TabIndex = 13;
            this.objectListView1.TileSize = new System.Drawing.Size(400, 40);
            this.objectListView1.UseCellFormatEvents = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Tile;
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_CellClick);
            this.objectListView1.CellOver += new System.EventHandler<BrightIdeasSoftware.CellOverEventArgs>(this.objectListView1_CellOver);
            this.objectListView1.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.objectListView1_CellToolTipShowing);
            this.objectListView1.MouseLeave += new System.EventHandler(this.objectListView1_MouseLeave);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Filename";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.IsTileViewColumn = true;
            this.olvColumn1.Text = "Filename";
            this.olvColumn1.Width = 100;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Fullpath";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.IsTileViewColumn = true;
            this.olvColumn2.Text = "Fullpath";
            // 
            // wolvenKitLbl
            // 
            this.wolvenKitLbl.AutoSize = true;
            this.wolvenKitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold);
            this.wolvenKitLbl.ForeColor = System.Drawing.Color.Black;
            this.wolvenKitLbl.Location = new System.Drawing.Point(50, 40);
            this.wolvenKitLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wolvenKitLbl.Name = "wolvenKitLbl";
            this.wolvenKitLbl.Size = new System.Drawing.Size(346, 78);
            this.wolvenKitLbl.TabIndex = 14;
            this.wolvenKitLbl.Text = "WolvenKit";
            this.wolvenKitLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wolvenKitLbl_MouseDown);
            // 
            // communityToolsLbl
            // 
            this.communityToolsLbl.AutoSize = true;
            this.communityToolsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.communityToolsLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.communityToolsLbl.Location = new System.Drawing.Point(65, 112);
            this.communityToolsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.communityToolsLbl.Name = "communityToolsLbl";
            this.communityToolsLbl.Size = new System.Drawing.Size(408, 29);
            this.communityToolsLbl.TabIndex = 15;
            this.communityToolsLbl.Text = "Witcher 3 Community Modding Tools";
            this.communityToolsLbl.Click += new System.EventHandler(this.label2_Click);
            this.communityToolsLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.communityToolsLbl_MouseDown);
            // 
            // learnLbl
            // 
            this.learnLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.learnLbl.AutoSize = true;
            this.learnLbl.Font = new System.Drawing.Font("Calibri", 18F);
            this.learnLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.learnLbl.Location = new System.Drawing.Point(800, 630);
            this.learnLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.learnLbl.Name = "learnLbl";
            this.learnLbl.Size = new System.Drawing.Size(87, 44);
            this.learnLbl.TabIndex = 17;
            this.learnLbl.Text = "Help";
            // 
            // getStartedLbl
            // 
            this.getStartedLbl.AutoSize = true;
            this.getStartedLbl.Font = new System.Drawing.Font("Calibri", 18F);
            this.getStartedLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.getStartedLbl.Location = new System.Drawing.Point(800, 170);
            this.getStartedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getStartedLbl.Name = "getStartedLbl";
            this.getStartedLbl.Size = new System.Drawing.Size(189, 44);
            this.getStartedLbl.TabIndex = 18;
            this.getStartedLbl.Text = "Get Started";
            this.getStartedLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // openRecentLbl
            // 
            this.openRecentLbl.AutoSize = true;
            this.openRecentLbl.Font = new System.Drawing.Font("Calibri", 18F);
            this.openRecentLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.openRecentLbl.Location = new System.Drawing.Point(50, 170);
            this.openRecentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openRecentLbl.Name = "openRecentLbl";
            this.openRecentLbl.Size = new System.Drawing.Size(209, 44);
            this.openRecentLbl.TabIndex = 19;
            this.openRecentLbl.Text = "Open Recent";
            // 
            // helpWebBrowser
            // 
            this.helpWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpWebBrowser.Location = new System.Drawing.Point(800, 679);
            this.helpWebBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpWebBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.helpWebBrowser.Name = "helpWebBrowser";
            this.helpWebBrowser.ScrollBarsEnabled = false;
            this.helpWebBrowser.Size = new System.Drawing.Size(500, 245);
            this.helpWebBrowser.TabIndex = 20;
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // continueWithoutProjectBtn
            // 
            this.continueWithoutProjectBtn.AutoSize = true;
            this.continueWithoutProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueWithoutProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueWithoutProjectBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.continueWithoutProjectBtn.Location = new System.Drawing.Point(900, 530);
            this.continueWithoutProjectBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.continueWithoutProjectBtn.Name = "continueWithoutProjectBtn";
            this.continueWithoutProjectBtn.Size = new System.Drawing.Size(307, 29);
            this.continueWithoutProjectBtn.TabIndex = 4;
            this.continueWithoutProjectBtn.Text = "Continue Without Project →";
            this.continueWithoutProjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continueWithoutProjectBtn.Click += new System.EventHandler(this.continueWithoutProjectBtn_Click);
            this.continueWithoutProjectBtn.MouseEnter += new System.EventHandler(this.continueWithoutProjectBtn_Enter);
            this.continueWithoutProjectBtn.MouseLeave += new System.EventHandler(this.continueWithoutProjectBtn_Leave);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProjectBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.newProjectBtn.Image = global::WolvenKit.Properties.Resources.New_Project_dark_64x;
            this.newProjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newProjectBtn.Location = new System.Drawing.Point(800, 230);
            this.newProjectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(500, 80);
            this.newProjectBtn.TabIndex = 1;
            this.newProjectBtn.Text = "New Project";
            this.newProjectBtn.UseVisualStyleBackColor = true;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            this.newProjectBtn.MouseEnter += new System.EventHandler(this.newProjectBtn_MouseEnter);
            this.newProjectBtn.MouseLeave += new System.EventHandler(this.newProjectBtn_MouseLeave);
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProjectBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.openProjectBtn.Image = global::WolvenKit.Properties.Resources.Open_Project_dark_64x;
            this.openProjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openProjectBtn.Location = new System.Drawing.Point(800, 320);
            this.openProjectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(500, 80);
            this.openProjectBtn.TabIndex = 2;
            this.openProjectBtn.Text = "Open Project";
            this.openProjectBtn.UseVisualStyleBackColor = true;
            this.openProjectBtn.Click += new System.EventHandler(this.openProjectBtn_Click);
            this.openProjectBtn.MouseEnter += new System.EventHandler(this.openProjectBtn_MouseEnter);
            this.openProjectBtn.MouseLeave += new System.EventHandler(this.openProjectBtn_MouseLeave);
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preferencesBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.preferencesBtn.Image = global::WolvenKit.Properties.Resources.Preferences_dark_64x;
            this.preferencesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preferencesBtn.Location = new System.Drawing.Point(800, 410);
            this.preferencesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.Size = new System.Drawing.Size(500, 80);
            this.preferencesBtn.TabIndex = 3;
            this.preferencesBtn.Text = "Preferences";
            this.preferencesBtn.UseVisualStyleBackColor = true;
            this.preferencesBtn.Click += new System.EventHandler(this.preferencesBtn_Click);
            this.preferencesBtn.MouseEnter += new System.EventHandler(this.preferencesBtn_MouseEnter);
            this.preferencesBtn.MouseLeave += new System.EventHandler(this.preferencesBtn_MouseLeave);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1400, 36);
            this.mainMenuStrip.TabIndex = 23;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMenuStrip_MouseDown);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.window_close_24x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(28, 32);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1400, 1000);
            this.Controls.Add(this.preferencesBtn);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.newProjectBtn);
            this.Controls.Add(this.continueWithoutProjectBtn);
            this.Controls.Add(this.helpWebBrowser);
            this.Controls.Add(this.openRecentLbl);
            this.Controls.Add(this.getStartedLbl);
            this.Controls.Add(this.learnLbl);
            this.Controls.Add(this.communityToolsLbl);
            this.Controls.Add(this.wolvenKitLbl);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.checkBoxDisable);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1400, 1000);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWelcome_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDisable;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Label wolvenKitLbl;
        private System.Windows.Forms.Label communityToolsLbl;
        private System.Windows.Forms.Label learnLbl;
        private System.Windows.Forms.Label getStartedLbl;
        private System.Windows.Forms.Label openRecentLbl;
        private System.Windows.Forms.WebBrowser helpWebBrowser;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private System.Windows.Forms.Label continueWithoutProjectBtn;
        private System.Windows.Forms.Button newProjectBtn;
        private System.Windows.Forms.Button openProjectBtn;
        private System.Windows.Forms.Button preferencesBtn;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}