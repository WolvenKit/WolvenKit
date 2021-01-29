
using WolvenKit.Views.SettingsPages.SubPages.Tool;

namespace WolvenKit.Views.SettingsPages
{
    public partial class ToolSettingsView
    {
        public ToolSettingsView()
        {
            InitializeComponent();
        }

        private void AssetBrowserSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new AssetBrowserSubSettingsView());
            }
        }

        private void PluginManagerSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new PluginManagerSubSettingsView());
            }
        }

        private void CodeEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new CodeEditorSubSettingsView());
            }
        }

        private void VisualEditorSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new VisualEditorSubSettingsView());
            }
        }
    }
}
