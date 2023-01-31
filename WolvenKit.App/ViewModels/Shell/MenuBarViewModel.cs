using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.App.ViewModels.Shell;

public partial class MenuBarViewModel : ObservableObject
{
    public ISettingsManager SettingsManager { get; }
    public AppViewModel MainViewModel { get; }

    public MenuBarViewModel(ISettingsManager settingsManager, AppViewModel appViewModel)
    {
        MainViewModel = appViewModel;
        SettingsManager = settingsManager;

        MainViewModel.PropertyChanged += MainViewModel_PropertyChanged;
    }

    private void MainViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(AppViewModel.DockedViews))
        {
            // hack lazy checkbox setting
            foreach (var pane in MainViewModel.DockedViews)
            {
                switch (pane)
                {
                    case ProjectExplorerViewModel:
                        ProjectExplorerCheckbox = pane.IsVisible;
                        break;
                    case AssetBrowserViewModel:
                        AssetBrowserCheckbox = pane.IsVisible;
                        break;
                    case PropertiesViewModel:
                        PropertiesCheckbox = pane.IsVisible;
                        break;
                    case LogViewModel:
                        LogCheckbox = pane.IsVisible;
                        break;
                    case TweakBrowserViewModel:
                        TweakBrowserCheckbox = pane.IsVisible;
                        break;
                    case LocKeyBrowserViewModel:
                        LocKeyBrowserCheckbox = pane.IsVisible;
                        break;
                    default:
                        break;
                }
            }
        }
    }
    
    [RelayCommand]
    private void OpenGameFolder() => Commonfunctions.ShowFolderInExplorer(SettingsManager.GetRED4GameRootDir());

    [ObservableProperty]
    private bool _projectExplorerCheckbox;
    partial void OnProjectExplorerCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<ProjectExplorerViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _assetBrowserCheckbox;
    partial void OnAssetBrowserCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<AssetBrowserViewModel>().IsVisible = value;
    }
    
    [ObservableProperty]
    private bool _propertiesCheckbox;
    partial void OnPropertiesCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<PropertiesViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _logCheckbox;
    partial void OnLogCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<LogViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _tweakBrowserCheckbox;
    partial void OnTweakBrowserCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<TweakBrowserViewModel>().IsVisible = value;
    }

    [ObservableProperty]
    private bool _locKeyBrowserCheckbox;
    partial void OnLocKeyBrowserCheckboxChanged(bool value)
    {
        MainViewModel.GetToolViewModel<LocKeyBrowserViewModel>().IsVisible = value;
    }
}
