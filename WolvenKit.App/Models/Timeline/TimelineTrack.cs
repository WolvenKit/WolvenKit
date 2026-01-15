using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.Models.Timeline;

public partial class TimelineTrack : ObservableObject
{
    public TimelineTrack(string category)
    {
        Category = category;
        Events = new ObservableCollection<TimelineEvent>();
    }

    public string Category { get; }
    public ObservableCollection<TimelineEvent> Events { get; }
    public SolidColorBrush ColorBrush => new(TimelineColorHelper.GetColorForCategory(Category));

    [ObservableProperty]
    private int _rowCount = 1;

    public double HeightMultiplier => RowCount + 0.1;

    [ObservableProperty]
    private bool _isExpanded = true;

    partial void OnRowCountChanged(int value)
    {
        OnPropertyChanged(nameof(HeightMultiplier));
    }

    public void AssignEventRows()
    {
        var eventsWithPreferred = Events.Where(e => e.PreferredRow >= 0).OrderBy(e => e.PreferredRow).ThenBy(e => e.StartTime).ToList();
        var eventsWithoutPreferred = Events.Where(e => e.PreferredRow < 0).OrderBy(e => e.StartTime).ThenBy(e => e.Duration).ToList();
        
        var rowOccupancy = new List<List<(uint Start, uint End)>>();
        
        bool CanFitInRow(int row, uint start, uint end)
        {
            if (row >= rowOccupancy.Count)
            {
                return true;
            }
            
            foreach (var o in rowOccupancy[row])
            {
                if (start == end && o.Start == o.End && start == o.Start)
                {
                    return false;
                }
                if (start < o.End && o.Start < end)
                {
                    return false;
                }
            }
            return true;
        }
        
        void AddToRow(int row, uint start, uint end)
        {
            while (rowOccupancy.Count <= row)
            {
                rowOccupancy.Add(new List<(uint, uint)>());
            }
            rowOccupancy[row].Add((start, end));
        }
        
        foreach (var evt in eventsWithPreferred)
        {
            int targetRow = evt.PreferredRow;
            
            if (CanFitInRow(targetRow, evt.StartTime, evt.EndTime))
            {
                evt.Row = targetRow;
                AddToRow(targetRow, evt.StartTime, evt.EndTime);
            }
            else
            {
                int assignedRow = 0;
                while (!CanFitInRow(assignedRow, evt.StartTime, evt.EndTime))
                {
                    assignedRow++;
                }
                evt.Row = assignedRow;
                AddToRow(assignedRow, evt.StartTime, evt.EndTime);
            }
        }
        
        foreach (var evt in eventsWithoutPreferred)
        {
            int assignedRow = 0;
            while (!CanFitInRow(assignedRow, evt.StartTime, evt.EndTime))
            {
                assignedRow++;
            }
            evt.Row = assignedRow;
            AddToRow(assignedRow, evt.StartTime, evt.EndTime);
        }

        RowCount = Math.Max(1, rowOccupancy.Count);
    }
}
