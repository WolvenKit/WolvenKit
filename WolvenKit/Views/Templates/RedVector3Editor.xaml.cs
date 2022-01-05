using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedVector3Editor.xaml
    /// </summary>
    public partial class RedVector3Editor : UserControl
    {
        public RedVector3Editor()
        {
            InitializeComponent();
        }

        public CFloat X
        {
            get => (CFloat)this.GetValue(XProperty);
            set => this.SetValue(XProperty, value);
        }
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)this.GetValue(YProperty);
            set => this.SetValue(YProperty, value);
        }
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Z
        {
            get => (CFloat)this.GetValue(ZProperty);
            set => this.SetValue(ZProperty, value);
        }
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

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

        private void SetXValue(string value) => SetCurrentValue(XProperty, (CFloat)float.Parse(value));
        private void SetYValue(string value) => SetCurrentValue(YProperty, (CFloat)float.Parse(value));
        private void SetZValue(string value) => SetCurrentValue(ZProperty, (CFloat)float.Parse(value));

        private string GetValueFromXValue() => ((float)X).ToString("R");
        private string GetValueFromYValue() => ((float)Y).ToString("R");
        private string GetValueFromZValue() => ((float)Z).ToString("R");


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = float.TryParse(e.Text, out var _);
        }

    }
}
