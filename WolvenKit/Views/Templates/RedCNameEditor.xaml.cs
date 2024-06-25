using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
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
            RefreshValidity();
        }

        public bool IsValid { get; set; } = true;

        private void RefreshValidity()
        {
            var newValidity = !_settingsManager.UseValidatingEditor ||
                              (RedString.ToString() is string s && !s.EndsWith(s_space) && !s.StartsWith(s_space));
            if (IsValid == newValidity)
            {
                return;
            }

            IsValid = newValidity;
            OnPropertyChanged(nameof(IsValid));
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
            if (d is RedCNameEditor view)
            {
                view.OnPropertyChanged(nameof(Text));
                view.OnPropertyChanged(nameof(Hash));
            }
        }


        public string Text
        {
            get => RedString;
            set
            {
                SetValue(RedStringProperty, (CName)value);
                RefreshValidity();
            }
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnTextboxFocusLost(object sender, RoutedEventArgs e) => RefreshValidity();
    }
}
