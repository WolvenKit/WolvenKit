using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipData : ATooltipData
	{
		private gameItemID _itemID;
		private TweakDBID _itemTweakID;
		private wCHandle<gameItemData> _itemData;
		private CString _itemName;
		private CEnum<gamedataQuality> _quality;
		private CInt32 _quantity;
		private CName _description;
		private CFloat _weight;
		private CFloat _price;
		private CFloat _dpsValue;
		private CFloat _dpsDiff;
		private CFloat _armorValue;
		private CFloat _armorDiff;
		private CBool _compareDPS;
		private CBool _compareArmor;
		private CFloat _attackSpeed;
		private CFloat _projectilesPerShot;
		private CHandle<InventoryTooltiData_GrenadeData> _grenadeData;
		private CInt32 _ammoCount;
		private CBool _hasSilencer;
		private CBool _hasScope;
		private CBool _isSilencerInstalled;
		private CBool _isScopeInstalled;
		private CHandle<MinimalItemTooltipDataRequirements> _requirements;
		private CHandle<MinimalItemTooltipRecipeData> _recipeData;
		private CArray<CHandle<MinimalItemTooltipStatData>> _stats;
		private CArray<CHandle<MinimalItemTooltipModData>> _mods;
		private CArray<CHandle<MinimalItemTooltipModAttachmentData>> _dedicatedMods;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataItemCategory> _itemCategory;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataWeaponEvolution> _itemEvolution;
		private CString _iconPath;
		private CBool _useMaleIcon;
		private CBool _isIconic;
		private CBool _isCrafted;
		private CBool _isEquipped;
		private CEnum<InventoryTooltipDisplayContext> _displayContext;
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
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get
			{
				if (_itemTweakID == null)
				{
					_itemTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemTweakID", cr2w, this);
				}
				return _itemTweakID;
			}
			set
			{
				if (_itemTweakID == value)
				{
					return;
				}
				_itemTweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "quality", cr2w, this);
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
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
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
		[RED("description")] 
		public CName Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CName) CR2WTypeManager.Create("CName", "description", cr2w, this);
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
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("dpsValue")] 
		public CFloat DpsValue
		{
			get
			{
				if (_dpsValue == null)
				{
					_dpsValue = (CFloat) CR2WTypeManager.Create("Float", "dpsValue", cr2w, this);
				}
				return _dpsValue;
			}
			set
			{
				if (_dpsValue == value)
				{
					return;
				}
				_dpsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get
			{
				if (_dpsDiff == null)
				{
					_dpsDiff = (CFloat) CR2WTypeManager.Create("Float", "dpsDiff", cr2w, this);
				}
				return _dpsDiff;
			}
			set
			{
				if (_dpsDiff == value)
				{
					return;
				}
				_dpsDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("armorValue")] 
		public CFloat ArmorValue
		{
			get
			{
				if (_armorValue == null)
				{
					_armorValue = (CFloat) CR2WTypeManager.Create("Float", "armorValue", cr2w, this);
				}
				return _armorValue;
			}
			set
			{
				if (_armorValue == value)
				{
					return;
				}
				_armorValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get
			{
				if (_armorDiff == null)
				{
					_armorDiff = (CFloat) CR2WTypeManager.Create("Float", "armorDiff", cr2w, this);
				}
				return _armorDiff;
			}
			set
			{
				if (_armorDiff == value)
				{
					return;
				}
				_armorDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("compareDPS")] 
		public CBool CompareDPS
		{
			get
			{
				if (_compareDPS == null)
				{
					_compareDPS = (CBool) CR2WTypeManager.Create("Bool", "compareDPS", cr2w, this);
				}
				return _compareDPS;
			}
			set
			{
				if (_compareDPS == value)
				{
					return;
				}
				_compareDPS = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("compareArmor")] 
		public CBool CompareArmor
		{
			get
			{
				if (_compareArmor == null)
				{
					_compareArmor = (CBool) CR2WTypeManager.Create("Bool", "compareArmor", cr2w, this);
				}
				return _compareArmor;
			}
			set
			{
				if (_compareArmor == value)
				{
					return;
				}
				_compareArmor = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get
			{
				if (_attackSpeed == null)
				{
					_attackSpeed = (CFloat) CR2WTypeManager.Create("Float", "attackSpeed", cr2w, this);
				}
				return _attackSpeed;
			}
			set
			{
				if (_attackSpeed == value)
				{
					return;
				}
				_attackSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("projectilesPerShot")] 
		public CFloat ProjectilesPerShot
		{
			get
			{
				if (_projectilesPerShot == null)
				{
					_projectilesPerShot = (CFloat) CR2WTypeManager.Create("Float", "projectilesPerShot", cr2w, this);
				}
				return _projectilesPerShot;
			}
			set
			{
				if (_projectilesPerShot == value)
				{
					return;
				}
				_projectilesPerShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("ammoCount")] 
		public CInt32 AmmoCount
		{
			get
			{
				if (_ammoCount == null)
				{
					_ammoCount = (CInt32) CR2WTypeManager.Create("Int32", "ammoCount", cr2w, this);
				}
				return _ammoCount;
			}
			set
			{
				if (_ammoCount == value)
				{
					return;
				}
				_ammoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("hasSilencer")] 
		public CBool HasSilencer
		{
			get
			{
				if (_hasSilencer == null)
				{
					_hasSilencer = (CBool) CR2WTypeManager.Create("Bool", "hasSilencer", cr2w, this);
				}
				return _hasSilencer;
			}
			set
			{
				if (_hasSilencer == value)
				{
					return;
				}
				_hasSilencer = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get
			{
				if (_hasScope == null)
				{
					_hasScope = (CBool) CR2WTypeManager.Create("Bool", "hasScope", cr2w, this);
				}
				return _hasScope;
			}
			set
			{
				if (_hasScope == value)
				{
					return;
				}
				_hasScope = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isSilencerInstalled")] 
		public CBool IsSilencerInstalled
		{
			get
			{
				if (_isSilencerInstalled == null)
				{
					_isSilencerInstalled = (CBool) CR2WTypeManager.Create("Bool", "isSilencerInstalled", cr2w, this);
				}
				return _isSilencerInstalled;
			}
			set
			{
				if (_isSilencerInstalled == value)
				{
					return;
				}
				_isSilencerInstalled = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isScopeInstalled")] 
		public CBool IsScopeInstalled
		{
			get
			{
				if (_isScopeInstalled == null)
				{
					_isScopeInstalled = (CBool) CR2WTypeManager.Create("Bool", "isScopeInstalled", cr2w, this);
				}
				return _isScopeInstalled;
			}
			set
			{
				if (_isScopeInstalled == value)
				{
					return;
				}
				_isScopeInstalled = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("requirements")] 
		public CHandle<MinimalItemTooltipDataRequirements> Requirements
		{
			get
			{
				if (_requirements == null)
				{
					_requirements = (CHandle<MinimalItemTooltipDataRequirements>) CR2WTypeManager.Create("handle:MinimalItemTooltipDataRequirements", "requirements", cr2w, this);
				}
				return _requirements;
			}
			set
			{
				if (_requirements == value)
				{
					return;
				}
				_requirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("recipeData")] 
		public CHandle<MinimalItemTooltipRecipeData> RecipeData
		{
			get
			{
				if (_recipeData == null)
				{
					_recipeData = (CHandle<MinimalItemTooltipRecipeData>) CR2WTypeManager.Create("handle:MinimalItemTooltipRecipeData", "recipeData", cr2w, this);
				}
				return _recipeData;
			}
			set
			{
				if (_recipeData == value)
				{
					return;
				}
				_recipeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("stats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> Stats
		{
			get
			{
				if (_stats == null)
				{
					_stats = (CArray<CHandle<MinimalItemTooltipStatData>>) CR2WTypeManager.Create("array:handle:MinimalItemTooltipStatData", "stats", cr2w, this);
				}
				return _stats;
			}
			set
			{
				if (_stats == value)
				{
					return;
				}
				_stats = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("mods")] 
		public CArray<CHandle<MinimalItemTooltipModData>> Mods
		{
			get
			{
				if (_mods == null)
				{
					_mods = (CArray<CHandle<MinimalItemTooltipModData>>) CR2WTypeManager.Create("array:handle:MinimalItemTooltipModData", "mods", cr2w, this);
				}
				return _mods;
			}
			set
			{
				if (_mods == value)
				{
					return;
				}
				_mods = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("dedicatedMods")] 
		public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods
		{
			get
			{
				if (_dedicatedMods == null)
				{
					_dedicatedMods = (CArray<CHandle<MinimalItemTooltipModAttachmentData>>) CR2WTypeManager.Create("array:handle:MinimalItemTooltipModAttachmentData", "dedicatedMods", cr2w, this);
				}
				return _dedicatedMods;
			}
			set
			{
				if (_dedicatedMods == value)
				{
					return;
				}
				_dedicatedMods = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
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

		[Ordinal(29)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get
			{
				if (_itemCategory == null)
				{
					_itemCategory = (CEnum<gamedataItemCategory>) CR2WTypeManager.Create("gamedataItemCategory", "itemCategory", cr2w, this);
				}
				return _itemCategory;
			}
			set
			{
				if (_itemCategory == value)
				{
					return;
				}
				_itemCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
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

		[Ordinal(31)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get
			{
				if (_itemEvolution == null)
				{
					_itemEvolution = (CEnum<gamedataWeaponEvolution>) CR2WTypeManager.Create("gamedataWeaponEvolution", "itemEvolution", cr2w, this);
				}
				return _itemEvolution;
			}
			set
			{
				if (_itemEvolution == value)
				{
					return;
				}
				_itemEvolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("iconPath")] 
		public CString IconPath
		{
			get
			{
				if (_iconPath == null)
				{
					_iconPath = (CString) CR2WTypeManager.Create("String", "iconPath", cr2w, this);
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

		[Ordinal(33)] 
		[RED("useMaleIcon")] 
		public CBool UseMaleIcon
		{
			get
			{
				if (_useMaleIcon == null)
				{
					_useMaleIcon = (CBool) CR2WTypeManager.Create("Bool", "useMaleIcon", cr2w, this);
				}
				return _useMaleIcon;
			}
			set
			{
				if (_useMaleIcon == value)
				{
					return;
				}
				_useMaleIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get
			{
				if (_isCrafted == null)
				{
					_isCrafted = (CBool) CR2WTypeManager.Create("Bool", "isCrafted", cr2w, this);
				}
				return _isCrafted;
			}
			set
			{
				if (_isCrafted == value)
				{
					return;
				}
				_isCrafted = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
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

		[Ordinal(37)] 
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

		[Ordinal(38)] 
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

		public MinimalItemTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
