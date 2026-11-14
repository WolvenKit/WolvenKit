using System.Collections.Generic;
using System.Linq;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// The node tree of a sector: nodes in folders by type (Meshes, Instanced meshes, Foliage,
/// Entities, Lights...), each labelled with its index in the sector's nodes array, so a row
/// matches <c>nodes[...]</c> in the JSON and in the log. A sector stores its nodes in blocks by
/// type already; the folders follow the same split, and their check box hides a whole kind.
/// </summary>
public partial class RDTMeshViewModel
{
    /// <summary>Folder order in the tree.</summary>
    private static readonly string[] s_sectorNodeCategories =
    [
        "Meshes", "Instanced meshes", "Foliage", "Proxy meshes", "Decals", "Entities",
        "Lights", "Effects & sound", "Areas", "Collision", "Other",
    ];

    /// <summary>The folder a node type goes in.</summary>
    public static string SectorNodeCategory(string? type)
    {
        var t = type ?? "";
        if (t.Contains("Collision"))
        {
            return "Collision";
        }

        if (t.Contains("Foliage"))
        {
            return "Foliage";
        }

        if (t.Contains("Proxy"))
        {
            return "Proxy meshes";
        }

        if (t.Contains("Instanced"))
        {
            return "Instanced meshes";
        }

        if (t.Contains("Decal") || t.Contains("Sticker"))
        {
            return "Decals";
        }

        if (t.Contains("Light") && !t.Contains("Channel") || t.Contains("ReflectionProbe"))
        {
            return "Lights";
        }

        if (t.Contains("Area") || t.Contains("Volume") || t.Contains("GISpace") || t.Contains("Trigger"))
        {
            return "Areas";
        }

        if (t.Contains("Mesh") || t.Contains("Destruction") || t.Contains("Terrain") || t.Contains("Occluder"))
        {
            return "Meshes";
        }

        if (t.Contains("Entity") || t.Contains("Device") || t.Contains("Spawner") || t.Contains("Community"))
        {
            return "Entities";
        }

        if (t.Contains("Effect") || t.Contains("Particle") || t.Contains("Sound") || t.Contains("Audio"))
        {
            return "Effects & sound";
        }

        return "Other";
    }

    /// <summary>"#0264 {lc_wardobe_}8", or "#0264" for a node without a debug name.</summary>
    private static void LabelSectorNodes(List<Element3D> groups, worldStreamingSector data)
    {
        foreach (var group in groups)
        {
            // collision actors keep their own names (one node holds many of them)
            if (group is not MeshComponent mesh || mesh.Name?.StartsWith("collisionNode_") == true ||
                !int.TryParse(mesh.WorldNodeIndex, out var index) || index < 0 || index >= data.Nodes.Count)
            {
                continue;
            }

            var debugName = data.Nodes[index]?.Chunk?.DebugName.GetResolvedText();
            mesh.Text = string.IsNullOrEmpty(debugName) || debugName == "None"
                ? $"#{index:D4}"
                : $"#{index:D4} {debugName}";
        }
    }

    /// <summary>The sector's node groups in folders by type, nodes in index order.</summary>
    private static List<Element3D> GroupSectorNodesByType(List<Element3D> groups)
    {
        var byCategory = new Dictionary<string, List<Element3D>>();
        foreach (var group in groups)
        {
            var category = SectorNodeCategory((group as MeshComponent)?.WorldNodeType);
            if (!byCategory.TryGetValue(category, out var list))
            {
                byCategory[category] = list = [];
            }

            list.Add(group);
        }

        var folders = new List<Element3D>();
        foreach (var category in s_sectorNodeCategories)
        {
            if (!byCategory.TryGetValue(category, out var nodes))
            {
                continue;
            }

            var folder = new GroupModel3DExt
            {
                Name = "folder_" + new string(category.Where(char.IsLetter).ToArray()),
                Text = $"{category} ({nodes.Count})",
            };

            foreach (var node in nodes.OrderBy(n => int.TryParse((n as MeshComponent)?.WorldNodeIndex, out var i) ? i : int.MaxValue))
            {
                folder.Children.Add(node);
            }

            folders.Add(folder);
        }

        return folders;
    }
}
