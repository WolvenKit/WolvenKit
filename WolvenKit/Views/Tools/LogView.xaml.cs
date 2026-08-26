using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using DynamicData;
using HandyControl.Tools.Extension;
using MahApps.Metro.Controls;
using ReactiveUI;
using Serilog.Events;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Core.Exceptions;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Tools
{
    public record LogEntry(LogType Level, string Message, Uri Uri, Brush TextColor);

    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : ReactiveUserControl<LogViewModel>
    {
        private ScrollViewer _scrollViewer;
        private bool _autoscroll = true;

        public ObservableCollection<LogEntry> LogEntries { get; set; } = new();
        public ObservableCollection<LogEntry> FilteredLogEntries { get; set; } = new();

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
                    .Subscribe(_ => RebuildFilteredEntries())
                    .DisposeWith(disposables);
            });
        }

        private bool PassesFilter(LogEntry log) =>
            ViewModel is null || log.Level switch
            {
                LogType.Error => ViewModel.FilterByLevel[0],
                LogType.Warning => ViewModel.FilterByLevel[1],
                LogType.Success => ViewModel.FilterByLevel[2],
                LogType.Normal or LogType.Important => ViewModel.FilterByLevel[3],
                LogType.Debug => ViewModel.FilterByLevel[4],
                _ => true
            };

        /// <summary>
        /// Re-applies the level filter across every entry. Only for when the filter itself
        /// changes. Appending a single entry must not come through here.
        /// </summary>
        private void RebuildFilteredEntries()
        {
            FilteredLogEntries.Clear();
            FilteredLogEntries.AddRange(LogEntries.Where(PassesFilter));
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e) => _scrollViewer = (ScrollViewer)sender;

        private void OnNext(IChangeSet<LogEvent> obj)
        {
            var countBefore = FilteredLogEntries.Count;

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

            if (_autoscroll && FilteredLogEntries.Count != countBefore)
            {
                _scrollViewer?.ScrollToBottom();
            }
        }

        private void AddLog(LogEvent item)
        {
            var level = ToLogtype(item.Level);
            if (item.Properties.TryGetValue(Core.Constants.IsSuccess, out var isSuccessObj) && isSuccessObj is ScalarValue { Value: true })
            {
                level = LogType.Success;
            }

            var brush = GetBrushForLevel(level);

            var message = item.RenderMessage();
            var uri = item.Properties.TryGetValue(Core.Constants.InfoCode, out var infoCodeObj)
                      && infoCodeObj is ScalarValue { Value: int infoCode }
                ? LogCodeHelper.GetUrl(infoCode)
                : null;

            var entry = new LogEntry(level, $"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}", uri, brush);
            LogEntries.Add(entry);

            if (PassesFilter(entry))
            {
                FilteredLogEntries.Add(entry);
            }
        }

        private static LogType ToLogtype(LogEventLevel level) =>
            level switch
            {
                LogEventLevel.Verbose => LogType.Debug,
                LogEventLevel.Debug => LogType.Debug,
                LogEventLevel.Information => LogType.Important,
                LogEventLevel.Warning => LogType.Warning,
                LogEventLevel.Error => LogType.Error,
                LogEventLevel.Fatal => LogType.Error,
                _ => LogType.Normal,
            };

        private static Brush GetBrushForLevel(LogType level) => level switch
        {
            LogType.Normal or LogType.Important => Brushes.LightGray,
            LogType.Error => (Brush)Application.Current.FindResource("WolvenKitRed"),
            LogType.Warning => (Brush)Application.Current.FindResource("WolvenKitYellow"),
            LogType.Debug => (Brush)Application.Current.FindResource("WolvenKitPurple"),
            LogType.Success => (Brush)Application.Current.FindResource("WolvenKitGreen"),

            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null),
        };

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            LogEntries.Clear();
            FilteredLogEntries.Clear();
        }

        private void OpenLogFolder_Click(object sender, RoutedEventArgs e)
        {
            // regular click: open log folder
            if (!ModifierViewStateService.IsShiftBeingHeld)
            {
                Process.Start(new ProcessStartInfo(ISettingsManager.GetLogsDir()) { UseShellExecute = true });
                return;
            }

            // should never happen, but better safe than sorry
            if (FileHelper.GetMostRecentlyChangedFile(Path.Combine(ISettingsManager.GetAppData(), "Logs"), "*.txt") is
                not FileInfo fI)
            {
                return;
            }

            // shift-click: open most recent log file
            try
            {
                Process.Start(new ProcessStartInfo(fI.FullName) { UseShellExecute = true });
            }
            catch (Exception)
            {
                throw new WolvenKitException(0, $"Failed to open log file {fI.FullName}");
            }
        }

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

        private void ScrollToBottom_OnClick(object sender, RoutedEventArgs e) => _scrollViewer?.ScrollToBottom();

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
