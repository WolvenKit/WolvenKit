using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.Homepage.Pages.IntegratedToolsPages.CyberCAT
{
    public partial class CyberCATPageView
    {
        #region Constructors

        public CyberCATPageView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("CyberCAT Save Editor");
            }
        }

        #endregion Methods
    }
}
