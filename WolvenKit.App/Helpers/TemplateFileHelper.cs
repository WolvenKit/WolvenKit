using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using PhotoModePlayerEntityComponent = WolvenKit.RED4.Types.PhotoModePlayerEntityComponent;

namespace WolvenKit.App.Helpers;

public static class TemplateFileHelper
{
    public static string? CopyInkatlasTemplateSingle(Cp77Project activeProject,
        string inkatlasAbsolutePath, bool forceOverwrite)
    {
        var inkatlasTemplatePath = Path.Combine(AppContext.BaseDirectory, "Resources", "TemplateFiles", "inkatlas",
            "single_item_template.inkatlas");

        var targetFolderAbsolutePath = Path.GetDirectoryName(inkatlasAbsolutePath);

        if (targetFolderAbsolutePath is not null && !Directory.Exists(targetFolderAbsolutePath))
        {
            Directory.CreateDirectory(targetFolderAbsolutePath);
        }

        if (File.Exists(inkatlasAbsolutePath) && !forceOverwrite && !Interactions.ShowQuestionYesNo((
                $"File {inkatlasAbsolutePath} already exists. Overwrite it?", "Overwrite file?")))
        {
            return null;
        }

        File.Copy(inkatlasTemplatePath, inkatlasAbsolutePath, overwrite: true);

        var inkatlasFileName = Path.GetFileNameWithoutExtension(inkatlasAbsolutePath);
        
        // Copy the xbm file
        var xbmDestAbsPath = Path.Join(targetFolderAbsolutePath, $"{inkatlasFileName}.xbm");
        if (!File.Exists(xbmDestAbsPath))
        {
            var xbmTemplatePath = inkatlasTemplatePath.Replace(".inkatlas", ".xbm");
            File.Copy(xbmTemplatePath, xbmDestAbsPath);

        }

        var relativeXbmPath = activeProject.GetRelativePath(xbmDestAbsPath);

        ProjectResourceHelper.ReplacePathInFile(activeProject, inkatlasAbsolutePath, "your_depot_path_here.xbm",
            relativeXbmPath);

        return inkatlasAbsolutePath;
    }


    public static void CreatePhotomodeYaml(PhotomodeYamlOptions options)
    {
        if (string.IsNullOrEmpty(options.NpcName))
        {
            throw new Exception("NPC name is empty, this won't work");
        }

        var fileName = options.NpcName.ToFileName();

        if (File.Exists(options.YamlFileAbsolutePath) && !options.Overwrite)
        {
            return;
        }

        var yamlFolder = Path.GetDirectoryName(options.YamlFileAbsolutePath);
        if (yamlFolder is not null && !Directory.Exists(yamlFolder))
        {
            Directory.CreateDirectory(yamlFolder);
        }

        var yamlTemplatePath = Path.Combine(AppContext.BaseDirectory, "Resources", "TemplateFiles", "yaml",
            "photomode_npc_template.yaml");

        if (!File.Exists(yamlTemplatePath))
        {
            throw new Exception("Yaml file not found in resources");
        }


        File.Copy(yamlTemplatePath, options.YamlFileAbsolutePath, true);

        var yamlTemplate = File.ReadAllText(options.YamlFileAbsolutePath);

        yamlTemplate = yamlTemplate.Replace("DISPLAY_NAME",
            $"LocKey#{options.ModderName.ToFileName()}_{fileName}_photomode_i18n");
        yamlTemplate = yamlTemplate.Replace("NPC_NAME", fileName);

        if (!string.IsNullOrEmpty(options.EntFilePath))
        {
            yamlTemplate = yamlTemplate.Replace("ENTITY_TEMPLATE_PATH", options.EntFilePath);
        }

        if (!string.IsNullOrEmpty(options.InkatlasPath))
        {
            yamlTemplate = yamlTemplate.Replace("INKATLAS_PATH", options.InkatlasPath);
        }

        if (!string.IsNullOrEmpty(options.IconName))
        {
            yamlTemplate = yamlTemplate.Replace("INKATLAS_ICON", options.IconName);
        }

        switch (options.BodyGender)
        {
            case PhotomodeBodyGender.Female:
                yamlTemplate = yamlTemplate.Replace(@"  visualTags: [ !append GENDER ]", "");
                break;
            case PhotomodeBodyGender.Massive:
                yamlTemplate = yamlTemplate.Replace(@"GENDER", "ManMassive");
                break;
            case PhotomodeBodyGender.Big:
                yamlTemplate = yamlTemplate.Replace(@"GENDER", "ManBig");
                break;
            case PhotomodeBodyGender.Male:
                yamlTemplate = yamlTemplate.Replace(@"GENDER", "ManAverage");
                break;
            case PhotomodeBodyGender.Cat:
                yamlTemplate = yamlTemplate.Replace(@"GENDER", "Cat");
                break;
        }


        File.WriteAllText(options.YamlFileAbsolutePath, yamlTemplate);
    }

