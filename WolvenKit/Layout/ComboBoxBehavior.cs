using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using WolvenKit.App.Services;

namespace WolvenKit.Functionality.Helpers
{
    // https://stackoverflow.com/a/42297391/1530201
    public static class ComboBoxBehavior
    {
        public static readonly DependencyProperty ArrowKeysChangeSelectionProperty =
            DependencyProperty.RegisterAttached(
                "ArrowKeysChangeSelection", typeof(bool), typeof(ComboBoxBehavior),
                new PropertyMetadata(false, OnArrowKeysChangeSelectionChanged));

        private static void OnArrowKeysChangeSelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not ComboBox tb)
            {
                return;
            }

            var enable = (bool)e.NewValue;
            if (enable)
            {
                tb.KeyDown += OnComboboxKeyDown;
                tb.PreviewKeyDown += OnComboBoxPreviewKeyDown;
            }
            else
            {
                tb.PreviewKeyDown -= OnComboBoxPreviewKeyDown;
            }
        }

        private static void OnComboboxKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not ComboBox comboBox || comboBox.IsDropDownOpen)
            {
                return;
            }

            OnComboBoxPreviewKeyDown(sender, e);
        }

        private static void OnComboBoxPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not ComboBox comboBox)
            {
                return;
            }

            switch (e.Key)
            {
                case Key.Down:
                case Key.Right:
                    SetDropdownIndex(comboBox, ModifierViewStateService.IsShiftBeingHeld ? 10 : 1);
                    break;
                case Key.Up:
                case Key.Left:
                    SetDropdownIndex(comboBox, ModifierViewStateService.IsShiftBeingHeld ? -10 : -1);
                    break;
                case Key.PageDown:
                    SetDropdownIndex(comboBox, 10);
                    break;
                case Key.PageUp:
                    SetDropdownIndex(comboBox, -10);
                    break;
                default:
                    return;
            }
        }

        private static void SetDropdownIndex(ComboBox comboBox, int offset)
        {
            if (offset == 0 || comboBox.Items.Count == 0)
            {
                return;
            }

            var index = comboBox.SelectedIndex + offset;
            // clamp to 0 and max items
            index = Math.Max(0, index);
            index = Math.Min(index, comboBox.Items.Count - 1);

            comboBox.SetCurrentValue(Selector.SelectedIndexProperty, index);
        }

        /// <summary>Helper for setting <see cref="ArrowKeysChangeSelectionProperty"/> on <paramref name="element"/>.</summary>
        /// <param name="element"><see cref="DependencyObject"/> to set <see cref="ArrowKeysChangeSelectionProperty"/> on.</param>
        /// <param name="value">ArrowKeysChangeSelection property value.</param>
        public static void SetArrowKeysChangeSelection(DependencyObject element, bool value) =>
            element.SetValue(ArrowKeysChangeSelectionProperty, value);

        public static bool GetArrowKeysChangeSelection(DependencyObject element) =>
            (bool)element.GetValue(ArrowKeysChangeSelectionProperty);
    }
}
