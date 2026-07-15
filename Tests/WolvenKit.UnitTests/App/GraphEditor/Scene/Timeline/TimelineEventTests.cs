using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Models.Timeline;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene.Timeline;

[TestClass]
[DoNotParallelize]
public class TimelineEventTests
{
    [TestMethod]
    public void TimingChangesUpdateTheUnderlyingEvent()
    {
        var changeCount = 0;
        var sceneEvent = CreateSceneEvent(100, 200);
        var timelineEvent = new TimelineEvent(sceneEvent, () => changeCount++);

        timelineEvent.StartTime = 300;
        timelineEvent.Duration = 400;

        Assert.AreEqual(300U, (uint)sceneEvent.StartTime);
        Assert.AreEqual(400U, (uint)sceneEvent.Duration);
        Assert.AreEqual(700U, timelineEvent.EndTime);
        Assert.AreEqual(2, changeCount);
    }

    [TestMethod]
    public void AdjacentEventsDoNotOverlap()
    {
        var first = CreateTimelineEvent(100, 100);
        var adjacent = CreateTimelineEvent(200, 50);
        var overlapping = CreateTimelineEvent(199, 50);

        Assert.IsFalse(first.OverlapsWith(adjacent));
        Assert.IsTrue(first.OverlapsWith(overlapping));
    }

    [TestMethod]
    public void SocketEventExposesItsIndexAndCategory()
    {
        var sceneEvent = CreateSceneEvent(100, 0);
        var timelineEvent = new TimelineEvent(sceneEvent, () => { }, eventIndex: 3);

        Assert.AreEqual("Other", timelineEvent.Category);
        Assert.AreEqual("#3 Socket", timelineEvent.TitleLine);
        Assert.AreEqual("(2, 1)", timelineEvent.DetailsLine);
    }

    private static TimelineEvent CreateTimelineEvent(uint startTime, uint duration) =>
        new(CreateSceneEvent(startTime, duration), () => { });

    private static scneventsSocket CreateSceneEvent(uint startTime, uint duration) =>
        new()
        {
            StartTime = startTime,
            Duration = duration,
            OsockStamp = new scnOutputSocketStamp { Name = 2, Ordinal = 1 }
        };
}
