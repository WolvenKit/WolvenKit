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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.game.SuspendLayout();
            this.utilities.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(794, 651);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.game);
            this.tabControl1.Controls.Add(this.utilities);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 346);
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
            this.game.Name = "game";
            this.game.Padding = new System.Windows.Forms.Padding(3);
            this.game.Size = new System.Drawing.Size(786, 317);
            this.game.TabIndex = 0;
            this.game.Text = "Game";
            this.game.UseVisualStyleBackColor = true;
            // 
            // taskkillButton
            // 
            this.taskkillButton.Location = new System.Drawing.Point(8, 201);
            this.taskkillButton.Name = "taskkillButton";
            this.taskkillButton.Size = new System.Drawing.Size(160, 45);
            this.taskkillButton.TabIndex = 4;
            this.taskkillButton.Text = "Taskkill game";
            this.taskkillButton.UseVisualStyleBackColor = true;
            // 
            // startcostumGameButton
            // 
            this.startcostumGameButton.Location = new System.Drawing.Point(8, 266);
            this.startcostumGameButton.Name = "startcostumGameButton";
            this.startcostumGameButton.Size = new System.Drawing.Size(160, 45);
            this.startcostumGameButton.TabIndex = 3;
            this.startcostumGameButton.Text = "Start game with costum commands";
            this.startcostumGameButton.UseVisualStyleBackColor = true;
            // 
            // startnetGameButton
            // 
            this.startnetGameButton.Location = new System.Drawing.Point(8, 136);
            this.startnetGameButton.Name = "startnetGameButton";
            this.startnetGameButton.Size = new System.Drawing.Size(160, 45);
            this.startnetGameButton.TabIndex = 2;
            this.startnetGameButton.Text = "Start game with -net";
            this.startnetGameButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(8, 19);
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
            this.statusLabel.Location = new System.Drawing.Point(174, 36);
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
            this.utilities.Controls.Add(this.button8);
            this.utilities.Controls.Add(this.button7);
            this.utilities.Controls.Add(this.button6);
            this.utilities.Controls.Add(this.button5);
            this.utilities.Controls.Add(this.button4);
            this.utilities.Controls.Add(this.CommandTextBox);
            this.utilities.Controls.Add(this.button3);
            this.utilities.Location = new System.Drawing.Point(4, 25);
            this.utilities.Name = "utilities";
            this.utilities.Padding = new System.Windows.Forms.Padding(3);
            this.utilities.Size = new System.Drawing.Size(786, 317);
            this.utilities.TabIndex = 1;
            this.utilities.Text = "Utilities";
            this.utilities.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(138, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Classname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(138, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Funcname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(138, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(138, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Section:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(138, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Command:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(256, 208);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(484, 30);
            this.nameTextBox.TabIndex = 10;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectionTextBox.Location = new System.Drawing.Point(256, 172);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(484, 30);
            this.sectionTextBox.TabIndex = 9;
            // 
            // ClassnameTextBox
            // 
            this.ClassnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClassnameTextBox.Location = new System.Drawing.Point(256, 126);
            this.ClassnameTextBox.Name = "ClassnameTextBox";
            this.ClassnameTextBox.Size = new System.Drawing.Size(484, 30);
            this.ClassnameTextBox.TabIndex = 8;
            // 
            // FuncNameTextBox
            // 
            this.FuncNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FuncNameTextBox.Location = new System.Drawing.Point(256, 90);
            this.FuncNameTextBox.Name = "FuncNameTextBox";
            this.FuncNameTextBox.Size = new System.Drawing.Size(484, 30);
            this.FuncNameTextBox.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 49);
            this.button8.TabIndex = 6;
            this.button8.Text = "Varlist";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 49);
            this.button7.TabIndex = 5;
            this.button7.Text = "Get Opcode";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(295, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 43);
            this.button6.TabIndex = 4;
            this.button6.Text = "Reload scripts";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "Get scripts path of game";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "List installed mods";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommandTextBox.Location = new System.Drawing.Point(256, 24);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(484, 30);
            this.CommandTextBox.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "Send console command";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // logbox
            // 
            this.logbox.ContextMenuStrip = this.contextMenuStrip1;
            this.logbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logbox.Location = new System.Drawing.Point(0, 0);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(794, 301);
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
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 651);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDebug";
            this.Text = "Game Debugger - Disconnected";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            this.utilities.ResumeLayout(false);
            this.utilities.PerformLayout();
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox ClassnameTextBox;
        private System.Windows.Forms.TextBox FuncNameTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button taskkillButton;
        private System.Windows.Forms.Button startcostumGameButton;
    }
}