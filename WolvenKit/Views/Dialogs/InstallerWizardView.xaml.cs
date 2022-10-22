using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;

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
