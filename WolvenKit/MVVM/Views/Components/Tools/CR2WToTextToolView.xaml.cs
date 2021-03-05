using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Components.Tools
{
    public partial class CR2WToTextToolView
    {
        #region Constructors

        public CR2WToTextToolView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("CR2W To Text Tool");
            }
        }

        #endregion Methods
    }
}
