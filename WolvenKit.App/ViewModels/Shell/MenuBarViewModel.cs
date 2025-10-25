using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Core;

namespace WolvenKit.App.ViewModels.Shell;

public partial class MenuBarViewModel : ObservableObject
{
    private bool _automaticUpdate;
    public ISettingsManager SettingsManager { get; }
    public AppViewModel MainViewModel { get; }

    public WikiLinksInstance WikiLinks { get; } = new();

    public MenuBarViewModel(ISettingsManager settingsManager, AppViewModel appViewModel)
    {
        MainViewModel = appViewModel;
        SettingsManager = settingsManager;
        EnableRedmodCommands = settingsManager.ShowRedmodInRibbon;

        MainViewModel.DockedViewVisibleChanged += MainViewModel_OnDockedViewVisibleChanged;
        SettingsManager.PropertyChanged += SettingsManager_PropertyChanged;

        appViewModel.PropertyChanged += AppViewModel_PropertyChanged;
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

    public Dictionary<string, List<string>> GenerateItemCodesFromYaml()
    {
        if (MainViewModel.ActiveProject is not { } project)
        {
            return [];
        }
        var files = MainViewModel.ProjectResourceTools.GetProjectFiles(".yaml", ProjectFolder.Resources);

        Dictionary<string, List<string>> allItems = [];

        foreach (var file in files)
        {
            allItems.AddRange(YamlHelper.GetItemRecordsFromYaml(project.GetAbsolutePath(file)));
        }

        return allItems;
    }

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

    [ObservableProperty] private bool? _hasOpenProject;

    private void AppViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        HasOpenProject ??= MainViewModel.ActiveProject != null;
        if (e.PropertyName == nameof(AppViewModel.ActiveProject))
        {
            HasOpenProject = true;
        }
    }

    public void AddItemCodesToFiles(AddItemsToStoreDialogViewModel? dialogVm)
    {
        if (dialogVm is null || dialogVm.ItemCodes.Count == 0 ||
            (string.IsNullOrEmpty(dialogVm.RedsPath) && string.IsNullOrEmpty(dialogVm.YamlPath)))
        {
            return;
        }

        MainViewModel.ProjectResourceTools.AddItemCodesToStoreFiles(
            dialogVm.ItemCodes,
            dialogVm.YamlPath,
            dialogVm.RedsPath
        );
    }
}
