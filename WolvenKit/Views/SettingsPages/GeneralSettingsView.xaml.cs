
using WolvenKit.Views.SettingsPages.SubPages.General;

namespace WolvenKit.Views.SettingsPages
{
    public partial class GeneralSettingsView
    {
        public GeneralSettingsView()
        {
            InitializeComponent();
        }

        private void GlobalSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new GlobalSubSettingsView());
            }
        }

        private void AccountSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new AccountSubSettingsView());
            }
        }



        private void UpdatesSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new UpdatesSubSettingsView());
            }
        }

        private void ThemeSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new ThemeSubSettingsView());
            }
        }

        private void LoggingSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new LoggingSubSettingsView());
            }
        }
    }
}
