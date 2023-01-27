using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using Splat;
using WolvenKit.Core.Extensions;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ScriptManagerViewModel : DialogViewModel, IActivatableViewModel
{
    private readonly AppViewModel _appViewModel;

    private const string ScriptExtension = ".wscript";

    public ScriptManagerViewModel(AppViewModel? appViewModel = null)
    {
        _appViewModel = appViewModel ?? Locator.Current.GetService<AppViewModel>().NotNull();

        OkCommand = ReactiveCommand.Create(() => _appViewModel.CloseModalCommand.Execute(null));
        CancelCommand = ReactiveCommand.Create(() => _appViewModel.CloseModalCommand.Execute(null));

        this.WhenActivated(disposables =>
        {
            HandleActivation();

            Disposable
                .Create(HandleDeactivation)
                .DisposeWith(disposables);
        });

        this.WhenAnyValue(x => x.SelectedItem)
            .Subscribe(x => DeleteScriptCommand.NotifyCanExecuteChanged());
    }

    public ObservableCollection<string> Scripts { get; } = new();
    [ObservableProperty] private string? _selectedItem;
    [ObservableProperty] private string? _fileName;

    public ViewModelActivator Activator { get; } = new();
    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

    private void HandleActivation() => GetScriptFiles();

    private void HandleDeactivation()
    {

    }

    [RelayCommand]
    private void AddScript()
    {
        if (string.IsNullOrEmpty(FileName))
        {
            return;
        }

        if (!FileName.EndsWith(ScriptExtension))
        {
            FileName += ScriptExtension;
        }

        if (Scripts.Any(scriptEntry => scriptEntry == FileName))
        {
            return;
        }

        File.Create(Path.Combine(ISettingsManager.GetWScriptDir(), FileName)).Close();
        Scripts.Add(FileName);
    }

    [RelayCommand(CanExecute = nameof(CanDeleteScript))]
    private async void DeleteScript()
    {
        if (SelectedItem is null)
        {
            return;
        }

        var response = await Interactions.ShowMessageBoxAsync(
            $"Are you sure you want to delete \"{SelectedItem}\"?",
            "Add file",
            WMessageBoxButtons.YesNo);

        if (response == WMessageBoxResult.Yes)
        {
            File.Delete(Path.Combine(ISettingsManager.GetWScriptDir(), SelectedItem));
            Scripts.Remove(SelectedItem);
            SelectedItem = null;
        }
    }

    public bool CanDeleteScript() => SelectedItem != null;

    public void GetScriptFiles()
    {
        foreach (var file in Directory.GetFiles(ISettingsManager.GetWScriptDir(), $"*{ScriptExtension}"))
        {
            Scripts.Add(Path.GetFileName(file));
        }
    }

    public void OpenFile()
    {
        if (SelectedItem is null)
        {
            return;
        }
        _appViewModel.RequestFileOpen(Path.Combine(ISettingsManager.GetWScriptDir(), SelectedItem));
        _appViewModel.CloseModalCommand.Execute(null);
    }
}