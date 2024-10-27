using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// During the first time setup it tries to automatically determine the missing paths and settings.
/// </summary>
public partial class FirstSetupViewModel : DialogWindowViewModel, INotifyDataErrorInfo
{
    private readonly Dictionary<string, List<string>> _errorsByPropertyName = new();

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
        var dlg = new OpenFileDialog
        {
            Title = "Select Cyberpunk 2077 executable",
            Multiselect = false,
            Filter = "Cyberpunk2077.exe|*.exe"
        };

        if (dlg.ShowDialog() != true)
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
        var dlg = new FolderPicker
        {
            Title = "Select Material Depot folder",
            ForceFileSystem = true
        };

        if (dlg.ShowDialog() != true)
        {
            return;
        }

        var result = dlg.ResultPath;
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

    public void ExecuteFinish()
    {
        _settingsManager.CP77ExecutablePath = CP77ExePath;
        _settingsManager.MaterialRepositoryPath = MaterialDepotPath;
        _settingsManager.Bounce();
    }

    partial void OnCP77ExePathChanged(string? value) => ValidateCP77ExePath();

    public void ValidateCP77ExePath()
    {
        ClearError(nameof(CP77ExePath));
        if (File.Exists(CP77ExePath) && Path.GetFileName(CP77ExePath).Equals(Core.Constants.Red4Exe))
        {
            var oodle = Path.Combine(new FileInfo(CP77ExePath).Directory!.FullName, Core.Constants.Oodle);
            if (!File.Exists(oodle))
            {
                AddError(nameof(CP77ExePath), $"Oodle dll was not found within the game installation. Please make sure you have {Core.Constants.Oodle} next to your game executable.");
            }
        }
        else
        {
            AddError(nameof(CP77ExePath), "Locate game executable (.exe) for full WolvenKit functionality.");
        }
    }

    partial void OnMaterialDepotPathChanged(string value) => ValidateMaterialDepotPath();

    public void ValidateMaterialDepotPath()
    {
        ClearError(nameof(MaterialDepotPath));
        if (!Directory.Exists(MaterialDepotPath))
        {
            AddError(nameof(MaterialDepotPath), "Selected path does not exist");
        }
    }

    #endregion Methods

    #region INotifyDataErrorInfo

    private void AddError(string propertyName, string error)
    {
        if (!_errorsByPropertyName.TryGetValue(propertyName, out var errorList))
        {
            errorList = new List<string>();
            _errorsByPropertyName.Add(propertyName, errorList);
        }

        if (!errorList.Contains(error))
        {
            errorList.Add(error);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }

    private void ClearError(string propertyName)
    {
        if (!_errorsByPropertyName.ContainsKey(propertyName))
        {
            return;
        }

        _errorsByPropertyName.Remove(propertyName);
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
    }

    public IEnumerable GetErrors(string? propertyName)
    {
        if (!string.IsNullOrEmpty(propertyName) && _errorsByPropertyName.TryGetValue(propertyName, out var errorList))
        {
            return errorList;
        }

        return new List<string>();
    }

    public bool HasErrors => _errorsByPropertyName.Count > 0;

    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

    #endregion INotifyDataErrorInfo
}
