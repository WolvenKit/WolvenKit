using System;
using System.Collections.ObjectModel;
using System.Linq;
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
        private ObservableCollection<string> _selectedItems;

        public BitfieldTemplateView()
        {
            InitializeComponent();

            comboboxadv.SelectionChanged += CollectionChanged;
        }

        public ObservableCollection<string> SelectedItems => _selectedItems ??= new ObservableCollection<string>(RedBitfield?.ToBitFieldString().Split(", ") ?? []);

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

        public void CollectionChanged(object sender, SelectionChangedEventArgs e) => SetRedValue(string.Join(", ", comboboxadv.SelectedItems.Cast<string>()));

        private void SetRedValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                SetCurrentValue(RedBitfieldProperty, (IRedBitField)RedTypeManager.CreateRedType(RedBitfield.RedType));
            }
            else
            {
                var redBitfield = CBitField.Parse(RedBitfield.GetInnerType(), value);
                SetCurrentValue(RedBitfieldProperty, redBitfield);
            }
        }
    }
}
