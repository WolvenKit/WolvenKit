using System;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedBaseTypeEditor.xaml
    /// </summary>
    public partial class RedBaseTypeEditor : UserControl
    {
        public RedBaseTypeEditor()
        {
            InitializeComponent();
        }

        public IRedType RedType
        {
            get => (IRedType)this.GetValue(RedTypeProperty);
            set => this.SetValue(RedTypeProperty, value);
        }
        public static readonly DependencyProperty RedTypeProperty = DependencyProperty.Register(
            nameof(RedType), typeof(IRedType), typeof(RedBaseTypeEditor), new PropertyMetadata(default(IRedType)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value)
        {
            if (RedType is CName)
            {
                SetCurrentValue(RedTypeProperty, (CName)value);
            }
            else if (RedType is CString)
            {
                SetCurrentValue(RedTypeProperty, (CString)value);
            }

        }

        private string GetValueFromRedValue()
        {
            // null exception here, RedString = null
            var redvalue = RedType?.GetType().Name ?? null;
            if (redvalue is string redstring)
            {
                return redstring;
            }
            else if (redvalue is null)
            {
                return "";
            }
            else
            {
                throw new ArgumentException(nameof(redvalue));
            }
        }


    }
}
