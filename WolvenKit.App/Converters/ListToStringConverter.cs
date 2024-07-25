using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Wolvenkit.App.Converters;

public class ListToStringConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is List<string> list)
        {
            return string.Join(Environment.NewLine, list);
        }

        if (value is not Dictionary<string, List<string>> dict)
        {
            return string.Empty;
        }

        return dict
            .SelectMany(kv => new[] { $"{Environment.NewLine}{kv.Key}" }.Concat(kv.Value.Select(entry => $"      {entry}")))
            .Aggregate(new StringBuilder(), (sb, s) => sb.AppendLine(s))
            .ToString();
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        List<string> ret = [];
        if (value is not string str)
        {
            return ret;
        }

        ret = str.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

        // Check if it's a dictionary
        var dict = new Dictionary<string, List<string>>();
        string? currentKey = null;

        foreach (var line in ret)
        {
            if (!line.StartsWith("    ")) // This is a key
            {
                currentKey = line;
                if (!dict.ContainsKey(currentKey))
                {
                    dict.Add(currentKey, []);
                }
            }
            else if (currentKey != null) // This is a value
            {
                var valueToAdd = line.TrimStart(' ');
                dict[currentKey].Add(valueToAdd);
            }
        }


        return dict.Any(kv => kv.Value.Any()) ? dict : ret;
    }
}