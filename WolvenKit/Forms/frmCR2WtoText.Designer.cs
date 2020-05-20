namespace WolvenKit.Forms
{
    partial class frmCR2WtoText
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.labPath = new System.Windows.Forms.Label();
            this.labOutputFile = new System.Windows.Forms.Label();
            this.labFileCountDesc = new System.Windows.Forms.Label();
            this.labFileCount = new System.Windows.Forms.Label();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(13, 132);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1142, 1178);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(145, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(295, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(457, 19);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(75, 20);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "Select path";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = global::WolvenKit.Properties.Resources.Output_16x;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(19, 103);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(421, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(145, 72);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(295, 20);
            this.txtOutputFile.TabIndex = 4;
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Location = new System.Drawing.Point(16, 22);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(105, 13);
            this.labPath.TabIndex = 5;
            this.labPath.Text = "Dump files in folder : ";
            this.labPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labOutputFile
            // 
            this.labOutputFile.AutoSize = true;
            this.labOutputFile.Location = new System.Drawing.Point(16, 75);
            this.labOutputFile.Name = "labOutputFile";
            this.labOutputFile.Size = new System.Drawing.Size(109, 13);
            this.labOutputFile.TabIndex = 6;
            this.labOutputFile.Text = "Output results to file : ";
            this.labOutputFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labFileCountDesc
            // 
            this.labFileCountDesc.AutoSize = true;
            this.labFileCountDesc.Location = new System.Drawing.Point(16, 47);
            this.labFileCountDesc.Name = "labFileCountDesc";
            this.labFileCountDesc.Size = new System.Drawing.Size(120, 13);
            this.labFileCountDesc.TabIndex = 7;
            this.labFileCountDesc.Text = "Number of files in folder:";
            this.labFileCountDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labFileCount
            // 
            this.labFileCount.AutoSize = true;
            this.labFileCount.Location = new System.Drawing.Point(142, 47);
            this.labFileCount.Name = "labFileCount";
            this.labFileCount.Size = new System.Drawing.Size(13, 13);
            this.labFileCount.TabIndex = 8;
            this.labFileCount.Text = "0";
            // 
            // btnPickFile
            // 
            this.btnPickFile.Location = new System.Drawing.Point(457, 72);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(75, 23);
            this.btnPickFile.TabIndex = 9;
            this.btnPickFile.Text = "Output file";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // frmCR2WtoText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 1322);
            this.Controls.Add(this.btnPickFile);
            this.Controls.Add(this.labFileCount);
            this.Controls.Add(this.labFileCountDesc);
            this.Controls.Add(this.labOutputFile);
            this.Controls.Add(this.labPath);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtOutput);
            this.Name = "frmCR2WtoText";
            this.Text = "frmCR2WtoText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label labPath;
        private System.Windows.Forms.Label labOutputFile;
        private System.Windows.Forms.Label labFileCountDesc;
        private System.Windows.Forms.Label labFileCount;
        private System.Windows.Forms.Button btnPickFile;
    }
}