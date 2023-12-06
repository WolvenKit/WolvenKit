using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
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
                var itemPath = f.DepotPath.ToString().NotNull();
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
                    if (seq.NotNull().GetValue() is inkanimSequence inkanimSequence)
                    {
                        InkAnimations.Add(inkanimSequence);
                    }
                }
            }
        });
    }

    public Task LoadFont(string path)
    {
        return Task.Run(() =>
        {
            if (InkCache.Resources.Contains(path))
            {
                return;
            }

            InkCache.Resources.Add(path, false);

            var ffFile = Parent.GetFileFromDepotPath(path);
            if (ffFile == null || ffFile.RootChunk is not inkFontFamilyResource ffr)
            {
                return;
            }

            foreach (var fs in ffr.FontStyles)
            {
                var key = "FontCollection/" + path + "#" + fs.StyleName;
                if (!InkCache.Resources.Contains(key))
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

                    InkCache.Resources.Add(key, pfc);
                }
            }

            InkCache.Resources[path] = true;
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
                if (!StyleStates.Contains(style.State.ToString().NotNull()))
                {
                    StyleStates.Add(style.State.ToString().NotNull());
                }

                foreach (var prop in style.Properties)
                {
                    var key = "CVariant/Default/" + prop.PropertyPath + "#" + style.State;
                    if (!InkCache.Resources.Contains(key))
                    {
                        InkCache.Resources.Add(key, prop.Value);
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
                    if (!StyleStates.Contains(style.State.ToString().NotNull()))
                    {
                        StyleStates.Add(style.State.ToString().NotNull());
                    }

                    foreach (var prop in style.Properties)
                    {
                        var key = "CVariant/" + theme.ThemeID + "/" + prop.PropertyPath + "#" + style.State;
                        if (!InkCache.Resources.Contains(key))
                        {
                            InkCache.Resources.Add(key, prop.Value);
                        }
                    }
                }

                if (!Themes.Contains(theme.ThemeID.ToString().NotNull()))
                {
                    Themes.Add(theme.ThemeID.ToString().NotNull());
                }
            }
        });
    }

    public async Task LoadInkAtlasAsync(string path)
    {
        if (InkCache.Resources.Contains(path))
        {
            return;
        }

        InkCache.Resources.Add(path, false);

        var atlasFile = Parent.GetFileFromDepotPath(path);
        if (atlasFile == null || atlasFile.RootChunk is not inkTextureAtlas atlas)
        {
            return;
        }

        var slot = atlas.Slots[0];
        if (slot == null)
        {
            return;
        }

        var xbmFile = Parent.GetFileFromDepotPath(slot.Texture.DepotPath);
        if (xbmFile == null || xbmFile.RootChunk is not CBitmapTexture xbm)
        {
            return;
        }

        using var ddsstream = new MemoryStream();
        if (!ModTools.ConvertRedClassToDdsStream(xbm, ddsstream, out _, out var decompressedFormat, true))
        {
            return;
        }

        var image = RedImage.LoadFromDDSMemory(ddsstream.ToByteArray(), decompressedFormat);
        if (image == null)
        {
            return;
        }

        foreach (var part in slot.Parts)
        {
            var key = "ImageSource/" + path + "#" + part.PartName;
            if (!InkCache.Resources.Contains(key))
            {
                var x = Math.Round(part.ClippingRectInUVCoords.Left * image.Metadata.Width);
                var y = Math.Round(part.ClippingRectInUVCoords.Top * image.Metadata.Height);
                var width = Math.Round(part.ClippingRectInUVCoords.Right * image.Metadata.Width) - x;
                var height = Math.Round(part.ClippingRectInUVCoords.Bottom * image.Metadata.Height) - y;

                var partImage = await Task.Run(() => ImageDecoder.CreateBitmapImage(image.Crop((int)x, (int)y, (int)width, (int)height), false));

                InkCache.Resources.Add(key, partImage);
            }
        }

        foreach (var slice in slot.Slices)
        {
            var key = "RectF/" + path + "#" + slice.PartName;
            if (!InkCache.Resources.Contains(key))
            {
                InkCache.Resources.Add(key, slice.NineSliceScaleRect);
            }
        }

        InkCache.Resources[path] = true;
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
