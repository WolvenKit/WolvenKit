using System;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedTweakEditor.xaml
    /// </summary>
    public partial class RedTweakEditor : UserControl
    {

        public RedTweakEditor()
        {
            InitializeComponent();

            Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => PathBox.KeyUp += handler,
                handler => PathBox.KeyUp -= handler)
                .Throttle(TimeSpan.FromSeconds(.5))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    SetRedValue(PathBox.Text);
                });
        }

        public TweakDBID RedTweak
        {
            get => (TweakDBID)GetValue(RedTweakProperty);
            set => SetValue(RedTweakProperty, value);
        }
        public static readonly DependencyProperty RedTweakProperty = DependencyProperty.Register(
            nameof(RedTweak), typeof(TweakDBID), typeof(RedTweakEditor), new PropertyMetadata(default(TweakDBID)));


        public string Path
        {
            get => GetPathFromRedValue();
            set => SetRedValue(value);
        }

        public ulong Hash
        {
            get => GetHashFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(string value)
        {
            if (RedTweak == null)
                return;
            TweakDBID tdb = null;
            if (ulong.TryParse(value, out var number))
            {
                tdb = number;
            }
            else
            {
                tdb = value;
            }
            SetCurrentValue(RedTweakProperty, tdb);
            HashBox.SetCurrentValue(TextBox.TextProperty, GetHashFromRedValue().ToString());
        }

        private void SetRedValue(ulong value)
        {
            //RedTweak = value;
        }

        private string GetPathFromRedValue()
        {
            if (RedTweak.ResolvedText == null)
            {
                return GetHashFromRedValue().ToString();
            }
            return RedTweak.ResolvedText;
        }

        private ulong GetHashFromRedValue()
        {
            return (ulong)RedTweak;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
