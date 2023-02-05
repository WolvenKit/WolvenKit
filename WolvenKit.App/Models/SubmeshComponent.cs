using HelixToolkit.Wpf.SharpDX;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class SubmeshComponent : MeshGeometryModel3D
{
    public bool EnabledWithMask { get; set; }
    public string? MaterialName { get; set; }
    public uint LOD { get; set; }
    public string? AppearanceName { get; set; }
    public ResourcePath DepotPath { get; set; }
    public HelixToolkit.Wpf.SharpDX.Material? OriginalMaterial { get; set; }

}
