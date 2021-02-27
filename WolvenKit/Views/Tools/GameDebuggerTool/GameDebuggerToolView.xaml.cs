
namespace WolvenKit.Views.GameDebuggerTool
{
    public partial class GameDebuggerToolView
    {
        public GameDebuggerToolView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Game Debugger");
            }
        }
    }
}
