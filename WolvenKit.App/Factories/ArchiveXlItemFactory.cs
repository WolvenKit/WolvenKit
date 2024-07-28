using System;
using System.Collections.Generic;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Factories;

public class ArchiveXlItem
{
    public string DestinationPath { get; set; } = string.Empty;
    public string ItemName { get; set; } = string.Empty;
    public bool IsFactory { get; set; }

    // only required for non-factory items
    public bool IsDynamic { get; set; }
    public bool HideInFpp { get; set; }
    public bool ForceHair { get; set; }
    public EquipmentItemSlot Slot { get; set; } = EquipmentItemSlot.Head;
    public EquipmentItemSubSlot SubSlot { get; set; } = EquipmentItemSubSlot.None;
    public EquipmentExSlot EqExSlot { get; set; } = EquipmentExSlot.None;

    public List<GarmentSupportTags> GarmentSupportTags { get; set; } = new();
    public List<ArchiveXlHidingTags> HidingTags { get; set; } = new();
}

public static class ArchiveXlItemFactory
{
    public static void CreateEquipmentItem(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        CreateDirectory(activeProject, itemData);
        AddMeshEntity(activeProject, itemData);
        AddRootEntity(activeProject, itemData);
        AddAppFile(activeProject, itemData);


        WriteYamlToDisk(activeProject, itemData);
    }

    private static void CreateDirectory(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        if (string.IsNullOrEmpty(itemData.DestinationPath))
        {
            throw new Exception("Depot path is empty");
        }

        var directoryPath = Path.Combine(activeProject.FileDirectory, itemData.DestinationPath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
    }

    private static void AddMeshEntity(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        // Grab default files from 
    }

    private static void AddRootEntity(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        // Grab default files from 
    }

    private static void AddAppFile(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        // Grab default files from 
    }

    private static void WriteYamlToDisk(Cp77Project activeProject, ArchiveXlItem itemData)
    {
        // If we have more than one .yaml file under resources, create a new one, otherwise append
    }
}