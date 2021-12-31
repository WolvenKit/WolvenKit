using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedStringEditor : UserControl
    {
        public RedStringEditor()
        {
            InitializeComponent();
            TextBox.KeyUp += TextBox_KeyUp;
        }

        public IRedString RedString
        {
            get => (IRedString)this.GetValue(RedStringProperty);
            set => this.SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(IRedString), typeof(RedStringEditor), new PropertyMetadata(default(IRedString)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SetRedValue(TextBox.Text);
        }

        private void SetRedValue(string value)
        {
            //RedString.SetValue(value);
            if (RedString is CName)
                SetCurrentValue(RedStringProperty, (CName)value);
            else if (RedString is CString)
                SetCurrentValue(RedStringProperty, (CString)value);
        }

        private string GetValueFromRedValue()
        {
            // null exception here, RedString = null
            if (RedString is null)
            {
                return "";
            } 
            var redvalue = RedString.GetValue();
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
