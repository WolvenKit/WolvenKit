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
using WolvenKit.CR2W;

namespace WolvenKit
{
    public partial class frmTextureFile : DockContent
    {
        private CR2WFile _file;

        public frmTextureFile()
        {
            InitializeComponent();
        }

        public CR2WFile File
        {
            get { return _file; }
            set
            {
                _file = value;
                //pictureBox1.Image = GetImage(value) ?? SystemIcons.Warning.ToBitmap();
            }
        }

        public void LoadImage(string imgPath)
        {
            DdsImage ddsImg = new DdsImage(System.IO.File.ReadAllBytes(imgPath));
            imageBox1.Image = ddsImg.BitmapImage;

            origImg = imageBox1.Image;

            Resize += FrmTextureFile_Resize;

            imageBox1.Image = ddsImg.BitmapImage;
        }

        public void LoadImage(Stream stream)
        {
            DdsImage ddsImg = new DdsImage(stream);
            imageBox1.Image = ddsImg.BitmapImage;

            origImg = imageBox1.Image;

            Resize += FrmTextureFile_Resize;
        }

        public void LoadImage(DdsImage ddsImg)
        {
            imageBox1.Image = ddsImg.BitmapImage;

            origImg = imageBox1.Image;

            Resize += FrmTextureFile_Resize;
        }

        public void LoadImage(Bitmap bitmap)
        {
            imageBox1.Image = bitmap;

            origImg = bitmap;

            Resize += FrmTextureFile_Resize;
        }

        private Image origImg;

        private void ResizeImage()
        {
            /*if (origImg.Width > Width || origImg.Height > Height)
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

            CenterPictureBox(pictureBox1, new Bitmap(pictureBox1.Image));*/
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
