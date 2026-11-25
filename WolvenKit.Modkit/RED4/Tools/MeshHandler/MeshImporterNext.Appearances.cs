using System;
using WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshImporterNext
{
    public void LoadAppearancesLegacy()
    {
        if (_oldFileWrapper == null)
        {
            throw new Exception();
        }

        foreach (var appearance in _oldFileWrapper.CMesh.Appearances)
        {
            _fileWrapper.CMesh.Appearances.Add(appearance);
        }
    }

    public void LoadAppearances()
    {
        var variants = _modelRoot.GetExtension<VariantsRootExtension>();
        if (variants != null)
        {
            foreach (var entry in variants.Variants)
            {
                _fileWrapper.CMesh.Appearances.Add(new meshMeshAppearance { Name = entry.Name });
            }
        }
    }
}
