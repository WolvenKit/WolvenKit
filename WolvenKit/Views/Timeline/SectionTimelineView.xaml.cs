#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.Timeline;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Timeline;

namespace WolvenKit.Views.Timeline;

/// <summary>
/// Code behind for SectionTimelineView - handles rendering and mouse interactions
/// </summary>
public partial class SectionTimelineView : UserControl
{
    private SectionTimelineViewModel? _viewModel;
    private readonly Dictionary<TimelineEvent, Border> _eventElements = new();
    
    private TimelineEvent? _draggedEvent;
    private bool _isResizing;
    private bool _isDragActive;
    private Point _dragStartPoint;
    private uint _dragStartTime;
    private uint _dragStartDuration;
    private int _dragStartRow;
    private double _dragTrackYOffset;
    
    private TimelineEvent? _selectedEvent;
    private Border? _selectedBorder;
    private Border? _activeResizeGrip;
    private Border? _sectionEndHandle;
    private Line? _rulerSectionEndLine;
    private Line? _rulerSectionEndCap;
    private Line? _timelineSectionEndLine;
    private Rectangle? _overrunRegion;
    private bool _isRenderPending;
    private bool _isDraggingSectionEnd;
    private bool _isSectionEndHovered;
    private bool _sectionEndDragHasChanged;
    private Point _sectionEndDragStartPoint;
    private uint _sectionEndDragStartDuration;
    private const double DragThreshold = 5.0;

    public SectionTimelineView()
    {
        InitializeComponent();
        
        _viewModel = new SectionTimelineViewModel();
        DataContext = _viewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        
        Loaded += OnLoaded;
        SizeChanged += OnSizeChanged;
        
        PreviewKeyDown += OnPreviewKeyDown;
        PreviewMouseLeftButtonUp += OnGlobalMouseLeftButtonUp;
    }
    
    private void OnGlobalMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (_isDraggingSectionEnd)
        {
            FinishSectionEndDrag();
            e.Handled = true;
            return;
        }

