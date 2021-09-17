using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for CurveEditorWindow.xaml
    /// </summary>
    public partial class CurveEditorWindow : Window
    {
        public CurveEditorWindow(IEditableVariable property)
        {
            InitializeComponent();

            if (property is not ICurveDataAccessor model)
            {
                return;
            }

            var points = model.GetCurvePoints().ToArray();
            var times = points.Select(x => (double)x.GetTime()).ToArray();
            var values = points
                .Select(x => x.GetValue())
                .OfType<Tuple<IEditableVariable, IEditableVariable>>()
                .Select(x => x.Item1);


            var plt = WpfPlot1.Plot;
            //plt.Palette = ScottPlot.Drawing.Palette.PolarNight;
            plt.Style(ScottPlot.Style.Blue2);

            switch (model.Elementtype)
            {
                case "HDRColor":
                {
                    var colors = values.OfType<HDRColor>().ToList();
                    var blue = colors.Select(x => (double)x.Blue.Value).ToArray();
                    var red = colors.Select(x => (double)x.Red.Value).ToArray();
                    var green = colors.Select(x => (double)x.Green.Value).ToArray();

                    plt.AddScatter(times, red, label: "Red");
                    plt.AddScatter(times, green, label: "Green");
                    plt.AddScatter(times, blue, label: "Blue");

                    break;
                }
                case "Float":
                {
                    var floats = values.OfType<CFloat>().ToList();
                    var ys = floats.Select(x => (double)x.Value).ToArray();
                    plt.AddScatter(times, ys, label: "Y");

                    break;
                }
                case "Vector2":
                {
                    var floats = values.OfType<Vector2>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();
                    plt.AddScatter(times, xs, label: "X");
                    plt.AddScatter(times, ys, label: "Y");

                    break;
                }
                case "Vector3":
                {
                    var floats = values.OfType<Vector3>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();
                    var zs = floats.Select(x => (double)x.Z.Value).ToArray();
                    plt.AddScatter(times, xs, label: "X");
                    plt.AddScatter(times, ys, label: "Y");
                    plt.AddScatter(times, zs, label: "Z");

                    break;
                }
                case "Vector4":
                {
                    var floats = values.OfType<Vector4>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();
                    var zs = floats.Select(x => (double)x.Z.Value).ToArray();
                    var ws = floats.Select(x => (double)x.W.Value).ToArray();
                    plt.AddScatter(times, xs, label: "X");
                    plt.AddScatter(times, ys, label: "Y");
                    plt.AddScatter(times, zs, label: "Z");
                    plt.AddScatter(times, ws, label: "W");

                    break;
                }
            }



            
            plt.XAxis.Label("Time (hours)");
            plt.YAxis.Label("Value");
            plt.XAxis2.Label($"{property.REDName}");


            plt.Legend();

            WpfPlot1.Render();
        }



    }
}
