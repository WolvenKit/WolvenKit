using System;
using System.IO;
using Newtonsoft.Json;
using WolvenKit.Core.Services;

namespace WolvenKit.App.Models;

public class InstanceSettings
{
    public string AppDataPath { get; set; }

    private InstanceSettings()
    {
        AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");
    }

    public static InstanceSettings Load(string instanceSettingsFile, string[] executableArguments)
    {
        var instance = new InstanceSettings();

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
                    instance.AppDataPath = appDataPath;
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
                instance.AppDataPath = path;
            }
        }

        Directory.CreateDirectory(instance.AppDataPath);

        return instance;
    }

    private static string CleanPath(string path) => path.Replace("/", Path.DirectorySeparatorChar.ToString())
        .Replace(@"\", Path.DirectorySeparatorChar.ToString())
        .Replace($"{Path.DirectorySeparatorChar}{Path.DirectorySeparatorChar}", Path.DirectorySeparatorChar.ToString());
}
