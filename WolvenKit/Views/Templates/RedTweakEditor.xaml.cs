using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedTweakEditor.xaml
    /// </summary>
    public partial class RedTweakEditor : INotifyPropertyChanged
    {

        public RedTweakEditor() => InitializeComponent();

        public TweakDBID RedString
        {
            get => (TweakDBID)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(TweakDBID), typeof(RedTweakEditor), new PropertyMetadata(default(TweakDBID)));


        public string Text
        {
            get => RedString;
            set
            {
                SetValue(RedStringProperty, (TweakDBID)value);
                OnPropertyChanged(nameof(Hash));
            }
        }

        public ulong Hash
        {
            get => RedString;
            set
            {
                SetValue(RedStringProperty, (TweakDBID)value);
                OnPropertyChanged(nameof(Text));
            }
        }

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);

            e.Handled = !ulong.TryParse(full, out _);
        }

        private void HashBox_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = (string)e.DataObject.GetData(typeof(string));
                var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, text!);
                if (!ulong.TryParse(full, out _))
                {
                    e.CancelCommand();
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
