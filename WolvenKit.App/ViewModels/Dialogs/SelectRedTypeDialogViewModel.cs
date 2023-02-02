using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class SelectRedTypeDialogViewModel : DialogViewModel
{
    private readonly Dictionary<string, Type> _internalTypes;

    public SelectRedTypeDialogViewModel()
    {

        _internalTypes = Assembly.GetAssembly(typeof(RedBaseClass)).NotNull().GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IRedPrimitive)) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);

        Types = new ObservableCollection<string>(_internalTypes.Select(t => t.Key));
    }

    [ObservableProperty] private ObservableCollection<string> _types = new();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OkCommand))]
    private string? _selectedTypeString;

    public Type? SelectedType => SelectedTypeString is null ? null : _internalTypes[SelectedTypeString];


    private bool CanExecuteOk() => SelectedTypeString is not null && Types.Contains(SelectedTypeString);
    [RelayCommand(CanExecute = nameof(CanExecuteOk))]
    private void Ok()
    {
        DialogHandler?.Invoke(this);
    }

    [RelayCommand]
    private void Cancel()
    {
        DialogHandler?.Invoke(null);
    }
}
