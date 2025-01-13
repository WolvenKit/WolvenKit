using System;
using System.Collections.Generic;
using System.Linq;
using HelixToolkit.SharpDX.Core;
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

    /// <summary>
    /// Resolves dynamic appearance names and -materials.
    /// Returns a dictionary of dynamic appearance names with all possible parameters. 
    /// </summary>
    /// <example><code>
    /// { "@neon", [ "red", "blue", "green" ] }
    /// </code></example>
    public Dictionary<string, List<string>> UnDynamifyAppearances()
    {
        Dictionary<string, List<string>> ret = [];

        if (ResolvedData is not CMesh mesh || GetPropertyChild("appearances") is not ChunkViewModel appearances)
        {
            return ret;
        }

        appearances.CalculatePropertiesRecursive();

        var meshAppearances = mesh.Appearances.Select(m => m.Chunk).OfType<meshMeshAppearance>().ToList();
        var appearancesWithMaterials = meshAppearances.Where(mA => mA.ChunkMaterials.Count > 0).ToList();

        // if only the first appearance has chunks defined, then the other materials will inherit from the first
        if (meshAppearances.Count > 1 && appearancesWithMaterials.Count == 1 &&
            meshAppearances.First() is meshMeshAppearance template &&
            template.Name.GetString() is string templateName)
        {
            var templateChunkMaterials = template.ChunkMaterials.Select(s => s.ToString() ?? "").ToList();
            foreach (var mA in meshAppearances)
            {
                mA.ChunkMaterials.Clear();

                // turn materialName@neon to neon_materialName
                foreach (var chunkMaterial in templateChunkMaterials.Select(chunk =>
                             chunk.Replace(templateName, mA.Name)))
                {
                    mA.ChunkMaterials.Add(chunkMaterial);
                }
            }
        }

        // now add the dynamic materials to the list
        foreach (var mA in meshAppearances)
        {
            var chunkMaterials = mA.ChunkMaterials
                .Select(cm => cm.GetString() ?? "")
                // resolve all dynamic materials, turn red@neon into neon_red
                .Select(mat =>
                {
                    if (!mat.Contains('@'))
                    {
                        return mat;
                    }

                    var nameParts = mat.Split('@');
                    if (nameParts.Length != 2)
                    {
                        return mat;
                    }

                    ret.TryAdd(nameParts[1], []);
                    var materialName = $"{nameParts[1]}_{nameParts[0]}";
                    ret.Get(nameParts[1]).Add(materialName);
                    return materialName;
                })
                .ToList();

            mA.ChunkMaterials.Clear();
            foreach (var mat in chunkMaterials)
            {
                mA.ChunkMaterials.Add(mat);
            }
        }

        if (ret.Count != 0)
        {
            appearances.RecalculateProperties();
            foreach (var child in appearances.TVProperties)
            {
                child.RecalculateProperties();
            }
        }

        return ret;
    }
}