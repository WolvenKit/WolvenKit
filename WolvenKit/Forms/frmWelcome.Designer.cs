namespace WolvenKit.Forms
{
    partial class frmWelcome
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
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.recentfilesLbl = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.recentfilesListView = new System.Windows.Forms.ListView();
            this.checkBoxDisable = new System.Windows.Forms.CheckBox();
            this.openProjectBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.CloseBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.newProjectBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxDisable);
            this.splitContainer1.Panel2.Controls.Add(this.openProjectBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CloseBtn);
            this.splitContainer1.Panel2.Controls.Add(this.newProjectBtn);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.visualLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.recentfilesLbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.recentfilesListView);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 58;
            this.splitContainer2.TabIndex = 0;
            // 
            // recentfilesLbl
            // 
            this.recentfilesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentfilesLbl.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recentfilesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recentfilesLbl.Location = new System.Drawing.Point(0, 0);
            this.recentfilesLbl.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.recentfilesLbl.Name = "recentfilesLbl";
            this.recentfilesLbl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.recentfilesLbl.Outline = false;
            this.recentfilesLbl.OutlineColor = System.Drawing.Color.Red;
            this.recentfilesLbl.OutlineLocation = new System.Drawing.Point(0, 0);
            this.recentfilesLbl.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recentfilesLbl.ReflectionSpacing = 0;
            this.recentfilesLbl.ShadowColor = System.Drawing.Color.Black;
            this.recentfilesLbl.ShadowDirection = 315;
            this.recentfilesLbl.ShadowLocation = new System.Drawing.Point(0, 0);
            this.recentfilesLbl.ShadowOpacity = 100;
            this.recentfilesLbl.Size = new System.Drawing.Size(266, 58);
            this.recentfilesLbl.TabIndex = 0;
            this.recentfilesLbl.Text = "Recent projects";
            this.recentfilesLbl.TextAlignment = System.Drawing.StringAlignment.Near;
            this.recentfilesLbl.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.recentfilesLbl.TextStyle = textStyle6;
            // 
            // recentfilesListView
            // 
            this.recentfilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentfilesListView.HideSelection = false;
            this.recentfilesListView.Location = new System.Drawing.Point(0, 0);
            this.recentfilesListView.Name = "recentfilesListView";
            this.recentfilesListView.ShowItemToolTips = true;
            this.recentfilesListView.Size = new System.Drawing.Size(266, 388);
            this.recentfilesListView.TabIndex = 0;
            this.recentfilesListView.UseCompatibleStateImageBehavior = false;
            this.recentfilesListView.View = System.Windows.Forms.View.List;
            // 
            // checkBoxDisable
            // 
            this.checkBoxDisable.AutoSize = true;
            this.checkBoxDisable.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxDisable.Location = new System.Drawing.Point(302, 418);
            this.checkBoxDisable.Name = "checkBoxDisable";
            this.checkBoxDisable.Size = new System.Drawing.Size(150, 17);
            this.checkBoxDisable.TabIndex = 5;
            this.checkBoxDisable.Text = "Don\'t show this form again";
            this.checkBoxDisable.UseVisualStyleBackColor = false;
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openProjectBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openProjectBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openProjectBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.openProjectBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.openProjectBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.openProjectBtn.Border.HoverVisible = true;
            this.openProjectBtn.Border.Rounding = 6;
            this.openProjectBtn.Border.Thickness = 1;
            this.openProjectBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.openProjectBtn.Border.Visible = true;
            this.openProjectBtn.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.openProjectBtn.Image = null;
            this.openProjectBtn.Location = new System.Drawing.Point(156, 405);
            this.openProjectBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(96, 33);
            this.openProjectBtn.TabIndex = 4;
            this.openProjectBtn.Text = "Open project";
            this.openProjectBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.openProjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.openProjectBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.openProjectBtn.TextStyle = textStyle1;
            this.openProjectBtn.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CloseBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CloseBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.CloseBtn.Border.HoverVisible = true;
            this.CloseBtn.Border.Rounding = 6;
            this.CloseBtn.Border.Thickness = 1;
            this.CloseBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.CloseBtn.Border.Visible = true;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.Image = null;
            this.CloseBtn.Location = new System.Drawing.Point(458, 405);
            this.CloseBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(60, 33);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CloseBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CloseBtn.TextStyle = textStyle2;
            this.CloseBtn.Click += new System.EventHandler(this.visualButton1_Click);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newProjectBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newProjectBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newProjectBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newProjectBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newProjectBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.newProjectBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.newProjectBtn.Border.HoverVisible = true;
            this.newProjectBtn.Border.Rounding = 6;
            this.newProjectBtn.Border.Thickness = 1;
            this.newProjectBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.newProjectBtn.Border.Visible = true;
            this.newProjectBtn.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newProjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newProjectBtn.Image = null;
            this.newProjectBtn.Location = new System.Drawing.Point(13, 405);
            this.newProjectBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(118, 33);
            this.newProjectBtn.TabIndex = 2;
            this.newProjectBtn.Text = "Create new project";
            this.newProjectBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newProjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.newProjectBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.newProjectBtn.TextStyle = textStyle3;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(530, 427);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // visualLabel1
            // 
            this.visualLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.visualLabel1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.Location = new System.Drawing.Point(0, 0);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(530, 23);
            this.visualLabel1.TabIndex = 0;
            this.visualLabel1.Text = "Getting Started";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle4;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmWelcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWelcome_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel recentfilesLbl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton CloseBtn;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton newProjectBtn;
        private System.Windows.Forms.ListView recentfilesListView;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton openProjectBtn;
        private System.Windows.Forms.CheckBox checkBoxDisable;
    }
}