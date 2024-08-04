using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AddArchiveXlFilesDialogViewModel() : DialogViewModel
{
    [ObservableProperty] private string? _depotPath;
    [ObservableProperty] private string? _itemName;
    [ObservableProperty] private bool _createFactory;
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

    public AddArchiveXlFilesDialogViewModel(bool collectFactoryInfo = false) : this()
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

        HidingTags = [];
        GarmentSupportTag = GarmentSupportTags.None;

        CreateFactory = collectFactoryInfo;

        IsHeadItem = false;
        HideInFpp = false;
        ForceHair = false;

        IsValid = false;
        HasSlot = false;
    }

    public ArchiveXlItem CollectItemInfo() => new()
    {
        DestinationPath = DepotPath ?? string.Empty,
        ItemName = ItemName ?? string.Empty,
        Slot = Slot ?? EquipmentItemSlot.Head,
        SubSlot = SubSlot ?? EquipmentItemSubSlot.None,
        EqExSlot = EqExSlot ?? EquipmentExSlot.None,
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