using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.App.Helpers;

/// <summary>What the elements of an object are, for an .xl removal of single ones.</summary>
public enum SectorElementKind
{
    None,

    /// <summary>Copies of an instanced mesh (instanceDeletions / expectedInstances).</summary>
    Instance,

    /// <summary>Collision actors (actorDeletions / expectedActors).</summary>
    Actor,
}

/// <summary>One instance or collision actor of an object, ticked to be removed on its own.</summary>
public sealed partial class SectorObjectElement : ObservableObject
{
    public required int Index { get; init; }

    /// <summary>"instance 2 at -780.1, 985.6, 12.2", "actor 3".</summary>
    public required string Text { get; init; }

    [ObservableProperty] private bool _isChecked;
}

/// <summary>
/// One object of a sector: one nodeData entry, with the node (and, for cooked nodes, the inner node) it places.
/// </summary>
public sealed class SectorObject
{
    /// <summary>Index in nodeData.</summary>
    public required int NodeDataIndex { get; init; }

    /// <summary>Index in nodes.</summary>
    public required int NodeIndex { get; init; }

    /// <summary>Inner node of a cooked node (its instanceIndex), -1 for other nodes.</summary>
    public required int InnerIndex { get; init; }

    /// <summary>The node's class, as .xl files and ArchiveXL name it.</summary>
    public required string ClassName { get; init; }

    /// <summary>The kind of object, the same for a cooked class and the class it replaces ("Static mesh").</summary>
    public required string Group { get; init; }

    /// <summary>RedHotTools' target group of the class (Mesh, Collision, Area...).</summary>
    public string TargetGroup { get; init; } = SectorTargetGroups.Other;

    /// <summary>Instances or actors that an .xl removal can remove one by one; none for other objects.</summary>
    public SectorElementKind ElementKind { get; init; }

    public IReadOnlyList<SectorObjectElement> Elements { get; init; } = [];

    public bool HasElements => Elements.Count > 0;

    /// <summary>What a checked .xl does with this object ("removed", or the problem ArchiveXL would report); null if nothing.</summary>
    public string? XlMark { get; set; }

    /// <summary>The checked .xl means this object but doesn't match it any more.</summary>
    public bool XlProblem { get; set; }

    /// <summary>File name of the object's resource, else its debug name, else its kind.</summary>
    public required string Name { get; init; }

    public string? Resource { get; init; }

    public string? Appearance { get; init; }

    /// <summary>"12 instances", "8 actors"...</summary>
    public string? Detail { get; init; }

    /// <summary>Node range (variantIndices) the entry is in.</summary>
    public required int Variant { get; init; }

    public required string VariantName { get; init; }

    /// <summary>Order of the node ranges: the persistent one first, then the variants.</summary>
    public int VariantOrder => VariantName == "Persistent" ? -1 : Variant;

    /// <summary>The node isn't visible in game (isVisibleInGame = false).</summary>
    public bool IsHidden { get; init; }

    public bool IsCooked { get; init; }

    public ENodeFlags Flags { get; init; }

    /// <summary>"Building, No collision": the flags that tell what an object is.</summary>
    public string Categories { get; init; } = "";

    /// <summary>How many entries place the same node (or inner node): 1 for most.</summary>
    public int SharedCount { get; set; } = 1;

    public string? DebugName { get; init; }

    public float X { get; init; }

    public float Y { get; init; }

    public float Z { get; init; }

    /// <summary>The nodeData entry's own transform, which an .xl mutation sets (for instanced meshes, the origin of their instances).</summary>
    public (float X, float Y, float Z) EntryPosition { get; init; }

    /// <summary>The entry's rotation as i, j, k, r.</summary>
    public (float I, float J, float K, float R) EntryOrientation { get; init; } = (0, 0, 0, 1);

    public (float X, float Y, float Z) EntryScale { get; init; } = (1, 1, 1);

    /// <summary>"#157 · node 1057[12]"</summary>
    public string Where => InnerIndex >= 0
        ? $"#{NodeDataIndex} · node {NodeIndex}[{InnerIndex}]"
        : $"#{NodeDataIndex} · node {NodeIndex}";

