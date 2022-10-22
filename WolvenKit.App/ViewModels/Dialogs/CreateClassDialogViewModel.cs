using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class CreateClassDialogViewModel : DialogViewModel
    {
        private readonly Dictionary<string, Type> _typeMap = new();

        public CreateClassDialogViewModel(ObservableCollection<string> existingClasses, bool allowOthers = true)
        {
            ExistingClasses = existingClasses;
            Classes = allowOthers
                ? new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(t => t.IsAssignableTo(typeof(IRedClass)) && t.IsClass && !t.IsAbstract)
                    .Select(t => t.Name))
                : ExistingClasses;

            if (allowOthers)
            {
                _typeMap = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(t => t.IsAssignableTo(typeof(IRedClass)) && t.IsClass && !t.IsAbstract)
                    .ToDictionary(obj => obj.Name, obj => obj);

                Classes = new ObservableCollection<string>(_typeMap.Keys);
            }

            OkCommand = ReactiveCommand.Create(() => DialogHandler(this), CanOk);
            CancelCommand = ReactiveCommand.Create(() => DialogHandler(null));
        }

        public override ReactiveCommand<Unit, Unit> OkCommand { get; }
        public override ReactiveCommand<Unit, Unit> CancelCommand { get; }

        private IObservable<bool> CanOk =>
            this.WhenAnyValue(
                x => x.SelectedClass,
                (c) => Classes.Contains(c)
            );

        [Reactive] public ObservableCollection<string> Classes { get; set; }

        [Reactive] public ObservableCollection<string> ExistingClasses { get; set; }

        [Reactive] public string SelectedClass { get; set; }

        public Type SelectedType => _typeMap[SelectedClass];
    }
}
