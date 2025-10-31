using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using DynamicData;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using PhotoModePlayerEntityComponent = WolvenKit.RED4.Types.PhotoModePlayerEntityComponent;

// ReSharper disable UnreachableSwitchArmDueToIntegerAnalysis

namespace WolvenKit.App.Helpers;

public class TemplateFileTools
{
    private readonly ILoggerService _loggerService;
    private readonly IProjectManager _projectManager;
    private readonly IModTools _modTools;
    private readonly Cr2WTools _cr2WTools;
    private readonly DocumentTools _documentTools;
    private readonly ProjectResourceTools _projectResourceTools;
    private readonly ISettingsManager _settingsManager;
    private readonly IAppArchiveManager _archiveManager;

    public TemplateFileTools(ILoggerService loggerService, IProjectManager projectManager, IModTools modTools,
        Cr2WTools cr2WTools, DocumentTools documentTools, ProjectResourceTools projectResourceTools,
        ISettingsManager settingsManager, IAppArchiveManager archiveManager)
    {
        _loggerService = loggerService;
        _projectManager = projectManager;
        _modTools = modTools;
        _cr2WTools = cr2WTools;
        _documentTools = documentTools;
        _projectResourceTools = projectResourceTools;
        _settingsManager = settingsManager;
        _settingsManager = settingsManager;
        _archiveManager = archiveManager;
    }

