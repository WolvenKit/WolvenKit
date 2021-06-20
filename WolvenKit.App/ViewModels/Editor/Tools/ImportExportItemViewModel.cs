using System;
using System.ComponentModel;
using WolvenKit.Models.Arguments;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Models;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.ViewModels.Editor
{
    /// <summary>
    /// ImportExportItem ViewModel
    /// </summary>
    public abstract class ImportExportItemViewModel : ObservableObject
    {
        /// <summary>
        /// BaseFile "FileModel"
        /// </summary>
        protected FileModel BaseFile { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        public ImportExportArgs Properties { get; set; }

        public string ExportTaskIdentifier => Properties.ToString();

        public string Extension => BaseFile.GetExtension();
        public string FullName => BaseFile.FullName;
        public string Name => BaseFile.Name;

        public bool IsChecked { get; set; }

        public EExportState ExportState => BaseFile.IsImportable ? EExportState.Importable : EExportState.Exportable;
    }

    public class ImportableItemViewModel : ImportExportItemViewModel
    {
        public ImportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideImportOptions(model);

            Properties.PropertyChanged += PropertiesOnPropertyChanged;
        }

        private void PropertiesOnPropertyChanged(object sender, PropertyChangedEventArgs e) => RaisePropertyChanged(nameof(Properties));

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
                _ => new CommonImportArgs()
            };
        }
    }

    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(FileModel model)
        {
            BaseFile = model;
            Properties = DecideExportOptions(model);

            Properties.PropertyChanged += PropertiesOnPropertyChanged;
        }

        private void PropertiesOnPropertyChanged(object sender, PropertyChangedEventArgs e) => RaisePropertyChanged(nameof(Properties));

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
