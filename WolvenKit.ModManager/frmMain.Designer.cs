namespace WolvenKit.ModManager
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mods = new System.Windows.Forms.TabPage();
            this.dlcs = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ModList = new System.Windows.Forms.ListView();
            this.DLCList = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mods.SuspendLayout();
            this.dlcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModToolStripMenuItem,
            this.addDLCToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addModToolStripMenuItem
            // 
            this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            this.addModToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addModToolStripMenuItem.Text = "Add mod";
            this.addModToolStripMenuItem.Click += new System.EventHandler(this.addModToolStripMenuItem_Click);
            // 
            // addDLCToolStripMenuItem
            // 
            this.addDLCToolStripMenuItem.Name = "addDLCToolStripMenuItem";
            this.addDLCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDLCToolStripMenuItem.Text = "Add DLC";
            this.addDLCToolStripMenuItem.Click += new System.EventHandler(this.addDLCToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // launchGameToolStripMenuItem
            // 
            this.launchGameToolStripMenuItem.Name = "launchGameToolStripMenuItem";
            this.launchGameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.launchGameToolStripMenuItem.Text = "Launch game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1057, 600);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mods);
            this.tabControl1.Controls.Add(this.dlcs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // mods
            // 
            this.mods.Controls.Add(this.ModList);
            this.mods.Location = new System.Drawing.Point(4, 22);
            this.mods.Name = "mods";
            this.mods.Padding = new System.Windows.Forms.Padding(3);
            this.mods.Size = new System.Drawing.Size(344, 574);
            this.mods.TabIndex = 0;
            this.mods.Text = "Mods";
            this.mods.UseVisualStyleBackColor = true;
            // 
            // dlcs
            // 
            this.dlcs.Controls.Add(this.DLCList);
            this.dlcs.Location = new System.Drawing.Point(4, 22);
            this.dlcs.Name = "dlcs";
            this.dlcs.Padding = new System.Windows.Forms.Padding(3);
            this.dlcs.Size = new System.Drawing.Size(344, 574);
            this.dlcs.TabIndex = 1;
            this.dlcs.Text = "DLCs";
            this.dlcs.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(701, 600);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ModList
            // 
            this.ModList.CheckBoxes = true;
            this.ModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModList.Location = new System.Drawing.Point(3, 3);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(338, 568);
            this.ModList.TabIndex = 0;
            this.ModList.UseCompatibleStateImageBehavior = false;
            this.ModList.View = System.Windows.Forms.View.List;
            // 
            // DLCList
            // 
            this.DLCList.CheckBoxes = true;
            this.DLCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLCList.Location = new System.Drawing.Point(3, 3);
            this.DLCList.Name = "DLCList";
            this.DLCList.Size = new System.Drawing.Size(338, 568);
            this.DLCList.TabIndex = 0;
            this.DLCList.UseCompatibleStateImageBehavior = false;
            this.DLCList.View = System.Windows.Forms.View.List;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 624);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Witcher 3 Mod Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mods.ResumeLayout(false);
            this.dlcs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mods;
        private System.Windows.Forms.TabPage dlcs;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView ModList;
        private System.Windows.Forms.ListView DLCList;
    }
}

