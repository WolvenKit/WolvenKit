using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Cache;

namespace WolvenKit
{
    public partial class frmTextureFile : DockContent
    {
        public frmTextureFile(string imgPath)
        {
            InitializeComponent();

            DdsImage ddsImg = new DdsImage(File.ReadAllBytes(imgPath));
            this.pictureBox1.Image = ddsImg.BitmapImage;

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Anchor = AnchorStyles.None;

            CenterPictureBox(pictureBox1, new Bitmap(this.pictureBox1.Image));
        }

        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
            picBox.Refresh();
        }
    }
}
