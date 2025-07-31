using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for UIntAsBitfieldEditor.xaml
    /// </summary>
    public partial class UIntAsBitfieldEditor : UserControl
    {
        public ObservableCollection<string> SelectedItems { get; set; } = new();
        public ObservableCollection<string> BindingCollection { get; set; } = new();

        public Type EnumType
        {
            get => (Type)GetValue(EnumTypeProperty);
            set => SetValue(EnumTypeProperty, value);
        }
        public static readonly DependencyProperty EnumTypeProperty = DependencyProperty.Register(
            nameof(EnumType), typeof(Type), typeof(UIntAsBitfieldEditor));

        public IRedInteger RedInteger
        {
            get => (IRedInteger)GetValue(RedIntegerProperty);
            set => SetValue(RedIntegerProperty, value);
        }
        public static readonly DependencyProperty RedIntegerProperty = DependencyProperty.Register(
            nameof(RedInteger), typeof(IRedInteger), typeof(UIntAsBitfieldEditor), new PropertyMetadata(OnRedIntegerChanged));

        public UIntAsBitfieldEditor()
        {
            InitializeComponent();

            comboboxadv.SelectionChanged += (s, e) => SetValueFromString(string.Join(", ", comboboxadv.SelectedItems.Cast<string>()));
        }

        private static void OnRedIntegerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not UIntAsBitfieldEditor view)
            {
                return;
            }
            if (view.RedInteger == null)
            {
                return;
            }
            if (e.NewValue is not IRedInteger ri)
            {
                return;
            }
            if (view.EnumType is not Type enumType)
            {
                return;
            }

            if (e.OldValue == null)
            {
                view.BindingCollection.Clear();
                view.SelectedItems.Clear();
                var val = EnumHelper.RedIntToULong(ri);
                foreach (var ev in Enum.GetValues(enumType))
                {
                    var ev64 = Convert.ToUInt64(ev);
                    if (ev64 > 0)
                    {
                        view.BindingCollection.Add(Enum.GetName(enumType, ev));
                        if ((val & ev64) == ev64)
                        {
                            view.SelectedItems.Add(Enum.GetName(enumType, ev));
                        }
                    }                    
                }
            }
        }

        public void SetULongValue(ulong value)
        {
            switch (RedInteger)
            {
                case CUInt8:
                    SetCurrentValue(RedIntegerProperty, (CUInt8)value);
                    break;
                case CUInt16:
                    SetCurrentValue(RedIntegerProperty, (CUInt16)value);
                    break;
                case CUInt32:
                    SetCurrentValue(RedIntegerProperty, (CUInt32)value);
                    break;
                case CUInt64:
                    SetCurrentValue(RedIntegerProperty, (CUInt64)value);
                    break;
                default:
                    throw new NotImplementedException("Only unsigned integers are supported");
            }
        }

        private void SetValueFromString(string value)
        {
            if (EnumType == null || string.IsNullOrEmpty(value))
            {
                SetULongValue(0);
            }
            else
            {
                SetULongValue(Convert.ToUInt64(Enum.Parse(EnumType, value)));
            }
        }
    }
}