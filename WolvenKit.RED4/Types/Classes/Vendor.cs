using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Vendor : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public CWeakHandle<gameObject> VendorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("tweakID")] 
		public TweakDBID TweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("lastInteractionTime")] 
		public CFloat LastInteractionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("stock")] 
		public CArray<gameSItemStack> Stock
		{
			get => GetPropertyValue<CArray<gameSItemStack>>();
			set => SetPropertyValue<CArray<gameSItemStack>>(value);
		}

		[Ordinal(5)] 
		[RED("newItems")] 
		public CArray<TweakDBID> NewItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(6)] 
		[RED("soldItems")] 
		public CHandle<SoldItemsCache> SoldItems
		{
			get => GetPropertyValue<CHandle<SoldItemsCache>>();
			set => SetPropertyValue<CHandle<SoldItemsCache>>(value);
		}

		[Ordinal(7)] 
		[RED("priceMultiplier")] 
		public CFloat PriceMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("vendorPersistentID")] 
		public gamePersistentID VendorPersistentID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(9)] 
		[RED("stockInit")] 
		public CBool StockInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("playerHacksInit")] 
		public CBool PlayerHacksInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("inventoryInit")] 
		public CBool InventoryInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("inventoryReinitWithPlayerStats")] 
		public CBool InventoryReinitWithPlayerStats
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("vendorRecord")] 
		public CWeakHandle<gamedataVendor_Record> VendorRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataVendor_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataVendor_Record>>(value);
		}

		[Ordinal(15)] 
		[RED("playerHacks")] 
		public CArray<gameItemID> PlayerHacks
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public Vendor()
		{
			GameInstance = new ScriptGameInstance();
			Stock = new();
			NewItems = new();
			PriceMultiplier = 1.000000F;
			VendorPersistentID = new gamePersistentID();
			PlayerHacks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
