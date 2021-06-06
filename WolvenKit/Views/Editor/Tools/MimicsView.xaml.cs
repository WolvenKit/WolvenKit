using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    public partial class MimicsView
    {
        #region Constructors

        public MimicsView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                //DiscordHelper.SetDiscordRPCStatus("Mimics Exporter");
            }
        }

        #endregion Methods
    }
}
