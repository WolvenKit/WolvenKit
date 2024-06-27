using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using DynamicData;
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
    public record LogEntry(string Message, Uri Uri, Brush TextColor);

    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {
        private ScrollViewer _scrollViewer;
        private bool _autoscroll = true;

        public ObservableCollection<object> LogEntries { get; set; } = new();
        
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
                LogEntries.Add(new LogEntry($"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}", LogCodeHelper.GetUrl(infoCode), brush));
            }
            else
            {
                LogEntries.Add(new LogEntry($"[{item.Timestamp.LocalDateTime}] [{level,-9}] {message}", null, brush));
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
            Logtype.Success => Brushes.Green,

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

        private void LogView_OnKeyUp(object sender, KeyEventArgs e)
        {
            // TODO: Implement scrolling and copy
        }

    }
}
