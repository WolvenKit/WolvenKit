using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs
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
            CreateCommand = ReactiveCommand.Create(() => DialogHandler(this), CanCreate);
            CancelCommand = ReactiveCommand.Create(() => DialogHandler(null));
        }

        public ICommand CreateCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        private IObservable<bool> CanCreate =>
            this.WhenAnyValue(
                x => x.SelectedClass,
                (c) => Classes.Contains(c)
            );

        [Reactive] public ObservableCollection<string> Classes { get; set; }

        [Reactive] public ObservableCollection<string> ExistingClasses { get; set; }

        [Reactive] public string SelectedClass { get; set; }
    }
}
