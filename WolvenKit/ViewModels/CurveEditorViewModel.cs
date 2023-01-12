using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using WolvenKit.Common.Annotations;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using Math = System.Math;
using Point = System.Windows.Point;

namespace WolvenKit.ViewModels
{
    /*
    TODOS:
    - Hermite curve

    - scrolling

    - multi channel curves
    - single channel curves of objects
    */


    internal class CurveEditorViewModel : INotifyPropertyChanged
    {
        #region fields

        public const double XMIN = 0; // TODO fix this at some point
        public const double YMIN = XMIN;
        private const double TOLERANCE = 0.001;

        private string _interpolationType;
        private ObservableCollection<GeneralizedPoint> _curve;
        private PointCollection _renderedPoints;
        private string _text;
        private Point _startPoint;
        private Point _cursor;
        private double _minX;
        private double _maxX;
        private double _minY;
        private double _maxY;
        private double[] _times;
        private double[] _values;
        private Enums.EInterpolationType _type;

        #endregion

        public CurveEditorViewModel()
        {
            InterpolationTypes = Enumerable.ToList(Enum.GetNames<Enums.EInterpolationType>());
            RenderedPoints = new PointCollection();
            InterpolationType = Enums.EInterpolationType.Linear.ToString();
        }

        #region properties

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler CurveReloaded;
        public event EventHandler CtrlPointsChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnCurveReloaded() => CurveReloaded?.Invoke(this, EventArgs.Empty);
        private void OnCtrlPointsChanged() => CtrlPointsChanged?.Invoke(this, EventArgs.Empty);


        public bool IsLoaded { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public Point Cursor
        {
            get => _cursor;
            set
            {
                if (value.Equals(_cursor))
                {
                    return;
                }

                _cursor = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CursorPos));
            }
        }

        public ObservableCollection<GeneralizedPoint> Curve
        {
            get => _curve;
            set
            {
                //if (Equals(value, _curve)) return;
                _curve = value;
                OnPropertyChanged();

                //RenderCurve();
            }
        }

        public PointCollection RenderedPoints
        {
            get => _renderedPoints;
            set
            {
                //if (Equals(value, _renderedPoints)) return;
                _renderedPoints = value;
                OnPropertyChanged();
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                if (value == _text)
                {
                    return;
                }

                _text = value;
                OnPropertyChanged();
            }
        }

        public Point StartPoint
        {
            get => _startPoint;
            set
            {
                //if (value.Equals(_startPoint)) return;
                _startPoint = value;
                OnPropertyChanged();
            }
        }

        public List<string> InterpolationTypes { get; }

        public string InterpolationType
        {
            get => _interpolationType;
            set
            {
                if (value == _interpolationType)
                {
                    return;
                }

                _interpolationType = value;
                OnPropertyChanged();
            }
        }

        public double MinT { get; set; }
        public double MaxT { get; set; }

        public double MinV { get; set; }
        public double MaxV { get; set; }


        public string CursorPos
        {
            get
            {
                var (nx, ny) = ToWorldCoordinates(Cursor.X, Cursor.Y);
                return $"T : {Math.Round(nx, 2)} | V : {Math.Round(ny, 2)}";
            }
        }

        public double MinX
        {
            get => _minX;
            set
            {
                var calculatedValue = Curve is null ? value : Math.Min(value, GetCurveMinT());
                _minX = calculatedValue;
                OnPropertyChanged();

                MinT = _minX;
                Reload();
            }
        }

        public double MaxX
        {
            get => _maxX;
            set
            {
                var calculatedValue = Curve is null ? value : Math.Max(value, GetCurveMaxT());

                _maxX = calculatedValue;
                OnPropertyChanged();

                MaxT = _maxX;
                Reload();
            }
        }

        public double MinY
        {
            get => _minY;
            set
            {
                var calculatedValue = Curve is null ? value : Math.Min(value, GetCurveMinV());
                _minY = calculatedValue;
                OnPropertyChanged();

                MinV = _minY;
                Reload();
            }
        }

