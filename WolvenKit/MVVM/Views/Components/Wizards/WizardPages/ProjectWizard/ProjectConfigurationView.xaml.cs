using Catel.IoC;
using Catel.Services;
using HandyControl.Controls;
using WolvenKit.MVVM.ViewModels.Components.Wizards;
using WolvenKit.MVVM.ViewModels.Components.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard
{
    public partial class ProjectConfigurationView
    {
        private readonly ISelectDirectoryService _selectDirectoryService;
        private readonly ProjectWizardViewModel _pwvm;

        public ProjectConfigurationView()
        {
            InitializeComponent();

            _selectDirectoryService = ServiceLocator.Default.ResolveType<ISelectDirectoryService>();
            _pwvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();

            imgSelector.CommandBindings[0].Executed += imgSelector_Executed;
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            validateAllFields();
            if (_pwvm.ProfileImageBrush != null)
            {
                imgSelector.SetValue(ImageSelector.UriPropertyKey, new System.Uri(_pwvm.ProfileImageBrushPath, System.UriKind.RelativeOrAbsolute));
                imgSelector.SetValue(ImageSelector.PreviewBrushPropertyKey, _pwvm.ProfileImageBrush);
                imgSelector.SetValue(ImageSelector.HasValuePropertyKey, true);
                imgSelector.SetCurrentValue(ImageSelector.ToolTipProperty, _pwvm.ProfileImageBrushPath);
            }
            else
            {
                imgSelector.SetValue(ImageSelector.UriPropertyKey, default(System.Uri));
                imgSelector.SetValue(ImageSelector.PreviewBrushPropertyKey, default(System.Windows.Media.Brush));
                imgSelector.SetValue(ImageSelector.HasValuePropertyKey, false);
                imgSelector.SetCurrentValue(ImageSelector.ToolTipProperty, default);
            }
        }

        private void imgSelector_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            var imgBrush = imgSelector.PreviewBrush as System.Windows.Media.ImageBrush;
            if (imgBrush != null)
            {
                _pwvm.ProfileImageBrush = imgBrush;
                _pwvm.ProfileImageBrushPath = imgSelector.Uri.AbsoluteUri;
            }
            else
            {
                _pwvm.ProfileImageBrush = default(System.Windows.Media.ImageBrush);
                _pwvm.ProfileImageBrushPath = "";
            }
        }

        private async void ProjectPathBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var result = await _selectDirectoryService.DetermineDirectoryAsync(
                new DetermineDirectoryContext()
            );
            if (result.Result)
                (ViewModel as ProjectConfigurationViewModel).ProjectWizardModel.ProjectPath = result.DirectoryName;
        }

        private HandyControl.Data.OperationResult<bool> VerifyFolder(string str)
        {
            return System.IO.Directory.Exists(str)
                ? HandyControl.Data.OperationResult.Success()
                : HandyControl.Data.OperationResult.Failed("WolvenKit path does not exist");
        }

        private void validateAllFields()
        {
            _pwvm.AllFieldIsValid = projectNameTxtbx.VerifyData() && projectPathTxtbx.VerifyData();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            validateAllFields();
        }
    }
}
