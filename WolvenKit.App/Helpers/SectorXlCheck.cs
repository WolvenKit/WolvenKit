using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.Helpers;

/// <summary>One entry of an ArchiveXL removal or mutation.</summary>
public sealed record XlNodeDeletion(
    int Index,
    string Type,
    SectorElementKind ElementKind,
    int ExpectedElements,
    IReadOnlyList<int> Elements);

/// <summary>A sector of an ArchiveXL file (streaming / sectors[]) with its removals and mutations.</summary>
public sealed record XlSectorBlock(
    string Path,
    int? ExpectedNodes,
    IReadOnlyList<XlNodeDeletion> Deletions,
    IReadOnlyList<XlNodeDeletion> Mutations);

/// <summary>What a check of an .xl against a sector found.</summary>
public sealed class XlCheckResult
{
    /// <summary>Removals as ArchiveXL would apply them, by nodeData entry.</summary>
    public Dictionary<int, XlNodeDeletion> Valid { get; } = new();

    /// <summary>Problem per nodeData entry, for the rows.</summary>
    public Dictionary<int, string> RowProblems { get; } = new();

    /// <summary>Every problem, in file order, for the report.</summary>
    public List<string> Problems { get; } = [];

    /// <summary>
    /// ArchiveXL skips the whole sector when its nodeData count isn't expectedNodes (after a game patch, typically).
    /// </summary>
    public bool SectorRejected { get; set; }
}

/// <summary>
/// Reads the sector removals and mutations of an ArchiveXL file and checks them against a sector the way
/// ArchiveXL does (WorldStreaming/Config.cpp): nodeData count against expectedNodes, class against type,
/// and for single instances or actors their count against expectedInstances / expectedActors.
/// Missing expected* or an out-of-range single index makes ArchiveXL drop the singles and remove the whole node.
/// </summary>
public static class SectorXlCheck
{
    public static List<XlSectorBlock> Parse(string yaml)
    {
        var stream = new YamlStream();
        using (var reader = new StringReader(yaml))
        {
            stream.Load(reader);
        }

        var result = new List<XlSectorBlock>();
        foreach (var document in stream.Documents)
        {
            if (document.RootNode is not YamlMappingNode root ||
                Child(root, "streaming") is not YamlMappingNode streaming ||
                Child(streaming, "sectors") is not YamlSequenceNode sectors)
            {
                continue;
            }

            foreach (var sector in sectors.OfType<YamlMappingNode>())
            {
                if (Scalar(sector, "path") is not { Length: > 0 } path)
                {
                    continue;
                }

                var deletions = ReadEntries(sector, "nodeDeletions");
                var mutations = ReadEntries(sector, "nodeMutations");
                result.Add(new XlSectorBlock(path, Int(sector, "expectedNodes"), deletions, mutations));
            }
        }

        return result;
    }

    /// <summary>The block of a file for this sector: same depot path, else the same file name.</summary>
    public static XlSectorBlock? FindBlock(IEnumerable<XlSectorBlock> blocks, string sectorPath)
    {
        var list = blocks.ToList();
        var path = Normalize(sectorPath);
        return list.FirstOrDefault(b => Normalize(b.Path) == path) ??
               list.FirstOrDefault(b => string.Equals(FileName(b.Path), FileName(path), StringComparison.OrdinalIgnoreCase));
    }

    public static XlCheckResult Check(XlSectorBlock block, IReadOnlyList<SectorObject> objects)
    {
        var result = new XlCheckResult();
        if (block.ExpectedNodes != objects.Count)
        {
            result.SectorRejected = true;
            result.Problems.Add(string.Format(CultureInfo.InvariantCulture,
                "The sector has {0} nodeData entries, the file expects {1}: ArchiveXL skips the whole sector.",
                objects.Count, block.ExpectedNodes?.ToString(CultureInfo.InvariantCulture) ?? "none"));
        }

        foreach (var deletion in block.Deletions)
        {
            CheckEntry(result, deletion, objects, isMutation: false);
        }

        foreach (var mutation in block.Mutations)
        {
            CheckEntry(result, mutation, objects, isMutation: true);
        }

        return result;
    }

