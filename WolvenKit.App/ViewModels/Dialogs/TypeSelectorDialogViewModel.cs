using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs;

public record TypeEntry(string Name, string Description, object? UserData);

public partial class TypeSelectorDialogViewModel : DialogViewModel
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private bool _allowCreating;

    [ObservableProperty]
    private ObservableCollection<TypeEntry> _entries;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private TypeEntry? _selectedEntry;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _enteredText;

    public TypeSelectorDialogViewModel(List<TypeEntry> entries, bool allowCreating = false)
    {
        _entries = new ObservableCollection<TypeEntry>(entries);
        _allowCreating = allowCreating;
    }

    private bool CanExecuteOk() => (AllowCreating && EnteredText is not null && EnteredText != "") || SelectedEntry != null;

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        if (AllowCreating && EnteredText is not null && EnteredText != "")
        {
            SelectedEntry = new TypeEntry(EnteredText, "", typeof(DynamicBaseClass));
        }
        DialogHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel() => DialogHandler?.Invoke(null);
}