using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class PluginsToolViewModel : DialogViewModel
{
    private readonly ILoggerService _logger;
    [ObservableProperty] private IPluginService _pluginService;


    public delegate Task ReturnHandler(PluginsToolViewModel? file);

    public ReturnHandler? FileHandler;

    public PluginsToolViewModel(ILoggerService logger, IPluginService pluginService)
    {
        _logger = logger;
        _pluginService = pluginService;
    }


    [ObservableProperty]
    private PluginViewModel? _selectedPlugin;

    [RelayCommand]
    private async Task Sync() => await PluginService.CheckForUpdatesAsync();

    [RelayCommand]
    private void Ok() => throw new NotImplementedException();

    [RelayCommand]
    private void Cancel() => FileHandler?.Invoke(null);

}
