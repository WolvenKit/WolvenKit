using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using Prism.Commands;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTInkTextureAtlasViewModel : RDTTextureViewModel
    {
        private readonly inkTextureAtlas _atlas;

        public RDTInkTextureAtlasViewModel(inkTextureAtlas atlas, CBitmapTexture xbm, RedDocumentViewModel file) : base(xbm, file)
        {
            _atlas = atlas;
            Header = "Part Mapping";

            Render = RenderAtlas;
        }

        public void RenderAtlas()
        {
            if (IsRendered)
            {
                return;
            }
            SetupImage();

            var xbm = (CBitmapTexture)_data;
            Width = xbm.Width;
            Height = xbm.Height;

            Bitmap sourceBitmap;
            using (var outStream = new MemoryStream())
            {
                BitmapEncoder enc = new TiffBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)Image));
                enc.Save(outStream);
                sourceBitmap = new Bitmap(outStream);
            }

            var destBitmap = new Bitmap((int)Math.Round(Width), (int)Math.Round(Height), System.Drawing.Imaging.PixelFormat.Format64bppArgb);

            using (var gfx = Graphics.FromImage(destBitmap))
            {
                // this is doesn't account for premultipied alpha, so the opacity mask is still needed
                var matrix = new ColorMatrix(new float[][]
                {
                        new float[] { 1, 0, 0, 0, 0},
                        new float[] { 0, 1, 0, 0, 0},
                        new float[] { 0, 0, 1, 0, 0},
                        new float[] { 0, 0, 0, 1, 0},
                        new float[] { 0, 0, 0, 0, 0},
                });
                //matrix.Matrix03 = 1F;
                //matrix.Matrix13 = TintColor.Alpha / 3F;
                //matrix.Matrix23 = TintColor.Alpha / 3F;
                //matrix.Matrix40 = TintColor.R / 255F;
                //matrix.Matrix41 = TintColor.G / 255F;
                //matrix.Matrix42 = TintColor.B / 255F;

                var attributes = new ImageAttributes();

                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(sourceBitmap, new Rectangle(0, 0, (int)Width, (int)Height), 0, 0, Width, Height, GraphicsUnit.Pixel, attributes);
            }

            sourceBitmap.Dispose();

            Image = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                destBitmap.GetHbitmap(),
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            foreach (var part in _atlas.Slots[0].Parts)
            {
                OverlayItems.Add(new InkTextureAtlasMapperViewModel(part, xbm, _atlas.Slots[0].Texture.DepotPath.ToString(), File.RelativePath, (BitmapSource)Image));
            }

        }

        [Reactive] public ObservableCollection<InkTextureAtlasMapperViewModel> OverlayItems { get; set; } = new();

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
            [Reactive]
            public string RedscriptExample
            {
                get => $@"let image = new inkImage();
image.SetAtlasResource(r""{AtlasPath}"");
image.SetTexturePart(n""{PartName}"");";
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
                SaveImageCommand = new DelegateCommand(ExecuteSaveImage, CanSaveImage);
                try
                {
                    Image = new CroppedBitmap(image, new Int32Rect((int)Left, (int)Top, (int)Width, (int)Height));
                }
                catch
                {

                }
            }

            [Browsable(false)]
            public ICommand SaveImageCommand { get; private set; }
            private bool CanSaveImage() => Image != null;
            private void ExecuteSaveImage()
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Save an Image As",
                    FileName = PartName + ".png"
                };
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(Image as BitmapSource));

                    using var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    encoder.Save(fileStream);
                }
            }

        }
    }
}
