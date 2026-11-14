using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

/// <summary>
/// The material lists of a mesh, in one place: a mesh keeps its materials either in the preload lists
/// (preloadLocalMaterialInstances / preloadExternalMaterials) or in the others (localMaterialBuffer /
/// externalMaterials), and a material entry's index points into the lists in use.
/// </summary>
public static class MeshMaterialLists
{
    public static bool HasPreloadMaterials(CMesh mesh) =>
        mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0;

    public static List<IMaterial> GetLocalMaterials(CMesh mesh)
    {
        if (HasPreloadMaterials(mesh))
        {
            return mesh.PreloadLocalMaterialInstances.Select(r => r.Chunk).OfType<IMaterial>().ToList();
        }

        return mesh.LocalMaterialBuffer.Materials.ToList();
    }

    public static List<IRedRef> GetExternalMaterials(CMesh mesh)
    {
        if (HasPreloadMaterials(mesh))
        {
            return mesh.PreloadExternalMaterials.Cast<IRedRef>().ToList();
        }

        return mesh.ExternalMaterials.Cast<IRedRef>().ToList();
    }

    /// <summary>
    /// The local material at an entry's index, or null. A mesh read from an archive (not opened in an editor)
    /// keeps its non-preload local materials unread in the buffer's raw data: they are taken from there.
    /// </summary>
    public static IMaterial? GetLocalMaterial(CMesh mesh, int index)
    {
        if (index < 0)
        {
            return null;
        }

        var materials = GetLocalMaterials(mesh);
        if (index < materials.Count)
        {
            return materials[index];
        }

        if (!HasPreloadMaterials(mesh) && mesh.LocalMaterialBuffer.RawData?.Buffer.Data is CR2WList raw &&
            index < raw.Files.Count)
        {
            return raw.Files[index].RootChunk as IMaterial;
        }

        return null;
    }

    /// <summary>The path of the external material at an entry's index, or an empty path.</summary>
    public static ResourcePath GetExternalMaterialPath(CMesh mesh, int index)
    {
        var materials = GetExternalMaterials(mesh);
        return index >= 0 && index < materials.Count ? materials[index].DepotPath : ResourcePath.Empty;
    }
}