    // Mirrors ArchiveXL ParseSubDeletions: missing/invalid expected* or any out-of-range index
    // clears the singles (whole-node removal). expected = -1 marks "singles were dropped".
    private static List<XlNodeDeletion> ReadEntries(YamlMappingNode sector, string key)
    {
        var list = new List<XlNodeDeletion>();
        if (Child(sector, key) is not YamlSequenceNode nodes)
        {
            return list;
        }

        foreach (var node in nodes.OfType<YamlMappingNode>())
        {
            if (Int(node, "index") is not { } index || Scalar(node, "type") is not { Length: > 0 } type)
            {
                continue;
            }

            var kind = SectorElementKind.None;
            var expected = 0;
            IReadOnlyList<int> elements = Array.Empty<int>();
            var dropped = false;

            var instances = Child(node, "instanceDeletions") as YamlSequenceNode
                         ?? Child(node, "instanceMutations") as YamlSequenceNode;
            var actors = Child(node, "actorDeletions") as YamlSequenceNode
                      ?? Child(node, "actorMutations") as YamlSequenceNode;

            if (instances is not null)
            {
                if (Int(node, "expectedInstances") is { } exp && exp > 0)
                {
                    var parsed = Elements(instances);
                    if (parsed.All(e => e >= 0 && e < exp))
                    {
                        kind = SectorElementKind.Instance;
                        expected = exp;
                        elements = parsed;
                    }
                    else
                    {
                        dropped = true;
                    }
                }
                else
                {
                    dropped = true;
                }
            }
            else if (actors is not null)
            {
                if (Int(node, "expectedActors") is { } exp && exp > 0)
                {
                    var parsed = Elements(actors);
                    if (parsed.All(e => e >= 0 && e < exp))
                    {
                        kind = SectorElementKind.Actor;
                        expected = exp;
                        elements = parsed;
                    }
                    else
                    {
                        dropped = true;
                    }
                }
                else
                {
                    dropped = true;
                }
            }

            if (dropped)
            {
                expected = -1;
            }

            list.Add(new XlNodeDeletion(index, type, kind, expected, elements));
        }

        return list;
    }

    private static void CheckEntry(XlCheckResult result, XlNodeDeletion entry, IReadOnlyList<SectorObject> objects, bool isMutation)
    {
        var label = isMutation ? "mutation" : "removal";
        if (entry.Index < 0 || entry.Index >= objects.Count)
        {
            result.Problems.Add($"#{entry.Index} ({entry.Type}): no such nodeData entry ({label}).");
            return;
        }

        var o = objects[entry.Index];
        string? problem = null;
        var effective = entry;

        if (entry.ExpectedElements < 0)
        {
            problem = "expected* missing or a single index is out of range; ArchiveXL drops the singles and removes the whole node";
            effective = entry with { ExpectedElements = 0, Elements = Array.Empty<int>() };
        }
        else if (!string.Equals(o.ClassName, entry.Type, StringComparison.Ordinal))
        {
            problem = $"is {o.ClassName}, the file expects {entry.Type}";
        }
        else if (entry.ElementKind != SectorElementKind.None &&
                 (entry.ElementKind != o.ElementKind || entry.ExpectedElements != o.Elements.Count))
        {
            var what = entry.ElementKind == SectorElementKind.Actor ? "actors" : "instances";
            problem = $"has {o.Elements.Count} {what}, the file expects {entry.ExpectedElements}";
        }

        if (problem is not null)
        {
            result.RowProblems[entry.Index] = problem;
            result.Problems.Add($"#{entry.Index} {o.Name}: {problem}.");
            if (!isMutation && effective.ElementKind == SectorElementKind.None && entry.ExpectedElements < 0)
            {
                result.Valid[entry.Index] = effective;
            }
        }
        else if (!isMutation)
        {
            result.Valid[entry.Index] = entry;
        }
    }

    private static YamlNode? Child(YamlMappingNode node, string key) =>
        node.Children.TryGetValue(new YamlScalarNode(key), out var child) ? child : null;

    private static string? Scalar(YamlMappingNode node, string key) => (Child(node, key) as YamlScalarNode)?.Value;

    private static int? Int(YamlMappingNode node, string key) =>
        int.TryParse(Scalar(node, key), NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) ? value : null;

    // "[0, 2]" or "[[3, 1]]" (an actor and one of its shapes): the element index
    private static List<int> Elements(YamlSequenceNode list) => list
        .Select(item => item switch
        {
            YamlScalarNode s => s.Value,
            YamlSequenceNode { Children.Count: > 0 } pair => (pair.Children[0] as YamlScalarNode)?.Value,
            _ => null,
        })
        .Select(text => int.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) ? value : -1)
        .ToList();

    private static string Normalize(string path) => path.Trim().Replace('/', '\\').TrimStart('\\').ToUpperInvariant();

    private static string FileName(string path)
    {
        var slash = path.LastIndexOfAny(['\\', '/']);
        return slash >= 0 ? path[(slash + 1)..] : path;
    }
}
