using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WolvenKit.Common;
using Point = System.Windows.Point;

namespace WolvenKit.Views.Editors
{
    public class CurveDto
    {
        public EInterpolationType Type { get; set; }
        public IEnumerable<Tuple<double,object>> Points { get; set; }

        public CurveDto(IEnumerable<Tuple<double, object>> points, EInterpolationType type)
        {
            Points = points;
            Type = type;
        }
    }

    public class GeneralizedPoint
    {
        public GeneralizedPoint(double t, double v, bool isCtrlPoint = false)
        {
            RenderPoint = null;
            IsControlPoint = isCtrlPoint;
            Vector = new(t, v);
        }

        public GeneralizedPoint(Vector vector, bool isCtrlPoint = false)
        {
            RenderPoint = null;
            IsControlPoint = isCtrlPoint;
            Vector = vector;
        }

        public bool IsControlPoint { get; set; }

        public Point? RenderPoint { get; set; }

        public Vector Vector { get; set; }

        public bool IsSelected { get; set; }

        public double T
        {
            get => Vector.X;
            set => Vector = new(value, V);
        }

        public double V
        {
            get => Vector.Y;
            set => Vector = new(T, value);
        }

        public bool Verify() => RenderPoint != null;
    }
}
