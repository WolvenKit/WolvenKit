using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class GeneralSettingsView
    {
        #region Fields

        private AccountSubSettingsView ASSV;

        private GlobalSubSettingsView GSSV;

        private LoggingSubSettingsView LSSV;

        private ThemeSubSettingsView TSSV;

        private UpdatesSubSettingsView USSV;

        #endregion Fields

        #region Constructors

        public GeneralSettingsView()
        {
            GSSV = new GlobalSubSettingsView();
            ASSV = new AccountSubSettingsView();
            USSV = new UpdatesSubSettingsView();
            TSSV = new ThemeSubSettingsView();
            LSSV = new LoggingSubSettingsView();

            InitializeComponent();

            SettingsViewer.Children.Add(GSSV);
            GlobalSubItem.IsSelected = true;
        }

        #endregion Constructors

        #region Methods

        private void AccountSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(ASSV);
            }
        }

        private void GlobalSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(GSSV);
            }
        }

        private void LoggingSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(LSSV);
            }
        }

        private void ThemeSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(TSSV);
            }
        }

        private void UpdatesSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(USSV);
            }
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
               // DiscordHelper.SetDiscordRPCStatus("Setting - General");
            }
        }

        #endregion Methods
    }
}
