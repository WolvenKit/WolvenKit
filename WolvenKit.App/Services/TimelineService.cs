using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.Timeline;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services;

public partial class TimelineService : ObservableObject, IDisposable
{
    private scnSectionNode? _sectionNode;
    private scnSectionNodeWrapper? _nodeWrapper;
    private bool _isUpdating;
    private int _lastKnownEventCount;

    public TimelineService()
    {
        Tracks = new ObservableCollection<TimelineTrack>();
        NodeSelectionService.Instance.PropertyChanged += OnNodeSelectionChanged;
        NodePropertyUpdateService.NodePropertyUpdated += OnNodePropertyUpdated;
    }

    public ObservableCollection<TimelineTrack> Tracks { get; }
    public scnSectionNodeWrapper? NodeWrapper => _nodeWrapper;

    [ObservableProperty]
    private bool _hasSectionNode;

    [ObservableProperty]
    private string _sectionName = string.Empty;

    [ObservableProperty]
    private uint _sectionDuration;

    [ObservableProperty]
    private uint _snapInterval = 100;

    [ObservableProperty]
    private bool _isSnapEnabled = true;

    [ObservableProperty]
    private double _zoomLevel = 1.0;

    public double MinZoomLevel => 0.1;
    public double MaxZoomLevel => 10.0;

    public bool IsDragging { get; set; }

