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
        public frmTextureFile()
        {
            InitializeComponent();
        }

        public void LoadImage(string imgPath)
        {
            DdsImage ddsImg = new DdsImage(File.ReadAllBytes(imgPath));
            pictureBox1.Image = ddsImg.BitmapImage;

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Anchor = AnchorStyles.None;

            origImg = pictureBox1.Image;

            ResizeImage();

            Resize += FrmTextureFile_Resize;
        }

        private Image origImg;

        private void ResizeImage()
        {
            if (origImg.Width > Width || origImg.Height > Height)
            {
                Size newSize;
                float ratio = pictureBox1.Image.Height / (float)pictureBox1.Image.Width;
                if (pictureBox1.Image.Width > pictureBox1.Image.Height)
                    newSize = new Size(Width, (int)(ratio * Width));
                else
                    newSize = new Size((int)(1 / ratio * Height), Height);
                if(newSize.Height > 0 && newSize.Width > 0)
                    pictureBox1.Image = new Bitmap(origImg, newSize);
            }

            CenterPictureBox(pictureBox1, new Bitmap(pictureBox1.Image));
        }
        
        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
            picBox.Refresh();
        }

        private void FrmTextureFile_Resize(object sender, EventArgs e)
        {
            ResizeImage();
        }
    }
}
