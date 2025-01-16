using System;
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

        public ObservableCollection<LogEntry> LogEntries { get; set; } = new();
        public ObservableCollection<LogEntry> FilteredLogEntries { get; set; } = new();

        public LogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;

            LogEntries.CollectionChanged += LogEntries_CollectionChanged;

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
                    .Subscribe(_ => LogEntries_CollectionChanged(null, null))
                    .DisposeWith(disposables);
            });
        }

        private void LogEntries_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var filtered = LogEntries.Where(log =>
            {
                switch (log.Level)
                {
                    case Logtype.Error:
                        return ViewModel.FilterByLevel[0];
                    case Logtype.Warning:
                        return ViewModel.FilterByLevel[1];
                    case Logtype.Success:
                        return ViewModel.FilterByLevel[2];
                    case Logtype.Normal:
                    case Logtype.Important:
                        return ViewModel.FilterByLevel[3];
                    case Logtype.Debug:
                        return ViewModel.FilterByLevel[4];
                    default:
                        return true;
                }
            });

            FilteredLogEntries.Clear();
            FilteredLogEntries.AddRange(filtered);
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e) => _scrollViewer = (ScrollViewer)sender;

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
            if (item.Properties.TryGetValue(Core.Constants.IsSuccess, out var isSuccessObj) && isSuccessObj is ScalarValue { Value: true })
            {
                level = Logtype.Success;
            }

            var brush = GetBrushForLevel(level);

            var message = item.RenderMessage();
            if (item.Properties.TryGetValue(Core.Constants.InfoCode, out var infoCodeObj) && infoCodeObj is ScalarValue { Value: int infoCode })
            {
                LogEntries.Add(new LogEntry(level, $"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}", LogCodeHelper.GetUrl(infoCode), brush));
            }
            else
            {
                LogEntries.Add(new LogEntry(level, $"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}", null, brush));
            }

            if (_autoscroll)
            {
                _scrollViewer?.ScrollToBottom();
            }
        }

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

        private void ClearAll_Click(object sender, RoutedEventArgs e) => LogEntries.Clear();

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
