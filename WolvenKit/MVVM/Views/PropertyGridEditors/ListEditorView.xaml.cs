using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
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

        #endregion

        public PropertyResolver PropertyResolver { get; }


        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty
            = DependencyProperty.Register(
                nameof(ItemsSource),
                typeof(IEnumerable),
                typeof(ListEditorView),
                new FrameworkPropertyMetadata((IEnumerable)null, OnItemsSourceChanged));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ListEditorView uc)
            {
                uc.OnSetItemSourceChanged(e.OldValue, e.NewValue);
            }
        }

        private void OnSetItemSourceChanged(object oldValue, object newValue)
        {
            if (newValue is not IEnumerable enumerable)
            {
                return;
            }

            GetEditor(enumerable);
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

        private void InitNumericEditor(IEnumerable enumerable)
        {
            ContentControl.SetCurrentValue(TemplateProperty, (ControlTemplate)this.FindResource("NumericEditor"));
            ContentControl.DataContext = enumerable;
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



    }
}
