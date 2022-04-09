using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorDataManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("VendorObject")] 
		public CWeakHandle<gameObject> VendorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("BuyingCart")] 
		public CArray<VendorShoppingCartItem> BuyingCart
		{
			get => GetPropertyValue<CArray<VendorShoppingCartItem>>();
			set => SetPropertyValue<CArray<VendorShoppingCartItem>>(value);
		}

		[Ordinal(2)] 
		[RED("SellingCart")] 
		public CArray<VendorShoppingCartItem> SellingCart
		{
			get => GetPropertyValue<CArray<VendorShoppingCartItem>>();
			set => SetPropertyValue<CArray<VendorShoppingCartItem>>(value);
		}

		[Ordinal(3)] 
		[RED("VendorID")] 
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("VendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetPropertyValue<CArray<CEnum<EVendorMode>>>();
			set => SetPropertyValue<CArray<CEnum<EVendorMode>>>(value);
		}

		[Ordinal(5)] 
		[RED("TimeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(7)] 
		[RED("InventoryBBID")] 
		public CHandle<redCallbackObject> InventoryBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("EquipmentBBID")] 
		public CHandle<redCallbackObject> EquipmentBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public VendorDataManager()
		{
			BuyingCart = new();
			SellingCart = new();
			VendingBlacklist = new();
			OpenTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
