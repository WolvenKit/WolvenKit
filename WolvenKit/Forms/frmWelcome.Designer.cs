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
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.newProjectBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.openProjectBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.checkBoxDisable = new System.Windows.Forms.CheckBox();
            this.preferencesBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.label7 = new System.Windows.Forms.Label();
            this.continueWithoutModBtn = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(50, 805);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(600, 124);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // newProjectBtn
            // 
            this.newProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.newProjectBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newProjectBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.newProjectBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.newProjectBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.newProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newProjectBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.newProjectBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.newProjectBtn.Border.HoverVisible = false;
            this.newProjectBtn.Border.Rounding = 6;
            this.newProjectBtn.Border.Thickness = 1;
            this.newProjectBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.newProjectBtn.Border.Visible = false;
            this.newProjectBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.newProjectBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newProjectBtn.Image = null;
            this.newProjectBtn.Location = new System.Drawing.Point(799, 217);
            this.newProjectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newProjectBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.newProjectBtn.Name = "newProjectBtn";
            this.newProjectBtn.Size = new System.Drawing.Size(500, 80);
            this.newProjectBtn.TabIndex = 2;
            this.newProjectBtn.Text = "Create New Project";
            this.newProjectBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newProjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.newProjectBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.newProjectBtn.TextStyle = textStyle1;
            this.newProjectBtn.Click += new System.EventHandler(this.newProjectBtn_Click);
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.openProjectBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openProjectBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.openProjectBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.openProjectBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.openProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openProjectBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.openProjectBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.openProjectBtn.Border.HoverVisible = false;
            this.openProjectBtn.Border.Rounding = 6;
            this.openProjectBtn.Border.Thickness = 1;
            this.openProjectBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.openProjectBtn.Border.Visible = false;
            this.openProjectBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.openProjectBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.openProjectBtn.Image = null;
            this.openProjectBtn.Location = new System.Drawing.Point(799, 307);
            this.openProjectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openProjectBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(500, 80);
            this.openProjectBtn.TabIndex = 4;
            this.openProjectBtn.Text = "Open Project";
            this.openProjectBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.openProjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.openProjectBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.openProjectBtn.TextStyle = textStyle2;
            this.openProjectBtn.Click += new System.EventHandler(this.openProjectBtn_Click);
            // 
            // checkBoxDisable
            // 
            this.checkBoxDisable.AutoSize = true;
            this.checkBoxDisable.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxDisable.Enabled = false;
            this.checkBoxDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisable.Location = new System.Drawing.Point(56, 961);
            this.checkBoxDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDisable.Name = "checkBoxDisable";
            this.checkBoxDisable.Padding = new System.Windows.Forms.Padding(68, 15, 15, 15);
            this.checkBoxDisable.Size = new System.Drawing.Size(344, 54);
            this.checkBoxDisable.TabIndex = 5;
            this.checkBoxDisable.Text = "Don\'t show this form again";
            this.checkBoxDisable.UseVisualStyleBackColor = false;
            this.checkBoxDisable.Visible = false;
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.preferencesBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.preferencesBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.preferencesBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.preferencesBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.preferencesBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.preferencesBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.preferencesBtn.Border.HoverVisible = false;
            this.preferencesBtn.Border.Rounding = 6;
            this.preferencesBtn.Border.Thickness = 1;
            this.preferencesBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.preferencesBtn.Border.Visible = false;
            this.preferencesBtn.Font = new System.Drawing.Font("Calibri", 16F);
            this.preferencesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.preferencesBtn.Image = null;
            this.preferencesBtn.Location = new System.Drawing.Point(800, 397);
            this.preferencesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preferencesBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.Size = new System.Drawing.Size(500, 80);
            this.preferencesBtn.TabIndex = 12;
            this.preferencesBtn.Text = "Preferences";
            this.preferencesBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.preferencesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.preferencesBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.preferencesBtn.TextStyle = textStyle3;
            this.preferencesBtn.Click += new System.EventHandler(this.preferencesBtn_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.BackColor = System.Drawing.SystemColors.Control;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(50, 217);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(592, 519);
            this.objectListView1.TabIndex = 13;
            this.objectListView1.UseCellFormatEvents = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_CellClick);
            this.objectListView1.CellOver += new System.EventHandler<BrightIdeasSoftware.CellOverEventArgs>(this.objectListView1_CellOver);
            this.objectListView1.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.objectListView1_CellToolTipShowing);
            this.objectListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView1_FormatCell);
            this.objectListView1.MouseLeave += new System.EventHandler(this.objectListView1_MouseLeave);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Filename";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Filename";
            this.olvColumn1.Width = 100;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Fullpath";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Fullpath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "WolvenKit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Witcher 3 Community Modding Tools";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(1141, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Customize";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(740, 678);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Learn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(1307, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(50, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Recent Projects";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser2.Location = new System.Drawing.Point(746, 721);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(600, 250);
            this.webBrowser2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(44, 762);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Help";
            // 
            // continueWithoutModBtn
            // 
            this.continueWithoutModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.continueWithoutModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.continueWithoutModBtn.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.continueWithoutModBtn.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.continueWithoutModBtn.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.continueWithoutModBtn.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.continueWithoutModBtn.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.continueWithoutModBtn.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.continueWithoutModBtn.Border.HoverVisible = true;
            this.continueWithoutModBtn.Border.Rounding = 6;
            this.continueWithoutModBtn.Border.Thickness = 1;
            this.continueWithoutModBtn.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.continueWithoutModBtn.Border.Visible = false;
            this.continueWithoutModBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueWithoutModBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.continueWithoutModBtn.Image = null;
            this.continueWithoutModBtn.Location = new System.Drawing.Point(910, 510);
            this.continueWithoutModBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continueWithoutModBtn.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.continueWithoutModBtn.Name = "continueWithoutModBtn";
            this.continueWithoutModBtn.Size = new System.Drawing.Size(275, 36);
            this.continueWithoutModBtn.TabIndex = 22;
            this.continueWithoutModBtn.Text = "Continue Without Project";
            this.continueWithoutModBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.continueWithoutModBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.continueWithoutModBtn.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.continueWithoutModBtn.TextStyle = textStyle4;
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1400, 1000);
            this.Controls.Add(this.continueWithoutModBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.preferencesBtn);
            this.Controls.Add(this.checkBoxDisable);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.newProjectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 462);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWelcome_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton newProjectBtn;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton openProjectBtn;
        private System.Windows.Forms.CheckBox checkBoxDisable;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton preferencesBtn;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Label label7;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton continueWithoutModBtn;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
    }
}