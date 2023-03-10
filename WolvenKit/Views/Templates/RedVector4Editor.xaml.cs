using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedVector4Editor.xaml
    /// </summary>
    public partial class RedVector4Editor : UserControl
    {
        public RedVector4Editor()
        {
            InitializeComponent();
        }

        public CFloat X
        {
            get => (CFloat)GetValue(XProperty);
            set => SetValue(XProperty, value);
        }
        /// <summary>Identifies the <see cref="X"/> dependency property.</summary>
        public static readonly DependencyProperty XProperty = DependencyProperty.Register(
            nameof(X), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Y
        {
            get => (CFloat)GetValue(YProperty);
            set => SetValue(YProperty, value);
        }
        /// <summary>Identifies the <see cref="Y"/> dependency property.</summary>
        public static readonly DependencyProperty YProperty = DependencyProperty.Register(
            nameof(Y), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat Z
        {
            get => (CFloat)GetValue(ZProperty);
            set => SetValue(ZProperty, value);
        }
        /// <summary>Identifies the <see cref="Z"/> dependency property.</summary>
        public static readonly DependencyProperty ZProperty = DependencyProperty.Register(
            nameof(Z), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

        public CFloat W
        {
            get => (CFloat)GetValue(WProperty);
            set => SetValue(WProperty, value);
        }
        /// <summary>Identifies the <see cref="W"/> dependency property.</summary>
        public static readonly DependencyProperty WProperty = DependencyProperty.Register(
            nameof(W), typeof(CFloat), typeof(RedVector4Editor), new PropertyMetadata(default(CFloat)));

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

        public double WValue
        {
            get => (double)W;
            set => SetValue(WProperty, (CFloat)value);
        }
    }
}
