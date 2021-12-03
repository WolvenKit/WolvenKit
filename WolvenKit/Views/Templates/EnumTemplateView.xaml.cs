using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;
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

        public string SelectedItem { get; set; }

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

            view.BindingCollection.Clear();

            var vals = Enum.GetNames(view.RedEnum.GetInnerType());

            foreach (var s in vals)
            {
                view.BindingCollection.Add(s);
            }

            view.SelectedItem = ienum.ToEnumString();

        }

        

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RedEnum.ToEnumString() == SelectedItem)
            {
                return;
            }

            RedEnum.SetValue(SelectedItem);
        }
    }
}
