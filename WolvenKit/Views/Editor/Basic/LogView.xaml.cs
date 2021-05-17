using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Catel.Logging;
using ControlzEx.Theming;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {

        #region Constructors

        public LogView()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            { return; } // Prevents Designer from trying to do the below.
        }

        #endregion Constructors

        #region Methods


        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Log View");
            }
        }

        #endregion Methods

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogRichTextBox.Clear();
        }
    }
}
