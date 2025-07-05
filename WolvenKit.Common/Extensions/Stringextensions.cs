using System.Diagnostics.CodeAnalysis;
using System.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Gets the path relative from a base directory
        /// </summary>
        /// <param name="s">the string</param>
        /// <param name="relativeTo">folder the path should be relative to</param>
        /// <returns></returns>
        public static string RelativePath(this string s, DirectoryInfo relativeTo) => s[(relativeTo.FullName.Length + 1)..];

        /// <summary>
        /// Gets the path relative from a base directory
        /// </summary>
        /// <param name="s">the string</param>
        /// <param name="relativeTo">folder the path should be relative to</param>
        /// <returns></returns>
        public static string RelativePath(this string s, string relativeTo) => s[(relativeTo.Length + 1)..];

        public static string ToEscapedPath(this string s) => "\"" + s.TrimStart('\"').TrimEnd('\"') + "\"";
    }
}
