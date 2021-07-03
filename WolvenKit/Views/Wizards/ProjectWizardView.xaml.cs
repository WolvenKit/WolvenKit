using Catel.IoC;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models.Wizards;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Wizards.WizardPages.ProjectWizard;

namespace WolvenKit.Views.Wizards
{
    public partial class ProjectWizardView
    {
        private readonly ProjectWizardViewModel _fswvm;

        public ProjectWizardView()
        {
            ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectWizardModel>();
            _fswvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();

            InitializeComponent();
        }

        private void wizardControl_Finish(object sender, System.Windows.RoutedEventArgs e)
        {
        }
    }
}
