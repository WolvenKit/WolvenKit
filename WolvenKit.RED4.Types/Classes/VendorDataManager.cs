using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorDataManager : IScriptable
	{
		private CWeakHandle<gameObject> _vendorObject;
		private CArray<VendorShoppingCartItem> _buyingCart;
		private CArray<VendorShoppingCartItem> _sellingCart;
		private TweakDBID _vendorID;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;
		private CFloat _timeToCompletePurchase;
		private CHandle<UI_EquipmentDef> _uIBBEquipment;
		private CHandle<redCallbackObject> _inventoryBBID;
		private CHandle<redCallbackObject> _equipmentBBID;
		private GameTime _openTime;

		[Ordinal(0)] 
		[RED("VendorObject")] 
		public CWeakHandle<gameObject> VendorObject
		{
			get => GetProperty(ref _vendorObject);
			set => SetProperty(ref _vendorObject, value);
		}

		[Ordinal(1)] 
		[RED("BuyingCart")] 
		public CArray<VendorShoppingCartItem> BuyingCart
		{
			get => GetProperty(ref _buyingCart);
			set => SetProperty(ref _buyingCart, value);
		}

		[Ordinal(2)] 
		[RED("SellingCart")] 
		public CArray<VendorShoppingCartItem> SellingCart
		{
			get => GetProperty(ref _sellingCart);
			set => SetProperty(ref _sellingCart, value);
		}

		[Ordinal(3)] 
		[RED("VendorID")] 
		public TweakDBID VendorID
		{
			get => GetProperty(ref _vendorID);
			set => SetProperty(ref _vendorID, value);
		}

		[Ordinal(4)] 
		[RED("VendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetProperty(ref _vendingBlacklist);
			set => SetProperty(ref _vendingBlacklist, value);
		}

		[Ordinal(5)] 
		[RED("TimeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get => GetProperty(ref _timeToCompletePurchase);
			set => SetProperty(ref _timeToCompletePurchase, value);
		}

		[Ordinal(6)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetProperty(ref _uIBBEquipment);
			set => SetProperty(ref _uIBBEquipment, value);
		}

		[Ordinal(7)] 
		[RED("InventoryBBID")] 
		public CHandle<redCallbackObject> InventoryBBID
		{
			get => GetProperty(ref _inventoryBBID);
			set => SetProperty(ref _inventoryBBID, value);
		}

		[Ordinal(8)] 
		[RED("EquipmentBBID")] 
		public CHandle<redCallbackObject> EquipmentBBID
		{
			get => GetProperty(ref _equipmentBBID);
			set => SetProperty(ref _equipmentBBID, value);
		}

		[Ordinal(9)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetProperty(ref _openTime);
			set => SetProperty(ref _openTime, value);
		}
	}
}
