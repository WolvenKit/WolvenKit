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
            this.exportCurrentAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boundingBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skeletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfTransparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diffuseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.exportCurrentAnimationToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewToolStripMenuItem,
            this.animationSpeedToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator3,
            this.replaceTexturesToolStripMenuItem,
            this.exportTexturesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(207, 264);
            // 
            // loadRigToolStripMenuItem
            // 
            this.loadRigToolStripMenuItem.Name = "loadRigToolStripMenuItem";
            this.loadRigToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.loadRigToolStripMenuItem.Text = "Load Rig (*.w2rig)";
            this.loadRigToolStripMenuItem.Click += new System.EventHandler(this.loadRigToolStripMenuItem_Click);
            // 
            // loadAnimToolStripMenuItem
            // 
            this.loadAnimToolStripMenuItem.Enabled = false;
            this.loadAnimToolStripMenuItem.Name = "loadAnimToolStripMenuItem";
            this.loadAnimToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.loadAnimToolStripMenuItem.Text = "Load Anims (*.w2anims)";
            this.loadAnimToolStripMenuItem.Click += new System.EventHandler(this.loadAnimToolStripMenuItem_Click);
            // 
            // selectAnimationToolStripMenuItem
            // 
            this.selectAnimationToolStripMenuItem.Enabled = false;
            this.selectAnimationToolStripMenuItem.Name = "selectAnimationToolStripMenuItem";
            this.selectAnimationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.selectAnimationToolStripMenuItem.Text = "Play animation";
            this.selectAnimationToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.selectAnimationToolStripMenuItem_DropDownItemClicked);
            // 
            // exportCurrentAnimationToolStripMenuItem
            // 
            this.exportCurrentAnimationToolStripMenuItem.Enabled = false;
            this.exportCurrentAnimationToolStripMenuItem.Name = "exportCurrentAnimationToolStripMenuItem";
            this.exportCurrentAnimationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportCurrentAnimationToolStripMenuItem.Text = "Export current animation";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boundingBoxToolStripMenuItem,
            this.wireOverlayToolStripMenuItem,
            this.skeletonToolStripMenuItem,
            this.halfTransparentToolStripMenuItem,
            this.normalsToolStripMenuItem,
            this.offToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
            // 
            // boundingBoxToolStripMenuItem
            // 
            this.boundingBoxToolStripMenuItem.Name = "boundingBoxToolStripMenuItem";
            this.boundingBoxToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.boundingBoxToolStripMenuItem.Text = "Bounding Box";
            this.boundingBoxToolStripMenuItem.Click += new System.EventHandler(this.boundingBoxToolStripMenuItem_Click);
            // 
            // wireOverlayToolStripMenuItem
            // 
            this.wireOverlayToolStripMenuItem.Name = "wireOverlayToolStripMenuItem";
            this.wireOverlayToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wireOverlayToolStripMenuItem.Text = "Wire Overlay";
            this.wireOverlayToolStripMenuItem.Click += new System.EventHandler(this.wireOverlayToolStripMenuItem_Click);
            // 
            // skeletonToolStripMenuItem
            // 
            this.skeletonToolStripMenuItem.Name = "skeletonToolStripMenuItem";
            this.skeletonToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.skeletonToolStripMenuItem.Text = "Skeleton";
            this.skeletonToolStripMenuItem.Click += new System.EventHandler(this.skeletonToolStripMenuItem_Click);
            // 
            // halfTransparentToolStripMenuItem
            // 
            this.halfTransparentToolStripMenuItem.Name = "halfTransparentToolStripMenuItem";
            this.halfTransparentToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.halfTransparentToolStripMenuItem.Text = "Half Transparent";
            this.halfTransparentToolStripMenuItem.Click += new System.EventHandler(this.halfTransparentToolStripMenuItem_Click);
            // 
            // normalsToolStripMenuItem
            // 
            this.normalsToolStripMenuItem.Name = "normalsToolStripMenuItem";
            this.normalsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.normalsToolStripMenuItem.Text = "Normals";
            this.normalsToolStripMenuItem.Click += new System.EventHandler(this.normalsToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // animationSpeedToolStripMenuItem
            // 
            this.animationSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decreaseToolStripMenuItem,
            this.increaseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.animationSpeedToolStripMenuItem.Name = "animationSpeedToolStripMenuItem";
            this.animationSpeedToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.animationSpeedToolStripMenuItem.Text = "Animation Speed";
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // replaceTexturesToolStripMenuItem
            // 
            this.replaceTexturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diffuseToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.resetToolStripMenuItem1});
            this.replaceTexturesToolStripMenuItem.Name = "replaceTexturesToolStripMenuItem";
            this.replaceTexturesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.replaceTexturesToolStripMenuItem.Text = "Replace textures";
            // 
            // diffuseToolStripMenuItem
            // 
            this.diffuseToolStripMenuItem.Name = "diffuseToolStripMenuItem";
            this.diffuseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.diffuseToolStripMenuItem.Text = "Diffuse";
            this.diffuseToolStripMenuItem.Click += new System.EventHandler(this.diffuseToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // exportTexturesToolStripMenuItem
            // 
            this.exportTexturesToolStripMenuItem.Enabled = false;
            this.exportTexturesToolStripMenuItem.Name = "exportTexturesToolStripMenuItem";
            this.exportTexturesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportTexturesToolStripMenuItem.Text = "Export textures";
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
            this.Load += new System.EventHandler(this.frmRender_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundingBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem wireOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfTransparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diffuseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
    }
}