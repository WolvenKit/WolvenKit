namespace WolvenKit.Render
{
    partial class frmRender
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
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.irrlichtPanel = new System.Windows.Forms.Panel();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTip
            // 
            this.textBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTip.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTip.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTip.Location = new System.Drawing.Point(0, 359);
            this.textBoxTip.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTip.Multiline = true;
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(91, 54);
            this.textBoxTip.TabIndex = 5;
            this.textBoxTip.Text = "[Space] Reset\r\n[LMouse] Rotate\r\n[RMouse] Move\r\n[Wheel] Zoom";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFPS.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFPS.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFPS.Location = new System.Drawing.Point(0, 346);
            this.textBoxFPS.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(100, 16);
            this.textBoxFPS.TabIndex = 4;
            this.textBoxFPS.Text = "FPS: 60";
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxRotation.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRotation.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxRotation.Location = new System.Drawing.Point(0, 333);
            this.textBoxRotation.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(100, 16);
            this.textBoxRotation.TabIndex = 3;
            this.textBoxRotation.Text = "Yaw:0 Pitch:0 Roll: 0";
            // 
            // textBoxPos
            // 
            this.textBoxPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPos.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPos.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPos.Location = new System.Drawing.Point(0, 320);
            this.textBoxPos.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(100, 16);
            this.textBoxPos.TabIndex = 2;
            this.textBoxPos.Text = "X: 0 Y:0 Z:0";
            // 
            // irrlichtPanel
            // 
            this.irrlichtPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.irrlichtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrlichtPanel.Location = new System.Drawing.Point(0, 0);
            this.irrlichtPanel.Name = "irrlichtPanel";
            this.irrlichtPanel.Size = new System.Drawing.Size(549, 413);
            this.irrlichtPanel.TabIndex = 1;
            this.irrlichtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseMove);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 16;
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.replaceTexturesToolStripMenuItem,
            this.exportTexturesToolStripMenuItem,
            this.exportCurrentAnimationToolStripMenuItem,
            this.importAnimationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 148);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // replaceTexturesToolStripMenuItem
            // 
            this.replaceTexturesToolStripMenuItem.Enabled = false;
            this.replaceTexturesToolStripMenuItem.Name = "replaceTexturesToolStripMenuItem";
            this.replaceTexturesToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.replaceTexturesToolStripMenuItem.Text = "Replace textures";
            // 
            // exportTexturesToolStripMenuItem
            // 
            this.exportTexturesToolStripMenuItem.Enabled = false;
            this.exportTexturesToolStripMenuItem.Name = "exportTexturesToolStripMenuItem";
            this.exportTexturesToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.exportTexturesToolStripMenuItem.Text = "Export textures";
            // 
            // exportCurrentAnimationToolStripMenuItem
            // 
            this.exportCurrentAnimationToolStripMenuItem.Enabled = false;
            this.exportCurrentAnimationToolStripMenuItem.Name = "exportCurrentAnimationToolStripMenuItem";
            this.exportCurrentAnimationToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.exportCurrentAnimationToolStripMenuItem.Text = "Export current animation";
            // 
            // importAnimationToolStripMenuItem
            // 
            this.importAnimationToolStripMenuItem.Enabled = false;
            this.importAnimationToolStripMenuItem.Name = "importAnimationToolStripMenuItem";
            this.importAnimationToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.importAnimationToolStripMenuItem.Text = "Import animation";
            // 
            // frmRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 413);
            this.Controls.Add(this.textBoxTip);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.textBoxRotation);
            this.Controls.Add(this.textBoxPos);
            this.Controls.Add(this.irrlichtPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmRender";
            this.Text = "Renderer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bithack3D_FormClosing);
            this.Load += new System.EventHandler(this.Bithack3D_Load);
            this.ResizeEnd += new System.EventHandler(this.Bithack3D_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bithack3D_KeyDown);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Bithack3D_MouseWheel);
            this.Resize += new System.EventHandler(this.Bithack3D_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.TextBox textBoxRotation;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.Panel irrlichtPanel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAnimationToolStripMenuItem;
    }
}