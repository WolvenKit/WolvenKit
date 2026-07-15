using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Models.Timeline;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene.Timeline;

[TestClass]
[DoNotParallelize]
public class TimelineTrackTests
{
    [TestMethod]
    public void NonOverlappingAndAdjacentEventsShareARow()
    {
        var track = CreateTrack(
            CreateEvent(0, 100),
            CreateEvent(100, 100),
            CreateEvent(250, 50));

        track.AssignEventRows();

        foreach (var timelineEvent in track.Events)
        {
            Assert.AreEqual(0, timelineEvent.Row);
        }
        Assert.AreEqual(1, track.RowCount);
    }

    [TestMethod]
    public void OverlappingEventsUseSeparateRows()
    {
        var track = CreateTrack(
            CreateEvent(0, 200),
            CreateEvent(100, 200),
            CreateEvent(200, 100));

        track.AssignEventRows();

        CollectionAssert.AreEqual(new[] { 0, 1, 0 }, track.Events.Select(timelineEvent => timelineEvent.Row).ToArray());
        Assert.AreEqual(2, track.RowCount);
    }

    [TestMethod]
    public void PreferredRowIsUsedWhenAvailable()
    {
        var preferred = CreateEvent(0, 200, preferredRow: 2);
        var conflicting = CreateEvent(100, 50, preferredRow: 2);
        var track = CreateTrack(preferred, conflicting);

        track.AssignEventRows();

        Assert.AreEqual(2, preferred.Row);
        Assert.AreEqual(0, conflicting.Row);
        Assert.AreEqual(3, track.RowCount);
    }

    [TestMethod]
    public void ZeroDurationEventsAtTheSameTimeUseSeparateRows()
    {
        var track = CreateTrack(
            CreateEvent(100, 0),
            CreateEvent(100, 0));

        track.AssignEventRows();

        CollectionAssert.AreEqual(new[] { 0, 1 }, track.Events.Select(timelineEvent => timelineEvent.Row).ToArray());
        Assert.AreEqual(2, track.RowCount);
    }

    private static TimelineTrack CreateTrack(params TimelineEvent[] events)
    {
        var track = new TimelineTrack("Other");
        foreach (var timelineEvent in events)
        {
            track.Events.Add(timelineEvent);
        }

        return track;
    }

    private static TimelineEvent CreateEvent(uint startTime, uint duration, int preferredRow = -1) =>
        new(new scneventsSocket { StartTime = startTime, Duration = duration }, () => { })
        {
            PreferredRow = preferredRow
        };
}
