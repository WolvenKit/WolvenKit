using System;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

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

        public CBool RedBool
        {
            get => (CBool)GetValue(RedBoolProperty);
            set => SetValue(RedBoolProperty, value);
        }
        public static readonly DependencyProperty RedBoolProperty = DependencyProperty.Register(
            nameof(RedBool), typeof(CBool), typeof(RedBoolEditor), new PropertyMetadata(default(CBool)));


        public bool IsChecked
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(bool value) => SetCurrentValue(RedBoolProperty, (CBool)value);

        private bool GetValueFromRedValue()
        {
            var redvalue = (bool)RedBool;
            return redvalue is bool redbool ? redbool : throw new ArgumentException(nameof(redvalue));
        }


    }
}
