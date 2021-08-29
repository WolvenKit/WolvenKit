using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimalItemTooltipData : ATooltipData
	{
		private gameItemID _itemID;
		private TweakDBID _itemTweakID;
		private CWeakHandle<gameItemData> _itemData;
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
		private CEnum<gameLootItemType> _lootItemType;
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
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get => GetProperty(ref _itemTweakID);
			set => SetProperty(ref _itemTweakID, value);
		}

		[Ordinal(2)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(3)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(5)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(6)] 
		[RED("description")] 
		public CName Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(7)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(8)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(9)] 
		[RED("dpsValue")] 
		public CFloat DpsValue
		{
			get => GetProperty(ref _dpsValue);
			set => SetProperty(ref _dpsValue, value);
		}

		[Ordinal(10)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetProperty(ref _dpsDiff);
			set => SetProperty(ref _dpsDiff, value);
		}

		[Ordinal(11)] 
		[RED("armorValue")] 
		public CFloat ArmorValue
		{
			get => GetProperty(ref _armorValue);
			set => SetProperty(ref _armorValue, value);
		}

		[Ordinal(12)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetProperty(ref _armorDiff);
			set => SetProperty(ref _armorDiff, value);
		}

		[Ordinal(13)] 
		[RED("compareDPS")] 
		public CBool CompareDPS
		{
			get => GetProperty(ref _compareDPS);
			set => SetProperty(ref _compareDPS, value);
		}

		[Ordinal(14)] 
		[RED("compareArmor")] 
		public CBool CompareArmor
		{
			get => GetProperty(ref _compareArmor);
			set => SetProperty(ref _compareArmor, value);
		}

		[Ordinal(15)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetProperty(ref _attackSpeed);
			set => SetProperty(ref _attackSpeed, value);
		}

		[Ordinal(16)] 
		[RED("projectilesPerShot")] 
		public CFloat ProjectilesPerShot
		{
			get => GetProperty(ref _projectilesPerShot);
			set => SetProperty(ref _projectilesPerShot, value);
		}

		[Ordinal(17)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetProperty(ref _grenadeData);
			set => SetProperty(ref _grenadeData, value);
		}

		[Ordinal(18)] 
		[RED("ammoCount")] 
		public CInt32 AmmoCount
		{
			get => GetProperty(ref _ammoCount);
			set => SetProperty(ref _ammoCount, value);
		}

		[Ordinal(19)] 
		[RED("hasSilencer")] 
		public CBool HasSilencer
		{
			get => GetProperty(ref _hasSilencer);
			set => SetProperty(ref _hasSilencer, value);
		}

		[Ordinal(20)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetProperty(ref _hasScope);
			set => SetProperty(ref _hasScope, value);
		}

		[Ordinal(21)] 
		[RED("isSilencerInstalled")] 
		public CBool IsSilencerInstalled
		{
			get => GetProperty(ref _isSilencerInstalled);
			set => SetProperty(ref _isSilencerInstalled, value);
		}

		[Ordinal(22)] 
		[RED("isScopeInstalled")] 
		public CBool IsScopeInstalled
		{
			get => GetProperty(ref _isScopeInstalled);
			set => SetProperty(ref _isScopeInstalled, value);
		}

		[Ordinal(23)] 
		[RED("requirements")] 
		public CHandle<MinimalItemTooltipDataRequirements> Requirements
		{
			get => GetProperty(ref _requirements);
			set => SetProperty(ref _requirements, value);
		}

		[Ordinal(24)] 
		[RED("recipeData")] 
		public CHandle<MinimalItemTooltipRecipeData> RecipeData
		{
			get => GetProperty(ref _recipeData);
			set => SetProperty(ref _recipeData, value);
		}

		[Ordinal(25)] 
		[RED("stats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> Stats
		{
			get => GetProperty(ref _stats);
			set => SetProperty(ref _stats, value);
		}

		[Ordinal(26)] 
		[RED("mods")] 
		public CArray<CHandle<MinimalItemTooltipModData>> Mods
		{
			get => GetProperty(ref _mods);
			set => SetProperty(ref _mods, value);
		}

		[Ordinal(27)] 
		[RED("dedicatedMods")] 
		public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods
		{
			get => GetProperty(ref _dedicatedMods);
			set => SetProperty(ref _dedicatedMods, value);
		}

		[Ordinal(28)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(29)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(30)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(31)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetProperty(ref _itemEvolution);
			set => SetProperty(ref _itemEvolution, value);
		}

		[Ordinal(32)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetProperty(ref _lootItemType);
			set => SetProperty(ref _lootItemType, value);
		}

		[Ordinal(33)] 
		[RED("iconPath")] 
		public CString IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(34)] 
		[RED("useMaleIcon")] 
		public CBool UseMaleIcon
		{
			get => GetProperty(ref _useMaleIcon);
			set => SetProperty(ref _useMaleIcon, value);
		}

		[Ordinal(35)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(36)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetProperty(ref _isCrafted);
			set => SetProperty(ref _isCrafted, value);
		}

		[Ordinal(37)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(38)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(39)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}
	}
}
