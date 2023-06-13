using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
    public ImportableItemViewModel(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService) 
        : base(fileName, DecideImportOptions(fileName, archiveManager, projectManager, parserService))
    {

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
            if(TryLoadXbmSettingsFromGame(fileName, archiveManager, projectManager, parserService, out var args))
            {
                xbmArgs = args;
            }
            else
            {
                // if not, get defaults from filename
                xbmArgs = LoadXbmDefaultSettings(fileName);
            }
            
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
        var image = RedImage.LoadFromFile(fileName);
        if (image != null)
        {
            var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);
            xbmArgs.RawFormat = rawFormat;
            xbmArgs.Compression = compression;      // todo if this is already set use the previous one
            //xbmArgs.PremultiplyAlpha              // todo ???
        }

        return xbmArgs;
    }

    public static bool TryLoadXbmSettingsFromGame(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService, [NotNullWhen(true)] out XbmImportArgs? args )
    {
        args = null;
        var activeProject = projectManager.ActiveProject;
        if (activeProject == null)
        {
            return false;
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
                        return false;
                    }

                    args = new XbmImportArgs()
                    {
                        TextureGroup = setup.Group,
                        IsGamma = setup.IsGamma,
                        RawFormat = setup.RawFormat,
                        Compression = setup.Compression,
                        GenerateMipMaps = blob.Header.TextureInfo.MipCount > 1,
                        IsStreamable = setup.IsStreamable,
                    };
                    return true;
                }
            }
        }

        return false;
    }

    private static bool IsRawTexture(ERawFileFormat fmt) => fmt is ERawFileFormat.tga or ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.dds or ERawFileFormat.tiff;
}
