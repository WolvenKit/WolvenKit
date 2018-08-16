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
            this.irrlichtPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadRigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // irrlichtPanel
            // 
            this.irrlichtPanel.ContextMenuStrip = this.contextMenuStrip;
            this.irrlichtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrlichtPanel.Location = new System.Drawing.Point(0, 0);
            this.irrlichtPanel.Margin = new System.Windows.Forms.Padding(2);
            this.irrlichtPanel.Name = "irrlichtPanel";
            this.irrlichtPanel.Size = new System.Drawing.Size(412, 316);
            this.irrlichtPanel.TabIndex = 1;
            this.irrlichtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRigToolStripMenuItem,
            this.loadAnimToolStripMenuItem,
            this.selectAnimationToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.replaceTexturesToolStripMenuItem,
            this.exportTexturesToolStripMenuItem,
            this.exportCurrentAnimationToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(206, 202);
            // 
            // loadRigToolStripMenuItem
            // 
            this.loadRigToolStripMenuItem.Name = "loadRigToolStripMenuItem";
            this.loadRigToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.loadRigToolStripMenuItem.Text = "Load Rig (*.w2rig)";
            this.loadRigToolStripMenuItem.Click += new System.EventHandler(this.loadRigToolStripMenuItem_Click);
            // 
            // loadAnimToolStripMenuItem
            // 
            this.loadAnimToolStripMenuItem.Enabled = false;
            this.loadAnimToolStripMenuItem.Name = "loadAnimToolStripMenuItem";
            this.loadAnimToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.loadAnimToolStripMenuItem.Text = "Load Anims (*.w2anims)";
            this.loadAnimToolStripMenuItem.Click += new System.EventHandler(this.loadAnimToolStripMenuItem_Click);
            // 
            // selectAnimationToolStripMenuItem
            // 
            this.selectAnimationToolStripMenuItem.Enabled = false;
            this.selectAnimationToolStripMenuItem.Name = "selectAnimationToolStripMenuItem";
            this.selectAnimationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.selectAnimationToolStripMenuItem.Text = "Select animation";
            this.selectAnimationToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.selectAnimationToolStripMenuItem_DropDownItemClicked);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // replaceTexturesToolStripMenuItem
            // 
            this.replaceTexturesToolStripMenuItem.Enabled = false;
            this.replaceTexturesToolStripMenuItem.Name = "replaceTexturesToolStripMenuItem";
            this.replaceTexturesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.replaceTexturesToolStripMenuItem.Text = "Replace textures";
            // 
            // exportTexturesToolStripMenuItem
            // 
            this.exportTexturesToolStripMenuItem.Enabled = false;
            this.exportTexturesToolStripMenuItem.Name = "exportTexturesToolStripMenuItem";
            this.exportTexturesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportTexturesToolStripMenuItem.Text = "Export textures";
            // 
            // exportCurrentAnimationToolStripMenuItem
            // 
            this.exportCurrentAnimationToolStripMenuItem.Enabled = false;
            this.exportCurrentAnimationToolStripMenuItem.Name = "exportCurrentAnimationToolStripMenuItem";
            this.exportCurrentAnimationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportCurrentAnimationToolStripMenuItem.Text = "Export current animation";
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 16;
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // frmRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 316);
            this.Controls.Add(this.irrlichtPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRender";
            this.Text = "Renderer";
            this.Load += new System.EventHandler(this.Bithack3D_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bithack3D_KeyDown);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Bithack3D_MouseWheel);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel irrlichtPanel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTexturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnimationToolStripMenuItem;
    }
}