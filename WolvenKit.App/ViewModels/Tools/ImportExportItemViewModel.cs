using System;
using System.IO;
using DynamicData.Binding;
using HelixToolkit.SharpDX.Core.Model;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ReactiveObject, ISelectableViewModel
    {
        /// <summary>
        /// BaseFile "FileModel"
        /// </summary>
        protected FileModel BaseFile { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [Reactive] public ImportExportArgs Properties { get; set; }

        public string ExportTaskIdentifier => Properties.ToString();

        public string Extension => BaseFile.GetExtension();
        public string FullName => BaseFile.FullName;
        public string Name => BaseFile.Name;

        [Reactive] public bool IsChecked { get; set; }

        public EExportState ExportState => BaseFile.IsImportable ? EExportState.Importable : EExportState.Exportable;

        public FileModel GetBaseFile() => BaseFile;

        public IGameFile GetArchiveFile(string extension)
        {
            var archiveManager = Locator.Current.GetService<IArchiveManager>();
            if (archiveManager != null)
            {
                var hash = FNV1A64HashAlgorithm.HashString(Path.ChangeExtension(BaseFile.RelativePath, extension));

                var archiveFile = archiveManager.Lookup(hash);
                if (archiveFile.HasValue)
                {
                    return archiveFile.Value;
                }
            }

            return null;
        }

        public string GetModFile(string extension)
        {
            var projectManager = Locator.Current.GetService<IProjectManager>();
            if (projectManager is { ActiveProject: Cp77Project project })
            {
                var tmp = Path.ChangeExtension(BaseFile.RelativePath, extension);

                foreach (var modFile in project.ModFiles)
                {
                    if (modFile == tmp)
                    {
                        return Path.Combine(project.ModDirectory, modFile);
                    }
                }
            }

            return null;
        }
    }

    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideImportOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));
        }

        private ImportArgs DecideImportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ERawFileFormat rawFileFormat);

            // get texturegroup from filename
            var xbmArgs = new XbmImportArgs();
            if (IsRawTexture(rawFileFormat))
            {
                // load and, if needed, decompress file
                var image = rawFileFormat switch
                {
                    ERawFileFormat.dds => RedImage.LoadFromDDSFile(model.FullName),
                    ERawFileFormat.tga => RedImage.LoadFromTGAFile(model.FullName),
                    ERawFileFormat.bmp => RedImage.LoadFromBMPFile(model.FullName),
                    ERawFileFormat.jpg => RedImage.LoadFromJPGFile(model.FullName),
                    ERawFileFormat.png => RedImage.LoadFromPNGFile(model.FullName),
                    ERawFileFormat.tiff => RedImage.LoadFromTIFFFile(model.FullName),
                    _ => throw new ArgumentOutOfRangeException(),
                };

                var texGroup = CommonFunctions.GetTextureGroupFromFileName(Path.GetFileName(FullName));

                // get settings from texgroup
                xbmArgs = CommonFunctions.TextureSetupFromTextureGroup(texGroup);
                // get the format again, cos CDPR
                var (rawFormat, compression, _) = CommonFunctions.MapGpuToEngineTextureFormat(image.Metadata.Format);
                xbmArgs.RawFormat = rawFormat;
                xbmArgs.Compression = compression;   // todo if this is already set use the previous one
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



        private static bool IsRawTexture(ERawFileFormat fmt) => fmt is ERawFileFormat.tga or ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.dds or ERawFileFormat.tiff;
    }

    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideExportOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));
        }

        private ExportArgs DecideExportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ECookedFileFormat fileFormat);

            return fileFormat switch
            {
                ECookedFileFormat.opusinfo => new OpusExportArgs(),
                ECookedFileFormat.mesh => new MeshExportArgs(),
                ECookedFileFormat.xbm => new XbmExportArgs(),
                ECookedFileFormat.wem => new WemExportArgs(),
                ECookedFileFormat.csv => new CommonExportArgs(),
                //ECookedFileFormat.json => new CommonExportArgs(),
                ECookedFileFormat.mlmask => new MlmaskExportArgs(),
                ECookedFileFormat.cubemap => new CommonExportArgs(),
                ECookedFileFormat.xcube => new CommonExportArgs(),
                ECookedFileFormat.envprobe => new CommonExportArgs(),
                ECookedFileFormat.texarray => new CommonExportArgs(),
                ECookedFileFormat.ent => new EntityExportArgs(),
                ECookedFileFormat.fnt => new FntExportArgs(),
                ECookedFileFormat.morphtarget => new MorphTargetExportArgs(),
                //ECookedFileFormat.ent => new EntityExportArgs(),
                //ECookedFileFormat.app => new EntityExportArgs(),
                ECookedFileFormat.anims => new AnimationExportArgs(),
                ECookedFileFormat.inkatlas => new InkAtlasExportArgs(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
