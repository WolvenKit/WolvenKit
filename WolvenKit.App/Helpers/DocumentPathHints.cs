using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Tells apart editor tabs of files with the same name: for each such file, the shortest end of its folder path
/// that no other open file with that name shares (as VS Code does). Files with a unique name get no hint.
/// </summary>
public static class DocumentPathHints
{
    private static readonly char[] s_separators = ['\\', '/'];

    /// <summary>
    /// Returns one hint per path, in the same order: null when the file name is unique among <paramref name="paths"/>,
    /// otherwise the distinguishing folders, e.g. "ep1\weapons" or "…\weapons".
    /// </summary>
    public static string?[] Compute(IReadOnlyList<string?> paths)
    {
        var hints = new string?[paths.Count];

        var groups = Enumerable.Range(0, paths.Count)
            .Where(i => !string.IsNullOrEmpty(paths[i]))
            .GroupBy(i => Path.GetFileName(paths[i]!), StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1);

        foreach (var group in groups)
        {
            var indices = group.ToList();
            var folders = indices.ToDictionary(i => i, i => SplitFolders(paths[i]!));

            foreach (var i in indices)
            {
                hints[i] = Distinguish(folders[i], indices.Where(j => j != i).Select(j => folders[j]).ToList());
            }
        }

        return hints;
    }

    private static string[] SplitFolders(string path) =>
        (Path.GetDirectoryName(path) ?? "").Split(s_separators, StringSplitOptions.RemoveEmptyEntries);

    private static string? Distinguish(string[] own, List<string[]> others)
    {
        // the same file opened twice (or no folders at all): nothing to show
        if (own.Length == 0 || others.All(o => o.SequenceEqual(own, StringComparer.OrdinalIgnoreCase)))
        {
            return null;
        }

        for (var count = 1; count <= own.Length; count++)
        {
            var tail = own[^count..];
            if (others.All(o => !EndsWith(o, tail)))
            {
                var hint = string.Join('\\', tail);
                return count < own.Length ? "…\\" + hint : hint;
            }
        }

        // every folder of this path ends another one (a parent folder of the same name): show it whole
        return string.Join('\\', own);
    }

    private static bool EndsWith(string[] folders, string[] tail) =>
        folders.Length >= tail.Length &&
        folders[^tail.Length..].SequenceEqual(tail, StringComparer.OrdinalIgnoreCase);
}
