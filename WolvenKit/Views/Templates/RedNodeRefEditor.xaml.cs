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
    /// Interaction logic for RedNodeRefEditor.xaml
    /// </summary>
    public partial class RedNodeRefEditor : UserControl
    {
        //[ObservableAsProperty] public bool IsHashEditable { get; }

        public RedNodeRefEditor()
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

        public NodeRef RedNodeRef
        {
            get => (NodeRef)GetValue(RedNodeRefProperty);
            set => SetValue(RedNodeRefProperty, value);
        }
        public static readonly DependencyProperty RedNodeRefProperty = DependencyProperty.Register(
            nameof(RedNodeRef), typeof(NodeRef), typeof(RedNodeRefEditor), new PropertyMetadata(default(NodeRef)));


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
            NodeRef cn = null;
            if (ulong.TryParse(value, out var number))
            {
                cn = number;
            }
            else
            {
                cn = value;
            }
            SetCurrentValue(RedNodeRefProperty, cn);
            HashBox.SetCurrentValue(TextBox.TextProperty, GetHashFromRedValue().ToString());
        }

        private void SetRedValue(ulong value)
        {
            //RedNodeRef = value;
        }

        private string GetPathFromRedValue()
        {
            if (RedNodeRef.GetResolvedText() != null)
            {
                return RedNodeRef.GetResolvedText();
            }
            else if (RedNodeRef.GetRedHash() != 0)
            {
                return GetHashFromRedValue().ToString();
            }
            else
            {
                return "";
            }
        }

        private ulong GetHashFromRedValue() => RedNodeRef.GetRedHash();

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
