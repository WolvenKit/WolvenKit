using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using HelixToolkit.SharpDX.Core;
using Splat;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
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
    private static INotificationService? s_notificationService;
    private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

    private static INotificationService? NotificationService =>
        s_notificationService ??= Locator.Current.GetService<INotificationService>();

    private static IProjectManager? s_projectManager;
    private static IProjectManager? ProjectManager => s_projectManager ??= Locator.Current.GetService<IProjectManager>();

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
        if (depotPath.Contains("{body}") && depotPath.Split("{body}") is { Length: 2 } parts &&
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
                    path.Replace(pathStart, "").Split(Path.DirectorySeparatorChar) is
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
                              || ProjectManager.ActiveProject?.FileDirectory is not string pathToGameFiles)
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
        var appearancesWithMaterials =
            meshAppearances.Where(mA => mA.ChunkMaterials.Count > 0).ToDictionary(k => k.Name, v => v);

        if (meshAppearances.Count <= 1 || // can't expand anything if there's just one appearance
            meshAppearances.Count == appearancesWithMaterials.Count || // they all have materials
            appearancesWithMaterials.Count == 0 // none have materials
           )
        {
            // nothing to do here
            return apps;
        }

        var appearancesWithoutMaterials =
            meshAppearances.Where(ma => ma.ChunkMaterials.Count == 0).ToList();

        if (appearancesWithMaterials.Count > 1 && appearancesWithoutMaterials.Count(a => a.Tags.Count == 0) <
            appearancesWithoutMaterials.Count)
        {
            LoggerService?.Warning(
                "More than one appearance has chunk materials. " +
                "To avoid ambiguities, add the template appearance name as a tag to your empty appearances." +
                "Expansion will proceed, but results may not be what you expect."
            );
            NotificationService?.Warning("Material template ambiguity detected in mesh appearances. " +
                                         "Check the log view for details.");
        }

        var templateAppearance = appearancesWithMaterials.Values.First();
        foreach (var mA in appearancesWithoutMaterials)
        {

            // If a template appearance is defined via tag, use that one
            if (mA.Tags.Count > 0 && appearancesWithMaterials.TryGetValue(mA.Tags[0], out var appearance))
            {
                templateAppearance = appearance;
            }

            if (templateAppearance.Name.ToString() is not string templateAppearanceName)
            {
                continue;
            }

            // turn template@neon to currentMaterial@neon
            foreach (var chunkMaterial in templateAppearance.ChunkMaterials.ToList().Select(chunk =>
                         chunk.ToString()!.Replace(templateAppearanceName, mA.Name)))
            {
                mA.ChunkMaterials.Add((CName)chunkMaterial);
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
    /// { "@neon",   [ "red", "blue", "green" ] }
    /// { "lambert", [ "lambert" ] }
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
                ret.TryAdd(mat, [mat]);
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
    /// <example><code>
    /// in:
    /// red@neon, green@neon, blue@neon
    /// lambert
    /// out:
    /// @neon   => [red, green, blue]
    /// lambert => [lambert]
    /// </code> </example>
    public static IEnumerable<string> ResolveMaterialSubstitutions(string depotPath,
        CArray<CHandle<meshMeshAppearance>> meshAppearances)
    {
        if (!depotPath.StartsWith('*') && !depotPath.Contains("{material}"))
        {
            return [depotPath];
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


    /// <summary>
    /// Replaces {material} in a resource reference's depot path with a new material name.
    /// I'm sure there is a way to make this nicer with generics, but this will do for now.
    /// </summary>
    public static IRedRef UnDynamifyResourceReference(IRedType cvpValue, string newMatName)
    {
        var newPath = "";
        var redType = cvpValue.RedType.Split(":").Last();
        if (cvpValue is IRedResourceReference original)
        {
            newPath = ReplaceMaterialPath(original.DepotPath, newMatName);
            // @formatter:off
            return redType switch
            {
                "Multilayer_Setup" => new CResourceReference<Multilayer_Setup>(newPath, InternalEnums.EImportFlags.Default),
                "Multilayer_Mask" => new CResourceReference<Multilayer_Mask>(newPath, InternalEnums.EImportFlags.Default),
                "ITexture" => new CResourceReference<ITexture>(newPath, InternalEnums.EImportFlags.Default),
                "CGradient" => new CResourceReference<CGradient>(newPath, InternalEnums.EImportFlags.Default),
                "CFoliageProfile" => new CResourceReference<CFoliageProfile>(newPath, InternalEnums.EImportFlags.Default),
                "CHairProfile" => new CResourceReference<CHairProfile>(newPath, InternalEnums.EImportFlags.Default),
                "CSkinProfile" => new CResourceReference<CSkinProfile>(newPath, InternalEnums.EImportFlags.Default),
                "CTerrainSetup" => new CResourceReference<CTerrainSetup>(newPath, InternalEnums.EImportFlags.Default),
                _ => original
            };
            // @formatter:on
        }

        if (cvpValue is not IRedResourceReference asyncRef)
        {
            throw new WolvenKitException(0,
                $"This shouldn't happen: UnDynamifyResourceReference called with unsupported type {redType}");
        }

        newPath = ReplaceMaterialPath(asyncRef.DepotPath, newMatName);
        // @formatter:off
        return redType switch
        {
            "Multilayer_Setup" => new CResourceAsyncReference<Multilayer_Setup>(newPath, InternalEnums.EImportFlags.Default),
            "Multilayer_Mask" => new CResourceAsyncReference<Multilayer_Mask>(newPath, InternalEnums.EImportFlags.Default),
            "ITexture" => new CResourceAsyncReference<ITexture>(newPath, InternalEnums.EImportFlags.Default),
            "CGradient" => new CResourceAsyncReference<CGradient>(newPath, InternalEnums.EImportFlags.Default),
            "CFoliageProfile" => new CResourceAsyncReference<CFoliageProfile>(newPath, InternalEnums.EImportFlags.Default),
            "CHairProfile" => new CResourceAsyncReference<CHairProfile>(newPath, InternalEnums.EImportFlags.Default),
            "CSkinProfile" => new CResourceAsyncReference<CSkinProfile>(newPath, InternalEnums.EImportFlags.Default),
            "CTerrainSetup" => new CResourceAsyncReference<CTerrainSetup>(newPath, InternalEnums.EImportFlags.Default),
            _ => asyncRef
        };
        // @formatter:on

        static string ReplaceMaterialPath(ResourcePath? depotPath, string input) =>
            (depotPath?.GetResolvedText() ?? "").Replace("{material}", input).Replace("*", "");
    }
}
