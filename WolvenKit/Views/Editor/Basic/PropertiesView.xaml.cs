using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class PropertiesView
    {
        #region Constructors

        public PropertiesView()
        {
            InitializeComponent();
            StaticReferences.GlobalPropertiesView = this;
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Properties View");
            }
        }

        #endregion Methods
    }
}
