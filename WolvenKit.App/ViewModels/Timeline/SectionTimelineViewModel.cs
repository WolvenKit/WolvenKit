using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Timeline;

/// <summary>
/// Main ViewModel for the Section Timeline editor panel.
/// Manages tracks, events, snapping, zoom, and auto-duration calculation.
/// </summary>
public partial class SectionTimelineViewModel : ObservableObject, IDisposable
{
    private scnSectionNode? _sectionNode;
    private scnSectionNodeWrapper? _nodeWrapper;
    private bool _isUpdating;
    private int _lastKnownEventCount;

    public SectionTimelineViewModel()
    {
        Tracks = new ObservableCollection<TimelineTrackViewModel>();
        
        // Subscribe to node selection changes
        NodeSelectionService.Instance.PropertyChanged += OnNodeSelectionChanged;
        
        // Subscribe to property updates for detecting event additions/deletions
        NodePropertyUpdateService.NodePropertyUpdated += OnNodePropertyUpdated;
    }

    /// <summary>
    /// All tracks in the timeline
    /// </summary>
    public ObservableCollection<TimelineTrackViewModel> Tracks { get; }

    /// <summary>
    /// The currently loaded section node wrapper
    /// </summary>
    public scnSectionNodeWrapper? NodeWrapper => _nodeWrapper;

    /// <summary>
    /// Whether a section node is currently loaded
    /// </summary>
    [ObservableProperty]
    private bool _hasSectionNode;

    /// <summary>
    /// Section node display name
    /// </summary>
    [ObservableProperty]
    private string _sectionName = string.Empty;

    /// <summary>
    /// Total duration of the section in milliseconds
    /// </summary>
    [ObservableProperty]
    private uint _sectionDuration;

    /// <summary>
    /// Snap interval in milliseconds (0 = disabled)
    /// </summary>
    [ObservableProperty]
    private uint _snapInterval = 100;

    /// <summary>
    /// Whether snapping is enabled
    /// </summary>
    [ObservableProperty]
    private bool _isSnapEnabled = true;

    /// <summary>
    /// Zoom level (pixels per millisecond)
    /// </summary>
    [ObservableProperty]
    private double _pixelsPerMs = 0.1;

    /// <summary>
    /// Minimum zoom level
    /// </summary>
    public double MinPixelsPerMs => 0.01;

    /// <summary>
    /// Maximum zoom level
    /// </summary>
    public double MaxPixelsPerMs => 1.0;

    /// <summary>
    /// Timeline viewport width for scrolling
    /// </summary>
    [ObservableProperty]
    private double _viewportWidth = 800;

    /// <summary>
    /// Whether a drag operation is in progress (prevents full re-render during drag)
    /// </summary>
    public bool IsDragging { get; set; }

    /// <summary>
    /// Total timeline width based on duration and zoom (with minimum for short timelines)
    /// </summary>
    public double TimelineWidth => Math.Max(ViewportWidth, SectionDuration * PixelsPerMs);

    /// <summary>
    /// Total height of all tracks combined (for canvas sizing)
    /// </summary>
    public double TotalTrackHeight => Tracks.Sum(t => t.TrackHeight);

    partial void OnSectionDurationChanged(uint value)
    {
        OnPropertyChanged(nameof(TimelineWidth));
    }

    partial void OnPixelsPerMsChanged(double value)
    {
        OnPropertyChanged(nameof(TimelineWidth));
    }
    
    partial void OnViewportWidthChanged(double value)
    {
        OnPropertyChanged(nameof(TimelineWidth));
    }

