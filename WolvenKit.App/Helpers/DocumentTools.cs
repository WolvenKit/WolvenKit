using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.App.Services;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using InvalidDataException = System.IO.InvalidDataException;

namespace WolvenKit.App.Helpers;

public class DocumentTools
{

    private static ILoggerService s_loggerServiceInstance = null!;
    private static IHashService s_hashServiceInstance = null!;
    private static Red4ParserService s_parserServiceInstance = null!;

    public static Regex PlaceholderRegex { get; } = new Regex(@"^[-=_]+$");

    public DocumentTools(
        ILoggerService loggerService,
        IHashService hashService,
        Red4ParserService parserService
    )
    {
        s_loggerServiceInstance = loggerService;
        s_hashServiceInstance = hashService;
        s_parserServiceInstance = parserService;
    }

    #region cr2w

    public static bool WriteCr2W(CR2WFile cr2WFile, string? absolutePath)
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

    public static CR2WFile ReadCr2W(string absolutePath)
    {
        if (!File.Exists(absolutePath))
        {
            throw new InvalidDataException($"File does not exist: {absolutePath}");
        }

        using var fs = new FileStream(absolutePath, FileMode.Open);

        if (!s_parserServiceInstance.TryReadRed4File(fs, out var cr2WFile))
        {
            throw new InvalidFileTypeException($"Can't read file: {absolutePath}");
        }

        return cr2WFile;
    }

    #endregion


    private static void SaveHashedValues(CR2WFile file)
    {
        if (s_hashServiceInstance is not HashServiceExt hashService)
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
                default:
                    break;
            }
        }
    }


    # region appfile

    public static List<string> ConnectAppToEntFile(string absoluteAppFilePath, string absoluteEntFilePath,
        bool clearExistingEntries = false)
    {
        if (!File.Exists(absoluteAppFilePath))
        {
            s_loggerServiceInstance.Error("App file does not exist.");
            return [];
        }

        if (!File.Exists(absoluteEntFilePath))
        {
            s_loggerServiceInstance.Error("Ent file does not exist.");
            return [];
        }

        var appCr2W = ReadCr2W(absoluteAppFilePath);
        var entCr2W = ReadCr2W(absoluteEntFilePath);

        if (entCr2W.RootChunk is not entEntityTemplate ent)
        {
            s_loggerServiceInstance.Error($"invalid .ent file: {absoluteEntFilePath}!");
            return [];
        }

        if (appCr2W.RootChunk is not appearanceAppearanceResource app)
        {
            s_loggerServiceInstance.Error($"invalid .app file: {absoluteAppFilePath}!");
            return [];
        }

        var appAppearanceNames = app.Appearances.Select(a => a.Chunk?.Name.GetResolvedText())
            .Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s!)
            .Where(s => !PlaceholderRegex.IsMatch(s))
            .ToList();

        if (clearExistingEntries)
        {
            ent.Appearances.Clear();
        }

        var entAppearanceNames = ent.Appearances.Select(a => a.AppearanceName.GetResolvedText())
            .Where(s => !string.IsNullOrEmpty(s))
            .Select(s => s!)
            .ToList();

        var missingAppearances = appAppearanceNames.Except(entAppearanceNames).ToList();
        if (missingAppearances.Count == 0)
        {
            return appAppearanceNames;
        }

        var appearancePrefix = ent.Appearances
            .Where(eA => appAppearanceNames.Contains(eA.AppearanceName.GetResolvedText() ?? ""))
            .Select(eA =>
                (eA.Name.GetResolvedText() ?? "").Replace(eA.AppearanceName.GetResolvedText() ?? "", ""))
            .FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? "";

        var relativeAppFilePath = absoluteAppFilePath.Split("archive")[^1];

        foreach (var appName in appAppearanceNames.Except(entAppearanceNames))
        {
            var newAppearance = new entTemplateAppearance()
            {
                AppearanceName = appName,
                Name = $"{appearancePrefix}{appName}",
                AppearanceResource = new CResourceAsyncReference<appearanceAppearanceResource>(relativeAppFilePath)
            };
            ent.Appearances.Add(newAppearance);
        }

        if (!entAppearanceNames.Contains(ent.DefaultAppearance.GetResolvedText() ?? ""))
        {
            ent.DefaultAppearance = ent.Appearances.LastOrDefault()?.Name.GetResolvedText() ?? "";
        }

        WriteCr2W(entCr2W, absoluteEntFilePath);
        return appAppearanceNames;
    }

    public static void SetFacialAnimations(string absoluteAppFilePath, string? facialAnim, string? animGraph,
        List<string> selectedAnims)
    {
        if (string.IsNullOrEmpty(facialAnim) && string.IsNullOrEmpty(animGraph) && selectedAnims.Count == 0)
        {
            return;
        }

        if (!File.Exists(absoluteAppFilePath))
        {
            s_loggerServiceInstance.Error($".app file {absoluteAppFilePath} does not exist.");
            return;
        }

        var appCr2W = ReadCr2W(absoluteAppFilePath);

        if (appCr2W.RootChunk is not appearanceAppearanceResource app)
        {
            s_loggerServiceInstance.Error($"invalid .app file: {absoluteAppFilePath}!");
            return;
        }

        foreach (var appearance in app.Appearances.Where(a => a.Chunk is not null))
        {
            foreach (var anim in appearance.Chunk!.Components.OfType<entAnimatedComponent>())
            {
                if (!string.IsNullOrEmpty(facialAnim))
                {
                    anim.Graph = new CResourceReference<animAnimGraph>(facialAnim);
                }

                if (!string.IsNullOrEmpty(animGraph))
                {
                    anim.FacialSetup = new CResourceAsyncReference<animFacialSetup>(animGraph);
                }
            }

            if (selectedAnims.Count == 0)
            {
                continue;
            }

            foreach (var setup in appearance.Chunk!.Components.OfType<entAnimationSetupExtensionComponent>())
            {
                setup.Animations.Gameplay.Clear();
                foreach (var selectedAnim in selectedAnims)
                {
                    setup.Animations.Gameplay.Add(new animAnimSetupEntry()
                    {
                        Priority = 200,
                        AnimSet = new CResourceAsyncReference<animAnimSet>(selectedAnim),
                        VariableNames = []
                    });
                }
            }
        }

        WriteCr2W(appCr2W, absoluteAppFilePath);
    }

    # endregion
}