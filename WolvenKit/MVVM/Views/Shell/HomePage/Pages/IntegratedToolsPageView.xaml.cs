using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Shell.Homepage.Pages.IntegratedToolsPages.CyberCAT;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class IntegratedToolsPageView
    {
        public IntegratedToolsPageView()
        {
            InitializeComponent();

            GeneralTabItem.Content = new CyberCATPageView();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Integrated Tools");
            }
        }
    }
}
