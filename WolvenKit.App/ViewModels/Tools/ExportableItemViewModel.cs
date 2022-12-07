using System;
using System.IO;
using DynamicData.Binding;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Tools
{
    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(string model)
        {
            BaseFile = model;
            Properties = DecideExportOptions(model);

            Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));
        }

        private ExportArgs DecideExportOptions(string model)
        {
            _ = Enum.TryParse(Path.GetExtension(model).TrimStart('.'), out ECookedFileFormat fileFormat);

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
