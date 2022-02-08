//Code Auther: Mr. Squirrel.Downy (Flithor)
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WolvenKit.Functionality.Layout
{
    public class NineSlicePanel : ContentControl
    {
        private ImageSource[] patchs;

        [Category("Background")]
        [Description("Set nine patch background image")]
        public ImageSource BackgroundImage
        {
            get => (ImageSource)GetValue(BackgroundImageProperty);
            set => SetValue(BackgroundImageProperty, value);
        }
        public static readonly DependencyProperty BackgroundImageProperty =
            DependencyProperty.Register(nameof(BackgroundImage), typeof(ImageSource), typeof(NineSlicePanel), new PropertyMetadata(null, OnBackgroundImageChanged));

        [Category("Background")]
        [Description("Set the center split area")]
        public Thickness NineSlice
        {
            get => (Thickness)GetValue(NineSliceProperty);
            set => SetValue(NineSliceProperty, value);
        }
        public static readonly DependencyProperty NineSliceProperty =
            DependencyProperty.Register(nameof(NineSlice), typeof(Thickness), typeof(NineSlicePanel), new PropertyMetadata(new Thickness(0, 0, 0, 0), OnNineSliceChanged));

        protected override void OnRender(DrawingContext dc)
        {
            if (patchs != null)
            {
                double x1 = patchs[0].Width, x2 = Math.Max(ActualWidth - patchs[2].Width, 0);
                double y1 = patchs[0].Height, y2 = Math.Max(ActualHeight - patchs[6].Height, 0);
                double w1 = patchs[0].Width, w2 = Math.Max(x2 - x1, 0), w3 = patchs[2].Width;
                double h1 = patchs[0].Height, h2 = Math.Max(y2 - y1, 0), h3 = patchs[6].Height;
                var rects = new[]
                {
                new Rect(0, 0, w1, h1),
                new Rect(x1, 0, w2, h1),
                new Rect(x2, 0, w3, h1),
                new Rect(0, y1, w1, h2),
                new Rect(x1, y1, w2, h2),
                new Rect(x2, y1, w3, h2),
                new Rect(0, y2, w1, h3),
                new Rect(x1, y2, w2, h3),
                new Rect(x2, y2, w3, h3)
            };
                for (var i = 0; i < 9; i++)
                {
                    dc.DrawImage(patchs[i], rects[i]);
                }
            }
            base.OnRender(dc);
        }

        private static void OnNineSliceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var np = d as NineSlicePanel;
            if (np == null)
            {
                return;
            }

            var bm = np.BackgroundImage as BitmapSource;
            if (bm != null)
            {
                SetPatchs(np, bm);
            }
        }
        private static void OnBackgroundImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var np = d as NineSlicePanel;
            if (np == null)
            {
                return;
            }

            var bm = np.BackgroundImage as BitmapSource;
            if (np.NineSlice == new Thickness(0, 0, 0, 0))
            {
                var w1_3 = bm.PixelWidth / 3;
                var h1_3 = bm.PixelHeight / 3;
                np.NineSlice = new Thickness(w1_3, h1_3, w1_3, h1_3);
            }
            else
            {
                SetPatchs(np, bm);
            }
        }

        private static void SetPatchs(NineSlicePanel np, BitmapSource bm)
        {
            try
            {
                double x1 = np.NineSlice.Left, x2 = bm.Width - np.NineSlice.Right;
                double y1 = np.NineSlice.Top, y2 = bm.Height - np.NineSlice.Bottom;
                double w1 = np.NineSlice.Left, w3 = np.NineSlice.Right % (bm.Width - w1), w2 = bm.Width - w1 - w3;
                double h1 = np.NineSlice.Top, h3 = np.NineSlice.Bottom % (bm.Height - h1), h2 = bm.Height - h1 - h3;
                np.patchs = new ImageSource[9];

                np.patchs[0] = new CroppedBitmap(bm, new Int32Rect(0, 0, (int)w1, (int)h1));
                np.patchs[1] = new CroppedBitmap(bm, new Int32Rect((int)x1, 0, (int)w2, (int)h1));
                np.patchs[2] = new CroppedBitmap(bm, new Int32Rect((int)x2, 0, (int)w3, (int)h1));

                np.patchs[3] = new CroppedBitmap(bm, new Int32Rect(0, (int)y1, (int)w1, (int)h2));
                np.patchs[4] = new CroppedBitmap(bm, new Int32Rect((int)x1, (int)y1, (int)w2, (int)h2));
                np.patchs[5] = new CroppedBitmap(bm, new Int32Rect((int)x2, (int)y1, (int)w3, (int)h2));

                np.patchs[6] = new CroppedBitmap(bm, new Int32Rect(0, (int)y2, (int)w1, (int)h3));
                np.patchs[7] = new CroppedBitmap(bm, new Int32Rect((int)x1, (int)y2, (int)w2, (int)h3));
                np.patchs[8] = new CroppedBitmap(bm, new Int32Rect((int)x2, (int)y2, (int)w3, (int)h3));
            }
            catch (Exception)
            {
                var w1_3 = bm.PixelWidth / 3;
                var h1_3 = bm.PixelHeight / 3;
                np.SetCurrentValue(NineSliceProperty, new Thickness(w1_3, h1_3, w1_3, h1_3));

                double x1 = np.NineSlice.Left, x2 = bm.Width - np.NineSlice.Right;
                double y1 = np.NineSlice.Top, y2 = bm.Height - np.NineSlice.Bottom;
                double w1 = np.NineSlice.Left, w3 = np.NineSlice.Right, w2 = bm.Width - w1 - w3;
                double h1 = np.NineSlice.Top, h3 = np.NineSlice.Bottom, h2 = bm.Height - h1 - h3;
                np.patchs = new ImageSource[9];

                np.patchs[0] = new CroppedBitmap(bm, new Int32Rect(0, 0, (int)w1, (int)h1));
                np.patchs[1] = new CroppedBitmap(bm, new Int32Rect((int)x1, 0, (int)w2, (int)h1));
                np.patchs[2] = new CroppedBitmap(bm, new Int32Rect((int)x2, 0, (int)w3, (int)h1));

                np.patchs[3] = new CroppedBitmap(bm, new Int32Rect(0, (int)y1, (int)w1, (int)h2));
                np.patchs[4] = new CroppedBitmap(bm, new Int32Rect((int)x1, (int)y1, (int)w2, (int)h2));
                np.patchs[5] = new CroppedBitmap(bm, new Int32Rect((int)x2, (int)y1, (int)w3, (int)h2));

                np.patchs[6] = new CroppedBitmap(bm, new Int32Rect(0, (int)y2, (int)w1, (int)h3));
                np.patchs[7] = new CroppedBitmap(bm, new Int32Rect((int)x1, (int)y2, (int)w2, (int)h3));
                np.patchs[8] = new CroppedBitmap(bm, new Int32Rect((int)x2, (int)y2, (int)w3, (int)h3));

            }
        }
    }
}
