#nullable enable
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4;

public class DocumentTools
{
    private readonly ILoggerService _loggerService;
    private readonly IHashService _hashService;

    private static ILoggerService s_loggerServiceInstance = null!;
    private static IHashService s_hashServiceInstance = null!;

    public static Regex PlaceholderRegex { get; } = new Regex(@"^[-=_]+$");

    public DocumentTools(
        ILoggerService loggerService,
        IHashService hashService
    )
    {
        _loggerService = loggerService;
        s_loggerServiceInstance = loggerService;

        _hashService = hashService;
        s_hashServiceInstance = hashService;
    }

    public static bool SaveCr2W(CR2WFile cr2WFile, string? absolutePath)
    {
        if (string.IsNullOrEmpty(absolutePath))
        {
            s_loggerServiceInstance.Error("No file path provided!");
            return false;
        }

        var fileDirectory = Path.GetDirectoryName(absolutePath);
        if (fileDirectory is not null && !Directory.Exists(fileDirectory))
        {
            Directory.CreateDirectory(fileDirectory);
        }

        using (var ms = new MemoryStream())
        {
            try
            {
                using var writer = new CR2WWriter(ms, Encoding.UTF8, true) { LoggerService = s_loggerServiceInstance };
                writer.WriteFile(cr2WFile);
                if (!FileHelper.SafeWrite(ms, absolutePath, s_loggerServiceInstance))
                {
                    return false;
                }

                SaveHashedValues(cr2WFile);
            }
            catch (Exception e)
            {
                s_loggerServiceInstance.Error($"Error while saving {absolutePath}");
                s_loggerServiceInstance.Error(e);

                return false;
            }
        }

        s_loggerServiceInstance.Success($"Saved file {absolutePath}");
        return true;
    }

    private static void SaveHashedValues(CR2WFile file)
    {
        if (s_hashServiceInstance is not HashService hashService)
        {
            return;
        }

        foreach (var (_, value) in file.RootChunk.GetEnumerator())
        {
            switch (value)
            {
                case IRedRef redRef when redRef.DepotPath != ResourcePath.Empty &&
                                         redRef.DepotPath.TryGetResolvedText(out var refPath):
                    hashService.AddResourcePath(refPath);
                    break;
                case TweakDBID tweakDbId
                    when tweakDbId != TweakDBID.Empty && tweakDbId.TryGetResolvedText(out var tweakName):
                    hashService.AddTweakName(tweakName);
                    break;
            }
        }
    }
}