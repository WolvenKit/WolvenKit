using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedVector3Editor.xaml
    /// </summary>
    public partial class RedVector3Editor : UserControl
    {
        public RedVector3Editor()
        {
            InitializeComponent();
        }

        public CFloat X
        {
            get => (CFloat)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Z
        {
            get => (CFloat)GetValue(ZProperty);
            set => SetValue(ZProperty, value);
        }
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(CFloat), typeof(RedVector3Editor), new PropertyMetadata(default(CFloat)));

        // Bound to the editor
        public double XValue
        {
            get => (double)X;
            set => SetValue(XProperty, (CFloat)value);
        }

        public double YValue
        {
            get => (double)Y;
            set => SetValue(YProperty, (CFloat)value);
        }

        public double ZValue
        {
            get => (double)Z;
            set => SetValue(ZProperty, (CFloat)value);
        }
    }
}
