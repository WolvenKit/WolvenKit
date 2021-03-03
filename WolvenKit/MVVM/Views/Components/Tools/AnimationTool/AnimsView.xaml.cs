
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.AnimationTool
{
    public partial class AnimsView
    {
        public AnimsView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Animation Exporter");
            }
        }
    }
}
