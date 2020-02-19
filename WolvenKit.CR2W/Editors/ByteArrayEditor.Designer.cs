namespace WolvenKit.CR2W.Editors
{
    partial class ByteArrayEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btOpen = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOpen.Location = new System.Drawing.Point(243, 0);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(112, 32);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btExport
            // 
            this.btExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExport.Location = new System.Drawing.Point(0, 0);
            this.btExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 32);
            this.btExport.TabIndex = 1;
            this.btExport.Text = "Export...";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btImport.Location = new System.Drawing.Point(122, 0);
            this.btImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(112, 32);
            this.btImport.TabIndex = 2;
            this.btImport.Text = "Import...";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoEllipsis = true;
            this.lblSize.Location = new System.Drawing.Point(360, 6);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(483, 26);
            this.lblSize.TabIndex = 3;
            // 
            // ByteArrayEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btOpen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ByteArrayEditor";
            this.Size = new System.Drawing.Size(848, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label lblSize;
    }
}
