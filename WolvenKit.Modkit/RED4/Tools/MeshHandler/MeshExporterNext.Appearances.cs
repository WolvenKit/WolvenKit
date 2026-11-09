using System;
using System.Collections.Generic;
using WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshExporterNext
{
    private List<VariantsRootEntry>? _variants;

    private void StoreAppearancesLegacy()
    {

    }

    private void StoreAppearances()
    {
        _variants = new List<VariantsRootEntry>();
        foreach (var appearanceHandle in _fileWrapper.CMesh.Appearances)
        {
            if (appearanceHandle.Chunk is not { } appearance)
            {
                continue;
            }

            var entry = new VariantsRootEntry { Name = appearance.Name.GetResolvedText()! };
            foreach (var chunkMaterial in appearance.ChunkMaterials)
            {
                entry.Materials.Add(chunkMaterial.GetResolvedText()!);
            }
            _variants.Add(entry);
        }

        if (_variants.Count == 0)
        {
            // Add a default variant if none exist?
            throw new Exception();
        }

        _modelRoot.UseExtension<VariantsRootExtension>().Variants = _variants;
    }
}
