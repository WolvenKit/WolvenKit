using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO.PreProcessor;

public class CMeshPreProcessor : IPreProcessor
{
    private readonly ILoggerService? _loggerService;

    public CMeshPreProcessor(ILoggerService? loggerService) => _loggerService = loggerService;

    public void Process(RedBaseClass cls)
    {
        if (_loggerService == null)
        {
            return;
        }

        var mesh = (CMesh)cls;

        var sumOfLocal = mesh.LocalMaterialInstances.Count + mesh.PreloadLocalMaterialInstances.Count;
        if (mesh.LocalMaterialBuffer is { Materials: { } })
        {
            sumOfLocal += mesh.LocalMaterialBuffer.Materials.Count;
        }
        var sumOfExternal = mesh.ExternalMaterials.Count + mesh.PreloadExternalMaterials.Count;

        var localIndexList = new List<ushort>();
        var externalIndexList = new List<ushort>();

        for (var i = 0; i < mesh.MaterialEntries.Count; i++)
        {
            var materialEntry = mesh.MaterialEntries[i];
            ArgumentNullException.ThrowIfNull(materialEntry);

            if (materialEntry.IsLocalInstance)
            {
                if (materialEntry.Index >= sumOfLocal)
                {
                    _loggerService.Warning($"MaterialEntries: Material entry {i} tries to access non existing local material");
                }

                localIndexList.Add(materialEntry.Index);
            }
            else
            {
                if (materialEntry.Index >= sumOfExternal)
                {
                    _loggerService.Warning($"MaterialEntries: Material entry {i} tries to access non existing external material");
                }

                externalIndexList.Add(materialEntry.Index);
            }
        }

        CheckList(localIndexList, "Local");
        CheckList(externalIndexList, "External");

        void CheckList(List<ushort> list, string listName)
        {
            if (list.Count > 0)
            {
                list.Sort();

                if (list[0] != 0)
                {
                    _loggerService.Warning($"MaterialEntries: {listName} material indices aren't starting with index 0!");
                }

                if (list.Select((i, j) => i - j).Distinct().Skip(1).Any())
                {
                    _loggerService.Warning($"MaterialEntries: {listName} material indices aren't consecutive!");
                }
            }
        }
    }
}