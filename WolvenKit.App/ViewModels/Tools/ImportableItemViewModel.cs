using System;
using System.ComponentModel;
using System.IO;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools;

public class ImportableItemViewModel : ImportExportItemViewModel
{
    private readonly IArchiveManager _archiveManager;
    private readonly IProjectManager _projectManager;
    private readonly Red4ParserService _parserService;

    public ImportableItemViewModel(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService) 
        : base(fileName, DecideImportOptions(fileName, archiveManager, projectManager, parserService))
    {
        _archiveManager = archiveManager;
        _projectManager = projectManager;
        _parserService = parserService;
        Properties.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(Properties));

            if (args.PropertyName == nameof(XbmImportArgs.TextureGroup))
            {
                if (Properties is XbmImportArgs importArgs)
                {
                    // when manually changing texturegroup, recalculate values
                    // IsGamma, RawFormat, Compression, GenerateMipMaps, IsStreamable
                    var propArgs = CommonFunctions.TextureSetupFromTextureGroup(importArgs.TextureGroup);
                    importArgs.IsGamma = propArgs.IsGamma;
                    importArgs.RawFormat = propArgs.RawFormat;
                    importArgs.Compression = propArgs.Compression;
                    importArgs.GenerateMipMaps = propArgs.GenerateMipMaps;
                    importArgs.IsStreamable = propArgs.IsStreamable;
                }
            }
        };
    }

    private static ImportArgs DecideImportOptions(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService)
    {
        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ERawFileFormat rawFileFormat))
        {
            throw new ArgumentException("extension is not ERawFileFormat", nameof(fileName));
        }

        // get texturegroup from filename
        var xbmArgs = new XbmImportArgs();
        if (IsRawTexture(rawFileFormat))
        {
            // first get settings from game
            xbmArgs = LoadXbmSettingsFromGame(fileName, archiveManager, projectManager, parserService);
            // if not, get defaults from filename
            xbmArgs ??= LoadXbmDefaultSettings(fileName);
        }

        return rawFileFormat switch
        {
            ERawFileFormat.tga => xbmArgs,
            ERawFileFormat.bmp => xbmArgs,
            ERawFileFormat.jpg => xbmArgs,
            ERawFileFormat.png => xbmArgs,
            ERawFileFormat.tiff => xbmArgs,
            ERawFileFormat.dds => xbmArgs,

            ERawFileFormat.glb => new GltfImportArgs(),
            ERawFileFormat.gltf => new GltfImportArgs(),

            ERawFileFormat.ttf => new FntImportArgs(),
            ERawFileFormat.wav => new OpusImportArgs(),
            ERawFileFormat.masklist => new MlmaskImportArgs(),
            ERawFileFormat.re => new ReImportArgs(),

            ERawFileFormat.fbx => new CommonImportArgs(),
            ERawFileFormat.csv => new CommonImportArgs(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public static XbmImportArgs LoadXbmDefaultSettings(string fileName)
    {
        XbmImportArgs xbmArgs;

        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ERawFileFormat rawFileFormat))
        {
            throw new ArgumentException("extension is not ERawFileFormat", nameof(fileName));
        }

        // set default texturegroup from filename
        var texGroup = CommonFunctions.GetTextureGroupFromFileName(Path.GetFileNameWithoutExtension(fileName));

        // get settings from texgroup
        xbmArgs = CommonFunctions.TextureSetupFromTextureGroup(texGroup);

        // get the format again, cos CDPR
        // load and, if needed, decompress file
        var image = rawFileFormat switch
        {
            ERawFileFormat.dds => RedImage.LoadFromDDSFile(fileName),
            ERawFileFormat.tga => RedImage.LoadFromTGAFile(fileName),
            ERawFileFormat.bmp => RedImage.LoadFromBMPFile(fileName),
            ERawFileFormat.jpg => RedImage.LoadFromJPGFile(fileName),
            ERawFileFormat.png => RedImage.LoadFromPNGFile(fileName),
            ERawFileFormat.tiff => RedImage.LoadFromTIFFFile(fileName),
            ERawFileFormat.fbx => throw new NotImplementedException(),
            ERawFileFormat.gltf => throw new NotImplementedException(),
            ERawFileFormat.glb => throw new NotImplementedException(),
            ERawFileFormat.ttf => throw new NotImplementedException(),
            ERawFileFormat.wav => throw new NotImplementedException(),
            ERawFileFormat.masklist => throw new NotImplementedException(),
            ERawFileFormat.csv => throw new NotImplementedException(),
            ERawFileFormat.re => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException(),
        };
        var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);
        xbmArgs.RawFormat = rawFormat;
        xbmArgs.Compression = compression;   // todo if this is already set use the previous one
        return xbmArgs;
    }

    public static XbmImportArgs LoadXbmSettingsFromGame(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService)
    {
        var activeProject = projectManager.ActiveProject;
        if (activeProject == null)
        {
            return new XbmImportArgs();
        }

        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ERawFileFormat _))
        {
            throw new ArgumentException("extension is not ERawFileFormat", nameof(fileName));
        }

        // first get the texturegroup from the vanilla file

        var relPath = Path.ChangeExtension(FileModel.GetRelativeName(fileName, activeProject), "xbm");
        var hash = FNV1A64HashAlgorithm.HashString(relPath);
        var file = archiveManager.Lookup(hash);
        if (file.HasValue)
        {
            // file exists in vanilla
            using MemoryStream stream = new();
            file.Value.Extract(stream);
            if (parserService.TryReadRed4File(stream, out var cr2w))
            {
                if (cr2w.RootChunk is CBitmapTexture bitmapTexture)
                {
                    if (bitmapTexture.Setup is not { } setup || bitmapTexture.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
                    {
                        return new XbmImportArgs();
                    }

                    return new XbmImportArgs()
                    {
                        TextureGroup = setup.Group,
                        IsGamma = setup.IsGamma,
                        RawFormat = setup.RawFormat,
                        Compression = setup.Compression,
                        GenerateMipMaps = blob.Header.TextureInfo.MipCount > 1,
                        IsStreamable = setup.IsStreamable,
                    };
                }
            }
        }

        return new XbmImportArgs();
    }

    private static bool IsRawTexture(ERawFileFormat fmt) => fmt is ERawFileFormat.tga or ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.dds or ERawFileFormat.tiff;
}
