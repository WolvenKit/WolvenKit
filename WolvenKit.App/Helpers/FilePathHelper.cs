using System;
using System.IO;

namespace WolvenKit.App.Helpers;

public abstract class FilePathHelper
{
    public static bool IsOneDrivePath(string path)
    {
        // There are more special cases, but this should work mostly
        if (path.StartsWith(@"\\?\") || path.StartsWith(@"\\.\"))
        {
            path = path[4..];
        }

        path = Path.GetFullPath(path);

        // %OneDrive% -> If only one of both versions is installed
        // %OneDriveConsumer% -> If both are installed, the path to the personal OneDrive
        // %OneDriveCommercial% -> If both are installed, the path to the commercial OneDrive
        return IsInEnv("OneDrive") || IsInEnv("OneDriveConsumer") || IsInEnv("OneDriveCommercial");

        bool IsInEnv(string envName) => Environment.GetEnvironmentVariable(envName) is { } str && path.StartsWith(str);
    }
}