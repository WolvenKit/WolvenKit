using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    public partial class GameDebuggerToolView
    {
        #region Constructors

        public GameDebuggerToolView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Game Debugger");
            }
        }

        #endregion Methods
    }
}
