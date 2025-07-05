using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.Resources;

public partial class ArchiveXlHelper
{
    private const string s_materialWildcard = "{material}";

    /// <summary>
    /// Resolves a potentially invalid depot path: Empty values will fall back to <see cref="DefaultMaterials.DefaultMiPath"/>,
    /// ArchiveXL dynamic materials will have substitution applied.
    /// </summary>
    /// <param name="resourceReference">The reference in question</param>
    /// <param name="substitutionValue">name of dynamic material to substitute <see cref="s_materialWildcard"/> with</param>
    /// <returns>The resolved reference</returns>
    public static IRedRef ResolvePotentiallyDynamicDepotPath(IRedRef resourceReference, string substitutionValue)
    {
        var depotPath = resourceReference.DepotPath.GetResolvedText();
        if (depotPath is not string || string.IsNullOrEmpty(depotPath))
        {
            return new CResourceAsyncReference<IMaterial>(DefaultMaterials.DefaultMiPath);
        }

        if (!depotPath.StartsWith('*'))
        {
            return resourceReference;
        }

        return new CResourceAsyncReference<IMaterial>(depotPath.Replace(s_materialWildcard, substitutionValue)[1..]);
    }

    /// <summary>
    /// Resolves a potentially invalid depot path: Empty values will fall back to <see cref="DefaultMaterials.DefaultMiPath"/>,
    /// ArchiveXL dynamic materials will have substitution applied.
    /// </summary>
    /// <param name="baseMaterial">The reference in question</param>
    /// <param name="substitutionValue">name of dynamic material to substitute <see cref="s_materialWildcard"/> with</param>
    /// <returns>The resolved reference</returns>
    public static CResourceReference<IMaterial> ResolveBaseMaterial(CResourceReference<IMaterial> baseMaterial, string substitutionValue)
    {
        var baseMaterialPath = baseMaterial.DepotPath.GetResolvedText();
        if (baseMaterialPath is not string || string.IsNullOrEmpty(baseMaterialPath))
        {
            return new CResourceReference<IMaterial>(DefaultMaterials.DefaultMiPath);
        }

        if (!baseMaterialPath.StartsWith('*'))
        {
            return baseMaterial;
        }

        // replace {material} with dynamic material name and cut off leading *
        return new CResourceReference<IMaterial>(baseMaterialPath.Replace(s_materialWildcard, substitutionValue)[1..]);

    }
    
    

    private static readonly Dictionary<string, List<string>> s_substitutionMap =
        new()
        {
            { "camera", ["fpp", "tpp"] }, //
            { "feet", ["lifted", "flat", "high_heels", "flat_shoes"] }, //
            { "arms", ["base_arms", "mantis_blades", "monowire", "projectile_launcher"] }, //
            { "gender", ["m", "w"] },
            { "body", ["base_body", "for a list check https://tinyurl.com/cyberpunk-body-mods"] },
        };


    [GeneratedRegex(@"(?<=\{)\w+(?=\})")]
    private static partial Regex s_substitutionRegex();

    public static bool HasSubstitution(string s) => s_substitutionRegex().IsMatch(s);

    public static string? GetValuesForInvalidSubstitution(string? s)
    {
        if (s is null || !HasSubstitution(s))
        {
            return null;
        }

        if (!s.StartsWith('*'))
        {
            return "string must start with '*'";
        }

        if (s.Contains(s_materialWildcard))
        {
            return null;
        }

        List<string> invalidSubstitutions = [];
        
        foreach (Match match in s_substitutionRegex().Matches(s))
        {
            if (s_substitutionMap.ContainsKey(match.Value))
            {
                continue;
            }

            invalidSubstitutions.Add(match.Value);
        }

        if (invalidSubstitutions.Count == 0)
        {
            return null;
        }
        

        return
            $"Invalid substitutions used: [{string.Join(',', invalidSubstitutions)}]. Valid substitutions are: [{string.Join(',', s_substitutionMap.Keys)}] ";
    }


    [GeneratedRegex(@"(?<=&)\w+=\w+")]
    private static partial Regex s_ConditionRegex();

    public static bool HasInvalidCondition(string s) => s_ConditionRegex().IsMatch(s);

    public static string? GetValuesForInvalidConditions(string? s)
    {
        if (s is null || !HasInvalidCondition(s))
        {
            return null;
        }

        List<string> result = [];

        foreach (Match match in s_ConditionRegex().Matches(s))
        {
            var keyValue = match.Value.Split("=");
            if (keyValue.Length != 2)
            {
                continue;
            }

            var (key, value) = (keyValue[0].Replace("&", ""), keyValue[1]);
            if (!s_substitutionMap.TryGetValue(key, out var values))
            {
                result.Add($"Bad key '{key}' ([ {string.Join(", ", s_substitutionMap.Keys)} ])");
            }
            else if (!values.Contains(value))
            {
                result.Add($"{key}: [ {string.Join(", ", values)} ]");
            } 
        }

        return result.Count == 0 ? null : string.Join(", ", result);
    }
}