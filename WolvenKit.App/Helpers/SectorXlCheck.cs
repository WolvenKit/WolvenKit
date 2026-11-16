using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.Helpers;

/// <summary>One entry of an ArchiveXL removal: nodeDeletions[] of a sector.</summary>
public sealed record XlNodeDeletion(
    int Index,
    string Type,
    SectorElementKind ElementKind,
    int ExpectedElements,
    IReadOnlyList<int> Elements);

/// <summary>A sector of an ArchiveXL file (streaming / sectors[]) with its removals.</summary>
public sealed record XlSectorBlock(string Path, int? ExpectedNodes, IReadOnlyList<XlNodeDeletion> Deletions);

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
/// Reads the sector removals of an ArchiveXL file and checks them against a sector the way ArchiveXL does
/// (WorldStreaming extension): the nodeData count against expectedNodes, the class of each entry's node against type,
/// and for single instances or actors their count against expectedInstances / expectedActors. Game patches reorder
/// the nodes of sectors (2.5 did it for every sector), so an old file can point at other objects.
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

                var deletions = new List<XlNodeDeletion>();
                if (Child(sector, "nodeDeletions") is YamlSequenceNode nodes)
                {
                    foreach (var node in nodes.OfType<YamlMappingNode>())
                    {
                        if (Int(node, "index") is not { } index || Scalar(node, "type") is not { Length: > 0 } type)
                        {
                            continue;
                        }

                        var (kind, expected, elements) =
                            Child(node, "instanceDeletions") is YamlSequenceNode instances
                                ? (SectorElementKind.Instance, Int(node, "expectedInstances") ?? 0, Elements(instances))
                                : Child(node, "actorDeletions") is YamlSequenceNode actors
                                    ? (SectorElementKind.Actor, Int(node, "expectedActors") ?? 0, Elements(actors))
                                    : (SectorElementKind.None, 0, new List<int>());
                        deletions.Add(new XlNodeDeletion(index, type, kind, expected, elements));
                    }
                }

                result.Add(new XlSectorBlock(path, Int(sector, "expectedNodes"), deletions));
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
            if (deletion.Index < 0 || deletion.Index >= objects.Count)
            {
                result.Problems.Add($"#{deletion.Index} ({deletion.Type}): no such nodeData entry.");
                continue;
            }

            var o = objects[deletion.Index];
            string? problem = null;
            if (!string.Equals(o.ClassName, deletion.Type, StringComparison.Ordinal))
            {
                problem = $"is {o.ClassName}, the file expects {deletion.Type}";
            }
            else if (deletion.ElementKind != SectorElementKind.None &&
                     (deletion.ElementKind != o.ElementKind || deletion.ExpectedElements != o.Elements.Count))
            {
                var what = deletion.ElementKind == SectorElementKind.Actor ? "actors" : "instances";
                problem = $"has {o.Elements.Count} {what}, the file expects {deletion.ExpectedElements}";
            }
            else if (deletion.Elements.Any(e => e < 0 || e >= Math.Max(deletion.ExpectedElements, 0)))
            {
                problem = "a single removal is out of range";
            }

            if (problem is not null)
            {
                result.RowProblems[deletion.Index] = problem;
                result.Problems.Add($"#{deletion.Index} {o.Name}: {problem}.");
            }
            else
            {
                result.Valid[deletion.Index] = deletion;
            }
        }

        return result;
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
