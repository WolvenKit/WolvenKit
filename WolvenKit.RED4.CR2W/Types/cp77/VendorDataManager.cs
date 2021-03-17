using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorDataManager : IScriptable
	{
		private wCHandle<gameObject> _vendorObject;
		private CArray<VendorShoppingCartItem> _buyingCart;
		private CArray<VendorShoppingCartItem> _sellingCart;
		private TweakDBID _vendorID;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;
		private CFloat _timeToCompletePurchase;
		private CHandle<gameIBlackboard> _uIBBEquipmentBlackboard;
		private CHandle<UI_EquipmentDef> _uIBBEquipment;
		private CUInt32 _inventoryBBID;
		private CUInt32 _equipmentBBID;
		private GameTime _openTime;

		[Ordinal(0)] 
		[RED("VendorObject")] 
		public wCHandle<gameObject> VendorObject
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
		[RED("UIBBEquipmentBlackboard")] 
		public CHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get => GetProperty(ref _uIBBEquipmentBlackboard);
			set => SetProperty(ref _uIBBEquipmentBlackboard, value);
		}

		[Ordinal(7)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get => GetProperty(ref _uIBBEquipment);
			set => SetProperty(ref _uIBBEquipment, value);
		}

		[Ordinal(8)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get => GetProperty(ref _inventoryBBID);
			set => SetProperty(ref _inventoryBBID, value);
		}

		[Ordinal(9)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get => GetProperty(ref _equipmentBBID);
			set => SetProperty(ref _equipmentBBID, value);
		}

		[Ordinal(10)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetProperty(ref _openTime);
			set => SetProperty(ref _openTime, value);
		}

		public VendorDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
