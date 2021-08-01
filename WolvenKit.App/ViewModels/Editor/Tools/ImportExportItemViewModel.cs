using System;
using System.ComponentModel;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Editor
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ReactiveObject
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
    }

    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideImportOptions(model);
        }

        private ImportArgs DecideImportOptions(FileModel model)
        {
            _ = Enum.TryParse(model.GetExtension(), out ERawFileFormat rawFileFormat);

            return rawFileFormat switch
            {
                ERawFileFormat.tga => new XbmImportArgs(),
                ERawFileFormat.dds => new XbmImportArgs(),
                ERawFileFormat.fbx => new CommonImportArgs(),
                ERawFileFormat.glb => new MeshImportArgs(),
                ERawFileFormat.gltf => new MeshImportArgs(),
                ERawFileFormat.ttf => new FntImportArgs(),
                ERawFileFormat.wav => new OpusImportArgs(),
                ERawFileFormat.bmp => new XbmImportArgs(),
                ERawFileFormat.jpg => new XbmImportArgs(),
                ERawFileFormat.png => new XbmImportArgs(),
                ERawFileFormat.tiff => new XbmImportArgs(),
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
                ECookedFileFormat.mlmask => new CommonExportArgs(),
                ECookedFileFormat.cubemap => new CommonExportArgs(),
                ECookedFileFormat.envprobe => new CommonExportArgs(),
                ECookedFileFormat.texarray => new CommonExportArgs(),
                ECookedFileFormat.fnt => new FntExportArgs(),
                ECookedFileFormat.morphtarget => new MorphTargetExportArgs(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
