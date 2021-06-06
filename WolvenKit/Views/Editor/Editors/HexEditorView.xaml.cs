using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    public partial class HexEditorView
    {
        #region Constructors

        public HexEditorView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                //DiscordHelper.SetDiscordRPCStatus("Hex Editor");
            }
        }

        #endregion Methods
    }
}
