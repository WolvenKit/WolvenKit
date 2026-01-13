#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Timeline;

namespace WolvenKit.Views.Timeline;

/// <summary>
/// Code behind for SectionTimelineView - handles rendering and mouse interactions
/// </summary>
public partial class SectionTimelineView : UserControl
{
    private SectionTimelineViewModel? _viewModel;
    private readonly Dictionary<TimelineEventViewModel, Border> _eventElements = new();
    
    private TimelineEventViewModel? _draggedEvent;
    private bool _isResizing;
    private bool _isDragActive; // True only after drag threshold exceeded
    private Point _dragStartPoint;
    private uint _dragStartTime;
    private uint _dragStartDuration;
    private int _dragStartRow;
    private double _dragTrackYOffset; // Y offset of the track containing the dragged event
    
    // Selection highlighting
    private TimelineEventViewModel? _selectedEvent;
    private Border? _selectedBorder;
    private const double DragThreshold = 5.0; // Pixels to move before drag starts

    public SectionTimelineView()
    {
        InitializeComponent();
        
        // Create and set the ViewModel
        _viewModel = new SectionTimelineViewModel();
        DataContext = _viewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        
        Loaded += OnLoaded;
        SizeChanged += OnSizeChanged;
        
        PreviewKeyDown += OnPreviewKeyDown;
    }
    