    /// <summary>
    /// Copies an .app and .ent file, sets them up for photo mode, and connects them.
    /// </summary>
    /// <param name="activeProject">The active Wolvenkit project</param>
    /// <param name="loggerService">Logger service instance</param>
    /// <param name="options">option object</param>
    /// <returns>A list with all appearances in the .ent file</returns>
    public static void CreatePhotoModeAppAndEnt(Cp77Project activeProject, ILoggerService loggerService,
        PhotomodeEntAppOptions options)
    {
        var absolutePhotomodeFolder = Path.Join(activeProject.ModDirectory, options.TargetDir);

        if (!Directory.Exists(absolutePhotomodeFolder))
        {
            Directory.CreateDirectory(absolutePhotomodeFolder);
        }

        var appTargetAbsPath = Path.Join(activeProject.ModDirectory, options.AppDestRelPath);
        var appOriginalAbsPath = Path.Join(activeProject.ModDirectory, options.AppSourceRelPath);

        // Only copy app file when AppFileName is not an empty string
        if (File.Exists(appOriginalAbsPath) && options.WriteAppFile &&
            (!File.Exists(appTargetAbsPath) || options.IsOverwrite))
        {
            File.Copy(appOriginalAbsPath, appTargetAbsPath, true);
        }

        var entTargetAbsPath = Path.Join(activeProject.ModDirectory, options.EntDestRelPath);
        var entOriginalAbsPath = Path.Join(activeProject.ModDirectory, options.EntSourceRelPath);

        if (options.WriteEntFile)
        {
            if (File.Exists(entOriginalAbsPath) &&
                (!File.Exists(entTargetAbsPath) || options.IsOverwrite))
            {
                File.Copy(entOriginalAbsPath, entTargetAbsPath, true);
            }
        }

        List<string> warnings = [];

        if (!File.Exists(entTargetAbsPath) && options.WriteEntFile)
        {
            warnings.Add($"Failed to write .ent file to {entTargetAbsPath}");
        }

        if (!File.Exists(appTargetAbsPath) && options.WriteAppFile)
        {
            warnings.Add($"Failed to write .app file to {appTargetAbsPath}");
        }

        foreach (var warning in warnings)
        {
            loggerService.Error(warning);
        }

        if (!File.Exists(entTargetAbsPath))
        {
            return;
        }

        AddPhotomodeComponentsToEnt(entTargetAbsPath, options.BodyGender, loggerService);

        if (!File.Exists(appTargetAbsPath))
        {
            return;
        }

        DocumentTools.SetFacialAnimations(appTargetAbsPath, options.BodyGender);

        DocumentTools.ConnectAppToEntFile(appTargetAbsPath, entTargetAbsPath, true);
    }


