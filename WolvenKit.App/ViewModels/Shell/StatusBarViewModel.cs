using System;
using System.Reactive.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Shell
{
    public partial class StatusBarViewModel : ObservableObject
    {
        #region Fields

        private const string s_noProjectLoaded =
            "NO PROJECT LOADED | Create a New Project or Open an existing Project to get started with WolvenKit";

        public ISettingsManager _settingsManager { get; set; }
        private readonly ILoggerService _loggerService;

        private readonly IProjectManager _projectManager;
        private readonly IProgressService<double> _progressService;


        #endregion Fields

        #region Constructors

        public StatusBarViewModel(
            ISettingsManager settingsManager,
            IProjectManager projectManager,
            ILoggerService loggerService,
            IProgressService<double> progressService
            )
        {
            _settingsManager = settingsManager;
            _projectManager = projectManager;
            _progressService = progressService;
            _loggerService = loggerService;

            IsLoading = false;
            LoadingString = "";
            _currentProject = "";

            _projectManager
                .WhenAnyValue(
                    x => x.ActiveProject,
                    project => project != null ? project.Name : s_noProjectLoaded)
                .Subscribe(p =>
                {
                    _currentProject = p;
                });
                

            _ = Observable.FromEventPattern<EventHandler<double>, double>(
                handler => _progressService.ProgressChanged += handler,
                handler => _progressService.ProgressChanged -= handler)
                .Select(_ => _.EventArgs * 100)
                .Subscribe(x =>
                {
                    _progress = x;
                });

            _ = _progressService.WhenAnyValue(x => x.IsIndeterminate).Subscribe(b => DispatcherHelper.RunOnMainThread(() => IsIndeterminate = b));
            _ = _progressService.WhenAnyValue(x => x.Status).Subscribe(s =>
            {
                DispatcherHelper.RunOnMainThread(() =>
                {
                    Status = s.ToString();
                    switch (s)
                    {
                        case EStatus.Running:
                            BarColor = Brushes.DarkOrange;
                            break;
                        case EStatus.Ready:
                            if (new BrushConverter().ConvertFromString("#951C2D") is SolidColorBrush brush)
                            {
                                BarColor = brush;
                            }

                            break;
                        default:
                            break;
                    }
                });

            });
        }

        #endregion Constructors

        #region Properties

        [ObservableProperty] private double _progress;

        [ObservableProperty] private bool _isIndeterminate;

        public string? InternetConnected { get; private set; }

        public bool IsLoading { get; set; }

        public string LoadingString { get; set; }

        [ObservableProperty] private string _currentProject;

        [ObservableProperty] private string _status = "Ready";

        public object VersionNumber => _settingsManager.GetVersionNumber();


        [ObservableProperty] private Brush _barColor  = Brushes.Black;

        #endregion Properties

    }
}
