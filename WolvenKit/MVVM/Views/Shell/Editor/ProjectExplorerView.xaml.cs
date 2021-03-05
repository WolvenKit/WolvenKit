using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView
    {
        #region Constructors

        public ProjectExplorerView()
        {
            InitializeComponent();

            //ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Project Explorer");
            }
        }

        #endregion Methods
    }
}
