
using Catel.IoC;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.MVVM.Views.Components.Wizards.WizardPages.ProjectWizard
{
    public partial class SelectProjectTypeView
    {
        private readonly ProjectWizardViewModel _fswvm;

        public SelectProjectTypeView()
        {
            InitializeComponent();

            _fswvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            _fswvm.AllFieldIsValid = true;
        }
    }
}
