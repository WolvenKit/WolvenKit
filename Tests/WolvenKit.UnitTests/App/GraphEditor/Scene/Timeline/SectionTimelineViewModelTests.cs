using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.Timeline;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.GraphEditor.Scene.Timeline;

[TestClass]
[DoNotParallelize]
public class SectionTimelineViewModelTests
{
    [TestMethod]
    public void FirstSelectedSectionZoomsToFitViewport()
    {
        using var fixture = new TimelineViewModelFixture();
        fixture.ViewModel.ViewportWidth = 400;

        fixture.SelectSection(duration: 2_000);

        Assert.AreEqual(0.18, fixture.ViewModel.PixelsPerMs, 0.00001);
        Assert.AreEqual(400, fixture.ViewModel.TimelineWidth, 0.00001);
    }

    [TestMethod]
    public void SwitchingSectionsRestoresIndependentZoomLevels()
    {
        using var fixture = new TimelineViewModelFixture();
        fixture.ViewModel.ViewportWidth = 400;
        var first = fixture.CreateSection(duration: 2_000);
        var second = fixture.CreateSection(duration: 1_000);

        fixture.Select(first);
        fixture.ViewModel.PixelsPerMs = 0.25;

        fixture.Select(second);
        fixture.ViewModel.PixelsPerMs = 0.5;

        fixture.Select(first);
        Assert.AreEqual(0.25, fixture.ViewModel.PixelsPerMs, 0.00001);

        fixture.Select(second);
        Assert.AreEqual(0.5, fixture.ViewModel.PixelsPerMs, 0.00001);
    }

    [TestMethod]
    public void RefreshingCurrentSectionPreservesZoom()
    {
        using var fixture = new TimelineViewModelFixture();
        fixture.SelectSection(duration: 2_000);
        fixture.ViewModel.PixelsPerMs = 0.3;

        fixture.ViewModel.RefreshAfterDrag();

        Assert.AreEqual(0.3, fixture.ViewModel.PixelsPerMs, 0.00001);
    }

    [TestMethod]
    public void TimelineWidthUsesViewportAsMinimumAndExpandsForContent()
    {
        using var fixture = new TimelineViewModelFixture();
        fixture.ViewModel.ViewportWidth = 500;

        Assert.AreEqual(500, fixture.ViewModel.TimelineWidth, 0.00001);

        fixture.SelectSection(duration: 1_000);
        Assert.AreEqual(500, fixture.ViewModel.TimelineWidth, 0.00001);

        fixture.ViewModel.PixelsPerMs = 0.8;
        Assert.AreEqual(800, fixture.ViewModel.TimelineWidth, 0.00001);
    }

    [TestMethod]
    public void PixelTimeConversionsRespectZoomAndSnapping()
    {
        using var fixture = new TimelineViewModelFixture();
        fixture.ViewModel.PixelsPerMs = 0.2;
        fixture.ViewModel.IsSnapEnabled = true;
        fixture.ViewModel.SnapInterval = 100;

        Assert.AreEqual(50, fixture.ViewModel.TimeToPixels(250), 0.00001);
        Assert.AreEqual(200U, fixture.ViewModel.PixelsToTime(46));
        Assert.AreEqual(0U, fixture.ViewModel.PixelsToTime(-10));
    }

    [TestMethod]
    public void ViewportWidthChangeNotifiesTimelineWidth()
    {
        using var fixture = new TimelineViewModelFixture();
        var changedProperties = new List<string?>();
        fixture.ViewModel.PropertyChanged += OnPropertyChanged;

        fixture.ViewModel.ViewportWidth = 1_200;

        CollectionAssert.Contains(changedProperties, nameof(SectionTimelineViewModel.TimelineWidth));

        void OnPropertyChanged(object? sender, PropertyChangedEventArgs e) => changedProperties.Add(e.PropertyName);
    }

    [TestMethod]
    public void DisposeStopsReactingToNodeSelection()
    {
        using var fixture = new TimelineViewModelFixture();
        var first = fixture.CreateSection(duration: 1_000);
        var second = fixture.CreateSection(duration: 2_000);
        fixture.Select(first);
        fixture.DisposeViewModel();

        fixture.Select(second);

        Assert.AreSame(first, fixture.ViewModel.NodeWrapper);
        Assert.AreEqual(1_000U, fixture.ViewModel.SectionDuration);
    }

    private sealed class TimelineViewModelFixture : IDisposable
    {
        private readonly List<scnSectionNodeWrapper> _wrappers = [];
        private uint _nextNodeId = 1;
        private bool _isViewModelDisposed;

        public TimelineViewModelFixture()
        {
            NodeSelectionService.Instance.SelectedNode = null;
            ViewModel = new SectionTimelineViewModel();
        }

        public SectionTimelineViewModel ViewModel { get; }

        public scnSectionNodeWrapper CreateSection(uint duration)
        {
            var node = new scnSectionNode
            {
                NodeId = new scnNodeId { Id = _nextNodeId++ },
                SectionDuration = new scnSceneTime { Stu = duration }
            };
            var wrapper = new scnSectionNodeWrapper(node, new scnSceneResource());
            _wrappers.Add(wrapper);
            return wrapper;
        }

        public void SelectSection(uint duration) => Select(CreateSection(duration));

        public void Select(scnSectionNodeWrapper wrapper) => NodeSelectionService.Instance.SelectedNode = wrapper;

        public void DisposeViewModel()
        {
            if (_isViewModelDisposed)
            {
                return;
            }

            ViewModel.Dispose();
            _isViewModelDisposed = true;
        }

        public void Dispose()
        {
            NodeSelectionService.Instance.SelectedNode = null;
            DisposeViewModel();
            foreach (var wrapper in _wrappers)
            {
                wrapper.Dispose();
            }
        }
    }
}
