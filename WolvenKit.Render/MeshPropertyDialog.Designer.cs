namespace WolvenKit.Render
{
    partial class MeshPropertyDialog
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.xTranslationTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yTranslationTextBox = new System.Windows.Forms.TextBox();
            this.zLabel = new System.Windows.Forms.Label();
            this.zTranslationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zRotationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yRotationTextBox = new System.Windows.Forms.TextBox();
            this.rxLabel = new System.Windows.Forms.Label();
            this.xRotationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(221, 75);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 8;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(6, 75);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // xTranslationTextBox
            // 
            this.xTranslationTextBox.Location = new System.Drawing.Point(27, 12);
            this.xTranslationTextBox.Name = "xTranslationTextBox";
            this.xTranslationTextBox.Size = new System.Drawing.Size(70, 20);
            this.xTranslationTextBox.TabIndex = 0;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(3, 15);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 13);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "TX:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(103, 15);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 13);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "TY:";
            // 
            // yTranslationTextBox
            // 
            this.yTranslationTextBox.Location = new System.Drawing.Point(127, 12);
            this.yTranslationTextBox.Name = "yTranslationTextBox";
            this.yTranslationTextBox.Size = new System.Drawing.Size(70, 20);
            this.yTranslationTextBox.TabIndex = 1;
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(202, 15);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(24, 13);
            this.zLabel.TabIndex = 8;
            this.zLabel.Text = "TZ:";
            // 
            // zTranslationTextBox
            // 
            this.zTranslationTextBox.Location = new System.Drawing.Point(226, 12);
            this.zTranslationTextBox.Name = "zTranslationTextBox";
            this.zTranslationTextBox.Size = new System.Drawing.Size(70, 20);
            this.zTranslationTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "RZ:";
            // 
            // zRotationTextBox
            // 
            this.zRotationTextBox.Location = new System.Drawing.Point(226, 43);
            this.zRotationTextBox.Name = "zRotationTextBox";
            this.zRotationTextBox.Size = new System.Drawing.Size(70, 20);
            this.zRotationTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "RY:";
            // 
            // yRotationTextBox
            // 
            this.yRotationTextBox.Location = new System.Drawing.Point(127, 43);
            this.yRotationTextBox.Name = "yRotationTextBox";
            this.yRotationTextBox.Size = new System.Drawing.Size(70, 20);
            this.yRotationTextBox.TabIndex = 4;
            // 
            // rxLabel
            // 
            this.rxLabel.AutoSize = true;
            this.rxLabel.Location = new System.Drawing.Point(2, 46);
            this.rxLabel.Name = "rxLabel";
            this.rxLabel.Size = new System.Drawing.Size(25, 13);
            this.rxLabel.TabIndex = 12;
            this.rxLabel.Text = "RX:";
            // 
            // xRotationTextBox
            // 
            this.xRotationTextBox.Location = new System.Drawing.Point(27, 43);
            this.xRotationTextBox.Name = "xRotationTextBox";
            this.xRotationTextBox.Size = new System.Drawing.Size(70, 20);
            this.xRotationTextBox.TabIndex = 3;
            // 
            // MeshPropertyDialog
            // 
            this.AcceptButton = this.applyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 108);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zRotationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yRotationTextBox);
            this.Controls.Add(this.rxLabel);
            this.Controls.Add(this.xRotationTextBox);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.zTranslationTextBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yTranslationTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xTranslationTextBox);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.applyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeshPropertyDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mesh Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox xTranslationTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yTranslationTextBox;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.TextBox zTranslationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zRotationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yRotationTextBox;
        private System.Windows.Forms.Label rxLabel;
        private System.Windows.Forms.TextBox xRotationTextBox;
    }
}