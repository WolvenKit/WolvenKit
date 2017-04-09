using System.ComponentModel;
using System.Windows.Forms;

namespace WolvenKit.FlowTreeEditors
{
    partial class SceneFlowConditionEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTrue = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrue
            // 
            this.lblTrue.Location = new System.Drawing.Point(276, 18);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(35, 15);
            this.lblTrue.TabIndex = 1;
            this.lblTrue.Text = "True";
            // 
            // lblFalse
            // 
            this.lblFalse.Location = new System.Drawing.Point(276, 30);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(35, 15);
            this.lblFalse.TabIndex = 2;
            this.lblFalse.Text = "False";
            // 
            // lblCondition
            // 
            this.lblCondition.Location = new System.Drawing.Point(3, 20);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(267, 23);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "label1";
            // 
            // SceneFlowCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblFalse);
            this.Controls.Add(this.lblTrue);
            this.Name = "SceneFlowCondition";
            this.Controls.SetChildIndex(this.lblTrue, 0);
            this.Controls.SetChildIndex(this.lblFalse, 0);
            this.Controls.SetChildIndex(this.lblCondition, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTrue;
        private Label lblFalse;
        private Label lblCondition;
    }
}
