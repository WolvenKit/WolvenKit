using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ProjectSettingsDialogViewModel : DialogViewModel
{
    private readonly IProjectManager _projectManager;
    private readonly IPluginService _pluginService;
    private readonly AppViewModel _appViewModel;

    [ObservableProperty]
    private Cp77Project _project;


    public bool IsRedModInstalled => _pluginService.IsInstalled(EPlugin.redmod);

    public ProjectSettingsDialogViewModel(IProjectManager projectManager, IPluginService pluginService, AppViewModel appViewModel)
    {
        _projectManager = projectManager;
        _pluginService = pluginService;
        _appViewModel = appViewModel;

        _project = _projectManager.ActiveProject.NotNull();
    }

    [RelayCommand]
    private async Task<Unit> Ok()
    {
        await _projectManager.SaveAsync();

        _appViewModel.CloseModalCommand.Execute(null);

        return Unit.Default;
    }

    [RelayCommand]
    private void Cancel() => _appViewModel.CloseModalCommand.Execute(null);
}
