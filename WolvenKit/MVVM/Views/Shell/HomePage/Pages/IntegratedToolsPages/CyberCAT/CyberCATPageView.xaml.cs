
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.Homepage.Pages.IntegratedToolsPages.CyberCAT
{
    public partial class CyberCATPageView
    {
        public CyberCATPageView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {

            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("CyberCAT Save Editor");
            }


        }
    }
}
