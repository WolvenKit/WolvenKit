using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedWorldPositionEditor.xaml
    /// </summary>
    public partial class RedWorldPositionEditor : UserControl
    {
        public RedWorldPositionEditor()
        {
            InitializeComponent();
        }

        public FixedPoint X
        {
            get => (FixedPoint)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(FixedPoint), typeof(RedWorldPositionEditor), new PropertyMetadata(default(FixedPoint)));

        public FixedPoint Y
        {
            get => (FixedPoint)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(FixedPoint), typeof(RedWorldPositionEditor), new PropertyMetadata(default(FixedPoint)));

        public FixedPoint Z
        {
            get => (FixedPoint)GetValue(ZProperty);
            set => SetValue(ZProperty, value);
        }
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(FixedPoint), typeof(RedWorldPositionEditor), new PropertyMetadata(default(FixedPoint)));

        public string XText
        {
            get => GetValueFromXValue();
            set => SetXValue(value);
        }

        public string YText
        {
            get => GetValueFromYValue();
            set => SetYValue(value);
        }

        public string ZText
        {
            get => GetValueFromZValue();
            set => SetZValue(value);
        }

        private void SetXValue(string value) => SetCurrentValue(XProperty, (FixedPoint)float.Parse(value));
        private void SetYValue(string value) => SetCurrentValue(YProperty, (FixedPoint)float.Parse(value));
        private void SetZValue(string value) => SetCurrentValue(ZProperty, (FixedPoint)float.Parse(value));

        private string GetValueFromXValue() => ((float)X).ToString("G9");
        private string GetValueFromYValue() => ((float)Y).ToString("G9");
        private string GetValueFromZValue() => ((float)Z).ToString("G9");


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) => e.Handled = float.TryParse(e.Text, out var _);

    }
}
