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
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.Common.Conversion;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Types;
using Application = System.Windows.Application;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTWidgetViewModel : RedDocumentTabViewModel
{
    public inkWidgetLibraryResource library;



    public RDTWidgetViewModel(inkWidgetLibraryResource data, RedDocumentViewModel file) : base(file, "Widget Preview") => library = data;

    [ObservableProperty] private Dictionary<object, inkTextWidget> _textWidgets = new();

    [ObservableProperty] private List<string> _styleStates = new();

    [ObservableProperty] private string? _currentStyleState;

    [ObservableProperty] private List<string> _themes = new();

    [ObservableProperty] private string? _currentTheme;

    [ObservableProperty] private Color _widgetBackground;

    [ObservableProperty] private List<string> _bindings = new();

    [ObservableProperty] private List<inkanimSequence> _inkAnimations = new();

    [ObservableProperty] private List<inkIEffect> _inkEffects = new();

    [ObservableProperty] private ImageSource? _image;

    [ObservableProperty] private object? _selectedItem;

    [ObservableProperty] private bool _isDragging;



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
            InkAnimations = new();

            var animFile = Parent.GetFileFromDepotPath(library.AnimationLibraryResRef.DepotPath);

            if (animFile != null && animFile.RootChunk is inkanimAnimationLibraryResource alr)
            {
                foreach (var seq in alr.Sequences)
                {
                    InkAnimations.Add((inkanimSequence)seq.GetValue());
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

            var ffFile = Parent.GetFileFromDepotPath(path);
            if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
            {
                return;
            }

            foreach (var fs in ffr.FontStyles)
            {
                var key = "FontCollection/" + path + "#" + fs.StyleName;
                if (!Application.Current.Resources.Contains(key))
                {
                    var fontFile = Parent.GetFileFromDepotPath(fs.Font.DepotPath);
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
            var styleFile = Parent.GetFileFromDepotPath(path);

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
                var themeFile = Parent.GetFileFromDepotPath(theme.StyleResource.DepotPath);
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

        var atlasFile = Parent.GetFileFromDepotPath(path);
        if (atlasFile == null || atlasFile.RootChunk is not inkTextureAtlas atlas)
        {
            return;
        }

        if (atlas.Slots[0] == null)
        {
            return;
        }

        var xbmFile = Parent.GetFileFromDepotPath(atlas.Slots[0].Texture.DepotPath);
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
                var Width = part.ClippingRectInUVCoords.Right * xbm.Width - Left;
                var Height = part.ClippingRectInUVCoords.Bottom * xbm.Height - Top;
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
