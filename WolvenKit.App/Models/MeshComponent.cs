using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class MeshComponent : GroupModel3DExt
{
    public string? AppearanceName { get; set; }
    public string? MaterialName { get; set; }
    public string? WorldNodeIndex { get; set; }
    public ResourcePath DepotPath { get; set; }
}