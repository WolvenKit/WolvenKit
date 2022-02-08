using System;
using System.Collections.ObjectModel;
using System.Windows;
using WolvenKit.RED4.Types;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for EnumTemplateView.xaml
    /// </summary>
    public partial class EnumTemplateView : UserControl
    {
        public EnumTemplateView()
        {
            InitializeComponent();
        }

        public string SelectedItem
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        public ObservableCollection<string> BindingCollection { get; set; } = new();

        public IRedEnum RedEnum
        {
            get => (IRedEnum)GetValue(RedEnumProperty);
            set => SetValue(RedEnumProperty, value);
        }

        public static readonly DependencyProperty RedEnumProperty =
            DependencyProperty.Register(nameof(RedEnum), typeof(IRedEnum),
                typeof(EnumTemplateView), new PropertyMetadata(OnRedEnumChanged));


        private static void OnRedEnumChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not EnumTemplateView view)
            {
                return;
            }
            if (view.RedEnum == null)
            {
                return;
            }
            if (e.NewValue is not IRedEnum ienum)
            {
                return;
            }

            if (e.OldValue == null)
            {
                view.BindingCollection.Clear();
                foreach (var s in Enum.GetNames(ienum.GetInnerType()))
                {
                    view.BindingCollection.Add(s);
                }
                //view.SelectedItem = ienum.ToEnumString();
            }
        }

        private void SetRedValue(string value) => SetCurrentValue(RedEnumProperty, CEnum.Parse(RedEnum.GetInnerType(), value));

        private string GetValueFromRedValue() => RedEnum.ToEnumString();
    }
}
