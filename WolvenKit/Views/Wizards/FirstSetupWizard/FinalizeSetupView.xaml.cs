using Catel.IoC;
using HandyControl.Controls;
using WolvenKit.Functionality.Services;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.ViewModels.Wizards.FirstSetupWizard;

namespace WolvenKit.Views.Wizards.WizardPages.FirstSetupWizard
{
    public partial class FinalizeSetupView
    {
        #region Fields

        private readonly FirstSetupWizardModel _fswm;
        private readonly FirstSetupWizardViewModel _fswvm;
        private readonly ISettingsManager _settingsManager;

        #endregion Fields

        #region Constructors

        public FinalizeSetupView()
        {
            InitializeComponent();

            _settingsManager = ServiceLocator.Default.ResolveType<ISettingsManager>();
            _fswvm = ServiceLocator.Default.ResolveType<FirstSetupWizardViewModel>();
            _fswm = ServiceLocator.Default.ResolveType<FirstSetupWizardModel>();

            imgSelector.CommandBindings[0].Executed += imgSelector_Executed;
        }

        #endregion Constructors

        #region Methods

        private void CancelSettings_Click(object sender, System.Windows.RoutedEventArgs e) => _fswvm.CloseViewModelAsync(null);

        private async void ConfirmSettings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            await _fswvm.SaveViewModelAsync();

            _settingsManager.ProfileImageBrush = _fswm.ProfileImageBrush;
            _settingsManager.Save();
            await _fswvm.CloseViewModelAsync(null);
        }

        /// <summary>
        /// Exectues on image selected event.
        /// </summary>
        private void imgSelector_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            var imgSelector = sender as ImageSelector;
            var imgBrush = imgSelector.PreviewBrush as System.Windows.Media.ImageBrush;
            if (imgBrush != null)
            {
                _fswm.ProfileImageBrush = imgBrush;
                _fswm.ProfileImageBrushPath = imgSelector.Uri.AbsoluteUri;
            }
            else
            {
                var frame = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(FinalizeSetupViewModel.bpp));
                _fswm.ProfileImageBrush = new System.Windows.Media.ImageBrush(frame);
                _fswm.ProfileImageBrushPath = FinalizeSetupViewModel.bpp;
            }
        }

        #endregion Methods
    }
}
