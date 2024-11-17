using System.Reactive.Disposables;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class FirstSetupView : IViewFor<FirstSetupViewModel>
    {
        public FirstSetupView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<FirstSetupViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                WizardControl.Finish += (sender, args) =>
                {
                    ViewModel.ExecuteFinish();
                };

                this.Bind(ViewModel,
                        vm => vm.AllFieldsValid,
                        v => v.WizardControl.FinishEnabled)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                    vm => vm.OpenCP77GamePathCommand,
                    v => v.cp77ExeButton).DisposeWith(disposables);

                this.BindCommand(ViewModel,
                    vm => vm.OpenDepotPathCommand,
                    v => v.matdepotButton).DisposeWith(disposables);

                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.helpButton,
                    vm => vm.WikiHelpLink);
            });

        }

        public FirstSetupViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (FirstSetupViewModel)value; }

        private void Field_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => ValidateAllFields();

        private void ValidateAllFields() => ViewModel.AllFieldsValid = !ViewModel.HasErrors;
    }
}
