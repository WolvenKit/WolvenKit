using System.Diagnostics;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaktionslogik für RedCurvePointEditor.xaml
    /// </summary>
    public partial class RedCurvePointEditor : UserControl
    {
        public RedCurvePointEditor()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.Value)
                .Do(x => Debugger.Break());
        }

        public CFloat Point
        {
            get => (CFloat)GetValue(PointProperty);
            set => SetValue(PointProperty, value);
        }
        public static readonly DependencyProperty PointProperty = DependencyProperty.Register(
            nameof(Point), typeof(CFloat), typeof(RedCurvePointEditor), new PropertyMetadata(default(CFloat)));

        public IRedType Value
        {
            get => (IRedType)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value), typeof(IRedType), typeof(RedCurvePointEditor), new PropertyMetadata(default(IRedType), OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public string PointText
        {
            get => GetValueFromPointValue();
            set => SetPointValue(value);
        }

        public string ValueText
        {
            get => GetValueFromValueValue();
            set => SetValueValue(value);
        }

        private void SetPointValue(string value) => SetCurrentValue(PointProperty, (CFloat)float.Parse(value));
        private void SetValueValue(string value) => SetCurrentValue(ValueProperty, (CFloat)float.Parse(value));

        private string GetValueFromPointValue() => ((float)Point).ToString("N6");
        private string GetValueFromValueValue() => ((float)(CFloat)Value).ToString("N6");
    }
}
