using System;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Windows.Media.Imaging;
using DynamicData.Binding;
using ReactiveUI;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Tools
{
    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(string fileName)
        {
            BaseFile = fileName;
            Properties = DecideImportOptions();

            Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));

            Properties.WhenAnyPropertyChanged(nameof(XbmImportArgs.TextureGroup)).Subscribe(p =>
            {
                if (p is XbmImportArgs importArgs)
                {
                    // when manually changing texturegroup, recalculate values
                    // IsGamma, RawFormat, Compression, GenerateMipMaps, IsStreamable
                    var args = CommonFunctions.TextureSetupFromTextureGroup(importArgs.TextureGroup);
                    importArgs.IsGamma = args.IsGamma;
                    importArgs.RawFormat = args.RawFormat;
                    importArgs.Compression = args.Compression;
                    importArgs.GenerateMipMaps = args.GenerateMipMaps;
                    importArgs.IsStreamable = args.IsStreamable;
                }
            });
        }

        private ImportArgs DecideImportOptions()
        {
            _ = Enum.TryParse(Extension, out ERawFileFormat rawFileFormat);

            // get texturegroup from filename
            var xbmArgs = new XbmImportArgs();
            if (IsRawTexture(rawFileFormat))
            {
                // first get settings from game
                xbmArgs = LoadXbmSettingsFromGame();
                // if not, get defaults from filename
                xbmArgs ??= LoadXbmDefaultSettings();
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
                _ => new CommonImportArgs()
            };
        }

        public XbmImportArgs LoadXbmDefaultSettings()
        {
            XbmImportArgs xbmArgs;
            if (!Enum.TryParse(Extension, out ERawFileFormat rawFileFormat))
            {
                throw new ArgumentException();
            }

            // set default texturegroup from filename
            var texGroup = CommonFunctions.GetTextureGroupFromFileName(Path.GetFileNameWithoutExtension(FullName));

            // get settings from texgroup
            xbmArgs = CommonFunctions.TextureSetupFromTextureGroup(texGroup);

            // get the format again, cos CDPR
            // load and, if needed, decompress file
            var image = rawFileFormat switch
            {
                ERawFileFormat.dds => RedImage.LoadFromDDSFile(BaseFile),
                ERawFileFormat.tga => RedImage.LoadFromTGAFile(BaseFile),
                ERawFileFormat.bmp => RedImage.LoadFromBMPFile(BaseFile),
                ERawFileFormat.jpg => RedImage.LoadFromJPGFile(BaseFile),
                ERawFileFormat.png => RedImage.LoadFromPNGFile(BaseFile),
                ERawFileFormat.tiff => RedImage.LoadFromTIFFFile(BaseFile),
                _ => throw new ArgumentOutOfRangeException(),
            };
            var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);
            xbmArgs.RawFormat = rawFormat;
            xbmArgs.Compression = compression;   // todo if this is already set use the previous one
            return xbmArgs;
        }

        public XbmImportArgs LoadXbmSettingsFromGame()
        {
            if (!Enum.TryParse(Extension, out ERawFileFormat _))
            {
                throw new ArgumentException();
            }

            // first get the texturegroup from the vanilla file
            var archiveManager = Locator.Current.GetService<IArchiveManager>();
            var activeProject = Locator.Current.GetService<IProjectManager>().ActiveProject;
            var relPath = Path.ChangeExtension(FileModel.GetRelativeName(BaseFile, activeProject), "xbm");
            var hash = FNV1A64HashAlgorithm.HashString(relPath);
            var file = archiveManager.Lookup(hash);
            if (file.HasValue)
            {
                // file exists in vanilla
                using MemoryStream stream = new();
                file.Value.Extract(stream);
                var parser = Locator.Current.GetService<Red4ParserService>();
                if (parser != null && parser.TryReadRed4File(stream, out var cr2w))
                {
                    if (cr2w.RootChunk is CBitmapTexture bitmapTexture)
                    {
                        if (bitmapTexture.Setup is not { } setup || bitmapTexture.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
                        {
                            return null;
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

            return null;
        }

        private static bool IsRawTexture(ERawFileFormat fmt) => fmt is ERawFileFormat.tga or ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.dds or ERawFileFormat.tiff;
    }
}