    public string Position => string.Format(CultureInfo.InvariantCulture, "{0:0.##}, {1:0.##}, {2:0.##}", X, Y, Z);

    public string SharedText => SharedCount > 1 ? $"×{SharedCount}" : "";

    public string HiddenText => IsHidden ? "hidden" : "";

    /// <summary>
    /// What a removal in an .xl file needs: the class, the indices and where the object is. The indices are named as
    /// RedHotTools' world inspector names them: Node Instance (nodeData entry, the index of an .xl removal), Node
    /// Definition (nodes) and Cooked Instance (the inner node of a cooked node).
    /// </summary>
    public string Summary
    {
        get
        {
            var text = new StringBuilder();
            text.Append(CultureInfo.InvariantCulture, $"{ClassName} · Node Instance {NodeDataIndex} · Node Definition {NodeIndex}");
            if (InnerIndex >= 0)
            {
                text.Append(CultureInfo.InvariantCulture, $" · Cooked Instance {InnerIndex}");
            }

            text.Append(CultureInfo.InvariantCulture, $" · {VariantName} ·");
            if (Resource is { Length: > 0 })
            {
                text.Append(CultureInfo.InvariantCulture, $" {Resource}");
            }

            if (Appearance is { Length: > 0 })
            {
                text.Append(CultureInfo.InvariantCulture, $" [{Appearance}]");
            }

            text.Append(CultureInfo.InvariantCulture, $" at {Position}");
            return text.ToString();
        }
    }
}

/// <summary>
/// The objects of a sector, one per nodeData entry. Since game 2.5 most objects of a sector are grouped by type into
/// cooked nodes (worldCookedStaticMeshNode, worldCookedStaticDecalNode, worldCookedCollisionNode...), whose inner
/// nodes each entry picks with its instanceIndex; this lists them again one by one, as the nodes did before.
/// </summary>
public static class SectorObjectList
{
    private const uint NoInstance = uint.MaxValue;

    /// <summary>Flags shown as categories, in this order.</summary>
    private static readonly (ENodeFlags Flag, string Name)[] s_categoryFlags =
    [
        (ENodeFlags.FLAG_Building, "Building"),
        (ENodeFlags.FLAG_Decoration, "Decoration"),
        (ENodeFlags.FLAG_Road, "Road"),
        (ENodeFlags.FLAG_Terrain, "Terrain"),
        (ENodeFlags.FLAG_VisualFluff, "Fluff"),
        (ENodeFlags.FLAG_Quest, "Quest"),
        (ENodeFlags.FLAG_IsInterior, "Interior"),
        (ENodeFlags.FLAG_NoCollision, "No collision"),
    ];

    /// <summary>The category names, for a filter.</summary>
    public static IReadOnlyList<string> CategoryNames { get; } = s_categoryFlags.Select(c => c.Name).ToList();

    /// <summary>Resource properties of nodes, most telling first; other references are used if none is set.</summary>
    private static readonly string[] s_resourceProperties =
    [
        "mesh", "entityTemplate", "material", "particleSystem", "effect", "foliageResource", "audioName", "data",
    ];

    private static readonly string[] s_innerResourceProperties = ["Mesh", "Material", "Data"];

    private static readonly string[] s_classPrefixes = ["worldCooked", "world", "game"];

    private static readonly string[] s_classSuffixes = ["_Streamable"];

    private static readonly ConcurrentDictionary<(Type, string), PropertyInfo?> s_properties = new();

