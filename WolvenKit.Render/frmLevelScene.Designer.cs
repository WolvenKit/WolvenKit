using IrrlichtLime.Scene;
using System;

namespace WolvenKit.Render
{
    partial class frmLevelScene
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
            if (disposing)
            {
                components?.Dispose();
                irrThread?.Abort();
                irrThread = null;
                gui = null;
                smgr?.Drop();
                smgr = null;

                driver = null;
                device?.Close();
                device?.Drop();
                device?.Dispose();
                device = null;

                foreach(System.Windows.Forms.TreeNode t in sceneView.Nodes)
                {
                    if (t.Nodes.Count > 0)
                    {
                        // free the RenderTreeNodes!
                        foreach (RenderTreeNode rn in t.Nodes)
                        {
                            rn.MeshNode.Drop();
                        }
                    }
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelScene));
            this.levelPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.translateModeBtn = new System.Windows.Forms.Button();
            this.rotateModeBtn = new System.Windows.Forms.Button();
            this.queueSizeBar = new System.Windows.Forms.ProgressBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.distanceBar = new System.Windows.Forms.TrackBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addMeshButton = new System.Windows.Forms.ToolStripButton();
            this.exportMeshButton = new System.Windows.Forms.ToolStripButton();
            this.showAllButton = new System.Windows.Forms.ToolStripButton();
            this.sceneView = new System.Windows.Forms.TreeView();
            this.irrlichtPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.levelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceBar)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelPanel
            // 
            this.levelPanel.Controls.Add(this.splitContainer);
            this.levelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelPanel.Location = new System.Drawing.Point(0, 0);
            this.levelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.Size = new System.Drawing.Size(993, 527);
            this.levelPanel.TabIndex = 2;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.translateModeBtn);
            this.splitContainer.Panel1.Controls.Add(this.rotateModeBtn);
            this.splitContainer.Panel1.Controls.Add(this.queueSizeBar);
            this.splitContainer.Panel1.Controls.Add(this.progressBar);
            this.splitContainer.Panel1.Controls.Add(this.distanceBar);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer.Panel1.Controls.Add(this.sceneView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.irrlichtPanel);
            this.splitContainer.Size = new System.Drawing.Size(993, 527);
            this.splitContainer.SplitterDistance = 331;
            this.splitContainer.TabIndex = 1;
            // 
            // translateModeBtn
            // 
            this.translateModeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.translateModeBtn.Image = global::WolvenKit.Render.Properties.Resources.move1;
            this.translateModeBtn.Location = new System.Drawing.Point(301, 4);
            this.translateModeBtn.Name = "translateModeBtn";
            this.translateModeBtn.Size = new System.Drawing.Size(24, 24);
            this.translateModeBtn.TabIndex = 7;
            this.translateModeBtn.UseVisualStyleBackColor = true;
            // 
            // rotateModeBtn
            // 
            this.rotateModeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateModeBtn.Image = global::WolvenKit.Render.Properties.Resources.rotate;
            this.rotateModeBtn.Location = new System.Drawing.Point(268, 4);
            this.rotateModeBtn.Name = "rotateModeBtn";
            this.rotateModeBtn.Size = new System.Drawing.Size(24, 24);
            this.rotateModeBtn.TabIndex = 6;
            this.rotateModeBtn.UseVisualStyleBackColor = true;
            // 
            // queueSizeBar
            // 
            this.queueSizeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queueSizeBar.ForeColor = System.Drawing.Color.Gold;
            this.queueSizeBar.Location = new System.Drawing.Point(0, 504);
            this.queueSizeBar.Name = "queueSizeBar";
            this.queueSizeBar.Size = new System.Drawing.Size(0, 10);
            this.queueSizeBar.TabIndex = 4;
            this.queueSizeBar.Resize += new System.EventHandler(this.queueSizeBar_Resize);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.progressBar.Location = new System.Drawing.Point(0, 514);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(0, 10);
            this.progressBar.TabIndex = 5;
            this.progressBar.Resize += new System.EventHandler(this.progressBar_Resize);
            // 
            // distanceBar
            // 
            this.distanceBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceBar.AutoSize = false;
            this.distanceBar.LargeChange = 1;
            this.distanceBar.Location = new System.Drawing.Point(130, 3);
            this.distanceBar.Maximum = 5;
            this.distanceBar.Minimum = 1;
            this.distanceBar.Name = "distanceBar";
            this.distanceBar.Size = new System.Drawing.Size(132, 22);
            this.distanceBar.TabIndex = 3;
            this.distanceBar.Value = 2;
            this.distanceBar.ValueChanged += new System.EventHandler(this.distanceBar_ValueChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMeshButton,
            this.exportMeshButton,
            this.showAllButton,
            this.saveButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(35, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // addMeshButton
            // 
            this.addMeshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addMeshButton.Enabled = false;
            this.addMeshButton.Image = global::WolvenKit.Render.Properties.Resources.AddNodefromFile_354;
            this.addMeshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addMeshButton.Name = "addMeshButton";
            this.addMeshButton.Size = new System.Drawing.Size(23, 20);
            this.addMeshButton.Text = "toolStripButton1";
            this.addMeshButton.ToolTipText = "Add more meshes";
            this.addMeshButton.Click += new System.EventHandler(this.addMeshButton_Click);
            // 
            // exportMeshButton
            // 
            this.exportMeshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportMeshButton.Enabled = false;
            this.exportMeshButton.Image = global::WolvenKit.Render.Properties.Resources.Output_16x;
            this.exportMeshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportMeshButton.Name = "exportMeshButton";
            this.exportMeshButton.Size = new System.Drawing.Size(23, 20);
            this.exportMeshButton.Text = "toolStripButton1";
            this.exportMeshButton.ToolTipText = "Export meshes";
            this.exportMeshButton.Click += new System.EventHandler(this.exportMeshButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showAllButton.Image = ((System.Drawing.Image)(resources.GetObject("showAllButton.Image")));
            this.showAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(23, 20);
            this.showAllButton.Text = "Show All";
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // sceneView
            // 
            this.sceneView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sceneView.CheckBoxes = true;
            this.sceneView.Location = new System.Drawing.Point(0, 28);
            this.sceneView.Name = "sceneView";
            this.sceneView.Size = new System.Drawing.Size(331, 469);
            this.sceneView.TabIndex = 1;
            this.sceneView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sceneView_AfterCheck);
            this.sceneView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sceneView_AfterSelect);
            // 
            // irrlichtPanel
            // 
            this.irrlichtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irrlichtPanel.Location = new System.Drawing.Point(0, 0);
            this.irrlichtPanel.Name = "irrlichtPanel";
            this.irrlichtPanel.Size = new System.Drawing.Size(658, 527);
            this.irrlichtPanel.TabIndex = 0;
            this.irrlichtPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseClick);
            this.irrlichtPanel.MouseEnter += new System.EventHandler(this.irrlichtPanel_Enter);
            this.irrlichtPanel.MouseLeave += new System.EventHandler(this.irrlichtPanel_Leave);
            this.irrlichtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseMove);
            this.irrlichtPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.irrlichtPanel_MouseWheel);
            this.irrlichtPanel.Resize += new System.EventHandler(this.irrlichtPanel_Resize);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 20);
            this.saveButton.Text = "toolStripButton1";
            this.saveButton.ToolTipText = "Save Changes";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // frmLevelScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 527);
            this.Controls.Add(this.levelPanel);
            this.KeyPreview = true;
            this.Name = "frmLevelScene";
            this.ShowIcon = false;
            this.Text = "Level Scene renderer";
            this.Load += new System.EventHandler(this.frmLevelScene_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLevelScene_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLevelScene_KeyUp);
            this.levelPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanceBar)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Panel levelPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView sceneView;
        private System.Windows.Forms.Panel irrlichtPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addMeshButton;
        private System.Windows.Forms.ToolStripButton exportMeshButton;
        private System.Windows.Forms.ToolStripButton showAllButton;
        private System.Windows.Forms.TrackBar distanceBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ProgressBar queueSizeBar;
        private System.Windows.Forms.Button rotateModeBtn;
        private System.Windows.Forms.Button translateModeBtn;
        private System.Windows.Forms.ToolStripButton saveButton;
    }
}