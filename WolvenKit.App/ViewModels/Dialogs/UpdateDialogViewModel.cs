using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class UpdateDialogViewModel : DialogViewModel
{
    public readonly AppViewModel _appvm;
    private readonly IUpdateService _updateService;
    private readonly ISettingsManager _settingsManager;
    public readonly ILoggerService _logger;
    
    public bool NoUpdateAvailableState { get; set; }
    public bool AskForPermissionState { get; set; }
    public bool UpdateExecutingState { get; set; }
    
    private bool _showLoadingSpinner = false;
    public bool ShowLoadingSpinner
    {
        get => _showLoadingSpinner;
        set
        {
            _showLoadingSpinner = value;
            OnPropertyChanged();
        }
    }
    

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            OnPropertyChanged();
        }
    }

    public string Body
    {
        get => _body;
        set
        {
            _body = value;
            OnPropertyChanged();
        }
    }

    public List<string> Buttons
    {
        get => _buttons;
        set
        {
            _buttons = value;
            OnPropertyChanged();
        }
    }

    private string _latestVersionTag;

    private string _title;
    private string _body;
    private List<string> _buttons;
    
    public UpdateDialogViewModel(AppViewModel appvm, IUpdateService updateService, ISettingsManager settingsManager, ILoggerService loggerService, bool skipPermissionStage = false, bool? updateAvailable = null)
    {
        _appvm = appvm;
        _updateService = updateService;
        _settingsManager = settingsManager;
        _logger = loggerService;
        
        _title = "Update";
        _body = "";
        _buttons = new List<string>() { "Ok" };

        _latestVersionTag = "";
        #pragma warning disable CS4014
        InitializeState(skipPermissionStage, updateAvailable);
    }

    private async Task InitializeState(bool skipPermissionStage = false, bool? updateAvailable = null)
    {
        _latestVersionTag = await _updateService.GetLatestVersionTag();
        updateAvailable ??= await _updateService.IsUpdateAvailable();
        
        if (!(bool)updateAvailable)
        {
            NoUpdateAvailableState = true;
        }
        else
        {
            AskForPermissionState = !skipPermissionStage;
            UpdateExecutingState = skipPermissionStage;
        }
        
        if (NoUpdateAvailableState)
        {
            SetDialogToNoUpdateAvailableState();
        }
        else if (AskForPermissionState)
        {
            SetDialogToAskForPermissionState();
        }
        else if (UpdateExecutingState)
        {
            SetDialogToUpdateExecutingState();
        }
    }
    
    public void SetDialogToNoUpdateAvailableState()
    {
        NoUpdateAvailableState = true;
        AskForPermissionState = false;
        UpdateExecutingState = false;
        
        Title = "No update available";
        Body = $"You are already on the latest release ({_updateService.GetLocalVersion()}) for the {_settingsManager.UpdateChannel} release channel";
        Buttons = new List<string>() { "OK" };
    }
    
    public void SetDialogToAskForPermissionState()
    {
        NoUpdateAvailableState = false;
        AskForPermissionState = true;
        UpdateExecutingState = false;
        
        Title = "Update available";
        Body =
            $"An update to version {_latestVersionTag} is available on the {_settingsManager.UpdateChannel} release channel";
        Buttons = new List<string>() { "Update", "Ignore" };
    }
    
    public void SetDialogToUpdateExecutingState()
    {
        NoUpdateAvailableState = false;
        AskForPermissionState = false;
        UpdateExecutingState = true;
        
        ShowLoadingSpinner = true;
        
        Title = "Updating WolvenKit...";
        Body = $"Updating to version {_latestVersionTag} on the {_settingsManager.UpdateChannel} release channel...\nWolvenKit will restart as part of the update process.";
        Buttons = new List<string>() { };
        
        Task.Run(async () =>
        {
            try
            {
                await _updateService.UpdateToNewestVersion();
            }
            catch (Exception ex)
            {
                ShowLoadingSpinner = false;
                Title = "Update failed";
                Body = $"Failed to update with error: {ex.Message}";
                Buttons = new List<string>() { "OK", "Retry" };
                _logger.Error("Failed to update:");
                _logger.Error(ex);
            }
        });
    }
    
}