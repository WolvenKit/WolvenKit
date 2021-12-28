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
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using WolvenKit.Functionality.Commands;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTInkTextureAtlasViewModel : RDTTextureViewModel
    {
        private inkTextureAtlas _atlas;

        public RDTInkTextureAtlasViewModel(inkTextureAtlas atlas, CBitmapTexture xbm, RedDocumentViewModel file) : base(xbm, file)
        {
            _atlas = atlas;
            Header = "Part Mapping";
            Width = xbm.Width;
            Height = xbm.Height;
            foreach (var part in atlas.Slots[0].Parts)
            {
                OverlayItems.Add(new InkTextureAtlasMapperViewModel(part, xbm, atlas.Slots[0].Texture.DepotPath.ToString(), file.FilePath, (BitmapSource)Image));
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
            [Reactive] public string AtlasPath { get; set; }
            [Reactive] public ImageSource Image { get; set; }
            [Browsable(false)]
            public inkTextureAtlasMapper Itam;
            [Browsable(false)]
            [Reactive] public double Left { get; set; }
            [Browsable(false)]
            [Reactive] public double Top { get; set; }
            [Browsable(false)]
            [Reactive] public string Name { get; set; }
            [Browsable(false)]
            [Reactive] public string RedscriptExample
            {
                get
                {
                    return $@"let image = new inkImage();
image.SetAtlasResource(r""{AtlasPath}"");
image.SetTexturePart(n""{PartName}"");";
                }
                set
                {

                }
            }

            public InkTextureAtlasMapperViewModel(inkTextureAtlasMapper itam, CBitmapTexture xbm, string path, string atlasPath, BitmapSource image)
            {
                Itam = itam;
                PartName = itam.PartName;
                DepotPath = path;
                AtlasPath = atlasPath;
                Left = Math.Round(itam.ClippingRectInUVCoords.Left * xbm.Width);
                Top = Math.Round(itam.ClippingRectInUVCoords.Top * xbm.Height);
                Width = Math.Round(itam.ClippingRectInUVCoords.Right * xbm.Width) - Left;
                Height = Math.Round(itam.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
                Name = $"{itam.PartName} ({(uint)Width}x{(uint)Height})";
                SaveImageCommand = new RelayCommand(ExecuteSaveImage, CanSaveImage);
                try
                {
                    Image = new CroppedBitmap(image, new Int32Rect((int)Left, (int)(xbm.Height - itam.ClippingRectInUVCoords.Bottom * xbm.Height), (int)Width, (int)Height));
                }
                catch
                {

                }
            }

            public ICommand SaveImageCommand { get; private set; }
            private bool CanSaveImage() => Image != null;
            private void ExecuteSaveImage()
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PNG Image|*.png";
                saveFileDialog1.Title = "Save an Image As";
                saveFileDialog1.FileName = PartName + ".png";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(Image as BitmapSource));

                    using (var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        encoder.Save(fileStream);
                    }
                }
            }

        }
    }
}
