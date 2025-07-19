using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Tools;

public class ImportableItemViewModel : ImportExportItemViewModel
{
    public ImportableItemViewModel(string fileName, IArchiveManager archiveManager, IProjectManager projectManager,
        Red4ParserService parserService)
        : base(fileName, DecideImportOptions(fileName, archiveManager, projectManager, parserService)) =>
        Properties.PropertyChanged += delegate(object? _, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(Properties));

            if (args.PropertyName != nameof(XbmImportArgs.TextureGroup) || Properties is not XbmImportArgs importArgs)
            {
                return;
            }

            // when manually changing texture group, recalculate values
            // IsGamma, RawFormat, Compression, GenerateMipMaps, IsStreamable
            var propArgs = CommonFunctions.TextureSetupFromTextureGroup(importArgs.TextureGroup);
            importArgs.IsGamma = propArgs.IsGamma;
            importArgs.RawFormat = propArgs.RawFormat;
            importArgs.Compression = propArgs.Compression;
            importArgs.GenerateMipMaps = propArgs.GenerateMipMaps;
            importArgs.IsStreamable = propArgs.IsStreamable;
        };

    private static ImportArgs DecideImportOptions(string fileName, IArchiveManager archiveManager, IProjectManager projectManager, Red4ParserService parserService)
    {
        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ERawFileFormat rawFileFormat))
        {
            throw new ArgumentException("extension is not ERawFileFormat", nameof(fileName));
        }

        var formatFromFilename = ModTools.GltfImportAsFormatFromFileExt(fileName);

        return rawFileFormat switch
        {
            // xbm: try to guess texture format
            ERawFileFormat.tga
                or ERawFileFormat.bmp
                or ERawFileFormat.jpg
                or ERawFileFormat.png
                or ERawFileFormat.tiff
                or ERawFileFormat.dds
                or ERawFileFormat.cube
                => TryLoadXbmSettingsFromGame(fileName, archiveManager, projectManager, parserService,
                    out var args)
                    ? args
                    : LoadXbmDefaultSettings(fileName),

            // glb or gltf: use format we read from file name, fall back to mesh
            ERawFileFormat.glb
                or ERawFileFormat.gltf
                => new GltfImportArgs()
                {
                    ImportFormat = formatFromFilename ?? GltfImportAsFormat.Mesh,
                    // Mesh won't have an internal extension
                    ImportGarmentSupport = formatFromFilename is null or GltfImportAsFormat.MeshWithRig 
                },

            // common import
            ERawFileFormat.fbx
                or ERawFileFormat.csv => new CommonImportArgs(),

            // everything else
            ERawFileFormat.ttf => new FntImportArgs(),
            ERawFileFormat.wav => new OpusImportArgs(),
            ERawFileFormat.masklist => new MlmaskImportArgs(),
            ERawFileFormat.re => new ReImportArgs(),

            _ => throw new ArgumentOutOfRangeException(nameof(fileName), $"Couldn't import {nameof(rawFileFormat)}"),
        };
    }

    public static XbmImportArgs LoadXbmDefaultSettings(string fileName)
    {
        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ERawFileFormat _))
        {
            throw new ArgumentException("extension is not ERawFileFormat", nameof(fileName));
        }

        // set default texture group from filename
        var texGroup = CommonFunctions.GetTextureGroupFromFileName(Path.GetFileNameWithoutExtension(fileName));

        // get settings from texgroup
        var xbmArgs = CommonFunctions.TextureSetupFromTextureGroup(texGroup);

        // Set image compression for normal map
        Enums.ETextureCompression? imageCompression = null;
        if (texGroup is Enums.GpuWrapApieTextureGroup.TEXG_Generic_Normal)
        {
            imageCompression = Enums.ETextureCompression.TCM_Normalmap;
        }
        
        // get the format again, cos CDPR
        // load and, if needed, decompress file
        var image = RedImage.LoadFromFile(fileName);
        if (image == null)
        {
            return xbmArgs;
        }

        var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);

        xbmArgs.RawFormat = rawFormat;
        xbmArgs.Compression = imageCompression ?? compression;
        xbmArgs.PremultiplyAlpha =
            CommonFunctions.ShouldPremultiplyAlpha(Path.GetFileNameWithoutExtension(fileName));

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

        // first get the texture group from the vanilla file

        var relPath = Path.ChangeExtension(activeProject.GetRelativePath(fileName), "xbm");
        var hash = FNV1A64HashAlgorithm.HashString(relPath);
        var file = archiveManager.Lookup(hash);
        if (!file.HasValue)
        {
            return false;
        }

        // file exists in vanilla
        using MemoryStream stream = new();
        file.Value.Extract(stream);
        if (!parserService.TryReadRed4File(stream, out var cr2WFile) ||
            cr2WFile.RootChunk is not CBitmapTexture { Setup: STextureGroupSetup setup } bitmapTexture ||
            bitmapTexture.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
        {
            return false;
        }

        // Invalid enum value. Not sure where this is coming from, in the constructors everything is assigned correctly.
        if (setup.Group.ToString() == "0")
        {
            setup.Group = Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color;
        }

        args = new XbmImportArgs(setup, blob.Header.TextureInfo.MipCount > 1);
        args.PremultiplyAlpha = CheckForAlphaMask(fileName);
        return true;

    }

    private static bool CheckForAlphaMask(string fileName)
    {
        try
        {
            using var image = System.Drawing.Image.FromFile(fileName);
            return image.PixelFormat is System.Drawing.Imaging.PixelFormat.Format32bppArgb
                or System.Drawing.Imaging.PixelFormat.Format32bppPArgb
                or System.Drawing.Imaging.PixelFormat.Format64bppArgb or System.Drawing.Imaging.PixelFormat.Format64bppPArgb;
        }
        catch
        {
            return false;
        }
    }
}
