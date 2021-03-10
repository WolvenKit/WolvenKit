using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    public partial class AnimsView
    {
        #region Constructors

        public AnimsView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Animation Exporter");
            }
        }

        #endregion Methods
    }
}
