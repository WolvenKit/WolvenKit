using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemData : CVariable
	{
		private CBool _empty;
		private gameItemID _iD;
		private TweakDBID _slotID;
		private CString _name;
		private CName _quality;
		private CInt32 _quantity;
		private CInt32 _ammo;
		private CEnum<gameInventoryItemShape> _shape;
		private CEnum<gameInventoryItemShape> _itemShape;
		private CString _iconPath;
		private CString _categoryName;
		private CEnum<gamedataItemType> _itemType;
		private CString _localizedItemType;
		private CString _description;
		private CString _additionalDescription;
		private CFloat _price;
		private CFloat _buyPrice;
		private CFloat _unlockProgress;
		private CInt32 _requiredLevel;
		private CInt32 _itemLevel;
		private CEnum<gamedataDamageType> _damageType;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataQuality> _comparedQuality;
		private CBool _isPart;
		private CBool _isCraftingMaterial;
		private CBool _isEquipped;
		private CBool _isNew;
		private CBool _isAvailable;
		private CBool _isVendorItem;
		private CBool _isBroken;
		private CInt32 _slotIndex;
		private CUInt32 _positionInBackpack;
		private CEnum<gameItemIconGender> _iconGender;
		private wCHandle<gameItemData> _gameItemData;
		private CBool _hasPlayerSmartGunLink;
		private CInt32 _playerLevel;
		private CInt32 _playerStrenght;
		private CInt32 _playerReflexes;
		private CInt32 _playerStreetCred;
		private CBool _isRequirementMet;
		private CBool _isEquippable;
		private gameSItemStackRequirementData _requirement;
		private gameSItemStackRequirementData _equipRequirement;
		private CEnum<gameLootItemType> _lootItemType;
		private CArray<InventoryItemAttachments> _attachments;
		private CArray<gameInventoryItemAbility> _abilities;
		private CArray<TweakDBID> _placementSlots;
		private CArray<gameStatViewData> _primaryStats;
		private CArray<gameStatViewData> _secondaryStats;

		[Ordinal(0)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(2)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(3)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(4)] 
		[RED("Quality")] 
		public CName Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(5)] 
		[RED("Quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(6)] 
		[RED("Ammo")] 
		public CInt32 Ammo
		{
			get => GetProperty(ref _ammo);
			set => SetProperty(ref _ammo, value);
		}

		[Ordinal(7)] 
		[RED("Shape")] 
		public CEnum<gameInventoryItemShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(8)] 
		[RED("ItemShape")] 
		public CEnum<gameInventoryItemShape> ItemShape
		{
			get => GetProperty(ref _itemShape);
			set => SetProperty(ref _itemShape, value);
		}

		[Ordinal(9)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(10)] 
		[RED("CategoryName")] 
		public CString CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		[Ordinal(11)] 
		[RED("ItemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(12)] 
		[RED("LocalizedItemType")] 
		public CString LocalizedItemType
		{
			get => GetProperty(ref _localizedItemType);
			set => SetProperty(ref _localizedItemType, value);
		}

		[Ordinal(13)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(14)] 
		[RED("AdditionalDescription")] 
		public CString AdditionalDescription
		{
			get => GetProperty(ref _additionalDescription);
			set => SetProperty(ref _additionalDescription, value);
		}

		[Ordinal(15)] 
		[RED("Price")] 
		public CFloat Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(16)] 
		[RED("BuyPrice")] 
		public CFloat BuyPrice
		{
			get => GetProperty(ref _buyPrice);
			set => SetProperty(ref _buyPrice, value);
		}

		[Ordinal(17)] 
		[RED("UnlockProgress")] 
		public CFloat UnlockProgress
		{
			get => GetProperty(ref _unlockProgress);
			set => SetProperty(ref _unlockProgress, value);
		}

		[Ordinal(18)] 
		[RED("RequiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		[Ordinal(19)] 
		[RED("ItemLevel")] 
		public CInt32 ItemLevel
		{
			get => GetProperty(ref _itemLevel);
			set => SetProperty(ref _itemLevel, value);
		}

		[Ordinal(20)] 
		[RED("DamageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(21)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(22)] 
		[RED("ComparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetProperty(ref _comparedQuality);
			set => SetProperty(ref _comparedQuality, value);
		}

		[Ordinal(23)] 
		[RED("IsPart")] 
		public CBool IsPart
		{
			get => GetProperty(ref _isPart);
			set => SetProperty(ref _isPart, value);
		}

		[Ordinal(24)] 
		[RED("IsCraftingMaterial")] 
		public CBool IsCraftingMaterial
		{
			get => GetProperty(ref _isCraftingMaterial);
			set => SetProperty(ref _isCraftingMaterial, value);
		}

		[Ordinal(25)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(26)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(27)] 
		[RED("IsAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		[Ordinal(28)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetProperty(ref _isVendorItem);
			set => SetProperty(ref _isVendorItem, value);
		}

		[Ordinal(29)] 
		[RED("IsBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		[Ordinal(30)] 
		[RED("SlotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(31)] 
		[RED("PositionInBackpack")] 
		public CUInt32 PositionInBackpack
		{
			get => GetProperty(ref _positionInBackpack);
			set => SetProperty(ref _positionInBackpack, value);
		}

		[Ordinal(32)] 
		[RED("IconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetProperty(ref _iconGender);
			set => SetProperty(ref _iconGender, value);
		}

		[Ordinal(33)] 
		[RED("GameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(34)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get => GetProperty(ref _hasPlayerSmartGunLink);
			set => SetProperty(ref _hasPlayerSmartGunLink, value);
		}

		[Ordinal(35)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(36)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get => GetProperty(ref _playerStrenght);
			set => SetProperty(ref _playerStrenght, value);
		}

		[Ordinal(37)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get => GetProperty(ref _playerReflexes);
			set => SetProperty(ref _playerReflexes, value);
		}

		[Ordinal(38)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get => GetProperty(ref _playerStreetCred);
			set => SetProperty(ref _playerStreetCred, value);
		}

		[Ordinal(39)] 
		[RED("IsRequirementMet")] 
		public CBool IsRequirementMet
		{
			get => GetProperty(ref _isRequirementMet);
			set => SetProperty(ref _isRequirementMet, value);
		}

		[Ordinal(40)] 
		[RED("IsEquippable")] 
		public CBool IsEquippable
		{
			get => GetProperty(ref _isEquippable);
			set => SetProperty(ref _isEquippable, value);
		}

		[Ordinal(41)] 
		[RED("Requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetProperty(ref _requirement);
			set => SetProperty(ref _requirement, value);
		}

		[Ordinal(42)] 
		[RED("EquipRequirement")] 
		public gameSItemStackRequirementData EquipRequirement
		{
			get => GetProperty(ref _equipRequirement);
			set => SetProperty(ref _equipRequirement, value);
		}

		[Ordinal(43)] 
		[RED("LootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetProperty(ref _lootItemType);
			set => SetProperty(ref _lootItemType, value);
		}

		[Ordinal(44)] 
		[RED("Attachments")] 
		public CArray<InventoryItemAttachments> Attachments
		{
			get => GetProperty(ref _attachments);
			set => SetProperty(ref _attachments, value);
		}

		[Ordinal(45)] 
		[RED("Abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}

		[Ordinal(46)] 
		[RED("PlacementSlots")] 
		public CArray<TweakDBID> PlacementSlots
		{
			get => GetProperty(ref _placementSlots);
			set => SetProperty(ref _placementSlots, value);
		}

		[Ordinal(47)] 
		[RED("PrimaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get => GetProperty(ref _primaryStats);
			set => SetProperty(ref _primaryStats, value);
		}

		[Ordinal(48)] 
		[RED("SecondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get => GetProperty(ref _secondaryStats);
			set => SetProperty(ref _secondaryStats, value);
		}

		public InventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
