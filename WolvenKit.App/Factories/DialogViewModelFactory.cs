using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Factories;

public class DialogViewModelFactory : IDialogViewModelFactory
{
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly INotificationService _notificationService;
    private readonly ISettingsManager _settingsManager;

    public DialogViewModelFactory(
        IProjectManager projectManager,
        ILoggerService loggerService,
        INotificationService notificationService,
        ISettingsManager settingsManager
        )
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _notificationService = notificationService;
        _settingsManager = settingsManager;

    }
    public SoundModdingViewModel SoundModdingViewModel() => new(_notificationService, _loggerService, _projectManager);
    public NewFileViewModel NewFileViewModel() => new(_projectManager, _settingsManager);
}
