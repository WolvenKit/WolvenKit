namespace WolvenKit.Render.FastRender
{
    partial class frmFastRender
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
            this.backgroundRendering = new System.ComponentModel.BackgroundWorker();
            this.panelRenderWindow = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadRigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAnimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.exportTexturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundRendering
            // 
            this.backgroundRendering.WorkerReportsProgress = true;
            this.backgroundRendering.WorkerSupportsCancellation = true;
            this.backgroundRendering.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundRendering_DoWork);
            this.backgroundRendering.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundRendering_RunWorkerCompleted);
            // 
            // panelRenderWindow
            // 
            this.panelRenderWindow.ContextMenuStrip = this.contextMenuStrip;
            this.panelRenderWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRenderWindow.Location = new System.Drawing.Point(0, 0);
            this.panelRenderWindow.Name = "panelRenderWindow";
            this.panelRenderWindow.Size = new System.Drawing.Size(773, 713);
            this.panelRenderWindow.TabIndex = 0;
            this.panelRenderWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRenderWindow_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRigToolStripMenuItem,
            this.loadAnimToolStripMenuItem,
            this.selectAnimationToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewToolStripMenuItem,
            this.animationSpeedToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportTexturesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(204, 220);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // loadRigToolStripMenuItem
            // 
            this.loadRigToolStripMenuItem.Name = "loadRigToolStripMenuItem";
            this.loadRigToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadRigToolStripMenuItem.Text = "Load Rig (*.w2rig)";
            this.loadRigToolStripMenuItem.Click += new System.EventHandler(this.loadRigToolStripMenuItem_Click);
            // 
            // loadAnimToolStripMenuItem
            // 
            this.loadAnimToolStripMenuItem.Enabled = false;
            this.loadAnimToolStripMenuItem.Name = "loadAnimToolStripMenuItem";
            this.loadAnimToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadAnimToolStripMenuItem.Text = "Load Anims (*.w2anims)";
            this.loadAnimToolStripMenuItem.Click += new System.EventHandler(this.loadAnimToolStripMenuItem_Click);
            // 
            // selectAnimationToolStripMenuItem
            // 
            this.selectAnimationToolStripMenuItem.Enabled = false;
            this.selectAnimationToolStripMenuItem.Name = "selectAnimationToolStripMenuItem";
            this.selectAnimationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectAnimationToolStripMenuItem.Text = "Play animation";
            this.selectAnimationToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.selectAnimationToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
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
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewToolStripMenuItem.Text = "View";
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
            this.animationSpeedToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Enabled = false;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(200, 6);
            // 
            // exportTexturesToolStripMenuItem
            // 
            this.exportTexturesToolStripMenuItem.Enabled = false;
            this.exportTexturesToolStripMenuItem.Name = "exportTexturesToolStripMenuItem";
            this.exportTexturesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exportTexturesToolStripMenuItem.Text = "Export textures";
            // 
            // frmFastRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 713);
            this.Controls.Add(this.panelRenderWindow);
            this.Name = "frmFastRender";
            this.ShowIcon = false;
            this.Text = "frmFastRender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFastRender_FormClosing);
            this.Load += new System.EventHandler(this.frmFastRender_Load);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panelRenderWindow_MouseWheel);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundRendering;
        private System.Windows.Forms.Panel panelRenderWindow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadRigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAnimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boundingBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skeletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfTransparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportTexturesToolStripMenuItem;
    }
}