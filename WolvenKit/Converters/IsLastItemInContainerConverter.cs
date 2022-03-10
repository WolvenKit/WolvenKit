using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WolvenKit.Converters
{
    // https://stackoverflow.com/a/12131197/1530201
    public class IsLastItemInContainerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            DependencyObject item = (DependencyObject)value;
            ItemsControl ic = ItemsControl.ItemsControlFromItemContainer(item);

            if (ic == null)
                return false;

            return ic.ItemContainerGenerator.IndexFromContainer(item)
                    == ic.Items.Count - 1;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
