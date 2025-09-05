using System;
using System.Collections.ObjectModel;
using System.Windows;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for UIntAsEnumEditor.xaml
    /// </summary>
    public partial class DisplayAsEnumEditor : UserControl
    {
        public ObservableCollection<string> BindingCollection { get; set; } = new();

        public string SelectedItem
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        public Type EnumType
        {
            get => (Type)GetValue(EnumTypeProperty);
            set => SetValue(EnumTypeProperty, value);
        }
        public static readonly DependencyProperty EnumTypeProperty = DependencyProperty.Register(
            nameof(EnumType), typeof(Type), typeof(DisplayAsEnumEditor));

        public IRedInteger RedInteger
        {
            get => (IRedInteger)GetValue(RedIntegerProperty);
            set => SetValue(RedIntegerProperty, value);
        }
        public static readonly DependencyProperty RedIntegerProperty = DependencyProperty.Register(
            nameof(RedInteger), typeof(IRedInteger), typeof(DisplayAsEnumEditor), new PropertyMetadata(OnRedIntegerChanged));
        

        public DisplayAsEnumEditor()
        {
            InitializeComponent();
        }

        private static void OnRedIntegerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not DisplayAsEnumEditor view)
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
                foreach (var ev in Enum.GetValues(enumType))
                {
                    view.BindingCollection.Add(Enum.GetName(enumType, ev));
                }
            }
        }

        private string GetValueFromRedValue() => EnumHelper.RedIntToEnumString(EnumType, RedInteger);

        private void SetRedValue(string value) => SetCurrentValue(RedIntegerProperty, EnumHelper.EnumStringToRedInt(EnumType, value, RedInteger));
    }
}
