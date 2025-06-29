using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.Helpers;
using WolvenKit.Modkit.Resources;

namespace WolvenKit.Views.Editors
{
    public partial class TrimmingTextBox : UserControl
    {
        /// <summary>Identifies the <see cref="Text"/> dependency property.</summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(TrimmingTextBox),
                new FrameworkPropertyMetadata(string.Empty));

        /// <summary>Identifies the <see cref="Background"/> dependency property.</summary>
        public static new readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register(
                nameof(Background),
                typeof(Brush),
                typeof(TrimmingTextBox),
                new FrameworkPropertyMetadata(
                    Application.Current.FindResource("BackgroundColor_Control") as Brush)); // Use resource as default value

        /// <summary>Identifies the <see cref="Tooltip"/> dependency property.</summary>
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

        public TrimmingTextBox() => InitializeComponent();

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

        private void RefreshContextMenu(object sender, ContextMenuEventArgs contextMenuEventArgs)
        {
            CutMenuItem.SetCurrentValue(IsEnabledProperty, RealTextBox.SelectionLength > 0);
            CopyMenuItem.SetCurrentValue(IsEnabledProperty, RealTextBox.SelectionLength > 0);
            PasteMenuItem.SetCurrentValue(IsEnabledProperty, Clipboard.ContainsText());

            if (string.IsNullOrWhiteSpace(Text) ||
                (!ArchiveXlHelper.HasSubstitution(Text) && !ArchiveXlHelper.CouldHaveSubstitution(Text)))
            {
                DynamicPathMenuItem.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                DynamicSeparator.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return;
            }

            DynamicSeparator.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            DynamicPathMenuItem.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            if (ArchiveXlHelper.HasSubstitution(Text))
            {
                DynamicPathMenuItem.SetCurrentValue(HeaderedItemsControl.HeaderProperty,
                    "Resolve dynamic substitution");
            }
            else
            {
                DynamicPathMenuItem.SetCurrentValue(HeaderedItemsControl.HeaderProperty,
                    "Convert to dynamic substitution");
            }
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

        private void RealTextBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            // custom undo/redo handling
            if (!(e.Key == Key.Z && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                OnKeyUp?.Invoke(sender, e);
                return;
            }

            if ((Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
            {
                // Ctrl+Shift+Z for redo
                if (RealTextBox.CanRedo)
                {
                    RealTextBox.Redo();
                }
                else
                {
                    var previous = Text;
                    RealTextBox.SetCurrentValue(TextBox.TextProperty, _previousValue);
                    _previousValue = previous;
                }
            }
            else
            {
                // Ctrl+Z for undo
                if (RealTextBox.CanUndo)
                {
                    RealTextBox.Undo();
                }
                else
                {
                    var previous = Text;
                    RealTextBox.SetCurrentValue(TextBox.TextProperty, _previousValue);
                    _previousValue = previous;
                }
            }

            e.Handled = true;
            OnKeyUp?.Invoke(sender, e);
        }

        private void Cut_Click(object sender, RoutedEventArgs e) => RealTextBox.Cut();

        private void Copy_Click(object sender, RoutedEventArgs e) => RealTextBox.Copy();

        private void Paste_Click(object sender, RoutedEventArgs e) => RealTextBox.Paste();

        private string _previousValue = string.Empty;

        private void MakeDynamic_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            if (!ArchiveXlHelper.HasSubstitution(Text))
            {
                _previousValue = Text;
                RealTextBox.SetCurrentValue(TextBox.TextProperty, ArchiveXlHelper.MakeDynamic(Text));
            }
            else if (App.Helpers.ArchiveXlHelper.GetFirstExistingPath(Text) is string s)
            {
                _previousValue = Text;
                RealTextBox.SetCurrentValue(TextBox.TextProperty, s);
            }
        }
    }
}