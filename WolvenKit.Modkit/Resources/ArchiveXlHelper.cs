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

    public static string MakeDynamic(string staticPath)
    {
        if (string.IsNullOrEmpty(staticPath) || HasSubstitution(staticPath))
        {
            return staticPath;
        }

        var text = Regex.Replace(staticPath, s_genderPartialRegex, "_{gender}_");

        foreach (var kvp in SubstitutionMap)
        {
            foreach (var partial in kvp.Value)
            {
                text = text.Replace($"_{partial}_", "_{" + kvp.Key + "}_");
                text = text.Replace($"_{partial}.", "_{" + kvp.Key + "}.");
            }
        }

        return $"*{text}";
    }


    public static readonly Dictionary<string, List<string>> SubstitutionMap =
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

    /// <summary>
    /// Will match w, m, wa, ma, pwa and pma, as long as it's between to underscores.
    /// </summary>
    private static readonly string s_genderPartialRegex = @"(?<=_)p?[wm]a?(?=_)";

    public static bool HasSubstitution(string s) => s_substitutionRegex().IsMatch(s);

    /// <summary>
    /// Could the string have substitution? 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool CouldHaveSubstitution(string s)
    {
        if (Regex.IsMatch(s, s_genderPartialRegex))
        {
            return true;
        }

        return SubstitutionMap.SelectMany(kvp => kvp.Value)
            .Any(partial => s.Contains($"_{partial}_") || s.Contains($"_{partial}."));
    }
    
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
            if (SubstitutionMap.ContainsKey(match.Value))
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
            $"Invalid substitutions used: [{string.Join(',', invalidSubstitutions)}]. Valid substitutions are: [{string.Join(',', SubstitutionMap.Keys)}] ";
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
            if (!SubstitutionMap.TryGetValue(key, out var values))
            {
                result.Add($"Bad key '{key}' ([ {string.Join(", ", SubstitutionMap.Keys)} ])");
            }
            else if (!values.Contains(value))
            {
                result.Add($"{key}: [ {string.Join(", ", values)} ]");
            } 
        }

        return result.Count == 0 ? null : string.Join(", ", result);
    }
}