using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedCurveEditor.xaml
    /// </summary>
    public partial class RedCurveEditor : UserControl
    {
        private ChunkViewModel _cvm => DataContext as ChunkViewModel;

        public RedCurveEditor()
        {
            InitializeComponent();
        }

        //public IRedLegacySingleChannelCurve RedCurve
        //{
        //    get => (IRedLegacySingleChannelCurve)GetValue(RedCurveProperty);
        //    set => SetValue(RedCurveProperty, value);
        //}
        //public static readonly DependencyProperty RedCurveProperty = DependencyProperty.Register(
        //    nameof(RedCurve), typeof(IRedLegacySingleChannelCurve), typeof(RedCurveEditor), new PropertyMetadata(default(IRedLegacySingleChannelCurve)));


        private void CurveEditorButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_cvm.Data is not IRedLegacySingleChannelCurve data)
            {
                data = (IRedLegacySingleChannelCurve)System.Activator.CreateInstance(_cvm.PropertyType);
            }

            var curveEditorWindow = new CurveEditorWindow(data);
            var r = curveEditorWindow.ShowDialog();
            if (r ?? true)
            {
                var c = curveEditorWindow.GetCurve();
                if (c is not null)
                {
                    if (c.Points.Count == 0)
                    {
                        _cvm.Data = null;
                    }
                    else
                    {
                        data.InterpolationType = c.Type;

                        data.Clear();
                        foreach (var point in c.Points)
                        {
                            data.Add((float)point.Item1, point.Item2);
                        }

                        _cvm.Data = data;
                        _cvm.NotifyChain(nameof(ChunkViewModel.Data));
                        _cvm.RecalculateProperties();
                    }
                }
            }
        }
    }
}
