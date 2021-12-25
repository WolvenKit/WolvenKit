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
using System.ComponentModel;

namespace WolvenKit.ViewModels.Documents
{
    public class InkTextureAtlasViewModel : TextureViewModel
    {
        private inkTextureAtlas _atlas;

        public InkTextureAtlasViewModel(inkTextureAtlas atlas, CBitmapTexture xbm, RedDocumentViewModel file) : base(xbm, file)
        {
            _atlas = atlas;
            Header = "Part Mapping";
            Width = xbm.Width;
            Height = xbm.Height;
            foreach (var part in atlas.Slots[0].Parts)
            {
                OverlayItems.Add(new InkTextureAtlasMapperViewModel(part, xbm, atlas.Slots[0].Texture.DepotPath.ToString()));
            }
        }

        [Reactive] public List<InkTextureAtlasMapperViewModel> OverlayItems { get; set; } = new List<InkTextureAtlasMapperViewModel>();

        [Reactive] public float Width { get; set; }

        [Reactive] public float Height { get; set; }

        public class InkTextureAtlasMapperViewModel
        {
            [Reactive] public string PartName { get; set; }
            [Reactive] public string DepotPath { get; set; }
            [Reactive] public double Width { get; set; }
            [Reactive] public double Height { get; set; }
            [Browsable(false)]
            public inkTextureAtlasMapper Itam;
            [Browsable(false)]
            [Reactive] public double Left { get; set; }
            [Browsable(false)]
            [Reactive] public double Top { get; set; }
            [Browsable(false)]
            [Reactive] public string Name { get; set; }

            public InkTextureAtlasMapperViewModel(inkTextureAtlasMapper itam, CBitmapTexture xbm, string path)
            {
                Itam = itam;
                PartName = itam.PartName;
                DepotPath = path;
                Left = Math.Round(itam.ClippingRectInUVCoords.Left * xbm.Width);
                Top = Math.Round(itam.ClippingRectInUVCoords.Top * xbm.Height);
                Width = Math.Round(itam.ClippingRectInUVCoords.Right * xbm.Width) - Left;
                Height = Math.Round(itam.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
                Name = $"{itam.PartName} ({(uint)Width}x{(uint)Height})";
            }
        }
    }
}
