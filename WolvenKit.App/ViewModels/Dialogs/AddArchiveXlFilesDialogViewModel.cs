using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public class FilePathItemDataTemplateSelector : DataTemplateSelector
{
    public override DataTemplate?
        SelectTemplate(object item, DependencyObject container)
    {
        if (container is not FrameworkElement frameworkElement || item == null)
        {
            return null;
        }


        return null;
    }
}

public partial class AddArchiveXlFilesDialogViewModel : DialogViewModel
{
    // form validation
    [ObservableProperty] private bool? _isFormValid;

    [ObservableProperty] private string? _itemName;
    [ObservableProperty] private EquipmentItemSlot? _slot;
    [ObservableProperty] private EquipmentItemSubSlot? _subSlot;
    [ObservableProperty] private EquipmentExSlot? _eqExSlot;

    [ObservableProperty] private GarmentSupportTags _garmentSupportTag;
    [ObservableProperty] private List<ArchiveXlHidingTags>? _hidingTags;
    [ObservableProperty] private List<string>? _existingFiles;

    [ObservableProperty] private bool? _isHideInFpp;
    [ObservableProperty] private bool? _isForceHair;
    [ObservableProperty] private bool? _isHeadItem;

    // enable/disable the subType and EquipmentEx slot dropdowns
    [ObservableProperty] private bool? _hasSlot;

    // for validation: disables/enables the button
    [ObservableProperty] private bool? _isValid;

    [ObservableProperty] private List<string>? _variants;
    [ObservableProperty] private bool _enableSecondaryVariants = false;
    [ObservableProperty] private List<string>? _secondaryVariants;

    // select mesh files from project
    [ObservableProperty] private bool _isUseExistingMeshes = false;
    [ObservableProperty] private List<string>? _selectedMeshes;

    // collect variants from existing meshes
    [ObservableProperty] private bool _isCollectMeshAppearances = false;
    [ObservableProperty] private string? _primaryAppearanceMesh;
    [ObservableProperty] private string? _secondaryAppearanceMesh;

    // Dropdown selection options
    [ObservableProperty] private List<EquipmentItemSubSlot>? _equipmentItemSubSlots;
    [ObservableProperty] private List<EquipmentItemSlot>? _equipmentItemSlots;
    [ObservableProperty] private List<EquipmentExSlot>? _equipmentExSlots;

    [ObservableProperty] private List<GarmentSupportTags>? _garmentSupportTagsSource;
    [ObservableProperty] private List<ArchiveXlHidingTags>? _hidingTagsSource;
    [ObservableProperty] private List<string>? _existingFilesSource;

    public AddArchiveXlFilesDialogViewModel(Cp77Project currentProject)
    {
        // initialize dropdowns
        EquipmentItemSlots = [.. Enum.GetValues<EquipmentItemSlot>().Where(x => x != EquipmentItemSlot.None)];
        EquipmentExSlots = [.. Enum.GetValues<EquipmentExSlot>()];
        EquipmentItemSubSlots = [.. Enum.GetValues<EquipmentItemSubSlot>()];

        HidingTagsSource = [.. Enum.GetValues<ArchiveXlHidingTags>()];
        GarmentSupportTagsSource = [.. Enum.GetValues<GarmentSupportTags>()];


        Slot = EquipmentItemSlot.None;
        SubSlot = EquipmentItemSubSlot.None;
        EqExSlot = EquipmentExSlot.None;

        Variants = [];

        HidingTags = [];
        GarmentSupportTag = GarmentSupportTags.None;

        ExistingFilesSource = currentProject.ModFiles.Where(f => f.HasFileExtension("mesh"))
            .Select(f => f.Replace("wa", "{gender}").Replace("ma", "{gender}"))
            .Distinct()
            .Select(f => f.Replace("{gender}", "wa"))
            .ToList();

        IsHeadItem = false;
        IsHideInFpp = false;
        IsForceHair = false;

        IsValid = false;
        HasSlot = false;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        IsFormValid = !string.IsNullOrEmpty(ItemName) && Slot != EquipmentItemSlot.None;
        base.OnPropertyChanged(e);
    }

    public ArchiveXlClothingItem CollectItemInfo()
    {
        var ret = new ArchiveXlClothingItem()
        {
            ItemName = ItemName ?? string.Empty,
            Slot = Slot ?? EquipmentItemSlot.Head,
            SubSlot = SubSlot ?? EquipmentItemSubSlot.None,
            EqExSlot = EqExSlot ?? EquipmentExSlot.None,
            HidingTags = HidingTags ?? [],
            GarmentSupportTag = GarmentSupportTag,
            Variants = Variants ?? [],
            SecondaryVariants = EnableSecondaryVariants ? SecondaryVariants ?? [] : [],
            TagsHideInFpp = IsHideInFpp ?? false,
            TagsForceHair = IsForceHair ?? false,
            MeshesFromProject = IsUseExistingMeshes ? SelectedMeshes ?? [] : [],
            PrimaryAppearanceMesh = IsCollectMeshAppearances ? PrimaryAppearanceMesh : string.Empty,
            SecondaryAppearanceMesh = IsCollectMeshAppearances ? SecondaryAppearanceMesh : string.Empty,
        };

        if (ret.Variants.Count == 0 && string.IsNullOrEmpty(PrimaryAppearanceMesh))
        {
            ret.Variants.Add("default");
        }

        if (EnableSecondaryVariants && ret.SecondaryVariants.Count == 0 &&
            !string.IsNullOrEmpty(SecondaryAppearanceMesh))
        {
            ret.SecondaryVariants.Add("secondary_default");
        }

        return ret;
    }

    public void SetItemSlot(EquipmentItemSlot slot)
    {
        Slot = slot;
        HasSlot = slot != EquipmentItemSlot.None;
        IsHeadItem = slot == EquipmentItemSlot.Head;

        if (HasSlot == true)
        {
            EquipmentItemSubSlots = EquipmentItemData.EquipmentSlotsAndSubtypes[slot];
            return;
        }

        SubSlot = EquipmentItemSubSlot.None;
        EqExSlot = EquipmentExSlot.None;
        IsValid = false;
    }
}
