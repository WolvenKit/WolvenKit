using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, bool appendTime = true)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            if (appendTime)
                box.AppendText("[" + DateTime.Now.ToString("G") + "]: " + text);
            else
                box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    public static class StringExtensions
    {
        public static string TrimStart(this string target, string trimString)
        {
            if (string.IsNullOrEmpty(trimString)) return target;

            string result = target;
            while (result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            return result;
        }


    }

    public static class FileSystemInfoExtensions
    {
        public static bool IsDirectory(this FileSystemInfo fsi)
        {
            return (fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }

        public static bool HasFilesOrFolders(this FileSystemInfo fsi)
        {
            if (!fsi.IsDirectory())
                return false;
            var di = fsi as DirectoryInfo;
            return (di.GetFiles().Any() || di.GetDirectories().Any());
        }

        public static DirectoryInfo GetParent(this FileSystemInfo fsi)
        {
            if (fsi.IsDirectory())
                return (fsi as DirectoryInfo).Parent;
            else
                return (fsi as FileInfo).Directory;
        }
    }
}
