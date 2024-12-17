using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WolvenKit.App.Services;
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

            Observable.FromEventPattern<SelectionChangedEventHandler, SelectionChangedEventArgs>(
                  handler => comboboxadv.SelectionChanged += handler,
                  handler => comboboxadv.SelectionChanged -= handler)
                    .Subscribe(e => CollectionChanged())
                    ;

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

        private void OnPropertyChanged(String prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
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

        public void CollectionChanged() => SetRedValueFromSelect(comboboxadv.SelectedItems.Cast<string>());

        private void SetRedValueFromSelect(IEnumerable<string> value)
        {
            var valueString = string.Join(", ", value.OrderBy(ulong.Parse));
            var numericValue = TextToNumber(valueString);

            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                var currentValue = (ulong)(CUInt64)RedNumber;
                if (numericValue > currentValue || currentValue == 0)
                {
                    // a box was checked
                    SetCurrentValue(RedNumberProperty, (CUInt64)ulong.MaxValue);
                    OnPropertyChanged("SelectedItems");
                }
                else
                {
                    // a box was unchecked
                    SetCurrentValue(RedNumberProperty, (CUInt64)0);
                    OnPropertyChanged("SelectedItems");
                }
            }
            else
            {
                SetCurrentValue(RedNumberProperty, (CUInt64)numericValue);
            }

            OnPropertyChanged("Text");
        }

        private ulong TextToNumber(string value = "")
        {
            return value.Split(", ")
                .Select(s =>
                {
                    if (int.TryParse(s, out var num))
                    {
                        return num;
                    }

                    return -1;
                })
                .Where(num => num >= 0)
                .Aggregate<int, ulong>(0, (current, item) => current | (1UL << item));
        }


        private void SetRedValueFromText(string value)
        {
            SetCurrentValue(RedNumberProperty, (CUInt64)ulong.Parse(value));
            OnPropertyChanged("SelectedItems");
        }

        private ObservableCollection<string> GetSelectFromRedValue()
        {
            var c = new ObservableCollection<string>();

            if (RedNumber == null)
            {
                return c;
            }
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
            return RedNumber == null ? "" : ((ulong)(CUInt64)RedNumber).ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var tb = (TextBox)e.Source;
            if (tb.SelectionLength == tb.Text.Length)
            {
                e.Handled = !ulong.TryParse(e.Text, out _);
            }
            else
            {
                e.Handled = !ulong.TryParse(tb.Text.Insert(tb.CaretIndex, e.Text), out _);
            }
        }
    }
}
