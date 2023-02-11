﻿using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.App.Factories;

public interface IPaneViewModelFactory
{
    public LogViewModel LogViewModel();
    public ProjectExplorerViewModel ProjectExplorerViewModel(AppViewModel appViewModel);
    public PropertiesViewModel PropertiesViewModel();
    public AssetBrowserViewModel AssetBrowserViewModel(AppViewModel appViewModel);
    public TweakBrowserViewModel TweakBrowserViewModel();
    public LocKeyBrowserViewModel LocKeyBrowserViewModel();
    public TextureImportViewModel TextureImportViewModel();
    public TextureExportViewModel TextureExportViewModel();

    public T GetToolViewModel<T>() where T : IDockElement;
}
