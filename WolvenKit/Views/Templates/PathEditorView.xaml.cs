using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

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

            var dlg = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                Multiselect = _multiselect,
                IsFolderPicker = _isFolderPicker,

                Title = title
            };

            if (_filters is not null)
            {
                foreach (var item in _filters)
                {
                    dlg.Filters.Add(new CommonFileDialogFilter(item.Name, item.Patterns));
                }
            }

            if (dlg.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var results = dlg.FileNames;
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
