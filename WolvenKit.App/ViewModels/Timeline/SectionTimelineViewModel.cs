using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.Timeline;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

namespace WolvenKit.App.ViewModels.Timeline;

public partial class SectionTimelineViewModel : ObservableObject, IDisposable
{
    private readonly TimelineService _service;
    
    private const double BaseRowHeight = 56.0;
    private const double BasePixelsPerMs = 0.1;

    public SectionTimelineViewModel()
    {
        _service = new TimelineService();
        _service.PropertyChanged += OnServicePropertyChanged;
    }

    public ObservableCollection<TimelineTrack> Tracks => _service.Tracks;
    public scnSectionNodeWrapper? NodeWrapper => _service.NodeWrapper;
    public bool HasSectionNode => _service.HasSectionNode;
    public string SectionName => _service.SectionName;
    public uint SectionDuration => _service.SectionDuration;
    public uint SnapInterval { get => _service.SnapInterval; set => _service.SnapInterval = value; }
    public bool IsSnapEnabled { get => _service.IsSnapEnabled; set => _service.IsSnapEnabled = value; }
    public bool IsDragging { get => _service.IsDragging; set => _service.IsDragging = value; }

    [ObservableProperty]
    private double _viewportWidth = 800;

    public double PixelsPerMs
    {
        get => _service.ZoomLevel * BasePixelsPerMs;
        set => _service.ZoomLevel = value / BasePixelsPerMs;
    }
    public double MinPixelsPerMs => _service.MinZoomLevel * BasePixelsPerMs;
    public double MaxPixelsPerMs => _service.MaxZoomLevel * BasePixelsPerMs;

    public double TimelineWidth => Math.Max(ViewportWidth, SectionDuration * PixelsPerMs);
    public double GetRowHeight() => BaseRowHeight;
    public double GetTrackHeight(TimelineTrack track) => track.HeightMultiplier * BaseRowHeight;
    public double TotalTrackHeight => Tracks.Sum(t => GetTrackHeight(t));

    private void OnServicePropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(TimelineService.ZoomLevel):
                OnPropertyChanged(nameof(PixelsPerMs));
                OnPropertyChanged(nameof(TimelineWidth));
                break;
            case nameof(TimelineService.SectionDuration):
                OnPropertyChanged(nameof(SectionDuration));
                OnPropertyChanged(nameof(TimelineWidth));
                break;
            case nameof(TimelineService.Tracks):
                OnPropertyChanged(nameof(Tracks));
                OnPropertyChanged(nameof(TotalTrackHeight));
                break;
            case nameof(TimelineService.HasSectionNode):
                OnPropertyChanged(nameof(HasSectionNode));
                break;
            case nameof(TimelineService.SectionName):
                OnPropertyChanged(nameof(SectionName));
                break;
        }
    }
    
    partial void OnViewportWidthChanged(double value)
    {
        OnPropertyChanged(nameof(TimelineWidth));
    }

    public void RefreshAfterDrag() => _service.RefreshAfterDrag();

    public uint SnapValue(uint value) => _service.SnapValue(value);

    public uint PixelsToTime(double pixels)
    {
        var time = (uint)Math.Max(0, pixels / PixelsPerMs);
        return SnapValue(time);
    }

    public double TimeToPixels(uint time) => time * PixelsPerMs;

    [RelayCommand]
    private void ZoomIn() => _service.ZoomIn();

    [RelayCommand]
    private void ZoomOut() => _service.ZoomOut();

    [RelayCommand]
    private void ZoomToFit() => _service.ZoomToFit(ViewportWidth);

    public void Dispose() => _service.Dispose();
}
