using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.Services;

public class ArchiveXlItem
{
    public string ItemName { get; init; } = string.Empty;

    public EquipmentItemSlot Slot { get; init; } = EquipmentItemSlot.Head;
    public EquipmentItemSubSlot SubSlot { get; init; } = EquipmentItemSubSlot.None;
    public EquipmentExSlot EqExSlot { get; init; } = EquipmentExSlot.None;

    public bool TagsHideInFpp { get; init; }
    public bool TagsForceHair { get; init; }

    /// <summary>
    /// Size tag (<see cref="GarmentSupportTag"/>)
    /// </summary>
    public GarmentSupportTags GarmentSupportTag { get; init; }

    public List<ArchiveXlHidingTags> HidingTags { get; init; } = [];

    // init these in ItemService during creation

    public string RootEntityPath { get; set; } = string.Empty;
    public string MeshEntityPath { get; set; } = string.Empty;
    public string AppFilePath { get; set; } = string.Empty;
    public string FactoryFilePath { get; set; } = string.Empty;

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

    public string XlFilePath { get; set; } = string.Empty;
    public string YamlFilePath { get; set; } = string.Empty;
    public string InkatlasPath { get; set; } = string.Empty;

    /// <summary>
    /// Variants for dynamic appearances, e.g. [black, white, red]
    /// </summary>
    public List<string> Variants { get; set; } = [];

    public static readonly string DefaultAppFilePath =
        @"base\gameplay\items\equipment\underwear\appearances\player_underwear_item_appearances.app";

    public static readonly string DefaultRootEntityPath =
        @"base\gameplay\items\equipment\underwear\player_underwear_item.ent";

