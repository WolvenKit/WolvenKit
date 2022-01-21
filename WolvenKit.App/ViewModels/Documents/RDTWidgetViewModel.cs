using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTWidgetViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public inkWidgetLibraryResource library;
        public RedDocumentViewModel File;

        [Reactive] public Dictionary<object, inkTextWidget> TextWidgets { get; set; } = new();

        [Reactive] public List<string> StyleStates { get; set; } = new();

        [Reactive] public string CurrentStyleState { get; set; }

        [Reactive] public List<string> Themes { get; set; } = new();

        [Reactive] public string CurrentTheme { get; set; }

        [Reactive] public Color WidgetBackground { get; set; }

        [Reactive] public List<string> Bindings { get; set; } = new();

        [Reactive] public List<inkanimSequence> inkAnimations { get; set; } = new();

        public RDTWidgetViewModel(RedBaseClass data, RedDocumentViewModel file)
        {
            Header = "Widget Preview";
            File = file;
            _data = data;
            var _library = data as inkWidgetLibraryResource;

            var animPath = _library.AnimationLibraryResRef?.DepotPath?.GetValue() ?? "";
            var animHash = FNV1A64HashAlgorithm.HashString(animPath);
            var animFile = File.GetFileFromDepotPath(animHash);

            if (animFile != null && animFile.RootChunk is inkanimAnimationLibraryResource alr)
            {
                foreach (var seq in alr.Sequences)
                {
                    inkAnimations.Add((inkanimSequence)seq.GetValue());
                }
            }

            foreach (var f in _library.ExternalDependenciesForInternalItems)
            {
                var itemPath = f.DepotPath.GetValue();
                if (Path.GetExtension(itemPath) == ".inkatlas")
                {
                    var atlasHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var atlasFile = File.GetFileFromDepotPath(atlasHash);
                    if (atlasFile == null || atlasFile.RootChunk is not inkTextureAtlas atlas)
                    {
                        continue;
                    }

                    var xbmHash = FNV1A64HashAlgorithm.HashString(atlas?.Slots[0]?.Texture?.DepotPath?.ToString() ?? "");
                    var xbmFile = File.GetFileFromDepotPath(xbmHash);
                    if (xbmFile == null || xbmFile.RootChunk is not CBitmapTexture xbm)
                    {
                        continue;
                    }

                    using var ddsstream = new MemoryStream();
                    if (!ModTools.ConvertRedClassToDdsStream(xbm, ddsstream, out _))
                    {
                        continue;
                    }

                    var qa = ImageDecoder.RenderToBitmapSourceDds(ddsstream);
                    if (qa.Result == null)
                    {
                        continue;
                    }

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
                        {
                            Application.Current.Resources.Add(key, slice.NineSliceScaleRect);
                        }
                    }
                }
                else if (Path.GetExtension(itemPath) == ".inkfontfamily")
                {
                    var ffHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var ffFile = File.GetFileFromDepotPath(ffHash);
                    if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
                    {
                        continue;
                    }

                    foreach (var fs in ffr.FontStyles)
                    {
                        var key = "FontCollection/" + itemPath + "#" + fs.StyleName;
                        if (!Application.Current.Resources.Contains(key))
                        {
                            var fontHash = FNV1A64HashAlgorithm.HashString(fs.Font.DepotPath.ToString());
                            var fontFile = File.GetFileFromDepotPath(fontHash);
                            if (fontFile == null || fontFile.RootChunk is not rendFont rf)
                            {
                                continue;
                            }

                            PrivateFontCollection pfc = new();
                            var fontBytes = rf.FontBuffer.Buffer.GetBytes();
                            var ptrData = Marshal.AllocCoTaskMem(fontBytes.Length);
                            Marshal.Copy(fontBytes, 0, ptrData, fontBytes.Length);
                            pfc.AddMemoryFont(ptrData, fontBytes.Length);
                            Marshal.FreeCoTaskMem(ptrData);

                            Application.Current.Resources.Add(key, pfc);
                        }
                    }
                }
                else if (Path.GetExtension(itemPath) == ".inkstyle")
                {
                    var styleHash = FNV1A64HashAlgorithm.HashString(itemPath);
                    var styleFile = File.GetFileFromDepotPath(styleHash);

                    if (styleFile == null || styleFile.RootChunk is not inkStyleResource sr)
                    {
                        continue;
                    }

                    Themes.Add("Default");
                    CurrentTheme = "Default";

                    foreach (var style in sr.Styles)
                    {
                        if (!StyleStates.Contains(style.State))
                        {
                            StyleStates.Add(style.State);
                        }

                        foreach (var prop in style.Properties)
                        {
                            var key = "CVariant/Default/" + prop.PropertyPath + "#" + style.State;
                            if (!Application.Current.Resources.Contains(key))
                            {
                                Application.Current.Resources.Add(key, prop.Value);
                            }
                        }
                    }

                    if (StyleStates.Count > 0)
                    {
                        CurrentStyleState = StyleStates[0];
                    }

                    foreach (var theme in sr.Themes)
                    {
                        var themeHash = FNV1A64HashAlgorithm.HashString(theme.StyleResource.DepotPath.ToString());
                        var themeFile = File.GetFileFromDepotPath(themeHash);
                        if (themeFile == null || themeFile.RootChunk is not inkStyleResource isr)
                        {
                            continue;
                        }

                        foreach (var style in isr.Styles)
                        {
                            if (!StyleStates.Contains(style.State))
                            {
                                StyleStates.Add(style.State);
                            }

                            foreach (var prop in style.Properties)
                            {
                                var key = "CVariant/" + theme.ThemeID + "/" + prop.PropertyPath + "#" + style.State;
                                if (!Application.Current.Resources.Contains(key))
                                {
                                    Application.Current.Resources.Add(key, prop.Value);
                                }
                            }
                        }

                        if (!Themes.Contains(theme.ThemeID))
                        {
                            Themes.Add(theme.ThemeID);
                        }
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
