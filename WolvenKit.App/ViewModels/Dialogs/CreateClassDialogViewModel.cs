using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class CreateClassDialogViewModel : DialogViewModel
{
    private readonly Dictionary<string, Type> _typeMap = new();

    public CreateClassDialogViewModel(ObservableCollection<string> existingClasses, bool allowOthers = true)
    {
        _existingClasses = existingClasses;
        _classes = allowOthers
            ? new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(t => t.IsAssignableTo(typeof(IRedClass)) && t.IsClass && !t.IsAbstract)
                .Select(t => t.Name))
            : _existingClasses;

        if (allowOthers)
        {
            _typeMap = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(t => t.IsAssignableTo(typeof(IRedClass)) && t.IsClass && !t.IsAbstract)
                .ToDictionary(obj => obj.Name, obj => obj);

            _classes = new ObservableCollection<string>(_typeMap.Keys);
        }

        OkCommand = ReactiveCommand.Create(() => DialogHandler?.Invoke(this), CanOk);
        CancelCommand = ReactiveCommand.Create(() => DialogHandler?.Invoke(null));
    }

    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

    private IObservable<bool> CanOk =>
        this.WhenAnyValue(
            x => x.SelectedClass,
            (c) => c is not null && Classes.Contains(c)
        );

    [ObservableProperty] private ObservableCollection<string> _classes;

    [ObservableProperty] private ObservableCollection<string> _existingClasses;

    [ObservableProperty] private string? _selectedClass;

    public Type? SelectedType
    {
        get
        {
            if (SelectedClass == null)
            {
                return null;
            }
            return _typeMap[SelectedClass];
        }
    }
}
