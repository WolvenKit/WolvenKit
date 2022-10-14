using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : INotifyPropertyChanged
    {
        public RedRefEditor() => InitializeComponent();

        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef)));

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
