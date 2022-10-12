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
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : UserControl
    {
        //[ObservableAsProperty] public bool IsHashEditable { get; }

        public RedRefEditor()
        {
            InitializeComponent();

            //this.WhenActivated(disposables =>
            //{
            //this.Bind(ViewModel,
            //        vm => vm.Data,
            //        v => v.RedRef,
            //        (IRedType redType) =>
            //        {
            //            return (IRedRef)redType;
            //        },
            //        (IRedRef redRef) =>
            //        {
            //            return (IRedType)redRef;
            //        })
            //   .DisposeWith(disposables);

            //this.OneWayBind(ViewModel,
            //        vm => (vm.Data as IRedRef).DepotPath.GetRedHash(),
            //        v => v.HashBox.Text)
            //   .DisposeWith(disposables);

            Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => PathBox.KeyUp += handler,
                handler => PathBox.KeyUp -= handler)
                .Throttle(TimeSpan.FromSeconds(.5))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x => SetRedValue(PathBox.Text));

            //this.WhenAnyValue(x => x.Path)
            //    .Select(x => x != "")
            //    .ToPropertyEx(this, x => x.IsHashEditable);
            //});
        }

        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef)));


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
            if (RedRef == null)
            {
                return;
            }

            var cn = ulong.TryParse(value, out var number) ? (CName)number : (CName)value;
            var redRef = (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, cn);
            SetCurrentValue(RedRefProperty, redRef);
            HashBox.SetCurrentValue(TextBox.TextProperty, GetHashFromRedValue().ToString());
        }

        private void SetRedValue(ulong value)
        {
            //RedRef.DepotPath = value;
        }

        private string GetPathFromRedValue()
        {
            // this might need to be handled at the class level like enums
            return RedRef is null || RedRef.DepotPath == CName.Empty
                ? ""
                : string.IsNullOrEmpty((string)RedRef.DepotPath) && RedRef.DepotPath.GetRedHash() != 0 ? GetHashFromRedValue().ToString() : (string)RedRef.DepotPath;
        }

        private ulong GetHashFromRedValue() =>
            // this might need to be handled at the class level like enums
            RedRef?.DepotPath ?? 0;

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
