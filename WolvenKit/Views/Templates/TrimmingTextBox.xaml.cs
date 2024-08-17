using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Editors
{
    public partial class TrimmingTextBox : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(TrimmingTextBox),
                new FrameworkPropertyMetadata(string.Empty));

        public static new readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register(
                nameof(Background),
                typeof(Brush),
                typeof(TrimmingTextBox),
                new FrameworkPropertyMetadata(default(Brush)));

        public static readonly DependencyProperty TooltipProperty =
            DependencyProperty.Register(
                nameof(Tooltip),
                typeof(string),
                typeof(TrimmingTextBox),
                new FrameworkPropertyMetadata(string.Empty));

        [DefaultValue("")]
        [Localizability(LocalizationCategory.Text)]
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        [DefaultValue("")]
        [Localizability(LocalizationCategory.Text)]
        public new Brush BorderBrush
        {
            get => (Brush)GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }

        [DefaultValue("")]
        [Localizability(LocalizationCategory.Text)]
        public new Brush Background
        {
            get => (Brush)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        public string Tooltip
        {
            get => (string)GetValue(TooltipProperty);
            set => SetValue(TooltipProperty, value);
        }

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

        public event EventHandler OnChange;
        private void RealTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshScrollViewer();
            OnChange?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshScrollViewer()
        {
            FetchScrollViewer();

            if (!RealTextBox.IsFocused)
            {
                _scrollViewer?.ScrollToRightEnd();
            }
        }

        public event EventHandler OnPaste;

        private void RealTextBox_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            RefreshScrollViewer();
            OnPaste?.Invoke(this, EventArgs.Empty);
        }

        public new event EventHandler OnKeyUp;
        private void RealTextBox_OnKeyUp(object sender, KeyEventArgs e) => OnKeyUp?.Invoke(sender, e);
    }
}