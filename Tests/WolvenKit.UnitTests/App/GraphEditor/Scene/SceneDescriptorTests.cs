using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene;

[TestClass]
[DoNotParallelize]
public class SceneDescriptorTests
{
    [TestMethod]
    public void AnimTargetResolvesActorWithoutUsingUnsetPropId()
    {
        var scene = CreateScene();
        var data = CreateTargetData(1, 769);

        Assert.AreEqual("Takemura => Old_man", StringHelper.Stringify(data, scene));
    }

    [TestMethod]
    public void AnimTargetResolvesPropFromTargetPerformerId()
    {
        var scene = CreateScene();
        scene.Props.Add(new scnPropDef
        {
            PropId = new scnPropId { Id = 4 },
            PropName = "lookat_gate"
        });
        var data = CreateTargetData(1, scnSceneResource.CalculatePropPerformerId(4));

        Assert.AreEqual("Takemura => lookat_gate", StringHelper.Stringify(data, scene));
    }

    [TestMethod]
    public void AnimTargetDescribesStopAndStaticPosition()
    {
        var scene = CreateScene();
        var stopData = CreateTargetData(1, 4294967040);
        stopData.IsStart = false;
        var staticData = CreateTargetData(1, 4294967040);
        staticData.StaticTarget = new Vector4 { X = 1.25F, Y = 2.5F, Z = 3.75F, W = 1 };

        Assert.AreEqual("Takemura stop", StringHelper.Stringify(stopData, scene));
        StringAssert.StartsWith(StringHelper.Stringify(staticData, scene), "Takemura => Position (1.25, 2.5, 3.75");
    }

    private static scnSceneResource CreateScene()
    {
        var scene = new scnSceneResource();
        scene.Actors.Add(new scnActorDef
        {
            ActorId = new scnActorId { Id = 0 },
            ActorName = "Takemura"
        });
        scene.Actors.Add(new scnActorDef
        {
            ActorId = new scnActorId { Id = 3 },
            ActorName = "Old_man"
        });
        scene.Props.Add(new scnPropDef
        {
            PropId = new scnPropId { Id = 1 },
            PropName = "wakako_cell"
        });
        return scene;
    }

    private static scnAnimTargetBasicData CreateTargetData(uint performerId, uint targetPerformerId) =>
        new()
        {
            PerformerId = new scnPerformerId { Id = performerId },
            TargetPerformerId = new scnPerformerId { Id = targetPerformerId },
            TargetActorId = new scnActorId { Id = uint.MaxValue },
            TargetPropId = new scnPropId { Id = uint.MaxValue },
            TargetType = scnLookAtTargetType.Actor
        };
}
