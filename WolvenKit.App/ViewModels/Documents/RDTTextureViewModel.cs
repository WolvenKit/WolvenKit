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
    public class RDTTextureViewModel : RedDocumentTabViewModel
    {
        protected readonly IRedClass _data;
        public RedDocumentViewModel File;
        //protected Stream ImageStream;

        public RDTTextureViewModel(IRedClass data, RedDocumentViewModel file)
        {
            Header = "Texture Preview";
            File = file;
            _data = data;

            SetupImage();
        }

        public RDTTextureViewModel(Stream stream, RedDocumentViewModel file)
        {
            Header = "Preview";
            File = file;
            //_data = data;
            //ImageStream = stream;

            _ = LoadImageFromStream(stream);
        }

        protected void SetupImage()
        {
            using var ddsstream = new MemoryStream();
            try
            {
                if (ModTools.ConvertRedClassToDdsStream(_data, ddsstream, out _))
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
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

    }
}
