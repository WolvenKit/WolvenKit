using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public delegate void ChangeEventHandler(object sender, EventArgs e);

public partial class RDTInkTextureAtlasViewModel : RedDocumentTabViewModel
{
    private readonly inkTextureAtlas _atlas;
    private int _currentSlot = -1;

    [ObservableProperty] public bool _isLoaded;
    
    [ObservableProperty] private ImageSource? _image;

    [ObservableProperty] private ObservableCollection<InkTextureAtlasMapperViewModel> _overlayItems = new();

    [ObservableProperty] private object? _selectedItem;

    public RDTInkTextureAtlasViewModel(inkTextureAtlas atlas, RedDocumentViewModel file) 
        : base(file, "Part Mapping")
    {
        _atlas = atlas;

        RenderAtlas(0);
    }

    public override void Dispose()
    {

    }

    public event ChangeEventHandler? ChangeEvent;

    public List<string> GetUsedSlotNames()
    {
        var result = new List<string>();
        for (var i = 0; i < _atlas.Slots.Count; i++)
        {
            if (_atlas.Slots[i].Texture.DepotPath != ResourcePath.Empty)
            {
                result.Add($"Slot {i}");
            }
        }
        return result;
    }

    public void RenderAtlas(int index)
    {
        IsLoaded = false; 
        if (index is < 0 or > 2)
        {
            throw new IndexOutOfRangeException();
        }

        foreach (var overlayItem in OverlayItems)
        {
            overlayItem.PropertyChanged -= OnSlotPropertyChanged;
        }
        OverlayItems.Clear();

        _currentSlot = index;

        if (_atlas.Slots[index] is not { } slot || slot.Texture.DepotPath == ResourcePath.Empty)
        {
            IsLoaded = true; 
            return;
        }

        var texture = Parent.GetFileFromDepotPath(slot.Texture.DepotPath);
        if (texture is not { RootChunk: CBitmapTexture xbm })
        {
            IsLoaded = true; 
            return;
        }

        var redImage = RedImage.FromXBM(xbm);

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(redImage.GetPreview(true));
        bitmapImage.EndInit();

        Image = bitmapImage;

        var width = (float)xbm.Width;
        var height = (float)xbm.Height;

        Bitmap sourceBitmap;
        using (var outStream = new MemoryStream())
        {
            BitmapEncoder enc = new TiffBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(bitmapImage));
            enc.Save(outStream);
            sourceBitmap = new Bitmap(outStream);
        }

        var destBitmap = new Bitmap((int)Math.Round(width), (int)Math.Round(height), System.Drawing.Imaging.PixelFormat.Format64bppArgb);

        using (var gfx = Graphics.FromImage(destBitmap))
        {
            // this is doesn't account for premultiplied alpha, so the opacity mask is still needed
            var matrix = new ColorMatrix(new float[][]
            {
                [1, 0, 0, 0, 0], [0, 1, 0, 0, 0], [0, 0, 1, 0, 0], [0, 0, 0, 1, 0], [0, 0, 0, 0, 0],
            });
            //matrix.Matrix03 = 1F;
            //matrix.Matrix13 = TintColor.Alpha / 3F;
            //matrix.Matrix23 = TintColor.Alpha / 3F;
            //matrix.Matrix40 = TintColor.R / 255F;
            //matrix.Matrix41 = TintColor.G / 255F;
            //matrix.Matrix42 = TintColor.B / 255F;

            var attributes = new ImageAttributes();

            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            gfx.DrawImage(sourceBitmap, new Rectangle(0, 0, (int)width, (int)height), 0, 0, width, height, GraphicsUnit.Pixel, attributes);
        }

        sourceBitmap.Dispose();

        Image = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
            destBitmap.GetHbitmap(),
            IntPtr.Zero,
            Int32Rect.Empty,
            BitmapSizeOptions.FromEmptyOptions());

        foreach (var part in slot.Parts)
        {
            var slotViewModel = new InkTextureAtlasMapperViewModel(part, xbm, slot.Texture.DepotPath.GetResolvedText().NotNull(),
                Parent.RelativePath, (BitmapSource)Image);
            slotViewModel.PropertyChanged += OnSlotPropertyChanged;
            OverlayItems.Add(slotViewModel);
        }

        IsLoaded = true; 
    }

    private void OnSlotPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is not InkTextureAtlasMapperViewModel sVm || e.PropertyName != nameof(InkTextureAtlasMapperViewModel.PartName) ||
            _atlas.Slots.Count == 0)
        {
            return;
        }

        var atlasSlotIdx = Array.FindIndex<inkTextureAtlasMapper>(_atlas.Slots[_currentSlot].Parts.ToArray(), p => p.PartName == sVm.OriginalPartName);

        // Change the slot name for all names
        foreach (var slot in _atlas.Slots)
        {
            if (slot.Parts.Count > atlasSlotIdx && slot.Parts[atlasSlotIdx] is { } m)
            {
                m.PartName = sVm.PartName;
                sVm.OriginalPartName = sVm.PartName;
            }
        }

        ChangeEvent?.Invoke(this, EventArgs.Empty);
    }

    public partial class InkTextureAtlasMapperViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _partName;

        public string OriginalPartName;
        
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
image.SetAtlasResource(r""{AtlasPath.Replace("\\", @"\\")}"");
image.SetTexturePart(n""{PartName}"");";

        public InkTextureAtlasMapperViewModel(inkTextureAtlasMapper itam, CBitmapTexture xbm, string path, string atlasPath, BitmapSource image)
        {
            Itam = itam;
            _partName = itam.PartName.ToString().NotNull();
            OriginalPartName = _partName;
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
            catch (Exception)
            {
                // do nothing
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

            if (saveFileDialog1.FileName == "" || Image is not BitmapSource source)
            {
                return;
            }

            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(source));

            using var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            encoder.Save(fileStream);
        }

    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;
}
