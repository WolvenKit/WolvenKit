using System;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedBoolEditor.xaml
    /// </summary>
    public partial class RedBoolEditor : UserControl
    {
        public RedBoolEditor()
        {
            InitializeComponent();
        }

        public IREDBool RedBool
        {
            get => (IREDBool)this.GetValue(RedBoolProperty);
            set => this.SetValue(RedBoolProperty, value);
        }
        public static readonly DependencyProperty RedBoolProperty = DependencyProperty.Register(
            nameof(RedBool), typeof(IREDBool), typeof(RedBoolEditor), new PropertyMetadata(default(IREDBool)));


        public bool IsChecked
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(bool value) => RedBool.SetValue(value);

        private bool GetValueFromRedValue()
        {
            var redvalue = RedBool.GetValue();
            return redvalue is bool redbool ? redbool : throw new ArgumentException(nameof(redvalue));
        }


    }
}
