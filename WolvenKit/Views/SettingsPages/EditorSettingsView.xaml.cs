
using WolvenKit.Views.SettingsPages.SubPages.Editor;

namespace WolvenKit.Views.SettingsPages
{
    public partial class EditorSettingsView
    {
        public EditorSettingsView()
        {
            InitializeComponent();
        }

        private void CompatibilitySubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new CompatibilitySubSettingsView());
            }
        }

        private void GeneralSubItem_Selected(object sender, System.Windows.RoutedEventArgs e)
        {
            if (IsLoaded && IsVisible && IsInitialized)
            {
                SettingsViewer.Children.Clear();
                SettingsViewer.Children.Add(new GeneralSubSettingsView());
            }
        }
    }
}
