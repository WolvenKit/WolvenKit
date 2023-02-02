using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Win32;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTTextureViewModel : RedDocumentTabViewModel
{
    protected readonly RedBaseClass? _data;

    protected readonly RedImage _redImage;

    public delegate void RenderDelegate();
    public RenderDelegate Render;
    public bool IsRendered;

    public RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file) : base(file, "Texture Preview")
    {

        _data = data;
        _redImage = RedImage.FromRedClass(data);

        Render = SetupImage;
    }

    public RDTTextureViewModel(Stream stream, RedDocumentViewModel file) : base(file, "Texture Preview")
    {

        var buffer = new byte[stream.Length];
        stream.Read(buffer, 0, buffer.Length);

        _redImage = RedImage.LoadFromDDSMemory(buffer);

        Render = SetupImage;
    }

    [ObservableProperty] private ImageSource? _image;

    [ObservableProperty] private object? _selectedItem;

    [ObservableProperty] private bool _isDragging;

    public override void OnSelected() => Render.Invoke();

    protected void SetupImage()
    {
        if (IsRendered)
        {
            return;
        }

        if (_redImage.Metadata.Format == DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM)
        {
            return;
        }

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();
        bitmapImage.StreamSource = new MemoryStream(_redImage.GetPreview());
        bitmapImage.EndInit();

        Image = bitmapImage;
        IsRendered = true;
    }

    public void UpdateFromImage()
    {
        if (_data is CBitmapTexture xbm && Image is not null)
        {
            xbm.Width = (uint)Image.Width;
            xbm.Height = (uint)Image.Height;
            if (Parent.GetMainFile() is RDTDataViewModel file)
            {
                file.Chunks[0].Properties.Where(x => x.Name is "Width" or "Height").ToList().ForEach(x => OnPropertyChanged("Data"));
            }
        }
    }

    public void ReplaceTexture()
    {
        if (Parent.Cr2wFile.RootChunk is not CBitmapTexture bitmap)
        {
            return;
        }

        var dlg = new OpenFileDialog()
        {
            Filter = "PNG files (*.png)|*.png|TGA files (*.tga)|*.tga|DDS files (*.dds)|*.dds|BMP files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|TIFF files (*.tiff)|*.tiff|All files (*.*)|*.*",
        };

        if (dlg.ShowDialog().GetValueOrDefault())
        {
            var ext = Path.GetExtension(dlg.FileName).ToUpperInvariant();

            RedImage image;
            switch (ext)
            {
                case ".JPG":
                case ".JPEG":
                case ".JPE":
                {
                    image = RedImage.LoadFromJPGFile(dlg.FileName);
                    break;
                }
                case ".PNG":
                {
                    image = RedImage.LoadFromPNGFile(dlg.FileName);
                    break;
                }
                case ".BMP":
                {
                    image = RedImage.LoadFromBMPFile(dlg.FileName);
                    break;
                }

                case ".TIF":
                case ".TIFF":
                {
                    image = RedImage.LoadFromTIFFFile(dlg.FileName);
                    break;
                }

                case ".DDS":
                {
                    image = RedImage.LoadFromDDSFile(dlg.FileName);
                    break;
                }

                case ".TGA":
                {
                    image = RedImage.LoadFromTGAFile(dlg.FileName);
                    break;
                }

                default:
                    throw new NotImplementedException();
            }

            var xbmImportArgs = new XbmImportArgs
            {
                RawFormat = Enum.Parse<ETextureRawFormat>(bitmap.Setup.RawFormat.ToString()),
                Compression = Enum.Parse<ETextureCompression>(bitmap.Setup.Compression.ToString()),
                GenerateMipMaps = bitmap.Setup.HasMipchain,
                IsGamma = bitmap.Setup.IsGamma,
                TextureGroup = bitmap.Setup.Group,
                //IsStreamable = bitmap.Setup.IsStreamable,
                //PlatformMipBiasPC = bitmap.Setup.PlatformMipBiasPC,
                //PlatformMipBiasConsole = bitmap.Setup.PlatformMipBiasConsole,
                //AllowTextureDowngrade = bitmap.Setup.AllowTextureDowngrade,
                //AlphaToCoverageThreshold = bitmap.Setup.AlphaToCoverageThreshold
            };

            // import raw texture to xbm
            var newxbm = image.SaveToXBM(xbmImportArgs);

            // set properties in file
            Parent.Cr2wFile.RootChunk = newxbm;
            // save file
            Parent.Save(null);

            // reload from itself
            Parent.TabItemViewModels.Clear();

            // TODO check this
            var path = Parent.FilePath;
            if (OpenFile(path, out var file))
            {
                Parent.Cr2wFile = file;
            }
            Parent.PopulateItems();

            Parent.SelectedIndex = 1;
        }
    }

    private bool OpenStream(Stream stream, string path, [NotNullWhen(true)] out CR2WFile? file)
    {
        using var reader = new BinaryReader(stream);

        if (!_parser.TryReadRed4File(reader, out file))
        {
            _loggerService.Error($"Failed to read cr2w file {path}");
            return false;
        }

        return true;
    }

    private bool OpenFile(string path, [NotNullWhen(true)] out CR2WFile? file)
    {
        file = null;
        try
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (OpenStream(stream, path, out file))
            {
                return true;
            }
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
        }

        return false;
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;



}
