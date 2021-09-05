using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ControlzEx.Theming;
using ReactiveUI;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
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

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;
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
