using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.Common;

namespace WolvenKit.Interfaces.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToLower(this string input)
        {
            return input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => input,
                _ => input.First().ToString().ToLower() + input[1..],
            };
        }

        public static string FirstCharToUpper(this string input) => input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => input,
            _ => input.First().ToString().ToUpper() + input[1..]
        };

        public static string CapitalizeEachWord(this string input) => input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => input,
            _ => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower()),
        };

        public static string GetHashMD5(this string input)
        {
            var encodedPassword = new UTF8Encoding().GetBytes(input);
            var hash = (CryptoConfig.CreateFromName("MD5") as HashAlgorithm)?.ComputeHash(encodedPassword);
            ArgumentNullException.ThrowIfNull(hash);
            var encoded = BitConverter.ToString(hash)
               .Replace("-", string.Empty)
               .ToLower();
            return encoded;
        }

        public static uint HashStringKey(this string key)
        {
            var keyConverted = key.ToCharArray();
            uint hash = 0;
            foreach (var c in keyConverted)
            {
                hash *= 31;
                hash += c;
            }
            return hash;
        }

        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString))
            {
                return target;
            }

            var result = target;
            while (result.StartsWith(trimString))
            {
                result = result[trimString.Length..];
            }

            return result;
        }

        public static bool IsNullOrEmptyOrEndsWith(this string? target, string value) =>
            string.IsNullOrEmpty(target) || target.EndsWith(value);

        public static bool IsEmptyOrEndsWith(this string target, string value) =>
            target == "" || target.EndsWith(value);
        
        
        /// <summary>
        /// Is the string a relative file path?
        /// </summary>
        public static bool IsFilePath(this string? target) => !string.IsNullOrEmpty(target) &&
                                                              target.Contains(Path.DirectorySeparatorChar) &&
                                                              target.Contains('.');

        /// <summary>
        /// Capitalizes each word in the string, replacing underscores with spaces
        /// </summary>
        public static string ToHumanFriendlyString(this string? target) =>
            string.IsNullOrEmpty(target) ? "" : target.Replace("_", " ").CapitalizeEachWord();
    }
}
