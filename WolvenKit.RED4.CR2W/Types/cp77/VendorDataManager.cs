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
			get
			{
				if (_vendorObject == null)
				{
					_vendorObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "VendorObject", cr2w, this);
				}
				return _vendorObject;
			}
			set
			{
				if (_vendorObject == value)
				{
					return;
				}
				_vendorObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BuyingCart")] 
		public CArray<VendorShoppingCartItem> BuyingCart
		{
			get
			{
				if (_buyingCart == null)
				{
					_buyingCart = (CArray<VendorShoppingCartItem>) CR2WTypeManager.Create("array:VendorShoppingCartItem", "BuyingCart", cr2w, this);
				}
				return _buyingCart;
			}
			set
			{
				if (_buyingCart == value)
				{
					return;
				}
				_buyingCart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SellingCart")] 
		public CArray<VendorShoppingCartItem> SellingCart
		{
			get
			{
				if (_sellingCart == null)
				{
					_sellingCart = (CArray<VendorShoppingCartItem>) CR2WTypeManager.Create("array:VendorShoppingCartItem", "SellingCart", cr2w, this);
				}
				return _sellingCart;
			}
			set
			{
				if (_sellingCart == value)
				{
					return;
				}
				_sellingCart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("VendorID")] 
		public TweakDBID VendorID
		{
			get
			{
				if (_vendorID == null)
				{
					_vendorID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "VendorID", cr2w, this);
				}
				return _vendorID;
			}
			set
			{
				if (_vendorID == value)
				{
					return;
				}
				_vendorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("VendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get
			{
				if (_vendingBlacklist == null)
				{
					_vendingBlacklist = (CArray<CEnum<EVendorMode>>) CR2WTypeManager.Create("array:EVendorMode", "VendingBlacklist", cr2w, this);
				}
				return _vendingBlacklist;
			}
			set
			{
				if (_vendingBlacklist == value)
				{
					return;
				}
				_vendingBlacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("TimeToCompletePurchase")] 
		public CFloat TimeToCompletePurchase
		{
			get
			{
				if (_timeToCompletePurchase == null)
				{
					_timeToCompletePurchase = (CFloat) CR2WTypeManager.Create("Float", "TimeToCompletePurchase", cr2w, this);
				}
				return _timeToCompletePurchase;
			}
			set
			{
				if (_timeToCompletePurchase == value)
				{
					return;
				}
				_timeToCompletePurchase = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("UIBBEquipmentBlackboard")] 
		public CHandle<gameIBlackboard> UIBBEquipmentBlackboard
		{
			get
			{
				if (_uIBBEquipmentBlackboard == null)
				{
					_uIBBEquipmentBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "UIBBEquipmentBlackboard", cr2w, this);
				}
				return _uIBBEquipmentBlackboard;
			}
			set
			{
				if (_uIBBEquipmentBlackboard == value)
				{
					return;
				}
				_uIBBEquipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("UIBBEquipment")] 
		public CHandle<UI_EquipmentDef> UIBBEquipment
		{
			get
			{
				if (_uIBBEquipment == null)
				{
					_uIBBEquipment = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "UIBBEquipment", cr2w, this);
				}
				return _uIBBEquipment;
			}
			set
			{
				if (_uIBBEquipment == value)
				{
					return;
				}
				_uIBBEquipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("InventoryBBID")] 
		public CUInt32 InventoryBBID
		{
			get
			{
				if (_inventoryBBID == null)
				{
					_inventoryBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "InventoryBBID", cr2w, this);
				}
				return _inventoryBBID;
			}
			set
			{
				if (_inventoryBBID == value)
				{
					return;
				}
				_inventoryBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("EquipmentBBID")] 
		public CUInt32 EquipmentBBID
		{
			get
			{
				if (_equipmentBBID == null)
				{
					_equipmentBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "EquipmentBBID", cr2w, this);
				}
				return _equipmentBBID;
			}
			set
			{
				if (_equipmentBBID == value)
				{
					return;
				}
				_equipmentBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get
			{
				if (_openTime == null)
				{
					_openTime = (GameTime) CR2WTypeManager.Create("GameTime", "openTime", cr2w, this);
				}
				return _openTime;
			}
			set
			{
				if (_openTime == value)
				{
					return;
				}
				_openTime = value;
				PropertySet(this);
			}
		}

		public VendorDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