    public static List<SectorObject> Build(worldStreamingSector sector)
    {
        var result = new List<SectorObject>();
        if (sector.NodeData.Data is not worldNodeDataBuffer entries)
        {
            return result;
        }

        var ranges = sector.VariantIndices.Select(i => (int)i).ToList();
        var persistent = (int)sector.PersisentNodeIndex;
        var innerCache = new Dictionary<int, IList?>();

        for (var i = 0; i < entries.Count; i++)
        {
            var entry = entries[i];
            var nodeIndex = (int)(ulong)entry.NodeIdx;
            var node = nodeIndex >= 0 && nodeIndex < sector.Nodes.Count ? sector.Nodes[nodeIndex]?.Chunk : null;
            var className = node?.GetType().Name ?? "missing node";
            var variant = VariantOf(ranges, i);
            var flags = (ENodeFlags)entry.NodeFlags;

            // only cooked nodes (and instanced meshes, cooked too) pick an inner node; occluders have an instanceIndex of 0
            var inner = -1;
            object? innerNode = null;
            if (node is worldCookedNode && (uint)entry.InstanceIndex != NoInstance)
            {
                if (!innerCache.TryGetValue(nodeIndex, out var list))
                {
                    innerCache[nodeIndex] = list = InnerNodes(node);
                }

                inner = (int)(uint)entry.InstanceIndex;
                innerNode = list is not null && inner >= 0 && inner < list.Count ? list[inner] : null;
            }

            var (resource, appearance, detail) = innerNode is not null
                ? DescribeInner(node!, innerNode, inner)
                : DescribeNode(node);

            var debugName = node?.DebugName.GetResolvedText();
            if (debugName is "None" or "")
            {
                debugName = null;
            }

            // instanced meshes keep their transforms in world space in the node; the entry's own is the origin
            var (x, y, z) = ((float)entry.Transform.Position.X, (float)entry.Transform.Position.Y, (float)entry.Transform.Position.Z);
            if (FirstInstancePosition(node, inner) is { } first)
            {
                (x, y, z) = first;
            }

            var group = GroupName(className);
            var (elementKind, elements) = Elements(node, inner, entry);
            result.Add(new SectorObject
            {
                TargetGroup = SectorTargetGroups.Of(className),
                ElementKind = elementKind,
                Elements = elements,
                NodeDataIndex = i,
                NodeIndex = nodeIndex,
                InnerIndex = inner,
                ClassName = className,
                Group = group,
                Name = ShortName(resource) ?? debugName ?? group,
                Resource = resource,
                Appearance = appearance,
                Detail = detail,
                Variant = variant,
                VariantName = variant == persistent || ranges.Count <= 1 ? "Persistent" : $"Variant {variant}",
                IsHidden = node is not null && !node.IsVisibleInGame,
                IsCooked = node is worldCookedNode,
                Flags = flags,
                Categories = Categories(flags),
                DebugName = debugName,
                X = x,
                Y = y,
                Z = z,
                EntryPosition = ((float)entry.Transform.Position.X, (float)entry.Transform.Position.Y, (float)entry.Transform.Position.Z),
                EntryOrientation = (entry.Transform.Orientation.I, entry.Transform.Orientation.J, entry.Transform.Orientation.K, entry.Transform.Orientation.R),
                EntryScale = (entry.Scale.X, entry.Scale.Y, entry.Scale.Z),
            });
        }

        // a node, or an inner node, placed by several entries: one object with several placements, as before 2.5
        foreach (var shared in result.GroupBy(o => (o.NodeIndex, o.InnerIndex)).Where(g => g.Count() > 1))
        {
            var count = shared.Count();
            foreach (var o in shared)
            {
                o.SharedCount = count;
            }
        }

        return result;
    }

