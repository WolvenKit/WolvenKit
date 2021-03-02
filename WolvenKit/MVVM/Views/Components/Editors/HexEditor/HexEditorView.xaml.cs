
namespace WolvenKit.Views.HexEditor
{
    public partial class HexEditorView
    {
        public HexEditorView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                WKitGlobal.DiscordHelper.SetDiscordRPCStatus("Hex Editor");           
            }
        }
    }
}
