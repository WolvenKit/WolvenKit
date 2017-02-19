using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmImagePreview : DockContent
    {
        private CR2WFile _file;

        public frmImagePreview()
        {
            InitializeComponent();
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;

        }

        public CR2WFile File
        {
            get { return _file; }
            set {
                _file = value;
                ImageBox.Image = GetImage(value) ?? SystemIcons.Warning.ToBitmap();
            }
        }

        private static Bitmap GetImage(CR2WFile file)
        {
            return file.chunks[0].Type == "CBitmapTexture" ? ImageUtility.Xbm2Dds(file.chunks[0]) : null;
        }

        private void copyImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(ImageBox.Image);
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = @"Choose a location to save.";
                sf.Filter = @"Bitmap | *.bmp;Jpeg image | *.jpg; PNG image | *.png;";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    ImageBox.Image.Save(sf.FileName);
                }
            }
        }

        private void replaceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = @"Choose an image";
                of.Filter = @"Bitmap | *.bmp;Jpeg image | *.jpg; PNG image | *.png;";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    //TODO: Replace image
                }
            }
        }
    }
}

/* Bmp { get; }
   Emf { get; }
   Exif { get; }
   Gif { get; }
   Icon { get; }
   Jpeg { get; }
   MemoryBmp { get; }
   Png { get; }
   Tiff { get; }
   Wmf { get; }*/
