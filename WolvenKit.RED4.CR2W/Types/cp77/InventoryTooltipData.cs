using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData : ATooltipData
	{
		private gameItemID _itemID;
		private CBool _isEquipped;
		private CBool _isLocked;
		private CBool _isVendorItem;
		private CBool _isCraftable;
		private CName _qualityStateName;
		private CString _description;
		private CString _additionalDescription;
		private CString _category;
		private CString _quality;
		private CString _itemName;
		private CFloat _price;
		private CFloat _buyPrice;
		private CFloat _unlockProgress;
		private CArray<InventoryTooltipData_StatData> _primaryStats;
		private CArray<InventoryTooltipData_StatData> _comparedStats;
		private CArray<InventoryTooltipData_StatData> _additionalStats;
		private CArray<InventoryTooltipData_StatData> _randomDamageTypes;
		private CArray<InventoryTooltipData_StatData> _recipeAdditionalStats;
		private CEnum<gamedataDamageType> _damageType;
		private CBool _isBroken;
		private CInt32 _levelRequired;
		private CArray<CName> _attachments;
		private CArray<gameInventoryItemAbility> _specialAbilities;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CBool _showCyclingDots;
		private CInt32 _numberOfCyclingDots;
		private CInt32 _selectedCyclingDot;
		private CEnum<gamedataQuality> _comparedQuality;
		private CBool _showIcon;
		private CInt32 _randomizedStatQuantity;
		private CEnum<gamedataItemType> _itemType;
		private CBool _hasPlayerSmartGunLink;
		private CInt32 _playerLevel;
		private CInt32 _playerStrenght;
		private CInt32 _playerReflexes;
		private CInt32 _playerStreetCred;
		private CArray<InventoryItemAttachments> _itemAttachments;
		private InventoryItemData _inventoryItemData;
		private CBool _overrideRarity;
		private InventoryTooltipData_QuickhackData _quickhackData;
		private CHandle<InventoryTooltiData_GrenadeData> _grenadeData;
		private CEnum<InventoryTooltipDisplayContext> _displayContext;
		private wCHandle<gameItemData> _parentItemData;
		private TweakDBID _slotID;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get
			{
				if (_isEquipped == null)
				{
					_isEquipped = (CBool) CR2WTypeManager.Create("Bool", "isEquipped", cr2w, this);
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

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isVendorItem")] 
		public CBool IsVendorItem
		{
			get
			{
				if (_isVendorItem == null)
				{
					_isVendorItem = (CBool) CR2WTypeManager.Create("Bool", "isVendorItem", cr2w, this);
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

		[Ordinal(4)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get
			{
				if (_isCraftable == null)
				{
					_isCraftable = (CBool) CR2WTypeManager.Create("Bool", "isCraftable", cr2w, this);
				}
				return _isCraftable;
			}
			set
			{
				if (_isCraftable == value)
				{
					return;
				}
				_isCraftable = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("qualityStateName")] 
		public CName QualityStateName
		{
			get
			{
				if (_qualityStateName == null)
				{
					_qualityStateName = (CName) CR2WTypeManager.Create("CName", "qualityStateName", cr2w, this);
				}
				return _qualityStateName;
			}
			set
			{
				if (_qualityStateName == value)
				{
					return;
				}
				_qualityStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
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

		[Ordinal(7)] 
		[RED("additionalDescription")] 
		public CString AdditionalDescription
		{
			get
			{
				if (_additionalDescription == null)
				{
					_additionalDescription = (CString) CR2WTypeManager.Create("String", "additionalDescription", cr2w, this);
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

		[Ordinal(8)] 
		[RED("category")] 
		public CString Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CString) CR2WTypeManager.Create("String", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("quality")] 
		public CString Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CString) CR2WTypeManager.Create("String", "quality", cr2w, this);
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

		[Ordinal(10)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CString) CR2WTypeManager.Create("String", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("price")] 
		public CFloat Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CFloat) CR2WTypeManager.Create("Float", "price", cr2w, this);
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

		[Ordinal(12)] 
		[RED("buyPrice")] 
		public CFloat BuyPrice
		{
			get
			{
				if (_buyPrice == null)
				{
					_buyPrice = (CFloat) CR2WTypeManager.Create("Float", "buyPrice", cr2w, this);
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

		[Ordinal(13)] 
		[RED("unlockProgress")] 
		public CFloat UnlockProgress
		{
			get
			{
				if (_unlockProgress == null)
				{
					_unlockProgress = (CFloat) CR2WTypeManager.Create("Float", "unlockProgress", cr2w, this);
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

		[Ordinal(14)] 
		[RED("primaryStats")] 
		public CArray<InventoryTooltipData_StatData> PrimaryStats
		{
			get
			{
				if (_primaryStats == null)
				{
					_primaryStats = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "primaryStats", cr2w, this);
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

		[Ordinal(15)] 
		[RED("comparedStats")] 
		public CArray<InventoryTooltipData_StatData> ComparedStats
		{
			get
			{
				if (_comparedStats == null)
				{
					_comparedStats = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "comparedStats", cr2w, this);
				}
				return _comparedStats;
			}
			set
			{
				if (_comparedStats == value)
				{
					return;
				}
				_comparedStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("additionalStats")] 
		public CArray<InventoryTooltipData_StatData> AdditionalStats
		{
			get
			{
				if (_additionalStats == null)
				{
					_additionalStats = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "additionalStats", cr2w, this);
				}
				return _additionalStats;
			}
			set
			{
				if (_additionalStats == value)
				{
					return;
				}
				_additionalStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("randomDamageTypes")] 
		public CArray<InventoryTooltipData_StatData> RandomDamageTypes
		{
			get
			{
				if (_randomDamageTypes == null)
				{
					_randomDamageTypes = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "randomDamageTypes", cr2w, this);
				}
				return _randomDamageTypes;
			}
			set
			{
				if (_randomDamageTypes == value)
				{
					return;
				}
				_randomDamageTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("recipeAdditionalStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeAdditionalStats
		{
			get
			{
				if (_recipeAdditionalStats == null)
				{
					_recipeAdditionalStats = (CArray<InventoryTooltipData_StatData>) CR2WTypeManager.Create("array:InventoryTooltipData_StatData", "recipeAdditionalStats", cr2w, this);
				}
				return _recipeAdditionalStats;
			}
			set
			{
				if (_recipeAdditionalStats == value)
				{
					return;
				}
				_recipeAdditionalStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get
			{
				if (_damageType == null)
				{
					_damageType = (CEnum<gamedataDamageType>) CR2WTypeManager.Create("gamedataDamageType", "damageType", cr2w, this);
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

		[Ordinal(20)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get
			{
				if (_isBroken == null)
				{
					_isBroken = (CBool) CR2WTypeManager.Create("Bool", "isBroken", cr2w, this);
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

		[Ordinal(21)] 
		[RED("levelRequired")] 
		public CInt32 LevelRequired
		{
			get
			{
				if (_levelRequired == null)
				{
					_levelRequired = (CInt32) CR2WTypeManager.Create("Int32", "levelRequired", cr2w, this);
				}
				return _levelRequired;
			}
			set
			{
				if (_levelRequired == value)
				{
					return;
				}
				_levelRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("attachments")] 
		public CArray<CName> Attachments
		{
			get
			{
				if (_attachments == null)
				{
					_attachments = (CArray<CName>) CR2WTypeManager.Create("array:CName", "attachments", cr2w, this);
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

		[Ordinal(23)] 
		[RED("specialAbilities")] 
		public CArray<gameInventoryItemAbility> SpecialAbilities
		{
			get
			{
				if (_specialAbilities == null)
				{
					_specialAbilities = (CArray<gameInventoryItemAbility>) CR2WTypeManager.Create("array:gameInventoryItemAbility", "specialAbilities", cr2w, this);
				}
				return _specialAbilities;
			}
			set
			{
				if (_specialAbilities == value)
				{
					return;
				}
				_specialAbilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("showCyclingDots")] 
		public CBool ShowCyclingDots
		{
			get
			{
				if (_showCyclingDots == null)
				{
					_showCyclingDots = (CBool) CR2WTypeManager.Create("Bool", "showCyclingDots", cr2w, this);
				}
				return _showCyclingDots;
			}
			set
			{
				if (_showCyclingDots == value)
				{
					return;
				}
				_showCyclingDots = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("numberOfCyclingDots")] 
		public CInt32 NumberOfCyclingDots
		{
			get
			{
				if (_numberOfCyclingDots == null)
				{
					_numberOfCyclingDots = (CInt32) CR2WTypeManager.Create("Int32", "numberOfCyclingDots", cr2w, this);
				}
				return _numberOfCyclingDots;
			}
			set
			{
				if (_numberOfCyclingDots == value)
				{
					return;
				}
				_numberOfCyclingDots = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("selectedCyclingDot")] 
		public CInt32 SelectedCyclingDot
		{
			get
			{
				if (_selectedCyclingDot == null)
				{
					_selectedCyclingDot = (CInt32) CR2WTypeManager.Create("Int32", "selectedCyclingDot", cr2w, this);
				}
				return _selectedCyclingDot;
			}
			set
			{
				if (_selectedCyclingDot == value)
				{
					return;
				}
				_selectedCyclingDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get
			{
				if (_comparedQuality == null)
				{
					_comparedQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "comparedQuality", cr2w, this);
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

		[Ordinal(29)] 
		[RED("showIcon")] 
		public CBool ShowIcon
		{
			get
			{
				if (_showIcon == null)
				{
					_showIcon = (CBool) CR2WTypeManager.Create("Bool", "showIcon", cr2w, this);
				}
				return _showIcon;
			}
			set
			{
				if (_showIcon == value)
				{
					return;
				}
				_showIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("randomizedStatQuantity")] 
		public CInt32 RandomizedStatQuantity
		{
			get
			{
				if (_randomizedStatQuantity == null)
				{
					_randomizedStatQuantity = (CInt32) CR2WTypeManager.Create("Int32", "randomizedStatQuantity", cr2w, this);
				}
				return _randomizedStatQuantity;
			}
			set
			{
				if (_randomizedStatQuantity == value)
				{
					return;
				}
				_randomizedStatQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
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

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		[Ordinal(34)] 
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

		[Ordinal(35)] 
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

		[Ordinal(36)] 
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

		[Ordinal(37)] 
		[RED("itemAttachments")] 
		public CArray<InventoryItemAttachments> ItemAttachments
		{
			get
			{
				if (_itemAttachments == null)
				{
					_itemAttachments = (CArray<InventoryItemAttachments>) CR2WTypeManager.Create("array:InventoryItemAttachments", "itemAttachments", cr2w, this);
				}
				return _itemAttachments;
			}
			set
			{
				if (_itemAttachments == value)
				{
					return;
				}
				_itemAttachments = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("inventoryItemData")] 
		public InventoryItemData InventoryItemData
		{
			get
			{
				if (_inventoryItemData == null)
				{
					_inventoryItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "inventoryItemData", cr2w, this);
				}
				return _inventoryItemData;
			}
			set
			{
				if (_inventoryItemData == value)
				{
					return;
				}
				_inventoryItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("overrideRarity")] 
		public CBool OverrideRarity
		{
			get
			{
				if (_overrideRarity == null)
				{
					_overrideRarity = (CBool) CR2WTypeManager.Create("Bool", "overrideRarity", cr2w, this);
				}
				return _overrideRarity;
			}
			set
			{
				if (_overrideRarity == value)
				{
					return;
				}
				_overrideRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("quickhackData")] 
		public InventoryTooltipData_QuickhackData QuickhackData
		{
			get
			{
				if (_quickhackData == null)
				{
					_quickhackData = (InventoryTooltipData_QuickhackData) CR2WTypeManager.Create("InventoryTooltipData_QuickhackData", "quickhackData", cr2w, this);
				}
				return _quickhackData;
			}
			set
			{
				if (_quickhackData == value)
				{
					return;
				}
				_quickhackData = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get
			{
				if (_grenadeData == null)
				{
					_grenadeData = (CHandle<InventoryTooltiData_GrenadeData>) CR2WTypeManager.Create("handle:InventoryTooltiData_GrenadeData", "grenadeData", cr2w, this);
				}
				return _grenadeData;
			}
			set
			{
				if (_grenadeData == value)
				{
					return;
				}
				_grenadeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get
			{
				if (_displayContext == null)
				{
					_displayContext = (CEnum<InventoryTooltipDisplayContext>) CR2WTypeManager.Create("InventoryTooltipDisplayContext", "displayContext", cr2w, this);
				}
				return _displayContext;
			}
			set
			{
				if (_displayContext == value)
				{
					return;
				}
				_displayContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("parentItemData")] 
		public wCHandle<gameItemData> ParentItemData
		{
			get
			{
				if (_parentItemData == null)
				{
					_parentItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "parentItemData", cr2w, this);
				}
				return _parentItemData;
			}
			set
			{
				if (_parentItemData == value)
				{
					return;
				}
				_parentItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
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

		[Ordinal(45)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get
			{
				if (_dEBUG_iconErrorInfo == null)
				{
					_dEBUG_iconErrorInfo = (CHandle<DEBUG_IconErrorInfo>) CR2WTypeManager.Create("handle:DEBUG_IconErrorInfo", "DEBUG_iconErrorInfo", cr2w, this);
				}
				return _dEBUG_iconErrorInfo;
			}
			set
			{
				if (_dEBUG_iconErrorInfo == value)
				{
					return;
				}
				_dEBUG_iconErrorInfo = value;
				PropertySet(this);
			}
		}

		public InventoryTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
