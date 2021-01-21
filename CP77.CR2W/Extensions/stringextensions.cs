using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CP77.CR2W.Extensions
{
    public static class StringExtensions
    {
        public static string RelativePath(this string s, DirectoryInfo infolder) => s[(infolder.FullName.Length + 1)..];
    }
}
