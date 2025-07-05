using System;
using System.Globalization;
using System.Windows.Data;
using WolvenKit.RED4.Types;

namespace WolvenKit.Converters;

public class TweakDBIDConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is TweakDBID tweakDbId)
        {
            if (tweakDbId.ResolvedText != null)
            {
                return tweakDbId.ResolvedText;
            }

            var crc = (uint)(tweakDbId & 0xFFFFFFFF);
            var length = (uint)(tweakDbId >> 32);

            return $"<TDBID:{crc:X8}:{length:X2}>";
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}
