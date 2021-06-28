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
using Feather.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using WolvenKit.Functionality.Services;

namespace WolvenKit.Controls
{
    /// <summary>
    /// Interaction logic for AddPathDialogView.xaml
    /// </summary>
    public partial class PathEditorView
    {
        private readonly bool _isFolderPicker;
        private readonly bool _multiselect;

        public PathEditorView(bool isFolderPicker, bool multiselect)
        {
            InitializeComponent();

            _isFolderPicker = isFolderPicker;
            _multiselect = multiselect;
        }

        public string Text
        {
            get => (string)this.GetValue(TextProperty);
            set => this.SetValue(TextProperty, value);
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text), typeof(string), typeof(PathEditorView), new PropertyMetadata(""));

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (System.IO.File.Exists(str))
            {
                notification.IsOpen = false;
                return HandyControl.Data.OperationResult.Success();
            }
            else
            {
                return HandyControl.Data.OperationResult.Failed();
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                Multiselect = _multiselect,
                IsFolderPicker = _isFolderPicker,

                Title = "Select files or folders"
            };
            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var results = dlg.FileNames;
            if (results == null)
            {
                return;
            }


            Text = "";
            foreach (var s in results)
            {
                if (_multiselect)
                {
                    Text += $"\"{s}\";";
                }
                else
                {
                    Text = s;
                }
            }
        }
    }
}
