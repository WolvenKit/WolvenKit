
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Components.Editors
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
                DiscordHelper.SetDiscordRPCStatus("Hex Editor");           
            }
        }
    }
}
