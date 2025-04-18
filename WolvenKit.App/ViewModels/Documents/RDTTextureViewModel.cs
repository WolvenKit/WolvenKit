using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTTextureViewModel : RedDocumentTabViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly Red4ParserService _parserService;

    protected readonly RedBaseClass? _data;

    protected readonly RedImage? _redImage;
    
    public delegate void RenderDelegate();
    public RenderDelegate Render;

    public RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file,
        ILoggerService loggerService,
        Red4ParserService parserService) : base(file, "Texture Preview")
    {
        _loggerService = loggerService;
        _parserService = parserService;

        _data = data;

        switch (_data)
        {
            case CBitmapTexture:
            case CCubeTexture:
            {
                try
                {
                    _redImage = RedImage.FromRedClass(data);
                }
                catch (Exception)
                {
                    _loggerService.Error("Error while loading an image");
                }
                break;
            }
            default:
                throw new NotSupportedException();
        }

        Render = SetupImage;
    }

    [ObservableProperty] private ImageSource? _image;

    [ObservableProperty] private bool _isDragging;
    [ObservableProperty] public bool _isRendered;

    public override void OnSelected() => Render.Invoke();

    protected void SetupImage()
    {
        if (IsRendered || _redImage == null)
        {
            return;
        }

        var bitmapImage = new BitmapImage();
        bitmapImage.BeginInit();

        if (IsLut())
        {
            bitmapImage.StreamSource = new MemoryStream(_redImage.GetHaldPreview());
        }
        else
        {
            bitmapImage.StreamSource = new MemoryStream(_redImage.GetPreview(true));
        }

        bitmapImage.EndInit();

        Image = bitmapImage;
        IsRendered = true;
    }

    private bool IsLut() => 
        CanReplaceTexture() &&
        _data is CBitmapTexture bitmapTexture &&
        bitmapTexture.Setup.Group == GpuWrapApieTextureGroup.TEXG_Generic_LUT;

    [RelayCommand(CanExecute = nameof(IsLut))]
    private void SaveAsCube()
    {
        var saveFileDialog1 = new SaveFileDialog
        {
            Filter = "cube Image|*.cube",
            Title = "Save cube file",
            FileName = Path.GetFileNameWithoutExtension(FilePath) + ".cube"
        };
        saveFileDialog1.ShowDialog();

        if (saveFileDialog1.FileName != "" && _redImage is not null)
        {
            var lines = _redImage.GetLutCube();

            File.WriteAllText(saveFileDialog1.FileName, lines);
        }
    }

    [RelayCommand(CanExecute = nameof(IsLut))]
    private async Task LoadFromCube()
    {
        var dlg = new OpenFileDialog()
        {
            Filter = "cube files (*.cube)|*.cube|All files (*.*)|*.*",
        };

        if (dlg.ShowDialog().GetValueOrDefault())
        {
            var image = RedImage.CreateFromLutCube(await File.ReadAllLinesAsync(dlg.FileName));
            if (image == null)
            {
                _loggerService.Error($"\"{dlg.FileName}\" could not be loaded!");
                return;
            }

            await ReplaceXbmAsync(image);
        }
    }

    private bool CanReplaceTexture() => !Parent.IsReadOnly && _data is CBitmapTexture;

    [RelayCommand(CanExecute = nameof(CanReplaceTexture))]
    private async Task ReplaceTexture()
    {
        if (_data is not CBitmapTexture bitmap)
        {
            return;
        }

        var dlg = new OpenFileDialog()
        {
            Filter = "PNG files (*.png)|*.png|TGA files (*.tga)|*.tga|DDS files (*.dds)|*.dds|BMP files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|TIFF files (*.tiff)|*.tiff|All files (*.*)|*.*",
        };

        if (dlg.ShowDialog().GetValueOrDefault())
        {
            var image = RedImage.LoadFromFile(dlg.FileName);
            if (image == null)
            {
                _loggerService.Error($"\"{dlg.FileName}\" could not be loaded!");
                return;
            }

            await ReplaceXbmAsync(image);
        }
    }

    private async Task ReplaceXbmAsync(RedImage newImage)
    {
        if (_data is not CBitmapTexture bitmap)
        {
            return;
        }

        if (newImage.Metadata.Width % 2 != 0 || newImage.Metadata.Height % 2 != 0)
        {
            if (bitmap.Setup.Compression != ETextureCompression.TCM_None)
            {
                _loggerService.Error("Image dimension (width and/or height) is an odd number. To import regardless, set Compression to TCM_None at own risk.");
                return;
            }

            if (bitmap.Setup.Group != GpuWrapApieTextureGroup.TEXG_Generic_Data)
            {
                _loggerService.Warning("Image dimension (width and/or height) is an odd number. Texture might not work as expected.");
            }
        }

        var xbmImportArgs = new XbmImportArgs(bitmap.Setup);

        // import raw texture to xbm
        var newxbm = newImage.SaveToXBM(xbmImportArgs, true);

        // set properties in file
        var replaced = false;
        if (ReferenceEquals(Parent.Cr2wFile.RootChunk, _data))
        {
            Parent.Cr2wFile.RootChunk = newxbm;
            replaced = true;
        }
        else
        {
            foreach (var embeddedFile in Parent.Cr2wFile.EmbeddedFiles)
            {
                if (ReferenceEquals(embeddedFile.Content, _data))
                {
                    embeddedFile.Content = newxbm;
                    replaced = true;
                    break;
                }
            }
        }

        if (!replaced)
        {
            return;
        }

        // save file
        await Parent.Save(null);

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

    private bool OpenStream(Stream stream, string path, [NotNullWhen(true)] out CR2WFile? file)
    {
        using var reader = new BinaryReader(stream);

        if (!_parserService.TryReadRed4File(reader, out file))
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
