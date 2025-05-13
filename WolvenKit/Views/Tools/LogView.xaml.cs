using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;
using DynamicData;
using HandyControl.Tools.Extension;
using MahApps.Metro.Controls;
using Microsoft.Extensions.Logging;
using ReactiveUI;
using Serilog.Events;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Tools
{
    public record LogEntry(Logtype Level, string Message, Uri Uri, Brush TextColor);

    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : ReactiveUserControl<LogViewModel>
    {
        private ScrollViewer _scrollViewer;
        private bool _autoscroll = true;

        public List<LogEntry> LogEntries { get; } = new();
        public ObservableCollection<LogEntry> FilteredLogEntries { get; } = new();
        private readonly List<LogEntry> _logEntryQueue = new();
        private readonly object _logEntryQueueLock = new();
        private readonly DispatcherTimer _dispatcherTimer;
        private const int s_maxFilteredLogEntries = 1000;
        private double _scrollViewerScrollOffset;
        private double SinglePixelUnit = 1 / VisualTreeHelper.GetDpi(Application.Current.MainWindow).DpiScaleX;
        public LogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;

            var sink = Locator.Current.GetService<MySink>();
            _ = sink.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out var _)
                .DisposeMany()
                .Subscribe(OnNext);

            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.FilterByLevel, v => v.FilterErrorButton.Opacity, level => level[0] ? 1.0 : 0.33)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.FilterByLevel, v => v.FilterWarningButton.Opacity, level => level[1] ? 1.0 : 0.33)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.FilterByLevel, v => v.FilterSuccessButton.Opacity, level => level[2] ? 1.0 : 0.33)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.FilterByLevel, v => v.FilterInfoButton.Opacity, level => level[3] ? 1.0 : 0.33)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel, vm => vm.FilterByLevel, v => v.FilterDebugButton.Opacity, level => level[4] ? 1.0 : 0.33)
                    .DisposeWith(disposables);
                this.WhenAnyValue(v => v.ViewModel.FilterByLevel)
                    .Subscribe(_ => LogLevelFilter_Changed(null, null))
                    .DisposeWith(disposables);
            });
            
            _dispatcherTimer = new DispatcherTimer(DispatcherPriority.Input) { Interval = TimeSpan.FromMilliseconds(100) };
            _dispatcherTimer.Tick += (_, _) => AddLogsToView();
            _dispatcherTimer.Start();
        }

        private bool ShouldInclude(LogEntry entry)
        {
            return entry.Level switch
            {
                Logtype.Error => ViewModel.FilterByLevel[0],
                Logtype.Warning => ViewModel.FilterByLevel[1],
                Logtype.Success => ViewModel.FilterByLevel[2],
                Logtype.Normal or Logtype.Important => ViewModel.FilterByLevel[3],
                Logtype.Debug => ViewModel.FilterByLevel[4],
                _ => true
            };
        }
        
        private void LogLevelFilter_Changed(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var tempFiltered = LogEntries.Where(ShouldInclude).TakeLast(s_maxFilteredLogEntries);
            FilteredLogEntries.Clear();
            FilteredLogEntries.AddRange(tempFiltered);
            if (_autoscroll)
            {
                ScrollToBottom();
            }
        }
        
        private void LogView_Loaded(object sender, RoutedEventArgs e)
        {
            _scrollViewer = LogListBox.FindChild<ScrollViewer>();
            _scrollViewer.ScrollChanged += OnScrollChanged;
        }

        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalOffset.Equals(_scrollViewerScrollOffset))
            {
                return;
            }
            _scrollViewerScrollOffset = e.VerticalOffset;
            
            Console.WriteLine($"ScrollViewer: {e.VerticalOffset} {e.ExtentHeight} {e.ViewportHeight} {e.VerticalChange}");
            if (e.VerticalOffset == 0)
            {
                var previousTopItem = FilteredLogEntries.First();
                int filteredTopIndex = 0;
                if (FilteredLogEntries.Count != 0 && LogEntries.Count != 0)
                {
                    filteredTopIndex = LogEntries.IndexOf(FilteredLogEntries.First());
                }
                var earlierLogs = LogEntries.Where(ShouldInclude).Take(filteredTopIndex);
                FilteredLogEntries.AddOrInsertRange(earlierLogs.Reverse()
                    .Take(s_maxFilteredLogEntries)
                    .Reverse(), 0);
                FilteredLogEntries.RemoveMany(FilteredLogEntries.Skip(s_maxFilteredLogEntries * 2));
                if (earlierLogs.Count() != 0)
                {
                    LogListBox.Dispatcher.BeginInvoke(new Action(() => _scrollViewer.ScrollToVerticalOffset(_scrollViewer.ScrollableHeight - SinglePixelUnit)), DispatcherPriority.Background);
                    LogListBox.Dispatcher.BeginInvoke(new Action(() => LogListBox.ScrollIntoView(previousTopItem)), DispatcherPriority.Background);   
                }
            }
            
            if (e.VerticalOffset.Equals(_scrollViewer.ScrollableHeight))
            {
                var previousBottomItem = FilteredLogEntries.Last();
                int filteredBottomIndex = 0;
                if (FilteredLogEntries.Count != 0 && LogEntries.Count != 0)
                {
                    filteredBottomIndex = LogEntries.IndexOf(FilteredLogEntries.Last());
                }
                var laterLogs = LogEntries.Where(ShouldInclude).Skip(filteredBottomIndex + 1).Take(s_maxFilteredLogEntries);
                FilteredLogEntries.AddRange(laterLogs);
                FilteredLogEntries.RemoveMany(FilteredLogEntries.Reverse().Skip(s_maxFilteredLogEntries * 2));
                if (laterLogs.Count() != 0)
                {
                    LogListBox.Dispatcher.BeginInvoke(new Action(() => _scrollViewer.ScrollToVerticalOffset(SinglePixelUnit)), DispatcherPriority.Background);
                    LogListBox.Dispatcher.BeginInvoke(new Action(() => LogListBox.ScrollIntoView(previousBottomItem)), DispatcherPriority.Background);
                }
                
            }
        }
        
        private void OnNext(IChangeSet<LogEvent> obj)
        {
            foreach (var change in obj)
            {
                switch (change.Reason)
                {
                    case ListChangeReason.Add:
                        var item = change.Item.Current;
                        AddLog(item);
                        break;
                    case ListChangeReason.AddRange:
                        foreach (var logEntry in change.Range)
                        {
                            AddLog(logEntry);
                        }
                        break;
                    case ListChangeReason.Replace:
                    case ListChangeReason.Remove:
                    case ListChangeReason.RemoveRange:
                    case ListChangeReason.Refresh:
                    case ListChangeReason.Moved:
                    case ListChangeReason.Clear:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void AddLog(LogEvent item)
        {
            var level = ToLogtype(item.Level);
            if (item.Properties.TryGetValue(Core.Constants.IsSuccess, out var isSuccessObj) &&
                isSuccessObj is ScalarValue { Value: true })
            {
                level = Logtype.Success;
            }

            var brush = GetBrushForLevel(level);

            var message = item.RenderMessage();
            lock (_logEntryQueueLock)
            {
                if (item.Properties.TryGetValue(Core.Constants.InfoCode, out var infoCodeObj) &&
                    infoCodeObj is ScalarValue { Value: int infoCode })
                {
                    _logEntryQueue.Add(new LogEntry(level, $"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}",
                        LogCodeHelper.GetUrl(infoCode), brush));
                }
                else
                {
                    _logEntryQueue.Add(new LogEntry(level, $"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}",
                        null, brush));
                }
            }
        }

        private void AddLogsToView()
        {
            if (_logEntryQueue.Count == 0)
            {
                return;
            }
            
            var filtered = _logEntryQueue.Where(ShouldInclude);
            if (_autoscroll)
            {
                ScrollToTrueBottom();
            }
            lock (_logEntryQueueLock)
            {
                FilteredLogEntries.AddRange(filtered);
                LogEntries.AddRange(_logEntryQueue);
                _logEntryQueue.Clear();
                
                while (FilteredLogEntries.Count > s_maxFilteredLogEntries)
                {
                    FilteredLogEntries.RemoveAt(0);
                }
            }
            if (_autoscroll)
            {
                ScrollToBottom();
            }
        }

        private void ScrollToTrueBottom()
        {
            if (FilteredLogEntries.Count == 0 || LogEntries.Count == 0)
            {
                return;
            }
            if (FilteredLogEntries.Last().Message != LogEntries.Last().Message)
            {
                FilteredLogEntries.Clear();
                FilteredLogEntries.AddRange(LogEntries.Where(ShouldInclude).TakeLast(s_maxFilteredLogEntries));
            }

            ScrollToBottom();
        }

        private void ScrollToBottom() => _scrollViewer?.ScrollToVerticalOffset(_scrollViewer.ScrollableHeight - SinglePixelUnit);
        
        
        private static Logtype ToLogtype(LogEventLevel level) =>
            level switch
            {
                LogEventLevel.Verbose => Logtype.Debug,
                LogEventLevel.Debug => Logtype.Debug,
                LogEventLevel.Information => Logtype.Important,
                LogEventLevel.Warning => Logtype.Warning,
                LogEventLevel.Error => Logtype.Error,
                LogEventLevel.Fatal => Logtype.Error,
                _ => Logtype.Normal,
            };

        private static Brush GetBrushForLevel(Logtype level) => level switch
        {
            Logtype.Normal or Logtype.Important => Brushes.LightGray,
            Logtype.Error => (Brush)Application.Current.FindResource("WolvenKitRed"),
            Logtype.Warning => (Brush)Application.Current.FindResource("WolvenKitYellow"),
            Logtype.Debug => (Brush)Application.Current.FindResource("WolvenKitPurple"),
            Logtype.Success => (Brush)Application.Current.FindResource("WolvenKitGreen"),

            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null),
        };

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            LogEntries.Clear();
            FilteredLogEntries.Clear();
        }

        private void OpenLogFolder_Click(object sender, RoutedEventArgs e) =>
            Process.Start(new ProcessStartInfo(ISettingsManager.GetLogsDir()) { UseShellExecute = true });

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e) =>
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });

        private void AutoScroll_OnChecked(object sender, RoutedEventArgs e) => _autoscroll = true;

        private void AutoScroll_OnUnchecked(object sender, RoutedEventArgs e) => _autoscroll = false;

        private void CopyLine_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not Button { Tag: string tag })
            {
                return;
            }

            Clipboard.SetText($"```{tag}```");
        }

        private void ScrollToBottom_OnClick(object sender, RoutedEventArgs e) => ScrollToTrueBottom();

        private void ScrollViewer_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.PageUp)
            {
                _scrollViewer?.PageUp();
            }
            else if (e.Key == Key.PageDown)
            {
                _scrollViewer?.PageDown();
            }
        }

        private void LogView_OnKeyUp(object sender, KeyEventArgs e)
        {
            // TODO: Implement scrolling and copy
        }

        private void LogView_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var breakpoint = (double)FindResource("WolvenKitLogBreakpointWidth");

            if (e.NewSize.Width > breakpoint && LogLevelFilter.Orientation != Orientation.Horizontal)
            {
                LogPanelButtons.Children.Remove(LogLevelFilter);
                LogViewHeader.Children.Add(LogLevelFilter);

                LogLevelFilter.SetCurrentValue(Grid.ColumnProperty, 0);
                LogLevelFilter.SetCurrentValue(HorizontalAlignmentProperty, HorizontalAlignment.Left);
                LogLevelFilter.SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Center);
                LogLevelFilter.SetCurrentValue(StackPanel.OrientationProperty, Orientation.Horizontal);
                ChangeMargin((Thickness)FindResource("WolvenKitMarginTinyRight"));
            }
            else if (e.NewSize.Width <= breakpoint && LogLevelFilter.Orientation != Orientation.Vertical)
            {
                LogViewHeader.Children.Remove(LogLevelFilter);
                LogPanelButtons.Children.Add(LogLevelFilter);

                LogLevelFilter.ClearValue(Grid.ColumnProperty);
                LogLevelFilter.SetCurrentValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
                LogLevelFilter.SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Top);
                LogLevelFilter.SetCurrentValue(StackPanel.OrientationProperty, Orientation.Vertical);
                ChangeMargin((Thickness)FindResource("WolvenKitMarginTinyTop"));
            }

            return;

            void ChangeMargin(Thickness margin)
            {
                LogLevelFilter.FindChildren<Button>().ForEach(button => button.SetCurrentValue(MarginProperty, margin));
            }
        }
    }
}
