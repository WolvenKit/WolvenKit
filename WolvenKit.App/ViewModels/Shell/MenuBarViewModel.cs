using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Shell;

// this has to be a class for the sake of view model binding. Still better than having properties, I guess.
#pragma warning disable CA1822
// ReSharper disable MemberCanBeMadeStatic.Global
public class WikiLinks
{
    public string CyberpunkBlenderAddon => "https://github.com/WolvenKit/Cyberpunk-Blender-add-on";
    public string WolvenKitSetupGuide => "https://wiki.redmodding.org/wolvenkit/getting-started/setup";
    public string WolvenKitCreatingAModGuide => "https://wiki.redmodding.org/wolvenkit/getting-started/creating-a-mod";
    public string DiscordInvitation => "https://discord.gg/Epkq79kd96";
    public string AboutWolvenKit => "https://wiki.redmodding.org/wolvenkit/about";
}
// ReSharper enable MemberCanBeMadeStatic.Global
#pragma warning restore CA1822

public partial class MenuBarViewModel : ObservableObject
{
    private bool _automaticUpdate;
    public ISettingsManager SettingsManager { get; }
    public AppViewModel MainViewModel { get; }

// this has to be a class for the sake of view model binding. Still better than having properties, I guess.
    public readonly WikiLinks WikiLinks = new();

    public MenuBarViewModel(ISettingsManager settingsManager, AppViewModel appViewModel)
    {
        MainViewModel = appViewModel;
        SettingsManager = settingsManager;
        EnableRedmodCommands = settingsManager.ShowRedmodInRibbon;
        
        MainViewModel.DockedViewVisibleChanged += MainViewModel_OnDockedViewVisibleChanged;
        SettingsManager.PropertyChanged += SettingsManager_PropertyChanged;
    }

    private void SettingsManager_PropertyChanged(object? sender, PropertyChangedEventArgs e) =>
        EnableRedmodCommands = SettingsManager.ShowRedmodInRibbon;

    private void MainViewModel_OnDockedViewVisibleChanged(object? sender, AppViewModel.DockedViewVisibleChangedEventArgs e)
    {
        _automaticUpdate = true;

        switch (e.Element)
        {
            case ProjectExplorerViewModel:
                ProjectExplorerCheckbox = e.Element.IsVisible;
                break;
            case AssetBrowserViewModel:
                AssetBrowserCheckbox = e.Element.IsVisible;
                break;
            case PropertiesViewModel:
                PropertiesCheckbox = e.Element.IsVisible;
                break;
            case LogViewModel:
                LogCheckbox = e.Element.IsVisible;
                break;
            case TweakBrowserViewModel:
                TweakBrowserCheckbox = e.Element.IsVisible;
                break;
            case LocKeyBrowserViewModel:
                LocKeyBrowserCheckbox = e.Element.IsVisible;
                break;
            default:
                break;
        }

        _automaticUpdate = false;
    }

    [RelayCommand]
    private void OpenGameFolder() => Commonfunctions.ShowFolderInExplorer(SettingsManager.GetRED4GameRootDir());

    [ObservableProperty]
    private bool _projectExplorerCheckbox;

    [ObservableProperty] private bool _enableRedmodCommands;
    
    partial void OnProjectExplorerCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<ProjectExplorerViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _assetBrowserCheckbox;
    partial void OnAssetBrowserCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<AssetBrowserViewModel>().IsVisible = value;
    }
    
    [ObservableProperty]
    private bool _propertiesCheckbox;
    partial void OnPropertiesCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<PropertiesViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _logCheckbox;
    partial void OnLogCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<LogViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _tweakBrowserCheckbox;
    partial void OnTweakBrowserCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<TweakBrowserViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _locKeyBrowserCheckbox;
    partial void OnLocKeyBrowserCheckboxChanged(bool value)
    {
        if (_automaticUpdate)
        {
            return;
        }

        MainViewModel.GetToolViewModel<LocKeyBrowserViewModel>().IsVisible = value;
    }
}
