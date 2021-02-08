
using WolvenKit.Views.SettingsPages.SubPages.Editor;

namespace WolvenKit.Views.SettingsPages
{
    public partial class EditorSettingsView
    {
        public EditorSettingsView()
        {
            GSSV = new GeneralSubSettingsView();
            CSSV = new CompatibilitySubSettingsView();

            InitializeComponent();
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

            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Setting - Editor");
            }


        }
    }
}
