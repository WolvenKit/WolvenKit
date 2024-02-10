using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.ApplicationModel;
using WolvenKit.Red3.UI.Services;

namespace WolvenKit.Red3.UI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IDialogService _dialogService;
    private readonly IWorkspaceService _workspaceService;

    public MainViewModel(
        IDialogService dialogService,
        IWorkspaceService workspaceService,
        INotificationService notificationService)
    {
        _dialogService = dialogService;
        _workspaceService = workspaceService;
        Notifications = notificationService;

        Documents = new();

        Init();
        Version = GetAppVersion();
    }

    [ObservableProperty]
    private INotificationService notifications;

    [ObservableProperty]
    private bool loaded;

    [ObservableProperty]
    private string version;

    [ObservableProperty]
    private ObservableCollection<DocumentViewModel> documents;

    #region commands

    [RelayCommand]
    private async Task NewFile()
    {
        Notifications.StartIndeterminate();
        Notifications.DisplayBanner("Test", "test msg", Microsoft.UI.Xaml.Controls.InfoBarSeverity.Warning);

        await Task.Delay(5000);

        Notifications.CloseBanner();
        Notifications.Completed();
    }

    [RelayCommand]
    private async Task OpenFolder()
    {
        // Create a folder picker.
        var folderPicker = new Windows.Storage.Pickers.FolderPicker();

        // Initialize the folder picker with the window handle (HWND). lmao
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(App.StartupWindow);
        WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);

        // Use the folder picker as usual.
        folderPicker.FileTypeFilter.Add("*");
        var storageFolder = await folderPicker.PickSingleFolderAsync();

        if (storageFolder is null)
        {
            return;
        }
        var folder = storageFolder.Path;
        if (!Directory.Exists(folder))
        {
            return;
        }

        // open folder
        _workspaceService.SetWorkspace(new DirectoryInfo(folder));
    }

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
        //Process.Start("explorer.exe", @"https://github.com/WolvenKit/WolvenKit");
    }

    #endregion


    #region methods

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
    internal async Task OpenFileAsync(string fullPath)
    {
        // parse file
        var text = await File.ReadAllTextAsync(fullPath);
        var documentVm = new DocumentViewModel(text, Path.GetFileName(fullPath));

        // add it to tabview
        Documents.Add(documentVm);
    }

    internal void CloseDocument(DocumentViewModel item)
    {
        Documents.Remove(item);
    }

    #endregion

}