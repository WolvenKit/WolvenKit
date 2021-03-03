
using Catel.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Components.Tools.PluginManager
{
    public partial class PluginManagerView
    {
        public PluginManagerView() 
        {
            InitializeComponent(); 
          

        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void DataWindow_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Plugin Manager");
            }
        }
    }
}
