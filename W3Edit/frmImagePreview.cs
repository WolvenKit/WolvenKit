using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Cache;

namespace WolvenKit
{
    public partial class frmImagePreview : DockContent
    {
        private CR2WFile _file;

        public frmImagePreview()
        {
            InitializeComponent();
        }

        public CR2WFile File
        {
            get { return _file; }
            set {
                _file = value;
                ImagePreviewControl.Image = GetImage(value) ?? SystemIcons.Warning.ToBitmap();
            }
        }

        private static Bitmap GetImage(CR2WFile file)
        {
            return file.chunks[0].Type == "CBitmapTexture" ? ImageUtility.Xbm2Dds(file.chunks[0]) : null;
        }

        private void copyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(ImagePreviewControl.Image);
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = @"Choose a location to save.";
                sf.Filter = @"Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf"; ;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    ImagePreviewControl.Image.Save(sf.FileName);
                }
            }
        }

        private void replaceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = @"Choose an image";
                of.Filter = @"Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf"; ;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    ImagePreviewControl.Image = Image.FromFile(of.FileName);
                    UpdateFileWithImage(ImagePreviewControl.Image);
                }
            }
        }

        public void UpdateFileWithImage(Image image)
        {
            //TODO: Finish this
            if (File.chunks[0].Type == "CBitmapTexture")
            {
                //((CBitmapTexture)File.chunks[0].data).Image.Bytes = ImageUtility.Dds2Xbm(System.IO.File.ReadAllBytes(of.FileName));
            }
        }
    }
}
