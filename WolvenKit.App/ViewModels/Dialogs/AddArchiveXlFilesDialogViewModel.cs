using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddArchiveXlFilesDialogViewModel : DialogViewModel
{
    private Cp77Project _activeProject;
    private ISettingsManager _settingsManager;

    [ObservableProperty] private string? _itemName;
    [ObservableProperty] private bool _createControlFiles;
    [ObservableProperty] private EquipmentItemSlot? _slot;
    [ObservableProperty] private EquipmentItemSubSlot? _subSlot;
    [ObservableProperty] private EquipmentExSlot? _eqExSlot;

    [ObservableProperty] private GarmentSupportTags _garmentSupportTag;
    [ObservableProperty] private List<ArchiveXlHidingTags>? _hidingTags;

    [ObservableProperty] private bool? _hideInFpp;
    [ObservableProperty] private bool? _forceHair;
    [ObservableProperty] private bool? _isHeadItem;

    // enable/disable the subType and EquipmentEx slot dropdowns
    [ObservableProperty] private bool? _hasSlot;

    // for validation: disables/enables the button
    [ObservableProperty] private bool? _isValid;

    // Dropdown selection options
    [ObservableProperty] private List<EquipmentItemSubSlot>? _equipmentItemSubSlots;
    [ObservableProperty] private List<EquipmentItemSlot>? _equipmentItemSlots;
    [ObservableProperty] private List<EquipmentExSlot>? _equipmentExSlots;

    [ObservableProperty] private List<GarmentSupportTags>? _garmentSupportTagsSource;
    [ObservableProperty] private List<ArchiveXlHidingTags>? _hidingTagsSource;

    public AddArchiveXlFilesDialogViewModel(Cp77Project activeProject, ISettingsManager settingsManager)
    {
        _activeProject = activeProject;
        _settingsManager = settingsManager;

        // initialize dropdowns
        EquipmentItemSlots = [.. Enum.GetValues<EquipmentItemSlot>().Where(x => x != EquipmentItemSlot.None)];
        EquipmentExSlots = [.. Enum.GetValues<EquipmentExSlot>()];
        EquipmentItemSubSlots = [.. Enum.GetValues<EquipmentItemSubSlot>()];

        HidingTagsSource = [.. Enum.GetValues<ArchiveXlHidingTags>()];
        GarmentSupportTagsSource = [.. Enum.GetValues<GarmentSupportTags>()];

        Slot = EquipmentItemSlot.None;
        SubSlot = EquipmentItemSubSlot.None;
        EqExSlot = EquipmentExSlot.None;

        HidingTags = [];
        GarmentSupportTag = GarmentSupportTags.None;

        CreateControlFiles = !activeProject.Files.Any(x => x.HasFileExtension("csv"));

        IsHeadItem = false;
        HideInFpp = false;
        ForceHair = false;

        IsValid = false;
        HasSlot = false;
    }

    public ArchiveXlItem CollectItemInfo() => new()
    {
        CreateControlFiles = CreateControlFiles,
        ItemName = ItemName ?? string.Empty,
        Slot = Slot ?? EquipmentItemSlot.Head,
        SubSlot = SubSlot ?? EquipmentItemSubSlot.None,
        EqExSlot = EqExSlot ?? EquipmentExSlot.None
    };

    public void SetItemSlot(EquipmentItemSlot slot)
    {
        Slot = slot;
        HasSlot = slot != EquipmentItemSlot.None;
        IsHeadItem = slot == EquipmentItemSlot.Head;

        if (HasSlot == true)
        {
            EquipmentItemSubSlots = ArchiveXlHelper.EquipmentSlotsAndSubtypes[slot];
            return;
        }

        SubSlot = EquipmentItemSubSlot.None;
        EqExSlot = EquipmentExSlot.None;
        IsValid = false;
    }
}
