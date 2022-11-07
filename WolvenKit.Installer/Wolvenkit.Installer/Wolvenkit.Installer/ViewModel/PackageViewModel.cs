using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Wolvenkit.Installer.Models;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class PackageViewModel
{
    private readonly PackageModel _model;
    private readonly ILibraryService _libraryService;
    private readonly INotificationService _notificationService;

    private const int s_height = 85;
    private const int s_expandedHeight = 140;

    public PackageViewModel(PackageModel model, EPackageStatus installed, string imagePath)
    {
        _libraryService = App.Current.Services.GetService<ILibraryService>();
        _notificationService = App.Current.Services.GetService<INotificationService>();

        _model = model;
        Status = installed;
        ImagePath = imagePath;

        Height = s_height;

        if (Status == EPackageStatus.UpdateAvailable)
        {
            IsUpdateAvailable = true;
            Height = s_expandedHeight;
        }
    }

    // Todo refactor with custom converter
    [ObservableProperty]
    private bool isUpdateAvailable;

    public string Name => _model.Name;
    public string Version => _model.Version;

    // LOCAL
    public string ImagePath { get; }
    public EPackageStatus Status { get; set; }

    // View
    [ObservableProperty]
    private int height;

    internal PackageModel GetModel() => _model;


    [RelayCommand()]
    private void Open()
    {
        if (Directory.Exists(_model.Path))
        {
            Process.Start("explorer.exe", "\"" + _model.Path + "\"");
        }
    }

    [RelayCommand()]
    private async Task Debug()
    {
        _notificationService.StartIndeterminate();
        _notificationService.DisplayBanner("Uninstalling", $"Uninstalling {Name}. Please wait", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Informational);

        await Task.Delay(4000);

        _notificationService.CloseBanner();
        _notificationService.StopIndeterminate();
    }

    [RelayCommand()]
    private void Launch()
    {
        if (Directory.Exists(_model.Path))
        {
            if (_libraryService.TryGetRemote(_model, out var remote))
            {
                var exe = Path.Combine(_model.Path, remote.GetModel().Executable);
                if (File.Exists(exe))
                {
                    try
                    {
                        Process.Start(exe);
                    }
                    catch (System.Exception)
                    {
                    }
                }
            }
        }
    }

    [RelayCommand()]
    private async Task Uninstall()
    {
        _notificationService.StartIndeterminate();
        _notificationService.DisplayBanner("Uninstalling", $"Uninstalling {Name}. Please wait", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Informational);


        if (Directory.Exists(_model.Path))
        {
            try
            {
                Directory.Delete(_model.Path, true);
                await _libraryService.RemoveAsync(_model);
            }
            catch (System.Exception)
            {
                // todo logging
            }
        }

        _notificationService.CloseBanner();
        _notificationService.StopIndeterminate();
    }

    [RelayCommand()]
    private async Task Update()
    {
        _notificationService.StartIndeterminate();
        _notificationService.DisplayBanner("Updating", $"Updating {Name}. Please wait", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Informational);

        var isuninstalled = false;

        // remove
        if (Directory.Exists(_model.Path))
        {
            try
            {
                Directory.Delete(_model.Path, true);
                isuninstalled = await _libraryService.RemoveAsync(_model);
            }
            catch (System.Exception)
            {
                // todo logging
            }
        }

        // install
        if (isuninstalled)
        {
            await _libraryService.InstallAsync(_model);
            IsUpdateAvailable = false;
            Height = s_expandedHeight;
        }

        _notificationService.CloseBanner();
        _notificationService.StopIndeterminate();
    }
}

public enum EPackageStatus
{
    NotInstalled,
    Installed,
    UpdateAvailable,
}