using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;
using System.Xml.Serialization;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Conversion;
using WolvenKit.Functionality.Other;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Types;
using Application = System.Windows.Application;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTWidgetViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public inkWidgetLibraryResource library;

        [Reactive] public Dictionary<object, inkTextWidget> TextWidgets { get; set; } = new();

        [Reactive] public List<string> StyleStates { get; set; } = new();

        [Reactive] public string CurrentStyleState { get; set; }

        [Reactive] public List<string> Themes { get; set; } = new();

        [Reactive] public string CurrentTheme { get; set; }

        [Reactive] public Color WidgetBackground { get; set; }

        [Reactive] public List<string> Bindings { get; set; } = new();

        [Reactive] public List<inkanimSequence> inkAnimations { get; set; } = new();

        [Reactive] public List<inkIEffect> inkEffects { get; set; } = new();

        public RDTWidgetViewModel(RedBaseClass data, RedDocumentViewModel file)
        {
            Header = "Widget Preview";
            File = file;
            _data = data;
            library = _data as inkWidgetLibraryResource;
        }

        public async Task LoadResources()
        {
            await Task.Run(async () =>
            {
                var tasks = new List<Task>
                {
                    LoadAnimations()
                };

                foreach (var f in library.ExternalDependenciesForInternalItems)
                {
                    var itemPath = (string)f.DepotPath;
                    if (Path.GetExtension(itemPath) == ".inkatlas")
                    {
                        tasks.Add(LoadInkAtlasAsync(itemPath));
                    }
                    else if (Path.GetExtension(itemPath) == ".inkfontfamily")
                    {
                        tasks.Add(LoadFont(itemPath));
                    }
                    else if (Path.GetExtension(itemPath) == ".inkstyle")
                    {
                        tasks.Add(LoadStyle(itemPath));
                    }
                }

                await Task.WhenAll(tasks);
            });
        }

        public Task LoadAnimations()
        {
            return Task.Run(() =>
            {
                inkAnimations = new();

                var animFile = File.GetFileFromDepotPath(library.AnimationLibraryResRef.DepotPath);

                if (animFile != null && animFile.RootChunk is inkanimAnimationLibraryResource alr)
                {
                    foreach (var seq in alr.Sequences)
                    {
                        inkAnimations.Add((inkanimSequence)seq.GetValue());
                    }
                }
            });
        }

        public Task LoadFont(string path)
        {
            return Task.Run(() =>
            {
                if (Application.Current.Resources.Contains(path))
                {
                    return;
                }

                Application.Current.Resources.Add(path, false);

                var ffFile = File.GetFileFromDepotPath(path);
                if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
                {
                    return;
                }

                foreach (var fs in ffr.FontStyles)
                {
                    var key = "FontCollection/" + path + "#" + fs.StyleName;
                    if (!Application.Current.Resources.Contains(key))
                    {
                        var fontFile = File.GetFileFromDepotPath(fs.Font.DepotPath);
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

                Application.Current.Resources[path] = true;
            });
        }

        public Task LoadStyle(string path)
        {
            return Task.Run(() =>
            {
                var styleFile = File.GetFileFromDepotPath(path);

                if (styleFile == null || styleFile.RootChunk is not inkStyleResource sr)
                {
                    return;
                }

                if (!Themes.Contains("Default"))
                {
                    Themes.Add("Default");
                }
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
                    var themeFile = File.GetFileFromDepotPath(theme.StyleResource.DepotPath);
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
            });
        }

        public async Task LoadInkAtlasAsync(string path)
        {
            if (Application.Current.Resources.Contains(path))
            {
                return;
            }

            Application.Current.Resources.Add(path, false);

            var atlasFile = File.GetFileFromDepotPath(path);
            if (atlasFile == null || atlasFile.RootChunk is not inkTextureAtlas atlas)
            {
                return;
            }

            if (atlas.Slots[0] == null)
            {
                return;
            }

            var xbmFile = File.GetFileFromDepotPath(atlas.Slots[0].Texture.DepotPath);
            if (xbmFile == null || xbmFile.RootChunk is not CBitmapTexture xbm)
            {
                return;
            }

            using var ddsstream = new MemoryStream();
            if (!ModTools.ConvertRedClassToDdsStream(xbm, ddsstream, out _, out var decompressedFormat))
            {
                return;
            }

            var qa = await ImageDecoder.RenderToBitmapImageDds(ddsstream, decompressedFormat);
            if (qa is null)
            {
                return;
            }

            var image = new TransformedBitmap(qa, new ScaleTransform(1, -1));

            foreach (var part in atlas.Slots[0].Parts)
            {
                var key = "ImageSource/" + path + "#" + part.PartName;
                if (!Application.Current.Resources.Contains(key))
                {
                    var Left = part.ClippingRectInUVCoords.Left * xbm.Width;
                    var Top = part.ClippingRectInUVCoords.Top * xbm.Height;
                    var Width = (part.ClippingRectInUVCoords.Right * xbm.Width) - Left;
                    var Height = (part.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
                    var partImage = new CroppedBitmap(image, new Int32Rect((int)Math.Round(Left), (int)Math.Round(Top), (int)Math.Round(Width), (int)Math.Round(Height)));
                    partImage.Freeze();

                    Application.Current.Resources.Add(key, partImage);
                }
            }

            foreach (var slice in atlas.Slots[0].Slices)
            {
                var key = "RectF/" + path + "#" + slice.PartName;
                if (!Application.Current.Resources.Contains(key))
                {
                    Application.Current.Resources.Add(key, slice.NineSliceScaleRect);
                }
            }

            Application.Current.Resources[path] = true;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public bool IsDragging { get; set; }

        public void ExportWidget(inkWidget widget)
        {
            Stream myStream;
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 2,
                FileName = widget.Name + ".xml",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    var dto = new inkWidgetSerializer(widget);
                    var x = new XmlSerializer(typeof(inkWidgetSerializer));

                    using var xmlWriter = XmlWriter.Create(myStream, new XmlWriterSettings { Indent = true });
                    x.Serialize(xmlWriter, dto);
                    //var json = JsonConvert.SerializeObject(dto, Formatting.Indented);

                    //if (string.IsNullOrEmpty(xml))
                    //{
                    //    throw new SerializationException();
                    //}

                    //myStream.Write(xml.ToCharArray().Select(c => (byte)c).ToArray());
                    //myStream.Close();
                }
            }
        }

    }
}
