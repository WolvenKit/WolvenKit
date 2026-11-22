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
            "# Game version: 2.5\n" +
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
    public void BuildXlMutation_EntryTransformWithComments()
    {
        var tower = new SectorObject
        {
            NodeDataIndex = 75, NodeIndex = 40, InnerIndex = -1, ClassName = "worldStaticMeshNode",
            Group = "Static mesh", Name = "electric_tower_b_base_metal.mesh", Variant = 0, VariantName = "Persistent",
            DebugName = "electric_tower_b_base_metal",
            Resource = "base\\environment\\architecture\\common\\electric_tower\\electric_tower_b_base_metal.mesh",
            EntryPosition = (3280.36f, 458.198f, 110.715f),
            EntryOrientation = (-0.015f, -0.003f, 0.974f, -0.225f),
            EntryScale = (0.594f, 0.594f, 0.594f),
        };
        var lamp = new SectorObject
        {
            NodeDataIndex = 12, NodeIndex = 3, InnerIndex = 2, ClassName = "worldCookedStaticMeshNode",
            Group = "Static mesh", Name = "lamp.mesh", Variant = 0, VariantName = "Persistent",
            Resource = "base\\lamp.mesh", Appearance = "red",
        };

        var xl = SectorObjectList.BuildXlMutation("base/worlds/x/exterior_51_7_1_0.streamingsector", 104, [tower, lamp]);

        Assert.Equal(
            "# Game version: 2.5\n" +
            "streaming:\n" +
            "  sectors:\n" +
            "    - path: base\\worlds\\x\\exterior_51_7_1_0.streamingsector\n" +
            "      expectedNodes: 104\n" +
            "      nodeMutations:\n" +
            "        - index: 12\n" +
            "          type: worldCookedStaticMeshNode\n" +
            "          # resource: base\\lamp.mesh\n" +
            "          # appearance: red\n" +
            "          position: [0.0, 0.0, 0.0, 0.0]\n" +
            "          orientation: [0.0, 0.0, 0.0, 1.0]\n" +
            "          scale: [1.0, 1.0, 1.0]\n" +
            "        - index: 75\n" +
            "          # [Debug Name: electric_tower_b_base_metal]\n" +
            "          type: worldStaticMeshNode\n" +
            "          # resource: base\\environment\\architecture\\common\\electric_tower\\electric_tower_b_base_metal.mesh\n" +
            "          position: [3280.36, 458.198, 110.715, 0.0]\n" +
            "          orientation: [-0.015, -0.003, 0.974, -0.225]\n" +
            "          scale: [0.594, 0.594, 0.594]\n",
            xl.ReplaceLineEndings("\n"));
    }

    [Theory]
    [InlineData(3280.36f, "3280.36")]
    [InlineData(-0.225f, "-0.225")]
    [InlineData(1f, "1.0")]
    [InlineData(-0f, "0.0")]
    [InlineData(1e-7f, "0.0")]
    [InlineData(-1e-7f, "0.0")]
    [InlineData(0.70710677f, "0.707107")]
    public void Number_ShortestUpToSixDecimals(float value, string expected) =>
        Assert.Equal(expected, SectorObjectList.Number(value));

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

    [Theory]
    [InlineData(2500, "2.5")]
    [InlineData(2310, "2.31")]
    [InlineData(2120, "2.12")]
    [InlineData(2599, "2.5")]
    public void GameVersionText_AsModdingToolsWriteIt(int version, string expected) =>
        Assert.Equal(expected, SectorObjectList.GameVersionText(version));

    [Fact]
    public void Categories_OnlyTellingFlags_InOrder()
    {
        var flags = ENodeFlags.FLAG_IsInterior | ENodeFlags.FLAG_NoCollision | ENodeFlags.FLAG_Decoration |
                    ENodeFlags.FLAG_Culling_IsCullable | ENodeFlags.FLAG_AllowDistanceBoosting;
        Assert.Equal("Decoration, Interior, No collision", SectorObjectList.Categories(flags));
        Assert.Equal("", SectorObjectList.Categories(ENodeFlags.FLAG_None));
    }
}
