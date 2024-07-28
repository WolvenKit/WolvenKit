using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Factories;

public class DialogViewModelFactory(
    IProjectManager projectManager,
    ILoggerService loggerService,
    INotificationService notificationService,
    ISettingsManager settingsManager
) : IDialogViewModelFactory
{
    public SoundModdingViewModel SoundModdingViewModel() => new(notificationService, loggerService, projectManager);
    public NewFileViewModel NewFileViewModel() => new(projectManager, settingsManager);
}
