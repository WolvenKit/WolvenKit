using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

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
    private ISettingsManager _settingsManager;
    private IProjectManager _projectManager;

    public ArchiveXlItemService(ISettingsManager settingsManager, IProjectManager projectManager)
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
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
        // check if factory file exists in project folder, create if not

        // Then register item name in factory file
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
