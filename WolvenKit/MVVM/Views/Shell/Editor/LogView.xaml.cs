using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Catel.IoC;
using ControlzEx.Theming;

namespace WolvenKit.Views
{
    using Common.Services;
    using Functionality.Extensions;
    using MahApps.Metro.Controls;
    using WolvenKit.Functionality.WKitGlobal.Helpers;

    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {
        private readonly ILoggerService _loggerService;

        public LogView()
        {
            InitializeComponent();
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) { return; } // Prevents Designer from trying to do the below.
                                                                                              
            _loggerService = ServiceLocator.Default.ResolveType<ILoggerService>();
            _loggerService.OnStringLogged += LoggerServiceOnOnStringLogged;
        }

        private delegate void LogDelegate(string t, Logtype type);
        private async void LoggerServiceOnOnStringLogged(object sender, LogStringEventArgs e)
        {
            var logdel = new LogDelegate(AddText);

            await Task.Run(() => logdel(((LoggerService)sender).Log + "\n", ((LoggerService)sender).Logtype));
        }


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

            LogRichTextBox.Invoke(() => LogRichTextBox.AppendText(text, color));
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Log View");
            }
        }

    }
}
