using System.IO;

namespace WolvenKit.Common.Extensions
{
    public static class StringExtensions
    {
        public static string RelativePath(this string s, DirectoryInfo infolder) => s[(infolder.FullName.Length + 1)..];

        public static string ToEscapedPath(this string s) => "\"" + s.TrimStart('\"').TrimEnd('\"') + "\"";
    }
}
