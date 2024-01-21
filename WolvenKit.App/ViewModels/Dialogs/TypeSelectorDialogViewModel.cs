﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WolvenKit.App.ViewModels.Dialogs;

public record TypeEntry(string Name, string Description, object? UserData);

public partial class TypeSelectorDialogViewModel : DialogViewModel
{
    [ObservableProperty]
    private ObservableCollection<TypeEntry> _entries;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private TypeEntry? _selectedEntry;

    public TypeSelectorDialogViewModel(List<TypeEntry> entries)
    {
        _entries = new ObservableCollection<TypeEntry>(entries);
    }

    private bool CanExecuteOk() => SelectedEntry != null;

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok() => DialogHandler?.Invoke(this);

    [RelayCommand]
    private void Cancel() => DialogHandler?.Invoke(null);
}