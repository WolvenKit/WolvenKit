using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WolvenKit.Functionality.Helpers
{
    internal class TreeGridButton : Button
    {
        #region Constructor

        public TreeGridButton()
        {
            PreviewMouseLeftButtonDown += OnLeftMouseButtonDownPreview;
            PreviewMouseLeftButtonUp += OnLeftMouseButtonUpPreview;
            MouseLeave += OnMouseLeave;
        }

        #endregion

        private bool mouseDown = false;

        #region Event Handler

        private void OnLeftMouseButtonDownPreview(object sender, MouseButtonEventArgs e)
        {
            // Prevent the event from going further
            e.Handled = true;
            mouseDown = true;
        }
        private void OnLeftMouseButtonUpPreview(object sender, MouseButtonEventArgs e)
        {
            // Prevent the event from going further
            e.Handled = true;

            if (mouseDown)
            {
                mouseDown = false;
                // Invoke a click event on the button
                var peer = new ButtonAutomationPeer(this);
                var invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
                if (invokeProv != null)
                {
                    invokeProv.Invoke();
                }
            }
        }
        private void OnMouseLeave(object sender, MouseEventArgs e) => mouseDown = false;

        #endregion

        private static readonly Brush DefaultHoverBackgroundValue = new BrushConverter().ConvertFromString("#FF373737") as Brush;

        public Brush HoverBackground
        {
            get => (Brush)GetValue(HoverBackgroundProperty);
            set => SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty = DependencyProperty.Register(
          nameof(HoverBackground), typeof(Brush), typeof(TreeGridButton), new PropertyMetadata(DefaultHoverBackgroundValue));
        private static readonly Brush DefaultPressedBackgroundValue = new BrushConverter().ConvertFromString("#FF131313") as Brush;

        public Brush PressedBackground
        {
            get => (Brush)GetValue(PressedBackgroundProperty);
            set => SetValue(PressedBackgroundProperty, value);
        }

        public static readonly DependencyProperty PressedBackgroundProperty = DependencyProperty.Register(
          nameof(PressedBackground), typeof(Brush), typeof(TreeGridButton), new PropertyMetadata(DefaultPressedBackgroundValue));
    }
}
