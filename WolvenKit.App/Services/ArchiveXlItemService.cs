using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using YamlDotNet.RepresentationModel;
using ArchiveXlHelper = WolvenKit.Modkit.Resources.ArchiveXlHelper;

namespace WolvenKit.App.Services;

/// <summary>
/// Created by <see cref="WolvenKit.App.ViewModels.Dialogs.AddArchiveXlFilesDialogViewModel"/>
/// </summary>
public class ArchiveXlClothingItem
{
    public string ItemName { get; init; } = string.Empty;
    public EquipmentItemSlot Slot { get; init; } = EquipmentItemSlot.None;
    public EquipmentItemSubSlot SubSlot { get; init; } = EquipmentItemSubSlot.None;
    public EquipmentExSlot EqExSlot { get; init; } = EquipmentExSlot.None;
    public bool TagsHideInFpp { get; init; }
    public bool TagsForceHair { get; init; }

    /// <summary>
    /// Size tag (<see cref="GarmentSupportTag"/>)
    /// </summary>
    public GarmentSupportTags GarmentSupportTag { get; init; }

    public List<ArchiveXlHidingTags> HidingTags { get; init; } = [];

    /// <summary>
    /// modderName/equipment/slot/projectName
    /// </summary>
    /// <example><code>
    /// tutorial/equipment/head/paper_bag
    /// </code></example>
    public string FilesRelPath { get; set; } = string.Empty;

    /// <summary>
    /// Re-uses the path of the first .csv in project. Otherwise, will write to modderName/projectName
    /// </summary>
    /// <example><code>
    /// tutorial/paper_bag
    /// </code></example>
    public string ControlFilesRelPath { get; set; } = string.Empty;

    public string TranslationFileRelPath { get; set; } = string.Empty;

    public string RootEntityPath { get; set; } = string.Empty;
    public string MeshEntityPath { get; set; } = string.Empty;
    public string AppFilePath { get; set; } = string.Empty;
    public string FactoryFilePath { get; set; } = string.Empty;
    public string XlFilePath { get; set; } = string.Empty;
    public string YamlFilePath { get; set; } = string.Empty;
    public string InkatlasPath { get; set; } = string.Empty;

    /// <summary>
    /// Variants for dynamic appearances, e.g. [black, white, red]
    /// </summary>
    public List<string> Variants { get; init; } = [];

    /// <summary>
    /// Secondary variants for dynamic appearances, e.g. [samurai, witcher, galaxy]
    /// </summary>
    public List<string> SecondaryVariants { get; init; } = [];

    public bool IsAddMeshMaterials { get; init; }


    public static readonly YamlSequenceNode StatModifiers = new(
        new YamlScalarNode("!append Quality.IconicItem"),
        new YamlScalarNode("!append Character.ScaleToPlayerLevel")
    );

    // Build statModifierGroups sequence
    public static readonly YamlSequenceNode StatModifierGroups = new(
        new YamlScalarNode("!append-once Items.IconicQualityRandomization")
    );

    public string[] GetAllVariants()
    {
        if (SecondaryVariants.Count == 0)
        {
            return [.. Variants];
        }

        return
        [
            .. Variants.SelectMany(variant =>
                SecondaryVariants.Select(secondary => $"{variant}_{secondary}"))
        ];
    }
}

public class ArchiveXlItemService
{
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly IAppArchiveManager _archiveManager;
    private readonly ProjectResourceTools _projectResourceTools;
    private readonly ILoggerService _logger;
    private readonly Cr2WTools _cr2WTools;

