using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;
using YamlDotNet.Core.Tokens;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;

        public IEnumerable<InternalEnums.EImportFlags> EnumValues => Enum.GetValues(typeof(InternalEnums.EImportFlags)).Cast<InternalEnums.EImportFlags>();

        public RedRefEditor()
        {
            InitializeComponent();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            FlagsComboBox.SelectionChanged += FlagsComboBox_OnSelectionChanged;
        }


        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef), OnRedRefChanged));

        private static void OnRedRefChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedRefEditor view && view.RedRef != null)
            {
                view.OnPropertyChanged(nameof(DepotPath));
                view.OnPropertyChanged(nameof(Hash));
            }
        }


        public string DepotPath
        {
            get => RedRef.DepotPath;
            set => SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)value, RedRef.Flags));
        }

        public string Hash
        {
            get
            {
                if (_settingsManager.ShowNodeRefAsHex)
                {
                    return RedRef.DepotPath.GetRedHash().ToString("X");
                }
                else
                {
                    return RedRef.DepotPath.GetRedHash().ToString();
                }
            }
            set
            {
                if (_settingsManager.ShowNodeRefAsHex)
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)ulong.Parse(value, NumberStyles.HexNumber), RedRef.Flags));
                }
                else
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)ulong.Parse(value), RedRef.Flags));
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

        private void FlagsComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox { SelectedItem: InternalEnums.EImportFlags flags })
            {
                if (RedRef != null && RedRef.Flags != flags)
                {
                    SetCurrentValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, RedRef.DepotPath, flags));
                }
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
