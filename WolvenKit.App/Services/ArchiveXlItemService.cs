using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using HelixToolkit.SharpDX.Core;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Interfaces;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services;

public class ArchiveXlItem
{
    public string ItemName { get; set; } = string.Empty;

    public bool CreateControlFiles { get; set; }

    public EquipmentItemSlot Slot { get; set; } = EquipmentItemSlot.Head;
    public EquipmentItemSubSlot SubSlot { get; set; } = EquipmentItemSubSlot.None;
    public EquipmentExSlot EqExSlot { get; set; } = EquipmentExSlot.None;

    public bool TagsHideInFpp { get; set; }
    public bool TagsForceHair { get; set; }

    public List<GarmentSupportTags> GarmentSupportTags { get; set; } = [];
    public List<ArchiveXlHidingTags> HidingTags { get; set; } = [];

    // Set these in ItemService during creation

    public string RootEntityPath { get; set; } = string.Empty;
    public string MeshEntityPath { get; set; } = string.Empty;
    public string AppFilePath { get; set; } = string.Empty;
    public string FactoryFilePath { get; set; } = string.Empty;
    public string FilesRelPath { get; set; } = string.Empty;
    public string ControlFilesRelPath { get; set; } = string.Empty;
    public string TranslationFileRelPath { get; set; } = string.Empty;

    public static readonly Dictionary<EquipmentItemSlot, string> FilesByType = new()
    {
        { EquipmentItemSlot.Face, @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent" },
        { EquipmentItemSlot.Head, @"base\characters\garment\player_equipment\head\h1_032_pwa_hat__asian.ent" },
        { EquipmentItemSlot.Legs, @"base\characters\garment\player_equipment\legs\l0_003_pwa_pants__leggins.ent" },
        {
            EquipmentItemSlot.Torso_Inner,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug_shirt.ent"
        },
        { EquipmentItemSlot.Torso_Outer, @"base\characters\garment\player_equipment\torso\t2_002_pwa_vest__puffy.ent" },
    };
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
        CreateOrSetDirectories(itemData);

        AddRootEntity(itemData);

        RegisterInFactory(itemData);
        RegisterInTranslationFile(itemData);

        RegisterInXlFile(itemData);

        AddDummyIcon(itemData);

        AddMeshEntity(itemData);
        AddAppFile(itemData);

        WriteYamlToDisk(itemData);
    }

    private void RegisterInXlFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var xlFileRelPath = Path.Join("r6", "tweaks", _settingsManager.ModderName, $"{activeProject.ModName}.xl");

        if (activeProject.ResourceFiles.Where(f => f.HasFileExtension(".xl")).ToList() is { Count: 1 } list)
        {
            xlFileRelPath = list.First();
        }

        var xlFileAbsPath = Path.Join(activeProject.ResourcesDirectory, xlFileRelPath);
        var xlFileContent = YamlHelper.ReadYamlAsObject(xlFileAbsPath) ?? new ExpandoObject();

        IDictionary<string, object> yamlDict = xlFileContent!;

        /*
         * Make sure the factory exists
         */
        List<string> factories = [];

        if (yamlDict.TryGetValue("factories", out var facNode) && facNode is List<object> l)
        {
            factories.AddRange(l.OfType<string>());
        }

        if (!factories.Contains(itemData.FactoryFilePath))
        {
            factories.Add(itemData.FactoryFilePath);
        }

        yamlDict.Remove("factories");
        yamlDict.Add("factories", factories);

        List<string> localizationStrings = [];

        if (YamlHelper.GetPropertyRecursive(yamlDict, "localization",
                "onscreens", "en-us") is List<object> locList)
        {
            localizationStrings.AddRange(locList.OfType<string>());
        }

        if (!localizationStrings.Contains(itemData.TranslationFileRelPath))
        {
            localizationStrings.Add(itemData.TranslationFileRelPath);
        }

        /*
         * TODO: Make sure localization exists
         */

        YamlHelper.AddPropertyRecursive(yamlDict, localizationStrings, "localization", "onscreens", "en-us");

