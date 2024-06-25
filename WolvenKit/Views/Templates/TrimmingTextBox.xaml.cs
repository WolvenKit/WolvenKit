using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaktionslogik für TrimmingTextBox.xaml
    /// </summary>
    public partial class TrimmingTextBox : UserControl
    {
        #region Public Properties

        /// <summary>
        /// The DependencyID for the Text property.
        /// Default Value:      ""
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text), // Property name
                typeof(string), // Property type
                typeof(TrimmingTextBox), // Property owner
                new FrameworkPropertyMetadata( // Property metadata
                    string.Empty // default value
                ));

        /// <summary>
        /// Contents of the TextBox.
        /// </summary>
        [DefaultValue("")]
        [Localizability(LocalizationCategory.Text)]
        public new Brush BorderBrush
        {
            get => (Brush)GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }

        /// <summary>
        /// The DependencyID for the BorderBrush property.
        /// Default Value:      ""
        /// </summary>
        public static new readonly DependencyProperty BorderBrushProperty = DependencyProperty.Register(
            nameof(BorderBrush), // Property name
            typeof(Brush), // Property type
            typeof(TrimmingTextBox), // Property owner
            new FrameworkPropertyMetadata( // Property metadata
                default(Brush)) // default value
        );

        /// <summary>
        /// Contents of the TextBox.
        /// </summary>
        [DefaultValue("")]
        [Localizability(LocalizationCategory.Text)]
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }


        public static readonly DependencyProperty TooltipProperty =
            DependencyProperty.Register(
                nameof(Tooltip), // Property name
                typeof(string), // Property type
                typeof(TrimmingTextBox), // Property owner
                new FrameworkPropertyMetadata( // Property metadata
                    string.Empty // default value
                ));

        public string Tooltip
        {
            get => (string)GetValue(TooltipProperty);
            set => SetValue(TooltipProperty, value);
        }

        #endregion

        private ScrollViewer _scrollViewer;

        public TrimmingTextBox()
        {
            InitializeComponent();
        }

        private void FetchScrollViewer()
        {
            if (_scrollViewer != null)
            {
                return;
            }

            _scrollViewer = RealTextBox.GetChildOfType<ScrollViewer>();
            if (_scrollViewer != null)
            {
                _scrollViewer.ScrollChanged += ScrollViewer_OnScrollChanged;
            }
        }

        private void ScrollViewer_OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            StartTrimming.SetCurrentValue(VisibilityProperty, _scrollViewer.HorizontalOffset > 0 ? Visibility.Visible : Visibility.Hidden);
            EndTrimming.SetCurrentValue(VisibilityProperty, Math.Abs(_scrollViewer.ScrollableWidth - _scrollViewer.HorizontalOffset) > 1 ? Visibility.Visible : Visibility.Hidden);
        }

        private void RealTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            FetchScrollViewer();

            if (!RealTextBox.IsFocused)
            {
                _scrollViewer?.ScrollToRightEnd();
            }
        }
    }
}
