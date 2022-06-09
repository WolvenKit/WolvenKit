using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using ColorPicker;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaktionslogik für RedColorPicker.xaml
    /// </summary>
    public partial class RedColorPicker : PickerControlBase
    {
        private bool _updateFromColor;

        public RedColorPicker()
        {
            InitializeComponent();

            Color.PropertyChanged += OnColorPropertyChanged;
        }

        public CColor RedColor
        {
            get => (CColor)GetValue(RedColorProperty);
            set => SetValue(RedColorProperty, value);
        }
        public static readonly DependencyProperty RedColorProperty = DependencyProperty.Register(
            nameof(RedColor), typeof(CColor), typeof(RedColorPicker), new PropertyMetadata(default(CColor), OnRedColorChanged));

        public HDRColor RedHDRColor
        {
            get => (HDRColor)GetValue(RedHDRColorProperty);
            set => SetValue(RedHDRColorProperty, value);
        }
        public static readonly DependencyProperty RedHDRColorProperty = DependencyProperty.Register(
            nameof(RedHDRColor), typeof(HDRColor), typeof(RedColorPicker), new PropertyMetadata(default(HDRColor), OnRedHDRColorChanged));

        public SolidColorBrush Brush
        {
            get => (SolidColorBrush)GetValue(BrushProperty);
            set => SetValue(BrushProperty, value);
        }
        public static readonly DependencyProperty BrushProperty = DependencyProperty.Register(
            nameof(Brush), typeof(SolidColorBrush), typeof(RedColorPicker), new PropertyMetadata(default(SolidColorBrush)));

        private void UpdateBrush()
        {
            SetCurrentValue(BrushProperty, new SolidColorBrush(System.Windows.Media.Color.FromArgb(
                (byte)Math.Round(Color.A),
                (byte)Math.Round(Color.RGB_R),
                (byte)Math.Round(Color.RGB_G),
                (byte)Math.Round(Color.RGB_B))));
        }

        private void OnColorPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_updateFromColor)
            {
                return;
            }

            _updateFromColor = true;

            SetCurrentValue(RedColorProperty, new CColor
            {
                Alpha = (CUInt8)Math.Round(Color.A),
                Red = (CUInt8)Math.Round(Color.RGB_R),
                Green = (CUInt8)Math.Round(Color.RGB_G),
                Blue = (CUInt8)Math.Round(Color.RGB_B)
            });

            SetCurrentValue(RedHDRColorProperty, new HDRColor
            {
                Alpha = (CFloat)Color.A,
                Red = (CFloat)Color.RGB_R / 255F,
                Green = (CFloat)Color.RGB_G / 255F,
                Blue = (CFloat)Color.RGB_B / 255F
            });

            UpdateBrush();

            _updateFromColor = false;
        }

        private static void OnRedColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedColorPicker { _updateFromColor: false } picker && e.NewValue is CColor color)
            {
                picker._updateFromColor = true;

                picker.Color.A = color.Alpha;
                picker.Color.RGB_R = color.Red;
                picker.Color.RGB_G = color.Green;
                picker.Color.RGB_B = color.Blue;
                picker.Color.UpdateEverything(picker.ColorState);
                picker.UpdateBrush();

                picker._updateFromColor = false;
            }
        }

        private static void OnRedHDRColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedColorPicker { _updateFromColor: false } picker && e.NewValue is HDRColor color)
            {
                picker._updateFromColor = true;

                picker.Color.A = color.Alpha;
                picker.Color.RGB_R = color.Red * 255F;
                picker.Color.RGB_G = color.Green * 255F;
                picker.Color.RGB_B = color.Blue * 255F;
                picker.Color.UpdateEverything(picker.ColorState);
                picker.UpdateBrush();

                picker._updateFromColor = false;
            }
        }
    }
}
