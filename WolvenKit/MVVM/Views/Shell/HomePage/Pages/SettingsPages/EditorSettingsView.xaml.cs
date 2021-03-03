using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages.SubPages.Editor;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages.SettingsPages
{
    public partial class EditorSettingsView
    {
        public EditorSettingsView()
        {
            GSSV = new GeneralSubSettingsView();
            CSSV = new CompatibilitySubSettingsView();

            InitializeComponent();

            SettingsViewer.Children.Add(GSSV);
            GeneralSubItem.IsSelected = true;
        }

        private GeneralSubSettingsView GSSV;
        private CompatibilitySubSettingsView CSSV;

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
    }
}
