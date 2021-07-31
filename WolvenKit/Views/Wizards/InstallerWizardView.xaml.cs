using ReactiveUI;
using Splat;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class InstallerWizardView : ReactiveUserControl<InstallerWizardViewModel>
    {
        #region Constructors

        public InstallerWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<InstallerWizardViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors

        #region Methods


        #endregion Methods
    }
}