    private void OnNodeSelectionChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(NodeSelectionService.SelectedNode))
            return;

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

    /// <summary>
    /// Load a section node into the timeline
    /// </summary>
    public void LoadSectionNode(scnSectionNodeWrapper wrapper)
    {
        if (wrapper.Data is not scnSectionNode sectionNode)
            return;

        _nodeWrapper = wrapper;
        _sectionNode = sectionNode;
        SectionName = $"(Node ID: {wrapper.UniqueId})";
        HasSectionNode = true;

        RebuildTracks();
    }

    /// <summary>
    /// Clear the timeline
    /// </summary>
    public void ClearTimeline()
    {
        _nodeWrapper = null;
        _sectionNode = null;
        SectionName = string.Empty;
        HasSectionNode = false;
        Tracks.Clear();
        SectionDuration = 0;
    }

    /// <summary>
    /// Rebuild all tracks from the section node's events
    /// </summary>
    private void RebuildTracks()
    {
        if (_sectionNode == null)
            return;

        _isUpdating = true;
        Tracks.Clear();

        // Group events by category
        var eventsByCategory = new Dictionary<string, List<TimelineEventViewModel>>();
        var sceneResource = _nodeWrapper?.SceneResource;
        int eventIndex = 0; // 0-based index

        foreach (var eventHandle in _sectionNode.Events)
        {
            if (eventHandle.GetValue() is not scnSceneEvent sceneEvent)
                continue;

            var eventVm = new TimelineEventViewModel(sceneEvent, OnEventChanged, sceneResource, eventIndex);
            eventIndex++;
            var category = eventVm.Category;

            if (!eventsByCategory.ContainsKey(category))
            {
                eventsByCategory[category] = new List<TimelineEventViewModel>();
            }

            eventsByCategory[category].Add(eventVm);
        }

        // Create tracks in a consistent order
        var categoryOrder = new[] { "Dialogue", "Animation", "LookAt", "Audio", "Camera", "VFX", "Gameplay", "Placement", "Other" };

        foreach (var category in categoryOrder)
        {
            if (!eventsByCategory.TryGetValue(category, out var events) || events.Count == 0)
                continue;

            var track = new TimelineTrackViewModel(category);
            
            // Sort events by start time within the track
            foreach (var evt in events.OrderBy(e => e.StartTime))
            {
                track.Events.Add(evt);
            }

            // Assign rows to events to handle overlaps
            track.AssignEventRows();
            Tracks.Add(track);
        }

        // Calculate section duration
        RecalculateSectionDuration();
        
        // Update last known event count for change detection
        _lastKnownEventCount = _sectionNode.Events?.Count ?? 0;
        
        // Notify UI to re-render
        OnPropertyChanged(nameof(Tracks));
        OnPropertyChanged(nameof(TotalTrackHeight));
        
        _isUpdating = false;
    }

    /// <summary>
    /// Called when any event's StartTime or Duration changes
    /// </summary>
    private void OnEventChanged()
    {
        if (_isUpdating)
            return;

        // During drag, only update the underlying data - don't re-render or reassign rows. Full update happens when drag ends via RefreshAfterDrag()
        if (!IsDragging)
        {
            ReorderEventsIfNeeded();
            
            foreach (var track in Tracks)
            {
                track.AssignEventRows();
            }
            
            OnPropertyChanged(nameof(Tracks));
            OnPropertyChanged(nameof(TotalTrackHeight));
        }
        
        RecalculateSectionDuration();
        
        // Only mark dirty and notify other editors when not dragging. This defers expensive updates until drag completes
        if (!IsDragging)
        {
            MarkDocumentDirty();
            NotifyPropertyUpdate();
        }
    }
    
    /// <summary>
    /// Reorder the events array to maintain chronological order by StartTime
    /// </summary>
    private void ReorderEventsIfNeeded()
    {
        if (_sectionNode?.Events == null || _sectionNode.Events.Count <= 1)
            return;
            
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
            return;
            
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
    
    /// <summary>
    /// Called when drag operation ends to recalculate rows and refresh display
    /// </summary>
    public void RefreshAfterDrag()
    {
        ReorderEventsIfNeeded();
        
        foreach (var track in Tracks)
        {
            track.AssignEventRows();
        }
        OnPropertyChanged(nameof(Tracks));
        OnPropertyChanged(nameof(TotalTrackHeight));
        
        // Now that drag is complete, do the deferred updates
        MarkDocumentDirty();
        NotifyPropertyUpdate();
    }
    
    /// <summary>
    /// Notify the property update service to sync changes to graph and property panel
    /// </summary>
    private void NotifyPropertyUpdate()
    {
        if (_sectionNode == null)
            return;
            
        // Notify the graph view to refresh
        NodePropertyUpdateService.NotifyPropertyUpdated(_sectionNode);
        
        // Also refresh the node wrapper's details directly for immediate graph update
        _nodeWrapper?.RefreshDetails();
        
        // Request the property panel to refresh its displayed values
        NodePropertyUpdateService.RequestPropertyPanelRefresh();
    }

    /// <summary>
    /// Recalculate section duration based on all events
    /// </summary>
    private void RecalculateSectionDuration()
    {
        if (_sectionNode == null)
            return;

        uint maxEndTime = 0;

        foreach (var track in Tracks)
        {
            foreach (var evt in track.Events)
            {
                var endTime = evt.EndTime;
                if (endTime > maxEndTime)
                    maxEndTime = endTime;
            }
        }

        // Update both the VM and the underlying data
        SectionDuration = maxEndTime;
        _sectionNode.SectionDuration = new scnSceneTime { Stu = maxEndTime };
    }

    /// <summary>
    /// Mark the parent document as dirty
    /// </summary>
    private void MarkDocumentDirty()
    {
        _nodeWrapper?.DocumentViewModel?.SetIsDirty(true);
    }

    /// <summary>
    /// Snap a value to the snap grid
    /// </summary>
    public uint SnapValue(uint value)
    {
        if (!IsSnapEnabled || SnapInterval == 0)
            return value;

        return (uint)(Math.Round((double)value / SnapInterval) * SnapInterval);
    }

    /// <summary>
    /// Convert pixel position to time in milliseconds
    /// </summary>
    public uint PixelsToTime(double pixels)
    {
        var time = (uint)Math.Max(0, pixels / PixelsPerMs);
        return SnapValue(time);
    }

    /// <summary>
    /// Convert time in milliseconds to pixel position
    /// </summary>
    public double TimeToPixels(uint time)
    {
        return time * PixelsPerMs;
    }

    [RelayCommand]
    private void ZoomIn()
    {
        PixelsPerMs = Math.Min(MaxPixelsPerMs, PixelsPerMs * 1.5);
    }

    [RelayCommand]
    private void ZoomOut()
    {
        PixelsPerMs = Math.Max(MinPixelsPerMs, PixelsPerMs / 1.5);
    }

    [RelayCommand]
    private void ZoomToFit()
    {
        if (SectionDuration > 0 && ViewportWidth > 0)
        {
            PixelsPerMs = ViewportWidth / SectionDuration * 0.9; // 90% to leave some margin
            PixelsPerMs = Math.Clamp(PixelsPerMs, MinPixelsPerMs, MaxPixelsPerMs);
        }
    }

    /// <summary>
    /// Handle property updates from the property editor (detect event additions/deletions)
    /// </summary>
    private void OnNodePropertyUpdated(object? sender, NodePropertyUpdatedEventArgs e)
    {
        if (_sectionNode == null || _isUpdating)
            return;
            
        // Check if this update is for our section node (compare by reference or by node ID)
        var isOurNode = e.NodeData == _sectionNode;
        if (!isOurNode && e.NodeData is scnSectionNode otherSection)
        {
            // Also check by node ID in case object references differ
            isOurNode = otherSection.NodeId?.Id == _sectionNode.NodeId?.Id;
        }
        
        if (!isOurNode)
            return;
            
        // Check if the event count has changed (addition or deletion)
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
