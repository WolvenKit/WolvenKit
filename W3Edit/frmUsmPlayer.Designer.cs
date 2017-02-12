using System.ComponentModel;
using Vlc.DotNet.Forms;

namespace W3Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsmPlayer));
            this.usmPlayer = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // usmPlayer
            // 
            this.usmPlayer.BackColor = System.Drawing.Color.Black;
            this.usmPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usmPlayer.Location = new System.Drawing.Point(0, 0);
            this.usmPlayer.Name = "usmPlayer";
            this.usmPlayer.Size = new System.Drawing.Size(630, 287);
            this.usmPlayer.Spu = -1;
            this.usmPlayer.TabIndex = 0;
            this.usmPlayer.Text = "usmPlayer";
            this.usmPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("usmPlayer.VlcLibDirectory")));
            this.usmPlayer.VlcMediaplayerOptions = null;
            // 
            // frmUsmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 287);
            this.Controls.Add(this.usmPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmUsmPlayer";
            this.ShowIcon = false;
            this.Text = "Video preview";
            this.Shown += new System.EventHandler(this.frmUsmPlayer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.usmPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VlcControl usmPlayer;
    }
}