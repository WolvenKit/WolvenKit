using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.MVVM.Views.PropertyGridEditors
{
    [ValueConversion(typeof(bool), typeof(SolidColorBrush))]
    public class BoolToBrushConverter : IValueConverter
    {
        public object
            Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Setting default values
            SolidColorBrush color;
            var colorIfTrue = Colors.DarkOliveGreen;
            var colorIfFalse = Colors.Red;

            // Creating Color Brush
            if ((bool)value)
            {
                color = new SolidColorBrush(colorIfTrue);
            }
            else
            {
                color = new SolidColorBrush(colorIfFalse);
            }
            return color;
        }

        // needs to be double to be able to convert from the Numeric Converter
        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture) =>
            throw new NotImplementedException();
    }


    public class ExpandableObjectEditor : EditorBase<IEditableVariable>, IExpandableObjectEditor
    {
        private protected override DependencyProperty GetInnerDependencyProperty() => PropertyGrid.SelectedObjectProperty;
        private protected override FrameworkElement CreateInnerElement(PropertyItem propertyItem)
        {
            throw new System.NotImplementedException();
        }

        // creates a treeview
        public override FrameworkElement CreateElement(PropertyItem propertyItem)
        {
            var (tree, pg) = CreateCustomInnerElement(propertyItem);
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

        private (FrameworkElement, FrameworkElement) CreateCustomInnerElement(PropertyItem propertyItem)
        {
            var tree = new TreeView();
            var treeviewitem = new TreeViewItem();
            var pg = new PropertyGrid()
            {
                PropertyResolver = new MyPropertyResolver()
            };
            treeviewitem.Items.Add(
                pg);
            tree.Items.Add(treeviewitem);
            return (tree, pg);
        }

        // bind the private dependency property to the UI element
        public override void CreateInnerBinding(DependencyObject element)
        {
            BindingOperations.SetBinding(
                element,
                GetInnerDependencyProperty(),
                new Binding($"{nameof(Wrapper)}")
                {
                    Source = this,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                });
        }




    }
}
