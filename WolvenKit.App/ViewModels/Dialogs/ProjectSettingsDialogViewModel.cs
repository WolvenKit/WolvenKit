using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ProjectSettingsDialogViewModel : DialogViewModel, IActivatableViewModel
{
    private readonly IProjectManager _projectManager;
    private readonly IPluginService _pluginService;
    private readonly AppViewModel _appViewModel;


    public ViewModelActivator Activator { get; } = new();
    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }


    [ObservableProperty] private Cp77Project _project = null!;


    public bool IsRedModInstalled => _pluginService.IsInstalled(EPlugin.redmod);

    public ProjectSettingsDialogViewModel(IProjectManager? projectManager = null, IPluginService? pluginService = null, AppViewModel? appViewModel = null)
    {
        _projectManager = projectManager ?? Locator.Current.GetService<IProjectManager>().NotNull();
        _pluginService = pluginService ?? Locator.Current.GetService<IPluginService>().NotNull();
        _appViewModel = appViewModel ?? Locator.Current.GetService<AppViewModel>().NotNull();

        OkCommand = ReactiveCommand.CreateFromTask(ExecuteOk);
        CancelCommand = ReactiveCommand.Create(ExecuteCancel);

        HandleActivation();

        this.WhenActivated(disposables =>
        {
            Disposable
                .Create(HandleDeactivation)
                .DisposeWith(disposables);
        });
    }

    [MemberNotNull(nameof(Project))]
    private void HandleActivation()
    {
        if (_projectManager.ActiveProject is not Cp77Project project)
        {
            throw new NotImplementedException();
        }

        Project = project;
    }

    private void HandleDeactivation()
    {

    }

    private async Task<Unit> ExecuteOk()
    {
        await _projectManager.SaveAsync();

        _appViewModel.CloseModalCommand.Execute(null);

        return Unit.Default;
    }

    private void ExecuteCancel() => _appViewModel.CloseModalCommand.Execute(null);
}
