using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Wolvenkit.Installer.Models;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class RemotePackageViewModel
{
    private readonly ILibraryService _libraryService;
    private readonly INotificationService _notificationService;
    private readonly RemotePackageModel _model;

    public RemotePackageViewModel(
        RemotePackageModel model,
        string remoteVersion
        )
    {
        _libraryService = App.Current.Services.GetService<ILibraryService>();
        _notificationService = App.Current.Services.GetService<INotificationService>();
        _model = model;

        RemoteVersion = remoteVersion;

        // default
        var appName = Name.Split('/').Last();
        InstallPath = Path.Combine(@"c:\ModdingTools", appName);
    }

    public string Name => _model.Name;

    public string Description => _model.Description;

    public string ImagePath => _model.ImagePath;

    // Local
    public string RemoteVersion { get; }

    [ObservableProperty]
    private string installPath;

    [RelayCommand(CanExecute = nameof(CanInstall))]
    private async Task Install()
    {
        _notificationService.StartIndeterminate();
        _notificationService.DisplayBanner("Installing", $"Installing {Name}. Please wait", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Informational);

        await _libraryService.InstallAsync(_model, InstallPath);

        _notificationService.CloseBanner();
        _notificationService.StopIndeterminate();
    }

    private bool CanInstall()
    {
        return !Directory.Exists(InstallPath);
    }

    public RemotePackageModel GetModel() => _model;
}

