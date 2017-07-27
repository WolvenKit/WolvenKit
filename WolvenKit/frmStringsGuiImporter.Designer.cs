namespace WolvenKit
{
    partial class frmStringsGuiImporter
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLoadCustom = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonLoadGameStr = new System.Windows.Forms.Button();
            this.listViewStrings = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStringsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxMachCaseSearch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMachCaseSearch);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoadCustom);
            this.splitContainer1.Panel1.Controls.Add(this.buttonImport);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxLanguage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoadGameStr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewStrings);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 568);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearch.Location = new System.Drawing.Point(273, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(615, 23);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(894, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLoadCustom
            // 
            this.buttonLoadCustom.Location = new System.Drawing.Point(138, 13);
            this.buttonLoadCustom.Name = "buttonLoadCustom";
            this.buttonLoadCustom.Size = new System.Drawing.Size(129, 23);
            this.buttonLoadCustom.TabIndex = 3;
            this.buttonLoadCustom.Text = "Load custom strings";
            this.buttonLoadCustom.UseVisualStyleBackColor = true;
            this.buttonLoadCustom.Click += new System.EventHandler(this.buttonLoadCustom_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(975, 13);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(103, 23);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import selected";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "ar",
            "br",
            "cz",
            "de",
            "en",
            "es",
            "esMX",
            "fr",
            "hu",
            "it",
            "jp",
            "kr",
            "pl",
            "ru",
            "tr",
            "zh"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(4, 39);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(128, 21);
            this.comboBoxLanguage.TabIndex = 1;
            // 
            // buttonLoadGameStr
            // 
            this.buttonLoadGameStr.Location = new System.Drawing.Point(4, 13);
            this.buttonLoadGameStr.Name = "buttonLoadGameStr";
            this.buttonLoadGameStr.Size = new System.Drawing.Size(128, 23);
            this.buttonLoadGameStr.TabIndex = 0;
            this.buttonLoadGameStr.Text = "Load game strings";
            this.buttonLoadGameStr.UseVisualStyleBackColor = true;
            this.buttonLoadGameStr.Click += new System.EventHandler(this.buttonLoadGameStr_Click);
            // 
            // listViewStrings
            // 
            this.listViewStrings.BackColor = System.Drawing.SystemColors.Window;
            this.listViewStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStrings.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewStrings.GridLines = true;
            this.listViewStrings.Location = new System.Drawing.Point(0, 0);
            this.listViewStrings.Name = "listViewStrings";
            this.listViewStrings.Size = new System.Drawing.Size(1090, 479);
            this.listViewStrings.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewStrings.TabIndex = 0;
            this.listViewStrings.UseCompatibleStateImageBehavior = false;
            this.listViewStrings.View = System.Windows.Forms.View.Tile;
            this.listViewStrings.ItemActivate += new System.EventHandler(this.listViewStrings_ItemActivate);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStringsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStringsCount
            // 
            this.toolStripStatusLabelStringsCount.Name = "toolStripStatusLabelStringsCount";
            this.toolStripStatusLabelStringsCount.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabelStringsCount.Text = "Strings Loaded: 0";
            // 
            // checkBoxMachCaseSearch
            // 
            this.checkBoxMachCaseSearch.AutoSize = true;
            this.checkBoxMachCaseSearch.Location = new System.Drawing.Point(273, 44);
            this.checkBoxMachCaseSearch.Name = "checkBoxMachCaseSearch";
            this.checkBoxMachCaseSearch.Size = new System.Drawing.Size(85, 17);
            this.checkBoxMachCaseSearch.TabIndex = 6;
            this.checkBoxMachCaseSearch.Text = "Match case.";
            this.checkBoxMachCaseSearch.UseVisualStyleBackColor = true;
            this.checkBoxMachCaseSearch.CheckedChanged += new System.EventHandler(this.checkBoxMachCaseSearch_CheckedChanged);
            // 
            // frmStringsGuiImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 568);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmStringsGuiImporter";
            this.Text = "W3Strings Importer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewStrings;
        private System.Windows.Forms.Button buttonLoadGameStr;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonLoadCustom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStringsCount;
        private System.Windows.Forms.CheckBox checkBoxMachCaseSearch;
    }
}