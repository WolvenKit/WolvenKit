using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.RED4.Types;

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

        public IRedRef RedRef
        {
            get => (IRedRef)this.GetValue(RedRefProperty);
            set => this.SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value) => RedRef.DepotPath = value;

        private string GetValueFromRedValue()
        {
            return RedRef.DepotPath;
        }


    }
}
