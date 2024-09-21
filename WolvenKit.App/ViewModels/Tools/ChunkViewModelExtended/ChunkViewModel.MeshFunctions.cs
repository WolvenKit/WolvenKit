using System.Linq;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    public const string LocalMaterialBufferPath = "localMaterialBuffer.materials";
    public const string ExternalMaterialPath = "externalMaterials";
    public const string PreloadMaterialPath = "preloadLocalMaterials";
    public const string MaterialEntryDefinitionPath = "materialEntries";

    private ChunkViewModel? FindMaterialDefinition(bool isLocal, CName? name, int? index)
    {
        if ((name is null && index is null)
            || GetRootModel() is not { ResolvedData: CMesh cmesh } rootModel
            || rootModel.GetPropertyFromPath(MaterialEntryDefinitionPath) is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.FirstOrDefault(prop =>
            prop.ResolvedData is CMeshMaterialEntry entry
            && entry.IsLocalInstance == isLocal
            && (name == null || entry.Name == name)
            && (index == null || entry.Index == index));
    }

    private ChunkViewModel? FindLocalMaterial(int index)
    {
        if (GetRootModel() is not { ResolvedData: CMesh } rootModel)
        {
            return null;
        }

        if (rootModel.GetPropertyFromPath(LocalMaterialBufferPath) is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.ElementAtOrDefault(index);
    }

    private ChunkViewModel? FindExternalMaterial(int index)
    {
        if (GetRootModel() is not { ResolvedData: CMesh } rootModel)
        {
            return null;
        }

        if (rootModel.GetPropertyFromPath("externalMaterials") is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.ElementAtOrDefault(index);
    }
}