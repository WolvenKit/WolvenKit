using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedFloatEditor.xaml
    /// </summary>
    public partial class RedFloatEditor : UserControl
    {
        public RedFloatEditor()
        {
            InitializeComponent();
        }

        public CFloat RedNumber
        {
            get => (CFloat)this.GetValue(RedNumberProperty);
            set => this.SetValue(RedNumberProperty, value);
        }
        public static readonly DependencyProperty RedNumberProperty = DependencyProperty.Register(
            nameof(RedNumber), typeof(CFloat), typeof(RedFloatEditor), new PropertyMetadata(default(CFloat)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => SetCurrentValue(RedNumberProperty, (CFloat)float.Parse(value));

        private string GetValueFromRedValue() => ((float)RedNumber).ToString("R");


    }
}