    public ArchiveXlItemService(
        ISettingsManager settingsManager,
        IProjectManager projectManager,
        Cr2WTools cr2WTools,
        IAppArchiveManager archiveManager,
        ProjectResourceTools projectResourceTools,
        ILoggerService logger
    )
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _cr2WTools = cr2WTools;
        _logger = logger;
        _archiveManager = archiveManager;
        _projectResourceTools = projectResourceTools;
    }

    /// gets modder name from project or settings
    private string GetModderName()
    {
        if (!string.IsNullOrEmpty(_projectManager.ActiveProject?.Author))
        {
            return _projectManager.ActiveProject.Author;
        }

        return _settingsManager.ModderName ?? "wolvenkit_user";
    }

    public void CreateEquipmentItem(ArchiveXlClothingItem clothingItemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            throw new WolvenKitException(0x4003, "You need a Wolvenkit project to use this feature");
        }

        var projectFiles = activeProject.ModFiles.ToList();

        SetPathsAndCreateDirectories(clothingItemData, activeProject);

        AddRootEntity(clothingItemData, activeProject);

        RegisterInFactory(clothingItemData, activeProject);

        RegisterInXlFile(clothingItemData, activeProject);

        CreatePlaceholderIcons(clothingItemData, activeProject);

        AddMeshEntity(clothingItemData, activeProject);

        AddAppFile(clothingItemData, activeProject);

        CreateYamlEntry(clothingItemData, activeProject);

        RegisterInTranslationFile(clothingItemData, activeProject);

        var newFiles = activeProject.ModFiles.Where(f => !projectFiles.Contains(f)).ToList();
        if (newFiles.Count == 0)
        {
            _logger.Success($"Your ArchiveXL item {clothingItemData.ItemName} has been updated.");
            return;
        }

        _logger.Success($"Your ArchiveXL item for {clothingItemData.Slot} has been created.");
        _logger.Success($"The following files were added:\n\t{string.Join("\n\t", newFiles)}");
        _logger.Success($"You can learn more about this process here:\n\t{WikiLinks.AddingNewItems}");

    }

    /// <summary>
    /// Sets default paths in itemData and creates folders if necessary.
    /// </summary>
    private void SetPathsAndCreateDirectories(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {

        // Items go into moddername/equipment/itemdataslot/projectname
        clothingItemData.FilesRelPath = Path.Join(
            GetModderName(),
            "equipment",
            clothingItemData.Slot.ToString().Replace("outer_", "").Replace("inner_", ""),
            clothingItemData.ItemName
        ).ToFilePath();

        // Control files go into the folder of any existing csv file in the project, or the default path
        clothingItemData.ControlFilesRelPath =
            activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).Select(Path.GetDirectoryName).FirstOrDefault()
            ?? Path.Join(GetModderName(), activeProject.ModName, clothingItemData.ItemName).ToFilePath();


        // Now write paths into the item data
        clothingItemData.RootEntityPath = Path.Combine(clothingItemData.ControlFilesRelPath,
            $"_root_entity.ent".ToFileName());
        if (activeProject.ModFiles.FirstOrDefault(f => f.EndsWith("_root_entity.ent")) is string existingRoot)
        {
            clothingItemData.RootEntityPath = existingRoot;
        }

        clothingItemData.AppFilePath = Path.Combine(clothingItemData.ControlFilesRelPath,
            $"_application.app".ToFileName());
        if (activeProject.ModFiles.FirstOrDefault(f => f.EndsWith("_application.app")) is string existingApp)
        {
            clothingItemData.AppFilePath = existingApp;
        }

        clothingItemData.MeshEntityPath = Path.Combine(clothingItemData.ControlFilesRelPath,
            $"_{clothingItemData.ItemName}_mesh_entity.ent".ToFileName());

        clothingItemData.InkatlasPath = Path.Combine(clothingItemData.ControlFilesRelPath,
            $"{clothingItemData.ItemName}_icons.inkatlas");

        // If we have more than one .yaml file under resources, create a new one, otherwise append
        var yamlFiles = activeProject.ResourceFiles.Where(f => f.HasFileExtension("yaml")).ToList();
        if (yamlFiles.Count == 1)
        {
            clothingItemData.YamlFilePath = yamlFiles.First();
        }
        else
        {
            clothingItemData.YamlFilePath = Path.Join(
                activeProject.GetRelativeResourceTweakDirectory(),
                $"{activeProject.ModName}.yaml"
            ).ToFilePath();
        }

        if (activeProject.ModFiles.Where(p => p.HasFileExtension(".json")).ToList() is { Count: 1 } list)
        {
            clothingItemData.TranslationFileRelPath = list.First();
        }
        else
        {
            clothingItemData.TranslationFileRelPath =
                Path.Combine(clothingItemData.ControlFilesRelPath, "i18n", "en_us.json");
        }

        var xlFiles = activeProject.ResourceFiles.Where(f => f.HasFileExtension("xl")).ToList();
        if (xlFiles.Count == 1)
        {
            clothingItemData.XlFilePath = xlFiles.First();
        }
        else
        {
            clothingItemData.XlFilePath = Path.Join($"{activeProject.ModName}.archive.xl").ToFilePath();
        }

        var relativeFactoryPath = Path.Combine(clothingItemData.ControlFilesRelPath, "factory.csv");
        if (activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).ToList() is { Count: 1 } l)
        {
            relativeFactoryPath = l.First();
        }

        clothingItemData.FactoryFilePath = relativeFactoryPath;


        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, clothingItemData.FilesRelPath));
        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, clothingItemData.ControlFilesRelPath));

        if (Path.GetDirectoryName(clothingItemData.YamlFilePath) is string parentPath)
        {
            Directory.CreateDirectory(Path.Combine(activeProject.ResourcesDirectory, parentPath));
        }
    }

    /// <summary>
    /// If necessary, adds .csv and .json file to the generated .xl file.
    /// </summary>
    private void RegisterInXlFile(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var xlFileAbsPath = Path.Join(activeProject.ResourcesDirectory, clothingItemData.XlFilePath);
        var xlFileContent = YamlHelper.ReadYamlAsNodes(xlFileAbsPath) ?? new YamlMappingNode();

        /*
         * Make sure the factory exists
         */

        if (xlFileContent.Children.TryGetValue("factories", out var facNode) && facNode is YamlSequenceNode factoryNode)
        {
            if (!factoryNode.Children.Contains(clothingItemData.FactoryFilePath))
            {
                factoryNode.Children.Add(clothingItemData.FactoryFilePath);
            }
        }
        else
        {
            xlFileContent.Children.Add("factories", new YamlSequenceNode() { clothingItemData.FactoryFilePath });
        }

        var onscreensNode = YamlHelper.EnsureNestedMapping(xlFileContent, "localization", "onscreens");
        if (!onscreensNode.Children.TryGetValue("en-us", out var enUsNode) ||
            enUsNode is not YamlSequenceNode enUsSeqNode)
        {
            onscreensNode.Children.Remove("en-us");
            onscreensNode.Children.Add("en-us", new YamlSequenceNode() { clothingItemData.TranslationFileRelPath });
        }
        else
        {
            if (enUsSeqNode.Children.All(n => n.ToString() != clothingItemData.TranslationFileRelPath))
            {
                enUsSeqNode.Children.Add(clothingItemData.TranslationFileRelPath);
            }
        }
        YamlHelper.WriteYaml(xlFileAbsPath, xlFileContent);
    }

    /// <summary>
    /// Creates .csv factory file if it doesn't exist, or re-uses existing one (if exactly one file exists).
    /// Will add factory entry mapping (entityName => rootFilePath) if it doesn't exist yet.
    /// </summary>
    private void RegisterInFactory(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var absoluteFactoryPath = Path.Combine(activeProject.ModDirectory, clothingItemData.FactoryFilePath);

        // check if factory file exists in project folder, create if not
        var cr2W = _cr2WTools.ReadCr2WNoException(absoluteFactoryPath) ??
                   new CR2WFile()
                   {
                       RootChunk = new C2dArray()
                       {
                           Headers = ["name", "path", "preload"], CompiledHeaders = ["name", "path", "preload"]
                       }
                   };

        var itemName = $"{clothingItemData.ItemName}_factory_name";

        if (cr2W.RootChunk is not C2dArray factory)
        {
            _logger.Error(string.Join(",\n\t", [
                $"Failed when adding to factory {clothingItemData.FactoryFilePath}. Add an entry to CompiledData by hand:",
                $"[0] = {itemName}",
                $"[1] = {clothingItemData.RootEntityPath}",
                $"[2] = true"
            ]));
            return;
        }

        if (factory.CompiledData.Any(item => item.Count > 0 && item[0].GetString() == itemName))
        {
            _logger.Info($"Factory entry for {itemName} already exists.");
            return;
        }

        factory.CompiledData.Add(new CArray<CString>([
            itemName, // name
            clothingItemData.RootEntityPath, // path
            "true" // preload
        ]));

        // write factory back
        _cr2WTools.WriteCr2W(cr2W, absoluteFactoryPath);

    }

    /// <summary>
    /// Creates translation file entries generated from description, display name and variants.
    /// Will re-use existing i18n file if it exists - entries will be appended, but not overwritten.
    /// </summary>
    private void RegisterInTranslationFile(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var absPath = Path.Combine(activeProject.ModDirectory, clothingItemData.TranslationFileRelPath);

        var cr2W = new CR2WFile()
        {
            RootChunk = new JsonResource()
            {
                Root = new CHandle<ISerializable>() { Chunk = new localizationPersistenceOnScreenEntries() }
            }
        };

        if (File.Exists(absPath) && _cr2WTools.ReadCr2W(absPath) is CR2WFile f)
        {
            cr2W = f;
        }

        if (cr2W.RootChunk is not JsonResource json ||
            json.Root.Chunk is not localizationPersistenceOnScreenEntries locEntries)
        {
            _logger.Error($"Failed to open or create translation file {clothingItemData.TranslationFileRelPath}");
            return;
        }

        var displayName = $"{clothingItemData.ItemName}_i18n_$(base_color)";
        if (clothingItemData.SecondaryVariants.Count > 0)
        {
            displayName = $"{displayName}_$(secondary)";
        }
        var description = $"{clothingItemData.ItemName}_i18n_desc";

        var entryList = locEntries.Entries.ToList();

        if (entryList.All(e => e.SecondaryKey != description))
        {
            entryList.Add(new localizationPersistenceOnScreenEntry()
            {
                SecondaryKey = description,
                FemaleVariant = $"{clothingItemData.ItemName} description".ToHumanFriendlyString(),
            });
        }

        foreach (var variant in clothingItemData.Variants)
        {
            var translationString = displayName.Replace("$(base_color)", variant);
            if (clothingItemData.SecondaryVariants.Count > 0)
            {
                foreach (var secondary in clothingItemData.SecondaryVariants)
                {
                    var translationString2 = translationString.Replace("$(secondary)", secondary);
                    if (entryList.All(e => e.SecondaryKey != translationString2))
                    {
                        entryList.Add(new localizationPersistenceOnScreenEntry()
                        {
                            SecondaryKey = translationString2,
                            FemaleVariant = $"{clothingItemData.ItemName} ({variant} {secondary})"
                                .ToHumanFriendlyString(),
                        });
                    }
                }
            }
            else
            {
                if (entryList.All(e => e.SecondaryKey != translationString))
                {
                    entryList.Add(new localizationPersistenceOnScreenEntry()
                    {
                        SecondaryKey = translationString,
                        FemaleVariant = $"{clothingItemData.ItemName} ({variant})".ToHumanFriendlyString(),
                    });
                }
            }

        }

        locEntries.Entries.Clear();
        foreach (var entry in entryList)
        {
            locEntries.Entries.Add(entry);
        }

        _cr2WTools.WriteCr2W(cr2W, absPath);

    }

    /// <summary>
    /// Creates an inkatlas with a dummy icon for each variant. Will do nothing if file exists.
    /// </summary>
    private void CreatePlaceholderIcons(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var absoluteInkatlasPath = Path.Combine(activeProject.ModDirectory, clothingItemData.InkatlasPath);

        if (File.Exists(absoluteInkatlasPath) && _cr2WTools.ReadCr2WNoException(absoluteInkatlasPath) is not null)
        {
            _logger.Warning($"Inkatlas {clothingItemData.InkatlasPath} already exists, refusing to overwrite.");
            _logger.Info($"Delete it or run Files -> Add Files -> Generate Inkatlas");
        }

        var tempFolder = Path.Combine(Path.GetTempPath(), $"iconImages_{clothingItemData.ItemName}");

        InkatlasImageGenerator.GenerateDummyIcons(tempFolder, $"{clothingItemData.ItemName}_",
            clothingItemData.GetAllVariants());

        InkatlasImageGenerator.GenerateAtlas(
            tempFolder,
            Path.GetDirectoryName(clothingItemData.InkatlasPath)!,
            Path.GetFileName(clothingItemData.InkatlasPath),
            160,
            160,
            _cr2WTools,
            activeProject
        );
    }

    /// <summary>
    /// Creates mesh entity from base game files, adds tags, reads mesh files from component paths
    /// and adds them to project, then adjusts/creates mesh file appearances to match variants
    /// </summary>
    private void AddMeshEntity(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var meshEntityAbsPath = Path.Combine(activeProject.ModDirectory, clothingItemData.MeshEntityPath);
        CR2WFile? cr2W = null;

        if (File.Exists(meshEntityAbsPath) && _cr2WTools.ReadCr2W(meshEntityAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (EquipmentItemData.FilesBySubType.TryGetValue(clothingItemData.SubSlot, out var meshEntityPath) &&
                 _archiveManager.GetCR2WFile(meshEntityPath) is
                     CR2WFile f2)
        {
            ((entEntityTemplate)f2.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f2;
        }
        else if (EquipmentItemData.FilesByType.TryGetValue(clothingItemData.Slot, out var defaultFilePath) &&
                 _archiveManager.GetCR2WFile(defaultFilePath) is
                     CR2WFile f3)
        {
            ((entEntityTemplate)f3.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f3;
        }

        if (cr2W?.RootChunk is not entEntityTemplate entTemplate)
        {
            _logger.Error($"Failed to open or create mesh entity {clothingItemData.MeshEntityPath}");
            return;
        }

        var relativeMeshFolder = Path.Combine(clothingItemData.FilesRelPath, "meshes");
        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, relativeMeshFolder));

        var useSecondary = clothingItemData.SecondaryVariants.Count > 0;

        foreach (var entComponent in entTemplate.Components.OfType<IRedMeshComponent>())
        {
            // remove "pwa" from component name, it confuses people
            entComponent.Name = (entComponent.Name.GetResolvedText() ?? "").Replace("pwa_", "").Replace("_pwa", "");

            var filePath = entComponent.Mesh.DepotPath.GetResolvedText();
            if (string.IsNullOrEmpty(filePath))
            {
                _logger.Warning($"Failed to read depot path for {entComponent.Name}, skipping...");
                continue;
            }

            if (filePath.StartsWith('*'))
            {
                _logger.Info($"Depot path for {entComponent.Name} is already dynamic. Skipping...");
                continue;
            }

            var isSecondaryComponent = IsSecondaryComponent(entComponent.Name!);
            var pathInMod = Path.Combine(relativeMeshFolder, Path.GetFileName(filePath));

            AddMeshFilesToProject(filePath, pathInMod, isSecondaryComponent);

            var dynamicPath = WolvenKit.Modkit.Resources.ArchiveXlHelper.MakeDynamic(pathInMod);
            var hasSubstitution = ArchiveXlHelper.HasSubstitution(dynamicPath);

            entComponent.Mesh =
                new CResourceAsyncReference<CMesh>(dynamicPath,
                    hasSubstitution ? InternalEnums.EImportFlags.Soft : InternalEnums.EImportFlags.Default);
            entComponent.MeshAppearance = "*{variant}";

            if (!useSecondary)
            {
                continue;
            }

            if (isSecondaryComponent)
            {
                entComponent.MeshAppearance = "*{variant.2}";
            }
            else
            {
                entComponent.MeshAppearance = "*{variant.1}";
            }
        }

        // Garment support tags (size)
        var tags = entTemplate.VisualTagsSchema.Chunk ?? new entVisualTagsSchema();
        var tagsArray = tags.VisualTags.Tags;

        if (clothingItemData.GarmentSupportTag is not GarmentSupportTags.None &&
            !tagsArray.Contains(clothingItemData.GarmentSupportTag.ToString()))
        {
            tagsArray.Add(clothingItemData.GarmentSupportTag.ToString());
        }

        tags.VisualTags.Tags = tagsArray;
        _cr2WTools.WriteCr2W(cr2W, meshEntityAbsPath);

        return;

        bool IsSecondaryComponent(string componentName) =>
            componentName.Contains("_dec", StringComparison.OrdinalIgnoreCase) ||
            componentName.Contains("_cuff", StringComparison.OrdinalIgnoreCase) ||
            componentName.Contains("_patch", StringComparison.OrdinalIgnoreCase);
        /*
         * Adds mesh files from .ent components to project. Will try to find pma/_ma mesh (entity is pwa/_wa).
         * Will not overwrite existing files.
         */
        void AddMeshFilesToProject(string filePath, string pathInMod, bool isSecondaryComponent = false)
        {
            var textureDirPath = Path.Combine(clothingItemData.FilesRelPath, "textures");
            if (_archiveManager.GetCR2WFile(filePath) is { RootChunk: CMesh mesh } componentMesh)
            {
                var destPath = Path.Combine(activeProject.ModDirectory, pathInMod);
                if (File.Exists(destPath))
                {
                    _logger.Info($"Mesh {pathInMod} exists, not overwriting.");
                    return;
                }

                if (pathInMod.Contains("_pwa"))
                {
                    AdjustMeshAppearances(mesh, isSecondaryComponent);
                }

                if (clothingItemData.IsAddMeshMaterials)
                {
                    _projectResourceTools.AddDependenciesToProject(componentMesh, textureDirPath).GetAwaiter()
                        .GetResult();
                }

                _cr2WTools.WriteCr2W(componentMesh, destPath);
            }

            var otherGenderSourcePath = filePath.Replace("pwa", "pma").Replace("_wa_", "_ma_");
            var otherGenderDestPath = pathInMod.Replace("pwa", "pma").Replace("_wa_", "_ma_");

            if (_archiveManager.GetCR2WFile(otherGenderSourcePath) is not { RootChunk: CMesh mesh2 } otherGenderMesh)
            {
                return;
            }

            var destPath2 = Path.Combine(activeProject.ModDirectory, otherGenderDestPath);
            if (File.Exists(destPath2))
            {
                _logger.Info($"Mesh {otherGenderDestPath} exists, not overwriting.");
                return;
            }


            if (pathInMod.Contains("_pma"))
            {
                AdjustMeshAppearances(mesh2, isSecondaryComponent);
            }


            if (clothingItemData.IsAddMeshMaterials)
            {
                _projectResourceTools.AddDependenciesToProject(otherGenderMesh, textureDirPath).GetAwaiter()
                    .GetResult();
            }

            _cr2WTools.WriteCr2W(otherGenderMesh, destPath2);
        }

        /*
         * Mesh appearances will be renamed to match variants from generator, and created if they don't exist.
         */
        void AdjustMeshAppearances(CMesh mesh, bool isSecondaryComponent = false)
        {
            var entries = isSecondaryComponent ? clothingItemData.SecondaryVariants : clothingItemData.Variants;
            for (var idx = 0; idx < entries.Count; idx++)
            {
                CHandle<meshMeshAppearance> appHandle;
                if (idx < mesh.Appearances.Count)
                {
                    appHandle = mesh.Appearances[idx];
                }
                else
                {
                    appHandle = new CHandle<meshMeshAppearance>();
                }

                appHandle.Chunk ??= new meshMeshAppearance();
                appHandle.Chunk.Name = entries[idx];
            }
        }
    }

    /// <summary>
    /// Creates root entity from base game file and adjusts path and tags
    /// </summary>
    private void AddRootEntity(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var rootEntityAbsPath = Path.Combine(activeProject.ModDirectory, clothingItemData.RootEntityPath);

        CR2WFile? cr2W = null;

        if (File.Exists(rootEntityAbsPath) && _cr2WTools.ReadCr2W(rootEntityAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (_archiveManager.GetCR2WFile(EquipmentItemData.DefaultRootEntityPath) is
                 CR2WFile f2)
        {
            ((entEntityTemplate)f2.RootChunk).Appearances.Clear();
            cr2W = f2;
        }

        if (cr2W?.RootChunk is not entEntityTemplate rootEntity)
        {
            _logger.Error($"Failed to open or create root entity {clothingItemData.RootEntityPath}");
            return;
        }

        var itemName = $"{clothingItemData.ItemName}_";

        var entTemplateAppearance = new entTemplateAppearance();
        var isAdding = true;

        if (rootEntity.Appearances.FirstOrDefault(e => e.Name == itemName) is { } existingAppearance)
        {
            entTemplateAppearance = existingAppearance;
            isAdding = false;
        }

        entTemplateAppearance.Name = itemName;
        entTemplateAppearance.AppearanceName = itemName;
        entTemplateAppearance.AppearanceResource =
            new CResourceAsyncReference<appearanceAppearanceResource>(clothingItemData.AppFilePath);

        if (isAdding)
        {
            rootEntity.Appearances.Add(entTemplateAppearance);
        }

        // Take care of the tags
        rootEntity.VisualTagsSchema ??= new CHandle<entVisualTagsSchema>() { Chunk = new entVisualTagsSchema() };

        var tags = rootEntity.VisualTagsSchema.Chunk ?? new entVisualTagsSchema();
        tags.VisualTags ??= new redTagList();
        var tagsArray = tags.VisualTags.Tags ?? [];

        if (!tagsArray.Contains("DynamicAppearance"))
        {
            tagsArray.Add("DynamicAppearance");
        }

        if (clothingItemData.TagsHideInFpp && !tagsArray.Contains("EmptyAppearance:FPP"))
        {
            tagsArray.Add("EmptyAppearance:FPP");
        }

        if (clothingItemData.TagsForceHair && !tagsArray.Contains("force_Hair"))
        {
            tagsArray.Add("force_Hair");
        }

        tags.VisualTags.Tags = tagsArray;
        _cr2WTools.WriteCr2W(cr2W, rootEntityAbsPath);
    }

    private void AddAppFile(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        var appFileAbsPath = Path.Combine(activeProject.ModDirectory, clothingItemData.AppFilePath);
        CR2WFile? cr2W = null;

        if (File.Exists(appFileAbsPath) && _cr2WTools.ReadCr2W(appFileAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (_archiveManager.GetCR2WFile(EquipmentItemData.DefaultAppFilePath) is
                 CR2WFile f2)
        {
            ((appearanceAppearanceResource)f2.RootChunk).Appearances.Clear();
            cr2W = f2;
        }

        if (cr2W?.RootChunk is not appearanceAppearanceResource app)
        {
            _logger.Error($"Failed to open or create .app file {clothingItemData.AppFilePath}");
            return;
        }

        var appearanceName = $"{clothingItemData.ItemName}_";
        var appAppearance = new appearanceAppearanceDefinition();
        var appHandle = new CHandle<appearanceAppearanceDefinition>(appAppearance);
        var isAdding = true;

        if (app.Appearances.FirstOrDefault(a =>
                a.Chunk?.Name == appearanceName) is CHandle<appearanceAppearanceDefinition> existingHandle)
        {
            existingHandle.Chunk ??= appAppearance;
            appHandle = existingHandle;
            appAppearance = existingHandle.Chunk ?? appAppearance;
            isAdding = false;
        }

        CArray<CName> tags = [.. clothingItemData.HidingTags.Select(t => (CName)t.ToString()).ToArray()];

        appAppearance.Name = $"{clothingItemData.ItemName}_";
        appAppearance.PartsValues = new CArray<appearanceAppearancePart>([
            new appearanceAppearancePart()
            {
                Resource = new CResourceAsyncReference<entEntityTemplate>(
                    (ResourcePath)clothingItemData.MeshEntityPath, InternalEnums.EImportFlags.Soft),
            }
        ]);
        appAppearance.VisualTags = new redTagList() { Tags = tags };

        if (isAdding)
        {
            app.Appearances.Add(appHandle);
        }

        _cr2WTools.WriteCr2W(cr2W, appFileAbsPath);
    }

    /// <summary>
    /// Generates yaml entry and writes it to file
    /// </summary>
    private void CreateYamlEntry(ArchiveXlClothingItem clothingItemData, Cp77Project activeProject)
    {
        if (!EquipmentItemData.EquipmentItemSlotNames.TryGetValue(clothingItemData.Slot, out var itemBase) ||
            string.IsNullOrEmpty(itemBase))
        {
            _logger.Error($"Failed to find item base for {clothingItemData.Slot}. Not creating .yaml entry.");
            return;
        }

        if (clothingItemData.SubSlot is not EquipmentItemSubSlot.None)
        {
            itemBase = $"Items.{clothingItemData.SubSlot}";
        }

        var yamlAbsPath = Path.Combine(activeProject.ResourcesDirectory, clothingItemData.YamlFilePath);

        var itemName = $"Items.{_settingsManager.ModderName}_{clothingItemData.ItemName}_$(base_color)";
        var atlasPathName = $"{clothingItemData.ItemName}_$(base_color)";
        var instances = new YamlSequenceNode(
            clothingItemData.Variants.Select(color =>
            {
                var node = new YamlMappingNode { { "base_color", color } };
                node.Style = YamlDotNet.Core.Events.MappingStyle.Flow;

                return node;
            }));

        var useSecondary = clothingItemData.SecondaryVariants.Count > 0;
        // Consider secondary variants
        if (useSecondary)
        {
            itemName = $"{itemName}_$(secondary)";
            atlasPathName = $"{atlasPathName}_$(secondary)";
            instances = new YamlSequenceNode(
                clothingItemData.Variants.SelectMany(color =>
                {
                    return clothingItemData.SecondaryVariants.Select(variant =>
                    {
                        var node = new YamlMappingNode { { "base_color", color }, { "secondary", variant } };
                        node.Style = YamlDotNet.Core.Events.MappingStyle.Flow;

                        return node;
                    });
                }));
        }

        var icon = new YamlMappingNode
        {
            { "atlasResourcePath", clothingItemData.InkatlasPath }, { "atlasPartName", $"{atlasPathName}" }
        };

        var yamlData = new YamlMappingNode();
        var yaml = new YamlMappingNode() { { itemName, yamlData } };

        if (YamlHelper.ReadYamlAsNodes(yamlAbsPath) is { } yamlFromFile)
        {
            if (yamlFromFile.Children.TryGetValue(itemName, out var n) && n is YamlMappingNode nodeFromFile)
            {
                _logger.Warning(
                    $"Yaml file {clothingItemData.YamlFilePath} already contains a definition for {itemName}. Existing properties will not be overwritten.");
                yamlData = nodeFromFile;
            }
        }

        yamlData.Children.TryAdd("$base", itemBase);
        yamlData.Children.TryAdd("$instances", instances);
        yamlData.Children.TryAdd("appearanceName",
            $"{clothingItemData.ItemName}_!$(base_color){(useSecondary ? "+$(secondary)" : string.Empty)}");
        yamlData.Children.TryAdd("entityName", $"{clothingItemData.ItemName}_factory_name");
        yamlData.Children.TryAdd("localizedDescription", $"LocKey#{clothingItemData.ItemName}_i18n_desc");
        yamlData.Children.TryAdd("displayName",
            $"LocKey#{clothingItemData.ItemName}_i18n_$(base_color){(useSecondary ? "_$(secondary)" : string.Empty)}");
        yamlData.Children.TryAdd("quality", "Quality.Legendary");
        yamlData.Children.TryAdd("icon", icon);
        yamlData.Children.TryAdd("statModifiers", ArchiveXlClothingItem.StatModifiers);
        yamlData.Children.TryAdd("appearanceSuffixes", "[]");
        yamlData.Children.TryAdd("statModifierGroups", ArchiveXlClothingItem.StatModifierGroups);

        if (clothingItemData.EqExSlot is not EquipmentExSlot.None)
        {
            yamlData.Children.TryAdd("placementSlots", $"OutfitSlots.{clothingItemData.EqExSlot}");
        }

        var comment = clothingItemData.Variants.SelectMany(color =>
            (clothingItemData.SecondaryVariants.Count > 0 ? clothingItemData.SecondaryVariants : [""])
            .Select(var => itemName.Replace("$(base_color)", color).Replace("$(secondary)", var))
            ).Select(s => $"Game.AddToInventory(\"{s}\")")
            .ToArray();

        YamlHelper.RemoveInExistingFileAndAppend(yamlAbsPath, itemName, yaml, comment);
    }
}
