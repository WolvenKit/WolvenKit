using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace WolvenKit.Red3.UI.Services;

public interface INotificationService
{
    BannerNotification BannerNotification { get; set; }
    Progress Progress { get; set; }

    void CloseBanner();
    void DisplayBanner(string title, string message, InfoBarSeverity severity);
    void DisplayError(string message);


    void StartIndeterminate();
    void StopIndeterminate();
    /// <summary>
    /// Report Progress
    /// </summary>
    /// <param name="v"></param>
    void Report(double v);
    /// <summary>
    /// Report full progress and halt indeterminate
    /// </summary>
    void Completed();
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

    public void DisplayError(string message)
    {
        BannerNotification.IsOpen = true;

        BannerNotification.Message = message;
        BannerNotification.Severity = InfoBarSeverity.Error;
        BannerNotification.Title = "Error";
    }

    public void CloseBanner() => BannerNotification.IsOpen = false;

    public void StartIndeterminate() => Progress.IsIndeterminate = true;
    public void StopIndeterminate() => Progress.IsIndeterminate = false;
    public void Report(double v) => Progress.Value = (int)(v * 100);
    public void Completed()
    {
        Progress.Value = 100;
        Progress.IsIndeterminate = false;
    }
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
    private int value;

    [ObservableProperty]
    private bool isIndeterminate;

}