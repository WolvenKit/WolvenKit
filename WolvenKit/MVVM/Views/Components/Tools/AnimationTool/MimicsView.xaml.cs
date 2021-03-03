
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.AnimationTool
{
    public partial class MimicsView
    {
        public MimicsView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Mimics Exporter");
            }
        }
    }
}