    private static void AddPhotomodeComponentsToEnt(string entTargetAbsPath, PhotomodeBodyGender bodyGender,
        ILoggerService loggerService)
    {
        if (!File.Exists(entTargetAbsPath))
        {
            loggerService.Error($"File not found: {entTargetAbsPath}");
            return;
        }

        if (Cr2WTools.ReadCr2W(entTargetAbsPath) is not { RootChunk: entEntityTemplate ent } cr2W)
        {
            loggerService.Error($"invalid .ent: {entTargetAbsPath}");
            return;
        }

        if (ent.Components.OfType<PhotoModePlayerEntityComponent>().All(comp => comp.Name != "PhotoModePlayerEntity"))
        {
            ent.Components.Add(
                new PhotoModePlayerEntityComponent()
                {
                    Name = "PhotoModePlayerEntity", Id = CRUIDService.GenerateRandomCRUID(),
                });
        }

        // add animations to root component
        var rootComponent = ent.Components.OfType<entAnimatedComponent>().FirstOrDefault(c => c.Name == "root");

        if (rootComponent is not null && bodyGender is not PhotomodeBodyGender.Cat)
        {
            var gameplay = new CArray<animAnimSetupEntry>();

            var anims = bodyGender switch
            {
                PhotomodeBodyGender.Female => PhotomodeEntityAnimations.RootComponentFemale,
                PhotomodeBodyGender.Male => PhotomodeEntityAnimations.RootComponentMale,
                PhotomodeBodyGender.Massive => PhotomodeEntityAnimations.RootComponentMassive,
                PhotomodeBodyGender.Big => PhotomodeEntityAnimations.RootComponentBig,
                PhotomodeBodyGender.Cat => PhotomodeEntityAnimations.RootComponentCat,
                _ => PhotomodeEntityAnimations.RootComponentCat
            };
            rootComponent.Animations.Gameplay.Clear();

            foreach (var se in anims)
            {
                rootComponent.Animations.Gameplay.Add(new animAnimSetupEntry()
                {
                    AnimSet = new CResourceAsyncReference<animAnimSet>(se)
                });
            }
        }

        // add animations to Character Entity Animation Setup
        var specialAnimComponent = ent.Components.OfType<entAnimationSetupExtensionComponent>()
            .FirstOrDefault(c => c.Name == "Character Entity Animation Setup");

        if (specialAnimComponent is not null && bodyGender is not PhotomodeBodyGender.Cat)
        {
            var gameplay = new CArray<animAnimSetupEntry>();

            var anims = bodyGender switch
            {
                PhotomodeBodyGender.Female => PhotomodeEntityAnimations.SpecialLocomotionSetupFemale,
                PhotomodeBodyGender.Male => PhotomodeEntityAnimations.SpecialLocomotionSetupMale,
                PhotomodeBodyGender.Massive => PhotomodeEntityAnimations.SpecialLocomotionSetupMassive,
                PhotomodeBodyGender.Big => PhotomodeEntityAnimations.SpecialLocomotionSetupBig,
                PhotomodeBodyGender.Cat => [],
                _ => PhotomodeEntityAnimations.RootComponentCat
            };
            specialAnimComponent.Animations.Gameplay.Clear();

            foreach (var se in anims)
            {
                specialAnimComponent.Animations.Gameplay.Add(new animAnimSetupEntry()
                {
                    AnimSet = new CResourceAsyncReference<animAnimSet>(se)
                });
            }
        }

        // add animations to Special Locomotion Setup
        var specialLocomotionSetup = ent.Components.OfType<entAnimationSetupExtensionComponent>()
            .FirstOrDefault(c => c.Name == "Special Locomotion Setup");

        if (specialLocomotionSetup is not null && bodyGender is not PhotomodeBodyGender.Cat)
        {
            var anims = bodyGender switch
            {
                PhotomodeBodyGender.Female => PhotomodeEntityAnimations.SpecialLocomotionSetupFemale,
                PhotomodeBodyGender.Male => PhotomodeEntityAnimations.SpecialLocomotionSetupMale,
                PhotomodeBodyGender.Massive => PhotomodeEntityAnimations.SpecialLocomotionSetupMassive,
                PhotomodeBodyGender.Big => PhotomodeEntityAnimations.SpecialLocomotionSetupBig,
                PhotomodeBodyGender.Cat => [],
                _ => PhotomodeEntityAnimations.RootComponentCat
            };
            specialLocomotionSetup.Animations.Gameplay.Clear();

            foreach (var se in anims)
            {
                specialLocomotionSetup.Animations.Gameplay.Add(new animAnimSetupEntry()
                {
                    AnimSet = new CResourceAsyncReference<animAnimSet>(se)
                });
            }
        }

        // female: "Ultimate Edition Animsets" (this is not present in other .ent files)
        if (bodyGender == PhotomodeBodyGender.Female && ent.Components.OfType<entAnimationSetupExtensionComponent>()
                .All(c => c.Name != "Ultimate Edition Animsets"))
        {
            ent.Components.Add(
                new entAnimationSetupExtensionComponent()
                {
                    Name = "Ultimate Edition Animsets",
                    Animations = new animAnimSetup() { Hash = 1099511628211 }, // steal from Rogue
                    ControlBinding =
                        new CHandle<entAnimationControlBinding>()
                        {
                            Chunk = new entAnimationControlBinding() { BindName = "root", Enabled = true }
                        }
                });
        }

        Cr2WTools.WriteCr2W(cr2W, entTargetAbsPath);
    }

