using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedStringEditor : INotifyPropertyChanged
    {
        public RedStringEditor() => InitializeComponent();

        private CString lastValue = CString.Empty;
        
        public CString RedString
        {
            get => (CString)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(CString), typeof(RedStringEditor), new PropertyMetadata(default(CString), OnRedStringChanged));

        private static void OnRedStringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedStringEditor view)
            {
                view.OnPropertyChanged(nameof(Text));
            }
        }


        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent(
            nameof(ValueChanged), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(RedStringEditor));

        public event RoutedEventHandler ValueChanged
        {
            add => AddHandler(ValueChangedEvent, value);
            remove => RemoveHandler(ValueChangedEvent, value);
        }


        private void OnTextboxFocusGained(object sender, RoutedEventArgs e) => lastValue = RedString;

        private void OnTextboxFocusLost(object sender, RoutedEventArgs e) =>
            RaiseEvent(new ValueChangedEventArgs(ValueChangedEvent, lastValue, RedString));

        public string Text
        {
            get => RedString;
            set => SetValue(RedStringProperty, (CString)value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
