using System;
using System.Reactive;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedVectorColorEditor.xaml (colour as vector)
    /// </summary>
    public partial class RedVectorColorEditor : UserControl
    {
        private ChunkViewModel _cvm => DataContext as ChunkViewModel;

        public RedVectorColorEditor()
        {
            InitializeComponent();

            SelectedVectorColorCommand = ReactiveCommand.Create<object>(OnColorPicked);
        }

        public CColor RedVectorColor
        {
            get => (CColor)GetValue(RedVectorColorProperty);
            set => SetValue(RedVectorColorProperty, value);
        }

        public static readonly DependencyProperty RedVectorColorProperty = DependencyProperty.Register(
            nameof(RedVectorColor), typeof(CColor), typeof(RedVectorColorEditor),
            new PropertyMetadata(default(CColor)));

        public ReactiveCommand<object, Unit> SelectedVectorColorCommand { get; set; }

        public Color Color
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private Vector4 ColorToVector4(Color color)
        {
            var x = color.R / 255.0f;
            var y = color.G / 255.0f;
            var z = color.B / 255.0f;
            var w = color.A / 255.0f;

            return new Vector4
            {
                X = x, Y = y, Z = z, W = w,
            };
        }

        private void OnColorPicked(object e)
        {
            dynamic d = e;
            var value = d.Brush.Color;

            // Pass the Vector4 to the ChunkViewModel
            _cvm.Data = ColorToVector4(value);

            _cvm.NotifyChain(nameof(ChunkViewModel.Data));
            _cvm.RecalculateProperties();
            _cvm.CalculateDescriptor();
            _cvm.CalculateValue();
        }

        private byte CFloatToByte(CFloat value)
        {
            var intValue = (int)((value * 255.0f) + 0.5f);
            return (byte)Math.Max(Math.Min(intValue, 255), 0);
        }

        private void SetRedValue(Color value) => OnColorPicked(value);

        private Color GetValueFromRedValue() =>
            Color.FromArgb(CFloatToByte(W), CFloatToByte(X), CFloatToByte(Y), CFloatToByte(Z));

        public CFloat X
        {
            get => (CFloat)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }

        /// <summary>Identifies the <see cref="X"/> dependency property.</summary>
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVectorColorEditor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }

        /// <summary>Identifies the <see cref="Y"/> dependency property.</summary>
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVectorColorEditor), new PropertyMetadata(default(CFloat)));

        public CFloat Z
        {
            get => (CFloat)GetValue(ZProperty);
            set => SetValue(ZProperty, value);
        }

        /// <summary>Identifies the <see cref="Z"/> dependency property.</summary>
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(CFloat), typeof(RedVectorColorEditor), new PropertyMetadata(default(CFloat)));

        public CFloat W
        {
            get => (CFloat)GetValue(WProperty);
            set => SetValue(WProperty, value);
        }

        /// <summary>Identifies the <see cref="W"/> dependency property.</summary>
        public static readonly DependencyProperty WProperty = DependencyProperty.Register(
            nameof(W), typeof(CFloat), typeof(RedVectorColorEditor), new PropertyMetadata(default(CFloat)));
    }
}