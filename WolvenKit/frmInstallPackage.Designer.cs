namespace WolvenKit
{
    partial class frmInstallPackage
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
            this.backgroundimagePB = new System.Windows.Forms.PictureBox();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.installBTN = new System.Windows.Forms.Button();
            this.detailWB = new System.Windows.Forms.WebBrowser();
            this.modnameLBL = new System.Windows.Forms.Label();
            this.authorLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundimagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.authorLBL);
            this.splitContainer1.Panel1.Controls.Add(this.modnameLBL);
            this.splitContainer1.Panel1.Controls.Add(this.installBTN);
            this.splitContainer1.Panel1.Controls.Add(this.logoPB);
            this.splitContainer1.Panel1.Controls.Add(this.backgroundimagePB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailWB);
            this.splitContainer1.Size = new System.Drawing.Size(830, 639);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // backgroundimagePB
            // 
            this.backgroundimagePB.BackColor = System.Drawing.Color.Maroon;
            this.backgroundimagePB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundimagePB.Location = new System.Drawing.Point(0, 0);
            this.backgroundimagePB.Name = "backgroundimagePB";
            this.backgroundimagePB.Size = new System.Drawing.Size(830, 181);
            this.backgroundimagePB.TabIndex = 0;
            this.backgroundimagePB.TabStop = false;
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.Location = new System.Drawing.Point(21, 12);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(169, 148);
            this.logoPB.TabIndex = 1;
            this.logoPB.TabStop = false;
            // 
            // installBTN
            // 
            this.installBTN.Location = new System.Drawing.Point(671, 122);
            this.installBTN.Name = "installBTN";
            this.installBTN.Size = new System.Drawing.Size(147, 38);
            this.installBTN.TabIndex = 2;
            this.installBTN.Text = "Install";
            this.installBTN.UseVisualStyleBackColor = true;
            this.installBTN.Click += new System.EventHandler(this.installBTN_Click);
            // 
            // detailWB
            // 
            this.detailWB.AllowNavigation = false;
            this.detailWB.AllowWebBrowserDrop = false;
            this.detailWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailWB.IsWebBrowserContextMenuEnabled = false;
            this.detailWB.Location = new System.Drawing.Point(0, 0);
            this.detailWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.detailWB.Name = "detailWB";
            this.detailWB.Size = new System.Drawing.Size(830, 454);
            this.detailWB.TabIndex = 0;
            // 
            // modnameLBL
            // 
            this.modnameLBL.AutoSize = true;
            this.modnameLBL.BackColor = System.Drawing.Color.Transparent;
            this.modnameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modnameLBL.Location = new System.Drawing.Point(210, 24);
            this.modnameLBL.Name = "modnameLBL";
            this.modnameLBL.Size = new System.Drawing.Size(139, 25);
            this.modnameLBL.TabIndex = 3;
            this.modnameLBL.Text = "<modname>";
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Location = new System.Drawing.Point(212, 65);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(49, 13);
            this.authorLBL.TabIndex = 4;
            this.authorLBL.Text = "<author>";
            // 
            // frmInstallPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 639);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmInstallPackage";
            this.ShowIcon = false;
            this.Text = "Package Installer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundimagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button installBTN;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.PictureBox backgroundimagePB;
        private System.Windows.Forms.WebBrowser detailWB;
        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Label modnameLBL;
    }
}