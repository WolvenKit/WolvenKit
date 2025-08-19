using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using HelixToolkit.SharpDX.Core;
using Splat;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;

namespace WolvenKit.App.Helpers;

/// <summary>
/// This class will resolve ArchiveXL dynamic variant depot paths.
/// They start with an asterisk <see cref="ArchiveXlHelper.ArchiveXLSubstitutionPrefix"/> and contain substitution wildcards (<see cref="s_keysAndValues"/>).
/// </summary>
public static partial class ArchiveXlHelper
{
    public const string ArchiveXLSubstitutionPrefix = "*";

    private static ILoggerService? s_loggerService;
    private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

    private static IProjectManager? s_projectManager;

    private static IProjectManager? ProjectManager =>
        s_projectManager ??= Locator.Current.GetService<IProjectManager>();


    private static readonly Dictionary<string, string[]> s_keysAndValues = new()
    {
        { "{camera}", ["fpp", "tpp"] },
        { "{feet}", ["lifted", "flat", "high_heels", "flat_shoes"] },
        { "{gender}", ["m", "w"] },
        { "{arms}", ["base_arms", "mantis_blades", "monowire", "projectile_launcher"] }, //
        { "{body}", ["base_body"] },
    };

    /// <summary>
    /// When parsing yaml, we need to remove prepending tags with bang, as they make the compiler throw up
    /// </summary>
    /// <returns></returns>
    [GeneratedRegex(@"(?<=-)\s?\![a-z-]*(?=\s)")]
    private static partial Regex YamlTagRegex();

    /// <summary>
    /// Converts a YAML string to a JSON dictionary
    /// </summary>
    /// <param name="yamlText">The YAML string to convert</param>
    /// <returns>The converted JSON string</returns>
    public static object? YamlToObject(string yamlText)
    {
        // remove yaml tags like !include, !append etc.
        yamlText = YamlTagRegex().Replace(yamlText, "");

        try
        {
            // deserialize it
            return new Deserializer().Deserialize(yamlText);
        }
        catch (Exception ex)
        {
            LoggerService?.Error($"Failed to parse YAML: {ex.Message}");
            return null;
        }
    }

    private static int CountBraces(string depotPath)
    {
        var openBracesCount = depotPath.Count(c => c == '{');
        var closingBracesCount = depotPath.Count(c => c == '}');
        if (openBracesCount != closingBracesCount)
        {
            throw new Exception("Failed to resolve ArchiveXL substitution, no equal amount of { and }");
        }

        return openBracesCount;
    }

    private static IEnumerable<string> Substitute(string depotPath, Cp77Project? activeProject = null)
    {
        // Base case: if the string does not contain '{', return the string as the only element in a list
        if (!depotPath.Contains('{'))
        {
            return [depotPath];
        }

        // For {body}: If we get meshes from active project, we'll use these instead of substituting.
        // The list will only hold "base_body" anyway.
        if (depotPath.Contains("{body}") && depotPath.Split("{body}") is string[] { Length: 2 } parts &&
            activeProject is not null)
        {
            if (!s_keysAndValues.TryGetValue("{body}", out var bodyValues))
            {
                bodyValues = [];
            }

            var bodiesFromProject = activeProject.ModFiles
                .Where(f => f.StartsWith(parts[0]) && f.EndsWith(parts[1]))
                .Select(f => f.Replace(parts[0], "").Replace(parts[1], ""))
                .ToList();

            if (bodiesFromProject.Count > 1)
            {
                bodiesFromProject.AddRange(bodyValues);
                s_keysAndValues["body"] = bodiesFromProject.Distinct().ToArray();
            }
        }


        List<string> results = [];

        var placeholders = PlaceholderPattern().Matches(depotPath);
        foreach (var placeholder in placeholders.Where(p => p.Success))
        {
            var key = placeholder.Value;

            // If the key is not in the dictionary, return early. Empty array will result in a warning.
            if (key.Contains("variant") || !s_keysAndValues.TryGetValue(key, out var substitutionList))
            {
                if (placeholders.Count == 1 && activeProject is not null)
                {
                    results.AddRange(ExtractVariants());
                }

                continue;
            }

            // For each value of this key, replace the key in the string with the value and recursively call the function
            foreach (var substitution in substitutionList)
            {
                var newPath = depotPath.Replace(key, substitution);
                results.AddRange(Substitute(newPath, activeProject));
            }
        }

        if (results.Count == 0)
        {
            results.Add(depotPath);
        }

        return results.Distinct();

        List<string> ExtractVariants()
        {
            var parts1 = depotPath.Split("{");
            var parts2 = depotPath.Split("}");
            if (parts1.Length != 2 || parts2.Length != 2)
            {
                return [depotPath];
            }

            var pathStart = parts1[0];
            HashSet<string> variantMatches = [];

            foreach (var path in activeProject.ModFiles)
            {
                if (!string.IsNullOrEmpty(pathStart) && path.StartsWith(pathStart) &&
                    path.Replace(pathStart, "").Split(Path.DirectorySeparatorChar) is string[]
                    {
                        Length: > 1
                    } variantParts)
                {
                    variantMatches.Add(variantParts[0]);
                }
            }

            return variantMatches.Distinct()
                .Select((variant) => PlaceholderPattern().Replace(depotPath, variant)).ToList();
        }

    }

