
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
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Mimics Exporter");
            }
        }
    }
}
