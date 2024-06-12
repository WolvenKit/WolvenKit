using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SaveGameSelectionDialogModel : DialogViewModel
{
    [ObservableProperty] private string? _selectedSave;
    [ObservableProperty] private List<SaveGame> _saveGames;

    public SaveGameSelectionDialogModel() => SaveGames = ISettingsManager.GetSaveGames();
}