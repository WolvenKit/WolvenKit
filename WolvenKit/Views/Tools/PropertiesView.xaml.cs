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

        private readonly MediaPlayer mediaPlayer = new();

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            //var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            //Resources.MergedDictionaries.Add(themeResources);

            //appControl.ExeName = "binkpl64.exe";
            //appControl.Args = "test2.bk2 /J /I2 /P";
            //this.Unloaded += new RoutedEventHandler((s, e) => { appControl.Dispose(); });


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

            this.WhenActivated(disposables =>
            {
                ViewModel.PreviewAudioCommand
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .Subscribe(async path => await TempConvertToWemWavAsync(path));
            });
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

        #region properties

        //public TimeSpan ChannelPosition { get; set; }

        //public string AudioPositionText { get; set; }

        //public string CurrentTrackName { get; set; }

        //public string ChannelLength { get; set; }

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

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();

        #region AudioPreview

        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        private async Task TempConvertToWemWavAsync(AudioObject obj) => await Task.Run(() => TempConvertToWemWav(obj));

        private void TempConvertToWemWav(AudioObject obj)
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                AudioPlayer.OpenAudioObject(obj);
            });
        }

        #endregion AudioPreview

    }
}
