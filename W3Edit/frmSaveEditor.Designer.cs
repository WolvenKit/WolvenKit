using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmSaveEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.savesTree = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.saveVariableBox = new System.Windows.Forms.TextBox();
            this.saveNamesBox = new System.Windows.Forms.TextBox();
            this.saveVersionBox = new System.Windows.Forms.TextBox();
            this.saveNameBox = new System.Windows.Forms.TextBox();
            this.saveIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.variableTab = new System.Windows.Forms.TabPage();
            this.variablesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeImages = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.infoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).BeginInit();
            this.variableTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WolvenKit.Properties.Resources.refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Refresh saves";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "About";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.savesTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(802, 480);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 1;
            // 
            // savesTree
            // 
            this.savesTree.BackColor = System.Drawing.SystemColors.Control;
            this.savesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savesTree.Location = new System.Drawing.Point(0, 0);
            this.savesTree.Name = "savesTree";
            this.savesTree.Size = new System.Drawing.Size(267, 480);
            this.savesTree.TabIndex = 0;
            this.savesTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.savesTree_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Controls.Add(this.variableTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // infoTab
            // 
            this.infoTab.BackColor = System.Drawing.SystemColors.Control;
            this.infoTab.Controls.Add(this.saveVariableBox);
            this.infoTab.Controls.Add(this.saveNamesBox);
            this.infoTab.Controls.Add(this.saveVersionBox);
            this.infoTab.Controls.Add(this.saveNameBox);
            this.infoTab.Controls.Add(this.saveIcon);
            this.infoTab.Controls.Add(this.label4);
            this.infoTab.Controls.Add(this.label3);
            this.infoTab.Controls.Add(this.label2);
            this.infoTab.Controls.Add(this.label1);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(523, 454);
            this.infoTab.TabIndex = 0;
            this.infoTab.Text = "Info";
            // 
            // saveVariableBox
            // 
            this.saveVariableBox.BackColor = System.Drawing.Color.White;
            this.saveVariableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveVariableBox.Location = new System.Drawing.Point(130, 161);
            this.saveVariableBox.Name = "saveVariableBox";
            this.saveVariableBox.Size = new System.Drawing.Size(193, 31);
            this.saveVariableBox.TabIndex = 9;
            // 
            // saveNamesBox
            // 
            this.saveNamesBox.BackColor = System.Drawing.Color.White;
            this.saveNamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveNamesBox.Location = new System.Drawing.Point(130, 112);
            this.saveNamesBox.Name = "saveNamesBox";
            this.saveNamesBox.Size = new System.Drawing.Size(193, 31);
            this.saveNamesBox.TabIndex = 8;
            // 
            // saveVersionBox
            // 
            this.saveVersionBox.BackColor = System.Drawing.Color.White;
            this.saveVersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveVersionBox.Location = new System.Drawing.Point(130, 63);
            this.saveVersionBox.Name = "saveVersionBox";
            this.saveVersionBox.Size = new System.Drawing.Size(193, 31);
            this.saveVersionBox.TabIndex = 7;
            // 
            // saveNameBox
            // 
            this.saveNameBox.BackColor = System.Drawing.Color.White;
            this.saveNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveNameBox.Location = new System.Drawing.Point(130, 14);
            this.saveNameBox.Name = "saveNameBox";
            this.saveNameBox.Size = new System.Drawing.Size(358, 31);
            this.saveNameBox.TabIndex = 6;
            // 
            // saveIcon
            // 
            this.saveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveIcon.Location = new System.Drawing.Point(88, 218);
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(372, 216);
            this.saveIcon.TabIndex = 5;
            this.saveIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Variables:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // variableTab
            // 
            this.variableTab.Controls.Add(this.variablesList);
            this.variableTab.Location = new System.Drawing.Point(4, 22);
            this.variableTab.Name = "variableTab";
            this.variableTab.Padding = new System.Windows.Forms.Padding(3);
            this.variableTab.Size = new System.Drawing.Size(523, 454);
            this.variableTab.TabIndex = 1;
            this.variableTab.Text = "Variables";
            this.variableTab.UseVisualStyleBackColor = true;
            // 
            // variablesList
            // 
            this.variablesList.BackColor = System.Drawing.SystemColors.Control;
            this.variablesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.variablesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variablesList.FullRowSelect = true;
            this.variablesList.LargeImageList = this.treeImages;
            this.variablesList.Location = new System.Drawing.Point(3, 3);
            this.variablesList.Name = "variablesList";
            this.variablesList.Size = new System.Drawing.Size(517, 448);
            this.variablesList.TabIndex = 0;
            this.variablesList.UseCompatibleStateImageBehavior = false;
            this.variablesList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Debug";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Children";
            // 
            // treeImages
            // 
            this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImages.ImageStream")));
            this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImages.Images.SetKeyName(0, "genericFile");
            this.treeImages.Images.SetKeyName(1, "normalFolder");
            this.treeImages.Images.SetKeyName(2, "openFolder");
            // 
            // frmSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(802, 505);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSaveEditor";
            this.ShowIcon = false;
            this.Text = "Save Explorer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).EndInit();
            this.variableTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private TreeView savesTree;
        private TabControl tabControl1;
        private TabPage infoTab;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripButton toolStripButton1;
        private TabPage variableTab;
        private PictureBox saveIcon;
        private TextBox saveNameBox;
        private TextBox saveVariableBox;
        private TextBox saveNamesBox;
        private TextBox saveVersionBox;
        private ToolStripLabel toolStripLabel1;
        private ListView variablesList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ImageList treeImages;
    }
}