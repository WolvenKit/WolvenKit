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
                        var key = "ImageSource/" + itemPath + "#" + part.PartName;
                        if (!Application.Current.Resources.Contains(key))
                        {
                            var Left = part.ClippingRectInUVCoords.Left * xbm.Width;
                            var Top = part.ClippingRectInUVCoords.Top * xbm.Height;
                            var Width = part.ClippingRectInUVCoords.Right * xbm.Width - Left;
                            var Height = part.ClippingRectInUVCoords.Bottom * xbm.Height - Top;
                            var partImage = new CroppedBitmap(image, new Int32Rect((int)Math.Round(Left), (int)Math.Round(Top), (int)Math.Round(Width), (int)Math.Round(Height)));
                            partImage.Freeze();

                            Application.Current.Resources.Add(key, partImage);
                        }
                    }

                    foreach (var slice in atlas.Slots[0].Slices)
                    {
                        var key = "RectF/" + itemPath + "#" + slice.PartName;
                        if (!Application.Current.Resources.Contains(key))
                            Application.Current.Resources.Add(key, slice.NineSliceScaleRect);
                    }
                }
                else if (Path.GetExtension(itemPath) == ".inkfontfamily")
                {
                    var ffHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var ffFile = File.GetFileFromHash(ffHash);
                    if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
                        continue;

                    foreach(var fs in ffr.FontStyles)
                    {
                        var key = "FontCollection/" + itemPath + "#" + fs.StyleName;
                        if (!Application.Current.Resources.Contains(key))
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

                            Application.Current.Resources.Add(key, pfc);
                        }
                    }
                }
                //else if(Path.GetExtension(itemPath) == ".inkstyle")
                //{
                //    var styleHash = FNV1A64HashAlgorithm.HashString(itemPath);
                //    var styleFile = File.GetFileFromHash(styleHash);

                //    if (styleFile == null || styleFile.RootChunk is not inkStyleResource sr)
                //        continue;

                //    foreach (inkStyle style in sr.Styles)
                //    {
                //        foreach (inkStyleProperty prop in style.Properties)
                //        {
                //            Application.Current.Resources.Add("CVariant/" + itemPath + "#" + prop.PropertyPath, prop.Value);
                //        }
                //    }
                //}
            }
            library = _library;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public bool IsDragging { get; set; }

    }
}
