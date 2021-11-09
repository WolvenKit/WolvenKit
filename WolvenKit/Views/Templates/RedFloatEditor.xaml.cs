using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;

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

        public IREDIntegerType RedNumber
        {
            get => (IREDIntegerType)this.GetValue(RedNumberProperty);
            set => this.SetValue(RedNumberProperty, value);
        }
        public static readonly DependencyProperty RedNumberProperty = DependencyProperty.Register(
            nameof(RedNumber), typeof(IREDIntegerType), typeof(RedFloatEditor), new PropertyMetadata(default(IREDIntegerType)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => RedNumber.SetValue(value);

        private string GetValueFromRedValue()
        {
            var redvalue = RedNumber.GetValue();
            return redvalue switch
            {
                float redfloat => redfloat.ToString("R"),
                ulong redulong => redulong.ToString(),
                _ => throw new ArgumentException(nameof(redvalue))
            };
        }


    }
}
