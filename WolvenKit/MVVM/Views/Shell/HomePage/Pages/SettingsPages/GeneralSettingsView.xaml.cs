using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages.SubPages.General;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages
{
    public partial class GeneralSettingsView
    {
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

        private GlobalSubSettingsView GSSV;
        private AccountSubSettingsView ASSV;
        private UpdatesSubSettingsView USSV;
        private ThemeSubSettingsView TSSV;
        private LoggingSubSettingsView LSSV;

        private void GlobalSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(GSSV);
            }
        }

        private void AccountSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(ASSV);
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

        private void ThemeSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(TSSV);
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

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Setting - General");
            }
        }
    }
}
