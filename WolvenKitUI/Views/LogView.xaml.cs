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
using WolvenKit.Common.Services;
using WolvenKitUI.Extensions;

namespace WolvenKitUI.Views
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView
    {
        private readonly ILoggerService _loggerService;

        public LogView()
        {
            InitializeComponent();

            _loggerService = ServiceLocator.Default.ResolveType<ILoggerService>();
            _loggerService.OnStringLogged += LoggerServiceOnOnStringLogged;
        }

        private delegate void LogDelegate(string t, Logtype type);
        private void LoggerServiceOnOnStringLogged(object sender, LogStringEventArgs e)
        {
            var typ = e.Logtype;
            var msg = e.Message;

            this.Dispatcher.Invoke(new LogDelegate(AddText), ((LoggerService)sender).Log + "\n",
                ((LoggerService)sender).Logtype);
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


            switch (type)
            {
                case Logtype.Error:
                    this.LogRichTextBox.AppendText(text, errorColor);
                    break;
                case Logtype.Important:
                    LogRichTextBox.AppendText(text, importantColor);
                    break;
                case Logtype.Success:
                    LogRichTextBox.AppendText(text, successColor);
                    break;
                case Logtype.Normal:
                case Logtype.Wcc:
                default:
                    LogRichTextBox.AppendText(text, defaultColor);
                    break;
            }
            
        }
    }
}
