// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Sample_NAudio
{
    public static class UIHelper
    {
        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp)
        {
            Bind(dataSource, sourcePath, destinationObject, dp, null, BindingMode.Default, null);
        }

        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, BindingMode bindingMode)
        {
            Bind(dataSource, sourcePath, destinationObject, dp, null, bindingMode, null);
        }

        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat)
        {
            Bind(dataSource, sourcePath, destinationObject, dp, stringFormat, BindingMode.Default, null);
        }

        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat, BindingMode bindingMode)
        {
            Bind(dataSource, sourcePath, destinationObject, dp, stringFormat, bindingMode, null);
        }

        public static void Bind(object dataSource, string sourcePath, FrameworkElement destinationObject, DependencyProperty dp, string stringFormat, BindingMode bindingMode, IValueConverter converter)
        {
            Binding binding = new Binding
            {
                Source = dataSource,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = bindingMode,
                Path = new PropertyPath(sourcePath),
                StringFormat = stringFormat,
                Converter = converter
            };
            destinationObject.SetBinding(dp, binding);
        }

        public static T FindParent<T>(this DependencyObject child) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);
            do
            {
                T matchedParent = parent as T;
                if (matchedParent != null)
                    return matchedParent;
                parent = VisualTreeHelper.GetParent(parent);
            }
            while (parent != null);

            return null;
        }
    }
}
