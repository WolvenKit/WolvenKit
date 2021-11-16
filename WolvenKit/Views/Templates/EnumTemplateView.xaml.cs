using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.RED4.CR2W.Reflection;
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

            //dynamic en = view.RedEnum;
            //Type enumtype = en.Value.GetType();
            Type enumtype = null;
            if (AssemblyDictionary.EnumExists(view.RedEnum.REDType))
            {
                enumtype = AssemblyDictionary.GetEnumByName(view.RedEnum.REDType);
            }
            //else if (RED3.CR2W.Reflection.AssemblyDictionary.EnumExists(view.RedEnum.REDType))
            //{
            //    enumtype = RED3.CR2W.Reflection.AssemblyDictionary.GetEnumByName(view.RedEnum.REDType);
            //}
            if (enumtype == null)
            {
                return;
            }
            
            var vals = Enum.GetNames(enumtype);

            foreach (var s in vals)
            {
                view.BindingCollection.Add(s);
            }

            view.SelectedItem = ienum.REDValue;
        }

        

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RedEnum is not IRedType cvar)
            {
                return;
            }

            if (cvar.REDValue == SelectedItem)
            {
                return;
            }

            cvar.SetValue(new List<string>() { SelectedItem });
        }
    }
}
