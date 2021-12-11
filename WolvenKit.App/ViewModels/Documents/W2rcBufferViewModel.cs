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

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcBufferViewModel : W2rcFileViewModel
    {
        private RedBuffer _buffer;
        private readonly CR2WFile _w2RcFile;

        public W2rcBufferViewModel(RedBuffer buffer, CR2WFile w2rcFile) : base(buffer)
        {
            _buffer = buffer;
            _w2RcFile = w2rcFile;

            if (_w2RcFile.Chunks[0] is not CBitmapTexture xbm)
            {
                return;
            }

            if (_w2RcFile.Chunks[1] is not rendRenderTextureBlobPC blob)
            {
                return;
            }

            IsImagePreviewVisible = true;

            using var ddsstream = new MemoryStream();
            try
            {
                if (ModTools.ConvertCR2WToDdsStream(_w2RcFile, ddsstream, out _))
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

        async Task LoadImageFromStream(Stream stream)
        {

            var qa = await ImageDecoder.RenderToBitmapSourceDds(stream);
            if (qa != null)
            {
                Stream bmp = new MemoryStream();

                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(qa));
                enc.Save(bmp);
                ImageStream = bmp;
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override string ToString() => $"Buffer {_w2RcFile.Buffers.IndexOf(_buffer)}";
        //public override string ToString() => $"TODO.buffer";

        #endregion
    }
}
