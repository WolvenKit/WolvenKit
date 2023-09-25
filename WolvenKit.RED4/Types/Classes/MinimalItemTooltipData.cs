using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(3)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("gameplayDescription")] 
		public CString GameplayDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("dpsValue")] 
		public CFloat DpsValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("armorValue")] 
		public CFloat ArmorValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("compareDPS")] 
		public CBool CompareDPS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("compareArmor")] 
		public CBool CompareArmor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(18)] 
		[RED("qualityF")] 
		public CFloat QualityF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("comparisonQualityF")] 
		public CFloat ComparisonQualityF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("projectilesPerShot")] 
		public CFloat ProjectilesPerShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>(value);
		}

		[Ordinal(23)] 
		[RED("ammoCount")] 
		public CInt32 AmmoCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("hasSilencer")] 
		public CBool HasSilencer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isSilencerInstalled")] 
		public CBool IsSilencerInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("isScopeInstalled")] 
		public CBool IsScopeInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("requirements")] 
		public CHandle<MinimalItemTooltipDataRequirements> Requirements
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipDataRequirements>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipDataRequirements>>(value);
		}

		[Ordinal(29)] 
		[RED("recipeData")] 
		public CHandle<MinimalItemTooltipRecipeData> RecipeData
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipRecipeData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipRecipeData>>(value);
		}

		[Ordinal(30)] 
		[RED("attributeAllocationStats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> AttributeAllocationStats
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>(value);
		}

		[Ordinal(31)] 
		[RED("stats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> Stats
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>(value);
		}

		[Ordinal(32)] 
		[RED("mods")] 
		public CArray<CHandle<MinimalItemTooltipModData>> Mods
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipModData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipModData>>>(value);
		}

		[Ordinal(33)] 
		[RED("dedicatedMods")] 
		public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipModAttachmentData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipModAttachmentData>>>(value);
		}

		[Ordinal(34)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>(value);
		}

		[Ordinal(35)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(36)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetPropertyValue<CEnum<gamedataItemCategory>>();
			set => SetPropertyValue<CEnum<gamedataItemCategory>>(value);
		}

		[Ordinal(37)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(38)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(39)] 
		[RED("itemPerkGroup")] 
		public CEnum<gamedataPerkWeaponGroupType> ItemPerkGroup
		{
			get => GetPropertyValue<CEnum<gamedataPerkWeaponGroupType>>();
			set => SetPropertyValue<CEnum<gamedataPerkWeaponGroupType>>(value);
		}

		[Ordinal(40)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetPropertyValue<CEnum<gameLootItemType>>();
			set => SetPropertyValue<CEnum<gameLootItemType>>(value);
		}

		[Ordinal(41)] 
		[RED("iconPath")] 
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(42)] 
		[RED("useMaleIcon")] 
		public CBool UseMaleIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("isPlus")] 
		public CFloat IsPlus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("hasRarity")] 
		public CBool HasRarity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("displayContextData")] 
		public CHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(50)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(51)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		[Ordinal(52)] 
		[RED("statsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemStatsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemStatsManager>>(value);
		}

		[Ordinal(53)] 
		[RED("statsManagerFetched")] 
		public CBool StatsManagerFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("managerRef")] 
		public CWeakHandle<UIInventoryItemsManager> ManagerRef
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		public MinimalItemTooltipData()
		{
			ItemID = new gameItemID();
			TransmogItem = new gameItemID();
			QualityF = -1.000000F;
			ComparisonQualityF = -1.000000F;
			AttributeAllocationStats = new();
			Stats = new();
			Mods = new();
			DedicatedMods = new();
			ItemType = Enums.gamedataItemType.Invalid;
			EquipmentArea = Enums.gamedataEquipmentArea.Invalid;
			ItemEvolution = Enums.gamedataWeaponEvolution.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
