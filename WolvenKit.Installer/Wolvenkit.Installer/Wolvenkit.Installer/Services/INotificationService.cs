using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace Wolvenkit.Installer.Services;
public interface INotificationService
{
    BannerNotification BannerNotification { get; set; }

    void CloseBanner();
    void DisplayBanner(string title, string message, InfoBarSeverity severity);

}

[ObservableObject]
public partial class NotificationService : INotificationService
{
    public NotificationService() => bannerNotification = new();

    [ObservableProperty]
    private BannerNotification bannerNotification;


    // Banners
    public void DisplayBanner(string title, string message, InfoBarSeverity severity)
    {
        BannerNotification.IsOpen = true;

        BannerNotification.Message = message;
        BannerNotification.Severity = severity;
        BannerNotification.Title = title;
    }

    public void CloseBanner() => BannerNotification.IsOpen = false;
}

[ObservableObject]
public partial class BannerNotification
{
    [ObservableProperty]
    private string? title;

    [ObservableProperty]
    private bool isOpen;

    [ObservableProperty]
    private string? message;

    [ObservableProperty]
    private InfoBarSeverity severity;
}