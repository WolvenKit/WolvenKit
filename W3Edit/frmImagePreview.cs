using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                var image = GetImage(value);
                if (image == null)
                    ImageBox.Image = SystemIcons.Warning.ToBitmap();
                else
                    ImageBox.Image = image;
            }
        }

        private static Bitmap GetImage(CR2WFile file)
        {
            return file.chunks[0].Type == "CBitmapTexture" ? ImageUtility.Xbm2Dds(file.chunks[0]) : null;
        }
    }
}
