using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace WolvenKit.Common.Extensions
{
    // https://stackoverflow.com/a/3102439
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MatchesWildcard<T>(this IEnumerable<T> sequence, Func<T, string> expression, string pattern)
        {
            var regEx = WildcardToRegex(pattern);

            return sequence.Where(item => Regex.IsMatch(expression(item), regEx));
        }

        public static string WildcardToRegex(string pattern) =>
            "^" + Regex.Escape(pattern).
                Replace("\\*", ".*").
                Replace("\\?", ".") + "$";


        public static EMlmaskUncookExtension ToMlmaskUncookExtension(this EUncookExtension uncookExtension) => uncookExtension switch
        {
            EUncookExtension.dds => EMlmaskUncookExtension.dds,
            EUncookExtension.png => EMlmaskUncookExtension.png,
            // default to png
            EUncookExtension.tga => EMlmaskUncookExtension.png,
            EUncookExtension.bmp => EMlmaskUncookExtension.png,
            EUncookExtension.jpg => EMlmaskUncookExtension.png,
            EUncookExtension.tiff => EMlmaskUncookExtension.png,
            _ => throw new ArgumentOutOfRangeException(nameof(uncookExtension), uncookExtension, null),
        };
    }
}
