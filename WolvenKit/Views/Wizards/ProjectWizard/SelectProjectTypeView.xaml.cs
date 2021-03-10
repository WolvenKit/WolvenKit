using Catel.IoC;
using WolvenKit.MVVM.ViewModels.Components.Wizards;

namespace WolvenKit.Views.Wizards.WizardPages.ProjectWizard
{
    public partial class SelectProjectTypeView
    {
        #region Fields

        private readonly ProjectWizardViewModel _fswvm;

        #endregion Fields

        #region Constructors

        public SelectProjectTypeView()
        {
            InitializeComponent();

            _fswvm = ServiceLocator.Default.ResolveType<ProjectWizardViewModel>();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e) => _fswvm.AllFieldIsValid = true;

        #endregion Methods
    }
}
