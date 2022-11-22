using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WolvenKit.App.Helpers;

/// <summary>
/// https://github.com/qmatteoq/DesktopBridgeHelpers
/// </summary>
public class DesktopBridgeHelper
{
    private const long APPMODEL_ERROR_NO_PACKAGE = 15700L;

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern int GetCurrentPackageFullName(ref int packageFullNameLength, StringBuilder packageFullName);

    public static bool IsRunningAsPackage()
    {
        if (_isWindows7OrLower)
        {
            return false;
        }
        else
        {
            var length = 0;
            var sb = new StringBuilder(0);
            var result = GetCurrentPackageFullName(ref length, sb);

            sb = new StringBuilder(length);
            result = GetCurrentPackageFullName(ref length, sb);

            return result != APPMODEL_ERROR_NO_PACKAGE;
        }
    }

    public static bool IsWindows7OrLower() => _isWindows7OrLower;
    private static bool _isWindows7OrLower
    {
        get
        {
            var versionMajor = Environment.OSVersion.Version.Major;
            var versionMinor = Environment.OSVersion.Version.Minor;
            var version = versionMajor + ((double)versionMinor / 10);
            return version <= 6.1;
        }
    }

    public static bool PowershellExists()
    {
        var regval = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PowerShell\1", "Install", null).ToString();
        if (regval.Equals("1"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
