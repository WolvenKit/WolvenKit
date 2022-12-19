using System;
using System.IO;
using DynamicData.Binding;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Tools
{
    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(string fileName)
        {
            BaseFile = fileName;
            Properties = DecideImportOptions();

            Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));
        }

        private ImportArgs DecideImportOptions()
        {
            _ = Enum.TryParse(Extension, out ERawFileFormat rawFileFormat);

            // get texturegroup from filename
            var xbmArgs = new XbmImportArgs();
            if (IsRawTexture(rawFileFormat))
            {
                xbmArgs = LoadXbmDefaultSettings();
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

            var texGroup = CommonFunctions.GetTextureGroupFromFileName(Path.GetFileNameWithoutExtension(FullName));

            // get settings from texgroup
            xbmArgs = CommonFunctions.TextureSetupFromTextureGroup(texGroup);
            // get the format again, cos CDPR
            var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);
            xbmArgs.RawFormat = rawFormat;
            xbmArgs.Compression = compression;   // todo if this is already set use the previous one
            return xbmArgs;
        }

        private static bool IsRawTexture(ERawFileFormat fmt) => fmt is ERawFileFormat.tga or ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.dds or ERawFileFormat.tiff;
    }
}
