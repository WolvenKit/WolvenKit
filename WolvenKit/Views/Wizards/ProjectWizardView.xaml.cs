using Catel.IoC;
using Catel.Windows;
using Catel.Windows.Controls;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView : UserControl //: DataWindow
    {

        public ProjectWizardView()
        {

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            => ValidateAllFields();

        private void ValidateAllFields()
        {
            if (ViewModel is ProjectWizardViewModel vm)
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

    }
}
