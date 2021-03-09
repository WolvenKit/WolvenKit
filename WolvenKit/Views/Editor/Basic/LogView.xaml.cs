using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Catel.Logging;
using ControlzEx.Theming;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.MVVM.Views.Shell.Editor
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {
        #region Fields

#pragma warning disable IDE0051 // Remove unused private members
        //  private readonly ILoggerService _loggerService;
#pragma warning restore IDE0051 // Remove unused private members

        #endregion Fields

        #region Constructors

        public LogView()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            { return; } // Prevents Designer from trying to do the below.

            ILog _loggerService = LogManager.GetCurrentClassLogger();
        }

        #endregion Constructors

        #region Delegates

        private delegate void LogDelegate(string t, Logtype type);

        #endregion Delegates

        #region Methods

        private void AddText(string text, Logtype type = Logtype.Normal)
        {
            var theme = ThemeManager.Current.DetectTheme(Application.Current);

            var errorColor = Colors.Red.ToString();
            var importantColor = Colors.Orange.ToString();
            var successColor = Colors.LimeGreen.ToString();
            var defaultColor = Colors.WhiteSmoke.ToString();

            if (theme == null)
            {
                defaultColor = Colors.Black.ToString();
            }
            if (theme != null && theme.BaseColorScheme == "Light")
            {
                errorColor = Colors.Red.ToString();
                importantColor = Colors.Orange.ToString();
                successColor = Colors.Green.ToString();
                defaultColor = Colors.Black.ToString();
            }

            var color = defaultColor;
            switch (type)
            {
                case Logtype.Error:
                    color = errorColor;
                    break;

                case Logtype.Important:
                    color = importantColor;
                    break;

                case Logtype.Success:
                    color = successColor;
                    break;

                case Logtype.Normal:
                case Logtype.Wcc:
                default:
                    break;
            }

            // LogRichTextBox.Invoke(() => LogRichTextBox.AppendText(text, color));
        }

        private async void LoggerServiceOnOnStringLogged(object sender, LogStringEventArgs e)
        {
            var logdel = new LogDelegate(AddText);

            await Task.Run(() => logdel(((LoggerService)sender).Log + "\n", ((LoggerService)sender).Logtype));
        }

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
