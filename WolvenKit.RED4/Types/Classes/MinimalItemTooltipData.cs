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
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("dpsValue")] 
		public CFloat DpsValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("armorValue")] 
		public CFloat ArmorValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("compareDPS")] 
		public CBool CompareDPS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("compareArmor")] 
		public CBool CompareArmor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("projectilesPerShot")] 
		public CFloat ProjectilesPerShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>(value);
		}

		[Ordinal(19)] 
		[RED("ammoCount")] 
		public CInt32 AmmoCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("hasSilencer")] 
		public CBool HasSilencer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isSilencerInstalled")] 
		public CBool IsSilencerInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isScopeInstalled")] 
		public CBool IsScopeInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("requirements")] 
		public CHandle<MinimalItemTooltipDataRequirements> Requirements
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipDataRequirements>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipDataRequirements>>(value);
		}

		[Ordinal(25)] 
		[RED("recipeData")] 
		public CHandle<MinimalItemTooltipRecipeData> RecipeData
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipRecipeData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipRecipeData>>(value);
		}

		[Ordinal(26)] 
		[RED("stats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> Stats
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipStatData>>>(value);
		}

		[Ordinal(27)] 
		[RED("mods")] 
		public CArray<CHandle<MinimalItemTooltipModData>> Mods
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipModData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipModData>>>(value);
		}

		[Ordinal(28)] 
		[RED("dedicatedMods")] 
		public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods
		{
			get => GetPropertyValue<CArray<CHandle<MinimalItemTooltipModAttachmentData>>>();
			set => SetPropertyValue<CArray<CHandle<MinimalItemTooltipModAttachmentData>>>(value);
		}

		[Ordinal(29)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(30)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetPropertyValue<CEnum<gamedataItemCategory>>();
			set => SetPropertyValue<CEnum<gamedataItemCategory>>(value);
		}

		[Ordinal(31)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(32)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(33)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetPropertyValue<CEnum<gameLootItemType>>();
			set => SetPropertyValue<CEnum<gameLootItemType>>(value);
		}

		[Ordinal(34)] 
		[RED("iconPath")] 
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(35)] 
		[RED("useMaleIcon")] 
		public CBool UseMaleIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("hasRarity")] 
		public CBool HasRarity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(41)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		public MinimalItemTooltipData()
		{
			ItemID = new gameItemID();
			TransmogItem = new gameItemID();
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
