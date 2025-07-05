using WolvenKit.App.Models.Docking;
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
    public TweakBrowserViewModel TweakBrowserViewModel(AppViewModel appViewModel);
    public LocKeyBrowserViewModel LocKeyBrowserViewModel();
    public ImportViewModel ImportViewModel(AppViewModel appViewModel);
    public ExportViewModel ExportViewModel(AppViewModel appViewModel);
    public HashToolViewModel HashToolViewModel();
}
