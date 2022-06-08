using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace WolvenKit.App.ViewModels.HomePage.Pages
{
    public class DebugPageViewModel : PageViewModel
    {
        #region Fields

        public static ObservableCollection<UserControl> _DialogsUC = new();
        public static ObservableCollection<UserControl> _EditorsUC = new();
        public static ObservableCollection<UserControl> _ToolsUC = new();
        public static ObservableCollection<UserControl> _WizardsUC = new();

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
