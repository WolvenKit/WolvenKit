using System;
using System.IO;

namespace WolvenKit.UnitTests;

/// <summary>
/// Provides the Cyberpunk 2077 game directory strictly from the CP77_DIR environment variable.
/// No appsettings.json fallback is used.
/// </summary>
public static class GameDirectoryHelper
{
    private static string? _gameDirectory;

    public static string GameDirectory
    {
        get
        {
            if (_gameDirectory is not null)
                return _gameDirectory;

            // Check User scope first (how existing Functional/Utility tests do it)
            var dir = Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);

            if (string.IsNullOrWhiteSpace(dir))
            {
                // Fallback to process-level (useful when running from certain CI or scripts)
                dir = Environment.GetEnvironmentVariable("CP77_DIR");
            }

            if (string.IsNullOrWhiteSpace(dir))
            {
                throw new DirectoryNotFoundException(
                    "CP77_DIR environment variable is not set. " +
                    "Please set it to your Cyberpunk 2077 installation directory (User scope recommended).");
            }

            if (!Directory.Exists(dir))
            {
                throw new DirectoryNotFoundException(
                    $"CP77_DIR points to a directory that does not exist: {dir}");
            }

            _gameDirectory = dir;
            return _gameDirectory;
        }
    }
}
