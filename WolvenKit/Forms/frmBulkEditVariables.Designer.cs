namespace WolvenKit.Forms
{
    partial class frmBulkEditVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBulkEditVariables));
            this.VariableListTreeView = new System.Windows.Forms.TreeView();
            this.treeViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTopLevelNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VariablesGroupBox = new System.Windows.Forms.GroupBox();
            this.VariableDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnVarDetailsReset = new System.Windows.Forms.Button();
            this.btnVarDetailsApply = new System.Windows.Forms.Button();
            this.rdbtnEdit = new System.Windows.Forms.RadioButton();
            this.rdbtnAdd = new System.Windows.Forms.RadioButton();
            this.rdbtnRemove = new System.Windows.Forms.RadioButton();
            this.cmbBoxVarType = new System.Windows.Forms.ComboBox();
            this.txtBoxVarValue = new System.Windows.Forms.TextBox();
            this.txtBoxVarName = new System.Windows.Forms.TextBox();
            this.lblVarType = new System.Windows.Forms.Label();
            this.lblVarValue = new System.Windows.Forms.Label();
            this.lblVarName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.FilesToolStrip = new System.Windows.Forms.ToolStrip();
            this.SelectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnselectAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.FilterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExtensionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ExtensionToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FCDToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.treeViewContextMenuStrip.SuspendLayout();
            this.VariablesGroupBox.SuspendLayout();
            this.VariableDetailsGroupBox.SuspendLayout();
            this.FilesToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VariableListTreeView
            // 
            this.VariableListTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariableListTreeView.ContextMenuStrip = this.treeViewContextMenuStrip;
            this.VariableListTreeView.Location = new System.Drawing.Point(3, 22);
            this.VariableListTreeView.Name = "VariableListTreeView";
            this.VariableListTreeView.Size = new System.Drawing.Size(483, 366);
            this.VariableListTreeView.TabIndex = 0;
            this.VariableListTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.VariableListTreeView_AfterSelect);
            this.VariableListTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.VariableListTreeView_NodeMouseClick);
            // 
            // treeViewContextMenuStrip
            // 
            this.treeViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.treeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTopLevelNodeToolStripMenuItem,
            this.addChildNodeToolStripMenuItem,
            this.DeleteNodeToolStripMenuItem});
            this.treeViewContextMenuStrip.Name = "contextMenuStrip1";
            this.treeViewContextMenuStrip.Size = new System.Drawing.Size(213, 94);
            // 
            // addTopLevelNodeToolStripMenuItem
            // 
            this.addTopLevelNodeToolStripMenuItem.Name = "addTopLevelNodeToolStripMenuItem";
            this.addTopLevelNodeToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.addTopLevelNodeToolStripMenuItem.Text = "Add Chunk";
            this.addTopLevelNodeToolStripMenuItem.Click += new System.EventHandler(this.addNodeToolStripMenuItem_Click);
            // 
            // addChildNodeToolStripMenuItem
            // 
            this.addChildNodeToolStripMenuItem.Name = "addChildNodeToolStripMenuItem";
            this.addChildNodeToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.addChildNodeToolStripMenuItem.Text = "Add Child Node";
            this.addChildNodeToolStripMenuItem.Click += new System.EventHandler(this.addChildNodeToolStripMenuItem_Click);
            // 
            // DeleteNodeToolStripMenuItem
            // 
            this.DeleteNodeToolStripMenuItem.Name = "DeleteNodeToolStripMenuItem";
            this.DeleteNodeToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.DeleteNodeToolStripMenuItem.Text = "Delete Node";
            this.DeleteNodeToolStripMenuItem.Click += new System.EventHandler(this.DeleteNodeToolStripMenuItem_Click);
            // 
            // VariablesGroupBox
            // 
            this.VariablesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariablesGroupBox.Controls.Add(this.VariableDetailsGroupBox);
            this.VariablesGroupBox.Controls.Add(this.VariableListTreeView);
            this.VariablesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.VariablesGroupBox.Name = "VariablesGroupBox";
            this.VariablesGroupBox.Size = new System.Drawing.Size(993, 394);
            this.VariablesGroupBox.TabIndex = 1;
            this.VariablesGroupBox.TabStop = false;
            // 
            // VariableDetailsGroupBox
            // 
            this.VariableDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VariableDetailsGroupBox.Controls.Add(this.btnVarDetailsReset);
            this.VariableDetailsGroupBox.Controls.Add(this.btnVarDetailsApply);
            this.VariableDetailsGroupBox.Controls.Add(this.rdbtnEdit);
            this.VariableDetailsGroupBox.Controls.Add(this.rdbtnAdd);
            this.VariableDetailsGroupBox.Controls.Add(this.rdbtnRemove);
            this.VariableDetailsGroupBox.Controls.Add(this.cmbBoxVarType);
            this.VariableDetailsGroupBox.Controls.Add(this.txtBoxVarValue);
            this.VariableDetailsGroupBox.Controls.Add(this.txtBoxVarName);
            this.VariableDetailsGroupBox.Controls.Add(this.lblVarType);
            this.VariableDetailsGroupBox.Controls.Add(this.lblVarValue);
            this.VariableDetailsGroupBox.Controls.Add(this.lblVarName);
            this.VariableDetailsGroupBox.Location = new System.Drawing.Point(488, 22);
            this.VariableDetailsGroupBox.Name = "VariableDetailsGroupBox";
            this.VariableDetailsGroupBox.Size = new System.Drawing.Size(502, 208);
            this.VariableDetailsGroupBox.TabIndex = 1;
            this.VariableDetailsGroupBox.TabStop = false;
            this.VariableDetailsGroupBox.Text = "Variable Details";
            // 
            // btnVarDetailsReset
            // 
            this.btnVarDetailsReset.Location = new System.Drawing.Point(90, 159);
            this.btnVarDetailsReset.Name = "btnVarDetailsReset";
            this.btnVarDetailsReset.Size = new System.Drawing.Size(75, 37);
            this.btnVarDetailsReset.TabIndex = 10;
            this.btnVarDetailsReset.Text = "Reset";
            this.btnVarDetailsReset.UseVisualStyleBackColor = true;
            this.btnVarDetailsReset.Click += new System.EventHandler(this.btnVarDetailsReset_Click);
            // 
            // btnVarDetailsApply
            // 
            this.btnVarDetailsApply.AutoSize = true;
            this.btnVarDetailsApply.Location = new System.Drawing.Point(9, 159);
            this.btnVarDetailsApply.Name = "btnVarDetailsApply";
            this.btnVarDetailsApply.Size = new System.Drawing.Size(75, 37);
            this.btnVarDetailsApply.TabIndex = 9;
            this.btnVarDetailsApply.Text = "Apply";
            this.btnVarDetailsApply.UseVisualStyleBackColor = true;
            this.btnVarDetailsApply.Click += new System.EventHandler(this.btnVarDetailsApply_Click);
            // 
            // rdbtnEdit
            // 
            this.rdbtnEdit.AutoSize = true;
            this.rdbtnEdit.Enabled = false;
            this.rdbtnEdit.Location = new System.Drawing.Point(254, 129);
            this.rdbtnEdit.Name = "rdbtnEdit";
            this.rdbtnEdit.Size = new System.Drawing.Size(62, 24);
            this.rdbtnEdit.TabIndex = 8;
            this.rdbtnEdit.Text = "Edit";
            this.rdbtnEdit.UseVisualStyleBackColor = true;
            // 
            // rdbtnAdd
            // 
            this.rdbtnAdd.AutoSize = true;
            this.rdbtnAdd.Enabled = false;
            this.rdbtnAdd.Location = new System.Drawing.Point(185, 129);
            this.rdbtnAdd.Name = "rdbtnAdd";
            this.rdbtnAdd.Size = new System.Drawing.Size(63, 24);
            this.rdbtnAdd.TabIndex = 7;
            this.rdbtnAdd.Text = "Add";
            this.rdbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rdbtnRemove
            // 
            this.rdbtnRemove.AutoSize = true;
            this.rdbtnRemove.Checked = true;
            this.rdbtnRemove.Location = new System.Drawing.Point(86, 129);
            this.rdbtnRemove.Name = "rdbtnRemove";
            this.rdbtnRemove.Size = new System.Drawing.Size(93, 24);
            this.rdbtnRemove.TabIndex = 6;
            this.rdbtnRemove.TabStop = true;
            this.rdbtnRemove.Text = "Remove";
            this.rdbtnRemove.UseVisualStyleBackColor = true;
            // 
            // cmbBoxVarType
            // 
            this.cmbBoxVarType.FormattingEnabled = true;
            this.cmbBoxVarType.Location = new System.Drawing.Point(86, 25);
            this.cmbBoxVarType.Name = "cmbBoxVarType";
            this.cmbBoxVarType.Size = new System.Drawing.Size(410, 28);
            this.cmbBoxVarType.TabIndex = 5;
            // 
            // txtBoxVarValue
            // 
            this.txtBoxVarValue.Enabled = false;
            this.txtBoxVarValue.Location = new System.Drawing.Point(86, 97);
            this.txtBoxVarValue.Name = "txtBoxVarValue";
            this.txtBoxVarValue.Size = new System.Drawing.Size(410, 26);
            this.txtBoxVarValue.TabIndex = 4;
            // 
            // txtBoxVarName
            // 
            this.txtBoxVarName.Location = new System.Drawing.Point(86, 61);
            this.txtBoxVarName.Name = "txtBoxVarName";
            this.txtBoxVarName.Size = new System.Drawing.Size(410, 26);
            this.txtBoxVarName.TabIndex = 3;
            // 
            // lblVarType
            // 
            this.lblVarType.AutoSize = true;
            this.lblVarType.Location = new System.Drawing.Point(20, 28);
            this.lblVarType.Name = "lblVarType";
            this.lblVarType.Size = new System.Drawing.Size(43, 20);
            this.lblVarType.TabIndex = 2;
            this.lblVarType.Text = "Type";
            // 
            // lblVarValue
            // 
            this.lblVarValue.AutoSize = true;
            this.lblVarValue.Location = new System.Drawing.Point(20, 100);
            this.lblVarValue.Name = "lblVarValue";
            this.lblVarValue.Size = new System.Drawing.Size(50, 20);
            this.lblVarValue.TabIndex = 1;
            this.lblVarValue.Text = "Value";
            // 
            // lblVarName
            // 
            this.lblVarName.AutoSize = true;
            this.lblVarName.Location = new System.Drawing.Point(20, 64);
            this.lblVarName.Name = "lblVarName";
            this.lblVarName.Size = new System.Drawing.Size(51, 20);
            this.lblVarName.TabIndex = 0;
            this.lblVarName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 707);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.Location = new System.Drawing.Point(737, 706);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(119, 45);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Apply";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // FilesToolStrip
            // 
            this.FilesToolStrip.AutoSize = false;
            this.FilesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FilesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.FilesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripButton,
            this.UnselectAllToolStripButton,
            this.toolStripSeparator1,
            this.FilterToolStripLabel,
            this.FilterToolStripTextBox,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.ExtensionToolStripLabel,
            this.ExtensionToolStripComboBox,
            this.toolStripSeparator3,
            this.FCDToolStripComboBox});
            this.FilesToolStrip.Location = new System.Drawing.Point(9, 397);
            this.FilesToolStrip.Name = "FilesToolStrip";
            this.FilesToolStrip.Size = new System.Drawing.Size(981, 37);
            this.FilesToolStrip.TabIndex = 5;
            this.FilesToolStrip.Text = "FiltertoolStrip";
            // 
            // SelectAllToolStripButton
            // 
            this.SelectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllToolStripButton.Image")));
            this.SelectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAllToolStripButton.Name = "SelectAllToolStripButton";
            this.SelectAllToolStripButton.Size = new System.Drawing.Size(87, 34);
            this.SelectAllToolStripButton.Text = "Select All";
            this.SelectAllToolStripButton.Click += new System.EventHandler(this.SelectAllToolStripButton_Click);
            // 
            // UnselectAllToolStripButton
            // 
            this.UnselectAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnselectAllToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnselectAllToolStripButton.Image")));
            this.UnselectAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnselectAllToolStripButton.Name = "UnselectAllToolStripButton";
            this.UnselectAllToolStripButton.Size = new System.Drawing.Size(107, 34);
            this.UnselectAllToolStripButton.Text = "Unselect All";
            this.UnselectAllToolStripButton.Click += new System.EventHandler(this.UnselectAllToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // FilterToolStripLabel
            // 
            this.FilterToolStripLabel.Name = "FilterToolStripLabel";
            this.FilterToolStripLabel.Size = new System.Drawing.Size(73, 34);
            this.FilterToolStripLabel.Text = "Search: ";
            // 
            // FilterToolStripTextBox
            // 
            this.FilterToolStripTextBox.Name = "FilterToolStripTextBox";
            this.FilterToolStripTextBox.Size = new System.Drawing.Size(100, 37);
            this.FilterToolStripTextBox.TextChanged += new System.EventHandler(this.FilterToolStripTextBox_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WolvenKit.Properties.Resources.ExitIcon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 34);
            this.toolStripButton1.Text = "ClearToolStripButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // ExtensionToolStripLabel
            // 
            this.ExtensionToolStripLabel.Name = "ExtensionToolStripLabel";
            this.ExtensionToolStripLabel.Size = new System.Drawing.Size(96, 34);
            this.ExtensionToolStripLabel.Text = "Extension: ";
            // 
            // ExtensionToolStripComboBox
            // 
            this.ExtensionToolStripComboBox.Name = "ExtensionToolStripComboBox";
            this.ExtensionToolStripComboBox.Size = new System.Drawing.Size(121, 37);
            this.ExtensionToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ExtensionToolStripComboBox_SelectedIndexChanged);
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(3, 445);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(987, 256);
            this.checkedListBoxFiles.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(862, 707);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 45);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // FCDToolStripComboBox
            // 
            this.FCDToolStripComboBox.Items.AddRange(new object[] {
            "Main File",
            "FlatCompiledData",
            "Both"});
            this.FCDToolStripComboBox.Name = "FCDToolStripComboBox";
            this.FCDToolStripComboBox.Size = new System.Drawing.Size(121, 37);
            // 
            // frmBulkEditVariables
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(993, 763);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkedListBoxFiles);
            this.Controls.Add(this.FilesToolStrip);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.VariablesGroupBox);
            this.MinimumSize = new System.Drawing.Size(1015, 819);
            this.Name = "frmBulkEditVariables";
            this.Text = "Bulk Edit Variables";
            this.Load += new System.EventHandler(this.frmBulkEditVariables_Load);
            this.treeViewContextMenuStrip.ResumeLayout(false);
            this.VariablesGroupBox.ResumeLayout(false);
            this.VariableDetailsGroupBox.ResumeLayout(false);
            this.VariableDetailsGroupBox.PerformLayout();
            this.FilesToolStrip.ResumeLayout(false);
            this.FilesToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView VariableListTreeView;
        private System.Windows.Forms.ContextMenuStrip treeViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addTopLevelNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChildNodeToolStripMenuItem;
        private System.Windows.Forms.GroupBox VariablesGroupBox;
        private System.Windows.Forms.GroupBox VariableDetailsGroupBox;
        private System.Windows.Forms.TextBox txtBoxVarValue;
        private System.Windows.Forms.TextBox txtBoxVarName;
        private System.Windows.Forms.Label lblVarType;
        private System.Windows.Forms.Label lblVarValue;
        private System.Windows.Forms.Label lblVarName;
        private System.Windows.Forms.ComboBox cmbBoxVarType;
        private System.Windows.Forms.RadioButton rdbtnEdit;
        private System.Windows.Forms.RadioButton rdbtnAdd;
        private System.Windows.Forms.RadioButton rdbtnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStrip FilesToolStrip;
        private System.Windows.Forms.ToolStripLabel FilterToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox FilterToolStripTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel ExtensionToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox ExtensionToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnVarDetailsApply;
        private System.Windows.Forms.Button btnVarDetailsReset;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SelectAllToolStripButton;
        private System.Windows.Forms.ToolStripButton UnselectAllToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteNodeToolStripMenuItem;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox FCDToolStripComboBox;
    }
}