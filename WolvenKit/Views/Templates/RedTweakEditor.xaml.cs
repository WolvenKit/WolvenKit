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
    /// Interaction logic for RedTweakEditor.xaml
    /// </summary>
    public partial class RedTweakEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;

        public RedTweakEditor()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
        }

        public TweakDBID RedString
        {
            get => (TweakDBID)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(TweakDBID), typeof(RedTweakEditor), new PropertyMetadata(default(TweakDBID), OnRedStringChanged));

        private static void OnRedStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedTweakEditor view)
            {
                view.OnPropertyChanged(nameof(Text));
                view.OnPropertyChanged(nameof(Hash));
            }
        }


        public string Text
        {
            get => RedString;
            set => SetValue(RedStringProperty, (TweakDBID)value);
        }

        public string Hash
        {
            get
            {
                if (_settingsManager.ShowTweakDBIDAsHex)
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
                if (_settingsManager.ShowTweakDBIDAsHex)
                {
                    SetValue(RedStringProperty, (TweakDBID)ulong.Parse(value, NumberStyles.HexNumber));
                }
                else
                {
                    SetValue(RedStringProperty, (TweakDBID)ulong.Parse(value));
                }
            }
        }

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);

            if (_settingsManager.ShowTweakDBIDAsHex)
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

                if (_settingsManager.ShowTweakDBIDAsHex)
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
