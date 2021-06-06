using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class ToolSettingsView
    {
        #region Fields

        private AssetBrowserSubSettingsView ABSSV;

        private CodeEditorSubSettingsView CESSV;

        private PluginManagerSubSettingsView PMSSV;

        private VisualEditorSubSettingsView VESSV;

        #endregion Fields

        #region Constructors

        public ToolSettingsView()
        {
            ABSSV = new AssetBrowserSubSettingsView();
            PMSSV = new PluginManagerSubSettingsView();
            CESSV = new CodeEditorSubSettingsView();
            VESSV = new VisualEditorSubSettingsView();

            InitializeComponent();

            SettingsViewer.Children.Add(ABSSV);
            AssetBrowserSubItem.IsSelected = true;
        }

        #endregion Constructors

        #region Methods

        private void AssetBrowserSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(ABSSV);
            }
        }

        private void CodeEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(CESSV);
            }
        }

        private void PluginManagerSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(PMSSV);
            }
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
               // DiscordHelper.SetDiscordRPCStatus("Setting - Tools");
            }
        }

        private void VisualEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(VESSV);
            }
        }

        #endregion Methods
    }
}
