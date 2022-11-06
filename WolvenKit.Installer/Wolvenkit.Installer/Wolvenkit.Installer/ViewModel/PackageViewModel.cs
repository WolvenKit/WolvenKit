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
        Installed = installed;
        ImagePath = imagePath;
    }

    public string Name => _model.Name;
    public string Version => _model.Version;

    // LOCAL
    public string ImagePath { get; }
    public EPackageStatus Installed { get; set; }

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

                throw;
            }

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