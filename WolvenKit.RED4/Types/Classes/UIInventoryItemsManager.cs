using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get => GetPropertyValue<CHandle<gameuiIconsNameResolver>>();
			set => SetPropertyValue<CHandle<gameuiIconsNameResolver>>(value);
		}

		[Ordinal(1)] 
		[RED("useMaleIcons")] 
		public CBool UseMaleIcons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ammoTypeCache")] 
		public CHandle<inkScriptIntHashMap> AmmoTypeCache
		{
			get => GetPropertyValue<CHandle<inkScriptIntHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptIntHashMap>>(value);
		}

		[Ordinal(3)] 
		[RED("statsMapCache")] 
		public CHandle<inkScriptWeakHashMap> StatsMapCache
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(4)] 
		[RED("statsPropertiesCache")] 
		public CHandle<inkScriptHashMap> StatsPropertiesCache
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(5)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(7)] 
		[RED("statsDataSystem")] 
		public CHandle<gameStatsDataSystem> StatsDataSystem
		{
			get => GetPropertyValue<CHandle<gameStatsDataSystem>>();
			set => SetPropertyValue<CHandle<gameStatsDataSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("inventoryManager")] 
		public CWeakHandle<gameInventoryManager> InventoryManager
		{
			get => GetPropertyValue<CWeakHandle<gameInventoryManager>>();
			set => SetPropertyValue<CWeakHandle<gameInventoryManager>>(value);
		}

		[Ordinal(10)] 
		[RED("equippedItemsFetched")] 
		public CBool EquippedItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("equippedItems")] 
		public CArray<gameItemID> EquippedItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(12)] 
		[RED("transmogItemsFetched")] 
		public CBool TransmogItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("transmogItems")] 
		public CArray<gameItemID> TransmogItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(14)] 
		[RED("maxStatValuesData")] 
		public CArray<CHandle<WeaponMaxStatValueData>> MaxStatValuesData
		{
			get => GetPropertyValue<CArray<CHandle<WeaponMaxStatValueData>>>();
			set => SetPropertyValue<CArray<CHandle<WeaponMaxStatValueData>>>(value);
		}

		[Ordinal(15)] 
		[RED("notSellableTags")] 
		public CArray<CName> NotSellableTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("TEMP_cuverBarsEnabled")] 
		public CBool TEMP_cuverBarsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("TEMP_separatorBarsEnabled")] 
		public CBool TEMP_separatorBarsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryItemsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
