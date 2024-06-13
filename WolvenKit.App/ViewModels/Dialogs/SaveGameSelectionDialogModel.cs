using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

// public record SaveGame(string Name, string Description, object? UserData);

public partial class SaveGameSelectionDialogModel : DialogViewModel
{
    [ObservableProperty] private string? _selectedSave;
    [ObservableProperty] private List<SaveGame> _saveGames;

    public SaveGameSelectionDialogModel() => SaveGames = ISettingsManager.GetSaveGames();

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private SaveGame? _selectedEntry;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private SaveGame? _selectedEntryName;

    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string _enteredText = "";

    private bool CanExecuteOk()
    {
        return SelectedEntry != null;
    }

    public void SetSelectedSave(string saveGameName)
    {
        if (SaveGames.Find(s => s.DirName == saveGameName) is SaveGame sg)
        {
            SelectedEntry = sg;
        }
    }

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        DialogHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel() => DialogHandler?.Invoke(null);
}