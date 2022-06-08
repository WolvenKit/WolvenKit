using System;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using WolvenKit.App.ViewModels.Wizards;
using WolvenKit.Core;

namespace WolvenKit.Views.Wizards
{
    public partial class FirstSetupWizardView : ReactiveUserControl<FirstSetupWizardViewModel>
    {

        #region Constructors

        public FirstSetupWizardView()
        {
            InitializeComponent();

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

            });

            this.WhenActivated(disposables => this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.helpButton,
                    vm => vm.WikiHelpLink));

        }

        #endregion Constructors
        //private void Circle_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    _lastaccent = a.Fill;
        //    //a.Fill = new SolidColorBrush(Colors.AliceBlue);
        //}

        //private void Circle_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    a.Fill = _lastaccent;
        //}

        //private void Circle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    var a = (Ellipse)sender;
        //    //a.Fill = new SolidColorBrush(Colors.Black);
        //    //ThemeManager.Current.ChangeTheme(Application.Current, "Dark." + a.Name);

        //    try
        //    {
        //        var color = ((SolidColorBrush)a.Fill).Color;
        //        var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
        //        settings.SetThemeAccent(color);
        //    }
        //    catch
        //    {
        //        // swallow
        //    }
        //}

        #region Methods

        #region Validation

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

        #endregion Methods


        #endregion Methods

    }
}
