using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Cache;
using WolvenKit.CR2W.Types;
using System.IO;
using System.Linq;

namespace WolvenKit
{
    public partial class frmImagePreview : DockContent
    {
        private enum EGDIFormats
        {
            BMP,
            GIF,
            JPG, //?
            JPEG,
            PNG,
            TIFF
        }

        public frmImagePreview()
        {
            InitializeComponent();
        }

        public void SetImage(string path)
        {
            if (Enum.GetNames(typeof(EGDIFormats)).Contains(Path.GetExtension(path).TrimStart('.').ToUpper()))
                ImagePreviewControl.Image = Image.FromFile(path) ?? SystemIcons.Warning.ToBitmap();
            else if (Path.GetExtension(path).ToUpper().Contains("TGA") || Path.GetExtension(path).ToUpper().Contains("DDS"))
                ImagePreviewControl.Image = ImageUtility.FromFile(path) ?? SystemIcons.Warning.ToBitmap();
            else
                ImagePreviewControl.Image = SystemIcons.Warning.ToBitmap();
            this.Text = Path.GetFileName(path);
        }

        public void SetImage(CR2WExportWrapper chunk)
        {
            CBitmapTexture xbm = chunk.data as CBitmapTexture;
            ImagePreviewControl.Image = ImageUtility.Xbm2Bmp(xbm) ?? SystemIcons.Warning.ToBitmap();
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
            //if (File.chunks[0].Type == "CBitmapTexture")
            //{
            //    //((CBitmapTexture)File.chunks[0].data).Image.Bytes = ImageUtility.Dds2Xbm(System.IO.File.ReadAllBytes(of.FileName));
            //}
        }
    }
}