    private void OnNodeSelectionChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(NodeSelectionService.SelectedNode))
        {
            return;
        }

        var selectedNode = NodeSelectionService.Instance.SelectedNode;
        
        if (selectedNode is scnSectionNodeWrapper sectionWrapper)
        {
            LoadSectionNode(sectionWrapper);
        }
        else
        {
            ClearTimeline();
        }
    }

    public void LoadSectionNode(scnSectionNodeWrapper wrapper)
    {
        if (wrapper.Data is not scnSectionNode sectionNode)
        {
            return;
        }

        _nodeWrapper = wrapper;
        _sectionNode = sectionNode;
        SectionName = $"(Node ID: {wrapper.UniqueId})";
        HasSectionNode = true;

        RebuildTracks();
    }

    public void ClearTimeline()
    {
        _nodeWrapper = null;
        _sectionNode = null;
        SectionName = string.Empty;
        HasSectionNode = false;
        Tracks.Clear();
        SectionDuration = 0;
    }

    private void RebuildTracks()
    {
        if (_sectionNode == null)
        {
            return;
        }

        _isUpdating = true;
        Tracks.Clear();

        var eventsByCategory = new Dictionary<string, List<TimelineEvent>>();
        var sceneResource = _nodeWrapper?.SceneResource;
        int eventIndex = 0;

        foreach (var eventHandle in _sectionNode.Events)
        {
            if (eventHandle.GetValue() is not scnSceneEvent sceneEvent)
            {
                continue;
            }

            var evt = new TimelineEvent(sceneEvent, OnEventChanged, sceneResource, eventIndex);
            eventIndex++;
            var category = evt.Category;

            if (!eventsByCategory.ContainsKey(category))
            {
                eventsByCategory[category] = new List<TimelineEvent>();
            }

            eventsByCategory[category].Add(evt);
        }

        var categoryOrder = new[] { "Dialogue", "Animation", "LookAt", "Audio", "Camera", "VFX", "Gameplay", "Placement", "Other" };

        foreach (var category in categoryOrder)
        {
            if (!eventsByCategory.TryGetValue(category, out var events) || events.Count == 0)
            {
                continue;
            }

            var track = new TimelineTrack(category);
            
            foreach (var evt in events.OrderBy(e => e.StartTime))
            {
                track.Events.Add(evt);
            }

            track.AssignEventRows();
            Tracks.Add(track);
        }

        RecalculateSectionDuration();
        _lastKnownEventCount = _sectionNode.Events?.Count ?? 0;
        
        OnPropertyChanged(nameof(Tracks));
        
        _isUpdating = false;
    }

    private void OnEventChanged()
    {
        if (_isUpdating)
        {
            return;
        }

        if (!IsDragging)
        {
            ReorderEventsIfNeeded();
            
            foreach (var track in Tracks)
            {
                track.AssignEventRows();
            }
            
            OnPropertyChanged(nameof(Tracks));
        }
        
        RecalculateSectionDuration();
        
        if (!IsDragging)
        {
            MarkDocumentDirty();
            NotifyPropertyUpdate();
        }
    }
    
    private void ReorderEventsIfNeeded()
    {
        if (_sectionNode?.Events == null || _sectionNode.Events.Count <= 1)
        {
            return;
        }
            
        bool needsReordering = false;
        for (int i = 0; i < _sectionNode.Events.Count - 1; i++)
        {
            var current = _sectionNode.Events[i].GetValue() as scnSceneEvent;
            var next = _sectionNode.Events[i + 1].GetValue() as scnSceneEvent;
            
            if (current != null && next != null && current.StartTime > next.StartTime)
            {
                needsReordering = true;
                break;
            }
        }
        
        if (!needsReordering)
        {
            return;
        }
            
        var sortedEvents = new List<(CHandle<scnSceneEvent> Handle, uint StartTime)>();
        foreach (var eventHandle in _sectionNode.Events)
        {
            if (eventHandle.GetValue() is scnSceneEvent evt)
            {
                sortedEvents.Add((eventHandle, evt.StartTime));
            }
        }
        
        sortedEvents.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));
        
        _sectionNode.Events.Clear();
        foreach (var (handle, _) in sortedEvents)
        {
            _sectionNode.Events.Add(handle);
        }
        
        RebuildTracks();
    }
    
    public void RefreshAfterDrag()
    {
        ReorderEventsIfNeeded();
        
        foreach (var track in Tracks)
        {
            track.AssignEventRows();
        }
            
        OnPropertyChanged(nameof(Tracks));
        
        MarkDocumentDirty();
        NotifyPropertyUpdate();
    }
    
    private void NotifyPropertyUpdate()
    {
        if (_sectionNode == null)
        {
            return;
        }
            
        NodePropertyUpdateService.NotifyPropertyUpdated(_sectionNode);
        _nodeWrapper?.RefreshDetails();
        NodePropertyUpdateService.RequestPropertyPanelRefresh();
    }

    private void RecalculateSectionDuration()
    {
        if (_sectionNode == null)
        {
            return;
        }

        uint maxEndTime = 0;

        foreach (var track in Tracks)
        {
            foreach (var evt in track.Events)
            {
                var endTime = evt.EndTime;
                if (endTime > maxEndTime)
                {
                    maxEndTime = endTime;
                }
            }
        }

        SectionDuration = maxEndTime;
        _sectionNode.SectionDuration = new scnSceneTime { Stu = maxEndTime };
    }

    private void MarkDocumentDirty()
    {
        _nodeWrapper?.DocumentViewModel?.SetIsDirty(true);
    }

    public uint SnapValue(uint value)
    {
        if (!IsSnapEnabled || SnapInterval == 0)
        {
            return value;
        }

        return (uint)(Math.Round((double)value / SnapInterval) * SnapInterval);
    }

    public void ZoomIn()
    {
        ZoomLevel = Math.Min(MaxZoomLevel, ZoomLevel * 1.5);
    }

    public void ZoomOut()
    {
        ZoomLevel = Math.Max(MinZoomLevel, ZoomLevel / 1.5);
    }

    public void ZoomToFit(double viewportWidth)
    {
        if (SectionDuration > 0 && viewportWidth > 0)
        {
            var targetPixelsPerMs = viewportWidth / SectionDuration * 0.9;
            ZoomLevel = targetPixelsPerMs / 0.1;
            ZoomLevel = Math.Clamp(ZoomLevel, MinZoomLevel, MaxZoomLevel);
        }
    }

    private void OnNodePropertyUpdated(object? sender, NodePropertyUpdatedEventArgs e)
    {
        if (_sectionNode == null || _isUpdating)
        {
            return;
        }
            
        var isOurNode = e.NodeData == _sectionNode;
        if (!isOurNode && e.NodeData is scnSectionNode otherSection)
        {
            isOurNode = otherSection.NodeId?.Id == _sectionNode.NodeId?.Id;
        }
        
        if (!isOurNode)
        {
            return;
        }
            
        var currentEventCount = _sectionNode.Events?.Count ?? 0;
        if (currentEventCount != _lastKnownEventCount)
        {
            _lastKnownEventCount = currentEventCount;
            RebuildTracks();
        }
    }

    public void Dispose()
    {
        NodeSelectionService.Instance.PropertyChanged -= OnNodeSelectionChanged;
        NodePropertyUpdateService.NodePropertyUpdated -= OnNodePropertyUpdated;
    }
}
