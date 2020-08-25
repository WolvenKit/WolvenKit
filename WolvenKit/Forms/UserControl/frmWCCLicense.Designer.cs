namespace WolvenKit
{
    partial class frmWCCLicense
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
            this.browserwcclicense = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // browserwcclicense
            // 
            this.browserwcclicense.AllowNavigation = false;
            this.browserwcclicense.AllowWebBrowserDrop = false;
            this.browserwcclicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserwcclicense.Location = new System.Drawing.Point(0, 0);
            this.browserwcclicense.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserwcclicense.Name = "browserwcclicense";
            this.browserwcclicense.Size = new System.Drawing.Size(643, 568);
            this.browserwcclicense.TabIndex = 0;
            this.browserwcclicense.WebBrowserShortcutsEnabled = false;
            // 
            // frmWCCLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 568);
            this.Controls.Add(this.browserwcclicense);
            this.Name = "frmWCCLicense";
            this.ShowIcon = false;
            this.Text = "Witcher III Modding Tool License";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserwcclicense;
    }
}