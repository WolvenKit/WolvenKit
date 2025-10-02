using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.Services;

/// <summary>
/// Created by <see cref="WolvenKit.App.ViewModels.Dialogs.AddArchiveXlFilesDialogViewModel"/>
/// </summary>
public class ArchiveXlItem
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

    public bool IsAddMeshMaterials { get; set; }

    public static readonly string DefaultAppFilePath =
        @"base\gameplay\items\equipment\underwear\appearances\player_underwear_item_appearances.app";

    public static readonly string DefaultRootEntityPath =
        @"base\gameplay\items\equipment\underwear\player_underwear_item.ent";

    public static readonly Dictionary<EquipmentItemSlot, string> FilesByType = new()
    {
        { EquipmentItemSlot.Face, @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent" },
        { EquipmentItemSlot.Head, @"base\characters\garment\player_equipment\head\h2_011_pwa_helmet__riot.ent" },
        { EquipmentItemSlot.Legs, @"base\characters\garment\player_equipment\legs\l1_070_pwa_pants__loose.ent" },
        {
            EquipmentItemSlot.Torso_Inner,
            @"base\characters\garment\player_equipment\torso\t1_079_pwa_tshirt__casual.ent"
        },
        { EquipmentItemSlot.Torso_Outer, @"base\characters\garment\player_equipment\torso\t2_002_pwa_vest__puffy.ent" },
        { EquipmentItemSlot.Outfit, @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug.ent" },
    };

    public static readonly Dictionary<EquipmentItemSubSlot, string> FilesBySubType = new()
    {
        // head
        { EquipmentItemSubSlot.Cap, @"base\characters\garment\player_equipment\head\h1_002_pwa_hat__headcap.ent" },
        { EquipmentItemSubSlot.Hat, @"base\characters\garment\player_equipment\head\h1_032_pwa_hat__asian.ent" },
        { EquipmentItemSubSlot.Mask, @"base\characters\garment\player_equipment\head\h1_056_pwa_mask__samurai.ent" },
        {
            EquipmentItemSubSlot.Glasses, @"base\characters\garment\player_equipment\head\h1_038_pwa_specs__classic.ent"
        },
        {
            EquipmentItemSubSlot.Tech,
            @"base\characters\garment\player_equipment\head\h1_052_pwa_specs__tactical_01.ent"
        },
        {
            EquipmentItemSubSlot.Visor,
            @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent"
        },

        // torso
        { EquipmentItemSubSlot.Dress, @"base\characters\garment\player_equipment\torso\t2_014_pwa_dress__chic.ent" },
        {
            EquipmentItemSubSlot.Undershirt,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug_tight.ent"
        },
        { EquipmentItemSubSlot.TankTop, @"base\characters\garment\player_equipment\torso\t1_071_pwa_tank__basic.ent" },
        {
            EquipmentItemSubSlot.Jumpsuit,
            @"base\characters\garment\player_equipment\torso\t1_091_pwa_full__jumpsuit.ent"
        },
        {
            EquipmentItemSubSlot.Coat,
            @"base\characters\garment\player_equipment\torso\t2_097_pwa_jacket__holmes_coat.ent"
        },
        {
            EquipmentItemSubSlot.TightJumpsuit,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug.ent"
        },
        // legs
        { EquipmentItemSubSlot.Skirt, @"base\characters\garment\player_equipment\legs\l1_011_pwa_skirt__tight.ent" },
        { EquipmentItemSubSlot.Shorts, @"base\characters\garment\player_equipment\legs\l1_054_pwa_shorts__latino.ent" },
        {
            EquipmentItemSubSlot.FormalPants,
            @"base\characters\garment\player_equipment\legs\l1_045_pwa_pants__suit.ent"
        },
        // feet
        { EquipmentItemSubSlot.Boots, @"base\characters\garment\player_equipment\feet\s1_056_pwa_boot__biker.ent" },
        {
            EquipmentItemSubSlot.CasualShoes,
            @"base\characters\garment\player_equipment\feet\s1_068_pwa_shoe__sneakers.ent"
        },
        {
            EquipmentItemSubSlot.FormalShoes,
            @"base\characters\garment\player_equipment\feet\s1_077_pwa_boot__blackwater.ent"
        },
    };

    public static readonly Dictionary<EquipmentItemSlot, string> EquipmentItemSlotNames = new()
    {
        { EquipmentItemSlot.None, "Items.GenericHeadClothing" },
        { EquipmentItemSlot.Head, "Items.GenericHeadClothing" },
        { EquipmentItemSlot.Face, "Items.GenericFaceClothing" },
        { EquipmentItemSlot.Torso_Inner, "Items.GenericInnerChestClothing" },
        { EquipmentItemSlot.Torso_Outer, "Items.GenericOuterChestClothing" },
        { EquipmentItemSlot.Legs, "Items.GenericLegClothing" },
        { EquipmentItemSlot.Feet, "Items.GenericFootClothing" },
        { EquipmentItemSlot.Outfit, "Items.Outfit" },
    };

    public static readonly YamlSequenceNode StatModifiers = new(
        new YamlScalarNode("!append Quality.IconicItem"),
        new YamlScalarNode("!append Character.ScaleToPlayerLevel")
    );

    // Build statModifierGroups sequence
    public static readonly YamlSequenceNode StatModifierGroups = new(
        new YamlScalarNode("!append-once Items.IconicQualityRandomization")
    );

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

    public void CreateEquipmentItem(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            throw new WolvenKitException(0x4003, "You need a Wolvenkit project to use this feature");
        }

        SetPathsAndCreateDirectories(itemData, activeProject);

        AddRootEntity(itemData, activeProject);

        RegisterInFactory(itemData, activeProject);

        RegisterInXlFile(itemData, activeProject);

        CreatePlaceholderIcons(itemData, activeProject);

        AddMeshEntity(itemData, activeProject);

        AddAppFile(itemData, activeProject);

        CreateYamlEntry(itemData, activeProject);

        RegisterInTranslationFile(itemData, activeProject);
    }

    /// <summary>
    /// Sets default paths in itemData and creates folders if necessary.
    /// </summary>
    private void SetPathsAndCreateDirectories(ArchiveXlItem itemData, Cp77Project activeProject)
    {

        // Items go into moddername/equipment/itemdataslot/projectname
        itemData.FilesRelPath = Path.Join(
            _settingsManager.ModderName,
            "equipment",
            itemData.Slot.ToString().Replace("outer_", "").Replace("inner_", ""),
            itemData.ItemName
        ).ToFilePath();

        // Control files go into the folder of any existing csv file in the project, or the default path
        itemData.ControlFilesRelPath =
            activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).Select(Path.GetDirectoryName).FirstOrDefault()
            ?? Path.Join(_settingsManager.ModderName, activeProject.ModName, itemData.ItemName).ToFilePath();

        // Now write paths into the item data
        itemData.RootEntityPath = Path.Combine(itemData.ControlFilesRelPath, "_root_entity.ent");
        itemData.AppFilePath = Path.Combine(itemData.ControlFilesRelPath, "_application.app");
        itemData.MeshEntityPath = Path.Combine(itemData.ControlFilesRelPath, "_mesh_entity.ent");

        itemData.InkatlasPath = Path.Combine(itemData.ControlFilesRelPath, $"{itemData.ItemName}_icons.inkatlas");

        // If we have more than one .yaml file under resources, create a new one, otherwise append
        var yamlFiles = activeProject.ResourceFiles.Where(f => f.HasFileExtension("yaml")).ToList();
        if (yamlFiles.Count == 1)
        {
            itemData.YamlFilePath = yamlFiles.First();
        }
        else
        {
            itemData.YamlFilePath = Path.Join("r6", "tweaks", _settingsManager.ModderName,
                $"{activeProject.ModName}.yaml").ToFilePath();
        }

        if (activeProject.ModFiles.Where(p => p.HasFileExtension("json")).ToList() is { Count: 1 } list)
        {
            itemData.TranslationFileRelPath = list.First();
        }
        else
        {
            itemData.TranslationFileRelPath = Path.Combine(itemData.ControlFilesRelPath, "i18n", "en_us.json");
        }

        var xlFiles = activeProject.ResourceFiles.Where(f => f.HasFileExtension("xl")).ToList();
        if (xlFiles.Count == 1)
        {
            itemData.XlFilePath = xlFiles.First();
        }
        else
        {
            itemData.XlFilePath = Path.Join($"{activeProject.ModName}.archive.xl").ToFilePath();
        }

        var relativeFactoryPath = Path.Combine(itemData.ControlFilesRelPath, "factory.csv");
        if (activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).ToList() is { Count: 1 } l)
        {
            relativeFactoryPath = l.First();
        }

        itemData.FactoryFilePath = relativeFactoryPath;


        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, itemData.FilesRelPath));
        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, itemData.ControlFilesRelPath));

        if (Path.GetDirectoryName(itemData.YamlFilePath) is string parentPath)
        {
            Directory.CreateDirectory(Path.Combine(activeProject.ResourcesDirectory, parentPath));
        }
    }

    /// <summary>
    /// If necessary, adds .csv and .json file to the generated .xl file.
    /// </summary>
    private void RegisterInXlFile(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var xlFileAbsPath = Path.Join(activeProject.ResourcesDirectory, itemData.XlFilePath);
        var xlFileContent = YamlHelper.ReadYamlAsNodes(xlFileAbsPath) ?? new YamlMappingNode();

        /*
         * Make sure the factory exists
         */

        if (xlFileContent.Children.TryGetValue("factories", out var facNode) && facNode is YamlSequenceNode factoryNode)
        {
            if (!factoryNode.Children.Contains(itemData.FactoryFilePath))
            {
                factoryNode.Children.Add(itemData.FactoryFilePath);
            }
        }
        else
        {
            xlFileContent.Children.Add("factories", new YamlSequenceNode() { itemData.FactoryFilePath });
        }

        var onscreensNode = YamlHelper.EnsureNestedMapping(xlFileContent, "localization", "onscreens");
        if (!onscreensNode.Children.TryGetValue("en-us", out var enUsNode) ||
            enUsNode is not YamlSequenceNode enUsSeqNode)
        {
            onscreensNode.Children.Remove("en-us");
            onscreensNode.Children.Add("en-us", new YamlSequenceNode() { itemData.TranslationFileRelPath });
        }
        else
        {
            if (enUsSeqNode.Children.All(n => n.ToString() != itemData.TranslationFileRelPath))
            {
                enUsSeqNode.Children.Add(itemData.TranslationFileRelPath);
            }
        }
        YamlHelper.WriteYaml(xlFileAbsPath, xlFileContent);
    }

    /// <summary>
    /// Creates .csv factory file if it doesn't exist, or re-uses existing one (if exactly one file exists).
    /// Will add factory entry mapping (entityName => rootFilePath) if it doesn't exist yet.
    /// </summary>
    private void RegisterInFactory(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var absoluteFactoryPath = Path.Combine(activeProject.ModDirectory, itemData.FactoryFilePath);

        // check if factory file exists in project folder, create if not
        var cr2W = _cr2WTools.ReadCr2WNoException(absoluteFactoryPath) ??
                   new CR2WFile() { RootChunk = new C2dArray() { Headers = ["name", "path", "preload"] } };

        var itemName = $"{itemData.ItemName}_factory_name";

        if (cr2W.RootChunk is not C2dArray factory)
        {
            _logger.Error(string.Join(",\n\t", [
                $"Failed when adding to factory {itemData.FactoryFilePath}. Add an entry to CompiledData by hand:",
                $"[0] = {itemName}",
                $"[1] = {itemData.RootEntityPath}",
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
            itemData.RootEntityPath, // path
            "true" // preload
        ]));

        // write factory back
        _cr2WTools.WriteCr2W(cr2W, absoluteFactoryPath);

    }

    /// <summary>
    /// Creates translation file entries generated from description, display name and variants.
    /// Will re-use existing i18n file if it exists - entries will be appended, but not overwritten.
    /// </summary>
    private void RegisterInTranslationFile(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var absPath = Path.Combine(activeProject.ModDirectory, itemData.TranslationFileRelPath);

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
            _logger.Error($"Failed to open or create translation file {itemData.TranslationFileRelPath}");
            return;
        }

        var displayName = $"{itemData.ItemName}_i18n_$(base_color)";
        var description = $"{itemData.ItemName}_i18n_desc";

        var entryList = locEntries.Entries.ToList();

        if (entryList.All(e => e.SecondaryKey != description))
        {
            entryList.Add(new localizationPersistenceOnScreenEntry()
            {
                SecondaryKey = description,
                FemaleVariant = $"{itemData.ItemName} description".ToHumanFriendlyString(),
            });
        }

        foreach (var variant in itemData.Variants)
        {
            var translationString = displayName.Replace("$(base_color)", variant);
            if (entryList.All(e => e.SecondaryKey != translationString))
            {
                entryList.Add(new localizationPersistenceOnScreenEntry()
                {
                    SecondaryKey = translationString,
                    FemaleVariant = $"{itemData.ItemName} ({variant})".ToHumanFriendlyString(),
                });
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
    private void CreatePlaceholderIcons(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var iconName = $"{itemData.ItemName}_$(base_color)";

        var absoluteInkatlasPath = Path.Combine(activeProject.ModDirectory, itemData.InkatlasPath);

        if (File.Exists(absoluteInkatlasPath) && _cr2WTools.ReadCr2WNoException(absoluteInkatlasPath) is not null)
        {
            _logger.Warning($"Inkatlas {itemData.InkatlasPath} already exists, refusing to overwrite.");
            _logger.Info($"Delete it or run Files -> Add Files -> Generate Inkatlas");
        }

        var tempFolder = Path.Combine(Path.GetTempPath(), $"iconImages_{itemData.ItemName}");
        InkatlasImageGenerator.GenerateDummyIcons(tempFolder, iconName.Replace("$(base_color)", ""),
            itemData.Variants.ToArray());

        InkatlasImageGenerator.GenerateAtlas(
            tempFolder,
            Path.GetDirectoryName(itemData.InkatlasPath)!,
            Path.GetFileName(itemData.InkatlasPath),
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
    private void AddMeshEntity(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var meshEntityAbsPath = Path.Combine(activeProject.ModDirectory, itemData.MeshEntityPath);
        CR2WFile? cr2W = null;

        if (File.Exists(meshEntityAbsPath) && _cr2WTools.ReadCr2W(meshEntityAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (ArchiveXlItem.FilesBySubType.TryGetValue(itemData.SubSlot, out var meshEntityPath) &&
                 _archiveManager.GetCR2WFile(meshEntityPath) is
                     CR2WFile f2)
        {
            ((entEntityTemplate)f2.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f2;
        }
        else if (ArchiveXlItem.FilesByType.TryGetValue(itemData.Slot, out var defaultFilePath) &&
                 _archiveManager.GetCR2WFile(defaultFilePath) is
                     CR2WFile f3)
        {
            ((entEntityTemplate)f3.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f3;
        }

        if (cr2W?.RootChunk is not entEntityTemplate entTemplate)
        {
            _logger.Error($"Failed to open or create mesh entity {itemData.MeshEntityPath}");
            return;
        }

        var relativeMeshFolder = Path.Combine(itemData.FilesRelPath, "meshes");
        Directory.CreateDirectory(Path.Combine(activeProject.ModDirectory, relativeMeshFolder));

        foreach (var entComponent in entTemplate.Components.OfType<IRedMeshComponent>())
        {
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

            var pathInMod = Path.Combine(relativeMeshFolder, Path.GetFileName(filePath));

            AddMeshFilesToProject(filePath, pathInMod);

            var dynamicPath = $"{pathInMod.Replace("pwa", "p{gender}a").Replace("_wa_", "_{gender}a_")}";
            if (dynamicPath.Contains("{gender}"))
            {
                entComponent.Mesh =
                    new CResourceAsyncReference<CMesh>($"*{dynamicPath}", InternalEnums.EImportFlags.Soft);
                entComponent.MeshAppearance = "*{variant}";
            }
            else
            {
                entComponent.Mesh = new CResourceAsyncReference<CMesh>(dynamicPath, InternalEnums.EImportFlags.Default);
            }
        }

        // Garment support tags (size)
        var tags = entTemplate.VisualTagsSchema.Chunk ?? new entVisualTagsSchema();
        var tagsArray = tags.VisualTags.Tags;

        if (itemData.GarmentSupportTag is not GarmentSupportTags.None &&
            !tagsArray.Contains(itemData.GarmentSupportTag.ToString()))
        {
            tagsArray.Add(itemData.GarmentSupportTag.ToString());
        }

        tags.VisualTags.Tags = tagsArray;
        _cr2WTools.WriteCr2W(cr2W, meshEntityAbsPath);

        return;

        /*
         * Adds mesh files from .ent components to project. Will try to find pma/_ma mesh (entity is pwa/_wa).
         * Will not overwrite existing files.
         */
        void AddMeshFilesToProject(string filePath, string pathInMod)
        {
            var textureDirPath = Path.Combine(itemData.FilesRelPath, "textures");
            if (_archiveManager.GetCR2WFile(filePath) is { RootChunk: CMesh mesh } componentMesh)
            {
                var destPath = Path.Combine(activeProject.ModDirectory, pathInMod);
                if (File.Exists(destPath))
                {
                    _logger.Info($"Mesh {pathInMod} exists, not overwriting.");
                    return;
                }

                AdjustMeshAppearances(mesh);

                if (itemData.IsAddMeshMaterials)
                {
                    _projectResourceTools.AddDependenciesToProject(componentMesh, textureDirPath).GetAwaiter()
                        .GetResult();
                }

                _cr2WTools.WriteCr2W(componentMesh, destPath);
            }

            var otherGenderSourcePath = filePath.Replace("pwa", "pma").Replace("_wa_", "_ma_");
            var otherGenderDestPath = pathInMod.Replace("pwa", "pma").Replace("_wa_", "_ma_");

            if (_archiveManager.GetCR2WFile(otherGenderSourcePath) is { RootChunk: CMesh mesh2 } otherGenderMesh)
            {
                var destPath = Path.Combine(activeProject.ModDirectory, otherGenderDestPath);
                if (File.Exists(destPath))
                {
                    _logger.Info($"Mesh {otherGenderDestPath} exists, not overwriting.");
                    return;
                }

                AdjustMeshAppearances(mesh2);

                if (itemData.IsAddMeshMaterials)
                {
                    _projectResourceTools.AddDependenciesToProject(otherGenderMesh, textureDirPath).GetAwaiter()
                        .GetResult();
                }

                _cr2WTools.WriteCr2W(otherGenderMesh, destPath);
            }
        }

        /*
         * Mesh appearances will be renamed to match variants from generator, and created if they don't exist.
         */
        void AdjustMeshAppearances(CMesh mesh)
        {
            for (var idx = 0; idx < itemData.Variants.Count; idx++)
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
                appHandle.Chunk.Name = itemData.Variants[idx];
            }
        }
    }

    /// <summary>
    /// Creates root entity from base game file and adjusts path and tags
    /// </summary>
    private void AddRootEntity(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var rootEntityAbsPath = Path.Combine(activeProject.ModDirectory, itemData.RootEntityPath);

        CR2WFile? cr2W = null;

        if (File.Exists(rootEntityAbsPath) && _cr2WTools.ReadCr2W(rootEntityAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (_archiveManager.GetCR2WFile(ArchiveXlItem.DefaultRootEntityPath) is
                 CR2WFile f2)
        {
            ((entEntityTemplate)f2.RootChunk).Appearances.Clear();
            cr2W = f2;
        }

        if (cr2W?.RootChunk is not entEntityTemplate rootEntity)
        {
            _logger.Error($"Failed to open or create root entity {itemData.RootEntityPath}");
            return;
        }

        var itemName = $"{itemData.ItemName}_";

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
            new CResourceAsyncReference<appearanceAppearanceResource>(itemData.AppFilePath);

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

        if (itemData.TagsHideInFpp && !tagsArray.Contains("EmptyAppearance:FPP"))
        {
            tagsArray.Add("EmptyAppearance:FPP");
        }

        if (itemData.TagsForceHair && !tagsArray.Contains("force_Hair"))
        {
            tagsArray.Add("force_Hair");
        }

        tags.VisualTags.Tags = tagsArray;
        _cr2WTools.WriteCr2W(cr2W, rootEntityAbsPath);
    }

    private void AddAppFile(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        var appFileAbsPath = Path.Combine(activeProject.ModDirectory, itemData.AppFilePath);
        CR2WFile? cr2W = null;

        if (File.Exists(appFileAbsPath) && _cr2WTools.ReadCr2W(appFileAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (_archiveManager.GetCR2WFile(ArchiveXlItem.DefaultAppFilePath) is
                 CR2WFile f2)
        {
            ((appearanceAppearanceResource)f2.RootChunk).Appearances.Clear();
            cr2W = f2;
        }

        if (cr2W?.RootChunk is not appearanceAppearanceResource app)
        {
            _logger.Error($"Failed to open or create .app file {itemData.AppFilePath}");
            return;
        }

        var appearanceName = $"{itemData.ItemName}_";
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

        CArray<CName> tags = [.. itemData.HidingTags.Select(t => (CName)t.ToString()).ToArray()];

        appAppearance.Name = $"{itemData.ItemName}_";
        appAppearance.PartsValues = new CArray<appearanceAppearancePart>([
            new appearanceAppearancePart()
            {
                Resource = new CResourceAsyncReference<entEntityTemplate>(
                    (ResourcePath)itemData.AppFilePath)
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
    private void CreateYamlEntry(ArchiveXlItem itemData, Cp77Project activeProject)
    {
        if (!ArchiveXlItem.EquipmentItemSlotNames.TryGetValue(itemData.Slot, out var itemBase) ||
            string.IsNullOrEmpty(itemBase))
        {
            _logger.Error($"Failed to find item base for {itemData.Slot}. Not creating .yaml entry.");
            return;
        }

        if (itemData.SubSlot is not EquipmentItemSubSlot.None)
        {
            itemBase = $"Items.{itemData.SubSlot}";
        }

        var yamlAbsPath = Path.Combine(activeProject.ResourcesDirectory, itemData.YamlFilePath);

        var itemName = $"Items.{_settingsManager.ModderName}_{itemData.ItemName}_$(base_color)";

        var instances = new YamlSequenceNode(
            itemData.Variants.Select(color =>
            {
                var node = new YamlMappingNode { { "base_color", color } };
                node.Style = YamlDotNet.Core.Events.MappingStyle.Flow;

                return node;
            })
        );

        var icon = new YamlMappingNode
        {
            { "atlasResourcePath", itemData.InkatlasPath },
            { "atlasPartName", $"{itemData.ItemName}_$(base_color)" }
        };

        var yamlData = new YamlMappingNode();
        var yaml = new YamlMappingNode() { { itemName, yamlData } };

        if (YamlHelper.ReadYamlAsNodes(yamlAbsPath) is { } yamlFromFile)
        {
            if (yamlFromFile.Children.TryGetValue(itemName, out var n) && n is YamlMappingNode nodeFromFile)
            {
                _logger.Warning(
                    $"Yaml file {itemData.YamlFilePath} already contains a definition for {itemName}. Existing properties will not be overwritten.");
                yaml = yamlFromFile;
                yamlData = nodeFromFile;
            }
        }

        yamlData.Children.TryAdd("$base", itemBase);
        yamlData.Children.TryAdd("$instances", instances);
        yamlData.Children.TryAdd("appearanceName", $"{itemData.ItemName}_!$(base_color)");
        yamlData.Children.TryAdd("entityName", $"{itemData.ItemName}_factory_name");
        yamlData.Children.TryAdd("icon", icon);
        yamlData.Children.TryAdd("localizedDescription", $"LocKey#{itemData.ItemName}_i18n_desc");
        yamlData.Children.TryAdd("displayName", $"LocKey#{itemData.ItemName}_i18n_$(base_color)");
        yamlData.Children.TryAdd("quality", "Quality.Legendary");
        yamlData.Children.TryAdd("statModifiers", ArchiveXlItem.StatModifiers);
        yamlData.Children.TryAdd("statModifierGroups", ArchiveXlItem.StatModifierGroups);

        if (itemData.EqExSlot is not EquipmentExSlot.None)
        {
            yamlData.Children.TryAdd("placementSlots", $"OutfitSlots.{itemData.EqExSlot}");
        }

        YamlHelper.WriteYaml(yamlAbsPath, yaml);
    }
}