        public double MaxY
        {
            get => _maxY;
            set
            {
                var calculatedValue = Curve is null ? value : Math.Max(value, GetCurveMaxV());

                _maxY = calculatedValue;
                OnPropertyChanged();

                MaxV = _maxY;
                Reload();
            }
        }


        public double ScaleX => Width / (MaxT - MinT);
        public double ScaleY => Height / (MaxV - MinV);
        public double ScaleXInverse => (MaxT - MinT) / Width;
        public double ScaleYInverse => (MaxV - MinV) / Height;

        #endregion


        public (double t, double v) ToWorldCoordinates(double x, double y)
        {
            var t = ToWorldCoordinateX(x);
            var v = ToWorldCoordinateY(y);
            return (t, v);
        }

        public double ToWorldCoordinateX(double x) => (x * ScaleXInverse) + MinT;
        public double ToWorldCoordinateY(double y) => ((Height - y) * ScaleYInverse) + MinV;

        public double ToCanvasCoordinateX(double x) => (x - MinT) * ScaleX;
        public double ToCanvasCoordinateY(double y) => Height - ((y - MinV) * ScaleY);

        private double GetCurveMinT() => Curve.Min(_ => _.T);
        private double GetCurveMaxT() => Curve.Max(_ => _.T);
        private double GetCurveMinV() => Curve.Min(_ => _.V);
        private double GetCurveMaxV() => Curve.Max(_ => _.V);

        /// <summary>
        ///     Load a curve into the editor
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void LoadCurve(double[] times, double[] values, Enums.EInterpolationType type)
        {
            if (times == null)
            {
                times = new double[] { 0 };
                type = Enums.EInterpolationType.Linear;
            }
            if (values == null)
            {
                values = new double[] { 0 };
                type = Enums.EInterpolationType.Linear;
            }
            if (times.Length < 1 || values.Length < 1)
            {
                times = new double[] { 0 };
                values = new double[] { 0 };
                type = Enums.EInterpolationType.Linear;
            }

            _times = times;
            _values = values;
            _type = type;

            var c = new List<GeneralizedPoint>(times.Select((t, i) => new GeneralizedPoint(t, values[i])));
            InterpolationType = type.ToString();

            ScaleCanvas(c);

            Curve = new ObservableCollection<GeneralizedPoint>(c);

            // set control points
            RecalculateControlPoints();
            IsLoaded = true;
        }

        /// <summary>
        /// Scales the canvas to the curve
        /// </summary>
        /// <param name="c"></param>
        public void ScaleCanvas(List<GeneralizedPoint> c)
        {
            MinT = c.Min(_ => _.T);
            MaxT = Math.Abs(c.Max(_ => _.T) - MinT) < TOLERANCE ? c.Max(_ => _.T) + 1 : c.Max(_ => _.T);
            var stepT = (MaxT - MinT) / 10;
            MinT -= stepT;
            MaxT += stepT;

            MinX = MinT;
            MaxX = MaxT;

            MinV = c.Min(_ => _.V);
            MaxV = Math.Abs(c.Max(_ => _.V) - MinV) < TOLERANCE ? c.Max(_ => _.V) + 1 : c.Max(_ => _.V);
            var stepV = (MaxV - MinV) / 10;
            MinV -= stepV;
            MaxV += stepV;

            MinY = MinV;
            MaxY = MaxV;
        }

        public void ReLoadCurve()
        {
            LoadCurve(_times, _values, _type);

            Reload();
        }

        private void RecalculateControlPoints()
        {
            switch (GetInterpolationTypeEnum())
            {
                case Enums.EInterpolationType.Constant:
                case Enums.EInterpolationType.Linear:
                    // no control points
                    foreach (var p in Curve)
                    {
                        p.IsControlPoint = false;
                    }

                    break;
                case Enums.EInterpolationType.BezierQuadratic:
                    // every second point is a control point
                    for (var i = 0; i < Curve.Count; i++)
                    {
                        Curve[i].IsControlPoint = i % 2 != 0;
                    }

                    break;
                case Enums.EInterpolationType.BezierCubic:
                    // every second and third point is a control point
                    for (var i = 0; i < Curve.Count; i++)
                    {
                        Curve[i].IsControlPoint = i % 2 != 0;
                        Curve[i].IsControlPoint = i % 3 != 0;
                    }

                    break;
                case Enums.EInterpolationType.Hermite:
                default:
                    throw new ArgumentOutOfRangeException();
            }

            OnCtrlPointsChanged();
        }