        YamlHelper.WriteYaml(xlFileAbsPath, xlFileContent);
    }

    private void RegisterInFactory(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var relativeFactoryPath = Path.Combine(itemData.ControlFilesRelPath, "factory.csv");
        if (activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).ToList() is { Count: 1 } l)
        {
            relativeFactoryPath = l.First();
        }

        itemData.FactoryFilePath = relativeFactoryPath;

        var absoluteFactoryPath = Path.Combine(activeProject.ModDirectory, relativeFactoryPath);


        // check if factory file exists in project folder, create if not
        var cr2Wfile = _cr2WTools.ReadCr2WNoException(absoluteFactoryPath) ??
                       new CR2WFile() { RootChunk = new C2dArray() { Headers = ["name", "path", "preload"] } };


        if (cr2Wfile.RootChunk is not C2dArray factory)
        {
            _logger.Error(string.Join(",\n\t", [
                $"Failed when adding to factory {relativeFactoryPath}. Please add your entry by hand to CompiledData:",
                $"[0] = {itemData.ItemName}",
                $"[1] = {Path.Join(itemData.FilesRelPath, "_root_entity.ent")}",
                $"[2] = true"
            ]));
            return;
        }

        factory.CompiledData.Add(new CArray<CString>([
            itemData.ItemName, // name
            Path.Join(itemData.FilesRelPath, "_root_entity.ent"), // path
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

        itemData.TranslationFileRelPath = Path.Combine(itemData.ControlFilesRelPath, "i18n", "en_us.json");

        if (activeProject.ModFiles.Where(f => f.HasFileExtension("json")).ToList() is { Count: 1 } list)
        {
            itemData.TranslationFileRelPath = list.First();
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

        if (cr2W.RootChunk is not JsonResource json)
        {
            _logger.Error($"Failed to open or create translation file {itemData.TranslationFileRelPath}");
            return;
        }

        // TODO: put it in here

    }

    private void AddDummyIcon(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
    }

    private void CreateOrSetDirectories(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        // Items go into moddername/equipment/itemdataslot/projectname
        itemData.FilesRelPath = Path
            .Join(_settingsManager.ModderName, "equipment", itemData.Slot.ToString(), activeProject.Name).ToFilePath();

        // Control files go into the folder of any existing csv file in the project, or the default path
        itemData.ControlFilesRelPath =
            activeProject.ModFiles.Where(f => f.HasFileExtension("csv")).Select(Path.GetDirectoryName).FirstOrDefault()
            ?? Path.Join(_settingsManager.ModderName, activeProject.Name).ToFilePath();

        Directory.CreateDirectory(Path.Combine(activeProject.FileDirectory, itemData.FilesRelPath));
        Directory.CreateDirectory(Path.Combine(activeProject.FileDirectory, itemData.ControlFilesRelPath));

        // Now write paths into the item data
        itemData.RootEntityPath = Path.Combine(itemData.ControlFilesRelPath, "_root_entity.ent");
        itemData.AppFilePath = Path.Combine(itemData.ControlFilesRelPath, "_application.app");
        itemData.MeshEntityPath = Path.Combine(itemData.ControlFilesRelPath, "_mesh_entity.ent");
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
            ((entEntityTemplate)f2.RootChunk).Components.Clear();
            ((entEntityTemplate)f2.RootChunk).VisualTagsSchema.Chunk?.VisualTags.Tags.Clear();
            cr2W = f2;
        }

        if (cr2W?.RootChunk is not entEntityTemplate entTemplate)
        {
            _logger.Error($"Failed to open or create mesh entity {itemData.MeshEntityPath}");
            return;
        }


        // Take care of the tags

        var tags = entTemplate.VisualTagsSchema.Chunk ?? new entVisualTagsSchema() { };
        var tagsArray = tags.VisualTags.Tags;

        foreach (var tag in itemData.GarmentSupportTags.Select(t => t.ToString()))
        {
            if (!tagsArray.Contains(tag))
            {
                tagsArray.Add(tag);
            }
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
        else if (_archiveManager.GetCR2WFile(@"base\gameplay\items\equipment\underwear\player_underwear_item.ent") is
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

        rootEntity.Appearances.Add(new entTemplateAppearance()
        {
            Name = $"{itemData.ItemName}_",
            AppearanceResource = new CResourceAsyncReference<appearanceAppearanceResource>(itemData.AppFilePath),
            AppearanceName = $"{itemData.ItemName}_",
        });

        // Take care of the tags

        var tags = rootEntity.VisualTagsSchema.Chunk ?? new entVisualTagsSchema() { };
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
        else if (_archiveManager.GetCR2WFile(
                     @"base\gameplay\items\equipment\underwear\appearances\playe _underwear_item_appearances.app") is
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

        CArray<CName> tags = [.. itemData.HidingTags.Select(t => (CName)t.ToString()).ToArray()];

        app.Appearances.Add(new CHandle<appearanceAppearanceDefinition>()
        {
            Chunk = new appearanceAppearanceDefinition()
            {
                Name = $"{itemData.ItemName}_", // name
                PartsValues = new CArray<appearanceAppearancePart>([
                    new appearanceAppearancePart()
                    {
                        Resource = new CResourceAsyncReference<entEntityTemplate>(
                            (ResourcePath)itemData.AppFilePath)
                    }
                ]),
                VisualTags = new redTagList() { Tags = tags }, // visual tags
            }
        });

        _cr2WTools.WriteCr2W(cr2W, appFileAbsPath);

    }

    private void WriteYamlToDisk(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
        // If we have more than one .yaml file under resources, create a new one, otherwise append
    }
}
