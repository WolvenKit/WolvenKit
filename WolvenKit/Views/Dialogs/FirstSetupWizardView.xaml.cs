using System;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.Core;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView : IViewFor<FirstSetupWizardViewModel>
    {
        public FirstSetupWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<FirstSetupWizardViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                Observable
                    .FromEventPattern(WizardControl, nameof(Syncfusion.Windows.Tools.Controls.WizardControl.Finish))
                    .Subscribe(_ => ViewModel.OkCommand.Execute().Subscribe())
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                    vm => vm.CP77ExePath,
                    v => v.cp77ExeTxtb.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        vm => vm.MaterialDepotPath,
                        v => v.matdepotxtb.Text)
                    .DisposeWith(disposables);
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

        public FirstSetupWizardViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (FirstSetupWizardViewModel)value; }

        private void Field_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => ValidateAllFields();

        private void ValidateAllFields() => ViewModel.AllFieldsValid = matdepotxtb.VerifyData() && cp77ExeTxtb.VerifyData();

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (File.Exists(str) && System.IO.Path.GetFileName(str).Equals(Core.Constants.Red4Exe))
            {
                var oodle = Path.Combine(new FileInfo(str).Directory.FullName, Constants.Oodle);
                if (!File.Exists(oodle))
                {
                    ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                        $"Oodle dll was not found within the game installation. Please make sure you have {Constants.Oodle} next to your game executable.");
                    return HandyControl.Data.OperationResult.Failed();
                }
                ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return HandyControl.Data.OperationResult.Success();
            }

            ValidationText.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            ValidationText.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty,
                "Locate game executable (.exe) for full WolvenKit functionality.");
            return HandyControl.Data.OperationResult.Failed();
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str) => System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed();

    }
}
