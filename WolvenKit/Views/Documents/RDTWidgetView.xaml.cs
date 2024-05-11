using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Tools.Extension;
using Microsoft.Win32;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Layout.inkWidgets;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTWidgetView.xaml
    /// </summary>
    public partial class RDTWidgetView : ReactiveUserControl<RDTWidgetViewModel>
    {

        public List<inkControl> Widgets = new();

        public List<inkControlAnimation> Animations = new();

        public bool ResourcesLoaded = false;

        public RDTWidgetView()
        {
            InitializeComponent();
            SetupWidgetPreview();

            this.WhenActivated(disposables =>
            {
                //this.ViewModel.WhenAnyValue(x => x.library).Subscribe(library =>
                //{

                //}).DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                        x => x.TextWidgets.Values,
                        x => x.TextWidgetList.ItemsSource)
                    .DisposeWith(disposables);

                if (!ResourcesLoaded)
                {
                    ResourcesLoaded = true;
                    Load();
                }
            });
        }

        private void Load()
        {
            Mouse.OverrideCursor = Cursors.Wait;

            ViewModel.LoadResources().ContinueWith(task =>
            {
                if (ViewModel == null)
                {
                    return;
                }
                var stack = new StackPanel();
                Widgets.Clear();
                WidgetPreview.Children.Clear();
                WidgetPreview.Children.Add(stack);

                if (ViewModel.TextWidgets == null)
                {
                    ViewModel.TextWidgets = new();
                }

                ViewModel.TextWidgets.Clear();

                foreach (var item in ViewModel.library.LibraryItems)
                {
                    inkWidgetLibraryItemInstance itemInstance;
                    if (item.Package.Data is CR2WWrapper { File.RootChunk: inkWidgetLibraryItemInstance inst1 })
                    {
                        itemInstance = inst1;
                    }
                    else if (item.PackageData is { Data: RedPackage { Chunks.Count: > 0 } pkg } && pkg.Chunks[0] is inkWidgetLibraryItemInstance inst2)
                    {
                        itemInstance = inst2;
                    }
                    else
                    {
                        Locator.Current.GetService<ILoggerService>().Warning($"LibraryItem {item.Name} did not contain any data and was skipped.");
                        continue;
                    }

                    if (itemInstance.RootWidget.GetValue() is not inkWidget root)
                    {
                        continue;
                    }

                    stack.Children.Add(new TextBlock()
                    {
                        Text = item.Name,
                        Margin = new Thickness(0, 5, 0, 5),
                        Foreground = new SolidColorBrush(Color.FromArgb(30, 255, 255, 255))
                    });

                    var widget = root.CreateControl(this);
                    Widgets.Add(widget);
                    stack.Children.Add(widget);
                }

                WidgetExportButtons.SetCurrentValue(ItemsControl.ItemsSourceProperty, Widgets.Select(x => x.Widget));

                foreach (var animation in ViewModel.InkAnimations)
                {
                    Animations.Add(new inkControlAnimation(animation, this));
                }

                AnimationList.SetCurrentValue(ItemsControl.ItemsSourceProperty, Animations);

                Mouse.OverrideCursor = null;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        // Image Preview
        [RelayCommand]
        private void ExportWidget(object w)
        {
            ViewModel.ExportWidget((inkWidget)w);
        }

        private System.Windows.Point origin;
        private System.Windows.Point start;
        private System.Windows.Point end;

        public void AddTextWidget(inkTextControl control, inkTextWidget widget) => ViewModel.TextWidgets.Add(control, widget);

        private void SetupWidgetPreview()
        {
            var group = new TransformGroup();


            var xform = new ScaleTransform();
            //xform.ScaleY = -1;
            group.Children.Add(xform);

            var tt = new TranslateTransform();
            group.Children.Add(tt);

            //TranslateTransform zoomCenter = new TranslateTransform();
            //group.Children.Add(zoomCenter);

            WidgetPreview.SetCurrentValue(RenderTransformProperty, group);

            WidgetPreviewCanvas.PreviewMouseWheel += WidgetPreview_MouseWheel;
            WidgetPreviewCanvas.MouseDown += WidgetPreview_MouseLeftButtonDown;
            WidgetPreviewCanvas.MouseUp += WidgetPreview_MouseLeftButtonUp;
            WidgetPreviewCanvas.MouseMove += WidgetPreview_MouseMove;
        }

        private void WidgetPreview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                WidgetPreviewCanvas.ReleaseMouseCapture();
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.Arrow);
                var tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
                end = new System.Windows.Point(Math.Round(tt.X), Math.Round(tt.Y));
            }
        }

        private void WidgetPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (!WidgetPreviewCanvas.IsMouseCaptured)
            {
                return;
            }

            var tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
            var v = start - Mouse.GetPosition(WidgetPreviewCanvas);
            tt.X = Math.Round(origin.X - v.X);
            tt.Y = Math.Round(origin.Y - v.Y);
        }

        private void WidgetPreview_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            start = Mouse.GetPosition(WidgetPreviewCanvas);
            if (e.ChangedButton == MouseButton.Middle)
            {
                WidgetPreviewCanvas.CaptureMouse();
                // resets when children are hittble? idk
                var tt = (TranslateTransform)((TransformGroup)WidgetPreview.RenderTransform).Children[1];
                origin = end;
                tt.X = Math.Round(origin.X);
                tt.Y = Math.Round(origin.Y);
                WidgetPreviewCanvas.SetCurrentValue(CursorProperty, Cursors.ScrollAll);
            }
        }

        private void WidgetPreview_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            var transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            var zoom = e.Delta > 0 ? 1.189207115 : (1 / 1.189207115);

            var CursorPosCanvas = e.GetPosition(WidgetPreviewCanvas);
            pan.X += Math.Round(-(CursorPosCanvas.X - (WidgetPreviewCanvas.RenderSize.Width / 2.0) - pan.X) * (zoom - 1.0));
            pan.Y += Math.Round(-(CursorPosCanvas.Y - (WidgetPreviewCanvas.RenderSize.Height / 2.0) - pan.Y) * (zoom - 1.0));
            end.X = pan.X;
            end.Y = pan.Y;

            transform.ScaleX = zoom * transform.ScaleX;
            transform.ScaleY = transform.ScaleX;
            UpdateZoomText(transform.ScaleX);
        }

        public void UpdateZoomText(double scale)
        {
            if (scale >= 1.0)
            {
                RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.NearestNeighbor);
            }
            else
            {
                RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.HighQuality);
            }
            ZoomText.SetCurrentValue(TextBlock.TextProperty, $"{scale * 100:F1}%");
        }

        public void SetRealPixelZoom(object sender, RoutedEventArgs e)
        {
            var transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            //double zoom = ViewModel.Image.Width / WidgetPreview.RenderSize.Width;
            //double zoomQuot = zoom / transform.ScaleX;
            ////WidgetPreview.SetCurrentValue(WidthProperty, ViewModel.Image.Width);
            ////WidgetPreview.SetCurrentValue(HeightProperty, ViewModel.Image.Height);
            //var CursorPosCanvas = start;
            //pan.X += -(CursorPosCanvas.X - WidgetPreviewCanvas.RenderSize.Width / 2.0 - pan.X) * (zoomQuot - 1.0);
            //pan.Y += -(CursorPosCanvas.Y - WidgetPreviewCanvas.RenderSize.Height / 2.0 - pan.Y) * (zoomQuot - 1.0);
            //transform.ScaleX = zoom;
            //transform.ScaleY = zoom;

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            UpdateZoomText(transform.ScaleX);
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }

        public void ResetZoomPan(object sender, RoutedEventArgs e)
        {
            var transformGroup = (TransformGroup)WidgetPreview.RenderTransform;
            var transform = (ScaleTransform)transformGroup.Children[0];
            var pan = (TranslateTransform)transformGroup.Children[1];

            transform.ScaleX = 1;
            transform.ScaleY = 1;
            UpdateZoomText(transform.ScaleX);
            pan.X = 0;
            pan.Y = 0;
            end.X = 0;
            end.Y = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach ((var control, var widget) in ViewModel.TextWidgets)
            {
                if (control is inkTextControl itc)
                {
                    itc.InvalidateMeasure();
                }
            }
        }

        private void SaveAsImage(object sender, RoutedEventArgs e)
        {
            foreach (var widget in Widgets)
            {
                var bitmap = new RenderTargetBitmap((int)widget.RenderSize.Width, (int)widget.RenderSize.Height, 96D, 96D, PixelFormats.Pbgra32);
                bitmap.Render(widget);

                var saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "TIFF Image|*.tiff",
                    Title = "Save an Image As",
                    FileName = widget.Name + ".tiff"
                };
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName.IsNullOrEmpty())
                {
                    continue;
                }

                BitmapEncoder encoder = new TiffBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));

                using var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                encoder.Save(fileStream);
            }

        }

        private void ClearAndReload(object sender, RoutedEventArgs e)
        {
            InkCache.Resources.Clear();

            Load();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var widget in Widgets)
            {
                widget.RenderRecursive();
            }
        }
    }
}
