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
    public class InkTextureAtlasViewModel : TextureViewModel
    {
        public InkTextureAtlasViewModel(inkTextureAtlas atlas, CBitmapTexture xbm, RedDocumentViewModel file) : base(xbm, file)
        {
            foreach (var part in atlas.Slots[0].Parts)
            {
                OverlayItems.Add(new InkTextureAtlasMapperViewModel(part, xbm));
            }
        }

        [Reactive] public List<InkTextureAtlasMapperViewModel> OverlayItems { get; set; } = new List<InkTextureAtlasMapperViewModel>();

        public class InkTextureAtlasMapperViewModel
        {
            [Reactive] public float Left { get; set; }
            [Reactive] public float Top { get; set; }
            [Reactive] public float Width { get; set; }
            [Reactive] public float Height { get; set; }
            [Reactive] public string Name { get; set; }

            public InkTextureAtlasMapperViewModel(inkTextureAtlasMapper itam, CBitmapTexture xbm)
            {
                Left = itam.ClippingRectInUVCoords.Left * xbm.Width;
                Top = itam.ClippingRectInUVCoords.Top * xbm.Height;
                Width = itam.ClippingRectInUVCoords.Right * xbm.Width - Left;
                Height = itam.ClippingRectInUVCoords.Bottom * xbm.Height - Top;
                Name = itam.PartName;
            }
        }
    }
}