    private void OnPreviewKeyDown(object sender, KeyEventArgs e)
    {
        // Block shortcuts
        if (e.Key == Key.Delete || e.Key == Key.Back ||
            (Keyboard.Modifiers == ModifierKeys.Control && 
             (e.Key == Key.C || e.Key == Key.V || e.Key == Key.D)))
        {
            e.Handled = true;
        }
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        UpdateViewportWidth();
        RenderTimeline();
    }

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateViewportWidth();
        RenderTimeline();
    }

    private void UpdateViewportWidth()
    {
        if (_viewModel != null && TrackScrollViewer != null)
        {
            _viewModel.ViewportWidth = TrackScrollViewer.ActualWidth - 150;
        }
    }

    private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName is nameof(SectionTimelineViewModel.HasSectionNode) 
            or nameof(SectionTimelineViewModel.PixelsPerMs)
            or nameof(SectionTimelineViewModel.SectionDuration)
            or nameof(SectionTimelineViewModel.Tracks))
        {
            Dispatcher.BeginInvoke(new Action(RenderTimeline));
        }
    }

    private void RenderTimeline()
    {
        if (_viewModel == null || !_viewModel.HasSectionNode)
        {
            TimelineCanvas?.Children.Clear();
            TimeRulerCanvas?.Children.Clear();
            _eventElements.Clear();
            return;
        }

        RenderTimeRuler();
        RenderEvents();
    }

    private void RenderTimeRuler()
    {
        if (TimeRulerCanvas == null || _viewModel == null)
            return;

        TimeRulerCanvas.Children.Clear();

        var duration = _viewModel.SectionDuration;
        var pixelsPerMs = _viewModel.PixelsPerMs;
        
        if (duration == 0 || pixelsPerMs == 0)
            return;

        // Determine tick interval based on zoom level
        uint tickInterval = GetTickInterval(pixelsPerMs);
        
        for (uint time = 0; time <= duration; time += tickInterval)
        {
            var x = time * pixelsPerMs;
            
            // Major tick line
            var line = new Line
            {
                X1 = x,
                Y1 = 16,
                X2 = x,
                Y2 = 24,
                Stroke = new SolidColorBrush(Color.FromRgb(100, 100, 100)),
                StrokeThickness = 1
            };
            TimeRulerCanvas.Children.Add(line);
            
            // Time label
            var label = new TextBlock
            {
                Text = FormatTime(time),
                Foreground = new SolidColorBrush(Color.FromRgb(150, 150, 150))
            };
            label.SetResourceReference(TextBlock.FontSizeProperty, "WolvenKitFontAltTitle");
            Canvas.SetLeft(label, x + 2);
            Canvas.SetTop(label, 2);
            TimeRulerCanvas.Children.Add(label);
        }
    }

    private static uint GetTickInterval(double pixelsPerMs)
    {
        // Choose tick interval based on zoom level to avoid overcrowding
        if (pixelsPerMs > 0.5) return 100;      // Every 100ms
        if (pixelsPerMs > 0.2) return 250;      // Every 250ms
        if (pixelsPerMs > 0.1) return 500;      // Every 500ms
        if (pixelsPerMs > 0.05) return 1000;    // Every 1s
        if (pixelsPerMs > 0.02) return 2000;    // Every 2s
        return 5000;                             // Every 5s
    }

    private static string FormatTime(uint ms)
    {
        if (ms < 1000)
            return $"{ms}ms";
        
        var seconds = ms / 1000.0;
        return $"{seconds:F1}s";
    }

    private void RenderEvents()
    {
        if (TimelineCanvas == null || _viewModel == null)
            return;

        TimelineCanvas.Children.Clear();
        _eventElements.Clear();

        var pixelsPerMs = _viewModel.PixelsPerMs;
        double yOffset = 0;

        // Render grid lines first
        RenderGridLines();

        foreach (var track in _viewModel.Tracks)
        {
            var trackHeight = track.TrackHeight;
            var rowHeight = track.RowHeight;

            // Track background/separator
            var trackBg = new Rectangle
            {
                Width = _viewModel.TimelineWidth,
                Height = trackHeight,
                Fill = new SolidColorBrush(Color.FromArgb(20, 255, 255, 255)),
                Stroke = new SolidColorBrush(Color.FromRgb(50, 50, 50)),
                StrokeThickness = 0.5
            };
            Canvas.SetLeft(trackBg, 0);
            Canvas.SetTop(trackBg, yOffset);
            TimelineCanvas.Children.Add(trackBg);

            // Render events in this track, positioned by their Row
            foreach (var evt in track.Events)
            {
                var eventYOffset = yOffset + (evt.Row * rowHeight) + 2;
                var eventElement = CreateEventElement(evt, eventYOffset, rowHeight);
                TimelineCanvas.Children.Add(eventElement);
                _eventElements[evt] = eventElement;
            }

            yOffset += trackHeight;
        }

        // Set canvas height
        TimelineCanvas.SetCurrentValue(HeightProperty, yOffset);
    }

    private void RenderGridLines()
    {
        if (_viewModel == null)
            return;

        var pixelsPerMs = _viewModel.PixelsPerMs;
        var duration = _viewModel.SectionDuration;
        var totalHeight = _viewModel.Tracks.Sum(t => t.TrackHeight);
        
        uint gridInterval = GetTickInterval(pixelsPerMs);
        
        for (uint time = 0; time <= duration; time += gridInterval)
        {
            var x = time * pixelsPerMs;
            var line = new Line
            {
                X1 = x,
                Y1 = 0,
                X2 = x,
                Y2 = totalHeight,
                Stroke = new SolidColorBrush(Color.FromArgb(30, 255, 255, 255)),
                StrokeThickness = 1
            };
            TimelineCanvas.Children.Add(line);
        }
    }

    private Border CreateEventElement(TimelineEventViewModel evt, double yOffset, double trackHeight)
    {
        const double eventHeight = 50;
        var pixelsPerMs = _viewModel!.PixelsPerMs;
        var x = evt.StartTime * pixelsPerMs;

        var width = Math.Max(80, evt.Duration * pixelsPerMs);

        var border = new Border
        {
            Background = new SolidColorBrush(evt.Color),
            CornerRadius = new CornerRadius(4),
            Height = eventHeight,
            MinWidth = 80,
            Cursor = Cursors.SizeAll,
            Tag = evt,
            ToolTip = $"{evt.DisplayLabel}\nStart: {evt.StartTime}ms\nDuration: {evt.Duration}ms"
        };

        // Two-line layout: Title on top, Details below
        var stackPanel = new StackPanel
        {
            Margin = new Thickness(8, 6, 12, 6),
            VerticalAlignment = VerticalAlignment.Center
        };

        // Title line (bigger font)
        var titleLabel = new TextBlock
        {
            Text = evt.TitleLine,
            Foreground = Brushes.White,
            FontWeight = FontWeights.SemiBold,
            TextTrimming = TextTrimming.CharacterEllipsis
        };
        titleLabel.SetResourceReference(TextBlock.FontSizeProperty, "WolvenKitFontSubTitle");

        // Details line (smaller font)
        var detailsLabel = new TextBlock
        {
            Text = evt.DetailsLine,
            Foreground = new SolidColorBrush(Color.FromArgb(200, 255, 255, 255)),
            TextTrimming = TextTrimming.CharacterEllipsis
        };
        detailsLabel.SetResourceReference(TextBlock.FontSizeProperty, "WolvenKitFontAltTitle");

        stackPanel.Children.Add(titleLabel);
        if (!string.IsNullOrEmpty(evt.DetailsLine))
        {
            stackPanel.Children.Add(detailsLabel);
        }

        // Resize grip
        var resizeGrip = new Border
        {
            Background = Brushes.Transparent,
            Cursor = Cursors.SizeWE,
            HorizontalAlignment = HorizontalAlignment.Right,
            Tag = "resize"
        };
        resizeGrip.SetResourceReference(Border.WidthProperty, "WolvenKitIconPico");

        var grid = new Grid();
        grid.Children.Add(stackPanel);
        grid.Children.Add(resizeGrip);
        border.Child = grid;

        Canvas.SetLeft(border, x);
        Canvas.SetTop(border, yOffset + (trackHeight - eventHeight) / 2);
        border.Width = width;

        // Mouse events for the resize grip
        resizeGrip.MouseLeftButtonDown += (s, e) =>
        {
            _isResizing = true;
            _draggedEvent = evt;
            _dragStartPoint = e.GetPosition(TimelineCanvas);
            _dragStartDuration = evt.Duration;
            if (_viewModel != null) _viewModel.IsDragging = true;
            resizeGrip.CaptureMouse();
            e.Handled = true;
        };

        resizeGrip.MouseLeftButtonUp += (s, e) =>
        {
            if (_isResizing)
            {
                _isResizing = false;
                _draggedEvent = null;
                resizeGrip.ReleaseMouseCapture();
                
                // End resize and refresh rows
                if (_viewModel != null)
                {
                    _viewModel.IsDragging = false;
                    _viewModel.RefreshAfterDrag();
                }
            }
        };

        resizeGrip.MouseMove += (s, e) =>
        {
            if (_isResizing && _draggedEvent != null)
            {
                var currentPoint = e.GetPosition(TimelineCanvas);
                var deltaX = currentPoint.X - _dragStartPoint.X;
                var deltaMs = (int)(deltaX / pixelsPerMs);
                
                var newDuration = (uint)Math.Max(0, (int)_dragStartDuration + deltaMs);
                newDuration = _viewModel.SnapValue(newDuration);
                
                if (newDuration > 0)
                {
                    _draggedEvent.Duration = newDuration;
                    UpdateEventElement(_draggedEvent);
                }
            }
        };

        return border;
    }

    private void UpdateEventElement(TimelineEventViewModel evt)
    {
        if (!_eventElements.TryGetValue(evt, out var border) || _viewModel == null)
            return;

        var pixelsPerMs = _viewModel.PixelsPerMs;
        Canvas.SetLeft(border, evt.StartTime * pixelsPerMs);
        border.Width = Math.Max(4, evt.Duration * pixelsPerMs);
        border.ToolTip = $"{evt.DisplayLabel}\nStart: {evt.StartTime}ms\nDuration: {evt.Duration}ms";
    }

    private void TimelineCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (_viewModel == null || _isResizing)
            return;

        // Capture keyboard focus to block shortcuts from propagating
        Focus();
        
        var point = e.GetPosition(TimelineCanvas);
        
        // Find clicked event
        var hitElement = TimelineCanvas.InputHitTest(point) as DependencyObject;
        while (hitElement != null && hitElement != TimelineCanvas)
        {
            if (hitElement is Border border && border.Tag is TimelineEventViewModel evt)
            {
                // Check if clicking on resize grip
                var innerHit = border.InputHitTest(e.GetPosition(border)) as FrameworkElement;
                if (innerHit?.Tag as string == "resize")
                    return; // Let resize grip handle it

                // Apply selection highlight
                SelectEvent(evt, border);

                _draggedEvent = evt;
                _dragStartPoint = point;
                _dragStartTime = evt.StartTime;
                _dragStartRow = evt.Row;
                _isDragActive = false; // Don't start dragging until threshold exceeded
                
                // Calculate the Y offset of the track containing this event
                _dragTrackYOffset = 0;
                foreach (var track in _viewModel.Tracks)
                {
                    if (track.Events.Contains(evt))
                        break;
                    _dragTrackYOffset += track.TrackHeight;
                }
                
                TimelineCanvas.CaptureMouse();
                
                // Select this event in the property panel
                SelectEventInPropertyPanel(evt);
                
                e.Handled = true;
                return;
            }
            hitElement = VisualTreeHelper.GetParent(hitElement);
        }
        
        // Clicked on empty space - deselect current event but keep focus
        if (_selectedBorder != null && _selectedEvent != null)
        {
            _selectedBorder.SetCurrentValue(Border.BorderBrushProperty, null);
            _selectedBorder.SetCurrentValue(Border.BorderThicknessProperty, new Thickness(0));
            _selectedBorder = null;
            _selectedEvent = null;
        }
        
        e.Handled = true;
    }
    
    private void SelectEvent(TimelineEventViewModel evt, Border border)
    {
        // Remove highlight from previously selected event
        if (_selectedBorder != null && _selectedEvent != null)
        {
            _selectedBorder.SetCurrentValue(Border.BorderBrushProperty, null);
            _selectedBorder.SetCurrentValue(Border.BorderThicknessProperty, new Thickness(0));
        }
        
        // Apply highlight to newly selected event
        _selectedEvent = evt;
        _selectedBorder = border;
        border.SetCurrentValue(Border.BorderBrushProperty, Brushes.White);
        border.SetCurrentValue(Border.BorderThicknessProperty, new Thickness(2));
    }

    private void TimelineCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (_draggedEvent != null && !_isResizing)
        {
            _draggedEvent = null;
            TimelineCanvas.ReleaseMouseCapture();
            
            // End drag and refresh rows only if drag was active
            if (_viewModel != null && _isDragActive)
            {
                _viewModel.IsDragging = false;
                _viewModel.RefreshAfterDrag();
            }
            _isDragActive = false;
        }
    }

    private void TimelineCanvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (_draggedEvent == null || _isResizing || _viewModel == null)
            return;

        var currentPoint = e.GetPosition(TimelineCanvas);
        var deltaX = currentPoint.X - _dragStartPoint.X;
        var deltaY = currentPoint.Y - _dragStartPoint.Y;
        
        // Check if drag threshold exceeded (reduces accidental drags on click)
        if (!_isDragActive)
        {
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distance < DragThreshold)
                return; // Not dragging yet, just a click
                
            // Threshold exceeded - start actual drag
            _isDragActive = true;
            _viewModel.IsDragging = true;
        }
        
        // Horizontal movement (time)
        var deltaMs = (int)(deltaX / _viewModel.PixelsPerMs);
        
        var newStartTime = (uint)Math.Max(0, (int)_dragStartTime + deltaMs);
        newStartTime = _viewModel.SnapValue(newStartTime);
        _draggedEvent.StartTime = newStartTime;
        
        // Vertical movement (row within track)
        // Find the track containing this event and get its row height
        TimelineTrackViewModel? eventTrack = null;
        foreach (var track in _viewModel.Tracks)
        {
            if (track.Events.Contains(_draggedEvent))
            {
                eventTrack = track;
                break;
            }
        }
        
        if (eventTrack != null)
        {
            var rowHeight = eventTrack.RowHeight;
            var relativeY = currentPoint.Y - _dragTrackYOffset;
            var targetRow = Math.Max(0, (int)(relativeY / rowHeight));
            
            // Set preferred row so the assignment algorithm respects it
            _draggedEvent.PreferredRow = targetRow;
            
            // Update visual position during drag
            UpdateEventElementWithRow(_draggedEvent, _dragTrackYOffset, rowHeight, targetRow);
        }
        else
        {
            UpdateEventElement(_draggedEvent);
        }
    }
    
    private void UpdateEventElementWithRow(TimelineEventViewModel evt, double trackYOffset, double rowHeight, int row)
    {
        if (!_eventElements.TryGetValue(evt, out var border) || _viewModel == null)
            return;

        var pixelsPerMs = _viewModel.PixelsPerMs;
        Canvas.SetLeft(border, evt.StartTime * pixelsPerMs);
        Canvas.SetTop(border, trackYOffset + (row * rowHeight) + 2);
        border.Width = Math.Max(40, evt.Duration * pixelsPerMs);
        border.ToolTip = $"{evt.DisplayLabel}\nStart: {evt.StartTime}ms\nDuration: {evt.Duration}ms";
    }

    private void TimelineCanvas_MouseLeave(object sender, MouseEventArgs e)
    {
        // Don't cancel drag on mouse leave - user might be dragging past the edge
    }
    
    private void TrackScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
    {
        if (e.HorizontalChange != 0 && TimeRulerCanvas != null)
        {
            TimeRulerCanvas.SetCurrentValue(MarginProperty, new Thickness(-e.HorizontalOffset, 0, 0, 0));
        }
    }
    
    /// <summary>
    /// Select the corresponding event in the property panel when a timeline item is clicked
    /// </summary>
    private void SelectEventInPropertyPanel(TimelineEventViewModel evt)
    {
        if (_viewModel == null)
            return;

        var eventIndex = evt.EventIndex;
        if (eventIndex < 0)
            return;
            
        NodePropertyUpdateService.RequestEventSelection(eventIndex);
    }
}
