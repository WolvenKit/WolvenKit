using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class EditorSettingsView
    {
        #region Fields

        private CompatibilitySubSettingsView CSSV;

        private GeneralSubSettingsView GSSV;

        #endregion Fields

        #region Constructors

        public EditorSettingsView()
        {
            GSSV = new GeneralSubSettingsView();
            CSSV = new CompatibilitySubSettingsView();

            InitializeComponent();

            SettingsViewer.Children.Add(GSSV);
            GeneralSubItem.IsSelected = true;
        }

        #endregion Constructors

        #region Methods

        private void CompatibilitySubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(CSSV);
            }
        }

        private void GeneralSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(GSSV);
            }
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Setting - Editor");
            }
        }

        #endregion Methods
    }
}
