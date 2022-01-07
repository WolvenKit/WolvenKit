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
using ReactiveUI;
using WolvenKit.Common.FNV1A;
using System.Windows;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTWidgetViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public inkWidgetLibraryResource library;
        public RedDocumentViewModel File;
        //protected Stream ImageStream;
        public Dictionary<string, Dictionary<string, ImageSource>> AtlasParts;

        public RDTWidgetViewModel(RedBaseClass data, RedDocumentViewModel file)
        {
            Header = "Widget Preview";
            File = file;
            _data = data;
            library = data as inkWidgetLibraryResource;

            AtlasParts = new Dictionary<string, Dictionary<string, ImageSource>>();

            foreach (var f in library.ExternalDependenciesForInternalItems)
            {
                var atlasPath = f.DepotPath.GetValue();
                if (Path.GetExtension(atlasPath) == ".inkatlas")
                {
                    var atlasHash = FNV1A64HashAlgorithm.HashString(atlasPath);
                    var atlasFile = File.GetFileFromHash(atlasHash);
                    if (atlasFile != null && atlasFile.RootChunk is inkTextureAtlas atlas)
                    {
                        AtlasParts[atlasPath] = new Dictionary<string, ImageSource>();
                        var xbmHash = FNV1A64HashAlgorithm.HashString(atlas.Slots[0].Texture.DepotPath.ToString());
                        var xbmFile = File.GetFileFromHash(xbmHash);
                        if (xbmFile != null && xbmFile.RootChunk is CBitmapTexture xbm)
                        {
                            using var ddsstream = new MemoryStream();
                            if (ModTools.ConvertRedClassToDdsStream(xbm, ddsstream, out _))
                            {
                                var qa = ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                                if (qa.Result != null)
                                {
                                    var image = new TransformedBitmap(qa.Result, new ScaleTransform(1, -1));

                                    foreach (var part in atlas.Slots[0].Parts)
                                    {
                                        var Left = Math.Round(part.ClippingRectInUVCoords.Left * xbm.Width);
                                        var Top = Math.Round(part.ClippingRectInUVCoords.Top * xbm.Height);
                                        var Width = Math.Round(part.ClippingRectInUVCoords.Right * xbm.Width) - Left;
                                        var Height = Math.Round(part.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
                                        var partImage = new CroppedBitmap(image, new Int32Rect((int)Left, (int)Top, (int)Width, (int)Height));
                                        AtlasParts[atlasPath][part.PartName] = partImage;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public bool IsDragging { get; set; }

    }
}
