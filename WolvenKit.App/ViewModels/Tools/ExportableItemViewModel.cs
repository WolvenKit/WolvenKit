using System;
using System.IO;
using DynamicData.Binding;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.ViewModels.Tools
{
    public class ExportableItemViewModel : ImportExportItemViewModel
    {
        public ExportableItemViewModel(string fileName) : base(fileName, DecideExportOptions(Path.GetExtension(fileName).TrimStart('.'))) => Properties.WhenAnyPropertyChanged().Subscribe(v => this.RaisePropertyChanged(nameof(Properties)));

        private static ExportArgs DecideExportOptions(string extension)
        {
            if (!Enum.TryParse(extension, out ECookedFileFormat fileFormat))
            {
                throw new ArgumentException("extension is not ECookedFileFormat", nameof(extension));
            }

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
