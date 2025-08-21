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

    public DialogViewModelFactory(
        IProjectManager projectManager,
        ILoggerService loggerService,
        INotificationService notificationService
        )
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _notificationService = notificationService;

    }
    public SoundModdingViewModel SoundModdingViewModel() => new(_notificationService, _loggerService, _projectManager);
    public NewFileViewModel NewFileViewModel() => new(_projectManager, _loggerService);
}
