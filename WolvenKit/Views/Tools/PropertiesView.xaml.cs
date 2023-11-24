using System;
using System.Collections.Specialized;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : ReactiveUserControl<PropertiesViewModel>
    {
        public string _fileName;

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            ViewModel.ModelGroup.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action != NotifyCollectionChangedAction.Reset)
                {
                    return;
                }

                if (ViewModel.ModelGroup.Count == 0)
                {
                    return;
                }

                if (!hxViewport.IsInitialized)
                {
                    return;
                }
            };

            ImagePreviewCanvas.PreviewMouseWheel += ImagePreview_MouseWheel;
            ImagePreviewCanvas.MouseDown += ImagePreview_MouseLeftButtonDown;
            ImagePreviewCanvas.MouseUp += ImagePreview_MouseLeftButtonUp;
            ImagePreviewCanvas.MouseMove += ImagePreview_MouseMove;

            ViewModel.WhenAnyValue(x => x.LoadedBitmapFrame).Subscribe(x =>
            {
                var group = new TransformGroup();
                group.Children.Add(new ScaleTransform());
                group.Children.Add(new TranslateTransform());

                ImagePreview.SetCurrentValue(RenderTransformProperty, group);
            });

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PropertiesViewModel.AudioObject))
            {
                // play in viewmodel
                AudioPlayer.ViewModel.LoadOggFile(ViewModel.AudioObject);
            }
        }

        #region Image Preview

        private Point origin;
        private Point start;
        private Point end;

        private void ImagePreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var transformGroup = (TransformGroup)ImagePreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            var zoom = e.Delta > 0 ? 1.2 : (1 / 1.2);

            var cursorPosCanvas = e.GetPosition(ImagePreviewCanvas);
            pan.X += -(cursorPosCanvas.X - (ImagePreviewCanvas.RenderSize.Width / 2.0) - pan.X) * (zoom - 1.0);
            pan.Y += -(cursorPosCanvas.Y - (ImagePreviewCanvas.RenderSize.Height / 2.0) - pan.Y) * (zoom - 1.0);
            end.X = pan.X;
            end.Y = pan.Y;

            transform.ScaleX *= zoom;
            transform.ScaleY *= zoom;
        }

        private void ImagePreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            start = Mouse.GetPosition(ImagePreviewCanvas);
            if (e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.CaptureMouse();
                // resets when children are hittble? idk
                var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                origin = end;
                tt.X = origin.X;
                tt.Y = origin.Y;
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void ImagePreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                ImagePreviewCanvas.ReleaseMouseCapture();
                ImagePreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
                end = new Point(tt.X, tt.Y);
            }
        }

        private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ImagePreviewCanvas.IsMouseCaptured)
            {
                return;
            }

            var tt = (TranslateTransform)((TransformGroup)ImagePreview.RenderTransform).Children[1];
            var v = start - Mouse.GetPosition(ImagePreviewCanvas);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;
        }

        #endregion

        private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
            e.ReadOnly = true;
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();
    }
}
