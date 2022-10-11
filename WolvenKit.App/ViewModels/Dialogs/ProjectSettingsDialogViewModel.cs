using System;
using System.Reactive;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Dialogs;

public class ProjectSettingsDialogViewModel : DialogViewModel, IActivatableViewModel
{
    private readonly IProjectManager _projectManager;
    private readonly IPluginService _pluginService;
    private readonly AppViewModel _appViewModel;


    public ViewModelActivator Activator { get; } = new();
    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }


    [Reactive] public Cp77Project Project { get; set; }


    public bool IsRedModInstalled => _pluginService.IsInstalled(EPlugin.redmod);

    public ProjectSettingsDialogViewModel(IProjectManager projectManager = null, IPluginService pluginService = null, AppViewModel appViewModel = null)
    {
        _projectManager = projectManager ?? Locator.Current.GetService<IProjectManager>();
        _pluginService = pluginService ?? Locator.Current.GetService<IPluginService>();
        _appViewModel = appViewModel ?? Locator.Current.GetService<AppViewModel>();

        OkCommand = ReactiveCommand.CreateFromTask(ExecuteOk);
        CancelCommand = ReactiveCommand.Create(ExecuteCancel);

        this.WhenActivated(disposables =>
        {
            HandleActivation();

            Disposable
                .Create(HandleDeactivation)
                .DisposeWith(disposables);
        });
    }

    private void HandleActivation()
    {
        if (_projectManager.ActiveProject is not Cp77Project project)
        {
            throw new Exception();
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
