using System;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView : ReactiveUserControl<ProjectWizardViewModel>
    {

        public ProjectWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<ProjectWizardViewModel>();
            DataContext = ViewModel;

            this.WhenAnyValue(x => x.ViewModel)
                .BindTo(this, x => x.DataContext);
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            => ValidateAllFields();

        private void ValidateAllFields()
        {
            if (ViewModel is { } vm)
            {
                vm.AllFieldsValid = /*projectNameTxtbx.VerifyData() &&*/ projectPathTxtbx.VerifyData();
            }
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
            => System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed("Selected path does not exist");

        private HandyControl.Data.OperationResult<bool> VerifyIfProjectExists(string str)
            => string.IsNullOrEmpty(str) || System.IO.Directory.Exists(System.IO.Path.Combine(projectPathTxtbx.Text, xprojectNameTxtbx.Text))
                ? HandyControl.Data.OperationResult.Failed("WolvenKit project exists")
                : HandyControl.Data.OperationResult.Success();

        private void ButtonClose(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        private void ButtonMinimize(object sender, RoutedEventArgs e) => throw new NotImplementedException();

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => throw new NotImplementedException();


    }
}
