using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using DynamicData;
using ReactiveUI;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Editor
{
    /// <summary>
    /// Implements the viewmodel that drives the log view.
    /// </summary>
    public class LogViewModel : ToolViewModel
    {
        #region Fields

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "Log_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Log";

        private readonly ILoggerService _loggerService;

        private readonly ReadOnlyObservableCollection<LogEntry> _logEntries;
        public ReadOnlyObservableCollection<LogEntry> LogEntries => _logEntries;

        #endregion Fields

        #region constructors

        public LogViewModel(
            ILoggerService loggerService
            ) : base(ToolTitle)
        {
            _loggerService = loggerService ??  ServiceLocator.Default.ResolveType<ILoggerService>();

            SetupToolDefaults();

            //filter, sort and populate reactive list,
            _loggerService.Connect() //connect to the cache
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _logEntries)
                .Subscribe();
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// The application log.
        /// Bound to the logview, implements OnPropertyRaised through Fody
        /// </summary>
        public string Log { get; set; }

        #endregion properties

        #region methods

        protected override Task CloseAsync() =>
            // TODO: Unsubscribe from events

            base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: Write initialization code here and subscribe to events

        /// <summary>
        /// Initialize Avalondock specific defaults that are specific to this tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;           // Define a unique contentid for this toolwindow//BitmapImage bi = new BitmapImage();  // Define an icon for this toolwindow//bi.BeginInit();//bi.UriSource = new Uri("pack://application:,,/Resources/Media/Images/property-blue.png");//bi.EndInit();//IconSource = bi;

        #endregion methods
    }
}
