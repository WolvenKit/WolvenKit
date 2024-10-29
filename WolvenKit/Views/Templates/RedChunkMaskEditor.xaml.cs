using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedChunkMaskEditor.xaml
    /// </summary>
    public partial class RedChunkMaskEditor : UserControl, INotifyPropertyChanged
    {
        public RedChunkMaskEditor()
        {
            InitializeComponent();
            comboboxadv.SelectionChanged += CollectionChanged;
            
            for (var i = 0; i < 64; i++)
            {
                BindingCollection.Add(i.ToString());
            }
        }

        public IRedPrimitive<ulong> RedNumber
        {
            get => (IRedPrimitive<ulong>)GetValue(RedNumberProperty);
            set
            {
                SetValue(RedNumberProperty, value);
                // OnPropertyChanged("RedNumber");
            }
        }

        public static readonly DependencyProperty RedNumberProperty = DependencyProperty.Register(
            nameof(RedNumber), typeof(IRedPrimitive<ulong>), typeof(RedChunkMaskEditor), new PropertyMetadata(default(IRedPrimitive<ulong>)));

        void OnPropertyChanged(String prop)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get => GetTextFromRedValue();
            set => SetRedValueFromText(value);
        }

        public ObservableCollection<string> SelectedItems
        {
            get => GetSelectFromRedValue();
            set => SetRedValueFromSelect(value);
        }

        public ObservableCollection<string> BindingCollection { get; set; } = new();

        public void CollectionChanged(object sender, SelectionChangedEventArgs e) => SetRedValueFromSelect(comboboxadv.SelectedItems.Cast<string>());

        private void SetRedValueFromSelect(IEnumerable<string> value) => SetRedValueFromSelect(string.Join(", ", value.OrderBy(s => ulong.Parse(s))));

        private void SetRedValueFromSelect(string value)
        {
            ulong i = 0;

            if (!string.IsNullOrEmpty(value))
            {
                foreach (var item in value.Split(", "))
                {
                    i |= 1UL << int.Parse(item);
                }
            }

            SetCurrentValue(RedNumberProperty, (CUInt64)i);
            OnPropertyChanged("Text");
        }

        private void SetRedValueFromText(string value)
        {
            SetCurrentValue(RedNumberProperty, (CUInt64)ulong.Parse(value));
            OnPropertyChanged("SelectedItems");
        }

        private ObservableCollection<string> GetSelectFromRedValue()
        {
            var c = new ObservableCollection<string>();
            for (var i = 0; i < 64; i++)
            {
                if (((CUInt64)RedNumber & (1UL << i)) > 0)
                {
                    c.Add(i.ToString());
                }
            }
            return c;
        }

        private string GetTextFromRedValue()
        {
            return ((ulong)(CUInt64)RedNumber).ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var tb = (TextBox)e.Source;
            e.Handled = !ulong.TryParse(tb.Text.Insert(tb.CaretIndex, e.Text), out _);
        }
    }
}
