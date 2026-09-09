using System;
using System.IO;
using Newtonsoft.Json;
using WolvenKit.Core.Services;

namespace WolvenKit.App.Services;

/// <summary>
/// Represents the per-instance settings of the application resolved from the instance config file and executable arguments.
/// It is deliberately read-only.
/// </summary>
public class InstanceSettings : IInstanceSettings
{
    public string AppDataPath { get; set; } // can't private set because of deserialization

    public InstanceSettings()
    {
        AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");
    }

    /// <summary>
    /// Loads the instance settings from the instance config file and executable arguments.
    /// Values get prioritized in the following order: executable arguments, instance config file, default as defined in the constructor.
    /// </summary>
    /// <param name="instanceSettingsFile"></param>
    /// <param name="executableArguments"></param>
    /// <returns></returns>
    public void Load(string instanceSettingsFile, string[] executableArguments)
    {
        if (File.Exists(instanceSettingsFile))
        {
            InstanceSettings? fileInstance;
            try
            {
                fileInstance =
                    JsonConvert.DeserializeObject<InstanceSettings>(File.ReadAllText(instanceSettingsFile));
            }
            catch (Exception)
            {
                fileInstance = null;
            }

            if (fileInstance != null)
            {
                var appDataPath = CleanPath(fileInstance.AppDataPath);
                if (FilepathValidationTools.IsOsFilePathValid(appDataPath))
                {
                    AppDataPath = appDataPath;
                }
            }
        }

        for (var i = 0; i < executableArguments.Length; i++)
        {
            var trimmed = executableArguments[i].TrimStart("-").ToString();
            if (!trimmed.StartsWith("AppDataPath") || executableArguments.Length <= i + 1)
            {
                continue;
            }

            var path = CleanPath(executableArguments[i + 1]);
            if (FilepathValidationTools.IsOsFilePathValid(path))
            {
                AppDataPath = path;
            }
        }

        Directory.CreateDirectory(AppDataPath);
    }

    private static string CleanPath(string path) => path.Replace("/", Path.DirectorySeparatorChar.ToString())
        .Replace(@"\", Path.DirectorySeparatorChar.ToString())
        .Replace($"{Path.DirectorySeparatorChar}{Path.DirectorySeparatorChar}", Path.DirectorySeparatorChar.ToString());
}
