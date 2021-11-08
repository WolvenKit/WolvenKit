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

        public CFloat RedString
        {
            get => (CFloat)this.GetValue(RedStringProperty);
            set => this.SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(CFloat), typeof(RedFloatEditor), new PropertyMetadata(default(CFloat)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => RedString.SetValue(value);

        private string GetValueFromRedValue()
        {
            var redvalue = RedString.GetValue();
            if (redvalue is float redfloat)
            {
                return redfloat.ToString("R");
            }
            else 
            {
                throw new ArgumentException(nameof(redvalue));
            }
        }


    }
}
