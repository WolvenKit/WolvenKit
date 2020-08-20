namespace WolvenKit
{
    partial class frmMenuCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCreator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menutree = new System.Windows.Forms.TreeView();
            this.MenuEditor = new PropertyGridEx.PropertyGridEx();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editMainToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(842, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editMainToolStripMenuItem
            // 
            this.editMainToolStripMenuItem.Name = "editMainToolStripMenuItem";
            this.editMainToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.editMainToolStripMenuItem.Text = "Edit main";
            this.editMainToolStripMenuItem.Click += new System.EventHandler(this.editMainToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::WolvenKit.Properties.Resources.arrow_circle_315;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menutree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MenuEditor);
            this.splitContainer1.Size = new System.Drawing.Size(842, 543);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.TabIndex = 3;
            // 
            // menutree
            // 
            this.menutree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutree.Location = new System.Drawing.Point(0, 0);
            this.menutree.Name = "menutree";
            this.menutree.Size = new System.Drawing.Size(526, 543);
            this.menutree.TabIndex = 0;
            this.menutree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.menutree_NodeMouseClick);
            // 
            // MenuEditor
            // 
            // 
            // 
            // 
            this.MenuEditor.DocCommentDescription.AutoEllipsis = true;
            this.MenuEditor.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuEditor.DocCommentDescription.Location = new System.Drawing.Point(3, 18);
            this.MenuEditor.DocCommentDescription.Name = "";
            this.MenuEditor.DocCommentDescription.Size = new System.Drawing.Size(306, 37);
            this.MenuEditor.DocCommentDescription.TabIndex = 1;
            this.MenuEditor.DocCommentImage = null;
            // 
            // 
            // 
            this.MenuEditor.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuEditor.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.MenuEditor.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.MenuEditor.DocCommentTitle.Name = "";
            this.MenuEditor.DocCommentTitle.Size = new System.Drawing.Size(306, 15);
            this.MenuEditor.DocCommentTitle.TabIndex = 0;
            this.MenuEditor.DocCommentTitle.UseMnemonic = false;
            this.MenuEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuEditor.Location = new System.Drawing.Point(0, 0);
            this.MenuEditor.Name = "MenuEditor";
            this.MenuEditor.Size = new System.Drawing.Size(312, 543);
            this.MenuEditor.TabIndex = 0;
            // 
            // 
            // 
            this.MenuEditor.ToolStrip.AccessibleName = "ToolBar";
            this.MenuEditor.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.MenuEditor.ToolStrip.AllowMerge = false;
            this.MenuEditor.ToolStrip.AutoSize = false;
            this.MenuEditor.ToolStrip.CanOverflow = false;
            this.MenuEditor.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuEditor.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuEditor.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.MenuEditor.ToolStrip.Name = "";
            this.MenuEditor.ToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.MenuEditor.ToolStrip.Size = new System.Drawing.Size(312, 25);
            this.MenuEditor.ToolStrip.TabIndex = 1;
            this.MenuEditor.ToolStrip.TabStop = true;
            this.MenuEditor.ToolStrip.Text = "PropertyGridToolBar";
            // 
            // frmMenuCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 571);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuCreator";
            this.Text = "Menu Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView menutree;
        private System.Windows.Forms.ToolStripMenuItem editMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private PropertyGridEx.PropertyGridEx MenuEditor;
    }
}