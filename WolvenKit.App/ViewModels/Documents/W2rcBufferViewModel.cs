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
    public class W2rcBufferViewModel : W2rcFileViewModel
    {
        private int _bufferIndex;

        public W2rcBufferViewModel(CR2WFile w2rcFile, int bufferIndex, DirtyDelegate setIsDirty) : base(w2rcFile, setIsDirty)
        {
            _bufferIndex = bufferIndex;
            
            if (_file.Chunks[0] is not CBitmapTexture xbm)
            {
                return;
            }

            if (_file.Chunks[1] is not rendRenderTextureBlobPC blob)
            {
                return;
            }

            IsImagePreviewVisible = true;

            using var ddsstream = new MemoryStream();
            try
            {
                if (ModTools.ConvertCR2WToDdsStream(_file, ddsstream, out _))
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

        public override List<ChunkViewModel> GenerateChunks()
        {
            if (_file.Buffers[_bufferIndex] != null && _file.Buffers[_bufferIndex].Data is Package04 pkg)
            {
                return pkg.Chunks?.Select(_ => new ChunkViewModel(_, this)).ToList() ?? null;
            }
            else
            {
                return null;
            }
        }

        public override string ToString() => $"Buffer {_bufferIndex}";
        //public override string ToString() => $"TODO.buffer";

        #endregion
    }
}
