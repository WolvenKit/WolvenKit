using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class SelectFacialAnimationPathDialog : IViewFor<SelectAnimationPathViewModel>
    {
        public SelectFacialAnimationPathDialog(List<string> facialSetupPaths)
        {
            InitializeComponent();
            
            ViewModel = new SelectAnimationPathViewModel(facialSetupPaths);
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                // bind to filteredDropdownMenu
                this.Bind(ViewModel,
                        x => x.AnimGraphOptions,
                        x => x.FilterableDropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SelectedGraph,
                        x => x.FilterableDropdownMenu.SelectedOption)
                    .DisposeWith(disposables);
            });
        }

        public SelectAnimationPathViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SelectAnimationPathViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

    }
}