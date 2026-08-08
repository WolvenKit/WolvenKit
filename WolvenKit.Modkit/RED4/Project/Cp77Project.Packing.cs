using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.RED4.Project;

public sealed partial class Cp77Project
{
    private static bool IsSpecialExtension(string fileName)
    {
        return Path.GetExtension(fileName) switch
        {
            ".xl" or ".script" or ".ws" or ".tweak" => true,
            _ => false,
        };
    }

    private static bool IsCDPRScriptFile(string fileName)
    {
        return Path.GetExtension(fileName) switch
        {
            ".script" or ".ws" => true,
            _ => false,
        };
    }

    private List<string> GetArchiveXlFiles() =>
        Directory.EnumerateFiles(ResourcesDirectory, "*.xl", SearchOption.AllDirectories).ToList();

    private List<string> GetResourceFiles() => Directory
        .EnumerateFiles(ResourcesDirectory, "*.*", SearchOption.AllDirectories)
        .Where(name => !IsSpecialExtension(name))
        .Where(x => Path.GetFileName(x) != "info.json").ToList();

    private List<string> GetREDmodScriptFiles()
    {
        var absolutePath = Path.Combine(ResourcesDirectory, "scripts");
        if (!Directory.Exists(absolutePath))
        {
            return [];
        }

        return Directory
            .EnumerateFiles(absolutePath, "*.*", SearchOption.AllDirectories)
            .Where(IsCDPRScriptFile).ToList();
    }

    private List<string> GetREDmodTweakFiles()
    {
        var absolutePath = Path.Combine(ResourcesDirectory, "tweaks");
        if (!Directory.Exists(absolutePath))
        {
            return [];
        }

        return Directory.EnumerateFiles(absolutePath, "*.tweak", SearchOption.AllDirectories).ToList();
    }

    public bool PackProject(IModTools modTools, ILoggerService loggerService, bool isRedmod)
    {
        var archives = Directory.EnumerateFiles(ModDirectory, "*", SearchOption.AllDirectories).ToList();
        if (archives.Count != 0)
        {
            var invalidFiles = archives
                .Select(f => Path.GetRelativePath(ModDirectory, f))
                .Where(f => f.Any(char.IsUpper) || f.Any(char.IsWhiteSpace)).ToList();
            if (invalidFiles.Count != 0)
            {
                loggerService.Warning("Capital letters and/or whitespaces found (this may cause issues):");
                foreach (var filePath in invalidFiles)
                {
                    loggerService.Warning($"\t {filePath}");
                }
            }

            if (!PackArchives(modTools, isRedmod))
            {
                loggerService.Error("Packing archives failed, aborting.");
                return false;
            }

            loggerService.Info($"{Name} archives packed into {GetPackedArchiveDirectory(isRedmod)}");
        }

        var files = GetArchiveXlFiles();
        if (files.Count != 0)
        {
            if (!PackArchiveXlFiles(files, isRedmod))
            {
                loggerService.Error("Packing archiveXL files failed, aborting.");
                return false;
            }

            loggerService.Info($"{Name} archiveXL files packed into {GetPackedArchiveDirectory(isRedmod)}");
        }

        files = GetResourceFiles();
        if (files.Count != 0)
        {
            if (!PackResources(files))
            {
                loggerService.Error("Packing other resource files failed, aborting.");
                return false;
            }

            loggerService.Info($"{Name} resource files packed into {PackedRootDirectory}");
        }

        if (!isRedmod)
        {
            return true;
        }

        if (!PackRedmodFiles(loggerService))
        {
            loggerService.Error("Packing redmod files failed, aborting.");
            return false;
        }

        loggerService.Info($"{Name} redmod files packed into {PackedRedModDirectory}");
        return true;
    }

    private bool PackArchives(IModTools modTools, bool isRedmod) =>
        modTools.Pack(new DirectoryInfo(ModDirectory), new DirectoryInfo(GetPackedArchiveDirectory(isRedmod)), ModName);

