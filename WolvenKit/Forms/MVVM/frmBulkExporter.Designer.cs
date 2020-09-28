namespace WolvenKit.Forms
{
    partial class frmBulkExporter
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
        /// the contents of this method with the code Exporter.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnRun = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputPathBtn = new System.Windows.Forms.Button();
            this.exportPathBtn = new System.Windows.Forms.Button();
            this.exportTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.geometryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textureComboBox = new System.Windows.Forms.ComboBox();
            this.mergeCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRun});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(543, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbtnRun
            // 
            this.tsbtnRun.Image = global::WolvenKit.Properties.Resources.Run_16x;
            this.tsbtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRun.Name = "tsbtnRun";
            this.tsbtnRun.Size = new System.Drawing.Size(48, 22);
            this.tsbtnRun.Text = "Run";
            this.tsbtnRun.Click += new System.EventHandler(this.tsbtnRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(543, 33);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Folder";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(74, 34);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(432, 20);
            this.inputTextBox.TabIndex = 9;
            // 
            // inputPathBtn
            // 
            this.inputPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPathBtn.Location = new System.Drawing.Point(509, 32);
            this.inputPathBtn.Name = "inputPathBtn";
            this.inputPathBtn.Size = new System.Drawing.Size(32, 23);
            this.inputPathBtn.TabIndex = 10;
            this.inputPathBtn.Text = "...";
            this.inputPathBtn.UseVisualStyleBackColor = true;
            this.inputPathBtn.Click += new System.EventHandler(this.InputFolder_Click);
            // 
            // exportPathBtn
            // 
            this.exportPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportPathBtn.Location = new System.Drawing.Point(509, 58);
            this.exportPathBtn.Name = "exportPathBtn";
            this.exportPathBtn.Size = new System.Drawing.Size(32, 23);
            this.exportPathBtn.TabIndex = 13;
            this.exportPathBtn.Text = "...";
            this.exportPathBtn.UseVisualStyleBackColor = true;
            this.exportPathBtn.Click += new System.EventHandler(this.ExportFolder_Click);
            // 
            // exportTextBox
            // 
            this.exportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportTextBox.Location = new System.Drawing.Point(74, 60);
            this.exportTextBox.Name = "exportTextBox";
            this.exportTextBox.Size = new System.Drawing.Size(432, 20);
            this.exportTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Export Folder";
            // 
            // geometryComboBox
            // 
            this.geometryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geometryComboBox.FormattingEnabled = true;
            this.geometryComboBox.Items.AddRange(new object[] {
            "FBX",
            "OBJ"});
            this.geometryComboBox.Location = new System.Drawing.Point(74, 97);
            this.geometryComboBox.Name = "geometryComboBox";
            this.geometryComboBox.Size = new System.Drawing.Size(121, 21);
            this.geometryComboBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geometries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Textures";
            // 
            // textureComboBox
            // 
            this.textureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textureComboBox.FormattingEnabled = true;
            this.textureComboBox.Items.AddRange(new object[] {
            "BMP",
            "JPG",
            "PNG"});
            this.textureComboBox.Location = new System.Drawing.Point(417, 97);
            this.textureComboBox.Name = "textureComboBox";
            this.textureComboBox.Size = new System.Drawing.Size(121, 21);
            this.textureComboBox.TabIndex = 16;
            // 
            // mergeCheckBox
            // 
            this.mergeCheckBox.AutoSize = true;
            this.mergeCheckBox.Location = new System.Drawing.Point(201, 99);
            this.mergeCheckBox.Name = "mergeCheckBox";
            this.mergeCheckBox.Size = new System.Drawing.Size(56, 17);
            this.mergeCheckBox.TabIndex = 18;
            this.mergeCheckBox.Text = "Merge";
            this.mergeCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmBulkExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 172);
            this.Controls.Add(this.mergeCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textureComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.geometryComboBox);
            this.Controls.Add(this.exportPathBtn);
            this.Controls.Add(this.exportTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPathBtn);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmBulkExporter";
            this.Text = "Bulk Exporter";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtnRun;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputPathBtn;
        private System.Windows.Forms.Button exportPathBtn;
        private System.Windows.Forms.TextBox exportTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox geometryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textureComboBox;
        private System.Windows.Forms.CheckBox mergeCheckBox;
    }
}