using System;
using System.ComponentModel;
using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.App.ViewModels.Tools;

public class ExportableItemViewModel : ImportExportItemViewModel
{
    public ExportableItemViewModel(string fileName) : base(fileName, DecideExportOptions(fileName)) =>
        Properties.PropertyChanged += delegate (object? sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(Properties));
        };

    /// <summary>
    /// Disable LOD filter based on file name. For example, we don't want to apply it for any kind of vehicle.
    /// Put into helper function for easier extension.
    /// </summary>
    private static bool GetLodFilterFromFileName(string fileName)
    {
        if (!(fileName.Contains(Path.DirectorySeparatorChar + "vehicles") ||
              fileName.Contains(Path.DirectorySeparatorChar + "cars")))
        {
            return true;
        }

        return false;
    }

    private static ExportArgs DecideExportOptions(string fileName)
    {
        var extension = Path.GetExtension(fileName).TrimStart('.');
        if (!Enum.TryParse(extension, out ECookedFileFormat fileFormat))
        {
            throw new ArgumentException("extension is not ECookedFileFormat", nameof(extension));
        }


        return fileFormat switch
        {
            ECookedFileFormat.opusinfo => new OpusExportArgs(),
            ECookedFileFormat.mesh => new MeshExportArgs() { LodFilter = GetLodFilterFromFileName(fileName) },
            ECookedFileFormat.w2mesh => new MeshExportArgs() { LodFilter = GetLodFilterFromFileName(fileName) },
            ECookedFileFormat.xbm => new XbmExportArgs(),
            ECookedFileFormat.wem => new WemExportArgs(),
            ECookedFileFormat.csv => new CommonExportArgs(),
            //ECookedFileFormat.json => new CommonExportArgs(),
            ECookedFileFormat.mlmask => new MlmaskExportArgs(),
            ECookedFileFormat.cubemap => new CommonExportArgs(),
            ECookedFileFormat.xcube => new CommonExportArgs(),
            ECookedFileFormat.envprobe => new CommonExportArgs(),
            ECookedFileFormat.texarray => new CommonExportArgs(),
            //ECookedFileFormat.ent => new EntityExportArgs(),
            ECookedFileFormat.fnt => new FntExportArgs(),
            ECookedFileFormat.morphtarget => new MorphTargetExportArgs(),
            //ECookedFileFormat.ent => new EntityExportArgs(),
            //ECookedFileFormat.app => new EntityExportArgs(),
            ECookedFileFormat.anims => new AnimationExportArgs(),
            ECookedFileFormat.inkatlas => new InkAtlasExportArgs(),
            ECookedFileFormat.physicalscene => new MeshExportArgs() { LodFilter = GetLodFilterFromFileName(fileName) },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
