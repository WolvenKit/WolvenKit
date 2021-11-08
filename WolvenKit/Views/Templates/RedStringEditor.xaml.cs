using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.Common.Model.Cr2w;

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
        }

        public IREDString RedString
        {
            get => (IREDString)this.GetValue(RedStringProperty);
            set => this.SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(IREDString), typeof(RedStringEditor), new PropertyMetadata(default(IREDString)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => RedString.SetValue(value);

        private string GetValueFromRedValue()
        {
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
