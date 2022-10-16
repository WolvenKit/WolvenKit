using System;
using System.ComponentModel;
using System.Globalization;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedNodeRefEditor.xaml
    /// </summary>
    public partial class RedNodeRefEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;

        public RedNodeRefEditor()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
        }

        public NodeRef RedNodeRef
        {
            get => (NodeRef)GetValue(RedNodeRefProperty);
            set => SetValue(RedNodeRefProperty, value);
        }
        public static readonly DependencyProperty RedNodeRefProperty = DependencyProperty.Register(
            nameof(RedNodeRef), typeof(NodeRef), typeof(RedNodeRefEditor), new PropertyMetadata(default(NodeRef), OnRedNodeRefChanged));

        private static void OnRedNodeRefChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedNodeRefEditor view)
            {
                view.OnPropertyChanged(nameof(Path));
                view.OnPropertyChanged(nameof(Hash));
            }
        }


        public string Path
        {
            get => RedNodeRef;
            set => SetValue(RedNodeRefProperty, (NodeRef)value);
        }

        public string Hash
        {
            get
            {
                if (_settingsManager.ShowNodeRefAsHex)
                {
                    return ((ulong)RedNodeRef).ToString("X");
                }
                else
                {
                    return ((ulong)RedNodeRef).ToString();
                }
            }
            set
            {
                if (_settingsManager.ShowNodeRefAsHex)
                {
                    SetValue(RedNodeRefProperty, (NodeRef)ulong.Parse(value, NumberStyles.HexNumber));
                }
                else
                {
                    SetValue(RedNodeRefProperty, (NodeRef)ulong.Parse(value));
                }
            }
        }

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);

            if (_settingsManager.ShowNodeRefAsHex)
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

                if (_settingsManager.ShowNodeRefAsHex)
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
