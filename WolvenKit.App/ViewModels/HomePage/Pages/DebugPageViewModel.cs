using System.Collections.ObjectModel;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.ViewModels.HomePage;


namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class DebugPageViewModel : PageViewModel
    {
        #region Fields

        public static ObservableCollection<UserControl> _DialogsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _EditorsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _ToolsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _WizardsUC = new ObservableCollection<UserControl>();

        #endregion Fields

        #region Constructors

        public DebugPageViewModel()
        {
            InitThis();
        }

        #endregion Constructors

        #region Properties

        public ObservableCollection<UserControl> DialogsUC => _DialogsUC;
        public ObservableCollection<UserControl> EditorsUC => _EditorsUC;
        public ObservableCollection<UserControl> ToolsUC => _ToolsUC;
        public ObservableCollection<UserControl> WizardsUC => _WizardsUC;

        #endregion Properties

        #region Methods

        public void InitThis()
        {
        }

        #endregion Methods
    }
}
