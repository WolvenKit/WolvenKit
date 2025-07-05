using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Converters;
public class IGameArchiveToMenuItemStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is IGameArchive archive)
        {
            if (!archive.Name.Contains('_'))
            {
                return archive.Name;
            }
            else
            {
                return archive.Name.Replace("_", "__");
            }
        }
        return null;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}
