using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    public ChunkViewModel? FindMaterialDefinition(bool isLocal, CName? name, int? index)
    {
        if ((name is null && index is null)
            || GetRootModel() is not { ResolvedData: CMesh cmesh } rootModel
            || rootModel.FindPropertyNode("materialEntries") is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.FirstOrDefault(prop =>
            prop.ResolvedData is CMeshMaterialEntry entry
            && entry.IsLocalInstance == isLocal
            && (name == null || entry.Name == name)
            && (index == null || entry.Index == index));
    }

    public ChunkViewModel? FindLocalMaterial(int index)
    {
        if (GetRootModel() is not { ResolvedData: CMesh } rootModel)
        {
            return null;
        }

        if (rootModel.FindPropertyNode("localMaterialBuffer")?.FindPropertyNode("materials") is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.ElementAtOrDefault(index);
    }

    public ChunkViewModel? FindExternalMaterial(int index)
    {
        if (GetRootModel() is not { ResolvedData: CMesh } rootModel)
        {
            return null;
        }

        if (rootModel.FindPropertyNode("externalMaterials") is not ChunkViewModel entries)
        {
            return null;
        }

        return entries.TVProperties.ElementAtOrDefault(index);
    }
}