    public static readonly Dictionary<EquipmentItemSlot, string> FilesByType = new()
    {
        { EquipmentItemSlot.Face, @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent" },
        { EquipmentItemSlot.Head, @"base\characters\garment\player_equipment\head\h1_032_pwa_hat__asian.ent" },
        { EquipmentItemSlot.Legs, @"base\characters\garment\player_equipment\legs\l1_054_pwa_shorts__latino.ent" },
        {
            EquipmentItemSlot.Torso_Inner,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug_shirt.ent"
        },
        { EquipmentItemSlot.Torso_Outer, @"base\characters\garment\player_equipment\torso\t2_002_pwa_vest__puffy.ent" },
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

    public static readonly YamlSequenceNode StatModifiers = new YamlSequenceNode(
        new YamlScalarNode("!append Quality.IconicItem"),
        new YamlScalarNode("!append Character.ScaleToPlayerLevel")
    );

    // Build statModifierGroups sequence
    public static readonly YamlSequenceNode StatModifierGroups = new YamlSequenceNode(
        new YamlScalarNode("!append-once Items.IconicQualityRandomization")
    );

}

public class ArchiveXlItemService
{
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly IAppArchiveManager _archiveManager;
    private readonly ILoggerService _logger;
    private readonly Cr2WTools _cr2WTools;

    public ArchiveXlItemService(
        ISettingsManager settingsManager,
        IProjectManager projectManager,
        Cr2WTools cr2WTools,
        IAppArchiveManager archiveManager,
        ILoggerService logger
    )
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _cr2WTools = cr2WTools;
        _logger = logger;
        _archiveManager = archiveManager;
    }

    public void CreateEquipmentItem(ArchiveXlItem itemData)
    {
        SetPathsAndCreateDirectories(itemData);

        AddRootEntity(itemData);

        RegisterInFactory(itemData);

        RegisterInXlFile(itemData);

        AddDummyIcon(itemData);

        AddMeshEntity(itemData);
        AddAppFile(itemData);

        CreateYamlEntry(itemData);
        RegisterInTranslationFile(itemData);
    }

    private void SetPathsAndCreateDirectories(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        // Items go into moddername/equipment/itemdataslot/projectname
        itemData.FilesRelPath = Path
            .Join(_settingsManager.ModderName, "equipment", itemData.Slot.ToString(), activeProject.ModName)
            .ToFilePath();

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

    private void RegisterInXlFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

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

    private void RegisterInFactory(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var absoluteFactoryPath = Path.Combine(activeProject.ModDirectory, itemData.FactoryFilePath);

        // check if factory file exists in project folder, create if not
        var cr2Wfile = _cr2WTools.ReadCr2WNoException(absoluteFactoryPath) ??
                       new CR2WFile() { RootChunk = new C2dArray() { Headers = ["name", "path", "preload"] } };


        if (cr2Wfile.RootChunk is not C2dArray factory)
        {
            _logger.Error(string.Join(",\n\t", [
                $"Failed when adding to factory {itemData.FactoryFilePath}. Add an entry to CompiledData by hand:",
                $"[0] = {itemData.ItemName}_factory_name",
                $"[1] = {itemData.RootEntityPath}",
                $"[2] = true"
            ]));
            return;
        }

        factory.CompiledData.Add(new CArray<CString>([
            $"{itemData.ItemName}_factory_name", // name
            itemData.RootEntityPath, // path
            "true" // preload
        ]));

        // write factory back
        _cr2WTools.WriteCr2W(cr2Wfile, absoluteFactoryPath);

    }

    private void RegisterInTranslationFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

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

    private void AddDummyIcon(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
    }

    private void AddMeshEntity(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var meshEntityAbsPath = Path.Combine(activeProject.ModDirectory, itemData.MeshEntityPath);
        CR2WFile? cr2W = null;

        if (File.Exists(meshEntityAbsPath) && _cr2WTools.ReadCr2W(meshEntityAbsPath) is CR2WFile f)
        {
            cr2W = f;
        }
        else if (ArchiveXlItem.FilesByType.TryGetValue(itemData.Slot, out var defaultFilePath) &&
                 _archiveManager.GetCR2WFile(defaultFilePath) is
                     CR2WFile f2)
        {
            ((entEntityTemplate)f2.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f2;
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
            if (entComponent.Mesh.DepotPath == ResourcePath.Empty ||
                entComponent.Mesh.DepotPath.GetResolvedText()?.StartsWith('*') == true)
            {
                continue;
            }

            entComponent.MeshAppearance = "*{variant}";

            var filePath = entComponent.Mesh.DepotPath.GetResolvedText() ?? "";
            var fileName = Path.GetFileName(filePath);

            var pathInMod = Path.Combine(relativeMeshFolder, fileName);

            if (_archiveManager.GetCR2WFile(filePath) is CR2WFile componentMesh)
            {
                var destPath = Path.Combine(activeProject.ModDirectory, pathInMod);
                if (!File.Exists(destPath))
                {
                    _cr2WTools.WriteCr2W(componentMesh, destPath);
                }
                else
                {
                    _logger.Info($"Mesh {pathInMod} exists, not overwriting.");
                }
            }


            if (_archiveManager.GetCR2WFile(filePath.Replace("pwa", "pma").Replace("_wa_", "_ma_")) is CR2WFile
                otherGenderMesh)
            {
                var destPath = Path.Combine(activeProject.ModDirectory,
                    pathInMod.Replace("pwa", "pma").Replace("_wa_", "_ma_"));
                if (!File.Exists(destPath))
                {
                    _cr2WTools.WriteCr2W(otherGenderMesh, destPath);
                }
                else
                {
                    _logger.Info(
                        $"Mesh {pathInMod.Replace("pwa", "pma").Replace("_wa_", "_ma_")} exists, not overwriting.");
                }
            }

            var escapedPath = $"{pathInMod.Replace("pwa", "p{gender}a").Replace("_wa_", "_{gender}a_")}";
            if (escapedPath.Contains("{gender}"))
            {
                entComponent.Mesh =
                    new CResourceAsyncReference<CMesh>($"*{escapedPath}", InternalEnums.EImportFlags.Soft);
            }
            else
            {
                entComponent.Mesh = new CResourceAsyncReference<CMesh>(escapedPath, InternalEnums.EImportFlags.Default);
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
    }

    private void AddRootEntity(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

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

    private void AddAppFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

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

    private void CreateYamlEntry(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject ||
            !ArchiveXlItem.EquipmentItemSlotNames.TryGetValue(itemData.Slot, out var itemBase) ||
            string.IsNullOrEmpty(itemBase))
        {
            return;
        }

        if (itemData.SubSlot is not EquipmentItemSubSlot.None)
        {
            itemBase = $"Items.{itemData.SubSlot.ToString()}";
        }

        var yamlAbsPath = Path.Combine(activeProject.ResourcesDirectory, itemData.YamlFilePath);
        YamlMappingNode yaml = YamlHelper.ReadYamlAsNodes(yamlAbsPath) ?? new YamlMappingNode();

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


        var yamlData = new YamlMappingNode()
        {
            { "$base", itemBase },
            { "$instances", instances },
            { "appearanceName", $"{itemData.ItemName}_!$(base_color)" },
            { "entityName", $"{itemData.ItemName}_factory_name" },
            { "displayName", $"LocKey#{itemData.ItemName}_i18n_$(base_color)" },
            { "localizedDescription", $"LocKey#{itemData.ItemName}_i18n_desc" },
            { "icon", icon },
            { "quality", "Quality.Legendary" },
            { "statModifiers", ArchiveXlItem.StatModifiers },
            { "statModifierGroups", ArchiveXlItem.StatModifierGroups }
        };

        if (itemData.EqExSlot is not EquipmentExSlot.None)
        {
            yamlData.Children.Add("placementSlots", $"OutfitSlots.{itemData.EqExSlot}");
        }

        YamlHelper.WriteYaml(yamlAbsPath, new YamlMappingNode() { { itemName, yamlData } });
    }
}
