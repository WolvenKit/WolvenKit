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
        if (IsWindows7OrLower())
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

    private static bool IsWindows7OrLower() => GetOSVersion() <= 6.1;
    public static bool IsWindows10OrHigher() => GetOSVersion() >= 10.0;

    public static double GetOSVersion()
    {
        var versionMajor = Environment.OSVersion.Version.Major;
        var versionMinor = Environment.OSVersion.Version.Minor;
        var version = versionMajor + ((double)versionMinor / 10);
        return version;
    }

    public static bool PowershellExists()
    {
        var regval = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PowerShell\1", "Install", null);
        var s = regval?.ToString();
        if (s is null)
        {
            return false;
        }

        if (s.Equals("1"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
