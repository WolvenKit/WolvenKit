using System.ComponentModel;

namespace WolvenKit.Scaleform
{
    partial class frmUsmPlayer
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
            this.SuspendLayout();
            // 
            // frmUsmPlayer
            // 
            this.Name = "frmUsmPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsmPlayer_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private BackgroundWorker videoConverter;
        private System.Windows.Forms.Label statusLabel;
    }
}