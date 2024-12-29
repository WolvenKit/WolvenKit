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

public abstract class TemplateFileHelper
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

            AddPhotomodeComponents(entTargetAbsPath, options.BodyGender, loggerService);
        }

        if (!File.Exists(appTargetAbsPath) || !File.Exists(entTargetAbsPath))
        {
            loggerService.Error(".app file or .ent file could not be added");
        }

        DocumentTools.ConnectAppToEntFile(appTargetAbsPath, entTargetAbsPath, true);
    }

    private static void AddPhotomodeComponents(string entTargetAbsPath, PhotomodeBodyGender bodyGender,
        ILoggerService loggerService)
    {
        if (!File.Exists(entTargetAbsPath))
        {
            loggerService.Error($"File not found: {entTargetAbsPath}");
            return;
        }

        if (DocumentTools.ReadCr2W(entTargetAbsPath) is not { RootChunk: entEntityTemplate ent } cr2w)
        {
            loggerService.Error($"invalid .ent: {entTargetAbsPath}");
            return;
        }

        if (!ent.Components.OfType<PhotoModePlayerEntityComponent>().Any())
        {
            ent.Components.Add(
                new PhotoModePlayerEntityComponent()
                {
                    Name = "PhotomodePlayerEntity", Id = CRUIDService.GenerateRandomCRUID(),
                });
        }

        // female: Needs "Ultimate Edition Animsets" (this is not present in other .ent files)
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
        
        DocumentTools.WriteCr2W(cr2w, entTargetAbsPath);
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
            cr2W = DocumentTools.ReadCr2W(absoluteFilePath);
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
        
        foreach (var keyValuePair in entries)
        {
            if (!overwrite && existingSecondaryKeys.ContainsKey(keyValuePair.Key))
            {
                if (existingSecondaryKeys[keyValuePair.Key] != keyValuePair.Value)
                {
                    nameCollisions.Add(
                        $"{keyValuePair.Key}: {existingSecondaryKeys[keyValuePair.Key]} (supposed to be {keyValuePair.Value})");
                }

                continue;
            }
            chunk.Entries.Add(new localizationPersistenceOnScreenEntry()
            {
                SecondaryKey = keyValuePair.Key, FemaleVariant = keyValuePair.Value,
            });
        }

        if (nameCollisions.Count > 0)
        {
            loggerService.Warning($"The following keys were already found in the JSON file (not overwriting):\n\t{
                string.Join("\n\t", nameCollisions)
            }");
        }

        DocumentTools.WriteCr2W(cr2W, absoluteFilePath);
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