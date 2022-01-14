using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedCurveEditor.xaml
    /// </summary>
    public partial class RedCurveEditor : UserControl
    {
        public RedCurveEditor()
        {
            InitializeComponent();
        }

        public IRedLegacySingleChannelCurve RedCurve
        {
            get => (IRedLegacySingleChannelCurve)GetValue(RedCurveProperty);
            set => SetValue(RedCurveProperty, value);
        }
        public static readonly DependencyProperty RedCurveProperty = DependencyProperty.Register(
            nameof(RedCurve), typeof(IRedLegacySingleChannelCurve), typeof(RedCurveEditor), new PropertyMetadata(default(IRedLegacySingleChannelCurve)));


        private void CurveEditorButton_OnClick(object sender, RoutedEventArgs e)
        {
            var curveEditorWindow = new CurveEditorWindow(RedCurve);
            var r = curveEditorWindow.ShowDialog();
            if (r ?? true)
            {
                var c = curveEditorWindow.GetCurve();
                if (c is not null)
                {
                    RedCurve.InterpolationType = c.Type;

                    RedCurve.Clear();
                    foreach (var point in c.Points)
                    {
                        RedCurve.Add((float)point.Item1, point.Item2);
                    }
                }
            }
        }
    }
}
