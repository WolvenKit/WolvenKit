using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WolvenKit
{
    public class NativeMethods
    {
        // offset of window style value
        public const int GWL_STYLE = -16;
        // window style constants for scrollbars
        public const int WS_VSCROLL = 0x00200000;
        public const int WS_HSCROLL = 0x00100000;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("shell32.dll")]
        public static extern int FindExecutable(string lpFile, string lpDirectory, [Out] StringBuilder lpResult);

        [DllImport("kernel32.dll", EntryPoint = "MoveFileW", SetLastError = true,
        CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]
        private static extern bool MoveFile(string lpExistingFileName, string lpNewFileName);
    }
}