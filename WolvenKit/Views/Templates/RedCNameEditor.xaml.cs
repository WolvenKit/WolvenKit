using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedCNameEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;

        public RedCNameEditor()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
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

        // sanitize hashes when control is used for ResourcePath
        public bool SanitizeHash
        {
            get => (bool)GetValue(SanitizeHashProperty);
            set => SetValue(SanitizeHashProperty, value);
        }

        public static readonly DependencyProperty SanitizeHashProperty = DependencyProperty.Register(
            nameof(SanitizeHash), typeof(bool), typeof(RedCNameEditor), new PropertyMetadata(false));

        public string Text
        {
            get => RedString;
            set => SetValue(RedStringProperty, (CName)value);
        }

        public string Hash
        {
            get
            {
                ulong retHash = SanitizeHash ? CName.GetHashSanitized(RedString) : RedString;
                if (_settingsManager.ShowCNameAsHex)
                {
                    return retHash.ToString("X");
                }
                else
                {
                    return retHash.ToString();
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
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = (string)e.DataObject.GetData(typeof(string));
                var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, text!);

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
            else
            {
                e.CancelCommand();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