        /// <summary>
        ///     Get the interpolation type as enum
        /// </summary>
        /// <returns></returns>
        public Enums.EInterpolationType GetInterpolationTypeEnum() => Enum.Parse<Enums.EInterpolationType>(InterpolationType);

        private bool VerifyCurve() => _curve.All(x => x.Verify());

        private void RenderCurve()
        {
            // sort points
            Curve = new ObservableCollection<GeneralizedPoint>(Curve.OrderBy(_ => _.T));


            // scale points to canvas
            foreach (var p in _curve)
            {
                var scaledT = Math.Round(ToCanvasCoordinateX(p.T) + XMIN);
                var scaledV = Math.Round(ToCanvasCoordinateY(p.V) + YMIN);
                p.RenderPoint = new Point(scaledT, scaledV);
            }

            // verify curve integrity
            if (!VerifyCurve())
            {
                throw new ArgumentNullException();
            }

            List<Point> points;

            // render bezier segments
            switch (GetInterpolationTypeEnum())
            {
                case Enums.EInterpolationType.Constant:
                case Enums.EInterpolationType.Linear:
                    // only take proper points (depending on first loaded curve)
                    var linearCurve = _curve.Where(x => !x.IsControlPoint).Select(x => x.RenderPoint.Value);
                    points = linearCurve.ToList();
                    break;
                case Enums.EInterpolationType.BezierQuadratic:
                case Enums.EInterpolationType.BezierCubic:
                    // take all
                    points = _curve.Select(x => x.RenderPoint.Value).ToList();
                    break;
                case Enums.EInterpolationType.Hermite:
                default:
                    throw new ArgumentOutOfRangeException();
            }

            StartPoint = points.First();
            RenderedPoints = new PointCollection(points.Skip(1));

            RecalculateControlPoints();
        }

