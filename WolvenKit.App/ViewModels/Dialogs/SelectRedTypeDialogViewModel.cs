using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs;

public class SelectRedTypeDialogViewModel : DialogViewModel
{
    private readonly Dictionary<string, Type> _types;

    public SelectRedTypeDialogViewModel()
    {
        _types = Assembly.GetAssembly(typeof(RedBaseClass)).GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IRedPrimitive)) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);

        Types = new ObservableCollection<string>(_types.Select(t => t.Key));

        OkCommand = ReactiveCommand.Create(() => DialogHandler(this), CanCreate);
        CancelCommand = ReactiveCommand.Create(() => DialogHandler(null));
    }

    public override ReactiveCommand<Unit, Unit> OkCommand { get; }
    public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

    private IObservable<bool> CanCreate =>
        this.WhenAnyValue(
            x => x.SelectedTypeString,
            (c) => Types.Contains(c)
        );

    [Reactive] public ObservableCollection<string> Types { get; set; }
    [Reactive] public string SelectedTypeString { get; set; }

    public Type SelectedType => _types[SelectedTypeString];
}
