namespace WolvenKit.Forms.Editors
{
    partial class PtrEditor
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
            this.lblType = new System.Windows.Forms.Label();
            this.FileType = new System.Windows.Forms.TextBox();
            this.HandlePath = new System.Windows.Forms.TextBox();
            this.lblHandle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 3);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // txType
            // 
            this.FileType.Location = new System.Drawing.Point(40, 0);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(121, 20);
            this.FileType.TabIndex = 1;
            // 
            // txHandle
            // 
            this.HandlePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HandlePath.Location = new System.Drawing.Point(214, 0);
            this.HandlePath.Name = "HandlePath";
            this.HandlePath.Size = new System.Drawing.Size(160, 20);
            this.HandlePath.TabIndex = 3;
            // 
            // lblHandle
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Location = new System.Drawing.Point(167, 3);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(41, 13);
            this.lblHandle.TabIndex = 2;
            this.lblHandle.Text = "Handle";
            // 
            // PtrEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HandlePath);
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.lblType);
            this.Name = "PtrEditor";
            this.Size = new System.Drawing.Size(473, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHandle;
    }
}
