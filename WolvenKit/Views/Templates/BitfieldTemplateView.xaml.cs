using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.Types;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for BitfieldTemplateView.xaml
    /// </summary>
    public partial class BitfieldTemplateView : UserControl
    {
        public BitfieldTemplateView()
        {
            InitializeComponent();

            // TODO MB
            //Observable.FromEventPattern<SelectionChangedEventHandler, SelectionChangedEventArgs>(
            //      handler => comboboxadv.SelectionChanged += handler,
            //      handler => comboboxadv.SelectionChanged -= handler)
            //        .Subscribe(e => CollectionChanged())
            //        ;
        }

        public ObservableCollection<string> SelectedItems
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        public ObservableCollection<string> BindingCollection { get; set; } = new();

        public IRedBitField RedBitfield
        {
            get => (IRedBitField)GetValue(RedBitfieldProperty);
            set => SetValue(RedBitfieldProperty, value);
        }

        public static readonly DependencyProperty RedBitfieldProperty =
            DependencyProperty.Register(nameof(RedBitfield), typeof(IRedBitField),
                typeof(BitfieldTemplateView), new PropertyMetadata(OnRedBitfieldChanged));


        private static void OnRedBitfieldChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not BitfieldTemplateView view)
            {
                return;
            }
            if (view.RedBitfield == null)
            {
                return;
            }
            if (e.NewValue is not IRedBitField ibf)
            {
                return;
            }

            if (e.OldValue == null)
            {
                view.BindingCollection.Clear();
                view.SelectedItems.Clear();
                foreach (var s in Enum.GetNames(ibf.GetInnerType()))
                {
                    view.BindingCollection.Add(s);
                    if (ibf.ToBitFieldString().Contains(s))
                    {
                        view.SelectedItems.Add(s);
                    }
                }
            }
        }

        //public void CollectionChanged() => SetRedValue(string.Join(", ", comboboxadv.SelectedItems.Cast<string>()));

        private void SetRedValue(string value)
        {
            var redBitfield = CBitField.Parse(RedBitfield.GetInnerType(), value);
            SetCurrentValue(RedBitfieldProperty, redBitfield);
        }

        private void SetRedValue(ObservableCollection<string> value) => SetRedValue(string.Join(", ", value));

        private ObservableCollection<string> GetValueFromRedValue() => new ObservableCollection<string>(RedBitfield?.ToBitFieldString().Split(", ") ?? Array.Empty<string>());
    }
}
