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

    public PackageViewModel(PackageModel model, EPackageStatus installed, string imagePath)
    {
        _libraryService = App.Current.Services.GetService<ILibraryService>();
        _notificationService = App.Current.Services.GetService<INotificationService>();

        _model = model;
        Status = installed;
        ImagePath = imagePath;

        if (Status == EPackageStatus.UpdateAvailable)
        {
            IsUpdateAvailable = true;
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

    internal PackageModel GetModel() => _model;


    [RelayCommand()]
    private void Open()
    {
        if (Directory.Exists(_model.Path))
        {
            var exe = Path.Combine(_model.Path, _model.Executable);
            if (File.Exists(exe))
            {
                Process.Start("explorer.exe", "\"" + _model.Executable + "\"");
            }

            //Process.Start("explorer.exe", "\"" + _model.Path + "\"");

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