    /// <summary>
    /// The instances or collision actors of an object that ArchiveXL can remove one by one, counted as it counts them
    /// (expectedInstances / expectedActors): the transform range of an instanced mesh, the instance transforms of a
    /// destructible instanced mesh, the actors of a collision node or of the inner node of a cooked one.
    /// </summary>
    private static (SectorElementKind Kind, IReadOnlyList<SectorObjectElement> Elements) Elements(
        RedBaseClass? node, int inner, worldCompiledNodeInstanceSetupInfo entry)
    {
        switch (node)
        {
            case worldInstancedMeshNode
            {
                Buffer.Data: worldInstancedMeshNodeBuffer buffer,
                CookedWorldTransformsBuffer.Data: WorldTransformsBuffer world,
            } when inner >= 0 && inner < buffer.TransformRanges.Count:
            {
                var start = (int)(ushort)buffer.TransformRanges[inner].TransformIndex;
                var count = (int)(ushort)buffer.TransformRanges[inner].TransformCount;
                var list = new List<SectorObjectElement>(count);
                for (var i = 0; i < count; i++)
                {
                    var text = $"instance {i}";
                    if (start + i < world.Transforms.Count && world.Transforms[start + i]?.Transform.Position is { } p)
                    {
                        text += " at " + FormatPosition((float)(CFloat)p.X, (float)(CFloat)p.Y, (float)(CFloat)p.Z);
                    }

                    list.Add(new SectorObjectElement { Index = i, Text = text });
                }

                return (SectorElementKind.Instance, list);
            }
            case worldInstancedDestructibleMeshNode destructible:
            {
                // instance transforms are relative to the entry
                var origin = new System.Numerics.Vector3(entry.Transform.Position.X, entry.Transform.Position.Y, entry.Transform.Position.Z);
                var rotation = new System.Numerics.Quaternion(entry.Transform.Orientation.I, entry.Transform.Orientation.J,
                    entry.Transform.Orientation.K, entry.Transform.Orientation.R);
                var scale = new System.Numerics.Vector3(entry.Scale.X, entry.Scale.Y, entry.Scale.Z);
                var list = new List<SectorObjectElement>(destructible.InstanceTransforms.Count);
                for (var i = 0; i < destructible.InstanceTransforms.Count; i++)
                {
                    var text = $"instance {i}";
                    if (destructible.InstanceTransforms[i] is { } t)
                    {
                        var local = new System.Numerics.Vector3(t.Position.X, t.Position.Y, t.Position.Z) * scale;
                        var p = origin + System.Numerics.Vector3.Transform(local, rotation);
                        text += " at " + FormatPosition(p.X, p.Y, p.Z);
                    }

                    list.Add(new SectorObjectElement { Index = i, Text = text });
                }

                return (SectorElementKind.Instance, list);
            }
            case worldCookedCollisionNode { Buffer.Data: worldCookedCollisionInfoBuffer infos }
                when inner >= 0 && inner < infos.CollisionNodeInfos.Count:
                return (SectorElementKind.Actor, Actors(infos.CollisionNodeInfos[inner].NumActors));
            case worldCollisionNode collision:
                return (SectorElementKind.Actor, Actors(collision.NumActors));
            default:
                return (SectorElementKind.None, []);
        }
    }

    private static List<SectorObjectElement> Actors(ushort count) =>
        Enumerable.Range(0, count).Select(i => new SectorObjectElement { Index = i, Text = $"actor {i}" }).ToList();

    internal static string FormatPosition(float x, float y, float z) =>
        string.Format(CultureInfo.InvariantCulture, "{0:0.##}, {1:0.##}, {2:0.##}", x, y, z);

    /// <summary>World position of the first transform of an instanced mesh's range, if the node is one.</summary>
    private static (float X, float Y, float Z)? FirstInstancePosition(RedBaseClass? node, int inner)
    {
        if (node is not worldInstancedMeshNode
            {
                Buffer.Data: worldInstancedMeshNodeBuffer buffer,
                CookedWorldTransformsBuffer.Data: WorldTransformsBuffer world,
            } || inner < 0 || inner >= buffer.TransformRanges.Count)
        {
            return null;
        }

        var index = (int)(ushort)buffer.TransformRanges[inner].TransformIndex;
        if (index >= world.Transforms.Count || world.Transforms[index]?.Transform.Position is not { } position)
        {
            return null;
        }

        return ((float)(CFloat)position.X, (float)(CFloat)position.Y, (float)(CFloat)position.Z);
    }

