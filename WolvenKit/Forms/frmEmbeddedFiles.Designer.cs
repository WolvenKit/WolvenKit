using System.ComponentModel;
using BrightIdeasSoftware;

namespace WolvenKit
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
            this.ImportIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ImportPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ImportClass = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ClassName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Handle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.ImportIndex);
            this.listView.AllColumns.Add(this.ImportPath);
            this.listView.AllColumns.Add(this.ImportClass);
            this.listView.AllColumns.Add(this.Size);
            this.listView.AllColumns.Add(this.ClassName);
            this.listView.AllColumns.Add(this.Handle);
            this.listView.AlternateRowBackColor = System.Drawing.Color.LightCyan;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ImportIndex,
            this.ImportPath,
            this.ImportClass,
            this.Size,
            this.ClassName,
            this.Handle});
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(710, 447);
            this.listView.TabIndex = 5;
            this.listView.UseAlternatingBackColors = true;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listView_CellClick);
            // 
            // ImportIndex
            // 
            this.ImportIndex.AspectName = "Embedded.importIndex";
            this.ImportIndex.Text = "ImportIndex";
            // 
            // ImportPath
            // 
            this.ImportPath.AspectName = "ImportPath";
            this.ImportPath.Text = "ImportPath";
            // 
            // ImportClass
            // 
            this.ImportClass.AspectName = "ImportClass";
            this.ImportClass.Text = "ImportClass";
            // 
            // Size
            // 
            this.Size.AspectName = "Embedded.dataSize";
            this.Size.Text = "Size";
            // 
            // ClassName
            // 
            this.ClassName.AspectName = "ClassName";
            this.ClassName.Text = "ClassName";
            this.ClassName.Width = 120;
            // 
            // Handle
            // 
            this.Handle.AspectName = "Handle";
            this.Handle.FillsFreeSpace = true;
            this.Handle.Text = "Handle";
            // 
            // frmEmbeddedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 447);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmbeddedFiles";
            this.Text = "Embedded files:";
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ObjectListView listView;
        private OLVColumn ImportIndex;
        private OLVColumn Handle;
        private OLVColumn Size;
        private OLVColumn ClassName;
        private OLVColumn ImportPath;
        private OLVColumn ImportClass;
    }
}