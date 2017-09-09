namespace WolvenKit
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.entityImage = new System.Windows.Forms.PictureBox();
            this.vulnerable_treview = new System.Windows.Forms.TreeView();
            this.textRender = new System.Windows.Forms.RichTextBox();
            this.entimgbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entityImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entimgbox)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.entimgbox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(318, 500);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.entityImage);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.vulnerable_treview);
            this.splitContainer3.Size = new System.Drawing.Size(318, 75);
            this.splitContainer3.SplitterDistance = 75;
            this.splitContainer3.TabIndex = 0;
            // 
            // entityImage
            // 
            this.entityImage.BackColor = System.Drawing.Color.LightGray;
            this.entityImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityImage.Location = new System.Drawing.Point(0, 0);
            this.entityImage.Name = "entityImage";
            this.entityImage.Size = new System.Drawing.Size(75, 75);
            this.entityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.entityImage.TabIndex = 0;
            this.entityImage.TabStop = false;
            // 
            // vulnerable_treview
            // 
            this.vulnerable_treview.BackColor = System.Drawing.Color.LightGray;
            this.vulnerable_treview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vulnerable_treview.Location = new System.Drawing.Point(0, 0);
            this.vulnerable_treview.Name = "vulnerable_treview";
            this.vulnerable_treview.Size = new System.Drawing.Size(239, 75);
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
            // entimgbox
            // 
            this.entimgbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entimgbox.Location = new System.Drawing.Point(0, 0);
            this.entimgbox.Name = "entimgbox";
            this.entimgbox.Size = new System.Drawing.Size(318, 421);
            this.entimgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.entimgbox.TabIndex = 0;
            this.entimgbox.TabStop = false;
            // 
            // frmJournalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entityImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entimgbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox textRender;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox entityImage;
        private System.Windows.Forms.TreeView vulnerable_treview;
        private System.Windows.Forms.PictureBox entimgbox;
    }
}