    private bool PackResources(IEnumerable<string> files)
    {
        foreach (var file in files)
        {
            var fileName = Path.GetFileName(file);
            var fileRelativeDir = Path.GetRelativePath(ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
            var fileOutputDir = Path.Combine(PackedRootDirectory, fileRelativeDir);
            var fileOutputPath = Path.Combine(fileOutputDir, fileName);
            if (!Directory.Exists(fileOutputDir))
            {
                Directory.CreateDirectory(fileOutputDir);
            }

            File.Copy(file, fileOutputPath, true);
        }
        return true;
    }

    private bool PackArchiveXlFiles(IEnumerable<string> archiveXlFiles, bool isRedmod)
    {
        foreach (var f in archiveXlFiles)
        {
            var outDirectory = GetPackedArchiveDirectory(isRedmod);
            if (!Directory.Exists(outDirectory))
            {
                Directory.CreateDirectory(outDirectory);
            }
            var filename = Path.GetFileName(f);
            var outPath = Path.Combine(outDirectory, filename);
            File.Copy(f, outPath, true);
        }
        return true;
    }

    private bool PackRedmodFiles(ILoggerService loggerService)
    {
        var modinfo = Path.Combine(PackedRedModDirectory, "info.json");

        if (File.Exists(modinfo))
        {
            File.Delete(modinfo);
        }

        if (!File.Exists(modinfo))
        {
            JsonSerializerOptions jsonoptions = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var jsonString = JsonSerializer.Serialize(GetInfo(), jsonoptions);
            File.WriteAllText(modinfo, jsonString);
        }

        if (PackSoundFiles(loggerService))
        {
            loggerService.Info($"{Name} redmod sound files packed into {PackedRedModDirectory}");
        }

        var files = GetREDmodTweakFiles();
        if (files.Count != 0)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var fileRelativeDir = Path.GetRelativePath(ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
                var fileOutputDir = Path.Combine(PackedRedModDirectory, fileRelativeDir);
                var fileOutputPath = Path.Combine(fileOutputDir, fileName);
                if (!Directory.Exists(fileOutputDir))
                {
                    Directory.CreateDirectory(fileOutputDir);
                }

                File.Copy(file, fileOutputPath, true);
            }
            loggerService.Info($"{Name} redmod tweak files packed into {PackedRedModDirectory}");
        }

        files = GetREDmodScriptFiles();
        if (files.Count != 0)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var fileRelativeDir = Path.GetRelativePath(ResourcesDirectory, Path.GetDirectoryName(file).NotNull());
                var fileOutputDir = Path.Combine(PackedRedModDirectory, fileRelativeDir);
                var fileOutputPath = Path.Combine(fileOutputDir, fileName);
                if (!Directory.Exists(fileOutputDir))
                {
                    Directory.CreateDirectory(fileOutputDir);
                }

                File.Copy(file, fileOutputPath, true);
            }
        }

        loggerService.Info($"{Name} redmod script files packed into {PackedRedModDirectory}");

        return true;
    }

    private bool PackSoundFiles(ILoggerService loggerService)
    {
        var path = Path.Combine(PackedRedModDirectory, "info.json");
        if (!File.Exists(path))
        {
            return false;
        }

        List<string> files = new();
        try
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreReadOnlyProperties = true,
            };
            var info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path), options).NotNull();
            if (info.CustomSounds.Count == 0)
            {
                return false;
            }

            foreach (var e in info.CustomSounds)
            {
                if (!string.IsNullOrEmpty(e.File))
                {
                    files.Add(e.File);

                    var rawFile = Path.Combine(SoundDirectory, e.File);
                    var packedFile = Path.Combine(PackedSoundsDirectory, e.File);
                    if (File.Exists(rawFile))
                    {
                        File.Copy(rawFile, packedFile, true);
                    }
                }
            }
        }
        catch (Exception e)
        {
            loggerService.Error(e);
            return false;
        }

        return true;
    }

    public bool CleanPackedDirectory(ILoggerService loggerService)
    {
        try
        {
            if (Directory.Exists(PackedRootDirectory))
            {
                Directory.Delete(PackedRootDirectory, true);
            }
            return true;
        }
        catch (Exception e)
        {
            loggerService.Error(e);
            return false;
        }
    }

    public bool CreateZip(ILoggerService loggerService, bool isBackup)
    {
        var zipPathRoot = new DirectoryInfo(PackedRootDirectory).Parent?.FullName;
        if (zipPathRoot is null)
        {
            return false;
        }

        var suffix = isBackup ? "_previousBuild" : "";
        var zipPath = Path.Combine(zipPathRoot, $"{Name}{suffix}.zip");
        try
        {
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }
            ZipFile.CreateFromDirectory(PackedRootDirectory, zipPath);
        }
        catch (Exception e)
        {
            loggerService.Error(e);
            return false;
        }
        loggerService.Info($"{Name} zip available at {zipPath}");
        return true;
    }
}
