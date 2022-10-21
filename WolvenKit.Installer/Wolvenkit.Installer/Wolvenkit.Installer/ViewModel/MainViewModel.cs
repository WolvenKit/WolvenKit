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
    private readonly ILibraryService _libraryService;

    public MainViewModel(
        IDialogService dialogService,
        ILibraryService libraryService,
        INotificationService notificationService)
    {
        _dialogService = dialogService;
        _libraryService = libraryService;
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

    [ObservableProperty]
    private bool loaded;

    /// <summary>
    /// Load everything expensive and unlock the app afterwards
    /// </summary>
    private async void Init()
    {
        IsIndeterminate = true;
        NotificationService.DisplayBanner("Test", "test msg", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await InitAsync();

        NotificationService.CloseBanner();
        IsIndeterminate = false;

        Loaded = true;
    }

    /// <summary>
    /// Get remote versions
    /// </summary>
    /// <returns></returns>
    private async Task InitAsync() => await _libraryService.InitAsync();//for (var i = 0; i < 10; i++)//{//    // thread safety//    //Text += "-G";//    //Progress += 10;//    await Task.Delay(500).ConfigureAwait(false);//}

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
