using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isPerkRequired")] 
		public CBool IsPerkRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("qualityStateName")] 
		public CName QualityStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("additionalDescription")] 
		public CString AdditionalDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("gameplayDescription")] 
		public CString GameplayDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("category")] 
		public CString Category
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("quality")] 
		public CString Quality
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("perkRequiredName")] 
		public CString PerkRequiredName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("buyPrice")] 
		public CFloat BuyPrice
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("unlockProgress")] 
		public CFloat UnlockProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("primaryStats")] 
		public CArray<InventoryTooltipData_StatData> PrimaryStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(18)] 
		[RED("comparedStats")] 
		public CArray<InventoryTooltipData_StatData> ComparedStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(19)] 
		[RED("additionalStats")] 
		public CArray<InventoryTooltipData_StatData> AdditionalStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(20)] 
		[RED("randomDamageTypes")] 
		public CArray<InventoryTooltipData_StatData> RandomDamageTypes
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(21)] 
		[RED("recipeAdditionalStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeAdditionalStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(22)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(23)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("levelRequired")] 
		public CInt32 LevelRequired
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("attachments")] 
		public CArray<CName> Attachments
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(26)] 
		[RED("specialAbilities")] 
		public CArray<gameInventoryItemAbility> SpecialAbilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		[Ordinal(27)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(28)] 
		[RED("showCyclingDots")] 
		public CBool ShowCyclingDots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("numberOfCyclingDots")] 
		public CInt32 NumberOfCyclingDots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("selectedCyclingDot")] 
		public CInt32 SelectedCyclingDot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(32)] 
		[RED("qualityF")] 
		public CFloat QualityF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("comparisonQualityF")] 
		public CFloat ComparisonQualityF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("showIcon")] 
		public CBool ShowIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(35)] 
		[RED("randomizedStatQuantity")] 
		public CInt32 RandomizedStatQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(36)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(37)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(39)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(40)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(42)] 
		[RED("itemAttachments")] 
		public CArray<CHandle<gameInventoryItemAttachments>> ItemAttachments
		{
			get => GetPropertyValue<CArray<CHandle<gameInventoryItemAttachments>>>();
			set => SetPropertyValue<CArray<CHandle<gameInventoryItemAttachments>>>(value);
		}

		[Ordinal(43)] 
		[RED("inventoryItemData")] 
		public gameInventoryItemData InventoryItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(44)] 
		[RED("overrideRarity")] 
		public CBool OverrideRarity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("quickhackData")] 
		public InventoryTooltipData_QuickhackData QuickhackData
		{
			get => GetPropertyValue<InventoryTooltipData_QuickhackData>();
			set => SetPropertyValue<InventoryTooltipData_QuickhackData>(value);
		}

		[Ordinal(46)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>(value);
		}

		[Ordinal(47)] 
		[RED("cyberdeckData")] 
		public CHandle<InventoryTooltipData_CyberdeckData> CyberdeckData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData_CyberdeckData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData_CyberdeckData>>(value);
		}

		[Ordinal(48)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_CyberwareUpgradeData>>(value);
		}

		[Ordinal(49)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(50)] 
		[RED("parentItemData")] 
		public CWeakHandle<gameItemData> ParentItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(51)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(52)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(53)] 
		[RED("managerRef")] 
		public CWeakHandle<UIInventoryItemsManager> ManagerRef
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		[Ordinal(54)] 
		[RED("statsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemStatsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemStatsManager>>(value);
		}

		[Ordinal(55)] 
		[RED("statsManagerFetched")] 
		public CBool StatsManagerFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		public InventoryTooltipData()
		{
			ItemID = new gameItemID();
			PrimaryStats = new();
			ComparedStats = new();
			AdditionalStats = new();
			RandomDamageTypes = new();
			RecipeAdditionalStats = new();
			Attachments = new();
			SpecialAbilities = new();
			ComparedQuality = Enums.gamedataQuality.Invalid;
			ComparisonQualityF = -1.000000F;
			ItemType = Enums.gamedataItemType.Invalid;
			ItemAttachments = new();
			InventoryItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			QuickhackData = new InventoryTooltipData_QuickhackData { AttackEffects = new() };
			TransmogItem = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
