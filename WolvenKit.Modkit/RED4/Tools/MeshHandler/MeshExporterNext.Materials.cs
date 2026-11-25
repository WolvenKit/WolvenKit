using System.Collections.Generic;
using SharpGLTF.Schema2;

namespace WolvenKit.Modkit.RED4.Tools.MeshHandler;

public partial class MeshExporterNext
{
    private Dictionary<string, Material>? _materials;

    private void StoreMaterialsLegacy()
    {

    }

    private void StoreMaterials()
    {
        _materials = new Dictionary<string, Material>();

        foreach (var materialEntry in _fileWrapper.CMesh.MaterialEntries)
        {
            var materialName = materialEntry.Name.GetResolvedText()!;

            var gMaterial = _modelRoot.CreateMaterial(materialName);

            _materials.Add(materialName, gMaterial);
        }
    }
}
