using System.Text.RegularExpressions;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTMeshViewModel
{
    // GetUniqueMaterialName: "meshFile_HASH8__material" (HASH8 = hash of the mesh's depot path)
    private static readonly Regex s_uniqueMaterialName = new(@"^(?<mesh>.+?)_[0-9A-F]{8}__(?<material>.+)$", RegexOptions.Compiled);

    /// <summary>
    /// A unique material name for people: "material (mesh)", without the path hash that only
    /// keeps the cache files of same-named meshes apart. Names without a mesh prefix (the open
    /// mesh's own materials) stay as they are.
    /// </summary>
    private static string MaterialDisplayName(string uniqueName)
    {
        var match = s_uniqueMaterialName.Match(uniqueName);
        return match.Success
            ? $"{match.Groups["material"].Value} ({match.Groups["mesh"].Value})"
            : uniqueName;
    }
}
