using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using DynamicData;
using ReactiveUI;
using Serilog.Events;
using Splat;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : ReactiveUserControl<LogViewModel>
    {

        #region Constructors

        public LogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;

            //var logger = Locator.Current.GetService<ILoggerService>();
            //logger.Connect()
            //    .ObserveOn(RxApp.MainThreadScheduler)
            //    .Bind(out var _logEntries)
            //    .Subscribe(OnNext);

            var _sink = Locator.Current.GetService<MySink>();
            var myOperation = _sink.Connect()
            //.Transform(x => x.RenderMessage())
            .ObserveOn(RxApp.MainThreadScheduler)
            .Bind(out var _logEntries)
            .DisposeMany()
            .Subscribe(OnNext);

            var firaCode = new FontFamily("Fira Code");
            if (firaCode != null)
            {
                LogRichTextBox.FontFamily = firaCode;
                LogRichTextBox.FontSize = 10;
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
        //private void OnNext(IChangeSet<LogEntry> obj)
        //{
        //    foreach (var change in obj)
        //    {
        //        switch (change.Reason)
        //        {
        //            case ListChangeReason.Add:
        //                var item = change.Item.Current;
        //                AddLog(item);
        //                break;
        //            case ListChangeReason.AddRange:
        //                foreach (var logEntry in change.Range)
        //                {
        //                    AddLog(logEntry);
        //                }
        //                break;
        //            case ListChangeReason.Replace:
        //            case ListChangeReason.Remove:
        //            case ListChangeReason.RemoveRange:
        //            case ListChangeReason.Refresh:
        //            case ListChangeReason.Moved:
        //            case ListChangeReason.Clear:
        //                break;
        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //}

        private void AddLog(LogEvent item)
        {
            var level = item.Level;
            var paragraph = new Paragraph()
            {
                LineHeight = 1
            };
            var run = new Run($"[{DateTime.Now}] {item.RenderMessage()}")
            {
                Foreground = GetBrushForLevel(level)
            };
            paragraph.Inlines.Add(run);
            LogRichTextBox.Document.Blocks.Add(paragraph);
            LogRichTextBox.ScrollToEnd();
        }

        //private void AddLog(LogEntry item)
        //{
        //    var level = item.Level;
        //    var paragraph = new Paragraph()
        //    {
        //        LineHeight = 1
        //    };
        //    var run = new Run(item.ToString())
        //    {
        //        Foreground = GetBrushForLevel(level)
        //    };
        //    paragraph.Inlines.Add(run);
        //    LogRichTextBox.Document.Blocks.Add(paragraph);
        //    LogRichTextBox.ScrollToEnd();
        //}

        private Brush GetBrushForLevel(LogEventLevel level) => level switch
        {
            //Logtype.Normal or Logtype.Wcc => Brushes.White,
            LogEventLevel.Error => (Brush)Application.Current.FindResource("WolvenKitRed"),
            LogEventLevel.Information => (Brush)Application.Current.FindResource("WolvenKitYellow"),
            LogEventLevel.Debug => (Brush)Application.Current.FindResource("WolvenKitCyan"),
            LogEventLevel.Warning => (Brush)Application.Current.FindResource("WolvenKitPurple"),
            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null),
        };

        //private Brush GetBrushForLevel(Logtype level) => level switch
        //{
        //    Logtype.Normal or Logtype.Wcc => Brushes.White,
        //    Logtype.Error => (Brush)Application.Current.FindResource("WolvenKitRed"),
        //    Logtype.Important => (Brush)Application.Current.FindResource("WolvenKitYellow"),
        //    Logtype.Success => (Brush)Application.Current.FindResource("WolvenKitCyan"),
        //    Logtype.Warning => (Brush)Application.Current.FindResource("WolvenKitPurple"),
        //    _ => throw new ArgumentOutOfRangeException(nameof(level), level, null),
        //};

        #endregion Constructors

        private void Button_Click(object sender, RoutedEventArgs e) => LogRichTextBox.Document.Blocks.Clear();
    }
}
