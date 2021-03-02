
using Catel.IoC;
using HandyControl.Controls;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.ProjectWizard
{
    public partial class FinalizeSetupView
    {
        ProjectWizardViewModel _pwvm;

        public FinalizeSetupView()
        {
            InitializeComponent();

            var command = ServiceLocator.Default.ResolveType<ApplicationCreateNewProjectCommandContainer>();
            command.OnCommandCompleted += () => CancelProjectBtn_Click(null, null);

            _pwvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();
            imgSelector.CommandBindings[0].Executed += imgSelector_Executed;
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
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


        private void CancelProjectBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _pwvm.CloseViewModelAsync(null);
        }
    }
}
