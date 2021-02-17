
using Catel.IoC;
using HandyControl.Controls;
using WolvenKit.Model.Wizards;
using WolvenKit.Services;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class FinalizeSetupView
    {
        private readonly ISettingsManager _settingsManager;
        private readonly FirstSetupWizardViewModel _fswvm;
        private readonly FirstSetupWizardModel _fswm;

        public FinalizeSetupView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _fswvm = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
            _fswm = ServiceLocator.Default.ResolveType<FirstSetupWizardModel>();

            imgSelector.CommandBindings[0].Executed += imgSelector_Executed;
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_fswm.ProfileImageBrush != null)
            {
                imgSelector.SetValue(ImageSelector.UriPropertyKey, new System.Uri(_fswm.ProfileImageBrushPath, System.UriKind.RelativeOrAbsolute));
                imgSelector.SetValue(ImageSelector.PreviewBrushPropertyKey, _fswm.ProfileImageBrush);
                imgSelector.SetValue(ImageSelector.HasValuePropertyKey, true);
                imgSelector.SetCurrentValue(ImageSelector.ToolTipProperty, _fswm.ProfileImageBrushPath);
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
                _fswm.ProfileImageBrush = imgBrush;
                _fswm.ProfileImageBrushPath = imgSelector.Uri.AbsoluteUri;
            }
            else
            {
                _fswm.ProfileImageBrush = default(System.Windows.Media.ImageBrush);
                _fswm.ProfileImageBrushPath = "";
            }
        }

        private async void ConfirmSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            await _fswvm.SaveViewModelAsync();
            _settingsManager.Save();
            await _fswvm.CloseViewModelAsync(null);
        }

        private void CancelSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _fswvm.CloseViewModelAsync(null);
        }
    }
}
