using System;
using System.ComponentModel;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using Octokit;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class StatusBarViewModel : ObservableObject
{
    private const string s_noProjectLoaded =
        "NO PROJECT LOADED | Create a New Project or Open an existing Project to get started with WolvenKit";

    public ISettingsManager _settingsManager { get; set; }
    private readonly ILoggerService _loggerService;

    private readonly IProjectManager _projectManager;
    private readonly IProgressService<double> _progressService;


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

        _projectManager.PropertyChanged += ProjectManager_OnPropertyChanged;

        _progressService.ProgressChanged += ProgressService_ProgressChanged;
        _progressService.PropertyChanged += ProgressService_PropertyChanged;
    }

    private void ProjectManager_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ProjectManager.ActiveProject))
        {
            CurrentProject = _projectManager.ActiveProject != null ? _projectManager.ActiveProject.Name : s_noProjectLoaded;
        }
    }

    private void ProgressService_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IProgressService<double>.IsIndeterminate))
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                IsIndeterminate = _progressService.IsIndeterminate;
            });
        }
        else if (e.PropertyName == nameof(IProgressService<double>.Status))
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                Status = _progressService.Status.ToString();
                switch (_progressService.Status)
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
        }
    }

    private void ProgressService_ProgressChanged(object? sender, double e)
    {
        Progress = e * 100;
    }


    #endregion Constructors

    #region Properties

    [ObservableProperty]
    private double _progress;

    [ObservableProperty]
    private bool _isIndeterminate;

    public string? InternetConnected { get; private set; }

    public bool IsLoading { get; set; }

    public string LoadingString { get; set; }

    [ObservableProperty] private string _currentProject;

    [ObservableProperty] private string _status = "Ready";

    public object VersionNumber => _settingsManager.GetVersionNumber();


    [ObservableProperty] private Brush _barColor = Brushes.Black;

    #endregion Properties

}
