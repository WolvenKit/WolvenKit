using System;
using System.ComponentModel;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ReactiveObject, ISelectableViewModel
    {
        public ImportExportItemViewModel()
        {
            
        }


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
    }

    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideImportOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v =>
            {
                this.RaisePropertyChanged(nameof(Properties));
            });
        }

        private ImportArgs DecideImportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ERawFileFormat rawFileFormat);

            return rawFileFormat switch
            {
                ERawFileFormat.tga => new XbmImportArgs(),
                ERawFileFormat.dds => new XbmImportArgs(),
                ERawFileFormat.fbx => new CommonImportArgs(),
                ERawFileFormat.glb => new GltfImportArgs(),
                ERawFileFormat.gltf => new GltfImportArgs(),
                ERawFileFormat.ttf => new FntImportArgs(),
                ERawFileFormat.wav => new OpusImportArgs(),
                ERawFileFormat.bmp => new XbmImportArgs(),
                ERawFileFormat.jpg => new XbmImportArgs(),
                ERawFileFormat.png => new XbmImportArgs(),
                ERawFileFormat.tiff => new XbmImportArgs(),
                ERawFileFormat.masklist => new MlmaskImportArgs(),
                _ => new CommonImportArgs()
            };
        }
    }

    public class ConvertableItemViewModel : ImportExportItemViewModel
    {
        public ConvertableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideConverOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v =>
            {
                this.RaisePropertyChanged(nameof(Properties));
            });
        }

        private ConvertArgs DecideConverOptions(FileModel model)
        {
            return new CommonConvertArgs();

        }
    }

    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideExportOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v =>
            {
                this.RaisePropertyChanged(nameof(Properties));
            });
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
                ECookedFileFormat.envprobe => new CommonExportArgs(),
                ECookedFileFormat.texarray => new CommonExportArgs(),
                ECookedFileFormat.fnt => new FntExportArgs(),
                ECookedFileFormat.morphtarget => new MorphTargetExportArgs(),
                //ECookedFileFormat.ent => new EntityExportArgs(),
                //ECookedFileFormat.app => new EntityExportArgs(),
                ECookedFileFormat.anims => new AnimationExportArgs(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
