using System;
using System.Globalization;
using System.Windows.Data;

namespace WolvenKit.Converters;

/// <summary>
/// Whether a group of a grouped list is open: values are "open anyway" (a bool, e.g. while searching), the group
/// (a <see cref="CollectionViewGroup"/>) and the selected item. Open when the first is true or the group holds the
/// selected item, so the selected row stays in view when the search is cleared.
/// </summary>
public class GroupOpenConverter : IMultiValueConverter
{
    public static GroupOpenConverter Instance { get; } = new();

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length > 0 && values[0] is true)
        {
            return true;
        }

        return values.Length > 2 && values[1] is CollectionViewGroup group && values[2] is { } selected &&
               group.Items.Contains(selected);
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}
