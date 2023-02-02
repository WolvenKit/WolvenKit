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
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("equippedItemsFetched")] 
		public CBool EquippedItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("equippedItems")] 
		public CArray<gameItemID> EquippedItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(10)] 
		[RED("transmogItemsFetched")] 
		public CBool TransmogItemsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("transmogItems")] 
		public CArray<gameItemID> TransmogItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public UIInventoryItemsManager()
		{
			EquippedItems = new();
			TransmogItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
