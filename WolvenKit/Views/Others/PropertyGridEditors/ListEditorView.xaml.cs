using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Catel.Linq;
using System.Linq;
using Catel.Collections;
using HandyControl.Controls;
using HandyControl.Tools.Extension;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Extensions.PropertyGridEditors;

namespace WolvenKit.Views.Others.PropertyGridEditors
{
    /// <summary>
    /// Interaction logic for ListEditor.xaml
    /// </summary>
    public partial class ListEditorView : UserControl
    {
        #region ctor

        public ListEditorView()
        {
            InitializeComponent();

            PropertyResolver = new MyPropertyResolver();
        }

        #endregion ctor

        #region properties

        public static readonly DependencyProperty ItemsSourceProperty
            = DependencyProperty.Register(
                nameof(ItemsSource),
                typeof(IEnumerable),
                typeof(ListEditorView),
                new FrameworkPropertyMetadata((IEnumerable)null, OnItemsSourceChanged));

        public PropertyResolver PropertyResolver { get; }



        public string HeaderText
        {
            get
            {
                var x = $"[{ItemSourceCount}]";
                return x;
            }
            set => throw new System.NotImplementedException();
        }

        private int ItemSourceCount => (ItemsSource is IList list) ?  list.Count : 0;

        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        #endregion properties

        #region methods

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ListEditorView uc)
            {
                uc.OnSetItemSourceChanged(e.OldValue, e.NewValue);
            }
        }

        private void GetEditor(IEnumerable enumerable)
        {
            // us the correct editor for the type
            switch (enumerable)
            {
                case IEnumerable<IREDPrimitive> intwrapper:
                    InitNumericEditor(intwrapper);
                    break;

                default:
                    InitDefaultEditor(enumerable);
                    break;
            }
        }

        private void InitDefaultEditor(IEnumerable enumerable)
        {
            var treeview = new TreeView();
            foreach (var obj in enumerable)
            {
                const string templateName = "PropertyGridEditor";
                var treeViewItem = new TreeViewItem
                {
                    Template = (ControlTemplate)this.FindResource(templateName),
                    DataContext = obj
                };

                treeview.Items.Add(treeViewItem);
            }

            ContentControl.SetCurrentValue(ContentProperty, treeview);
        }

        private void InitNumericEditor(IEnumerable enumerable)
        {
            ContentControl.SetCurrentValue(TemplateProperty, (ControlTemplate)this.FindResource("NumericEditor"));
            ContentControl.DataContext = enumerable;
        }

        private void OnSetItemSourceChanged(object oldValue, object newValue)
        {
            if (newValue is not IEnumerable enumerable)
            {
                return;
            }

            GetEditor(enumerable);
        }

        #endregion methods
    }
}
