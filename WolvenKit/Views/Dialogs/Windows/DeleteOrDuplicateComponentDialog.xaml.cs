using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class DeleteOrDuplicateComponentDialog : IViewFor<DeleteOrDuplicateComponentDialogViewModel>
    {
        private static string s_lastComponentName = "";
        private static string s_lastNewComponentName = "";

        public DeleteOrDuplicateComponentDialog(List<string> componentNames, bool isDeleting = false)
        {
            InitializeComponent();

            ViewModel = new DeleteOrDuplicateComponentDialogViewModel(componentNames, isDeleting);
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.ComponentName,
                        x => x.FilterableDropdownMenu.SelectedOption)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ComponentNames,
                        x => x.FilterableDropdownMenu.Options)
                    .DisposeWith(disposables);
            });
        }

        public DeleteOrDuplicateComponentDialogViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (DeleteOrDuplicateComponentDialogViewModel)value;
        }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void LoadLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (s_lastComponentName != "")
            {
                ViewModel.ComponentName = s_lastComponentName;
                ViewModel.RememberValues = true;
            }

            if (s_lastNewComponentName != "")
            {
                ViewModel.ComponentName = s_lastComponentName;
                ViewModel.RememberValues = true;
            }
        }

        private void SaveLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!ViewModel.RememberValues)
            {
                s_lastComponentName = "";
                s_lastNewComponentName = "";
                return;
            }

            s_lastComponentName = ViewModel.ComponentName;
            s_lastNewComponentName = ViewModel.NewComponentName;
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            SaveLastSelection();
            e.Handled = true;
            DialogResult = true;
            Close();
        }

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

        private void OnFilterableDropdownChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ViewModel is not null && sender is FilterableDropdownMenu f)
            {
                ViewModel.ComponentName = f.SelectedOption;
            }
        }
    }
}