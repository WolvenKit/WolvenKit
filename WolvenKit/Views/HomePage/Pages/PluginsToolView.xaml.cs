using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.HomePage;


namespace WolvenKit.Views.HomePage.Pages
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class PluginsToolView : ReactiveUserControl<PluginsToolViewModel>
    {
        public PluginsToolView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PluginsToolViewModel>();
            DataContext = ViewModel;
        }
    }
}
