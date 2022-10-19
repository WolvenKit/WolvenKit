using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedStringEditor : INotifyPropertyChanged
    {
        public RedStringEditor() => InitializeComponent();

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


        public string Text
        {
            get => RedString;
            set => SetValue(RedStringProperty, (CString)value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
