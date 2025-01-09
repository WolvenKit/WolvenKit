using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
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
    private ILoggerService _loggerService;
    private Cr2WTools _cr2wTools;

    public static Regex PlaceholderRegex { get; } = new Regex(@"^[-=_]+$");

    public DocumentTools(ILoggerService loggerService, Cr2WTools cr2wTools)
    {
        _loggerService = loggerService;
        _cr2wTools = cr2wTools;
    }


    # region appfile

    public List<string> ConnectAppToEntFile(string absoluteAppFilePath, string absoluteEntFilePath,
        bool clearExistingEntries = false)
    {
        if (!File.Exists(absoluteAppFilePath))
        {
            _loggerService.Error("App file does not exist.");
            return [];
        }

        if (!File.Exists(absoluteEntFilePath))
        {
            _loggerService.Error("Ent file does not exist.");
            return [];
        }

        var appCr2W = _cr2wTools.ReadCr2W(absoluteAppFilePath);
        var entCr2W = _cr2wTools.ReadCr2W(absoluteEntFilePath);

        if (entCr2W.RootChunk is not entEntityTemplate ent)
        {
            _loggerService.Error($"invalid .ent file: {absoluteEntFilePath}!");
            return [];
        }

        if (appCr2W.RootChunk is not appearanceAppearanceResource app)
        {
            _loggerService.Error($"invalid .app file: {absoluteAppFilePath}!");
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

        _cr2wTools.WriteCr2W(entCr2W, absoluteEntFilePath);
        return appAppearanceNames;
    }


    public void SetFacialAnimations(string absoluteAppFilePath, PhotomodeBodyGender bodyGender)
    {
        var facialAnim = SelectAnimationPathViewModel.FacialAnimPathMale;
        if (bodyGender is PhotomodeBodyGender.Female)
        {
            facialAnim = SelectAnimationPathViewModel.FacialAnimPathFemale;
        }

        var selectedAnims = SelectAnimationPathViewModel.PhotomodeAnimEntriesFemaleDefault;

        SetFacialAnimations(absoluteAppFilePath, facialAnim, null, selectedAnims);
    }

    public void SetFacialAnimations(string absoluteAppFilePath, string? facialAnim, string? animGraph,
        List<string> selectedAnims)
    {
        if (string.IsNullOrEmpty(facialAnim) && string.IsNullOrEmpty(animGraph) && selectedAnims.Count == 0)
        {
            return;
        }

        if (!File.Exists(absoluteAppFilePath))
        {
            _loggerService.Error($".app file {absoluteAppFilePath} does not exist.");
            return;
        }

        var appCr2W = _cr2wTools.ReadCr2W(absoluteAppFilePath);

        if (appCr2W.RootChunk is not appearanceAppearanceResource app)
        {
            _loggerService.Error($"invalid .app file: {absoluteAppFilePath}!");
            return;
        }

        var facialAnimWritten = false;
        var facialGraphWritten = false;
        var animationsWritten = false;

        foreach (var appearance in app.Appearances
                     .Where(a => a.Chunk is not null))
        {
            foreach (var anim in appearance.Chunk!.Components.OfType<entAnimatedComponent>()
                         .Where(c => c.Name == "face_rig"))
            {
                if (!string.IsNullOrEmpty(facialAnim))
                {
                    anim.Graph = new CResourceReference<animAnimGraph>(facialAnim);
                    facialAnimWritten = true;
                }

                if (!string.IsNullOrEmpty(animGraph))
                {
                    anim.FacialSetup = new CResourceAsyncReference<animFacialSetup>(animGraph);
                    facialGraphWritten = true;
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

            animationsWritten = true;
        }

        if (!facialAnimWritten && !facialGraphWritten && !animationsWritten)
        {
            return;
        }

        if (facialAnimWritten)
        {
            _loggerService?.Success($"set facial animation to {facialAnim}");
        }

        if (facialGraphWritten)
        {
            _loggerService?.Success($"set animgraph to {animGraph}");
        }

        if (animationsWritten)
        {
            _loggerService?.Success($"Wrote {selectedAnims.Count} animations");
        }

        _cr2wTools.WriteCr2W(appCr2W, absoluteAppFilePath);
    }

    # endregion

}