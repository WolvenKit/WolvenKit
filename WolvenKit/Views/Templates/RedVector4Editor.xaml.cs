using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedVector4Editor.xaml
    /// </summary>
    public partial class RedVector4Editor : UserControl
    {
        public RedVector4Editor()
        {
            InitializeComponent();
        }

        public CFloat X
        {
            get => (CFloat)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Z
        {
            get => (CFloat)GetValue(ZProperty);
            set => SetValue(ZProperty, value);
        }
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat W
        {
            get => (CFloat)GetValue(WProperty);
            set => SetValue(WProperty, value);
        }
        public static readonly DependencyProperty WProperty = DependencyProperty.Register(
            nameof(W), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));


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

        public string WText
        {
            get => GetValueFromWValue();
            set => SetWValue(value);
        }

        private void SetXValue(string value) => SetCurrentValue(XProperty, (CFloat)float.Parse(value));
        private void SetYValue(string value) => SetCurrentValue(YProperty, (CFloat)float.Parse(value));
        private void SetZValue(string value) => SetCurrentValue(ZProperty, (CFloat)float.Parse(value));
        private void SetWValue(string value) => SetCurrentValue(WProperty, (CFloat)float.Parse(value));

        private string GetValueFromXValue() => ((float)X).ToString("G9");
        private string GetValueFromYValue() => ((float)Y).ToString("G9");
        private string GetValueFromZValue() => ((float)Z).ToString("G9");
        private string GetValueFromWValue() => ((float)W).ToString("G9");

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var tb = (TextBox)e.Source;
            e.Handled = !float.TryParse(tb.Text.Insert(tb.CaretIndex, e.Text), out _);
        }

    }
}