        if (_isResizing)
        {
            _draggedEvent = null;
            _isResizing = false;
            _activeResizeGrip?.ReleaseMouseCapture();
            _activeResizeGrip = null;
            
            if (_viewModel != null)
            {
                _viewModel.IsDragging = false;
                _viewModel.RefreshAfterDrag();
            }
        }
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
        QueueRenderTimeline();
    }

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
        UpdateViewportWidth();
        if (!_isDraggingSectionEnd)
        {
            QueueRenderTimeline();
        }
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
        if (_draggedEvent != null || _isResizing || _isDraggingSectionEnd)
        {
            return;
        }

        if (e.PropertyName is nameof(SectionTimelineViewModel.HasSectionNode) 
            or nameof(SectionTimelineViewModel.PixelsPerMs)
            or nameof(SectionTimelineViewModel.SectionDuration)
            or nameof(SectionTimelineViewModel.TimelineDuration)
            or nameof(SectionTimelineViewModel.Tracks))
        {
            QueueRenderTimeline();
        }
    }

    private void QueueRenderTimeline()
    {
        if (_isRenderPending)
        {
            return;
        }

        _isRenderPending = true;
        Dispatcher.BeginInvoke(new Action(() =>
        {
            _isRenderPending = false;
            if (!_isDraggingSectionEnd)
            {
                RenderTimeline();
            }
        }));
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
        {
            return;
        }

        TimeRulerCanvas.Children.Clear();
        _rulerSectionEndLine = null;
        _rulerSectionEndCap = null;
        _sectionEndHandle = null;

        var duration = _viewModel.TimelineDuration;
        var pixelsPerMs = _viewModel.PixelsPerMs;
        
        if (pixelsPerMs == 0)
        {
            return;
        }

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

        RenderRulerSectionEndMarker();
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
        {
            return $"{ms}ms";
        }
        
        var seconds = ms / 1000.0;
        return $"{seconds:F1}s";
    }

    private void RenderEvents()
    {
        if (TimelineCanvas == null || _viewModel == null)
        {
            return;
        }

        TimelineCanvas.Children.Clear();
        _eventElements.Clear();
        _timelineSectionEndLine = null;
        _overrunRegion = null;

        var pixelsPerMs = _viewModel.PixelsPerMs;
        double yOffset = 0;

        RenderGridLines();
        RenderOverrunRegion();

        foreach (var track in _viewModel.Tracks)
        {
            var trackHeight = _viewModel.GetTrackHeight(track);
            var rowHeight = _viewModel.GetRowHeight();

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

            foreach (var evt in track.Events)
            {
                var eventYOffset = yOffset + (evt.Row * rowHeight) + 2;
                var eventElement = CreateEventElement(evt, eventYOffset, rowHeight);
                TimelineCanvas.Children.Add(eventElement);
                _eventElements[evt] = eventElement;
            }

            yOffset += trackHeight;
        }

        RenderTimelineSectionEndMarker(yOffset);

        TimelineCanvas.SetCurrentValue(HeightProperty, yOffset);
    }

    private void RenderOverrunRegion()
    {
        if (_viewModel == null || !_viewModel.IsSectionDurationTooShort)
        {
            return;
        }

        var sectionEndX = _viewModel.TimeToPixels(_viewModel.SectionDuration);
        _overrunRegion = new Rectangle
        {
            Width = Math.Max(0, _viewModel.TimelineWidth - sectionEndX),
            Height = _viewModel.TotalTrackHeight,
            Fill = new SolidColorBrush(Color.FromArgb(38, 223, 41, 53)),
            IsHitTestVisible = false
        };

        Canvas.SetLeft(_overrunRegion, sectionEndX);
        Canvas.SetTop(_overrunRegion, 0);
        TimelineCanvas.Children.Add(_overrunRegion);
    }

    private void RenderRulerSectionEndMarker()
    {
        if (_viewModel == null)
        {
            return;
        }

        var sectionEndX = _viewModel.TimeToPixels(_viewModel.SectionDuration);
        var markerBrush = GetSectionEndMarkerBrush();
        _rulerSectionEndLine = new Line
        {
            X1 = sectionEndX,
            X2 = sectionEndX,
            Y1 = 0,
            Y2 = 24,
            Stroke = markerBrush,
            StrokeThickness = _viewModel.IsSectionDurationTooShort ? 2 : 1,
            IsHitTestVisible = false
        };

        _rulerSectionEndCap = new Line
        {
            X1 = sectionEndX - 8,
            X2 = sectionEndX,
            Y1 = 2,
            Y2 = 2,
            Stroke = markerBrush,
            StrokeThickness = 2,
            IsHitTestVisible = false
        };

        _sectionEndHandle = new Border
        {
            Width = 16,
            Height = 24,
            Background = Brushes.Transparent,
            Cursor = Cursors.SizeWE,
            ToolTip = $"Section end: {_viewModel.SectionDuration}ms. Drag to adjust."
        };
        _sectionEndHandle.MouseLeftButtonDown += SectionEndHandle_MouseLeftButtonDown;
        _sectionEndHandle.MouseMove += SectionEndHandle_MouseMove;
        _sectionEndHandle.MouseEnter += SectionEndHandle_MouseEnter;
        _sectionEndHandle.MouseLeave += SectionEndHandle_MouseLeave;

        Canvas.SetLeft(_sectionEndHandle, Math.Max(0, sectionEndX - 12));
        Canvas.SetTop(_sectionEndHandle, 0);
        Panel.SetZIndex(_rulerSectionEndLine, 10);
        Panel.SetZIndex(_rulerSectionEndCap, 10);
        Panel.SetZIndex(_sectionEndHandle, 11);
        TimeRulerCanvas.Children.Add(_rulerSectionEndLine);
        TimeRulerCanvas.Children.Add(_rulerSectionEndCap);
        TimeRulerCanvas.Children.Add(_sectionEndHandle);
    }

    private void RenderTimelineSectionEndMarker(double height)
    {
        if (_viewModel == null || height <= 0)
        {
            return;
        }

        var sectionEndX = _viewModel.TimeToPixels(_viewModel.SectionDuration);
        _timelineSectionEndLine = new Line
        {
            X1 = sectionEndX,
            X2 = sectionEndX,
            Y1 = 0,
            Y2 = height,
            Stroke = GetSectionEndMarkerBrush(),
            StrokeThickness = _viewModel.IsSectionDurationTooShort ? 2 : 1,
            IsHitTestVisible = false
        };

        Panel.SetZIndex(_timelineSectionEndLine, 10);
        TimelineCanvas.Children.Add(_timelineSectionEndLine);
    }

    private Brush GetSectionEndMarkerBrush()
    {
        if ((_isDraggingSectionEnd || _isSectionEndHovered) &&
            TryFindResource("WolvenKitYellow") is Brush highlightBrush)
        {
            return highlightBrush;
        }

        return new SolidColorBrush(_viewModel?.IsSectionDurationTooShort == true
            ? Color.FromRgb(223, 41, 53)
            : Color.FromRgb(120, 120, 120));
    }

    private void SectionEndHandle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (_viewModel == null || sender is not Border handle || _viewModel.PixelsPerMs <= 0)
        {
            return;
        }

        _isDraggingSectionEnd = true;
        _sectionEndDragHasChanged = false;
        _sectionEndDragStartPoint = e.GetPosition(TimeRulerCanvas);
        _sectionEndDragStartDuration = _viewModel.SectionDuration;
        _viewModel.IsDragging = true;
        handle.CaptureMouse();
        UpdateSectionEndMarkerBrushes();
        e.Handled = true;
    }

    private void SectionEndHandle_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_isDraggingSectionEnd || _viewModel == null || _viewModel.PixelsPerMs <= 0)
        {
            return;
        }

        var currentPoint = e.GetPosition(TimeRulerCanvas);
        var deltaMs = (currentPoint.X - _sectionEndDragStartPoint.X) / _viewModel.PixelsPerMs;
        var rawDuration = Math.Clamp(_sectionEndDragStartDuration + deltaMs, 0, uint.MaxValue);
        var newDuration = _viewModel.GetSnappedSectionDuration((uint)Math.Round(rawDuration));

        if (newDuration == _viewModel.SectionDuration)
        {
            return;
        }

        _sectionEndDragHasChanged = true;
        _viewModel.PreviewSectionDuration(newDuration);
        UpdateSectionEndMarkerVisuals();
        e.Handled = true;
    }

    private void SectionEndHandle_MouseEnter(object sender, MouseEventArgs e)
    {
        _isSectionEndHovered = true;
        UpdateSectionEndMarkerBrushes();
    }

    private void SectionEndHandle_MouseLeave(object sender, MouseEventArgs e)
    {
        _isSectionEndHovered = false;
        UpdateSectionEndMarkerBrushes();
    }

    private void FinishSectionEndDrag()
    {
        if (!_isDraggingSectionEnd || _viewModel == null)
        {
            return;
        }

        _isDraggingSectionEnd = false;
        _sectionEndHandle?.ReleaseMouseCapture();
        _viewModel.IsDragging = false;

        if (_sectionEndDragHasChanged)
        {
            _viewModel.SetSectionDuration(_viewModel.SectionDuration);
        }

        _sectionEndDragHasChanged = false;
        QueueRenderTimeline();
    }

    private void UpdateSectionEndMarkerVisuals()
    {
        if (_viewModel == null)
        {
            return;
        }

        var sectionEndX = _viewModel.TimeToPixels(_viewModel.SectionDuration);

        if (_rulerSectionEndLine != null)
        {
            _rulerSectionEndLine.SetCurrentValue(Line.X1Property, sectionEndX);
            _rulerSectionEndLine.SetCurrentValue(Line.X2Property, sectionEndX);
        }

        if (_rulerSectionEndCap != null)
        {
            _rulerSectionEndCap.SetCurrentValue(Line.X1Property, sectionEndX - 8);
            _rulerSectionEndCap.SetCurrentValue(Line.X2Property, sectionEndX);
        }

        if (_timelineSectionEndLine != null)
        {
            _timelineSectionEndLine.SetCurrentValue(Line.X1Property, sectionEndX);
            _timelineSectionEndLine.SetCurrentValue(Line.X2Property, sectionEndX);
        }

        if (_sectionEndHandle != null)
        {
            Canvas.SetLeft(_sectionEndHandle, Math.Max(0, sectionEndX - 12));
            _sectionEndHandle.SetCurrentValue(ToolTipProperty, GetSectionEndToolTip());
        }

        if (_overrunRegion != null)
        {
            _overrunRegion.SetCurrentValue(VisibilityProperty,
                _viewModel.IsSectionDurationTooShort ? Visibility.Visible : Visibility.Collapsed);
            Canvas.SetLeft(_overrunRegion, sectionEndX);
            _overrunRegion.SetCurrentValue(WidthProperty, Math.Max(0, _viewModel.TimelineWidth - sectionEndX));
        }

        UpdateSectionEndMarkerBrushes();
    }

    private void UpdateSectionEndMarkerBrushes()
    {
        var brush = GetSectionEndMarkerBrush();
        var isEmphasized = _isDraggingSectionEnd || _isSectionEndHovered ||
                           _viewModel?.IsSectionDurationTooShort == true;
        var thickness = isEmphasized ? 2.0 : 1.0;

        if (_rulerSectionEndLine != null)
        {
            _rulerSectionEndLine.SetCurrentValue(Shape.StrokeProperty, brush);
            _rulerSectionEndLine.SetCurrentValue(Shape.StrokeThicknessProperty, thickness);
        }

        if (_rulerSectionEndCap != null)
        {
            _rulerSectionEndCap.SetCurrentValue(Shape.StrokeProperty, brush);
        }

        if (_timelineSectionEndLine != null)
        {
            _timelineSectionEndLine.SetCurrentValue(Shape.StrokeProperty, brush);
            _timelineSectionEndLine.SetCurrentValue(Shape.StrokeThicknessProperty, thickness);
        }
    }

    private string GetSectionEndToolTip()
    {
        if (_viewModel == null)
        {
            return "Section end";
        }

        return _viewModel.LatestEventEndTime > 0
            ? $"Section end: {_viewModel.SectionDuration}ms. Drag to adjust (minimum {_viewModel.LatestEventEndTime}ms)."
            : $"Section end: {_viewModel.SectionDuration}ms. Drag to adjust.";
    }

    private void RenderGridLines()
    {
        if (_viewModel == null)
            return;

        var pixelsPerMs = _viewModel.PixelsPerMs;
        var duration = _viewModel.TimelineDuration;
        var totalHeight = _viewModel.TotalTrackHeight;
        
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

    private Border CreateEventElement(TimelineEvent evt, double yOffset, double trackHeight)
    {
        const double eventHeight = 50;
        var pixelsPerMs = _viewModel!.PixelsPerMs;
        var x = evt.StartTime * pixelsPerMs;
        var width = Math.Max(80, evt.Duration * pixelsPerMs);
        var eventColor = TimelineColorHelper.GetColorForEventType(evt.EventType);
        var titleLine = evt.TitleLine;
        var detailsLine = evt.DetailsLine;
        var displayLabel = $"{titleLine} {detailsLine}".Trim();

        var border = new Border
        {
            Background = new SolidColorBrush(eventColor),
            CornerRadius = new CornerRadius(4),
            Height = eventHeight,
            MinWidth = 80,
            Cursor = Cursors.SizeAll,
            Tag = evt,
            ToolTip = $"{displayLabel}\nStart: {evt.StartTime}ms\nDuration: {evt.Duration}ms"
        };

        var stackPanel = new StackPanel
        {
            Margin = new Thickness(8, 6, 12, 6),
            VerticalAlignment = VerticalAlignment.Center
        };

        var titleLabel = new TextBlock
        {
            Text = titleLine,
            Foreground = Brushes.White,
            FontWeight = FontWeights.SemiBold,
            TextTrimming = TextTrimming.CharacterEllipsis
        };
        titleLabel.SetResourceReference(TextBlock.FontSizeProperty, "WolvenKitFontSubTitle");

        var detailsLabel = new TextBlock
        {
            Text = detailsLine,
            Foreground = new SolidColorBrush(Color.FromArgb(200, 255, 255, 255)),
            TextTrimming = TextTrimming.CharacterEllipsis
        };
        detailsLabel.SetResourceReference(TextBlock.FontSizeProperty, "WolvenKitFontAltTitle");

        stackPanel.Children.Add(titleLabel);
        if (!string.IsNullOrEmpty(detailsLine))
        {
            stackPanel.Children.Add(detailsLabel);
        }

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

        resizeGrip.MouseLeftButtonDown += (s, e) =>
        {
            _isResizing = true;
            _draggedEvent = evt;
            _activeResizeGrip = resizeGrip;
            _dragStartPoint = e.GetPosition(TimelineCanvas);
            _dragStartDuration = evt.Duration;
            if (_viewModel != null)
            {
                _viewModel.IsDragging = true;
            }
            resizeGrip.CaptureMouse();
            e.Handled = true;
        };

        resizeGrip.MouseLeftButtonUp += (s, e) =>
        {
            if (_isResizing)
            {
                _isResizing = false;
                _draggedEvent = null;
                _activeResizeGrip = null;
                resizeGrip.ReleaseMouseCapture();
                
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

    private void UpdateEventElement(TimelineEvent evt)
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
        {
            return;
        }

        Focus();
        
        var point = e.GetPosition(TimelineCanvas);
        
        // Find clicked event
        var hitElement = TimelineCanvas.InputHitTest(point) as DependencyObject;
        while (hitElement != null && hitElement != TimelineCanvas)
        {
            if (hitElement is Border border && border.Tag is TimelineEvent evt)
            {
                var innerHit = border.InputHitTest(e.GetPosition(border)) as FrameworkElement;
                if (innerHit?.Tag as string == "resize")
                {
                    return;
                }
                
                var clickX = e.GetPosition(border).X;
                var resizeZone = Math.Max(20, border.ActualWidth * 0.3);
                if (clickX > border.ActualWidth - resizeZone && evt.Duration < 500)
                {
                    var eventRightEdge = (evt.StartTime + evt.Duration) * _viewModel.PixelsPerMs;
                    _isResizing = true;
                    _isDragActive = false;
                    _draggedEvent = evt;
                    _dragStartPoint = new Point(eventRightEdge, point.Y);
                    _dragStartDuration = evt.Duration;
                    _dragStartTime = evt.StartTime;
                    if (_viewModel != null)
                    {
                        _viewModel.IsDragging = true;
                    }
                    TimelineCanvas.CaptureMouse();
                    e.Handled = true;
                    return;
                }

                SelectEvent(evt, border);

                _draggedEvent = evt;
                _dragStartPoint = point;
                _dragStartTime = evt.StartTime;
                _dragStartRow = evt.Row;
                _isDragActive = false;
                
                _dragTrackYOffset = 0;
                foreach (var track in _viewModel.Tracks)
                {
                    if (track.Events.Contains(evt))
                    {
                        break;
                    }
                    _dragTrackYOffset += _viewModel.GetTrackHeight(track);
                }
                
                TimelineCanvas.CaptureMouse();
                
                SelectEventInPropertyPanel(evt);
                
                e.Handled = true;
                return;
            }
            hitElement = VisualTreeHelper.GetParent(hitElement);
        }
        
        if (_selectedBorder != null && _selectedEvent != null)
        {
            _selectedBorder.SetCurrentValue(Border.BorderBrushProperty, null);
            _selectedBorder.SetCurrentValue(Border.BorderThicknessProperty, new Thickness(0));
            _selectedBorder = null;
            _selectedEvent = null;
        }
        
        e.Handled = true;
    }
    
    private void SelectEvent(TimelineEvent evt, Border border)
    {
        if (_selectedBorder != null && _selectedEvent != null)
        {
            _selectedBorder.SetCurrentValue(Border.BorderBrushProperty, null);
            _selectedBorder.SetCurrentValue(Border.BorderThicknessProperty, new Thickness(0));
        }
        
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
        if (_draggedEvent == null || _viewModel == null)
        {
            return;
        }
        
        if (_isResizing)
        {
            var resizePoint = e.GetPosition(TimelineCanvas);
            var resizeDeltaX = resizePoint.X - _dragStartPoint.X;
            var resizeDeltaMs = (int)(resizeDeltaX / _viewModel.PixelsPerMs);
            
            var newDuration = (uint)Math.Max(0, (int)_dragStartDuration + resizeDeltaMs);
            newDuration = _viewModel.SnapValue(newDuration);
            
            if (newDuration > 0)
            {
                _draggedEvent.Duration = newDuration;
                UpdateEventElement(_draggedEvent);
            }
            return;
        }

        var currentPoint = e.GetPosition(TimelineCanvas);
        var deltaX = currentPoint.X - _dragStartPoint.X;
        var deltaY = currentPoint.Y - _dragStartPoint.Y;
        
        if (!_isDragActive)
        {
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distance < DragThreshold)
            {
                return;
            }
                
            _isDragActive = true;
            _viewModel.IsDragging = true;
        }
        
        if (_isResizing)
        {
            return;
        }
        
        var deltaMs = (int)(deltaX / _viewModel.PixelsPerMs);
        
        var newStartTime = (uint)Math.Max(0, (int)_dragStartTime + deltaMs);
        newStartTime = _viewModel.SnapValue(newStartTime);
        _draggedEvent.StartTime = newStartTime;
        
        TimelineTrack? eventTrack = null;
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
            var rowHeight = _viewModel.GetRowHeight();
            var relativeY = currentPoint.Y - _dragTrackYOffset;
            var targetRow = Math.Max(0, (int)(relativeY / rowHeight));
            
            _draggedEvent.PreferredRow = targetRow;
            UpdateEventElementWithRow(_draggedEvent, _dragTrackYOffset, rowHeight, targetRow);
        }
        else
        {
            UpdateEventElement(_draggedEvent);
        }
    }
    
    private void UpdateEventElementWithRow(TimelineEvent evt, double trackYOffset, double rowHeight, int row)
    {
        if (!_eventElements.TryGetValue(evt, out var border) || _viewModel == null)
        {
            return;
        }

        var pixelsPerMs = _viewModel.PixelsPerMs;
        Canvas.SetLeft(border, evt.StartTime * pixelsPerMs);
        Canvas.SetTop(border, trackYOffset + (row * rowHeight) + 2);
        border.Width = Math.Max(40, evt.Duration * pixelsPerMs);
        border.ToolTip = $"{evt.DisplayLabel}\nStart: {evt.StartTime}ms\nDuration: {evt.Duration}ms";
    }

    private void TimelineCanvas_MouseLeave(object sender, MouseEventArgs e)
    {
    }
    
    private void TrackScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
    {
        if (e.HorizontalChange != 0 && TimeRulerCanvas != null)
        {
            TimeRulerCanvas.SetCurrentValue(MarginProperty, new Thickness(-e.HorizontalOffset, 0, 0, 0));
        }
    }
    
    private void SelectEventInPropertyPanel(TimelineEvent evt)
    {
        if (_viewModel == null)
        {
            return;
        }

        var eventIndex = evt.EventIndex;
        if (eventIndex < 0)
        {
            return;
        }
            
        NodePropertyUpdateService.RequestEventSelection(eventIndex);
    }
}
