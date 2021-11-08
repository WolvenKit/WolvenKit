using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.Common.Model.Cr2w;

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

        public ICurveDataAccessor RedCurve
        {
            get => (ICurveDataAccessor)this.GetValue(RedCurveProperty);
            set => this.SetValue(RedCurveProperty, value);
        }
        public static readonly DependencyProperty RedCurveProperty = DependencyProperty.Register(
            nameof(RedCurve), typeof(ICurveDataAccessor), typeof(RedCurveEditor), new PropertyMetadata(default(ICurveDataAccessor)));


        private void CurveEditorButton_OnClick(object sender, RoutedEventArgs e)
        {
            var curveEditorWindow = new CurveEditorWindow(RedCurve);
            var r = curveEditorWindow.ShowDialog();
            if (r ?? true)
            {
                var c = curveEditorWindow.GetCurve();
                if (c is not null)
                {
                    // set tag data
                    RedCurve.SetInterpolationType(c.Type);
                    RedCurve.SetCurvePoints(c.Points);
                }
            }
        }
    }
}
