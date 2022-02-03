using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WolvenKit.Functionality.Ab4d
{
    public class InfoControl : Grid
    {
        private readonly TextBlock _tooltipTextBlock;

        public static readonly DependencyProperty InfoTextProperty = DependencyProperty.Register(nameof(InfoText), typeof(object), typeof(InfoControl),
                 new FrameworkPropertyMetadata(null, InfoControl.OnInfoTextChanged));

        /// <summary>
        /// Text that will be shown as ToolTip.
        /// </summary>
        public object InfoText
        {
            get => base.GetValue(InfoTextProperty);
            set => base.SetValue(InfoTextProperty, value);
        }

        private static void OnInfoTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thisInfoControl = (InfoControl)d;

            if (e.NewValue is string)
            {
                thisInfoControl._tooltipTextBlock.SetCurrentValue(TextBlock.TextProperty, ((string)e.NewValue).Replace("\\n", Environment.NewLine));
                thisInfoControl.ToolTip = thisInfoControl._tooltipTextBlock;
            }
            else
            {
                thisInfoControl.ToolTip = e.NewValue;
            }
        }



        public static readonly DependencyProperty InfoWidthProperty = DependencyProperty.Register(nameof(InfoWidth), typeof(double), typeof(InfoControl),
                 new FrameworkPropertyMetadata(0.0, InfoControl.OnInfoWidthChanged));

        /// <summary>
        /// Width of the ToolTip TextBlock. Longer text will be automatically wrapped.
        /// Default value is 0 that does not limit the TextBlock width.
        /// </summary>
        public double InfoWidth
        {
            get => (double)base.GetValue(InfoWidthProperty);
            set => base.SetValue(InfoWidthProperty, value);
        }

        private static void OnInfoWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thisInfoControl = (InfoControl)d;
            var newWidth = (double)e.NewValue;

            if (newWidth == 0)
            {
                newWidth = double.NaN;
            }

            thisInfoControl._tooltipTextBlock.SetCurrentValue(WidthProperty, newWidth);
        }


        public static readonly DependencyProperty ShowDurationProperty = DependencyProperty.Register(nameof(ShowDuration), typeof(int), typeof(InfoControl),
                 new FrameworkPropertyMetadata(120000, InfoControl.OnShowDurationChanged));


        /// <summary>
        /// Duration of showing ToolTip in milliseconds. Default value is 120000.
        /// </summary>
        public int ShowDuration
        {
            get => (int)base.GetValue(ShowDurationProperty);
            set => base.SetValue(ShowDurationProperty, value);
        }

        private static void OnShowDurationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thisInfoControl = (InfoControl)d;
            ToolTipService.SetShowDuration(thisInfoControl, (int)e.NewValue);
        }


        /// <summary>
        /// Gets the Ellipse that is used to show background circle.
        /// </summary>
        public Ellipse BackGroundEllipse { get; private set; }

        /// <summary>
        /// Gets the TextBlock that is used to show the question character.
        /// </summary>
        public TextBlock QuestionTextBlock { get; private set; }


        /// <summary>
        /// Gets or sets the fill brush for the Ellipse shape. Default value is Gray.
        /// </summary>
        public Brush EllipseFillBrush
        {
            get => BackGroundEllipse.Fill;
            set => BackGroundEllipse.SetValue(Shape.FillProperty, value);
        }

        /// <summary>
        /// Gets or sets the foreground brush for the question character. Default value is White.
        /// </summary>
        public Brush QuestionCharacterForeground
        {
            get => QuestionTextBlock.Foreground;
            set => QuestionTextBlock.SetValue(TextBlock.ForegroundProperty, value);
        }

        /// <summary>
        /// Gets or sets the FontSize for the question character. Default value is 10.
        /// </summary>
        public double QuestionCharacterFontSize
        {
            get => QuestionTextBlock.FontSize;
            set => QuestionTextBlock.SetValue(TextBlock.FontSizeProperty, value);
        }




        //<Grid>
        //  <Ellipse Fill = "Gray" Width="12" Height="12" VerticalAlignment="Center" HorizontalAlignment="Center"/>
        //  <TextBlock Text = "?" Foreground="White" FontWeight="Bold" FontFamily="Tahoma" FontSize="10" VerticalAlignment="Center" HorizontalAlignment="Center" Margin="0 0 0 0" />
        //</Grid>

        public InfoControl()
        {
            Width = 12;
            Height = 12;
            VerticalAlignment = VerticalAlignment.Center;

            BackGroundEllipse = new Ellipse()
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Fill = Brushes.Gray
            };

            QuestionTextBlock = new TextBlock()
            {
                Text = "?",
                FontFamily = new FontFamily("Tahoma"),
                FontWeight = FontWeights.Bold,
                FontSize = 10,
                Foreground = Brushes.White,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
            };

            Children.Add(BackGroundEllipse);
            Children.Add(QuestionTextBlock);


            _tooltipTextBlock = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap
            };

            Loaded += (sender, args) => ToolTipService.SetShowDuration(this, ShowDuration);
        }
    }
}
