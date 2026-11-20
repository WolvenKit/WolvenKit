using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;
using Xunit;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>Reading an ArchiveXL sector removal and checking it against a sector, as ArchiveXL does.</summary>
public class SectorXlCheckTests
{
    private const string Xl = """
        streaming:
          sectors:
            - path: base\worlds\03_night_city\_compiled\default\interior_-25_30_0_0.streamingsector
              expectedNodes: 3
              nodeDeletions:
                - index: 0
                  type: worldCookedStaticMeshNode
                - index: 1
                  type: worldStaticMeshNode
                - index: 2
                  type: worldInstancedMeshNode
                  expectedInstances: 3
                  instanceDeletions: [0, 2]
                - index: 7
                  type: worldStaticMeshNode
            - path: base\worlds\other.streamingsector
              expectedNodes: 1
        """;

    private static SectorObject Row(int index, string className, SectorElementKind kind = SectorElementKind.None, int elements = 0) => new()
    {
        NodeDataIndex = index, NodeIndex = index, InnerIndex = -1, ClassName = className, Group = "g", Name = $"o{index}",
        Variant = 0, VariantName = "Persistent", ElementKind = kind,
        Elements = Enumerable.Range(0, elements).Select(i => new SectorObjectElement { Index = i, Text = $"instance {i}" }).ToList(),
    };

    [Fact]
    public void Parse_ReadsSectorsAndRemovals()
    {
        var blocks = SectorXlCheck.Parse(Xl);
        Assert.Equal(2, blocks.Count);
        Assert.Equal(3, blocks[0].ExpectedNodes);
        Assert.Equal(4, blocks[0].Deletions.Count);
        Assert.Equal(SectorElementKind.Instance, blocks[0].Deletions[2].ElementKind);
        Assert.Equal(3, blocks[0].Deletions[2].ExpectedElements);
        Assert.Equal(new[] { 0, 2 }, blocks[0].Deletions[2].Elements);
    }

    [Fact]
    public void FindBlock_ByPath_ThenByFileName()
    {
        var blocks = SectorXlCheck.Parse(Xl);
        Assert.Same(blocks[0], SectorXlCheck.FindBlock(blocks, "base/worlds/03_night_city/_compiled/default/interior_-25_30_0_0.streamingsector"));
        Assert.Same(blocks[0], SectorXlCheck.FindBlock(blocks, "my_project_copy\\interior_-25_30_0_0.streamingsector"));
        Assert.Null(SectorXlCheck.FindBlock(blocks, "base\\worlds\\none.streamingsector"));
    }

    [Fact]
    public void Check_FlagsWhatArchiveXlRejects()
    {
        var block = SectorXlCheck.Parse(Xl)[0];
        var rows = new List<SectorObject>
        {
            Row(0, "worldCookedStaticMeshNode"),
            Row(1, "worldCookedStaticMeshNode"), // reordered by a patch: another class now
            Row(2, "worldInstancedMeshNode", SectorElementKind.Instance, 3),
        };

        var result = SectorXlCheck.Check(block, rows);

        Assert.False(result.SectorRejected);
        Assert.Equal(new[] { 0, 2 }, result.Valid.Keys.Order());
        Assert.Contains("the file expects worldStaticMeshNode", result.RowProblems[1], StringComparison.Ordinal);
        Assert.Contains(result.Problems, p => p.StartsWith("#7 ", StringComparison.Ordinal));

        rows.Add(Row(3, "worldStaticMeshNode"));
        Assert.True(SectorXlCheck.Check(block, rows).SectorRejected);
    }
}