    /// <summary>
    /// Returns any existing depot path, or null. If no substitution is used, it will still check for the file's existence
    /// and return null if it can't be found.
    /// </summary>
    public static string? GetFirstExistingPath(string? depotPath, Cp77Project? activeProject = null)
    {
        if (depotPath is null || ProjectManager?.ActiveProject?.ModDirectory is not string pathToArchiveFolder
                              || ProjectManager?.ActiveProject?.FileDirectory is not string pathToGameFiles)
        {
            return null;
        }

        var potentialMatches = ResolveDynamicPaths(depotPath, activeProject);
        return potentialMatches.FirstOrDefault((f) =>
            File.Exists(Path.Combine(pathToArchiveFolder, f)) || File.Exists(Path.Combine(pathToGameFiles, f)));
    }

    /// <summary>
    /// Returns a list with all potential substitutions. If the path doesn't enable substitution, the list will have one element.
    /// To get _any_ existing depot path, use <see cref="GetFirstExistingPath(string,Cp77Project)"/> instead.
    /// </summary>
    public static IEnumerable<string> ResolveDynamicPaths(string depotPath, Cp77Project? activeProject = null)
    {
        if (!depotPath.StartsWith('*'))
        {
            return [depotPath];
        }

        depotPath = depotPath[1..];

        var braceCount = 0;
        try
        {
            braceCount = CountBraces(depotPath);
        }
        catch (Exception err)
        {
            LoggerService?.Error(err.Message);
        }

        if (braceCount == 0)
        {
            return [depotPath];
        }

        return Substitute(depotPath, activeProject);
    }

    /// <summary>
    /// ArchiveXL will use the first appearance's chunk materials as a template for any following appearances that don't have any
    /// </summary>
    /// <returns>The appearances array, destructively altered</returns>
    public static CArray<CHandle<meshMeshAppearance>> ExpandAppearanceTemplate(CArray<CHandle<meshMeshAppearance>> apps)
    {
        var meshAppearances = apps.Select(m => m.Chunk).OfType<meshMeshAppearance>().ToList();
        var appearancesWithMaterials = meshAppearances.Where(mA => mA.ChunkMaterials.Count > 0).ToList();

        if (meshAppearances.Count <= 1 || meshAppearances.Count == appearancesWithMaterials.Count ||
            meshAppearances.First() is not meshMeshAppearance template ||
            template.Name.GetString() is not string templateName)
        {
            // nothing to do here
            return apps;
        }

        if (template.ChunkMaterials.Count == 0)
        {
            s_loggerService?.Error($"Can't expand from appearance {templateName}, it doesn't have chunk materials!");
            return apps;
        }

        if (appearancesWithMaterials.Count != 1)
        {
            s_loggerService?.Warning("More than one appearance has chunk materials. Using first entry as template.");
        }

        var templateChunkMaterials = template.ChunkMaterials.Select(s => s.ToString() ?? "").ToList();
        foreach (var mA in meshAppearances.Where(ma => ma.ChunkMaterials.Count == 0))
        {
            // turn template@neon to currentMaterial@neon
            foreach (var chunkMaterial in templateChunkMaterials.Select(chunk =>
                         chunk.Replace(templateName, mA.Name)))
            {
                mA.ChunkMaterials.Add(chunkMaterial);
            }
        }

        return apps;
    }


