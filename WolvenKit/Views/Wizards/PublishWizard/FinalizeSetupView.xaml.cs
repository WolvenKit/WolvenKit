using Catel.IoC;
using HandyControl.Controls;
using WolvenKit.Models.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.PublishWizard
{
    public partial class FinalizeSetupView
    {
        #region Fields

        PublishWizardModel _pwm;

        #endregion Fields

        #region Constructors

        public FinalizeSetupView()
        {
            InitializeComponent();

            _pwm = ServiceLocator.Default.ResolveType<PublishWizardModel>();
            imgSelector.CommandBindings[0].Executed += imgSelector_Executed;
        }

        #endregion Constructors

        #region Methods

        private void imgSelector_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            var imgBrush = imgSelector.PreviewBrush as System.Windows.Media.ImageBrush;
            if (imgBrush != null)
            {
                _pwm.ProfileImageBrush = imgBrush;
                _pwm.ProfileImageBrushPath = imgSelector.Uri.AbsoluteUri;
            }
            else
            {
                _pwm.ProfileImageBrush = default(System.Windows.Media.ImageBrush);
                _pwm.ProfileImageBrushPath = "";
            }
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_pwm.ProfileImageBrush != null)
            {
                imgSelector.SetValue(ImageSelector.UriPropertyKey, new System.Uri(_pwm.ProfileImageBrushPath, System.UriKind.RelativeOrAbsolute));
                imgSelector.SetValue(ImageSelector.PreviewBrushPropertyKey, _pwm.ProfileImageBrush);
                imgSelector.SetValue(ImageSelector.HasValuePropertyKey, true);
                imgSelector.SetCurrentValue(ImageSelector.ToolTipProperty, _pwm.ProfileImageBrushPath);
            }
            else
            {
                imgSelector.SetValue(ImageSelector.UriPropertyKey, default(System.Uri));
                imgSelector.SetValue(ImageSelector.PreviewBrushPropertyKey, default(System.Windows.Media.Brush));
                imgSelector.SetValue(ImageSelector.HasValuePropertyKey, false);
                imgSelector.SetCurrentValue(ImageSelector.ToolTipProperty, default);
            }
        }

        #endregion Methods
    }
}
