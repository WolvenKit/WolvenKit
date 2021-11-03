using System;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Data;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.Views.Editors
{
    public class IntegerEditor : ITypeEditor
    {
        RedIntegerEditor redintegerEditor;

        public void Attach(PropertyViewItem property, PropertyItem info)
        {
            if (info.CanWrite)
            {
                var binding = new Binding("Value")
                {
                    Mode = BindingMode.TwoWay,
                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true,
                };
                BindingOperations.SetBinding(redintegerEditor, RedIntegerEditor.RedIntegerProperty, binding);
            }
            else
            {
                redintegerEditor.SetCurrentValue(System.Windows.UIElement.IsEnabledProperty, false);
                var binding = new Binding("Value")
                {
                    Source = info,
                    ValidatesOnExceptions = true,
                    ValidatesOnDataErrors = true
                };
                BindingOperations.SetBinding(redintegerEditor, RedIntegerEditor.RedIntegerProperty, binding);
            }
        }
        public object Create(PropertyInfo propertyInfo)
        {
            redintegerEditor = new RedIntegerEditor()
            {
                Background = Brushes.Red
            };

            return redintegerEditor;
        }
        public void Detach(PropertyViewItem property)
        {

        }
    }
}
