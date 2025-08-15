using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class PathEditorView : INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new();

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
            nameof(Text), typeof(string), typeof(PathEditorView), new PropertyMetadata("", OnTextChanged));

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var view = (PathEditorView)d;

            view.ValidateText();
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

        public void ValidateText()
        {
            ClearError(nameof(Text));

            if (_isFolderPicker)
            {
                if (!System.IO.Directory.Exists(Text))
                {
                    AddError(nameof(Text), "Directory doesn't exists");
                }
            }
            else
            {
                if (!System.IO.File.Exists(Text))
                {
                    AddError(nameof(Text), "File doesn't exists");
                }
            }
        }

        #region INotifyDataErrorInfo

        private void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.TryGetValue(propertyName, out var errorList))
            {
                errorList = new List<string>();
                _errorsByPropertyName.Add(propertyName, errorList);
            }

            if (!errorList.Contains(error))
            {
                errorList.Add(error);
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        private void ClearError(string propertyName)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
            {
                return;
            }

            _errorsByPropertyName.Remove(propertyName);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName) && _errorsByPropertyName.TryGetValue(propertyName, out var errorList))
            {
                return errorList;
            }

            return new List<string>();
        }

        public bool HasErrors => _errorsByPropertyName.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        #endregion INotifyDataErrorInfo
    }
}
