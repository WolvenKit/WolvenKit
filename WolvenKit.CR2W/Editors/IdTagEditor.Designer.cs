namespace WolvenKit.CR2W.Editors
{
    partial class IdTagEditor
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
            this.lblIdTag = new System.Windows.Forms.Label();
            this.IdType = new System.Windows.Forms.TextBox();
            this.IdGuid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 4);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblIdTag
            // 
            this.lblIdTag.AutoSize = true;
            this.lblIdTag.Location = new System.Drawing.Point(223, 4);
            this.lblIdTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTag.Name = "lblIdTag";
            this.lblIdTag.Size = new System.Drawing.Size(67, 17);
            this.lblIdTag.TabIndex = 3;
            this.lblIdTag.Text = "Guid Tag";
            // 
            // IdType
            // 
            this.IdType.Location = new System.Drawing.Point(52, 1);
            this.IdType.Name = "IdType";
            this.IdType.Size = new System.Drawing.Size(164, 22);
            this.IdType.TabIndex = 4;
            // 
            // IdGuid
            // 
            this.IdGuid.Location = new System.Drawing.Point(297, 1);
            this.IdGuid.Name = "IdGuid";
            this.IdGuid.Size = new System.Drawing.Size(331, 22);
            this.IdGuid.TabIndex = 5;
            // 
            // IdTagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdGuid);
            this.Controls.Add(this.IdType);
            this.Controls.Add(this.lblIdTag);
            this.Controls.Add(this.lblType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IdTagEditor";
            this.Size = new System.Drawing.Size(631, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblIdTag;
    }
}