    /// <summary>
    /// An ArchiveXL removal of these objects from the sector: <c>index</c> is the nodeData entry and <c>type</c> the
    /// class of its node, as ArchiveXL checks them; <c>expectedNodes</c> counts the nodeData entries. An object with
    /// some (not all) of its instances or actors ticked keeps the others: only those are removed
    /// (instanceDeletions / actorDeletions, with the count ArchiveXL expects). A comment above each entry names it.
    /// With <paramref name="entriesOnly"/>, only the entries, indented to go under the nodeDeletions of a sector the
    /// file already has.
    /// </summary>
    public static string BuildXlRemoval(string sectorPath, int expectedNodes, IEnumerable<SectorObject> objects, bool entriesOnly = false)
    {
        var text = new StringBuilder();
        if (!entriesOnly)
        {
            AppendXlHeader(text, sectorPath, expectedNodes, "nodeDeletions");
        }

        foreach (var o in objects.OrderBy(o => o.NodeDataIndex))
        {
            var detail = o.Detail is { Length: > 0 } d ? $", {d}" : "";
            text.AppendLine(CultureInfo.InvariantCulture, $"        # {o.Name}{detail} ({o.VariantName}) at {o.Position}");
            text.AppendLine(CultureInfo.InvariantCulture, $"        - index: {o.NodeDataIndex}");
            text.AppendLine(CultureInfo.InvariantCulture, $"          type: {o.ClassName}");

            var ticked = o.Elements.Where(e => e.IsChecked).Select(e => e.Index).ToList();
            if (ticked.Count > 0 && ticked.Count < o.Elements.Count && o.ElementKind != SectorElementKind.None)
            {
                var (expected, deletions) = o.ElementKind == SectorElementKind.Actor
                    ? ("expectedActors", "actorDeletions")
                    : ("expectedInstances", "instanceDeletions");
                text.AppendLine(CultureInfo.InvariantCulture, $"          {expected}: {o.Elements.Count}");
                text.AppendLine(CultureInfo.InvariantCulture, $"          {deletions}: [{string.Join(", ", ticked)}]");
            }
        }

        return text.ToString();
    }

    /// <summary>
    /// An ArchiveXL mutation of these objects: the same sector header as a removal, then for each object its
    /// <c>index</c> (the nodeData entry) and <c>type</c> with its current <c>position</c>, <c>orientation</c> (i, j, k, r)
    /// and <c>scale</c>, ready to edit. Debug name, resource and appearance go in comments, as in WolvenBench's
    /// "Copy AXL node mutation", so the file says what each entry is. With <paramref name="entriesOnly"/>, only the
    /// entries, indented to go under the nodeMutations of a sector the file already has.
    /// </summary>
    public static string BuildXlMutation(string sectorPath, int expectedNodes, IEnumerable<SectorObject> objects, bool entriesOnly = false)
    {
        var text = new StringBuilder();
        if (!entriesOnly)
        {
            AppendXlHeader(text, sectorPath, expectedNodes, "nodeMutations");
        }

        foreach (var o in objects.OrderBy(o => o.NodeDataIndex))
        {
            text.AppendLine(CultureInfo.InvariantCulture, $"        - index: {o.NodeDataIndex}");
            if (o.DebugName is { Length: > 0 })
            {
                text.AppendLine(CultureInfo.InvariantCulture, $"          # [Debug Name: {o.DebugName}]");
            }

            text.AppendLine(CultureInfo.InvariantCulture, $"          type: {o.ClassName}");
            if (o.Resource is { Length: > 0 })
            {
                text.AppendLine(CultureInfo.InvariantCulture, $"          # resource: {o.Resource}");
            }

            if (o.Appearance is { Length: > 0 })
            {
                text.AppendLine(CultureInfo.InvariantCulture, $"          # appearance: {o.Appearance}");
            }

            var (x, y, z) = o.EntryPosition;
            var (i, j, k, r) = o.EntryOrientation;
            var (sx, sy, sz) = o.EntryScale;
            text.AppendLine(CultureInfo.InvariantCulture, $"          position: [{Number(x)}, {Number(y)}, {Number(z)}, 0.0]");
            text.AppendLine(CultureInfo.InvariantCulture, $"          orientation: [{Number(i)}, {Number(j)}, {Number(k)}, {Number(r)}]");
            text.AppendLine(CultureInfo.InvariantCulture, $"          scale: [{Number(sx)}, {Number(sy)}, {Number(sz)}]");
        }

        return text.ToString();
    }

