using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace Wolvenkit.Installer.Services;
public interface INotificationService
{
    BannerNotification BannerNotification { get; set; }
    Progress Progress { get; set; }

    void CloseBanner();
    void DisplayBanner(string title, string message, InfoBarSeverity severity);
    void StartIndeterminate();
    void StopIndeterminate();
}

[ObservableObject]
public partial class NotificationService : INotificationService
{
    public NotificationService()
    {
        BannerNotification = new();
        Progress = new();
    }

    [ObservableProperty]
    private BannerNotification bannerNotification;

    [ObservableProperty]
    private Progress progress;


    // Banners
    public void DisplayBanner(string title, string message, InfoBarSeverity severity)
    {
        BannerNotification.IsOpen = true;

        BannerNotification.Message = message;
        BannerNotification.Severity = severity;
        BannerNotification.Title = title;
    }

    public void CloseBanner() => BannerNotification.IsOpen = false;

    public void StartIndeterminate() => Progress.IsIndeterminate = true;
    public void StopIndeterminate() => Progress.IsIndeterminate = false;
}

[ObservableObject]
public partial class BannerNotification
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private bool isOpen;

    [ObservableProperty]
    private string message;

    [ObservableProperty]
    private InfoBarSeverity severity;
}

[ObservableObject]
public partial class Progress
{

    [ObservableProperty]
    private bool isIndeterminate;

}