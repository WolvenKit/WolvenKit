using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : UserControl
    {
        public RedRefEditor()
        {
            InitializeComponent();
        }

        public IREDRef RedRef
        {
            get => (IREDRef)this.GetValue(RedRefProperty);
            set => this.SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IREDRef), typeof(RedRefEditor), new PropertyMetadata(default(IREDRef)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => RedRef.SetValue(value);

        private string GetValueFromRedValue()
        {
            return RedRef.DepotPath;
        }


    }
}