    /// <summary>
    /// The start of an .xl file for one sector, down to its list of entries: the game version line (ArchiveXL Sector
    /// Updater and Removal Editor read the version a file was made for from it), streaming / sectors, the sector's path
    /// and expectedNodes, and the list's key.
    /// </summary>
    private static void AppendXlHeader(StringBuilder text, string sectorPath, int expectedNodes, string listKey)
    {
        text.AppendLine(CultureInfo.InvariantCulture, $"# Game version: {GameVersionText((int)gameGameVersion.Current)}");
        text.AppendLine("streaming:");
        text.AppendLine("  sectors:");
        text.AppendLine(CultureInfo.InvariantCulture, $"    - path: {sectorPath.Replace('/', '\\')}");
        text.AppendLine(CultureInfo.InvariantCulture, $"      expectedNodes: {expectedNodes}");
        text.AppendLine(CultureInfo.InvariantCulture, $"      {listKey}:");
    }

    /// <summary>
    /// The shortest text that reads back as the same float ("3280.36", not 3280.360107), at most 6 decimals and at
    /// least one: a world position's step is 1/131072.
    /// </summary>
    internal static string Number(float value)
    {
        if (!float.IsFinite(value))
        {
            return "0.0";
        }

        var shortest = decimal.Parse(value.ToString("R", CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);
        var rounded = Math.Round(shortest, 6);

        // no "-0.0" for -0 or a tiny negative
        return rounded == 0m ? "0.0" : rounded.ToString("0.0#####", CultureInfo.InvariantCulture);
    }

    /// <summary>"2.5" for 2500, "2.31" for 2310 (patch 2.3, hotfix 1), as the game and modding tools name versions.</summary>
    internal static string GameVersionText(int version)
    {
        var major = version / 1000;
        var minor = version % 1000 / 100;
        var hotfix = version % 100 / 10;
        return hotfix is > 0 and < 9
            ? string.Create(CultureInfo.InvariantCulture, $"{major}.{minor}{hotfix}")
            : string.Create(CultureInfo.InvariantCulture, $"{major}.{minor}");
    }

    /// <summary>The node range an entry is in: the last range starting at or before it.</summary>
    internal static int VariantOf(IReadOnlyList<int> rangeStarts, int entryIndex)
    {
        var variant = 0;
        for (var r = 0; r < rangeStarts.Count; r++)
        {
            if (rangeStarts[r] <= entryIndex)
            {
                variant = r;
            }
        }

        return variant;
    }

    /// <summary>
    /// "Static mesh" for worldCookedStaticMeshNode and worldStaticMeshNode, "AI spot" for worldAISpotNode,
    /// "Compiled community area" for worldCompiledCommunityAreaNode_Streamable.
    /// </summary>
    internal static string GroupName(string className)
    {
        var name = className;
        foreach (var suffix in s_classSuffixes)
        {
            if (name.EndsWith(suffix, StringComparison.Ordinal))
            {
                name = name[..^suffix.Length];
            }
        }

        foreach (var prefix in s_classPrefixes)
        {
            if (name.StartsWith(prefix, StringComparison.Ordinal) && name.Length > prefix.Length && char.IsUpper(name[prefix.Length]))
            {
                name = name[prefix.Length..];
                break;
            }
        }

        if (name.EndsWith("Node", StringComparison.Ordinal) && name.Length > 4)
        {
            name = name[..^4];
        }

        // split camel case, keeping acronyms ("AISpot" -> "AI spot", "GI" -> "GI")
        var words = new List<string>();
        var start = 0;
        for (var i = 1; i < name.Length; i++)
        {
            var upper = char.IsUpper(name[i]);
            var startsWord = upper && (!char.IsUpper(name[i - 1]) || (i + 1 < name.Length && char.IsLower(name[i + 1])));
            if (startsWord || name[i] == '_')
            {
                words.Add(name[start..i].Trim('_'));
                start = i;
            }
        }

        words.Add(name[start..].Trim('_'));
        words.RemoveAll(w => w.Length == 0);

        var text = string.Join(' ', words.Select((w, i) =>
            i == 0 || w.All(char.IsUpper) ? w : char.ToLowerInvariant(w[0]) + w[1..]));
        return text.Length > 0 ? text : className;
    }

    internal static string Categories(ENodeFlags flags) =>
        string.Join(", ", s_categoryFlags.Where(c => flags.HasFlag(c.Flag)).Select(c => c.Name));

    private static string? ShortName(string? resource)
    {
        if (string.IsNullOrEmpty(resource))
        {
            return null;
        }

        var slash = resource.LastIndexOfAny(['\\', '/']);
        return slash >= 0 ? resource[(slash + 1)..] : resource;
    }

    /// <summary>The inner nodes of a cooked node: InnerNodes, or CollisionNodeInfos for collision.</summary>
    private static IList? InnerNodes(RedBaseClass node)
    {
        if (node is not worldCookedNode { Buffer.Data: { } data })
        {
            return null;
        }

        return (Property(data.GetType(), "InnerNodes") ?? Property(data.GetType(), "CollisionNodeInfos"))?.GetValue(data) as IList;
    }

    private static (string? Resource, string? Appearance, string? Detail) DescribeInner(RedBaseClass node, object inner, int index)
    {
        var type = inner.GetType();
        var resource = s_innerResourceProperties
            .Select(name => Property(type, name)?.GetValue(inner))
            .OfType<IRedRef>()
            .Select(ResourceText)
            .FirstOrDefault(text => text is not null);
        var appearance = Property(type, "MeshAppearance")?.GetValue(inner) is CName appearanceName ? AppearanceText(appearanceName) : null;

        string? detail = null;
        if (Property(type, "NumActors")?.GetValue(inner) is CUInt16 actors)
        {
            detail = $"{(ushort)actors} actors";
        }
        else if (node is worldInstancedMeshNode { Buffer.Data: worldInstancedMeshNodeBuffer buffer } && index < buffer.TransformRanges.Count)
        {
            detail = $"{(ushort)buffer.TransformRanges[index].TransformCount} instances";
        }

        return (resource, appearance, detail);
    }

    private static (string? Resource, string? Appearance, string? Detail) DescribeNode(RedBaseClass? node)
    {
        if (node is null)
        {
            return (null, null, null);
        }

        string? resource = null;
        foreach (var name in s_resourceProperties)
        {
            if (TryGetProperty(node, name) is IRedRef reference && ResourceText(reference) is { } text)
            {
                resource = text;
                break;
            }
        }

        resource ??= node.GetPropertyNames()
            .Select(name => TryGetProperty(node, name))
            .OfType<IRedRef>()
            .Select(ResourceText)
            .FirstOrDefault(text => text is not null);

        var appearance = (TryGetProperty(node, "meshAppearance") ?? TryGetProperty(node, "appearanceName")) is CName appearanceName
            ? AppearanceText(appearanceName)
            : null;

        // what an .xl removal of single instances counts (expectedInstances)
        var detail = node is worldInstancedDestructibleMeshNode destructible
            ? $"{destructible.InstanceTransforms.Count} instances"
            : null;

        return (resource, appearance, detail);
    }

    private static IRedType? TryGetProperty(RedBaseClass node, string name)
    {
        try
        {
            return node.GetProperty(name);
        }
        catch (Exception)
        {
            return null;
        }
    }

    private static string? ResourceText(IRedRef reference) =>
        reference.DepotPath.GetResolvedText() is { Length: > 0 } path ? path :
        (ulong)reference.DepotPath != 0 ? ((ulong)reference.DepotPath).ToString(CultureInfo.InvariantCulture) : null;

    private static string? AppearanceText(CName name) =>
        name.GetResolvedText() is { Length: > 0 } text && text != "None" && text != "default" ? text : null;

    private static PropertyInfo? Property(Type type, string name) =>
        s_properties.GetOrAdd((type, name), key => key.Item1.GetProperty(key.Item2, BindingFlags.Public | BindingFlags.Instance));
}
