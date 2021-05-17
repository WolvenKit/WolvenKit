using System.IO;

namespace WolvenKit.Common.Extensions
{
    public static class StringExtensions
    {
        #region Methods

        public static string RelativePath(this string s, DirectoryInfo infolder) => s[(infolder.FullName.Length + 1)..];

        #endregion Methods
    }
}
