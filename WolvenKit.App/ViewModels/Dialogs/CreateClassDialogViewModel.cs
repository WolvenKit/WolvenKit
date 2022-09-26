using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Dialogs
{
    public class CreateClassDialogViewModel : DialogViewModel
    {
        public CreateClassDialogViewModel(ObservableCollection<string> existingClasses, bool allowOthers = true)
        {
            ExistingClasses = existingClasses;
            Classes = allowOthers
                ? new ObservableCollection<string>(Assembly.GetAssembly(typeof(RedBaseClass)).GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(RedBaseClass)) && !t.IsAbstract)
                    .Select(t => t.Name))
                : ExistingClasses;
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
    }
}
