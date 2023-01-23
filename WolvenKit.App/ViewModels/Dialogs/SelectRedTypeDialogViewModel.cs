using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs;

public class SelectRedTypeDialogViewModel : DialogViewModel
{
    private readonly Dictionary<string, Type> _types;

    public SelectRedTypeDialogViewModel()
    {

        _types = Assembly.GetAssembly(typeof(RedBaseClass)).NotNull().GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IRedPrimitive)) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);

        Types = new ObservableCollection<string>(_types.Select(t => t.Key));

        OkCommand = ReactiveCommand.Create(() => DialogHandler?.Invoke(this), CanCreate);
        CancelCommand = ReactiveCommand.Create(() => DialogHandler?.Invoke(null));
    }

    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

    private IObservable<bool> CanCreate =>
        this.WhenAnyValue(
            x => x.SelectedTypeString,
            (c) => c is not null && Types.Contains(c)
        );

    [Reactive] public ObservableCollection<string> Types { get; set; } = new();
    [Reactive] public string? SelectedTypeString { get; set; }

    public Type? SelectedType => SelectedTypeString is null ? null : _types[SelectedTypeString];
}
