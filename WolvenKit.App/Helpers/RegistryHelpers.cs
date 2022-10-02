using System.IO;
using System.Linq;
using Microsoft.Win32;
using System.Threading.Tasks;
using static Microsoft.Win32.Registry;
using System;

namespace WolvenKit.App.Helpers;

public static class RegistryHelpers
{
    public static string GetFileNamePathFromRegistrySubKey(
        string subKeyPath,
        string appName,
        string fileName)
    {
        var subKey = LocalMachine.OpenSubKey(subKeyPath);
        var programName = (string)subKey?.GetValue("DisplayName");
        var installLocation = (string)subKey?.GetValue("InstallLocation");

        if (programName?.Contains(appName) ?? false)
        {
            if (Directory.Exists(installLocation))
            {
                var files = Directory
                    .GetFiles(
                        installLocation,
                        fileName,
                        SearchOption.AllDirectories);

                return files?.FirstOrDefault();
            }
        }

        return string.Empty;
    }
}
