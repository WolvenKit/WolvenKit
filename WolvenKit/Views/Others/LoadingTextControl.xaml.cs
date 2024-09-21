using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views.Others;

public partial class LoadingTextControl : UserControl
{
    public LoadingTextControl() => InitializeComponent();

    public static readonly DependencyProperty VisibilityFlagProperty =
        DependencyProperty.Register(nameof(VisibilityFlag), typeof(bool), typeof(LoadingTextControl), new PropertyMetadata(false));

    public bool VisibilityFlag
    {
        get => (bool)GetValue(VisibilityFlagProperty);
        set => SetValue(VisibilityFlagProperty, value);
    }

    public static readonly DependencyProperty SmallProperty =
        DependencyProperty.Register(nameof(Small), typeof(bool), typeof(LoadingTextControl), new PropertyMetadata(false));

    public bool Small
    {
        get => (bool)GetValue(SmallProperty);
        set => SetValue(SmallProperty, value);
    }
}