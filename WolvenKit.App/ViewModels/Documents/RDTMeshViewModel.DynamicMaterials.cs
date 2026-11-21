using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// ArchiveXL dynamic materials: a chunk material "red@neon" uses the material entry "@neon" with
/// {material} = "red" in its paths (the base material and every resource it references; a leading
/// '*' marks such a path). Resolved with the helpers the material export and Un-Dynamify Materials use.
/// </summary>
public partial class RDTMeshViewModel
{
    /// <summary>The chunk materials of a mesh's appearances after ArchiveXL's template expansion, per mesh.</summary>
    private sealed class ExpandedChunkMaterials
    {
        public string Structure = string.Empty;
        public List<List<string>> Appearances = [];
    }

    private static readonly ConditionalWeakTable<CMesh, ExpandedChunkMaterials> s_expandedChunkMaterials = new();

    /// <summary>
    /// The chunk materials of the appearance at <paramref name="appearanceIndex"/>. An appearance
    /// without any gets them from its template as ArchiveXL does ("emissive_cyan@emissive" of the
    /// first appearance with materials, or of the one its first tag names, becomes
    /// "emissive_purple@emissive"), expanded on a copy: the document is not changed.
    /// </summary>
    private static IReadOnlyList<string> ChunkMaterialNames(CMesh mesh, int appearanceIndex)
    {
        if (appearanceIndex < 0 || appearanceIndex >= mesh.Appearances.Count ||
            mesh.Appearances[appearanceIndex]?.Chunk is not meshMeshAppearance appearance)
        {
            return [];
        }

        if (appearance.ChunkMaterials.Count > 0)
        {
            return appearance.ChunkMaterials.Select(c => c.GetResolvedText() ?? string.Empty).ToList();
        }

        var expanded = s_expandedChunkMaterials.GetValue(mesh, _ => new ExpandedChunkMaterials());
        lock (expanded)
        {
            var structure = MeshStructure(mesh, null, null);
            if (expanded.Structure != structure)
            {
                var copy = (CArray<CHandle<meshMeshAppearance>>)mesh.Appearances.DeepCopy();
                ArchiveXlHelper.ExpandAppearanceTemplate(copy);
                expanded.Appearances = copy
                    .Select(h => h?.Chunk?.ChunkMaterials.Select(c => c.GetResolvedText() ?? string.Empty).ToList() ?? [])
                    .ToList();
                expanded.Structure = structure;
            }

            return appearanceIndex < expanded.Appearances.Count ? expanded.Appearances[appearanceIndex] : [];
        }
    }

    /// <summary>The material of a chunk: its own entry, else the dynamic one it names, else an empty one.</summary>
    private Material ChunkMaterial(Dictionary<string, Material> materials, string chunkName, CMesh mesh, string? meshPath = null)
    {
        var name = GetUniqueMaterialName(chunkName, mesh, meshPath);
        if (materials.TryGetValue(name, out var material))
        {
            return material;
        }

        if (ResolveDynamicMaterial(name, chunkName, mesh) is { } dynamic)
        {
            materials[name] = dynamic;
            return dynamic;
        }

        return new Material(name);
    }

    private Material? ResolveDynamicMaterial(string name, string chunkName, CMesh mesh)
    {
        var parts = chunkName.Split('@');
        if (parts.Length != 2 || parts[0].Length == 0 || parts[1].Length == 0)
        {
            return null;
        }

        var (value, dynamicName) = (parts[0], "@" + parts[1]);
        if (mesh.MaterialEntries.FirstOrDefault(me => me.Name.GetResolvedText() == dynamicName) is not { } entry)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] {chunkName}: no material entry {dynamicName} for this dynamic material");
            return null;
        }

        CMaterialInstance? source;
        if (entry.IsLocalInstance)
        {
            source = GetLocalMaterialInstance(mesh, entry.Index);
        }
        else
        {
            // an external dynamic material: its .mi path holds {material}
            var path = MeshMaterialLists.GetExternalMaterialPath(mesh, entry.Index);
            var resolved = path == ResourcePath.Empty
                ? string.Empty
                : WolvenKit.Modkit.Resources.ArchiveXlHelper
                    .ResolvePotentiallyDynamicDepotPath(new CResourceAsyncReference<IMaterial>(path), value)
                    .DepotPath.GetResolvedText() ?? string.Empty;
            source = resolved.Length > 0 ? GetProjectOrDepotFile(resolved)?.RootChunk as CMaterialInstance : null;
            if (source == null && resolved.Length > 0)
            {
                WarnMissingFile("material", resolved, chunkName);
            }

            if (source != null)
            {
                return FromInstance(source);
            }

            return null;
        }

        if (source == null)
        {
            return null;
        }

        var instance = new CMaterialInstance
        {
            BaseMaterial = WolvenKit.Modkit.Resources.ArchiveXlHelper.ResolveBaseMaterial(source.BaseMaterial, value),
            EnableMask = source.EnableMask,
            ResourceVersion = source.ResourceVersion,
        };
        foreach (var pair in source.Values)
        {
            instance.Values.Add(new CKeyValuePair(pair.Key, ArchiveXlHelper.UnDynamifyResourceReference(pair.Value, value)));
        }

        return FromInstance(instance);

        Material FromInstance(CMaterialInstance inst)
        {
            var material = new Material(name) { Instance = inst };
            foreach (var pair in inst.Values)
            {
                material.Values[pair.Key.ToString() ?? string.Empty] = pair.Value;
            }

            return material;
        }
    }
}
