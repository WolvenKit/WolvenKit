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
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "Empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (gameItemID) CR2WTypeManager.Create("gameItemID", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "SlotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "Name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Quality")] 
		public CName Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CName) CR2WTypeManager.Create("CName", "Quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "Quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Ammo")] 
		public CInt32 Ammo
		{
			get
			{
				if (_ammo == null)
				{
					_ammo = (CInt32) CR2WTypeManager.Create("Int32", "Ammo", cr2w, this);
				}
				return _ammo;
			}
			set
			{
				if (_ammo == value)
				{
					return;
				}
				_ammo = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Shape")] 
		public CEnum<gameInventoryItemShape> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CEnum<gameInventoryItemShape>) CR2WTypeManager.Create("gameInventoryItemShape", "Shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ItemShape")] 
		public CEnum<gameInventoryItemShape> ItemShape
		{
			get
			{
				if (_itemShape == null)
				{
					_itemShape = (CEnum<gameInventoryItemShape>) CR2WTypeManager.Create("gameInventoryItemShape", "ItemShape", cr2w, this);
				}
				return _itemShape;
			}
			set
			{
				if (_itemShape == value)
				{
					return;
				}
				_itemShape = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get
			{
				if (_iconPath == null)
				{
					_iconPath = (CString) CR2WTypeManager.Create("String", "IconPath", cr2w, this);
				}
				return _iconPath;
			}
			set
			{
				if (_iconPath == value)
				{
					return;
				}
				_iconPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("CategoryName")] 
		public CString CategoryName
		{
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (CString) CR2WTypeManager.Create("String", "CategoryName", cr2w, this);
				}
				return _categoryName;
			}
			set
			{
				if (_categoryName == value)
				{
					return;
				}
				_categoryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ItemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "ItemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("LocalizedItemType")] 
		public CString LocalizedItemType
		{
			get
			{
				if (_localizedItemType == null)
				{
					_localizedItemType = (CString) CR2WTypeManager.Create("String", "LocalizedItemType", cr2w, this);
				}
				return _localizedItemType;
			}
			set
			{
				if (_localizedItemType == value)
				{
					return;
				}
				_localizedItemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "Description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("AdditionalDescription")] 
		public CString AdditionalDescription
		{
			get
			{
				if (_additionalDescription == null)
				{
					_additionalDescription = (CString) CR2WTypeManager.Create("String", "AdditionalDescription", cr2w, this);
				}
				return _additionalDescription;
			}
			set
			{
				if (_additionalDescription == value)
				{
					return;
				}
				_additionalDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("Price")] 
		public CFloat Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CFloat) CR2WTypeManager.Create("Float", "Price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("BuyPrice")] 
		public CFloat BuyPrice
		{
			get
			{
				if (_buyPrice == null)
				{
					_buyPrice = (CFloat) CR2WTypeManager.Create("Float", "BuyPrice", cr2w, this);
				}
				return _buyPrice;
			}
			set
			{
				if (_buyPrice == value)
				{
					return;
				}
				_buyPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("UnlockProgress")] 
		public CFloat UnlockProgress
		{
			get
			{
				if (_unlockProgress == null)
				{
					_unlockProgress = (CFloat) CR2WTypeManager.Create("Float", "UnlockProgress", cr2w, this);
				}
				return _unlockProgress;
			}
			set
			{
				if (_unlockProgress == value)
				{
					return;
				}
				_unlockProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("RequiredLevel")] 
		public CInt32 RequiredLevel
		{
			get
			{
				if (_requiredLevel == null)
				{
					_requiredLevel = (CInt32) CR2WTypeManager.Create("Int32", "RequiredLevel", cr2w, this);
				}
				return _requiredLevel;
			}
			set
			{
				if (_requiredLevel == value)
				{
					return;
				}
				_requiredLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ItemLevel")] 
		public CInt32 ItemLevel
		{
			get
			{
				if (_itemLevel == null)
				{
					_itemLevel = (CInt32) CR2WTypeManager.Create("Int32", "ItemLevel", cr2w, this);
				}
				return _itemLevel;
			}
			set
			{
				if (_itemLevel == value)
				{
					return;
				}
				_itemLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("DamageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (CEnum<gamedataDamageType>) CR2WTypeManager.Create("gamedataDamageType", "DamageType", cr2w, this);
				}
				return _damageType;
			}
			set
			{
				if (_damageType == value)
				{
					return;
				}
				_damageType = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "EquipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("ComparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get
			{
				if (_comparedQuality == null)
				{
					_comparedQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "ComparedQuality", cr2w, this);
				}
				return _comparedQuality;
			}
			set
			{
				if (_comparedQuality == value)
				{
					return;
				}
				_comparedQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("IsPart")] 
		public CBool IsPart
		{
			get
			{
				if (_isPart == null)
				{
					_isPart = (CBool) CR2WTypeManager.Create("Bool", "IsPart", cr2w, this);
				}
				return _isPart;
			}
			set
			{
				if (_isPart == value)
				{
					return;
				}
				_isPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("IsCraftingMaterial")] 
		public CBool IsCraftingMaterial
		{
			get
			{
				if (_isCraftingMaterial == null)
				{
					_isCraftingMaterial = (CBool) CR2WTypeManager.Create("Bool", "IsCraftingMaterial", cr2w, this);
				}
				return _isCraftingMaterial;
			}
			set
			{
				if (_isCraftingMaterial == value)
				{
					return;
				}
				_isCraftingMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get
			{
				if (_isEquipped == null)
				{
					_isEquipped = (CBool) CR2WTypeManager.Create("Bool", "IsEquipped", cr2w, this);
				}
				return _isEquipped;
			}
			set
			{
				if (_isEquipped == value)
				{
					return;
				}
				_isEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "IsNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("IsAvailable")] 
		public CBool IsAvailable
		{
			get
			{
				if (_isAvailable == null)
				{
					_isAvailable = (CBool) CR2WTypeManager.Create("Bool", "IsAvailable", cr2w, this);
				}
				return _isAvailable;
			}
			set
			{
				if (_isAvailable == value)
				{
					return;
				}
				_isAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get
			{
				if (_isVendorItem == null)
				{
					_isVendorItem = (CBool) CR2WTypeManager.Create("Bool", "IsVendorItem", cr2w, this);
				}
				return _isVendorItem;
			}
			set
			{
				if (_isVendorItem == value)
				{
					return;
				}
				_isVendorItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("IsBroken")] 
		public CBool IsBroken
		{
			get
			{
				if (_isBroken == null)
				{
					_isBroken = (CBool) CR2WTypeManager.Create("Bool", "IsBroken", cr2w, this);
				}
				return _isBroken;
			}
			set
			{
				if (_isBroken == value)
				{
					return;
				}
				_isBroken = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("SlotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "SlotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("PositionInBackpack")] 
		public CUInt32 PositionInBackpack
		{
			get
			{
				if (_positionInBackpack == null)
				{
					_positionInBackpack = (CUInt32) CR2WTypeManager.Create("Uint32", "PositionInBackpack", cr2w, this);
				}
				return _positionInBackpack;
			}
			set
			{
				if (_positionInBackpack == value)
				{
					return;
				}
				_positionInBackpack = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("IconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get
			{
				if (_iconGender == null)
				{
					_iconGender = (CEnum<gameItemIconGender>) CR2WTypeManager.Create("gameItemIconGender", "IconGender", cr2w, this);
				}
				return _iconGender;
			}
			set
			{
				if (_iconGender == value)
				{
					return;
				}
				_iconGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("GameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "GameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get
			{
				if (_hasPlayerSmartGunLink == null)
				{
					_hasPlayerSmartGunLink = (CBool) CR2WTypeManager.Create("Bool", "HasPlayerSmartGunLink", cr2w, this);
				}
				return _hasPlayerSmartGunLink;
			}
			set
			{
				if (_hasPlayerSmartGunLink == value)
				{
					return;
				}
				_hasPlayerSmartGunLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get
			{
				if (_playerLevel == null)
				{
					_playerLevel = (CInt32) CR2WTypeManager.Create("Int32", "PlayerLevel", cr2w, this);
				}
				return _playerLevel;
			}
			set
			{
				if (_playerLevel == value)
				{
					return;
				}
				_playerLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get
			{
				if (_playerStrenght == null)
				{
					_playerStrenght = (CInt32) CR2WTypeManager.Create("Int32", "PlayerStrenght", cr2w, this);
				}
				return _playerStrenght;
			}
			set
			{
				if (_playerStrenght == value)
				{
					return;
				}
				_playerStrenght = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get
			{
				if (_playerReflexes == null)
				{
					_playerReflexes = (CInt32) CR2WTypeManager.Create("Int32", "PlayerReflexes", cr2w, this);
				}
				return _playerReflexes;
			}
			set
			{
				if (_playerReflexes == value)
				{
					return;
				}
				_playerReflexes = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get
			{
				if (_playerStreetCred == null)
				{
					_playerStreetCred = (CInt32) CR2WTypeManager.Create("Int32", "PlayerStreetCred", cr2w, this);
				}
				return _playerStreetCred;
			}
			set
			{
				if (_playerStreetCred == value)
				{
					return;
				}
				_playerStreetCred = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("IsRequirementMet")] 
		public CBool IsRequirementMet
		{
			get
			{
				if (_isRequirementMet == null)
				{
					_isRequirementMet = (CBool) CR2WTypeManager.Create("Bool", "IsRequirementMet", cr2w, this);
				}
				return _isRequirementMet;
			}
			set
			{
				if (_isRequirementMet == value)
				{
					return;
				}
				_isRequirementMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("IsEquippable")] 
		public CBool IsEquippable
		{
			get
			{
				if (_isEquippable == null)
				{
					_isEquippable = (CBool) CR2WTypeManager.Create("Bool", "IsEquippable", cr2w, this);
				}
				return _isEquippable;
			}
			set
			{
				if (_isEquippable == value)
				{
					return;
				}
				_isEquippable = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("Requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get
			{
				if (_requirement == null)
				{
					_requirement = (gameSItemStackRequirementData) CR2WTypeManager.Create("gameSItemStackRequirementData", "Requirement", cr2w, this);
				}
				return _requirement;
			}
			set
			{
				if (_requirement == value)
				{
					return;
				}
				_requirement = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("EquipRequirement")] 
		public gameSItemStackRequirementData EquipRequirement
		{
			get
			{
				if (_equipRequirement == null)
				{
					_equipRequirement = (gameSItemStackRequirementData) CR2WTypeManager.Create("gameSItemStackRequirementData", "EquipRequirement", cr2w, this);
				}
				return _equipRequirement;
			}
			set
			{
				if (_equipRequirement == value)
				{
					return;
				}
				_equipRequirement = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("LootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get
			{
				if (_lootItemType == null)
				{
					_lootItemType = (CEnum<gameLootItemType>) CR2WTypeManager.Create("gameLootItemType", "LootItemType", cr2w, this);
				}
				return _lootItemType;
			}
			set
			{
				if (_lootItemType == value)
				{
					return;
				}
				_lootItemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("Attachments")] 
		public CArray<InventoryItemAttachments> Attachments
		{
			get
			{
				if (_attachments == null)
				{
					_attachments = (CArray<InventoryItemAttachments>) CR2WTypeManager.Create("array:InventoryItemAttachments", "Attachments", cr2w, this);
				}
				return _attachments;
			}
			set
			{
				if (_attachments == value)
				{
					return;
				}
				_attachments = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("Abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get
			{
				if (_abilities == null)
				{
					_abilities = (CArray<gameInventoryItemAbility>) CR2WTypeManager.Create("array:gameInventoryItemAbility", "Abilities", cr2w, this);
				}
				return _abilities;
			}
			set
			{
				if (_abilities == value)
				{
					return;
				}
				_abilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("PlacementSlots")] 
		public CArray<TweakDBID> PlacementSlots
		{
			get
			{
				if (_placementSlots == null)
				{
					_placementSlots = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "PlacementSlots", cr2w, this);
				}
				return _placementSlots;
			}
			set
			{
				if (_placementSlots == value)
				{
					return;
				}
				_placementSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("PrimaryStats")] 
		public CArray<gameStatViewData> PrimaryStats
		{
			get
			{
				if (_primaryStats == null)
				{
					_primaryStats = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "PrimaryStats", cr2w, this);
				}
				return _primaryStats;
			}
			set
			{
				if (_primaryStats == value)
				{
					return;
				}
				_primaryStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("SecondaryStats")] 
		public CArray<gameStatViewData> SecondaryStats
		{
			get
			{
				if (_secondaryStats == null)
				{
					_secondaryStats = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "SecondaryStats", cr2w, this);
				}
				return _secondaryStats;
			}
			set
			{
				if (_secondaryStats == value)
				{
					return;
				}
				_secondaryStats = value;
				PropertySet(this);
			}
		}

		public InventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