    /// <summary>
    /// Resolves dynamic materials in mesh appearances, e.g. red@neon => neon_red
    /// </summary>
    /// <param name="apps"></param>
    /// <returns></returns>
    public static CArray<CHandle<meshMeshAppearance>> UnDynamifyChunkNames(CArray<CHandle<meshMeshAppearance>> apps)
    {
        foreach (var mA in apps.Select(m => m.Chunk).OfType<meshMeshAppearance>())
        {
            var chunkMaterials = mA.ChunkMaterials.Select(cm => cm.GetString() ?? "")
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

                    // turn red@neon into neon_red
                    return $"{nameParts[1]}_{nameParts[0]}";
                })
                .ToList();

            mA.ChunkMaterials.Clear();
            foreach (var mat in chunkMaterials)
            {
                mA.ChunkMaterials.Add(mat);
            }
        }

        return apps;
    }

    /// <summary>
    /// Resolves dynamic appearance names and -materials.
    /// Returns a dictionary of dynamic appearance names with all possible parameters.
    /// </summary>
    /// <example><code>
    /// { "@neon", [ "red", "blue", "green" ] }
    /// </code></example>
    public static Dictionary<string, List<string>> GetMaterialSubstitutionMap(CArray<CHandle<meshMeshAppearance>> apps)
    {
        Dictionary<string, List<string>> ret = [];

        var resolvedApps = ExpandAppearanceTemplate(apps)
            .Select(m => m.Chunk)
            .OfType<meshMeshAppearance>();

        foreach (var mat in resolvedApps
                     .SelectMany(a => a.ChunkMaterials)
                     .Select(cM => cM.GetString() ?? "")
                     .Where(name => name.Contains('@'))
                )
        {
            var nameParts = mat.Split('@');
            if (nameParts.Length != 2)
            {
                continue;
            }

            ret.TryAdd(nameParts[1], []);
            ret.Get(nameParts[1]).Add(nameParts[0]);
        }

        return ret;
    }

    /// <summary>
    /// Takes a depot path and a list of mesh appearances, and returns a list of all possible material substitutions.
    /// </summary>
    /// <example>
    ///<code>
    /// in:
    /// red@neon, green@neon, blue@neon
    /// out:
    /// @neon => [red, green, blue]
    /// </code>
    /// </example>
    ///     ///
    ///
    public static IEnumerable<string> ResolveMaterialSubstitutions(string depotPath,
        CArray<CHandle<meshMeshAppearance>> meshAppearances)
    {
        if (!depotPath.Contains("{material}"))
        {
            return ResolveDynamicPaths(depotPath);
        }

        var materialSubstitutions = GetMaterialSubstitutionMap(meshAppearances);
        if (materialSubstitutions.Count == 0)
        {
            return [depotPath];
        }

        depotPath = depotPath.Replace("*", "");

        return materialSubstitutions
            .SelectMany(kvp => kvp.Value)
            .Select(materialName => depotPath.Replace("{material}", materialName))
            .ToList();
    }

    public static string ReplaceInDynamicPath(string dynamicPathStr, string newPathStr)
    {
        // Find all {placeholders} in the original string
        var placeholderPattern = PlaceholderPattern();
        var matches = placeholderPattern.Matches(dynamicPathStr);

        // Split the original string into literal and placeholder parts
        var splitPattern = PlaceholderSplitPattern();
        var originalParts = splitPattern.Split(dynamicPathStr);

        var newPath = newPathStr;

        // Reconstruct the updated string, replacing matching literals with placeholders
        var index = 0;
        foreach (var part in originalParts)
        {
            if (placeholderPattern.IsMatch(part))
            {
                // Find the corresponding literal in the updated string and replace it with the placeholder
                var nextLiteral = index + 1 < originalParts.Length ? originalParts[index + 1] : null;
                if (nextLiteral != null && newPath.Contains(nextLiteral))
                {
                    newPath = newPath.Replace(nextLiteral, part + nextLiteral);
                }
                else
                {
                    // If the next literal is not found, just replace the matching part
                    newPath = newPath.Replace(part.Trim('{', '}'), part);
                }
            }

            index++;
        }

        return newPath;
    }

    [GeneratedRegex(@"\{[^}]+\}")]
    private static partial Regex PlaceholderPattern();

    [GeneratedRegex(@"(\{[^}]+\})")]
    private static partial Regex PlaceholderSplitPattern();
}
