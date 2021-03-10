using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Extensions.PropertyGridEditors;
using WolvenKit.Functionality.Converters;
using TextBox = System.Windows.Controls.TextBox;

namespace WolvenKit.Views.Others.PropertyGridEditors
{
    public class ExpandableObjectEditor : EditorBase<IEditableVariable>, IExpandableObjectEditor
    {
        #region Methods

        public string HeaderText
        {
            get => string.IsNullOrEmpty(Wrapper?.REDValue) ? "NOT SET" : Wrapper.REDValue;
            set => throw new NotImplementedException();
        }

        // creates a treeview
        public override FrameworkElement CreateElement(PropertyItem propertyItem)
        {
            var (tree, pg) = CreateCustomInnerElement();
            CreateInnerBinding(pg);

            

            BindingOperations.SetBinding(
                tree,
                Control.BackgroundProperty,
                new Binding($"{nameof(Wrapper)}.IsSerialized")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = new BoolToBrushConverter()
                });
            BindingOperations.SetBinding(
                pg,
                Control.BackgroundProperty,
                new Binding($"{nameof(Wrapper)}.IsSerialized")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = new BoolToBrushConverter()
                });

            return tree;
        }

        // bind the private dependency property to the UI element
        protected override void CreateInnerBinding(FrameworkElement element) =>
            BindingOperations.SetBinding(
                element,
                GetInnerDependencyProperty(),
                new Binding($"{nameof(Wrapper)}")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                });

        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem) => throw new System.NotImplementedException();

        private protected override DependencyProperty GetInnerDependencyProperty() => PropertyGrid.SelectedObjectProperty;

        private (FrameworkElement, FrameworkElement) CreateCustomInnerElement()
        {
            var tree = new TreeView();
            var treeviewitem = new TreeViewItem();
            var pg = new PropertyGrid()
            {
                PropertyResolver = new MyPropertyResolver()
            };
            treeviewitem.Items.Add(pg);

            //var grid = new Grid();
            var header = new TextBlock();
            BindingOperations.SetBinding(
                header,
                TextBlock.TextProperty,
                new Binding($"{nameof(HeaderText)}")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                });

            //grid.Children.Add(header);

            treeviewitem.Header = header;

            tree.Items.Add(treeviewitem);
            return (tree, pg);
        }

        #endregion Methods
    }
}
