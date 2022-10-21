using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
    private readonly IDialogService _dialogService;

    public MainViewModel(IDialogService dialogService, INotificationService notificationService)
    {
        _dialogService = dialogService;
        NotificationService = notificationService;

        Text = "DEBUG";
        Progress = 0;

        Init();
    }

    [ObservableProperty]
    private INotificationService notificationService;


    [ObservableProperty]
    private string? text;

    [ObservableProperty]
    private int progress;

    [ObservableProperty]
    private bool isIndeterminate;

    private async void Init()
    {
        IsIndeterminate = true;
        NotificationService.DisplayBanner("Test", "test msg", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await InitAsync();

        NotificationService.CloseBanner();
        IsIndeterminate = false;
    }

    private async Task InitAsync()
    {




        //for (var i = 0; i < 10; i++)
        //{
        //    // thread safety
        //    //Text += "-G";
        //    //Progress += 10;

        //    await Task.Delay(500).ConfigureAwait(false);
        //}
    }

    [RelayCommand]
    private async Task Refresh()
    {
        IsIndeterminate = true;
        NotificationService.DisplayBanner("Test", "test msg", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await InitAsync();

        NotificationService.CloseBanner();
        IsIndeterminate = false;
    }
}
