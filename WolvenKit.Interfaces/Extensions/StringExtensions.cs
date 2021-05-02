using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToLower(this string input)
        {
            switch (input)
            {
                case null:
                    throw new ArgumentNullException(nameof(input));
                case "":
                    throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default:
                    return input.First().ToString().ToLower() + input.Substring(1);
            }
        }

        public static string FirstCharToUpper(this string input)
        {
            return input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input.First().ToString().ToUpper() + input.Substring(1)
            };
        }
    }
}
