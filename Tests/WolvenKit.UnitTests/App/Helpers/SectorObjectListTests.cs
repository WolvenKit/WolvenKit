using WolvenKit.App.Helpers;
using Xunit;
using static WolvenKit.RED4.Types.Enums;

namespace Wolvenkit.Test.App.Helpers;

/// <summary>The sector's object list: kinds of nodes (cooked or not), node ranges and flag categories.</summary>
public class SectorObjectListTests
{
    [Theory]
    [InlineData("worldCookedStaticMeshNode", "Static mesh")]
    [InlineData("worldStaticMeshNode", "Static mesh")]
    [InlineData("worldCookedStaticDecalNode", "Static decal")]
    [InlineData("worldCookedCollisionNode", "Collision")]
    [InlineData("worldAISpotNode", "AI spot")]
    [InlineData("worldGINode", "GI")]
    [InlineData("worldGISpaceNode", "GI space")]
    [InlineData("worldInstancedDestructibleMeshNode", "Instanced destructible mesh")]
    [InlineData("worldCompiledCommunityAreaNode_Streamable", "Compiled community area")]
    [InlineData("MinimapDataNode", "Minimap data")]
    public void GroupName_SameKindForCookedAndOldClasses(string className, string expected) =>
        Assert.Equal(expected, SectorObjectList.GroupName(className));

    [Theory]
    [InlineData(0, 0)]
    [InlineData(2338, 0)]
    [InlineData(2339, 1)]
    [InlineData(2340, 2)]
    [InlineData(2549, 10)]
    public void VariantOf_LastRangeStartingAtOrBefore(int entry, int expected) =>
        Assert.Equal(expected, SectorObjectList.VariantOf([0, 2339, 2340, 2366, 2367, 2371, 2373, 2410, 2519, 2520, 2521], entry));

    [Fact]
    public void BuildXlRemoval_IndexIsNodeData_TypeIsRealClass()
    {
        var poster = new SectorObject
        {
            NodeDataIndex = 2141, NodeIndex = 544, InnerIndex = 0, ClassName = "worldCookedStaticMeshNode",
            Group = "Static mesh", Name = "poster_b.mesh", Variant = 0, VariantName = "Persistent",
            X = -782.64f, Y = 987.7f, Z = 30.09f,
        };
        var hedge = new SectorObject
        {
            NodeDataIndex = 253, NodeIndex = 102, InnerIndex = 0, ClassName = "worldInstancedMeshNode",
            Group = "Instanced mesh", Name = "hedge_low_3m.mesh", Detail = "2 instances", Variant = 7, VariantName = "Variant 7",
            X = 1, Y = 2, Z = 3,
        };

        var xl = SectorObjectList.BuildXlRemoval("base/worlds/x/interior_-25_30_0_0.streamingsector", 3112, [poster, hedge]);

        Assert.Equal(
            "streaming:\n" +
            "  sectors:\n" +
            "    - path: base\\worlds\\x\\interior_-25_30_0_0.streamingsector\n" +
            "      expectedNodes: 3112\n" +
            "      nodeDeletions:\n" +
            "        # hedge_low_3m.mesh, 2 instances (Variant 7) at 1, 2, 3\n" +
            "        - index: 253\n" +
            "          type: worldInstancedMeshNode\n" +
            "        # poster_b.mesh (Persistent) at -782.64, 987.7, 30.09\n" +
            "        - index: 2141\n" +
            "          type: worldCookedStaticMeshNode\n",
            xl.ReplaceLineEndings("\n"));
    }

    [Fact]
    public void BuildXlRemoval_TickedInstances_OnlyThose()
    {
        var hedge = new SectorObject
        {
            NodeDataIndex = 253, NodeIndex = 102, InnerIndex = 4, ClassName = "worldInstancedMeshNode",
            Group = "Instanced mesh", Name = "hedge_low_3m.mesh", Variant = 0, VariantName = "Persistent",
            ElementKind = SectorElementKind.Instance,
            Elements =
            [
                new SectorObjectElement { Index = 0, Text = "instance 0", IsChecked = true },
                new SectorObjectElement { Index = 1, Text = "instance 1" },
                new SectorObjectElement { Index = 2, Text = "instance 2", IsChecked = true },
            ],
        };

        var xl = SectorObjectList.BuildXlRemoval("x.streamingsector", 10, [hedge]).ReplaceLineEndings("\n");

        Assert.Contains("        - index: 253\n          type: worldInstancedMeshNode\n          expectedInstances: 3\n          instanceDeletions: [0, 2]\n", xl);

        // all ticked: the whole entry
        hedge.Elements[1].IsChecked = true;
        Assert.DoesNotContain("instanceDeletions", SectorObjectList.BuildXlRemoval("x.streamingsector", 10, [hedge]));
    }

    [Fact]
    public void Categories_OnlyTellingFlags_InOrder()
    {
        var flags = ENodeFlags.FLAG_IsInterior | ENodeFlags.FLAG_NoCollision | ENodeFlags.FLAG_Decoration |
                    ENodeFlags.FLAG_Culling_IsCullable | ENodeFlags.FLAG_AllowDistanceBoosting;
        Assert.Equal("Decoration, Interior, No collision", SectorObjectList.Categories(flags));
        Assert.Equal("", SectorObjectList.Categories(ENodeFlags.FLAG_None));
    }
}
