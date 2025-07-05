using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Core;

//https://stackoverflow.com/a/23623244
public static class NativeMethods
{
    [DllImport("kernel32.dll")]
    internal static extern IntPtr LoadLibrary(string dllToLoad);

    [DllImport("kernel32.dll")]
    internal static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

    [DllImport("kernel32.dll")]
    internal static extern bool FreeLibrary(IntPtr hModule);
}
