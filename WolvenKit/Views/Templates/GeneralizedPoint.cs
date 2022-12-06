using System;
using System.Collections.Generic;
using System.Windows;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.Views.Editors
{
    public class CurveDto
    {
        public Enums.EInterpolationType Type { get; set; }
        public ICollection<Tuple<double, IRedType>> Points { get; set; }

        public CurveDto(ICollection<Tuple<double, IRedType>> points, Enums.EInterpolationType type)
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
