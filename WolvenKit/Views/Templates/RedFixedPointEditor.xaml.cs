using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedFixedPointEditor.xaml
    /// </summary>
    public partial class RedFixedPointEditor : UserControl
    {
        public RedFixedPointEditor()
        {
            InitializeComponent();
        }

        public FixedPoint RedNumber
        {
            get => (FixedPoint)this.GetValue(RedNumberProperty);
            set => this.SetValue(RedNumberProperty, value);
        }
        public static readonly DependencyProperty RedNumberProperty = DependencyProperty.Register(
            nameof(RedNumber), typeof(FixedPoint), typeof(RedFixedPointEditor), new PropertyMetadata(default(FixedPoint)));

        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }


        private void SetRedValue(string value) => SetCurrentValue(RedNumberProperty, (FixedPoint)float.Parse(value));

        private string GetValueFromRedValue() => ((float)RedNumber).ToString("R");

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9\\.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
