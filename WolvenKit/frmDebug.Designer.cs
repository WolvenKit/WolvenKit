namespace WolvenKit
{
    partial class frmDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebug));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.game = new System.Windows.Forms.TabPage();
            this.taskkillButton = new System.Windows.Forms.Button();
            this.startcostumGameButton = new System.Windows.Forms.Button();
            this.startnetGameButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.utilities = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.ClassnameTextBox = new System.Windows.Forms.TextBox();
            this.FuncNameTextBox = new System.Windows.Forms.TextBox();
            this.VarListButton = new System.Windows.Forms.Button();
            this.GetOpcodeButton = new System.Windows.Forms.Button();
            this.ScriptReloadButton = new System.Windows.Forms.Button();
            this.GetPathButton = new System.Windows.Forms.Button();
            this.listmodsButton = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CCommandButton = new System.Windows.Forms.Button();
            this.vars = new System.Windows.Forms.TabPage();
            this.varDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gatherUpdateVarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.DataRecieveWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.game.SuspendLayout();
            this.utilities.SuspendLayout();
            this.vars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logbox);
            this.splitContainer1.Size = new System.Drawing.Size(795, 651);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.game);
            this.tabControl1.Controls.Add(this.utilities);
            this.tabControl1.Controls.Add(this.vars);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 345);
            this.tabControl1.TabIndex = 2;
            // 
            // game
            // 
            this.game.Controls.Add(this.taskkillButton);
            this.game.Controls.Add(this.startcostumGameButton);
            this.game.Controls.Add(this.startnetGameButton);
            this.game.Controls.Add(this.connectButton);
            this.game.Controls.Add(this.statusLabel);
            this.game.Location = new System.Drawing.Point(4, 25);
            this.game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Name = "game";
            this.game.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Size = new System.Drawing.Size(787, 316);
            this.game.TabIndex = 0;
            this.game.Text = "Game";
            this.game.UseVisualStyleBackColor = true;
            // 
            // taskkillButton
            // 
            this.taskkillButton.Location = new System.Drawing.Point(8, 201);
            this.taskkillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskkillButton.Name = "taskkillButton";
            this.taskkillButton.Size = new System.Drawing.Size(160, 46);
            this.taskkillButton.TabIndex = 4;
            this.taskkillButton.Text = "Taskkill game";
            this.taskkillButton.UseVisualStyleBackColor = true;
            this.taskkillButton.Click += new System.EventHandler(this.taskkillButton_Click);
            // 
            // startcostumGameButton
            // 
            this.startcostumGameButton.Location = new System.Drawing.Point(8, 266);
            this.startcostumGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startcostumGameButton.Name = "startcostumGameButton";
            this.startcostumGameButton.Size = new System.Drawing.Size(160, 46);
            this.startcostumGameButton.TabIndex = 3;
            this.startcostumGameButton.Text = "Start game with costum commands";
            this.startcostumGameButton.UseVisualStyleBackColor = true;
            this.startcostumGameButton.Click += new System.EventHandler(this.startcostumGameButton_Click);
            // 
            // startnetGameButton
            // 
            this.startnetGameButton.Location = new System.Drawing.Point(8, 135);
            this.startnetGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startnetGameButton.Name = "startnetGameButton";
            this.startnetGameButton.Size = new System.Drawing.Size(160, 46);
            this.startnetGameButton.TabIndex = 2;
            this.startnetGameButton.Text = "Start game with -net";
            this.startnetGameButton.UseVisualStyleBackColor = true;
            this.startnetGameButton.Click += new System.EventHandler(this.startnetGameButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(8, 18);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(160, 46);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusLabel.Location = new System.Drawing.Point(173, 36);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(99, 29);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status: -";
            // 
            // utilities
            // 
            this.utilities.Controls.Add(this.label6);
            this.utilities.Controls.Add(this.label5);
            this.utilities.Controls.Add(this.label4);
            this.utilities.Controls.Add(this.label3);
            this.utilities.Controls.Add(this.label2);
            this.utilities.Controls.Add(this.nameTextBox);
            this.utilities.Controls.Add(this.sectionTextBox);
            this.utilities.Controls.Add(this.ClassnameTextBox);
            this.utilities.Controls.Add(this.FuncNameTextBox);
            this.utilities.Controls.Add(this.VarListButton);
            this.utilities.Controls.Add(this.GetOpcodeButton);
            this.utilities.Controls.Add(this.ScriptReloadButton);
            this.utilities.Controls.Add(this.GetPathButton);
            this.utilities.Controls.Add(this.listmodsButton);
            this.utilities.Controls.Add(this.CommandTextBox);
            this.utilities.Controls.Add(this.CCommandButton);
            this.utilities.Location = new System.Drawing.Point(4, 25);
            this.utilities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.utilities.Name = "utilities";
            this.utilities.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.utilities.Size = new System.Drawing.Size(787, 316);
            this.utilities.TabIndex = 1;
            this.utilities.Text = "Utilities";
            this.utilities.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(139, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Classname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(139, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Funcname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(139, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(139, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Section:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(139, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Command:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(271, 208);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(469, 30);
            this.nameTextBox.TabIndex = 10;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectionTextBox.Location = new System.Drawing.Point(271, 172);
            this.sectionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(469, 30);
            this.sectionTextBox.TabIndex = 9;
            // 
            // ClassnameTextBox
            // 
            this.ClassnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassnameTextBox.Location = new System.Drawing.Point(271, 126);
            this.ClassnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassnameTextBox.Name = "ClassnameTextBox";
            this.ClassnameTextBox.Size = new System.Drawing.Size(469, 30);
            this.ClassnameTextBox.TabIndex = 8;
            // 
            // FuncNameTextBox
            // 
            this.FuncNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FuncNameTextBox.Location = new System.Drawing.Point(271, 90);
            this.FuncNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FuncNameTextBox.Name = "FuncNameTextBox";
            this.FuncNameTextBox.Size = new System.Drawing.Size(469, 30);
            this.FuncNameTextBox.TabIndex = 7;
            // 
            // VarListButton
            // 
            this.VarListButton.Location = new System.Drawing.Point(8, 172);
            this.VarListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VarListButton.Name = "VarListButton";
            this.VarListButton.Size = new System.Drawing.Size(124, 49);
            this.VarListButton.TabIndex = 6;
            this.VarListButton.Text = "Varlist";
            this.VarListButton.UseVisualStyleBackColor = true;
            this.VarListButton.Click += new System.EventHandler(this.VarListButton_Click);
            // 
            // GetOpcodeButton
            // 
            this.GetOpcodeButton.Location = new System.Drawing.Point(8, 97);
            this.GetOpcodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOpcodeButton.Name = "GetOpcodeButton";
            this.GetOpcodeButton.Size = new System.Drawing.Size(124, 49);
            this.GetOpcodeButton.TabIndex = 5;
            this.GetOpcodeButton.Text = "Get Opcode";
            this.GetOpcodeButton.UseVisualStyleBackColor = true;
            this.GetOpcodeButton.Click += new System.EventHandler(this.GetOpcodeButton_Click);
            // 
            // ScriptReloadButton
            // 
            this.ScriptReloadButton.Location = new System.Drawing.Point(295, 260);
            this.ScriptReloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScriptReloadButton.Name = "ScriptReloadButton";
            this.ScriptReloadButton.Size = new System.Drawing.Size(124, 43);
            this.ScriptReloadButton.TabIndex = 4;
            this.ScriptReloadButton.Text = "Reload scripts";
            this.ScriptReloadButton.UseVisualStyleBackColor = true;
            this.ScriptReloadButton.Click += new System.EventHandler(this.ScriptReloadButton_Click);
            // 
            // GetPathButton
            // 
            this.GetPathButton.Location = new System.Drawing.Point(156, 260);
            this.GetPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetPathButton.Name = "GetPathButton";
            this.GetPathButton.Size = new System.Drawing.Size(124, 43);
            this.GetPathButton.TabIndex = 3;
            this.GetPathButton.Text = "Get scripts path of game";
            this.GetPathButton.UseVisualStyleBackColor = true;
            this.GetPathButton.Click += new System.EventHandler(this.GetPathButton_Click);
            // 
            // listmodsButton
            // 
            this.listmodsButton.Location = new System.Drawing.Point(17, 260);
            this.listmodsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listmodsButton.Name = "listmodsButton";
            this.listmodsButton.Size = new System.Drawing.Size(124, 43);
            this.listmodsButton.TabIndex = 2;
            this.listmodsButton.Text = "List installed mods";
            this.listmodsButton.UseVisualStyleBackColor = true;
            this.listmodsButton.Click += new System.EventHandler(this.listmodsButton_Click);
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommandTextBox.Location = new System.Drawing.Point(271, 25);
            this.CommandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(469, 30);
            this.CommandTextBox.TabIndex = 1;
            // 
            // CCommandButton
            // 
            this.CCommandButton.Location = new System.Drawing.Point(8, 15);
            this.CCommandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CCommandButton.Name = "CCommandButton";
            this.CCommandButton.Size = new System.Drawing.Size(124, 49);
            this.CCommandButton.TabIndex = 0;
            this.CCommandButton.Text = "Send console command";
            this.CCommandButton.UseVisualStyleBackColor = true;
            this.CCommandButton.Click += new System.EventHandler(this.CCommandButton_Click);
            // 
            // vars
            // 
            this.vars.Controls.Add(this.varDGV);
            this.vars.Controls.Add(this.menuStrip1);
            this.vars.Location = new System.Drawing.Point(4, 25);
            this.vars.Name = "vars";
            this.vars.Size = new System.Drawing.Size(787, 316);
            this.vars.TabIndex = 2;
            this.vars.Text = "Vars";
            this.vars.UseVisualStyleBackColor = true;
            // 
            // varDGV
            // 
            this.varDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.varDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.varDGV.Location = new System.Drawing.Point(0, 28);
            this.varDGV.Name = "varDGV";
            this.varDGV.RowTemplate.Height = 24;
            this.varDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.varDGV.Size = new System.Drawing.Size(787, 288);
            this.varDGV.TabIndex = 1;
            this.varDGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.varDGV_CellEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gatherUpdateVarsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gatherUpdateVarsToolStripMenuItem
            // 
            this.gatherUpdateVarsToolStripMenuItem.Name = "gatherUpdateVarsToolStripMenuItem";
            this.gatherUpdateVarsToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.gatherUpdateVarsToolStripMenuItem.Text = "Help";
            this.gatherUpdateVarsToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // logbox
            // 
            this.logbox.ContextMenuStrip = this.contextMenuStrip1;
            this.logbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logbox.Location = new System.Drawing.Point(0, 0);
            this.logbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(795, 302);
            this.logbox.TabIndex = 0;
            this.logbox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 82);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.copySelectedToolStripMenuItem.Text = "Copy selected";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.copyAllToolStripMenuItem.Text = "Copy all";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // DataRecieveWorker
            // 
            this.DataRecieveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataRecieveWorker_DoWork);
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 651);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDebug";
            this.Text = "Game Debugger";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.utilities.ResumeLayout(false);
            this.utilities.PerformLayout();
            this.vars.ResumeLayout(false);
            this.vars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox logbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage game;
        private System.Windows.Forms.Button startnetGameButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TabPage utilities;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button GetPathButton;
        private System.Windows.Forms.Button listmodsButton;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button CCommandButton;
        private System.Windows.Forms.Button ScriptReloadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox ClassnameTextBox;
        private System.Windows.Forms.TextBox FuncNameTextBox;
        private System.Windows.Forms.Button VarListButton;
        private System.Windows.Forms.Button GetOpcodeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button taskkillButton;
        private System.Windows.Forms.Button startcostumGameButton;
        private System.ComponentModel.BackgroundWorker DataRecieveWorker;
        private System.Windows.Forms.TabPage vars;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gatherUpdateVarsToolStripMenuItem;
        private System.Windows.Forms.DataGridView varDGV;
    }
}