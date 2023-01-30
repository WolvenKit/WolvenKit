using System;
using System.Reactive;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.HomePage.Pages;



public partial class PluginsToolViewModel : DialogViewModel
{
    private readonly ILoggerService _logger;
    [ObservableProperty] private IPluginService _pluginService;


    public delegate Task ReturnHandler(PluginsToolViewModel? file);
    public ReturnHandler? FileHandler;

    public PluginsToolViewModel()
    {
        _logger = Locator.Current.GetService<ILoggerService>().NotNull();
        _pluginService = Locator.Current.GetService<IPluginService>().NotNull();

#pragma warning disable IDE0053 // Use expression body for lambda expression
        CancelCommand = ReactiveCommand.Create(() =>
        {
            FileHandler?.Invoke(null);
        });
#pragma warning restore IDE0053 // Use expression body for lambda expression
        SyncCommand = ReactiveCommand.CreateFromTask(SyncAsync);
    }


    [ObservableProperty] private PluginViewModel? _selectedPlugin;


    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }
    public ReactiveCommand<Unit, Unit> SyncCommand { get; set; }

    public override ReactiveCommand<Unit, Unit> OkCommand => throw new NotImplementedException();

    public async Task SyncAsync() => await PluginService.CheckForUpdatesAsync();

}
