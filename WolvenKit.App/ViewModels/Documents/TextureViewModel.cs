using System;
using System.IO;
using DynamicData;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Modkit.RED4;
using Splat;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;
using System.Windows.Media;
using WolvenKit.RED4.Archive.Buffer;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public class TextureViewModel : W2rcFileViewModel
    {
        protected string _header { get; set; }

        public TextureViewModel(CBitmapTexture data, RedDocumentViewModel file) : base(data, file)
        {
            IsImagePreviewVisible = true;
            _header = "Preview";

            SetupImage(data);
        }

        protected void SetupImage(CBitmapTexture xbm)
        {
            using var ddsstream = new MemoryStream();
            try
            {
                if (ModTools.ConvertXBMToDdsStream(xbm, ddsstream, out _))
                {
                    _ = LoadImageFromStream(ddsstream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        protected async Task LoadImageFromStream(Stream stream)
        {

            var qa = await ImageDecoder.RenderToBitmapSourceDds(stream);
            if (qa != null)
            {
                Image = qa;
                //Stream bmp = new MemoryStream();

                //BitmapEncoder enc = new BmpBitmapEncoder();
                //var frame = BitmapFrame.Create(qa);
                //enc.Frames.Add(frame);
                //enc.Save(bmp);
                //ImageStream = bmp;
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override ChunkViewModel GenerateChunks() => null;

        public override string ToString() => _header;

        #endregion
    }
}
