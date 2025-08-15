using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WolvenKit.Functionality.Helpers
{
    // https://stackoverflow.com/a/42297391/1530201
    public static class TextBoxBehavior
    {
        public static readonly DependencyProperty TripleClickSelectAllProperty = DependencyProperty.RegisterAttached(
            "TripleClickSelectAll", typeof(bool), typeof(TextBoxBehavior), new PropertyMetadata(false, OnTripleClickSelectAllChanged));
        private static void OnTripleClickSelectAllChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox tb)
            {
                var enable = (bool)e.NewValue;
                if (enable)
                {
                    tb.PreviewMouseLeftButtonDown += OnTextBoxMouseDown;
                }
                else
                {
                    tb.PreviewMouseLeftButtonDown -= OnTextBoxMouseDown;
                }
            }
        }

        private static void OnTextBoxMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 3)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        public static void SetTripleClickSelectAll(DependencyObject element, bool value) => element.SetValue(TripleClickSelectAllProperty, value);

        public static bool GetTripleClickSelectAll(DependencyObject element) => (bool)element.GetValue(TripleClickSelectAllProperty);

        //
        // On focus gained: Select everything
        //
        public static readonly DependencyProperty FocusGainedSelectAllProperty = DependencyProperty.RegisterAttached(
            "FocusGainedSelectAll", typeof(bool), typeof(TextBoxBehavior),
            new PropertyMetadata(false, OnFocusGainedSelectAllChanged));


        private static void OnFocusGainedSelectAllChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not TextBox tb)
            {
                return;
            }

            var enable = (bool)e.NewValue;
            if (enable)
            {
                tb.GotFocus += OnFocusGainedTextBoxFocusGained;
            }
            else
            {
                tb.GotFocus -= OnFocusGainedTextBoxFocusGained;
            }
        }

        private static void OnFocusGainedTextBoxFocusGained(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        public static void SetFocusGainedSelectAll(DependencyObject element, bool value) =>
            element.SetValue(FocusGainedSelectAllProperty, value);

        public static bool GetFocusGainedSelectAll(DependencyObject element) =>
            (bool)element.GetValue(FocusGainedSelectAllProperty);

        public static readonly DependencyProperty IsValidProperty =
            DependencyProperty.RegisterAttached(
                "IsValid",
                typeof(bool),
                typeof(TextBoxBehavior),
                new PropertyMetadata(true));

        public static bool GetIsValid(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsValidProperty);
        }

        public static void SetIsValid(DependencyObject obj, bool value)
        {
            obj.SetValue(IsValidProperty, value);
        }
    }
}
