using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// During the first time setup it tries to automatically determine the missing paths and settings.
/// </summary>
public partial class FirstSetupViewModel : DialogWindowViewModel
{
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;

    public FirstSetupViewModel(
        ISettingsManager settingsManager,
        ILoggerService loggerService
    )
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;

        Title = "Settings";

        TryToFindCP77ExecutableAutomatically();

        _materialDepotPath = Path.Combine(ISettingsManager.GetAppData(), "Depot");
        if (!Directory.Exists(_materialDepotPath))
        {
            Directory.CreateDirectory(_materialDepotPath);
        }
    }

    #region Properties

    public string Title { get; set; }

    //public string Author { get; set; }
    //public string Email { get; set; }
    //public string DonateLink { get; set; }
    //public string Description { get; set; }
    [ObservableProperty] private string _materialDepotPath;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenLinkCommand))]
    private bool _allFieldsValid;

    [ObservableProperty] private bool _checkForUpdates;

    [ObservableProperty] private string? _cP77ExePath;

    public string WikiHelpLink = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";

    #endregion Properties

    #region Commands

    private bool CanOpenLink() => AllFieldsValid;
    [RelayCommand]
    private void OpenLink(string link)
    {
        var ps = new ProcessStartInfo(link)
        {
            UseShellExecute = true,
            Verb = "open"
        };
        Process.Start(ps);
    }

    [RelayCommand]
    private void OpenCP77GamePath()
    {
        var dlg = new CommonOpenFileDialog
        {
            AllowNonFileSystemItems = false,
            Multiselect = false,
            IsFolderPicker = false,
            Title = "Select Cyberpunk 2077 executable."
        };

        dlg.Filters.Add(new CommonFileDialogFilter("Cyberpunk2077.exe", "*.exe"));

        if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
        {
            return;
        }

        var result = dlg.FileName;
        if (string.IsNullOrEmpty(result))
        {
            return;
        }

        CP77ExePath = result;
    }

    [RelayCommand]
    private void OpenDepotPath()
    {
        var dlg = new CommonOpenFileDialog
        {
            AllowNonFileSystemItems = false,
            Multiselect = false,
            IsFolderPicker = true,
            Title = "Select Material Depot folder"
        };

        if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
        {
            return;
        }

        var result = dlg.FileName;
        if (string.IsNullOrEmpty(result))
        {
            return;
        }

        MaterialDepotPath = result;
    }

    #endregion Commands

    #region Methods

    private delegate void StrDelegate(string value);

    private const string _steamCommonInstallLocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cyberpunk 2077\\bin\\x64\\Cyberpunk2077.exe";
    private const string _uninstallKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";
    private const string _uninstallKey2 = "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\";

    private void TryToFindCP77ExecutableAutomatically()
    {
        // Try Steam Default
        if (File.Exists(_steamCommonInstallLocation))
        {
            CP77ExePath = _steamCommonInstallLocation;
            return;
        }

        // Parallel Lookup through Registry Uninstall SubKeys.
        var fileNamePath = "";
        var subKeys = Registry.LocalMachine.OpenSubKey(_uninstallKey)?.GetSubKeyNames();
        if (subKeys?.Length > 0)
        {
            Parallel.ForEach(
                subKeys,
                (subKeyName, state) =>
                {
                    try
                    {
                        if (subKeyName is null)
                        { return; }

                        fileNamePath = RegistryHelpers.GetFileNamePathFromRegistrySubKey(
                            _uninstallKey + subKeyName,
                            "Cyberpunk",
                            "Cyberpunk2077.exe");

                        if (!string.IsNullOrWhiteSpace(fileNamePath))
                        { state.Break(); } // Stop the parallel loop.
                    }
                    catch (Exception ex)
                    { _loggerService.Error(ex); }
                });
        }

        // Keep Looking
        if (string.IsNullOrWhiteSpace(fileNamePath))
        {
            subKeys = Registry.LocalMachine.OpenSubKey(_uninstallKey2)?.GetSubKeyNames();
            if (subKeys?.Length > 0)
            {
                Parallel.ForEach(
                    subKeys,
                    (subKeyName, state) =>
                    {
                        try
                        {
                            if (subKeyName is null)
                            { return; }

                            fileNamePath = RegistryHelpers.GetFileNamePathFromRegistrySubKey(
                                _uninstallKey2 + subKeyName,
                                "Cyberpunk",
                                "Cyberpunk2077.exe");

                            if (!string.IsNullOrWhiteSpace(fileNamePath))
                            { state.Break(); } // Stop the parallel loop.
                        }
                        catch (Exception ex)
                        { _loggerService.Error(ex); }
                    });
            }
        }

        if (File.Exists(fileNamePath))
        {
            CP77ExePath = fileNamePath;
        }
    }

    #endregion Methods
}
