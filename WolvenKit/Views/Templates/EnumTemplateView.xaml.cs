using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;
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

        public IEnumAccessor RedEnum
        {
            get => (IEnumAccessor)GetValue(RedEnumProperty);
            set => SetValue(RedEnumProperty, value);
        }

        public static readonly DependencyProperty RedEnumProperty =
            DependencyProperty.Register(nameof(RedEnum), typeof(IEnumAccessor),
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
            if (e.NewValue is not IEnumAccessor ienum)
            {
                return;
            }

            view.BindingCollection.Clear();

            dynamic en = view.RedEnum;
            Type enumtype = en.Value.GetType();
            var vals = Enum.GetNames(enumtype);

            foreach (var s in vals)
            {
                view.BindingCollection.Add(s);
            }

            view.SelectedItem = ienum.REDValue;
        }

        

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RedEnum is not IEditableVariable cvar)
            {
                return;
            }

            if (cvar.REDValue != SelectedItem)
            {
                cvar.SetValue(new List<string>() { SelectedItem });
                cvar.IsSerialized = true;
            }
        }
    }
}