        /// <summary>
        ///     Add a point to the curve
        /// </summary>
        /// <param name="pos"></param>
        public void AddPoint(Point pos)
        {
            if (Curve == null)
            {
                return;
            }

            // Add single point
            var (t, v) = ToWorldCoordinates(pos.X - XMIN, pos.Y - YMIN);
            var point = new GeneralizedPoint(t, v);

            // insert
            var idx = Curve.Count;
            for (var i = 0; i < Curve.Count; i++)
            {
                var p = Curve[i];
                var thisT = p.T;
                if (t < thisT)
                {
                    idx = i;
                    break;
                }
            }

            Curve.Insert(idx, point);

            switch (GetInterpolationTypeEnum())
            {
                case Enums.EInterpolationType.Constant:
                case Enums.EInterpolationType.Linear:
                    // do nothing
                    break;
                case Enums.EInterpolationType.BezierQuadratic:
                {
                    if (Curve.Count <= idx + 1 || idx < 1)
                    {
                        return;
                    }

                    var previousPoint = Curve[idx - 1];
                    var nextPoint = Curve[idx + 1];
                    switch (previousPoint.IsControlPoint)
                    {
                        case false when nextPoint.IsControlPoint:
                        {
                            // add continuous ctrl point before
                            var ctrlPoint1 = AddControllPointBefore(nextPoint, point, previousPoint);
                            Curve.Insert(idx, new GeneralizedPoint(ClampToWorldCanvas(ctrlPoint1), true));
                            break;
                        }
                        case true when !nextPoint.IsControlPoint:
                        {
                            // add continuous control point after
                            var ctrlPoint2 = AddControllPointAfter(previousPoint, point, nextPoint);
                            Curve.Insert(idx + 1, new GeneralizedPoint(ClampToWorldCanvas(ctrlPoint2), true));
                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                }
                case Enums.EInterpolationType.BezierCubic:
                {
                    if (Curve.Count <= idx + 1 || idx < 1)
                    {
                        return;
                    }

                    var previousPoint = Curve[idx - 1];
                    var nextPoint = Curve[idx + 1];
                    switch (previousPoint.IsControlPoint)
                    {
                        case false:
                        {
                            // add two control points before
                            var vec1 = AddControllPointBefore(nextPoint, point, previousPoint);
                            var ctrlPoint1 = new GeneralizedPoint(ClampToWorldCanvas(vec1), true);
                            var vec2 = AddControllPointBefore(point, ctrlPoint1, point);
                            var ctrlPoint2 = new GeneralizedPoint(ClampToWorldCanvas(vec2), true);

                            Curve.Insert(idx, ctrlPoint1);
                            Curve.Insert(idx, ctrlPoint2);

                            break;
                        }
                        case true when nextPoint.IsControlPoint:
                        {
                            // add one control point before and one after
                            var vec1 = AddControllPointBefore(nextPoint, point, previousPoint);
                            var ctrlPoint1 = new GeneralizedPoint(ClampToWorldCanvas(vec1), true);
                            var vec2 = AddControllPointAfter(ctrlPoint1, point, nextPoint);

                            Curve.Insert(idx, ctrlPoint1);
                            Curve.Insert(idx + 2, new GeneralizedPoint(ClampToWorldCanvas(vec2), true));

                            break;
                        }
                        case true when !nextPoint.IsControlPoint:
                        {
                            // add two control points after
                            var vec1 = AddControllPointAfter(previousPoint, point, nextPoint);
                            var ctrlPoint1 = new GeneralizedPoint(ClampToWorldCanvas(vec1), true);
                            var vec2 = AddControllPointAfter(point, ctrlPoint1, nextPoint);
                            var ctrlPoint2 = new GeneralizedPoint(ClampToWorldCanvas(vec2), true);

                            Curve.Insert(idx + 1, ctrlPoint1);
                            Curve.Insert(idx + 1, ctrlPoint2);

                            break;
                        }

                        default:
                            break;
                    }

                    break;
                }
                case Enums.EInterpolationType.Hermite:
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Reload();
        }

        private static Vector AddControllPointAfter(GeneralizedPoint previousPoint, GeneralizedPoint point,
            GeneralizedPoint nextPoint)
        {
            var ctrlPoint2 = -(previousPoint.Vector - point.Vector);
            ctrlPoint2.Normalize();
            ctrlPoint2 = point.Vector + (ctrlPoint2 * (nextPoint.Vector - point.Vector).Length / 2);
            return ctrlPoint2;
        }

        private static Vector AddControllPointBefore(GeneralizedPoint nextPoint, GeneralizedPoint point,
            GeneralizedPoint previousPoint)
        {
            var ctrlPoint1 = -(nextPoint.Vector - point.Vector);
            ctrlPoint1.Normalize();
            ctrlPoint1 = point.Vector + (ctrlPoint1 * (point.Vector - previousPoint.Vector).Length / 2);
            return ctrlPoint1;
        }

        /// <summary>
        ///     Re-renders the curve
        /// </summary>
        public void Reload(bool raiseEvent = true)
        {
            if (Curve is null)
            {
                return;
            }

            OnPropertyChanged(nameof(Curve));

            RenderCurve();

            if (raiseEvent)
            {
                OnCurveReloaded();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Point ClampToCanvas(Point pos)
        {
            var x = Math.Min(
                Math.Max(pos.X - XMIN, 0),
                Width - (2 * XMIN));
            var y = Math.Min(
                Math.Max(pos.Y - YMIN, 0),
                Height - (2 * YMIN));
            return new Point(x, y);
        }

        // TODO: remove after scrolling
        private Vector ClampToWorldCanvas(Vector pos)
        {
            var x = Math.Min(
                Math.Max(pos.X - XMIN, MinT),
                MaxT - (2 * XMIN));
            var y = Math.Min(
                Math.Max(pos.Y - YMIN, MinV),
                MaxV - (2 * YMIN));
            return new Vector(x, y);
        }
    }
}