    public static void CreateOrAppendToJsonFile(
        string absoluteFilePath,
        Dictionary<string, string> entries,
        bool overwrite,
        ILoggerService loggerService)
    {
        CR2WFile cr2W;
        if (File.Exists(absoluteFilePath))
        {
            cr2W = Cr2WTools.ReadCr2W(absoluteFilePath);
        }
        else
        {
            cr2W = new CR2WFile()
            {
                RootChunk = new JsonResource()
                {
                    Root = new CHandle<ISerializable>() { Chunk = new localizationPersistenceOnScreenEntries() }
                }
            };
        }

        if (cr2W.RootChunk is not JsonResource { Root.Chunk: localizationPersistenceOnScreenEntries chunk })
        {
            throw new Exception("Invalid JSON file");
        }

        var existingSecondaryKeys = chunk.Entries.ToDictionary(x => x.SecondaryKey, x => x.FemaleVariant);

        List<string> nameCollisions = [];

        foreach (var kvp in entries)
        {
            if (!overwrite && existingSecondaryKeys.ContainsKey(kvp.Key))
            {
                if (existingSecondaryKeys[kvp.Key] != kvp.Value)
                {
                    nameCollisions.Add($"{kvp.Key}: {existingSecondaryKeys[kvp.Key]} (supposed to be {kvp.Value})");
                }

                continue;
            }
            chunk.Entries.Add(new localizationPersistenceOnScreenEntry()
            {
                SecondaryKey = kvp.Key, FemaleVariant = kvp.Value,
            });
        }

        if (nameCollisions.Count > 0)
        {
            loggerService.Warning($"The following keys were already found in the JSON file (not overwriting):\n\t{
                string.Join("\n\t", nameCollisions)
            }");
        }

        Cr2WTools.WriteCr2W(cr2W, absoluteFilePath);
    }
}

public class PhotomodeYamlOptions
{
    public PhotomodeBodyGender BodyGender { get; init; } = PhotomodeBodyGender.Female;

    public string ModderName { get; init; } = "";
    public string NpcName { get; init; } = "";
    public string YamlFileAbsolutePath { get; init; } = "";
    public string InkatlasPath { get; init; } = "";
    public string IconName { get; init; } = "";
    public string EntFilePath { get; init; } = "";
    public bool Overwrite { get; init; }
}

public class PhotomodeEntAppOptions
{
    public string EntSourceRelPath { get; init; } = "";
    public string EntDestRelPath { get; init; } = "";
    public string AppSourceRelPath { get; init; } = "";
    public string AppDestRelPath { get; init; } = "";
    public string TargetDir { get; init; } = "";

    public PhotomodeBodyGender BodyGender { get; init; } = PhotomodeBodyGender.Female;
    public bool WriteAppFile { get; init; }
    public bool WriteEntFile { get; init; }
    public bool IsOverwrite { get; init; }
}