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
    public partial class RedStringEditor : UserControl
    {
        public RedStringEditor()
        {
            InitializeComponent();
            //TextBox.TextChanged += TextBox_TextChanged;

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

        public IRedString RedString
        {
            get => (IRedString)GetValue(RedStringProperty);
            set => SetValue(RedStringProperty, value);
        }
        public static readonly DependencyProperty RedStringProperty = DependencyProperty.Register(
            nameof(RedString), typeof(IRedString), typeof(RedStringEditor), new PropertyMetadata(default(IRedString)));


        public string Text
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => SetRedValue(TextBox.Text);

        private void SetRedValue(string value)
        {
            //RedString.SetValue(value);
            if (RedString is CName)
            {
                SetCurrentValue(RedStringProperty, (CName)value);
            }
            else if (RedString is CString)
            {
                SetCurrentValue(RedStringProperty, (CString)value);
            }
            else if (RedString is NodeRef)
            {
                SetCurrentValue(RedStringProperty, (NodeRef)value);
            }
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
