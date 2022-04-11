using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("Quality")] 
		public CName Quality
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("Quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("Ammo")] 
		public CInt32 Ammo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("Shape")] 
		public CEnum<gameInventoryItemShape> Shape
		{
			get => GetPropertyValue<CEnum<gameInventoryItemShape>>();
			set => SetPropertyValue<CEnum<gameInventoryItemShape>>(value);
		}

		[Ordinal(8)] 
		[RED("ItemShape")] 
		public CEnum<gameInventoryItemShape> ItemShape
		{
			get => GetPropertyValue<CEnum<gameInventoryItemShape>>();
			set => SetPropertyValue<CEnum<gameInventoryItemShape>>(value);
		}

		[Ordinal(9)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("CategoryName")] 
		public CString CategoryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("ItemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(12)] 
		[RED("LocalizedItemType")] 
		public CString LocalizedItemType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("AdditionalDescription")] 
		public CString AdditionalDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("Price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("BuyPrice")] 
		public CFloat BuyPrice
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("UnlockProgress")] 
		public CFloat UnlockProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("RequiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("ItemLevel")] 
		public CInt32 ItemLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("DamageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(21)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(22)] 
		[RED("ComparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(23)] 
		[RED("IsPart")] 
		public CBool IsPart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("IsCraftingMaterial")] 
		public CBool IsCraftingMaterial
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("IsAvailable")] 
		public CBool IsAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("IsBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("SlotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("PositionInBackpack")] 
		public CUInt32 PositionInBackpack
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(32)] 
		[RED("IconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		[Ordinal(33)] 
		[RED("GameItemData")] 
		public CWeakHandle<gameItemData> GameItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(34)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(36)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(38)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(39)] 
		[RED("IsRequirementMet")] 
		public CBool IsRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("IsEquippable")] 
		public CBool IsEquippable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("IsVisualsEquipped")] 
		public CBool IsVisualsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("Requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetPropertyValue<gameSItemStackRequirementData>();
			set => SetPropertyValue<gameSItemStackRequirementData>(value);
		}

		[Ordinal(43)] 
		[RED("EquipRequirement")] 
		public gameSItemStackRequirementData EquipRequirement
		{
			get => GetPropertyValue<gameSItemStackRequirementData>();
			set => SetPropertyValue<gameSItemStackRequirementData>(value);
		}

		[Ordinal(44)] 
		[RED("EquipRequirements")] 
		public CArray<gameSItemStackRequirementData> EquipRequirements
		{
			get => GetPropertyValue<CArray<gameSItemStackRequirementData>>();
			set => SetPropertyValue<CArray<gameSItemStackRequirementData>>(value);
		}

		[Ordinal(45)] 
		[RED("LootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetPropertyValue<CEnum<gameLootItemType>>();
			set => SetPropertyValue<CEnum<gameLootItemType>>(value);
		}

		[Ordinal(46)] 
		[RED("Attachments")] 
		public CArray<InventoryItemAttachments> Attachments
		{
			get => GetPropertyValue<CArray<InventoryItemAttachments>>();
			set => SetPropertyValue<CArray<InventoryItemAttachments>>(value);
		}

		[Ordinal(47)] 
		[RED("Abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		[Ordinal(48)] 
		[RED("PlacementSlots")] 
		public CArray<TweakDBID> PlacementSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(49)] 
		[RED("PrimaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(50)] 
		[RED("SecondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(51)] 
		[RED("IsPerkRequired")] 
		public CBool IsPerkRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("PerkRequiredName")] 
		public CString PerkRequiredName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(53)] 
		[RED("IsCrafted")] 
		public CBool IsCrafted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("SortData")] 
		public InventoryItemSortData SortData
		{
			get => GetPropertyValue<InventoryItemSortData>();
			set => SetPropertyValue<InventoryItemSortData>(value);
		}

		public InventoryItemData()
		{
			Empty = true;
			ID = new();
			DamageType = Enums.gamedataDamageType.Invalid;
			EquipmentArea = Enums.gamedataEquipmentArea.Invalid;
			ComparedQuality = Enums.gamedataQuality.Invalid;
			IsAvailable = true;
			PositionInBackpack = 4294967295;
			IsRequirementMet = true;
			IsEquippable = true;
			Requirement = new() { StatType = Enums.gamedataStatType.Invalid };
			EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid };
			EquipRequirements = new();
			Attachments = new();
			Abilities = new();
			PlacementSlots = new();
			PrimaryStats = new();
			SecondaryStats = new();
			SortData = new();
		}
	}
}
