
using System.Windows;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class IntegratedToolsPageView
    {
        public IntegratedToolsPageView()
        {
            InitializeComponent();

            GeneralTabItem.Content = new IntegratedToolsPages.CyberCAT.CyberCATPageView();
        }


        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Integrated Tools");
            }

        }
    }
}
