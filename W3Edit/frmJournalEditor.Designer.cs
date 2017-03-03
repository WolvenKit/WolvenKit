namespace W3Edit
{
    partial class frmJournalEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.indeximage_label = new System.Windows.Forms.Label();
            this.entityImage = new System.Windows.Forms.PictureBox();
            this.vulnerable_treview = new System.Windows.Forms.TreeView();
            this.textRender = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textRender);
            this.splitContainer1.Size = new System.Drawing.Size(955, 500);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.indeximage_label);
            this.splitContainer2.Panel1.Controls.Add(this.entityImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.vulnerable_treview);
            this.splitContainer2.Size = new System.Drawing.Size(318, 500);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.TabIndex = 0;
            // 
            // indeximage_label
            // 
            this.indeximage_label.AutoSize = true;
            this.indeximage_label.BackColor = System.Drawing.Color.LightGray;
            this.indeximage_label.Location = new System.Drawing.Point(8, 8);
            this.indeximage_label.Name = "indeximage_label";
            this.indeximage_label.Size = new System.Drawing.Size(42, 17);
            this.indeximage_label.TabIndex = 1;
            this.indeximage_label.Text = "None";
            // 
            // entityImage
            // 
            this.entityImage.BackColor = System.Drawing.Color.LightGray;
            this.entityImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityImage.Location = new System.Drawing.Point(0, 0);
            this.entityImage.Name = "entityImage";
            this.entityImage.Size = new System.Drawing.Size(318, 421);
            this.entityImage.TabIndex = 0;
            this.entityImage.TabStop = false;
            // 
            // vulnerable_treview
            // 
            this.vulnerable_treview.BackColor = System.Drawing.Color.LightGray;
            this.vulnerable_treview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vulnerable_treview.Location = new System.Drawing.Point(0, 0);
            this.vulnerable_treview.Name = "vulnerable_treview";
            this.vulnerable_treview.Size = new System.Drawing.Size(318, 75);
            this.vulnerable_treview.TabIndex = 0;
            // 
            // textRender
            // 
            this.textRender.BackColor = System.Drawing.Color.LightGray;
            this.textRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRender.Location = new System.Drawing.Point(0, 0);
            this.textRender.Name = "textRender";
            this.textRender.Size = new System.Drawing.Size(633, 500);
            this.textRender.TabIndex = 0;
            this.textRender.Text = "";
            // 
            // frmJournalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 500);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmJournalEditor";
            this.Text = "Journal Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entityImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox entityImage;
        private System.Windows.Forms.Label indeximage_label;
        private System.Windows.Forms.TreeView vulnerable_treview;
        private System.Windows.Forms.RichTextBox textRender;
    }
}