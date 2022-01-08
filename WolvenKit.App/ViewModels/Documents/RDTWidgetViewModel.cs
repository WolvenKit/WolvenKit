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
using System.Drawing.Text;
using System.Runtime.InteropServices;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTWidgetViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public inkWidgetLibraryResource library;
        public RedDocumentViewModel File;
        //protected Stream ImageStream;

        // [atlasPath][partName]
        public Dictionary<string, Dictionary<string, ImageSource>> AtlasParts = new();

        // [fontfamily][styleName] 
        public Dictionary<string, Dictionary<string, PrivateFontCollection>> Fonts = new();

        public RDTWidgetViewModel(RedBaseClass data, RedDocumentViewModel file)
        {
            Header = "Widget Preview";
            File = file;
            _data = data;
            var _library = data as inkWidgetLibraryResource;

            foreach (var f in _library.ExternalDependenciesForInternalItems)
            {
                var itemPath = f.DepotPath.GetValue();
                if (Path.GetExtension(itemPath) == ".inkatlas")
                {
                    var atlasHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var atlasFile = File.GetFileFromHash(atlasHash);
                    if (atlasFile == null || atlasFile.RootChunk is not inkTextureAtlas atlas)
                        continue;

                    AtlasParts[itemPath] = new Dictionary<string, ImageSource>();
                    var xbmHash = FNV1A64HashAlgorithm.HashString(atlas.Slots[0].Texture.DepotPath.ToString());
                    var xbmFile = File.GetFileFromHash(xbmHash);
                    if (xbmFile == null || xbmFile.RootChunk is not CBitmapTexture xbm)
                        continue;

                    using var ddsstream = new MemoryStream();
                    if (!ModTools.ConvertRedClassToDdsStream(xbm, ddsstream, out _))
                        continue;

                    var qa = ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                    if (qa.Result == null)
                        continue;

                    var image = new TransformedBitmap(qa.Result, new ScaleTransform(1, -1));

                    foreach (var part in atlas.Slots[0].Parts)
                    {
                        var Left = Math.Round(part.ClippingRectInUVCoords.Left * xbm.Width);
                        var Top = Math.Round(part.ClippingRectInUVCoords.Top * xbm.Height);
                        var Width = Math.Round(part.ClippingRectInUVCoords.Right * xbm.Width) - Left;
                        var Height = Math.Round(part.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
                        var partImage = new CroppedBitmap(image, new Int32Rect((int)Left, (int)Top, (int)Width, (int)Height));
                        AtlasParts[itemPath][part.PartName] = partImage;
                    }
                }
                else if (Path.GetExtension(itemPath) == ".inkfontfamily")
                {
                    var ffHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var ffFile = File.GetFileFromHash(ffHash);
                    if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
                        continue;

                    Fonts[itemPath] = new Dictionary<string, PrivateFontCollection>();
                    foreach(var fs in ffr.FontStyles)
                    {
                        var fontHash = FNV1A64HashAlgorithm.HashString(fs.Font.DepotPath.ToString());
                        var fontFile = File.GetFileFromHash(fontHash);
                        if (fontFile == null || fontFile.RootChunk is not rendFont rf)
                            continue;

                        PrivateFontCollection pfc = new();
                        var fontBytes = rf.FontBuffer.Buffer.GetBytes();
                        IntPtr ptrData = Marshal.AllocCoTaskMem(fontBytes.Length);
                        Marshal.Copy(fontBytes, 0, ptrData, fontBytes.Length);
                        pfc.AddMemoryFont(ptrData, fontBytes.Length);
                        Marshal.FreeCoTaskMem(ptrData);
                        //var font = pfc.Families[0];

                        //Writing bytes to a temporary file.
                        //string tempFontFileLoation = Path.Combine(ISettingsManager.GetManagerCacheDir(), fontHash + "_" + fs.StyleName + ".ttf");
                        //System.IO.File.WriteAllBytes(tempFontFileLoation, fontBytes);

                        ////Creating an instance of System.Windows.Media.GlyphTypeface.
                        ////From here we will read all the needed font details.
                        //var glyphTypeface = new GlyphTypeface(new Uri(tempFontFileLoation));

                        ////Reading font family name
                        //string fontFamilyName = String.Join(" ", glyphTypeface.FamilyNames.Values.ToArray<string>());

                        ////This is what we actually need... the right font family name, to be able to create a correct FontFamily Uri
                        //string fontUri = new Uri(tempFontFileLoation.Replace(Path.GetFileName(tempFontFileLoation), ""), UriKind.RelativeOrAbsolute).AbsoluteUri + "/#" + fontFamilyName;

                        ////And here is the instance of System.Windows.Media.FontFamily
                        //var fontFamily = new FontFamily(fontUri);

                        Fonts[itemPath][fs.StyleName] = pfc;
                    }
                }
            }
            library = _library;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public bool IsDragging { get; set; }

    }
}
