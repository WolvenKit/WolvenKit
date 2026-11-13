using System.Text.RegularExpressions;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class SubmeshComponent : MeshGeometryModel3D
{
    public string? Text { get; set; }
    public bool EnabledWithMask { get; set; }
    public string? MaterialName { get; set; }

    /// <summary>
    /// <see cref="MaterialName"/> without the cache prefix "&lt;mesh&gt;_&lt;8 hex&gt;__" that keeps
    /// materials of different meshes apart in the preview cache; for display only.
    /// </summary>
    public string? MaterialDisplayName => StripMeshPrefix(MaterialName);

    public uint LOD { get; set; }
    public string? AppearanceName { get; set; }
    public string? CollisionActorId { get; set; }
    
    // fix endless printlns in debug mode slowing down the IDE 
    public string WorldNodeIndex = "";
    public string WorldNodeDataIndices = "";
    public ResourcePath DepotPath { get; set; }
    public HelixToolkit.Wpf.SharpDX.Material? OriginalMaterial { get; set; }

    private static readonly Regex s_meshPrefix = new(@"^.*?_[0-9A-F]{8}__", RegexOptions.Compiled);

    /// <summary>"hh_051_wa__judy_4E655027__hair_cards" → "hair_cards"; other names unchanged.</summary>
    public static string? StripMeshPrefix(string? name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return name;
        }

        var match = s_meshPrefix.Match(name);
        return match.Success && match.Length < name.Length ? name[match.Length..] : name;
    }
}
