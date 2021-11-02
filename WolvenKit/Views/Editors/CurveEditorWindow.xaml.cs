using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using WolvenKit.Common;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;
using Point = System.Windows.Point;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for CurveEditorWindow.xaml
    /// </summary>
    public partial class CurveEditorWindow
    {
        private bool _isCtrlPressed;

        private Point? _dragStart;

        private readonly string _elementType;

        private readonly ICurveDataAccessor _model;

        public CurveEditorWindow(IEditableVariable property)
        {
            InitializeComponent();

            if (property is not ICurveDataAccessor model)
            {
                return;
            }

            _model = model;

            var points = model.GetCurvePoints().ToArray();
            var times = points.Select(x => (double)x.GetTime()).ToArray();
            var values = points
                .Select(x => x.GetValue())
                .OfType<Tuple<IEditableVariable, IEditableVariable>>()
                .Select(x => x.Item1);
            var type = model.GetInterpolationType();

            _elementType = model.Elementtype;

            switch (model.Elementtype)
            {
                case "HDRColor":
                {
                    var colors = values.OfType<HDRColor>().ToList();
                    var blue = colors.Select(x => (double)x.Blue.Value).ToArray();
                    var red = colors.Select(x => (double)x.Red.Value).ToArray();
                    var green = colors.Select(x => (double)x.Green.Value).ToArray();
                    var alpha = colors.Select(x => (double)x.Alpha.Value).ToArray();

                    if (DataContext is CurveEditorViewModel vm)
                    {
                        vm.LoadCurve(times, alpha, type);
                    }

                    break;
                }
                case "Float":
                {
                    var floats = values.OfType<CFloat>().ToList();
                    var ys = floats.Select(x => (double)x.Value).ToArray();

                    if (DataContext is CurveEditorViewModel vm)
                    {
                        vm.LoadCurve(times, ys, type);
                    }

                    break;
                }
                case "Vector2":
                {
                    var floats = values.OfType<Vector2>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();


                    break;
                }
                case "Vector3":
                {
                    var floats = values.OfType<Vector3>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();
                    var zs = floats.Select(x => (double)x.Z.Value).ToArray();


                    break;
                }
                case "Vector4":
                {
                    var floats = values.OfType<Vector4>().ToList();
                    var xs = floats.Select(x => (double)x.X.Value).ToArray();
                    var ys = floats.Select(x => (double)x.Y.Value).ToArray();
                    var zs = floats.Select(x => (double)x.Z.Value).ToArray();
                    var ws = floats.Select(x => (double)x.W.Value).ToArray();


                    break;
                }
            }
        }

        #region drag and drop

        private void POnMouseMove(object sender, MouseEventArgs e)
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            if (_dragStart != null && e.LeftButton == MouseButtonState.Pressed)
            {
                var element = (UIElement)sender;
                var pos = e.GetPosition(CanvasPoints);

                var cpoint = vm.ClampToCanvas(pos);

                Canvas.SetLeft(element, cpoint.X - 3);
                Canvas.SetTop(element, cpoint.Y - 3);

                if (element is Ellipse ell)
                {
                    var model = (GeneralizedPoint)ell.Tag;

                    // find point on curve
                    var generalizedPoint = vm.Curve.FirstOrDefault(_ => _ == model);
                    if (generalizedPoint != null)
                    {
                        var (t, v) = vm.ToWorldCoordinates(cpoint.X, cpoint.Y);
                        generalizedPoint.T = t;
                        generalizedPoint.V = v;

                        vm.Reload(false);
                    }
                }
            }
        }

        private void POnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)sender;
            _dragStart = null;
            element.ReleaseMouseCapture();

            //if (element is Ellipse { Tag: GeneralizedPoint point } ell)
            //{
            //    point.IsSelected = false;
            //    ell.Fill = point.IsSelected ? Brushes.BlueViolet :
            //        point.IsControlPoint ? Brushes.OrangeRed : Brushes.Yellow;
            //}
        }

        private void POnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)sender;
            _dragStart = e.GetPosition(element);
            element.CaptureMouse();

            if (element is Ellipse { Tag: GeneralizedPoint point } /*&& e.ChangedButton == MouseButton.Right*/ && _isCtrlPressed)
            {
                //point.IsSelected = !point.IsSelected;
                //ell.Fill = point.IsSelected ? Brushes.BlueViolet :
                //    point.IsControlPoint ? Brushes.OrangeRed : Brushes.Yellow;

                // delete curve point
                if (DataContext is CurveEditorViewModel vm)
                {
                    vm.Curve.Remove(point);
                    vm.Reload();
                }
            }
        }

        #endregion

        #region events

        private void MainWindow1_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;

            if (DataContext is CurveEditorViewModel vm)
            {
                vm.CurveReloaded += VmOnCurveReloaded;
                vm.CtrlPointsChanged += VmOnCtrlPointsChanged;
                vm.ReLoadCurve();
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                _isCtrlPressed = false;
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                _isCtrlPressed = true;
            }
        }

        private void CanvasPoints_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            vm.Cursor = vm.ClampToCanvas(e.GetPosition(CanvasPoints));
        }

        private void Border_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            var pos = e.GetPosition(CanvasPoints);
            switch (e.ClickCount)
            {
                case 1:
                    // start dragging canvas?
                    break;
                // Add new point
                case 2:
                    vm.AddPoint(pos);
                    //this.RenderPoints();
                    vm.Reload();
                    break;
            }
        }

        private void CanvasPoints_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (DataContext is CurveEditorViewModel vm)
            {
                vm.Height = e.NewSize.Height - (2 * CurveEditorViewModel.YMIN);
                vm.Width = e.NewSize.Width - (2 * CurveEditorViewModel.XMIN);

                if (vm.Curve is not null)
                {
                    vm.Reload();
                }
            }
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HandleInterpolation();
            if (DataContext is CurveEditorViewModel vm)
            {
                vm.Reload();
            }
        }

        private void ButtonReload_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CurveEditorViewModel vm)
            {
                vm.ReLoadCurve();
            }

            //RenderPoints();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        #endregion

        #region methods

        private void VmOnCurveReloaded(object sender, EventArgs e) => RenderPoints();

        private void VmOnCtrlPointsChanged(object sender, EventArgs e) => UpdatePointColors();

        private void HandleInterpolation()
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            if (!vm.IsLoaded)
            {
                return;
            }

            // handle visibility
            switch (vm.GetInterpolationTypeEnum())
            {
                case EInterpolationType.EIT_Constant:
                case EInterpolationType.EIT_Linear:
                    CanvasLinearCurve.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    CanvasQuadraticCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    CanvasCubicCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    break;
                case EInterpolationType.EIT_BezierQuadratic:
                    CanvasLinearCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    CanvasQuadraticCurve.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    CanvasCubicCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    break;
                case EInterpolationType.EIT_BezierCubic:
                    CanvasLinearCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    CanvasQuadraticCurve.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    CanvasCubicCurve.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    break;
                case EInterpolationType.EIT_Hermite:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void RenderPoints()
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }
            if (vm.Curve is null)
            {
                return;
            }

            // unsubscribe from existing points
            foreach (UIElement p in CanvasPoints.Children)
            {
                p.MouseDown -= POnMouseDown;
                p.MouseUp -= POnMouseUp;
                p.MouseMove -= POnMouseMove;
            }

            // clear existing points
            CanvasPoints.Children.Clear();
            DrawAxes();

            // add points
            foreach (var generalizedPoint in vm.Curve)
            {
                var p = new Ellipse
                {
                    Stroke = Brushes.Black,
                    Fill = generalizedPoint.IsSelected ? Brushes.BlueViolet : generalizedPoint.IsControlPoint ? Brushes.OrangeRed : Brushes.Yellow,
                    Width = 8,
                    Height = 8,
                    Tag = generalizedPoint
                };
                Canvas.SetLeft(p, generalizedPoint.RenderPoint.Value.X - 3);
                Canvas.SetTop(p, generalizedPoint.RenderPoint.Value.Y - 3);


                // subscribe
                p.MouseDown += POnMouseDown;
                p.MouseUp += POnMouseUp;
                p.MouseMove += POnMouseMove;

                CanvasPoints.Children.Add(p);
            }

            HandleInterpolation();
            UpdatePointColors();
        }

        private void DrawAxes()
        {
            if (DataContext is CurveEditorViewModel vm)
            {
                var wxmax = /* vm.MaxT * */CanvasPoints.ActualWidth - CurveEditorViewModel.XMIN;
                var wymax = /*vm.MaxV * */CanvasPoints.ActualHeight - CurveEditorViewModel.YMIN;
                //var wxmin = /* vm.MaxT * */CanvasPoints.ActualWidth - CurveEditorViewModel.XMIN;
                //var wymin = /*vm.MaxV * */CanvasPoints.ActualHeight - CurveEditorViewModel.YMIN;
                const double xstep = 40;
                const double ystep = 40;
                const double xtic = 5;
                const double ytic = 5;

                // Make the X axis.
                var xaxisGeom = new GeometryGroup();
                var p0 = new Point(CurveEditorViewModel.XMIN, CanvasPoints.ActualHeight - CurveEditorViewModel.XMIN);
                var p1 = new Point(wxmax, CanvasPoints.ActualHeight - CurveEditorViewModel.XMIN);
                xaxisGeom.Children.Add(new LineGeometry(p0, p1));
                var p01 = new Point(CurveEditorViewModel.XMIN, CurveEditorViewModel.XMIN);
                var p11 = new Point(wxmax, CurveEditorViewModel.XMIN);
                xaxisGeom.Children.Add(new LineGeometry(p01, p11));

                for (var x = 2 * CurveEditorViewModel.XMIN; x <= wxmax; x += xstep)
                {
                    var tic0 = new Point(x, CanvasPoints.ActualHeight - CurveEditorViewModel.XMIN - ytic);
                    var tic1 = new Point(x, CanvasPoints.ActualHeight - CurveEditorViewModel.XMIN + ytic);
                    xaxisGeom.Children.Add(new LineGeometry(tic0, tic1));

                    var t = Math.Round(vm.ToWorldCoordinateX(x), 2);
                    DrawLabels(CanvasPoints, t.ToString(CultureInfo.InvariantCulture),
                        new Point(tic0.X, tic0.Y + 10), 12,
                        HorizontalAlignment.Center,
                        VerticalAlignment.Top);

                    var tic01 = new Point(x, CurveEditorViewModel.XMIN - ytic);
                    var tic11 = new Point(x, CurveEditorViewModel.XMIN + ytic);
                    xaxisGeom.Children.Add(new LineGeometry(tic01, tic11));

                    DrawLabels(CanvasPoints, t.ToString(CultureInfo.InvariantCulture),
                        new Point(tic01.X, tic01.Y - 20), 12,
                        HorizontalAlignment.Center,
                        VerticalAlignment.Top);
                }

                var xaxisPath = new Path
                {
                    StrokeThickness = 1,
                    Stroke = Brushes.Black,
                    Data = xaxisGeom
                };

                CanvasPoints.Children.Add(xaxisPath);

                // Make the Y axis.
                var yaxisGeom = new GeometryGroup();
                p0 = new Point(CurveEditorViewModel.XMIN, CurveEditorViewModel.YMIN);
                p1 = new Point(CurveEditorViewModel.XMIN, wymax);
                xaxisGeom.Children.Add(new LineGeometry(p0, p1));
                p01 = new Point(wxmax, CurveEditorViewModel.YMIN);
                p11 = new Point(wxmax, wymax);
                xaxisGeom.Children.Add(new LineGeometry(p01, p11));

                // total ticks
                for (var y = wymax; y >= CurveEditorViewModel.YMIN; y -= ystep)
                {
                    var tic0 = new Point(CurveEditorViewModel.XMIN - xtic, y);
                    var tic1 = new Point(CurveEditorViewModel.XMIN + xtic, y);
                    xaxisGeom.Children.Add(new LineGeometry(tic0, tic1));

                    // Label the tic mark's Y coordinate.
                    var v = Math.Round(vm.ToWorldCoordinateY(y), 2);
                    DrawLabels(CanvasPoints, v.ToString(CultureInfo.InvariantCulture),
                        new Point(tic0.X - 15, tic0.Y), 12,
                        HorizontalAlignment.Center,
                        VerticalAlignment.Center);

                    var tic01 = new Point(wxmax - xtic, y);
                    var tic11 = new Point(wxmax + xtic, y);
                    xaxisGeom.Children.Add(new LineGeometry(tic01, tic11));

                    // Label the tic mark's Y coordinate.
                    DrawLabels(CanvasPoints, v.ToString(CultureInfo.InvariantCulture),
                        new Point(tic01.X + 25, tic01.Y), 12,
                        HorizontalAlignment.Center,
                        VerticalAlignment.Center);
                }

                var yaxisPath = new Path
                {
                    StrokeThickness = 1,
                    Stroke = Brushes.Black,
                    Data = yaxisGeom
                };

                CanvasPoints.Children.Add(yaxisPath);
            }
        }

        private static void DrawLabels(Panel can, string text, Point location, double fontSize, HorizontalAlignment halign, VerticalAlignment valign)
        {
            // Make the label.
            var label = new Label
            {
                Content = text,
                FontSize = fontSize,
                Background = Brushes.Transparent,
                BorderBrush = Brushes.Transparent
            };
            can.Children.Add(label);

            // Position the label.
            label.Measure(new Size(double.MaxValue, double.MaxValue));

            var x = location.X;
            switch (halign)
            {
                case HorizontalAlignment.Center:
                    x -= label.DesiredSize.Width / 2;
                    break;
                case HorizontalAlignment.Right:
                    x -= label.DesiredSize.Width;
                    break;
            }
            Canvas.SetLeft(label, x);

            double y = location.Y;
            switch (valign)
            {
                case VerticalAlignment.Center:
                    y -= label.DesiredSize.Height / 2;
                    break;
                case VerticalAlignment.Bottom:
                    y -= label.DesiredSize.Height;
                    break;
            }
            Canvas.SetTop(label, y);
        }

        public CurveDto GetCurve()
        {
            if (DataContext is CurveEditorViewModel vm)
            {
                // switch curve type
                switch (_elementType)
                {
                    case "HDRColor":
                    {
                        // TODO
                        var alpha = vm.Curve.Select(_ => new Tuple<double, object>(_.T, (float)_.V)).ToList();
                        var type = vm.GetInterpolationTypeEnum();

                        var values = _model.GetCurvePoints()
                            .Select(x => x.GetValue())
                            .OfType<Tuple<IEditableVariable, IEditableVariable>>()
                            .Select(x => x.Item1)
                            .OfType<HDRColor>()
                            .ToList();

                        if (alpha.Count != values.Count)
                        {

                        }


                        var vec = new List<Tuple<double, object>>();
                        for (var i = 0; i < values.Count; i++)
                        {
                            var item = values[i];
                            item.Alpha.SetValue(alpha[i].Item2);
                            vec.Add(new Tuple<double, object>(alpha[i].Item1, item));
                        }

                        return new CurveDto(vec, type);
                    }
                    case "Float":
                    {
                        var vec = vm.Curve.Select(_ => new Tuple<double, object>(_.T, (float)_.V));
                        var type = vm.GetInterpolationTypeEnum();
                        return new CurveDto(vec, type);
                    }
                    case "Vector2":
                    {// TODO

                        break;
                    }
                    case "Vector3":
                    {
                        // TODO

                        break;
                    }
                    case "Vector4":
                    {
                        // TODO

                        break;
                    }
                }





            }

            return null;
        }

        private void UpdatePointColors()
        {
            foreach (var ellipsis in CanvasPoints.Children.OfType<Ellipse>())
            {
                if (ellipsis.Tag is GeneralizedPoint generalizedPoint)
                {
                    ellipsis.Fill = generalizedPoint.IsSelected ? Brushes.BlueViolet :
                        generalizedPoint.IsControlPoint ? Brushes.OrangeRed : Brushes.Yellow;

                }
            }
        }

        #endregion

        private void CanvasPoints_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            var deltaX = (vm.MaxX - vm.MinX) / 10;
            var deltaY = (vm.MaxV - vm.MinV) / 10;

            // up
            if (e.Delta < 0)
            {
                vm.MaxX += deltaX;
                vm.MinX -= deltaX;

                vm.MaxY += deltaY;
                vm.MinY -= deltaY;
            }

            //down
            else if (e.Delta > 0)
            {
                vm.MaxX -= deltaX;
                vm.MinX += deltaX;

                vm.MaxY -= deltaY;
                vm.MinY += deltaY;
            }
        }

        private void CurvePointsList_CurrentCellEndEdit(object sender, Syncfusion.UI.Xaml.Grid.CurrentCellEndEditEventArgs e)
        {
            if (DataContext is not CurveEditorViewModel vm)
            {
                return;
            }

            vm.ScaleCanvas(vm.Curve.ToList());

            vm.Reload();
        }
    }
}
