using System.Collections.Generic;

namespace WolvenKit.App.Models;

public class SectorGroup : GroupModel3DExt
{
    public string? MaterialName { get; set; }
    public string? AppearanceName { get; set; }

    // ---- variants and proxies (see RDTMeshViewModel.SectorVariants.cs) ----

    /// <summary>First nodeData index of each node range (the sector's variantIndices).</summary>
    public int[] RangeStarts { get; set; } = [];

    /// <summary>Number of nodeData entries (end of the last range).</summary>
    public int NodeDataCount { get; set; }

    /// <summary>The range that is always loaded.</summary>
    public int PersistentRange { get; set; } = -1;

    /// <summary>Range index → variant name and whether the game loads it by default (from the block, when known).</summary>
    public Dictionary<int, (string Name, bool EnabledByDefault)> Variants { get; set; } = new();

    /// <summary>Scene elements placed by nodeData entries, with those entries' indices.</summary>
    public List<(HelixToolkit.Wpf.SharpDX.Element3D Element, int[] NodeDataIndices)> Placements { get; set; } = new();

    /// <summary>Groups of proxy mesh nodes (low detail stand-ins for other content).</summary>
    public List<HelixToolkit.Wpf.SharpDX.Element3D> ProxyGroups { get; set; } = new();

    /// <summary>Groups of foliage nodes (grass, bushes, trees).</summary>
    public List<HelixToolkit.Wpf.SharpDX.Element3D> FoliageGroups { get; set; } = new();

    /// <summary>Range of a nodeData index; -1 when the sector has no ranges.</summary>
    public int RangeOf(int nodeDataIndex)
    {
        var range = -1;
        for (var i = 0; i < RangeStarts.Length; i++)
        {
            if (RangeStarts[i] <= nodeDataIndex)
            {
                range = i;
            }
        }

        return range;
    }
}
