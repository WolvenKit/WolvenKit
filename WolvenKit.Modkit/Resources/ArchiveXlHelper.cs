using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.Resources;

public class ArchiveXlHelper
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
        var baseMaterialPath = resourceReference.DepotPath.GetResolvedText();
        if (baseMaterialPath is not string || string.IsNullOrEmpty(baseMaterialPath))
        {
            return new CResourceAsyncReference<IMaterial>(DefaultMaterials.DefaultMiPath);
        }

        if (!baseMaterialPath.StartsWith('*'))
        {
            return resourceReference;
        }

        return new CResourceAsyncReference<IMaterial>(baseMaterialPath.Replace(s_materialWildcard, substitutionValue)[1..]);
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
}