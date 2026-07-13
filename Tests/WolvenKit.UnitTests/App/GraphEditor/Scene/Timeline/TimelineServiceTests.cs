using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene.Timeline;

[TestClass]
[DoNotParallelize]
public class TimelineServiceTests
{
    [TestMethod]
    public void LoadingSectionPreservesPositiveDurationBuffer()
    {
        using var fixture = new TimelineFixture(10_000, CreateEvent(7_000, 1_000));

        Assert.AreEqual(10_000U, fixture.Service.SectionDuration);
        Assert.AreEqual(10_000U, fixture.Service.TimelineDuration);
        Assert.AreEqual(8_000U, fixture.Service.LatestEventEndTime);
        Assert.IsFalse(fixture.Service.IsSectionDurationTooShort);
        Assert.AreEqual(10_000U, GetStoredDuration(fixture.Node));
    }

    [TestMethod]
    public void LoadingOverrunReportsItWithoutChangingStoredDuration()
    {
        using var fixture = new TimelineFixture(7_500, CreateEvent(7_000, 1_000));

        Assert.AreEqual(7_500U, fixture.Service.SectionDuration);
        Assert.AreEqual(8_000U, fixture.Service.TimelineDuration);
        Assert.AreEqual(8_000U, fixture.Service.LatestEventEndTime);
        Assert.IsTrue(fixture.Service.IsSectionDurationTooShort);
        Assert.AreEqual(7_500U, GetStoredDuration(fixture.Node));
    }

    [DataTestMethod]
    [DataRow(7_500U, 8_000U)]
    [DataRow(10_000U, 10_000U)]
    public void ExtendToEventsOnlyChangesAnOverrun(uint sectionDuration, uint expectedDuration)
    {
        using var fixture = new TimelineFixture(sectionDuration, CreateEvent(7_000, 1_000));

        fixture.Service.ExtendSectionDurationToEvents();

        Assert.AreEqual(expectedDuration, fixture.Service.SectionDuration);
        Assert.AreEqual(expectedDuration, GetStoredDuration(fixture.Node));
        Assert.IsFalse(fixture.Service.IsSectionDurationTooShort);
    }

    [TestMethod]
    public void PreviewDoesNotChangeStoredDurationUntilCommitted()
    {
        using var fixture = new TimelineFixture(10_000, CreateEvent(7_000, 1_000));

        fixture.Service.PreviewSectionDuration(9_000);

        Assert.AreEqual(9_000U, fixture.Service.SectionDuration);
        Assert.AreEqual(10_000U, GetStoredDuration(fixture.Node));

        fixture.Service.SetSectionDuration(fixture.Service.SectionDuration);

        Assert.AreEqual(9_000U, GetStoredDuration(fixture.Node));
    }

    [DataTestMethod]
    [DataRow(7_000U, 8_000U)]
    [DataRow(9_000U, 9_000U)]
    public void SetSectionDurationCannotEndBeforeTheLatestEvent(uint requestedDuration, uint expectedDuration)
    {
        using var fixture = new TimelineFixture(10_000, CreateEvent(7_000, 1_000));

        fixture.Service.SetSectionDuration(requestedDuration);

        Assert.AreEqual(expectedDuration, fixture.Service.SectionDuration);
        Assert.AreEqual(expectedDuration, GetStoredDuration(fixture.Node));
    }

    [TestMethod]
    public void SectionWithoutEventsCanBeReducedFreely()
    {
        using var fixture = new TimelineFixture(10_000);

        fixture.Service.SetSectionDuration(1_000);

        Assert.AreEqual(1_000U, fixture.Service.SectionDuration);
        Assert.AreEqual(1_000U, GetStoredDuration(fixture.Node));
    }

    [TestMethod]
    public void EventTimingChangeUpdatesDurationStateAndUnderlyingEvent()
    {
        var sceneEvent = CreateEvent(500, 500);
        using var fixture = new TimelineFixture(1_500, sceneEvent);
        var timelineEvent = fixture.Service.Tracks.Single().Events.Single();

        timelineEvent.StartTime = 1_200;

        Assert.AreEqual(1_200U, (uint)sceneEvent.StartTime);
        Assert.AreEqual(1_700U, fixture.Service.LatestEventEndTime);
        Assert.AreEqual(1_700U, fixture.Service.TimelineDuration);
        Assert.IsTrue(fixture.Service.IsSectionDurationTooShort);
        Assert.AreEqual(1_500U, GetStoredDuration(fixture.Node));
    }

    [TestMethod]
    public void TimingChangeReordersUnderlyingEvents()
    {
        var first = CreateEvent(100, 50);
        var second = CreateEvent(300, 50);
        using var fixture = new TimelineFixture(1_000, first, second);
        var firstTimelineEvent = fixture.Service.Tracks.Single().Events[0];

        firstTimelineEvent.StartTime = 400;

        Assert.AreSame(second, fixture.Node.Events[0].GetValue());
        Assert.AreSame(first, fixture.Node.Events[1].GetValue());
    }

