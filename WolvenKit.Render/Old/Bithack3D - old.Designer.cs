namespace WolvenKit.Render
{
    partial class Bithack3D
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
            this.components = new System.ComponentModel.Container();
            this.glControl1 = new OpenGL.GlControl();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.DimGray;
            this.glControl1.ColorBits = ((uint)(24u));
            this.glControl1.DepthBits = ((uint)(24u));
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.MultisampleBits = ((uint)(0u));
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(601, 431);
            this.glControl1.StencilBits = ((uint)(0u));
            this.glControl1.TabIndex = 0;
            this.glControl1.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_ContextCreated);
            this.glControl1.ContextDestroying += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_ContextDestroying);
            this.glControl1.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_Render);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Interval = 16;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // textBoxPos
            // 
            this.textBoxPos.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPos.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPos.Location = new System.Drawing.Point(0, 338);
            this.textBoxPos.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(100, 13);
            this.textBoxPos.TabIndex = 1;
            this.textBoxPos.Text = "X: 0 Y:0 Z:0";
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRotation.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxRotation.Location = new System.Drawing.Point(0, 351);
            this.textBoxRotation.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(100, 13);
            this.textBoxRotation.TabIndex = 2;
            this.textBoxRotation.Text = "Yaw:0 Pitch:0 Roll: 0";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFPS.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFPS.Location = new System.Drawing.Point(0, 364);
            this.textBoxFPS.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(100, 13);
            this.textBoxFPS.TabIndex = 3;
            this.textBoxFPS.Text = "FPS: 60";
            // 
            // textBoxTip
            // 
            this.textBoxTip.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTip.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTip.Location = new System.Drawing.Point(0, 377);
            this.textBoxTip.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTip.Multiline = true;
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(83, 54);
            this.textBoxTip.TabIndex = 4;
            this.textBoxTip.Text = "[Space] Reset\r\n[LMouse] Rotate\r\n[RMouse] Move\r\n[Wheel] Zoom";
            // 
            // Bithack3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 431);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.textBoxRotation);
            this.Controls.Add(this.textBoxPos);
            this.Controls.Add(this.glControl1);
            this.KeyPreview = true;
            this.Name = "Bithack3D";
            this.Text = "3D Bithack";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bithack3D_KeyDown);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Bithack3D_MouseWheel);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenGL.GlControl glControl1;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.TextBox textBoxRotation;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.TextBox textBoxTip;
    }
}

