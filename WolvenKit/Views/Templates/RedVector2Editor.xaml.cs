using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaktionslogik für RedVector2Editor.xaml
    /// </summary>
    public partial class RedVector2Editor : UserControl
    {
        public RedVector2Editor()
        {
            InitializeComponent();
        }

        public CFloat X
        {
            get => (CFloat)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVector2Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVector2Editor), new PropertyMetadata(default(CFloat)));


        // Bound to the editor
        public double XValue
        {
            get => X;
            set => SetValue(XProperty, (CFloat)value);
        }

        public double YValue
        {
            get => Y;
            set => SetValue(YProperty, (CFloat)value);
        }
    }
}
