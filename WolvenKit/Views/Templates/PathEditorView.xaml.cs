using System.Text;
using System.Windows;
using Microsoft.Win32;
using WolvenKit.App.Helpers;

namespace WolvenKit.Controls
{
    /// <summary>
    /// Creates a new instance of this class with the specified display name and 
    /// file extension list.
    /// </summary>
    /// <param name="Name">The name of this filter.</param>
    /// <param name="Patterns">The list of extensions in 
    /// this filter. Can use a semicolon(";") 
    /// or comma (",") to separate extensions. Extensions can be prefaced 
    /// with a period (".") or with the file wild card specifier "*.".</param>
    public record PathEditorFilter(string Name, string Patterns);

    /// <summary>
    /// Interaction logic for PathEditorView.xaml
    /// </summary>
    public partial class PathEditorView
    {
        private readonly bool _isFolderPicker;
        private readonly bool _multiselect;
        private readonly PathEditorFilter[] _filters;

        public PathEditorView(bool isFolderPicker, bool multiselect, PathEditorFilter[] filters = null)
        {
            InitializeComponent();

            _isFolderPicker = isFolderPicker;
            _multiselect = multiselect;
            _filters = filters;
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text), typeof(string), typeof(PathEditorView), new PropertyMetadata(""));

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (_isFolderPicker)
            {
                if (System.IO.Directory.Exists(str))
                {
                    notification.SetCurrentValue(System.Windows.Controls.Primitives.Popup.IsOpenProperty, false);
                    return HandyControl.Data.OperationResult.Success();
                }

                return HandyControl.Data.OperationResult.Failed();
            }
            else
            {
                if (System.IO.File.Exists(str))
                {
                    notification.SetCurrentValue(System.Windows.Controls.Primitives.Popup.IsOpenProperty, false);
                    return HandyControl.Data.OperationResult.Success();
                }

                return HandyControl.Data.OperationResult.Failed();
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var title = "Select files or folders";
            switch (_isFolderPicker)
            {
                case true when _multiselect:
                    title = "Select folders";
                    break;
                case true when !_multiselect:
                    title = "Select folder";
                    break;
                case false when _multiselect:
                    title = "Select files";
                    break;
                case false when !_multiselect:
                    title = "Select file";
                    break;
                default:
                    break;
            }

            string[] results;
            if (_isFolderPicker)
            {
                var dlg = new FolderPicker
                {
                    Title = title,
                    ForceFileSystem = false
                };

                if (dlg.ShowDialog() != true)
                { 
                    return;
                }

                results = new string[] { dlg.ResultPath };
            }

            else
            {
                var filter = "";
                if (_filters is not null)
                {
                    var stringBuilder = new StringBuilder();

                    foreach (var item in _filters)
                    {
                        stringBuilder.Append($"{item.Name}|{item.Patterns}|");
                    }
                    stringBuilder = stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    filter = stringBuilder.ToString();
                }
                var dlg = new OpenFileDialog
                {
                    Title = title,
                    Multiselect = _multiselect,
                    Filter = filter
                };
                
                if (dlg.ShowDialog() != true)
                {
                    return;
                }

                results = dlg.FileNames;
            }

            if (results == null)
            {
                return;
            }


            SetCurrentValue(TextProperty, "");
            foreach (var s in results)
            {
                if (_multiselect)
                {
                    Text += $"\"{s}\";";
                }
                else
                {
                    SetCurrentValue(TextProperty, s);
                }
            }
        }
    }
}
