using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.Views.Wizards
{
    public partial class InstallerWizardView : ReactiveUserControl<InstallerWizardViewModel>
    {
        public InstallerWizardView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<InstallerWizardViewModel>();
            DataContext = ViewModel;
        }
    }
}
