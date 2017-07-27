namespace WolvenKit
{
    partial class frmPackSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackSettings));
            this.metadatastoreCHB = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.soundCHB = new System.Windows.Forms.CheckBox();
            this.texturecachecCHB = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.stringsCHB = new System.Windows.Forms.CheckBox();
            this.bundlesCHB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scriptsCHB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // metadatastoreCHB
            // 
            this.metadatastoreCHB.AutoSize = true;
            this.metadatastoreCHB.Checked = true;
            this.metadatastoreCHB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metadatastoreCHB.Location = new System.Drawing.Point(9, 32);
            this.metadatastoreCHB.Margin = new System.Windows.Forms.Padding(2);
            this.metadatastoreCHB.Name = "metadatastoreCHB";
            this.metadatastoreCHB.Size = new System.Drawing.Size(143, 17);
            this.metadatastoreCHB.TabIndex = 0;
            this.metadatastoreCHB.Text = "Generate metadata.store";
            this.metadatastoreCHB.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 185);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Pack w3speech";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // soundCHB
            // 
            this.soundCHB.AutoSize = true;
            this.soundCHB.Enabled = false;
            this.soundCHB.Location = new System.Drawing.Point(9, 98);
            this.soundCHB.Margin = new System.Windows.Forms.Padding(2);
            this.soundCHB.Name = "soundCHB";
            this.soundCHB.Size = new System.Drawing.Size(116, 17);
            this.soundCHB.TabIndex = 2;
            this.soundCHB.Text = "Pack sound cache";
            this.soundCHB.UseVisualStyleBackColor = true;
            // 
            // texturecachecCHB
            // 
            this.texturecachecCHB.AutoSize = true;
            this.texturecachecCHB.Location = new System.Drawing.Point(9, 54);
            this.texturecachecCHB.Margin = new System.Windows.Forms.Padding(2);
            this.texturecachecCHB.Name = "texturecachecCHB";
            this.texturecachecCHB.Size = new System.Drawing.Size(119, 17);
            this.texturecachecCHB.TabIndex = 3;
            this.texturecachecCHB.Text = "Pack texture cache";
            this.texturecachecCHB.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(9, 119);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(138, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Generate shader cache";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(9, 141);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(162, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Generate deprecation cache";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(9, 163);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(143, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Generate collision cache";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // stringsCHB
            // 
            this.stringsCHB.AutoSize = true;
            this.stringsCHB.Location = new System.Drawing.Point(9, 207);
            this.stringsCHB.Margin = new System.Windows.Forms.Padding(2);
            this.stringsCHB.Name = "stringsCHB";
            this.stringsCHB.Size = new System.Drawing.Size(97, 17);
            this.stringsCHB.TabIndex = 7;
            this.stringsCHB.Text = "Copy w3strings";
            this.stringsCHB.UseVisualStyleBackColor = true;
            // 
            // bundlesCHB
            // 
            this.bundlesCHB.AutoSize = true;
            this.bundlesCHB.Checked = true;
            this.bundlesCHB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bundlesCHB.Location = new System.Drawing.Point(9, 10);
            this.bundlesCHB.Margin = new System.Windows.Forms.Padding(2);
            this.bundlesCHB.Name = "bundlesCHB";
            this.bundlesCHB.Size = new System.Drawing.Size(91, 17);
            this.bundlesCHB.TabIndex = 8;
            this.bundlesCHB.Text = "Pack bundles";
            this.bundlesCHB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scriptsCHB
            // 
            this.scriptsCHB.AutoSize = true;
            this.scriptsCHB.Location = new System.Drawing.Point(9, 76);
            this.scriptsCHB.Margin = new System.Windows.Forms.Padding(2);
            this.scriptsCHB.Name = "scriptsCHB";
            this.scriptsCHB.Size = new System.Drawing.Size(144, 17);
            this.scriptsCHB.TabIndex = 11;
            this.scriptsCHB.Text = "Copy scripts from scripts/";
            this.scriptsCHB.UseVisualStyleBackColor = true;
            // 
            // frmPackSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 314);
            this.Controls.Add(this.scriptsCHB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bundlesCHB);
            this.Controls.Add(this.stringsCHB);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.texturecachecCHB);
            this.Controls.Add(this.soundCHB);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.metadatastoreCHB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPackSettings";
            this.Text = "Pack settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox metadatastoreCHB;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox soundCHB;
        private System.Windows.Forms.CheckBox texturecachecCHB;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox stringsCHB;
        private System.Windows.Forms.CheckBox bundlesCHB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox scriptsCHB;
    }
}