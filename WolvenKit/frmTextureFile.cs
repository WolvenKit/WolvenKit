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
            //MouseWheel += FrmTextureFile_MouseWheel;

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
        //private int zoomFactor = 100;

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

        /*private void FrmTextureFile_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                zoomFactor += 20;
            else if(zoomFactor > 20)
                zoomFactor -= 20;

            Size newSize = new Size((int)(origImg.Width * zoomFactor/100f), (int)(origImg.Height * zoomFactor/100f));
            pictureBox1.Image = new Bitmap(origImg, newSize);

            CenterPictureBox(pictureBox1, new Bitmap(pictureBox1.Image));
        }*/

        private void FrmTextureFile_Resize(object sender, EventArgs e)
        {
            ResizeImage();
        }
    }
}
