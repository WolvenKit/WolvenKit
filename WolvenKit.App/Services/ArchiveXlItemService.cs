using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
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

    public bool HideInFpp { get; set; }
    public bool ForceHair { get; set; }
    public EquipmentItemSlot Slot { get; set; } = EquipmentItemSlot.Head;
    public EquipmentItemSubSlot SubSlot { get; set; } = EquipmentItemSubSlot.None;
    public EquipmentExSlot EqExSlot { get; set; } = EquipmentExSlot.None;

    public List<GarmentSupportTags> GarmentSupportTags { get; set; } = new();
    public List<ArchiveXlHidingTags> HidingTags { get; set; } = new();

    // Set these in ItemService during creation

    public string RootEntityPath { get; set; } = string.Empty;
    public string MeshEntityPath { get; set; } = string.Empty;
    public string AppFilePath { get; set; } = string.Empty;
    public string FilesRelPath { get; set; } = string.Empty;
    public string ControlFilesRelPath { get; set; } = string.Empty;
}

public class ArchiveXlItemService
{
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _logger;
    private readonly Cr2WTools _cr2WTools;

    public ArchiveXlItemService(ISettingsManager settingsManager, IProjectManager projectManager, Cr2WTools cr2WTools,
        ILoggerService logger)
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _cr2WTools = cr2WTools;
        _logger = logger;
    }

    public void CreateEquipmentItem(ArchiveXlItem itemData)
    {
        CreateOrSetDirectories(itemData);

        AddRootEntity(itemData);

        RegisterInFactory(itemData);
        RegisterInTranslationFile(itemData);
        AddDummyIcon(itemData);

        AddMeshEntity(itemData);
        AddAppFile(itemData);

        WriteYamlToDisk(itemData);
    }

    private void RegisterInFactory(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        var absoluteFactoryPath = Path.Combine(activeProject.ModDirectory, itemData.ControlFilesRelPath, "factory.csv");

        var cr2Wfile = new CR2WFile();
        var factory = new C2dArray();


        // check if factory file exists in project folder, create if not
        if (File.Exists(absoluteFactoryPath))
        {
            if (_cr2WTools.ReadCr2W(absoluteFactoryPath) is not CR2WFile cr2W || cr2W.RootChunk is not C2dArray ary)
            {
                _logger.Error("Failed to read existing factory.csv file - please register your item manually:");
                _logger.Error($"\t [0] = {itemData.ItemName}");
                _logger.Error($"\t [1] = {Path.Join(itemData.FilesRelPath, "_root_entity.ent")}");
                _logger.Error($"\t [2] = true");
                return;
            }

            cr2Wfile = cr2W;
            factory = ary;
        }

        if (factory.CompiledHeaders.Count == 0)
        {
            factory.Headers.Add("name");
            factory.Headers.Add("path");
            factory.Headers.Add("preload");
        }

        // Then register item name in factory file
        factory.CompiledData.Add(new CArray<CString>([
            itemData.ItemName, Path.Join(itemData.FilesRelPath, "_root_entity.ent"), "true"
        ]));

        // now write factory back

        cr2Wfile.RootChunk = factory;
        _cr2WTools.WriteCr2W(cr2Wfile, absoluteFactoryPath);

    }

    private void RegisterInTranslationFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
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
    }

    private void AddMeshEntity(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }

        // Grab default files from
        itemData.MeshEntityPath = "meshEntityPath";
    }

    private void AddRootEntity(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
        // Create default files from somewhere

        itemData.RootEntityPath = "rootEntityPath";
    }

    private void AddAppFile(ArchiveXlItem itemData)
    {
        if (_projectManager.ActiveProject is not { } activeProject)
        {
            return;
        }
        // Grab default files from

        itemData.AppFilePath = "appFilePath";
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