    [TestMethod]
    public void TracksUseCategoryOrderAndSortEventsByStartTime()
    {
        var laterSocket = CreateEvent(300, 0);
        var audio = new scnAudioEvent { StartTime = 200, Duration = 50 };
        var earlierSocket = CreateEvent(100, 0);
        using var fixture = new TimelineFixture(1_000, laterSocket, audio, earlierSocket);

        CollectionAssert.AreEqual(
            new[] { "Audio", "Other" },
            fixture.Service.Tracks.Select(track => track.Category).ToArray());
        CollectionAssert.AreEqual(
            new uint[] { 100, 300 },
            fixture.Service.Tracks[1].Events.Select(timelineEvent => timelineEvent.StartTime).ToArray());
    }

    [TestMethod]
    public void ExternalPropertyUpdatesRefreshDurationAndEventTiming()
    {
        var sceneEvent = CreateEvent(500, 500);
        using var fixture = new TimelineFixture(1_500, sceneEvent);

        fixture.Node.SectionDuration.Stu = 2_000;
        NodePropertyUpdateService.NotifyPropertyUpdated(fixture.Node);

        Assert.AreEqual(2_000U, fixture.Service.SectionDuration);

        sceneEvent.StartTime = 2_000;
        NodePropertyUpdateService.NotifyPropertyUpdated(sceneEvent);

        Assert.AreEqual(2_500U, fixture.Service.LatestEventEndTime);
        Assert.IsTrue(fixture.Service.IsSectionDurationTooShort);
    }

    [TestMethod]
    public void SnappedSectionDurationSnapsBeforeApplyingEventEndFloor()
    {
        using var fixture = new TimelineFixture(2_000, CreateEvent(1_000, 50));
        fixture.Service.SnapInterval = 100;

        Assert.AreEqual(1_050U, fixture.Service.GetSnappedSectionDuration(1_020));
        Assert.AreEqual(1_200U, fixture.Service.GetSnappedSectionDuration(1_180));

        fixture.Service.IsSnapEnabled = false;

        Assert.AreEqual(1_075U, fixture.Service.GetSnappedSectionDuration(1_075));
    }

    [TestMethod]
    public void ClearTimelineResetsLoadedState()
    {
        using var fixture = new TimelineFixture(1_500, CreateEvent(500, 500));

        fixture.Service.ClearTimeline();

        Assert.IsFalse(fixture.Service.HasSectionNode);
        Assert.AreEqual(0, fixture.Service.Tracks.Count);
        Assert.AreEqual(0U, fixture.Service.SectionDuration);
        Assert.AreEqual(0U, fixture.Service.TimelineDuration);
        Assert.AreEqual(0U, fixture.Service.LatestEventEndTime);
        Assert.IsFalse(fixture.Service.IsSectionDurationTooShort);
    }

    [TestMethod]
    public void ZoomOperationsRespectBoundsAndFitDuration()
    {
        using var service = new TimelineService();

        service.ZoomLevel = service.MaxZoomLevel;
        service.ZoomIn();
        Assert.AreEqual(service.MaxZoomLevel, service.ZoomLevel);

        service.ZoomLevel = service.MinZoomLevel;
        service.ZoomOut();
        Assert.AreEqual(service.MinZoomLevel, service.ZoomLevel);

        service.TimelineDuration = 1_000;
        service.ZoomToFit(100);
        Assert.AreEqual(0.9, service.ZoomLevel, 0.00001);
    }

    private static uint GetStoredDuration(scnSectionNode node) => node.SectionDuration.Stu;

    private static scneventsSocket CreateEvent(uint startTime, uint duration) =>
        new() { StartTime = startTime, Duration = duration };

    private sealed class TimelineFixture : IDisposable
    {
        public TimelineFixture(uint sectionDuration, params scnSceneEvent[] events)
        {
            Node = new scnSectionNode
            {
                NodeId = new scnNodeId { Id = 42 },
                SectionDuration = new scnSceneTime { Stu = sectionDuration }
            };

            foreach (var sceneEvent in events)
            {
                Node.Events.Add(new CHandle<scnSceneEvent>(sceneEvent));
            }

            Wrapper = new scnSectionNodeWrapper(Node, new scnSceneResource());
            Service = new TimelineService();
            Service.LoadSectionNode(Wrapper);
        }

        public scnSectionNode Node { get; }
        public scnSectionNodeWrapper Wrapper { get; }
        public TimelineService Service { get; }

        public void Dispose()
        {
            Service.Dispose();
            Wrapper.Dispose();
        }
    }
}
