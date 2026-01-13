using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Timeline;

/// <summary>
/// ViewModel representing a track (row) in the timeline, containing events of a specific category.
/// </summary>
public partial class TimelineTrackViewModel : ObservableObject
{
    public TimelineTrackViewModel(string category)
    {
        Category = category;
        Color = TimelineEventViewModel.GetColorForCategory(category);
        Events = new ObservableCollection<TimelineEventViewModel>();
    }

    /// <summary>
    /// Track category name (e.g., "Dialogue", "Animation")
    /// </summary>
    public string Category { get; }

    /// <summary>
    /// Track color for visual identification
    /// </summary>
    public Color Color { get; }

    /// <summary>
    /// Brush for UI binding
    /// </summary>
    public SolidColorBrush ColorBrush => new(Color);

    /// <summary>
    /// Events in this track
    /// </summary>
    public ObservableCollection<TimelineEventViewModel> Events { get; }

    /// <summary>
    /// Number of rows needed for this track (based on overlapping events)
    /// </summary>
    [ObservableProperty]
    private int _rowCount = 1;

    /// <summary>
    /// Height per row in pixels (sized to fit 2-line event elements with padding)
    /// </summary>
    public double RowHeight => 56;

    /// <summary>
    /// Track height in pixels (based on number of rows)
    /// </summary>
    public double TrackHeight => RowCount * RowHeight + 6; // 6px padding

    /// <summary>
    /// Whether the track is expanded (for future collapsible tracks)
    /// </summary>
    [ObservableProperty]
    private bool _isExpanded = true;

    partial void OnRowCountChanged(int value)
    {
        OnPropertyChanged(nameof(TrackHeight));
    }

    /// <summary>
    /// Assign rows to events to avoid overlaps within this track.
    /// Respects PreferredRow when set and valid.
    /// </summary>
    public void AssignEventRows()
    {
        // Sort by start time, but process events with preferred rows first
        var eventsWithPreferred = Events.Where(e => e.PreferredRow >= 0).OrderBy(e => e.PreferredRow).ThenBy(e => e.StartTime).ToList();
        var eventsWithoutPreferred = Events.Where(e => e.PreferredRow < 0).OrderBy(e => e.StartTime).ThenBy(e => e.Duration).ToList();
        
        // Track which time ranges are occupied in each row
        var rowOccupancy = new List<List<(uint Start, uint End)>>();
        
        // Helper to check if an event can fit in a row
        bool CanFitInRow(int row, uint start, uint end)
        {
            if (row >= rowOccupancy.Count) return true;
            return !rowOccupancy[row].Any(o => start < o.End && o.Start < end);
        }
        
        // Helper to add event to row occupancy
        void AddToRow(int row, uint start, uint end)
        {
            while (rowOccupancy.Count <= row)
                rowOccupancy.Add(new List<(uint, uint)>());
            rowOccupancy[row].Add((start, end));
        }
        
        // First, assign events with preferred rows
        foreach (var evt in eventsWithPreferred)
        {
            int targetRow = evt.PreferredRow;
            
            // Check if preferred row is available
            if (CanFitInRow(targetRow, evt.StartTime, evt.EndTime))
            {
                evt.Row = targetRow;
                AddToRow(targetRow, evt.StartTime, evt.EndTime);
            }
            else
            {
                // Preferred row not available, find next available
                int assignedRow = 0;
                while (!CanFitInRow(assignedRow, evt.StartTime, evt.EndTime))
                    assignedRow++;
                evt.Row = assignedRow;
                AddToRow(assignedRow, evt.StartTime, evt.EndTime);
            }
        }
        
        // Then, assign events without preferred rows
        foreach (var evt in eventsWithoutPreferred)
        {
            int assignedRow = 0;
            while (!CanFitInRow(assignedRow, evt.StartTime, evt.EndTime))
                assignedRow++;
            evt.Row = assignedRow;
            AddToRow(assignedRow, evt.StartTime, evt.EndTime);
        }

        RowCount = Math.Max(1, rowOccupancy.Count);
    }
}
