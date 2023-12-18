using System;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;
using DynamicData;
using ReactiveUI;
using Serilog.Events;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {
        private const uint s_logLen_cull_at = 1000;
        private const int s_logLen_cull_to = 500;
        
        public LogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;

            var sink = Locator.Current.GetService<MySink>();
            var _ = sink.Connect()
            .ObserveOn(RxApp.MainThreadScheduler)
            .Bind(out var _)
            .DisposeMany()
            .Subscribe(OnNext);

            var consolas = new FontFamily("Consolas");
            LogRichTextBox.FontFamily = consolas;
            LogRichTextBox.FontSize = 10;
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

#if !DEBUG
            // don't log Debug on release build
            if (level == Logtype.Debug)
            {
                return;
            }
#endif

            if (item.Properties.TryGetValue(Core.Constants.IsSuccess, out var val) && val is ScalarValue { Value: true })
            {
                // ... 
                level = Logtype.Success;
            }

            var paragraph = new Paragraph()
            {
                LineHeight = 1
            };
            var run = new Run($"[{DateTime.Now}] [{level,-9}] {item.RenderMessage()}")
            {
                Foreground = GetBrushForLevel(level),
                FontSize = 12,
            };
            paragraph.Inlines.Add(run);

            // cull after certain amount of blocks
            if (LogRichTextBox.Document.Blocks.Count > s_logLen_cull_at)
            {
                var elementsToRemove = LogRichTextBox.Document.Blocks.Take(s_logLen_cull_to).ToList();
                foreach (var element in elementsToRemove)
                {
                    LogRichTextBox.Document.Blocks.Remove(element);
                }
                
            }
            LogRichTextBox.Document.Blocks.Add(paragraph);

            DispatcherHelper.RunOnMainThread(() => LogRichTextBox.ScrollToEnd(), DispatcherPriority.Background);
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

        private void Button_Click(object sender, RoutedEventArgs e) => LogRichTextBox.Document.Blocks.Clear();
    }
}
