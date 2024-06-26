using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedCNameEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;

        private const string s_space = " ";

        public RedCNameEditor()
        {
            InitializeComponent();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
        }

        public bool IsValid { get; set; } = true;

        [GeneratedRegex(@"^[a-zA-Z0-9]+[a-zA-Z0-9\s@]*[a-zA-Z0-9]+$")]
        private static partial Regex s_validCharactersRegex();

        private void RecalculateValidityAndTooltip()
        {
            var newValidity = true;
            if (Text == "None" || _settingsManager?.UseValidatingEditor != true)
            {
                TextBoxToolTip = "CName";
            }
            else if (ArchiveXlHelper.GetValuesForInvalidConditions(Text) is string invalidConditions)
            {
                newValidity = false;
                TextBoxToolTip = $"Invalid dynamic appearance condition! Valid checks are: {invalidConditions}";
            }
            else if (!s_validCharactersRegex().IsMatch(Text))
            {
                TextBoxToolTip = $"'{Text}' contains invalid characters, or leading/trailing spaces! (Ignore this if everything works)";
            }
            else
            {
                TextBoxToolTip = "CName";
            }
            
            if (IsValid == newValidity)
            {
                return;
            }
            
            IsValid = newValidity;
            OnPropertyChanged(nameof(IsValid));
            OnPropertyChanged(nameof(TextBoxToolTip));
        }
       
        public CName RedString
        {
            get => (CName)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(CName), typeof(RedCNameEditor), new PropertyMetadata(default(CName), OnRedStringChanged));

        private static void OnRedStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not RedCNameEditor view)
            {
                return;
            }

            view.OnPropertyChanged(nameof(Text));
            view.OnPropertyChanged(nameof(Hash));
        }

        public string Text
        {
            get => RedString;
            set => SetValue(RedStringProperty, (CName)value);
        }

        public static readonly DependencyProperty TextBoxToolTipProperty = DependencyProperty.Register(
            nameof(TextBoxToolTip), typeof(string), typeof(RedCNameEditor), new PropertyMetadata(default(string)));

        public string TextBoxToolTip
        {
            get => TextBoxToolTip;
            set => SetValue(TextBoxToolTipProperty, value);
        }

        public string Hash
        {
            get
            {
                if (_settingsManager.ShowCNameAsHex)
                {
                    return ((ulong)RedString).ToString("X");
                }
                else
                {
                    return ((ulong)RedString).ToString();
                }
            }
            set
            {
                if (_settingsManager.ShowCNameAsHex)
                {
                    SetValue(RedStringProperty, (CName)ulong.Parse(value, NumberStyles.HexNumber));
                }
                else
                {
                    SetValue(RedStringProperty, (CName)ulong.Parse(value));
                }
            }
        }

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);

            if (_settingsManager.ShowCNameAsHex)
            {
                e.Handled = !ulong.TryParse(full, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _);
            }
            else
            {
                e.Handled = !ulong.TryParse(full, out _);
            }
        }

        private void HashBox_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (!e.DataObject.GetDataPresent(typeof(string)))
            {
                e.CancelCommand();
                return;
            }

            var text = (string)e.DataObject.GetData(typeof(string))!;
            if (_settingsManager.UseValidatingEditor)
            {
                text = text.Trim();
            }

            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, text);

            if (_settingsManager.ShowCNameAsHex)
            {
                if (!ulong.TryParse(full, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                if (!ulong.TryParse(full, out _))
                {
                    e.CancelCommand();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == nameof(Text))
            {
                RecalculateValidityAndTooltip();
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnTextboxFocusLost(object sender, RoutedEventArgs e) => RecalculateValidityAndTooltip();
    }
}
