using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit
{
    partial class frmExtractAmbigious
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.lsBundleList = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dnamaCHB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(12, 311);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(727, 311);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "Select";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // lsBundleList
            // 
            this.lsBundleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsBundleList.FormattingEnabled = true;
            this.lsBundleList.IntegralHeight = false;
            this.lsBundleList.Location = new System.Drawing.Point(13, 34);
            this.lsBundleList.Name = "lsBundleList";
            this.lsBundleList.Size = new System.Drawing.Size(789, 271);
            this.lsBundleList.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(789, 16);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "The file you are trying to extract exists in one or more archives, select one.\r\n";
            // 
            // dnamaCHB
            // 
            this.dnamaCHB.AutoSize = true;
            this.dnamaCHB.Location = new System.Drawing.Point(597, 315);
            this.dnamaCHB.Name = "dnamaCHB";
            this.dnamaCHB.Size = new System.Drawing.Size(124, 17);
            this.dnamaCHB.TabIndex = 10;
            this.dnamaCHB.Text = "Do not ask me again";
            this.dnamaCHB.UseVisualStyleBackColor = true;
            // 
            // frmExtractAmbigious
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 346);
            this.Controls.Add(this.dnamaCHB);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lsBundleList);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.MinimumSize = new System.Drawing.Size(420, 152);
            this.Name = "frmExtractAmbigious";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extract ambigious";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCancel;
        private Button btOk;
        private ListBox lsBundleList;
        private Label lblMessage;
        private CheckBox dnamaCHB;
    }
}