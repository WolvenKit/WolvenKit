using System.Diagnostics;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.ApplicationModel;
using WolvenKit.Red3.UI.Services;

namespace WolvenKit.Red3.UI.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
    private readonly IDialogService _dialogService;

    public MainViewModel(
        IDialogService dialogService,
        INotificationService notificationService)
    {
        _dialogService = dialogService;
        Notifications = notificationService;

        Init();
        Version = GetAppVersion();
    }

    [ObservableProperty]
    private INotificationService notifications;

    [ObservableProperty]
    private bool loaded;

    [ObservableProperty]
    private string version;

    //https://stackoverflow.com/a/28635481
    public static string GetAppVersion()
    {
        var package = Package.Current;
        var packageId = package.Id;
        var version = packageId.Version;

        return string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
    }

    /// <summary>
    /// Load everything expensive and unlock the app afterwards
    /// </summary>
    private async void Init()
    {
        Notifications.StartIndeterminate();
        Notifications.DisplayBanner("Initializing", "Checking for updates. Please wait.", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await InitAsync();

        Notifications.CloseBanner();
        Notifications.StopIndeterminate();

        Loaded = true;
    }

    /// <summary>
    /// Get remote versions
    /// </summary>
    /// <returns></returns>
    private async Task InitAsync() => await Task.Delay(1);

    [RelayCommand]
    private async Task Refresh()
    {
        Notifications.StartIndeterminate();
        Notifications.DisplayBanner("Test", "test msg", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await InitAsync();

        Notifications.CloseBanner();
        Notifications.Completed();
    }

    [RelayCommand]
    private void About()
    {
        Process.Start("explorer.exe", @"https://github.com/WolvenKit/WolvenKit");
    }

}