    public void CopyInkatlasTemplateSingle(string inkatlasRelativePath, bool forceOverwrite)
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return;
        }

        var inkatlasResourcePath = Path.Join("inkatlas", "single_item_template.inkatlas.json");
        var targetFolderRelativePath = Path.GetDirectoryName(inkatlasRelativePath);

        var inkatlasExists = CopyResource(inkatlasResourcePath, inkatlasRelativePath, forceOverwrite) &&
                             File.Exists(Path.Join(activeProject.ModDirectory, inkatlasRelativePath));

        var inkatlasFileName = Path.GetFileNameWithoutExtension(inkatlasRelativePath);

        // Copy the xbm file
        var xbmResourcePath = Path.Join("inkatlas", "single_item_template.xbm");
        var xbmDestPath = Path.Join(targetFolderRelativePath, $"{inkatlasFileName}.xbm");
        var xbmExists = CopyResource(xbmResourcePath, xbmDestPath);

        var inkatlasAbsolutePath = Path.Join(activeProject.ModDirectory, inkatlasRelativePath);
        if (!inkatlasExists || !xbmExists || _cr2WTools.ReadCr2W(inkatlasAbsolutePath) is
                not { RootChunk: inkTextureAtlas atlas } cr2W)
        {
            return;
        }

        foreach (var inkTextureSlot in atlas.Slots)
        {
            inkTextureSlot.Texture = new CResourceAsyncReference<CBitmapTexture>(xbmDestPath);
        }

        _cr2WTools.WriteCr2W(cr2W, inkatlasAbsolutePath);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="resourceRelativePath">Path under Resources/TemplateFiles</param>
    /// <param name="targetRelativePath">Relative path of target file</param>
    /// <param name="forceOverwrite"></param>
    /// <param name="askOverwrite"></param>
    private bool CopyResource(string resourceRelativePath, string targetRelativePath,
        bool forceOverwrite = false, bool askOverwrite = false)
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return false;
        }

        var resourcePath = Path.Join("Resources", "TemplateFiles");
        var sourceAbsolutePath = Path.Combine(AppContext.BaseDirectory, "Resources", "TemplateFiles",
            resourceRelativePath.Replace(resourcePath, ""));

        if (!File.Exists(sourceAbsolutePath))
        {
            _loggerService.Error($"Failed to read resource from files: {resourceRelativePath}");
            return false;
        }

        var targetAbsolutePath = Path.Join(activeProject.ModDirectory, targetRelativePath);
        if (File.Exists(targetAbsolutePath) && !(forceOverwrite || (askOverwrite && !Interactions.ShowQuestionYesNo((
                $"File {targetAbsolutePath} already exists. Overwrite it?", "Overwrite file?")))))
        {
            return false;
        }

        var absoluteDestDir = Path.GetDirectoryName(targetAbsolutePath) ?? "";

        var targetFileName = Path.GetFileName(targetAbsolutePath);

        try
        {
            if (resourceRelativePath.EndsWith(".json"))
            {
                _loggerService.Info($"Adding and converting {resourceRelativePath}...");
                var sourceFileName = Path.GetFileName(sourceAbsolutePath).Replace(".json", "");

                if (!_modTools.ConvertFromJsonAndWrite(sourceAbsolutePath, absoluteDestDir))
                {
                    return false;
                }

                if (targetFileName == sourceFileName)
                {
                    return true;
                }

                File.Move(Path.Join(absoluteDestDir, sourceFileName), Path.Join(absoluteDestDir, targetFileName),
                    true);
                return true;
            }

            if (!Directory.Exists(absoluteDestDir))
            {
                Directory.CreateDirectory(absoluteDestDir);
            }

            File.Copy(sourceAbsolutePath, targetAbsolutePath, true);
            return true;
        }
        catch (JsonException err)
        {
            var relativePath = activeProject.GetRelativePath(sourceAbsolutePath);

            if (err.Message.Contains(" | LineNumber"))
            {
                _loggerService.Error($"Failed to parse JSON in {relativePath}.");
                _loggerService.Error(
                    $"The error is in LineNumber{err.Message.Split(" | LineNumber").LastOrDefault()}");
            }
            else
            {
                _loggerService.Error($"Something went _really_ wrong when trying to parse {relativePath}:");
                throw;
            }
        }

        return false;
    }

    public void CreatePhotomodeYaml(PhotomodeYamlOptions options)
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

        // upper case first letter makes them show up at the top of the list
        yamlTemplate = yamlTemplate.Replace("NPC_NAME", fileName.FirstCharToUpper());

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
    /// <param name="options">option object</param>
    /// <returns>A list with all appearances in the .ent file</returns>
    public void CreatePhotoModeAppAndEnt(PhotomodeEntAppOptions options)
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return;
        }

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
            _loggerService.Error(warning);
        }

        if (!File.Exists(entTargetAbsPath))
        {
            return;
        }

        AddPhotomodeComponentsToEnt(entTargetAbsPath, options.BodyGender);

        if (!File.Exists(appTargetAbsPath))
        {
            return;
        }

        _documentTools.SetFacialAnimations(appTargetAbsPath, options.BodyGender);

        _documentTools.ConnectAppToEntFile(appTargetAbsPath, entTargetAbsPath, true);
    }


    private void AddPhotomodeComponentsToEnt(string entTargetAbsPath, PhotomodeBodyGender bodyGender)
    {
        if (!File.Exists(entTargetAbsPath))
        {
            _loggerService.Error($"File not found: {entTargetAbsPath}");
            return;
        }

        if (_cr2WTools.ReadCr2W(entTargetAbsPath) is not { RootChunk: entEntityTemplate ent } cr2W)
        {
            _loggerService.Error($"invalid .ent: {entTargetAbsPath}");
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

        _cr2WTools.WriteCr2W(cr2W, entTargetAbsPath);
    }

    public void CreateOrAppendToJsonFile(
        string absoluteFilePath,
        Dictionary<string, string> entries,
        bool overwrite,
        ILoggerService loggerService)
    {
        CR2WFile cr2W;
        if (File.Exists(absoluteFilePath))
        {
            cr2W = _cr2WTools.ReadCr2W(absoluteFilePath);
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

        _cr2WTools.WriteCr2W(cr2W, absoluteFilePath);
    }

    public void GenerateMinimalQuest(QuestGenerationOptions options)
    {
        // 1. Setup directories and paths
        var paths = SetupDirectoriesAndPaths(options);
        if (paths == null) return;

        // 2. Create journal file
        CreateJournalFile(options, paths);

        // 3. Create quest phase files
        CreateQuestPhaseFiles(options, paths);

        // 4. Create onscreens localization file
        CreateOnscreensLocalizationFile(options, paths);

        // 5. Create .archive.xl file in project resources folder
        CreateArchiveXlFile(options);
    }

    // Helper to setup directories and return all relevant paths
    private class MinimalQuestPaths
    {
        public string ModDir { get; set; } = string.Empty;
        public string JournalDir { get; set; } = string.Empty;
        public string LocalizationDir { get; set; } = string.Empty;
        public string QuestDir { get; set; } = string.Empty;
        public string PhasesDir { get; set; } = string.Empty;
        public string SceneDir { get; set; } = string.Empty;
        public string JournalPath { get; set; } = string.Empty;
        public string OnscreensPath { get; set; } = string.Empty;
        public string RootQuestphasePath { get; set; } = string.Empty;
        public string SetupPhasePath { get; set; } = string.Empty;
    }

    private MinimalQuestPaths? SetupDirectoriesAndPaths(QuestGenerationOptions options)
    {
        if (string.IsNullOrEmpty(options.ModName) || string.IsNullOrEmpty(options.TargetRoot))
        {
            _loggerService.Error("ModName or TargetRoot is empty.");
            return null;
        }
        var modDir = Path.Combine(options.TargetRoot, options.ModName);
        var journalDir = Path.Combine(modDir, "journal");
        var localizationDir = Path.Combine(modDir, "localization", "en-us", "onscreens");
        var questDir = Path.Combine(modDir, "quest");
        var phasesDir = Path.Combine(questDir, "phases");
        var sceneDir = Path.Combine(questDir, "scene");
        Directory.CreateDirectory(journalDir);
        Directory.CreateDirectory(localizationDir);
        Directory.CreateDirectory(questDir);
        Directory.CreateDirectory(phasesDir);
        Directory.CreateDirectory(sceneDir);
        return new MinimalQuestPaths
        {
            ModDir = modDir,
            JournalDir = journalDir,
            LocalizationDir = localizationDir,
            QuestDir = questDir,
            PhasesDir = phasesDir,
            SceneDir = sceneDir,
            JournalPath = Path.Combine(journalDir, $"{options.ModName}.journal"),
            OnscreensPath = Path.Combine(localizationDir, $"{options.ModName}.json"),
            RootQuestphasePath = Path.Combine(questDir, $"{options.ModName}_root.questphase"),
            SetupPhasePath = Path.Combine(phasesDir, $"{options.ModName}_root_setup.questphase")
        };
    }

    private void CreateJournalFile(QuestGenerationOptions options, MinimalQuestPaths paths)
    {
        if (!File.Exists(paths.JournalPath))
        {
            var journalResource = new gameJournalResource();
            var rootEntry = new gameJournalRootFolderEntry {  };

            // onscreens folder
            var onscreensFolder = new gameJournalFolderEntry { Id = "onscreens" };
            var onscreenGroup = new gameJournalOnscreenGroup { Id = $"{options.ModName}_tutorials" };
            var onscreenEntry = new gameJournalOnscreen
            {
                Id = $"{options.ModName}_popup" ,
                Tag = "None",
                Title = new LocalizationString { Value = $"{options.ModName}_popup_title" },
                Description = new LocalizationString { Value = $"{options.ModName}_popup_description" },
            };
            onscreenGroup.Entries.Add(new CHandle<gameJournalEntry>(onscreenEntry));
            onscreensFolder.Entries.Add(new CHandle<gameJournalEntry>(onscreenGroup));

            // contacts folder
            var contactsFolder = new gameJournalFolderEntry { Id = "contacts" };
            var contactEntry = new gameJournalContact
            {
                Id = $"{options.ModderName}",
                Name = new LocalizationString { Value = $"{options.ModName}_{options.ModderName}" },
                Type = Enums.gameContactType.Texter,
                UseFlatMessageLayout = true,
                IsCallableDefault = true
            };
            // Phone conversation
            var phoneConversation = new gameJournalPhoneConversation
            {
                Id = $"{options.ModName}_thread_title",
                Title = new LocalizationString { Value = $"{options.ModName}_thread_title"}
            };
            // Phone message
            var phoneMessage = new gameJournalPhoneMessage
            {
                Id = "info1",
                Delay = 3,
                IsQuestImportant = false,
                Sender = Enums.gameMessageSender.NPC,
                Text = new LocalizationString { Value = $"{options.ModName}_message" },
            };
            phoneConversation.Entries.Add(new CHandle<gameJournalEntry>(phoneMessage));
            contactEntry.Entries.Add(new CHandle<gameJournalEntry>(phoneConversation));
            contactsFolder.Entries.Add(new CHandle<gameJournalEntry>(contactEntry));

            // Add folders to root
            rootEntry.Entries.Add(new CHandle<gameJournalEntry>(onscreensFolder));
            rootEntry.Entries.Add(new CHandle<gameJournalEntry>(contactsFolder));
            journalResource.Entry = new CHandle<gameJournalEntry>(rootEntry);

            var cr2w = new CR2WFile { RootChunk = journalResource };
            _cr2WTools.WriteCr2W(cr2w, paths.JournalPath);
        }
    }

    // ... Move the quest phase file creation logic into this helper ...
    private void CreateQuestPhaseFiles(QuestGenerationOptions options, MinimalQuestPaths paths)
    {
        if (!File.Exists(paths.RootQuestphasePath))
        {
            var cr2w = new CR2WFile { RootChunk = RedTypeManager.Create("questQuestPhaseResource") };
            _cr2WTools.WriteCr2W(cr2w, paths.RootQuestphasePath);
        }

        // Add questInputNodeDefinition and questPhaseNodeDefinition to rootQuestphasePath
        if (_cr2WTools.ReadCr2W(paths.RootQuestphasePath) is { RootChunk: questQuestPhaseResource phaseResource })
        {
            // Ensure the graph exists
            if (phaseResource.Graph == null)
            {
                phaseResource.Graph = new CHandle<graphGraphDefinition>(new questGraphDefinition());
            }
            if (phaseResource.Graph?.Chunk is graphGraphDefinition graph)
            {
                // Only add if not already present
                bool hasInput = graph.Nodes.Any(n => n.Chunk is questInputNodeDefinition);
                bool hasPhase = graph.Nodes.Any(n => n.Chunk is questPhaseNodeDefinition);
                if (!hasInput)
                {
                    var inputNode = new questInputNodeDefinition
                    {
                        SocketName = "In1",
                        Id = 1
                    };
                    // Add CutDestination socket
                    inputNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                    {
                        Name = "CutDestination",
                        Type = Enums.questSocketType.CutDestination
                    }));
                    // Add Out socket
                    inputNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition
                    {
                        Name = "Out",
                        Type = Enums.questSocketType.Output
                    }));
                    graph.Nodes.Add(new CHandle<graphGraphNodeDefinition>(inputNode));
                }
                if (!hasPhase)
                {
                    var resourcePath = $"mod/{options.ModName}/quest/phases/{options.ModName}_root_setup.questphase";
                    var phaseNode = new questPhaseNodeDefinition
                    {
                        Id = 2,
                        PhaseResource = new CResourceAsyncReference<questQuestPhaseResource>(resourcePath)
                    };

                    // Add sockets as specified (CutDestination first)
                    phaseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                    phaseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In1", Type = Enums.questSocketType.Input }));
                    phaseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "basegame", Type = Enums.questSocketType.Output }));
                    phaseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "ifEP1", Type = Enums.questSocketType.Output }));
                    phaseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "ifReset", Type = Enums.questSocketType.Output }));

                    graph.Nodes.Add(new CHandle<graphGraphNodeDefinition>(phaseNode));

                    // Helper to get a socket by node ID and socket name
                    graphGraphSocketDefinition GetSocket(ushort nodeId, string socketName)
                    {
                        graphGraphNodeDefinition? node = null;
                        foreach (var n in graph.Nodes)
                        {
                            if (n.Chunk is questNodeDefinition qn && qn.Id == nodeId)
                            {
                                node = n.Chunk;
                                break;
                            }
                        }
                        graphGraphSocketDefinition? socket = null;
                        if (node?.Sockets != null)
                        {
                            socket = node.Sockets
                                .Where(h => h?.Chunk != null)
                                .Select(h => h.Chunk)
                                .FirstOrDefault(s => s?.Name == socketName);
                        }
                        // Fallback: search all nodes for the socket if not found
                        if (socket == null)
                        {
                            socket = graph.Nodes
                                .Where(h => h?.Chunk != null && h.Chunk.Sockets != null)
                                .SelectMany(h => h?.Chunk?.Sockets ?? new CArray<CHandle<graphGraphSocketDefinition>>())
                                .Where(h => h?.Chunk != null)
                                .Select(h => h.Chunk)
                                .FirstOrDefault(s => s?.Name == socketName);
                        }
                        if (socket == null)
                            throw new KeyNotFoundException($"Socket '{socketName}' not found for node {nodeId}.");
                        return socket;
                    }
                    // Helper to connect two sockets
                    void Connect(ushort fromId, string fromSocket, ushort toId, string toSocket)
                    {
                        var from = GetSocket(fromId, fromSocket);
                        var to = GetSocket(toId, toSocket);
                        var conn = new graphGraphConnectionDefinition
                        {
                            Source = new CWeakHandle<graphGraphSocketDefinition>(from),
                            Destination = new CWeakHandle<graphGraphSocketDefinition>(to)
                        };
                        from.Connections.Add(new CHandle<graphGraphConnectionDefinition>(conn));
                        to.Connections.Add(new CHandle<graphGraphConnectionDefinition>(conn));
                    }
                    // Add connections as specified
                    Connect(1, "Out", 2, "In1");
                    Connect(2, "ifReset", 2, "In1");
                }
                _cr2WTools.WriteCr2W(new CR2WFile { RootChunk = phaseResource }, paths.RootQuestphasePath);
            }
        }
        if (!File.Exists(paths.SetupPhasePath))
        {
            var cr2w = new CR2WFile { RootChunk = RedTypeManager.Create("questQuestPhaseResource") };
            _cr2WTools.WriteCr2W(cr2w, paths.SetupPhasePath);
        }

        // Populate setupPhasePath with nodes and connections as in the image
        if (_cr2WTools.ReadCr2W(paths.SetupPhasePath) is { RootChunk: questQuestPhaseResource setupPhaseResource })
        {
            if (setupPhaseResource.Graph == null)
                setupPhaseResource.Graph = new CHandle<graphGraphDefinition>(new questGraphDefinition());
            if (setupPhaseResource.Graph.Chunk is questGraphDefinition setupGraph)
            {
                // Node creation (IDs and placeholder values)
                var nodes = new List<graphGraphNodeDefinition>();
                // [1] Input
                var inputNode = new questInputNodeDefinition { Id = 1, SocketName = "In1", Sockets = new() };
                inputNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                inputNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                nodes.Add(inputNode);
                // [2] Output (NonTerminating)
                var outputNode2 = new questOutputNodeDefinition { Id = 2, SocketName = "basegame", Sockets = new(), Type = Enums.questExitType.NonTerminating };
                outputNode2.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                outputNode2.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                nodes.Add(outputNode2);
                // [3] Output (NonTerminating)
                var outputNode3 = new questOutputNodeDefinition { Id = 3, SocketName = "ifEP1",  Sockets = new(), Type = Enums.questExitType.NonTerminating };
                outputNode3.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                outputNode3.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                nodes.Add(outputNode3);
                // [4] Output (Terminating)
                var outputNode4 = new questOutputNodeDefinition { Id = 4, SocketName = "ifReset",  Sockets = new() };
                outputNode4.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                outputNode4.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                nodes.Add(outputNode4);
                // [5-8, 12, 14] PauseCondition nodes
                for (ushort i = 5; i <= 8; i++)
                {
                    var pauseNode = new questPauseConditionNodeDefinition { Id = i, Sockets = new() };
                    pauseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                    pauseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                    pauseNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                    // Set specific properties for [5] and [6]
                    if (i == 5)
                    {
                        var triggerCondition = new questTriggerCondition
                        {
                            IsPlayerActivator = true,
                            TriggerAreaRef = "#mq000_tr_vs_apartment",
                            Type = Enums.questTriggerConditionType.IsInside
                        };
                        pauseNode.Condition = new CHandle<questIBaseCondition>(triggerCondition);
                    }
                    else if (i == 6)
                    {
                        var varComparison = new questVarComparison_ConditionType
                        {
                            FactName = $"{options.ModName}_active",
                            ComparisonType = Enums.EComparisonType.Equal,
                            Value = 0
                        };
                        var factsDbCondition = new questFactsDBCondition
                        {
                            Type = new CHandle<questIFactsDBConditionType>(varComparison)
                        };
                        pauseNode.Condition = new CHandle<questIBaseCondition>(factsDbCondition);
                    }
                    else if (i == 7)
                    {
                        var deviceConditionType = new questDevice_ConditionType
                        {
                            ObjectRef = "#q001_v_room_tv",
                            DeviceControllerClass = "TVControllerPS",
                            DeviceConditionFunction = "IsON"
                        };
                        var objectCondition = new questObjectCondition
                        {
                            Type = new CHandle<questIObjectConditionType>(deviceConditionType)
                        };
                        pauseNode.Condition = new CHandle<questIBaseCondition>(objectCondition);
                    }
                    else if (i == 8)
                    {
                        var realTimeDelayType = new questRealtimeDelay_ConditionType
                        {
                            Hours = 0,
                            Minutes = 0,
                            Seconds = 0,
                            Miliseconds = 500
                        };
                        var timeCondition = new questTimeCondition
                        {
                            Type = new CHandle<questITimeConditionType>(realTimeDelayType)
                        };
                        pauseNode.Condition = new CHandle<questIBaseCondition>(timeCondition);
                    }
                    nodes.Add(pauseNode);
                }
                var pauseNode12 = new questPauseConditionNodeDefinition { Id = 12, Sockets = new() };
                pauseNode12.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                pauseNode12.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                pauseNode12.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                // Set specific properties for [12]
                {
                    var varComparison = new questVarComparison_ConditionType
                    {
                        FactName = "ep1_active",
                        ComparisonType = Enums.EComparisonType.GreaterOrEqual,
                        Value = 1
                    };
                    var factsDbCondition = new questFactsDBCondition
                    {
                        Type = new CHandle<questIFactsDBConditionType>(varComparison)
                    };
                    pauseNode12.Condition = new CHandle<questIBaseCondition>(factsDbCondition);
                }
                nodes.Add(pauseNode12);
                var pauseNode14 = new questPauseConditionNodeDefinition { Id = 14, Sockets = new() };
                pauseNode14.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                pauseNode14.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                pauseNode14.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                // Set specific properties for [14]
                {
                    var triggerCondition = new questTriggerCondition
                    {
                        IsPlayerActivator = true,
                        TriggerAreaRef = "#mq000_tr_vs_apartment",
                        Type = Enums.questTriggerConditionType.IsOutside
                    };
                    pauseNode14.Condition = new CHandle<questIBaseCondition>(triggerCondition);
                }
                nodes.Add(pauseNode14);
                // [9] UIManager
                var uiManagerNode = new questUIManagerNodeDefinition { Id = 9, Sockets = new() };
                uiManagerNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                uiManagerNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                uiManagerNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                // Set properties for UIManager [9]
                {
                    var showPopupSubtype = new questShowPopup_NodeSubType
                    {
                        Path = new CHandle<gameJournalPath>(new gameJournalPath
                        {
                            ClassName = "gameJournalOnscreen",
                            RealPath = $"onscreens/{options.ModName}_tutorials/{options.ModName}_popup",
                            FileEntryIndex = 1
                        }),
                        CloseAtInput = true,
                        CloseCurrentPopup = false,
                        HideInMenu = true,
                        IgnoreDisabledTutorials = true,
                        PauseGame = true,
                        Position = Enums.gamePopupPosition.LowerLeft,
                        ScreenMode = Enums.questTutorialScreenMode.Fullscreen
                    };
                    var tutorialType = new questTutorial_NodeType
                    {
                        Subtype = new CHandle<questITutorial_NodeSubType>(showPopupSubtype)
                    };
                    uiManagerNode.Type = new CHandle<questIUIManagerNodeType>(tutorialType);
                }
                nodes.Add(uiManagerNode);
                // [10] Journal
                var journalNode = new questJournalNodeDefinition { Id = 10, Sockets = new() };
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Active", Type = Enums.questSocketType.Input }));
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Inactive", Type = Enums.questSocketType.Input }));
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Failed", Type = Enums.questSocketType.Input }));
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Succeeded", Type = Enums.questSocketType.Input }));
                journalNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                // Set properties for Journal [10]
                {
                    var journalEntryType = new questJournalEntry_NodeType
                    {
                        Path = new CHandle<gameJournalPath>(new gameJournalPath
                        {
                            ClassName = "gameJournalPhoneMessage",
                            RealPath =  $"contacts/{options.ModderName}/{options.ModName}_thread_title/info1",
                            FileEntryIndex = 1
                        }),
                        SendNotification = true
                    };
                    journalNode.Type = new CHandle<questIJournal_NodeType>(journalEntryType);
                }
                nodes.Add(journalNode);
                // [11] Condition
                var conditionNode = new questConditionNodeDefinition { Id = 11, Sockets = new() };
                conditionNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                conditionNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                conditionNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "True", Type = Enums.questSocketType.Output }));
                conditionNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "False", Type = Enums.questSocketType.Output }));
                // Set properties for Condition [11]
                {
                    var varComparison = new questVarComparison_ConditionType
                    {
                        FactName = "ep1_active",
                        ComparisonType = Enums.EComparisonType.GreaterOrEqual,
                        Value = 1
                    };
                    var factsDbCondition = new questFactsDBCondition
                    {
                        Type = new CHandle<questIFactsDBConditionType>(varComparison)
                    };
                    conditionNode.Condition = new CHandle<questIBaseCondition>(factsDbCondition);
                }
                nodes.Add(conditionNode);
                // [13] FactDBManager
                var factDBNode = new questFactsDBManagerNodeDefinition { Id = 13, Sockets = new() };
                factDBNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination }));
                factDBNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input }));
                factDBNode.Sockets.Add(new CHandle<graphGraphSocketDefinition>(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output }));
                // Set properties for FactsDBManager [13]
                {
                    var setVarType = new questSetVar_NodeType
                    {
                        FactName = $"{options.ModName}_active",
                        SetExactValue = true,
                        Value = 1
                    };
                    factDBNode.Type = new CHandle<questIFactsDBManagerNodeType>(setVarType);
                }
                nodes.Add(factDBNode);
                // Add all nodes to the graph
                var nodeHandles = new Dictionary<ushort, graphGraphNodeDefinition>();
                foreach (var node in nodes)
                {
                    setupGraph.Nodes.Add(new CHandle<graphGraphNodeDefinition>(node));
                    if (node is questNodeDefinition qn && qn.Id != ushort.MaxValue && qn.Id != 0 && !nodeHandles.ContainsKey(qn.Id))
                    {
                        nodeHandles[qn.Id] = node;
                    }
                }
                // Helper to get a socket by node ID and socket name
                graphGraphSocketDefinition GetSocket(ushort nodeId, string socketName)
                {
                    graphGraphNodeDefinition? node = null;
                    nodeHandles.TryGetValue(nodeId, out node);
                    graphGraphSocketDefinition? socket = null;
                    if (node?.Sockets != null)
                    {
                        socket = node.Sockets
                            .Where(h => h?.Chunk != null)
                            .Select(h => h.Chunk)
                            .FirstOrDefault(s => s?.Name == socketName);
                    }
                    // Fallback: search all nodes for the socket if not found
                    if (socket == null)
                    {
                        socket = setupGraph.Nodes
                            .Where(h => h?.Chunk != null && h.Chunk.Sockets != null)
                            .SelectMany(h => h?.Chunk?.Sockets ?? new CArray<CHandle<graphGraphSocketDefinition>>())
                            .Where(h => h?.Chunk != null)
                            .Select(h => h.Chunk)
                            .FirstOrDefault(s => s?.Name == socketName);
                    }
                    if (socket == null)
                        throw new KeyNotFoundException($"Socket '{socketName}' not found for node {nodeId}.");
                    return socket;
                }
                // Helper to connect two sockets
                void Connect(ushort fromId, string fromSocket, ushort toId, string toSocket)
                {
                    var from = GetSocket(fromId, fromSocket);
                    var to = GetSocket(toId, toSocket);
                    var conn = new graphGraphConnectionDefinition
                    {
                        Source = new CWeakHandle<graphGraphSocketDefinition>(from),
                        Destination = new CWeakHandle<graphGraphSocketDefinition>(to)
                    };
                    from.Connections.Add(new CHandle<graphGraphConnectionDefinition>(conn));
                    to.Connections.Add(new CHandle<graphGraphConnectionDefinition>(conn));
                }
                // Connections (precise per user)
                Connect(1, "Out", 5, "In");
                Connect(5, "Out", 6, "In");
                Connect(6, "Out", 7, "In");
                Connect(7, "Out", 8, "In");
                Connect(8, "Out", 9, "In");
                Connect(9, "Out", 10, "Active");
                Connect(9, "Out", 11, "In");
                Connect(9, "Out", 13, "In");
                Connect(10, "Out", 2, "In");
                Connect(11, "False", 12, "In");
                Connect(11, "True", 3, "In");
                Connect(12, "Out", 3, "In");
                Connect(14, "Out", 4, "In");
                // Add missing connection: FactsDBManager [13] Out → PauseCondition [14] In
                Connect(13, "Out", 14, "In");
                // Save the file
                _cr2WTools.WriteCr2W(new CR2WFile { RootChunk = setupPhaseResource }, paths.SetupPhasePath);
            }
        }
    }

    private string GetFileOrganizationSubdir()
    {
        if (!_settingsManager.UseAuthorNameAsSubfolder)
        {
            return _projectManager.ActiveProject?.Name ?? "";
        }

        if (_projectManager.ActiveProject?.Author is string author && !string.IsNullOrEmpty(author))
        {
            return author;
        }

        return _settingsManager.ModderName ?? "";
    }

    private void CreateOnscreensLocalizationFile(QuestGenerationOptions options, MinimalQuestPaths paths)
    {
        if (!File.Exists(paths.OnscreensPath))
        {
            var modnameUpper = options.ModName.ToUpperInvariant();
            var onscreenEntries = new localizationPersistenceOnScreenEntries();
            onscreenEntries.Entries.Add(new localizationPersistenceOnScreenEntry
            {
                FemaleVariant = $"{modnameUpper} TITLE",
                MaleVariant = "",
                PrimaryKey = 0,
                SecondaryKey = $"{options.ModName}_popup_title"
            });
            onscreenEntries.Entries.Add(new localizationPersistenceOnScreenEntry
            {
                FemaleVariant = $"{modnameUpper} DESCRIPTION",
                MaleVariant = "",
                PrimaryKey = 0,
                SecondaryKey = $"{options.ModName}_popup_description"
            });
            onscreenEntries.Entries.Add(new localizationPersistenceOnScreenEntry
            {
                FemaleVariant = $"{modnameUpper} AUTHOR",
                MaleVariant = "",
                PrimaryKey = 0,
                SecondaryKey = $"{options.ModName}_{options.ModderName}"
            });
            onscreenEntries.Entries.Add(new localizationPersistenceOnScreenEntry
            {
                FemaleVariant = $"{modnameUpper} THREAD TITLE",
                MaleVariant = "",
                PrimaryKey = 0,
                SecondaryKey = $"{options.ModName}_thread_title"
            });
            onscreenEntries.Entries.Add(new localizationPersistenceOnScreenEntry
            {
                FemaleVariant = $"{modnameUpper} CONFIRMATION MESSAGE",
                MaleVariant = "",
                PrimaryKey = 0,
                SecondaryKey = $"{options.ModName}_message"
            });

            var cr2w = new CR2WFile
            {
                RootChunk = new JsonResource
                {
                    Root = new CHandle<ISerializable>(onscreenEntries)
                }
            };
            _cr2WTools.WriteCr2W(cr2w, paths.OnscreensPath);
        }
    }

    private const string s_questTemplateYaml = """

                                               quest:
                                                 phases:
                                                   - path: mod\MOD_NAME\quest\MOD_NAME_root.questphase
                                                     parent: cyberpunk2077.quest
                                               journal:
                                                 - mod\MOD_NAME\journal\MOD_NAME.journal
                                               localization:
                                                 onscreens:
                                                   en-us: mod\MOD_NAME\localization\en-us\onscreens\MOD_NAME.json

                                               """;

    private void CreateArchiveXlFile(QuestGenerationOptions options)
    {
        if (_projectManager.ActiveProject?.ResourcesDirectory is not string resourcesDir)
        {
            _loggerService.Error("Active project or its resources directory is null. Cannot create .archive.xl file.");
            return;
        }
        var archiveXlPath = Path.Combine(resourcesDir, $"{options.ModName}.archive.xl");
        if (!File.Exists(archiveXlPath))
        {
            File.WriteAllText(archiveXlPath, s_questTemplateYaml.Replace("MOD_NAME", options.ModName));
        }
    }

    public void GeneratePropFiles(AddPropFileDialogViewModel prop)
    {
        if (_projectManager.ActiveProject is not { } project)
        {
            return;
        }

        prop.Appearances ??= [];
        if (prop.Appearances.Count == 0)
        {
            prop.Appearances.Add("default");
        }

        prop.Appearances = prop.Appearances.Select(x => x.ToFileName()).ToList();

        var hasSingleAppearance = prop.Appearances.All(f => f == "default");


        var absoluteParentFolder = Path.Combine(project.ModDirectory, prop.ParentFolder);
        Directory.CreateDirectory(absoluteParentFolder);

        var propFolderName = prop.PropName.ToFileName();
        if (Directory.GetFileSystemEntries(absoluteParentFolder).Length > 0)
        {
            prop.ParentFolder = Path.Combine(prop.ParentFolder, propFolderName);
            absoluteParentFolder = Path.Combine(project.ModDirectory, prop.ParentFolder);
            Directory.CreateDirectory(absoluteParentFolder);
        }


        // generate .ent file

        var entFilePath = Path.Combine(prop.ParentFolder, $"{propFolderName}.ent");
        var appFilePath = Path.Combine(prop.ParentFolder, $"{propFolderName}.app");

        var meshFilesUseAppearances = prop.GetMeshFileData();

        PrepareMeshes();

        GenerateEntFile();
        GenerateAppFile();
        WriteLuaFile();
        WriteWorldbuilderFile();

        project.DeleteEmptyFolders(_loggerService);
        return;

        void PrepareMeshes()
        {
            // if they aren't in the correct directory, move them and adjust list
            Dictionary<string, bool> meshFileAppearances = [];
            foreach (var kvp in meshFilesUseAppearances)
            {
                if (Path.GetDirectoryName(kvp.Key)?.EndsWith(propFolderName) == true)
                {
                    meshFileAppearances[kvp.Key] = kvp.Value;
                    continue;
                }

                var relativePath = Path.Combine(prop.ParentFolder, Path.GetFileName(kvp.Key));
                if (!project.ModFiles.Contains(kvp.Key))
                {
                    // try get from game files
                    _archiveManager.GetGameFile(kvp.Key);
                }

                if (project.ModFiles.Contains(kvp.Key))
                {
                    _projectResourceTools.MoveAndRefactorAsync(
                            Path.Combine(project.ModDirectory, kvp.Key),
                            Path.Combine(project.ModDirectory, relativePath),
                            "",
                            false).GetAwaiter()
                        .GetResult();
                }
                else
                {
                }

                meshFileAppearances[relativePath] = kvp.Value;
            }

            meshFilesUseAppearances = meshFileAppearances;

            // If they should use appearances, set them now
            foreach (var kvp in meshFilesUseAppearances.Where(kvp => kvp.Value))
            {
                ApplyMeshAppearances(kvp.Key);
            }
        }

        void ApplyMeshAppearances(string relativePath)
        {
            if (!project.ModFiles.Contains(relativePath))
            {
                _loggerService.Info(
                    $"Mesh file not found in project resources. Can't apply appearances: {relativePath}");
                return;
            }

            var absolutePath = Path.Combine(project.ModDirectory, relativePath);
            if (_cr2WTools.ReadCr2W(absolutePath) is not { RootChunk: CMesh mesh })
            {
                _loggerService.Info($"Failed to read mesh file. Can't apply appearances: {relativePath}");
                return;
            }

            // Make sure that first appearance is defined, as we're gonna copy that one for all consecutive appearances
            var firstAppearance = mesh.Appearances.Count > 0
                ? mesh.Appearances[0]
                : new CHandle<meshMeshAppearance>()
                {
                    Chunk = new meshMeshAppearance()
                    {
                        Name = prop.Appearances[0],
                        ChunkMaterials = new CArray<CName>([
                            prop.Appearances[0],
                            prop.Appearances[0],
                            prop.Appearances[0]
                        ])
                    }
                };

            List<CHandle<meshMeshAppearance>?> newAppearances = [];

            for (var i = 0; i < prop.Appearances.Count; i++)
            {
                var meshAppearance = mesh.Appearances.Count > i
                    ? mesh.Appearances[i]
                    : new CHandle<meshMeshAppearance>();

                meshAppearance.Chunk ??= new meshMeshAppearance();
                meshAppearance.Chunk.Name = prop.Appearances[i];

                // make sure it has materials
                if (meshAppearance.Chunk.ChunkMaterials is null || meshAppearance.Chunk.ChunkMaterials.Count == 0)
                {
                    meshAppearance.Chunk.ChunkMaterials =
                        new CArray<CName>(firstAppearance.Chunk!.ChunkMaterials.ToList());
                }

                meshAppearance.Chunk.ChunkMaterials = new CArray<CName>(meshAppearance.Chunk.ChunkMaterials
                    .Select(c => c.ToString() ?? prop.Appearances[i])
                    .Select(s => (CName)s.Replace(prop.Appearances[0], prop.Appearances[i]))
                    .ToList());

                // write it back
                newAppearances.Add(meshAppearance);
            }

            mesh.Appearances = new CArray<CHandle<meshMeshAppearance>>(newAppearances);

            // now write it back
            _cr2WTools.WriteCr2W(new CR2WFile() { RootChunk = mesh }, absolutePath);
        }

        void GenerateAppFile()
        {
            if (hasSingleAppearance)
            {
                return;
            }

            var absoluteAppPath = Path.Combine(project.ModDirectory, appFilePath);
            var appTemplate = new appearanceAppearanceResource();
            if (File.Exists(absoluteAppPath) && _cr2WTools.ReadCr2WNoException(absoluteAppPath) is
                    { RootChunk: appearanceAppearanceResource template })
            {
                appTemplate = template;
            }

            appTemplate.Appearances.Clear();

            var components = CreateComponents();
            var adjustMeshAppearancesFor = meshFilesUseAppearances.Where(kvp => kvp.Value).Select(kvp => kvp.Key);

            foreach (var propAppearance in prop.Appearances)
            {
                var appDef = new appearanceAppearanceDefinition() { Name = propAppearance };
                var appComponents = components.Select(entIComponent? (c) =>
                {
                    if (c is IRedMeshComponent mC && mC?.Mesh.DepotPath.GetResolvedText() is string s &&
                        adjustMeshAppearancesFor.Contains(s))
                    {
                        mC.MeshAppearance = propAppearance;
                    }

                    return c;
                }).ToList();

                appDef.Components = new CArray<entIComponent>(appComponents);
                appDef.VisualTags = new redTagList() { Tags = new CArray<CName>(["amm_Prop", "wb_Prop"]) };
                appTemplate.Appearances.Add(new CHandle<appearanceAppearanceDefinition>() { Chunk = appDef });
            }

            _cr2WTools.WriteCr2W(new CR2WFile() { RootChunk = appTemplate }, absoluteAppPath);
        }

        void GenerateEntFile()
        {
            var absoluteEntPath = Path.Combine(project.ModDirectory, entFilePath);
            var entTemplate = new entEntityTemplate();

            if (File.Exists(absoluteEntPath) && _cr2WTools.ReadCr2WNoException(absoluteEntPath) is
                    { RootChunk: entEntityTemplate template })
            {
                entTemplate = template;
            }

            entTemplate.Appearances.Clear();
            entTemplate.Components ??= new CArray<entIComponent>();
            entTemplate.Components.Clear();


            if (hasSingleAppearance)
            {
                entTemplate.Components = new CArray<entIComponent>(CreateComponents());
            }
            else
            {
                foreach (var propAppearance in prop.Appearances)
                {
                    entTemplate.Appearances.Add(new entTemplateAppearance()
                    {
                        Name = propAppearance.ToFileName(),
                        AppearanceName = propAppearance.ToFileName(),
                        AppearanceResource = new CResourceAsyncReference<appearanceAppearanceResource>(appFilePath),
                    });
                }
            }

            entTemplate.Components.Add(new gameTargetingComponent() { Name = "targeting", });

            _cr2WTools.WriteCr2W(new CR2WFile() { RootChunk = entTemplate }, absoluteEntPath);
        }

        List<entIComponent?> CreateComponents()
        {
            List<entIComponent?> ret = [];

            var index = 1;
            foreach (var kvp in meshFilesUseAppearances)
            {
                ret.Add(new entPhysicalMeshComponent()
                {
                    Name = $"amm_prop_slot_{index}", Mesh = new CResourceAsyncReference<CMesh>(kvp.Key)
                });
                index += 1;
            }

            return ret;
        }

        void WriteLuaFile()
        {
            var luaFolderPath = Path.Combine(project.GetResourceCETDirectory(), "..", "AppearanceMenuMod", "Collabs",
                "Custom Props", GetFileOrganizationSubdir());
            var luaPath = Path.Combine(luaFolderPath, $"{project.Name.ToFileName()}.lua");

            var absolutePath = Path.Combine(project.ResourcesDirectory, luaPath);
            if (!File.Exists(absolutePath))
            {
                Directory.CreateDirectory(luaFolderPath);
                File.WriteAllText(absolutePath,
                    s_luaPropFileTemplate.Replace("MODDER_NAME", project.Author)
                        .Replace("PROJECT_NAME", project.Name.ToFileName()));
            }

            List<string> propFileData =
            [
                "    {",
                $"      name: \"{prop.PropName}\",",
                $"      path: \"{entFilePath.Replace(@"\", @"\\")}\",",
                "      category: \"Misc\",",
                "      distanceFromGround: 1,",
            ];
            if (!hasSingleAppearance)
            {
                propFileData.Add("      appearances: {\n");
                propFileData.AddRange(prop.Appearances.Select(propAppearance => $"        \"{propAppearance}\""));
                propFileData.Add("      },");
            }

            propFileData.Add("    },");

            var fileContent = File.ReadAllLines(absolutePath).ToList();
            var propLineIndex =
                fileContent.IndexOf(fileContent.FirstOrDefault(l => l.Contains("props = ")) ?? "INVALID_STRING");
            if (propLineIndex <= 0)
            {
                return;
            }

            fileContent.AddRange(propFileData, propLineIndex + 1);
            File.WriteAllLines(absolutePath, fileContent);
        }

        void WriteWorldbuilderFile()
        {
            var entspawnerSubdir = Path.Combine(project.GetResourceCETDirectory(), "..", "entSpawner", "data");

            if (meshFilesUseAppearances.Count == 1)
            {
                var entspawnerMeshDir = Path.Combine(entspawnerSubdir, "spawnables", "mesh", "all",
                    GetFileOrganizationSubdir());
                var entspawnerMeshFile = Path.Combine(entspawnerMeshDir, project.Name.ToFileName() + ".txt");
                var absolutePath = Path.Combine(project.ResourcesDirectory, entspawnerMeshFile);

                Directory.CreateDirectory(Path.Combine(project.ResourcesDirectory, entspawnerMeshDir));

                if (!File.Exists(absolutePath))
                {
                    File.WriteAllText(absolutePath, "");
                }

                File.AppendAllLines(absolutePath, [meshFilesUseAppearances.Keys.First()]);


                return;
            }

            var entspawnerEntFile =
                Path.Combine(entspawnerSubdir, GetFileOrganizationSubdir(), project.Name.ToFileName() + ".txt");
            var absoluteEntPath = Path.Combine(project.ResourcesDirectory, entspawnerEntFile);
            if (!File.Exists(absoluteEntPath))
            {
                Directory.CreateDirectory(Path.Combine(project.ResourcesDirectory, entspawnerSubdir,
                    GetFileOrganizationSubdir()));
                File.WriteAllText(absoluteEntPath, "");
            }

            File.AppendAllLines(absoluteEntPath, [entFilePath]);
        }
    }

    private const string s_luaPropFileTemplate = """
                                                 -- This file was autogenerated with WolvenKit. Yay!
                                                 return {

                                                   modder = "MODDER_NAME",

                                                   unique_identifier = "PROJECT_NAME",

                                                   props = {
                                                   }
                                                 }

                                                 """;

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

public class QuestGenerationOptions
{
    public string ModName { get; set; } = "modname";
    public string TargetRoot { get; set; } = string.Empty; // e.g., path to "archive/mod"
    public string ModderName { get; init; } = "";
}
