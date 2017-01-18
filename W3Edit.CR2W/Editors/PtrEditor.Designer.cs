using System.Windows.Forms;
namespace W3Edit.CR2W.Editors
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
            this.txType = new System.Windows.Forms.TextBox();
            this.txHandle = new System.Windows.Forms.TextBox();
            this.lblHandle = new System.Windows.Forms.Label();
            this.txFlags = new System.Windows.Forms.TextBox();
            this.lblFlags = new System.Windows.Forms.Label();
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
            this.txType.Location = new System.Drawing.Point(40, 0);
            this.txType.Name = "txType";
            this.txType.Size = new System.Drawing.Size(121, 20);
            this.txType.TabIndex = 1;
            // 
            // txHandle
            // 
            this.txHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txHandle.Location = new System.Drawing.Point(214, 0);
            this.txHandle.Name = "txHandle";
            this.txHandle.Size = new System.Drawing.Size(160, 20);
            this.txHandle.TabIndex = 3;
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
            // txFlags
            // 
            this.txFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txFlags.Location = new System.Drawing.Point(418, 0);
            this.txFlags.Name = "txFlags";
            this.txFlags.Size = new System.Drawing.Size(52, 20);
            this.txFlags.TabIndex = 5;
            // 
            // lblFlags
            // 
            this.lblFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlags.AutoSize = true;
            this.lblFlags.Location = new System.Drawing.Point(380, 3);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(32, 13);
            this.lblFlags.TabIndex = 4;
            this.lblFlags.Text = "Flags";
            // 
            // PtrEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txFlags);
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.txHandle);
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.txType);
            this.Controls.Add(this.lblType);
            this.Name = "PtrEditor";
            this.Size = new System.Drawing.Size(473, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txType;
        private System.Windows.Forms.TextBox txHandle;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.TextBox txFlags;
        private System.Windows.Forms.Label lblFlags;
    }
}
