using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Discord.Rest;
using Microsoft.Win32;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTInkTextureAtlasViewModel : RDTTextureViewModel
{
    private readonly inkTextureAtlas _atlas;

    public RDTInkTextureAtlasViewModel(
        inkTextureAtlas atlas, 
        CBitmapTexture xbm, 
        RedDocumentViewModel file,
        
        ILoggerService loggerService,
        Red4ParserService parserService
        ) 
        : base(xbm, file, loggerService, parserService)
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

        if (_data is not CBitmapTexture xbm)
        {
            return;
        }
        if (Image is not BitmapSource source)
        {
            return;
        }

        Width = xbm.Width;
        Height = xbm.Height;

        Bitmap sourceBitmap;
        using (var outStream = new MemoryStream())
        {
            BitmapEncoder enc = new TiffBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(source));
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

        var slot = _atlas.Slots[0].NotNull();
        foreach (var part in slot.Parts)
        {
            ArgumentNullException.ThrowIfNull(part);
            OverlayItems.Add(new InkTextureAtlasMapperViewModel(part, xbm, slot.Texture.DepotPath.ToString().NotNull(), Parent.RelativePath, (BitmapSource)Image));
        }

    }

    [ObservableProperty] private ObservableCollection<InkTextureAtlasMapperViewModel> _overlayItems = new();

    [ObservableProperty] private float _width;

    [ObservableProperty] private float _height;

    public partial class InkTextureAtlasMapperViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _partName;
        
        [ObservableProperty]
        private string _depotPath;
        
        [ObservableProperty]
        private double _width;
        
        [ObservableProperty]
        private double _height;
        
        [ObservableProperty]
        private string _atlasPath;
        
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SaveImageCommand))]
        private ImageSource? _image;

        [Browsable(false)]
        public inkTextureAtlasMapper Itam;

        [Browsable(false)]
        [ObservableProperty]
        private double _left;

        [Browsable(false)]
        [ObservableProperty]
        private double _top;

        [Browsable(false)]
        [ObservableProperty]
        private string _name;

        // TODO
        [Browsable(false)]
        //[ObservableProperty] 
        public string RedscriptExample => $@"let image = new inkImage();
image.SetAtlasResource(r""{AtlasPath.Replace("\\", "\\\\")}"");
image.SetTexturePart(n""{PartName}"");";

        public InkTextureAtlasMapperViewModel(inkTextureAtlasMapper itam, CBitmapTexture xbm, string path, string atlasPath, BitmapSource image)
        {
            Itam = itam;
            _partName = itam.PartName.ToString().NotNull();
            _depotPath = path;
            _atlasPath = atlasPath;
            Left = Math.Round(itam.ClippingRectInUVCoords.Left * xbm.Width);
            Top = Math.Round(itam.ClippingRectInUVCoords.Top * xbm.Height);
            Width = Math.Round(itam.ClippingRectInUVCoords.Right * xbm.Width) - Left;
            Height = Math.Round(itam.ClippingRectInUVCoords.Bottom * xbm.Height) - Top;
            _name = $"{itam.PartName} ({(uint)Width}x{(uint)Height})";

            try
            {
                Image = new CroppedBitmap(image, new Int32Rect((int)Left, (int)Top, (int)Width, (int)Height));
            }
            catch
            {

            }
        }

        private bool CanSaveImage() => Image != null;

        [RelayCommand(CanExecute = nameof(CanSaveImage))]
        private void SaveImage()
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
