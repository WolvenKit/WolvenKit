using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.JournalEditor
{
    public partial class JournalEditorView
    {
        public JournalEditorView() 
        {
            InitializeComponent();
        }

        private void DataWindow_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Journal Editor");
            }
        }
    }
}
