using System.ComponentModel;
using BrightIdeasSoftware;

namespace W3Edit
{
    partial class frmEmbeddedFiles
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new BrightIdeasSoftware.ObjectListView();
            this.colSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colUnk3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colUnk4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.colSize);
            this.listView.AllColumns.Add(this.colUnk3);
            this.listView.AllColumns.Add(this.colUnk4);
            this.listView.AllColumns.Add(this.colName);
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSize,
            this.colUnk3,
            this.colUnk4,
            this.colName});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(284, 262);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listView_CellClick);
            // 
            // colSize
            // 
            this.colSize.AspectName = "size";
            this.colSize.Text = "Size";
            this.colSize.Width = 100;
            // 
            // colName
            // 
            this.colName.AspectName = "Handles";
            this.colName.Text = "Handles";
            this.colName.Width = 400;
            // 
            // colUnk3
            // 
            this.colUnk3.AspectName = "unk3";
            this.colUnk3.Text = "unk3";
            // 
            // colUnk4
            // 
            this.colUnk4.AspectName = "unk4";
            this.colUnk4.Text = "unk4";
            // 
            // frmEmbeddedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmbeddedFiles";
            this.Text = "Embedded files";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ObjectListView listView;
        private OLVColumn colSize;
        private OLVColumn colName;
        private OLVColumn colUnk3;
        private OLVColumn colUnk4;
    }
}