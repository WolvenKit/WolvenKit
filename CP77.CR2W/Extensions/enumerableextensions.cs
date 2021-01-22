using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CP77.CR2W.Extensions
{
    // https://stackoverflow.com/a/3102439
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MatchesWildcard<T>(this IEnumerable<T> sequence, Func<T, string> expression, string pattern)
        {
            var regEx = WildcardToRegex(pattern);

            return sequence.Where(item => Regex.IsMatch(expression(item), regEx));
        }

        public static string WildcardToRegex(string pattern)
        {
            return "^" + Regex.Escape(pattern).
                Replace("\\*", ".*").
                Replace("\\?", ".") + "$";
        }
    }
}
