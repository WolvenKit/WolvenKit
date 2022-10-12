using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedStringEditor.xaml
    /// </summary>
    public partial class RedCNameEditor : UserControl
    {
        public RedCNameEditor()
        {
            InitializeComponent();

            // causes things to be redrawn :/
            Observable.FromEventPattern<TextChangedEventHandler, TextChangedEventArgs>(
                handler => TextBox.TextChanged += handler,
                handler => TextBox.TextChanged -= handler)
                .Throttle(TimeSpan.FromSeconds(.5))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    SetRedValue(TextBox.Text);
                });

        }

        public CName RedString
        {
            get => (CName)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(CName), typeof(RedCNameEditor), new PropertyMetadata(default(CName)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => SetRedValue(TextBox.Text);

        private void SetRedValue(string value) => SetCurrentValue(RedStringProperty, (CName)value);

        private string GetValueFromRedValue()
        {
            var redvalue = (string)RedString;
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
