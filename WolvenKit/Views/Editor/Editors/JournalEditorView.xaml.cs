using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    public partial class JournalEditorView
    {
        #region Constructors

        public JournalEditorView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void DataWindow_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Journal Editor");
            }
        }

        #endregion Methods
    }
}
