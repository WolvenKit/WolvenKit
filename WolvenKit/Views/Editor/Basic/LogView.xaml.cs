using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ControlzEx.Theming;
using ReactiveUI;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : ReactiveUserControl<LogViewModel>
    {

        #region Constructors

        public LogView()
        {
            InitializeComponent();


        }

        #endregion Constructors

        #region Methods


      

        #endregion Methods

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //LogRichTextBox.Clear();
        }
    }
}
