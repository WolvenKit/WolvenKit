using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using DynamicData;
using ReactiveUI;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.ViewModels.Tools;

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

            var logger = Locator.Current.GetService<ILoggerService>();
            logger.Connect()
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out var _logEntries)
                .Subscribe(OnNext);

            var firaCode = new FontFamily("Fira Code");
            if (firaCode != null)
            {
                LogRichTextBox.FontFamily = firaCode;
                LogRichTextBox.FontSize = 10;
            }
        }

        private void OnNext(IChangeSet<LogEntry> obj)
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
                        break;
                    case ListChangeReason.Remove:
                        break;
                    case ListChangeReason.RemoveRange:
                        break;
                    case ListChangeReason.Refresh:
                        break;
                    case ListChangeReason.Moved:
                        break;
                    case ListChangeReason.Clear:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }



        }

        private void AddLog(LogEntry item)
        {
            var level = item.Level;
            var paragraph = new Paragraph()
            {
                LineHeight = 1
            };
            var run = new Run(item.ToString())
            {
                Foreground = GetBrushForLevel(level)
            };
            paragraph.Inlines.Add(run);
            LogRichTextBox.Document.Blocks.Add(paragraph);
            LogRichTextBox.ScrollToEnd();
        }

        private Brush GetBrushForLevel(Logtype level)
        {
            switch (level)
            {
                case Logtype.Normal:
                case Logtype.Wcc:
                    return Brushes.White;
                case Logtype.Error:
                    return (Brush)Application.Current.FindResource("WolvenKitRed");
                case Logtype.Important:
                    return (Brush)Application.Current.FindResource("WolvenKitYellow");
                case Logtype.Success:
                    return (Brush)Application.Current.FindResource("WolvenKitCyan");
                case Logtype.Warning:
                    return (Brush)Application.Current.FindResource("WolvenKitPurple");
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }

        #endregion Constructors

        private void Button_Click(object sender, RoutedEventArgs e) => LogRichTextBox.Document.Blocks.Clear();
    }
}
