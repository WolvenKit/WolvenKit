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
    private bool _allowCreating;

    [ObservableProperty]
    private ObservableCollection<TypeEntry> _entries;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private TypeEntry? _selectedEntry;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string _enteredText = "";

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private int _selectedMode;

    public TypeSelectorDialogViewModel(List<TypeEntry> entries, bool allowCreating = false)
    {
        _entries = new ObservableCollection<TypeEntry>(entries);
        _allowCreating = allowCreating;
    }

    private bool CanExecuteOk()
    {
        if (SelectedMode == 0 && SelectedEntry != null)
        {
            return true;
        }

        if (SelectedMode == 1 && !string.IsNullOrEmpty(EnteredText))
        {
            return true;
        }
        
        return false;
    }

    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        if (SelectedMode == 1)
        {
            SelectedEntry = new TypeEntry(EnteredText!, "", typeof(DynamicBaseClass));
        }
        DialogHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel() => DialogHandler?.Invoke(null);
}