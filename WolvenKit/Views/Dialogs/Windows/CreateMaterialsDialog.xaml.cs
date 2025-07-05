using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class CreateMaterialsDialog : IViewFor<CreateMaterialsDialogViewModel>
    {
        private static string s_lastMaterial = "";
        private static bool? s_lastResolve;
        private static bool? s_lastLocal;

        public CreateMaterialsDialog()
        {
            InitializeComponent();


            ViewModel = Locator.Current.GetService<CreateMaterialsDialogViewModel>();
            DataContext = ViewModel;

            LoadLastSelection();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.BaseMaterial,
                        x => x.BaseMaterialBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.IsLocalMaterial,
                        x => x.LocalMaterialCheckBox.IsChecked)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ResolveSubstitutions,
                        x => x.ResolveDynamicCheckBox.IsChecked)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.RememberValues,
                        x => x.RememberValuesCheckBox.IsChecked)
                    .DisposeWith(disposables);
            });
        }

        public CreateMaterialsDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (CreateMaterialsDialogViewModel)value; }

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

            if (s_lastMaterial != "")
            {
                ViewModel.BaseMaterial = s_lastMaterial;
                ViewModel.RememberValues = true;
            }

            if (s_lastLocal is not null)
            {
                ViewModel.IsLocalMaterial = true;
                ViewModel.RememberValues = true;
            }

            if (s_lastResolve is not null)
            {
                ViewModel.ResolveSubstitutions = true;
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
                s_lastMaterial = "";
                s_lastLocal = null;
                s_lastResolve = null;
                return;
            }

            s_lastMaterial = ViewModel.BaseMaterial;
            s_lastLocal = ViewModel.IsLocalMaterial;
            s_lastResolve = ViewModel.ResolveSubstitutions;
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
    }
}