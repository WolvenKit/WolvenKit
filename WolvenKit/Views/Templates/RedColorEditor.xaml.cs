using System;
using System.Reactive;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ReactiveUI;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedColorEditor.xaml
    /// </summary>
    public partial class RedColorEditor : UserControl
    {
        public RedColorEditor()
        {
            InitializeComponent();

            SelectedColorCommand = ReactiveCommand.Create<object>(OnColorPicked);
        }

        public IREDColor RedColor
        {
            get => (IREDColor)this.GetValue(RedColorProperty);
            set => this.SetValue(RedColorProperty, value);
        }
        public static readonly DependencyProperty RedColorProperty = DependencyProperty.Register(
            nameof(RedColor), typeof(IREDColor), typeof(RedColorEditor), new PropertyMetadata(default(IREDColor)));

        public ReactiveCommand<object, Unit> SelectedColorCommand { get; set; }

        public Color Color
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void OnColorPicked(object e)
        {
            dynamic d = e;
            var mediaColor = d.Brush.Color;
            var c = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
            RedColor?.SetValue(c);
        }

        private void SetRedValue(Color value)
        {
            dynamic d = value;
            var mediaColor = d.Brush.Color;
            var c = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
            RedColor?.SetValue(c);

            //RedColor.SetValue(value);
        }

        private Color GetValueFromRedValue()
        {
            var redvalue = new Color()
            {
                A = RedColor.Value.A,
                R = RedColor.Value.R,
                G = RedColor.Value.G,
                B = RedColor.Value.B
            };
            return redvalue;
        }


    }
}
