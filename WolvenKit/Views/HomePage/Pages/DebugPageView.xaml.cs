using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class DebugPageView : ReactiveUserControl<DebugPageViewModel>
    {
        #region Constructors

        public DebugPageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<DebugPageViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors
    }
}
