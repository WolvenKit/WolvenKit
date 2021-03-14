using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vendor : IScriptable
	{
		private ScriptGameInstance _gameInstance;
		private wCHandle<gameObject> _vendorObject;
		private TweakDBID _tweakID;
		private CFloat _lastInteractionTime;
		private CArray<gameSItemStack> _stock;
		private CFloat _priceMultiplier;
		private gamePersistentID _vendorPersistentID;
		private CBool _stockInit;
		private CBool _inventoryInit;
		private CBool _inventoryReinitWithPlayerStats;
		private wCHandle<gamedataVendor_Record> _vendorRecord;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public wCHandle<gameObject> VendorObject
		{
			get
			{
				if (_vendorObject == null)
				{
					_vendorObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "vendorObject", cr2w, this);
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

		[Ordinal(2)] 
		[RED("tweakID")] 
		public TweakDBID TweakID
		{
			get
			{
				if (_tweakID == null)
				{
					_tweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakID", cr2w, this);
				}
				return _tweakID;
			}
			set
			{
				if (_tweakID == value)
				{
					return;
				}
				_tweakID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastInteractionTime")] 
		public CFloat LastInteractionTime
		{
			get
			{
				if (_lastInteractionTime == null)
				{
					_lastInteractionTime = (CFloat) CR2WTypeManager.Create("Float", "lastInteractionTime", cr2w, this);
				}
				return _lastInteractionTime;
			}
			set
			{
				if (_lastInteractionTime == value)
				{
					return;
				}
				_lastInteractionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stock")] 
		public CArray<gameSItemStack> Stock
		{
			get
			{
				if (_stock == null)
				{
					_stock = (CArray<gameSItemStack>) CR2WTypeManager.Create("array:gameSItemStack", "stock", cr2w, this);
				}
				return _stock;
			}
			set
			{
				if (_stock == value)
				{
					return;
				}
				_stock = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("priceMultiplier")] 
		public CFloat PriceMultiplier
		{
			get
			{
				if (_priceMultiplier == null)
				{
					_priceMultiplier = (CFloat) CR2WTypeManager.Create("Float", "priceMultiplier", cr2w, this);
				}
				return _priceMultiplier;
			}
			set
			{
				if (_priceMultiplier == value)
				{
					return;
				}
				_priceMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vendorPersistentID")] 
		public gamePersistentID VendorPersistentID
		{
			get
			{
				if (_vendorPersistentID == null)
				{
					_vendorPersistentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "vendorPersistentID", cr2w, this);
				}
				return _vendorPersistentID;
			}
			set
			{
				if (_vendorPersistentID == value)
				{
					return;
				}
				_vendorPersistentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stockInit")] 
		public CBool StockInit
		{
			get
			{
				if (_stockInit == null)
				{
					_stockInit = (CBool) CR2WTypeManager.Create("Bool", "stockInit", cr2w, this);
				}
				return _stockInit;
			}
			set
			{
				if (_stockInit == value)
				{
					return;
				}
				_stockInit = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryInit")] 
		public CBool InventoryInit
		{
			get
			{
				if (_inventoryInit == null)
				{
					_inventoryInit = (CBool) CR2WTypeManager.Create("Bool", "inventoryInit", cr2w, this);
				}
				return _inventoryInit;
			}
			set
			{
				if (_inventoryInit == value)
				{
					return;
				}
				_inventoryInit = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inventoryReinitWithPlayerStats")] 
		public CBool InventoryReinitWithPlayerStats
		{
			get
			{
				if (_inventoryReinitWithPlayerStats == null)
				{
					_inventoryReinitWithPlayerStats = (CBool) CR2WTypeManager.Create("Bool", "inventoryReinitWithPlayerStats", cr2w, this);
				}
				return _inventoryReinitWithPlayerStats;
			}
			set
			{
				if (_inventoryReinitWithPlayerStats == value)
				{
					return;
				}
				_inventoryReinitWithPlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vendorRecord")] 
		public wCHandle<gamedataVendor_Record> VendorRecord
		{
			get
			{
				if (_vendorRecord == null)
				{
					_vendorRecord = (wCHandle<gamedataVendor_Record>) CR2WTypeManager.Create("whandle:gamedataVendor_Record", "vendorRecord", cr2w, this);
				}
				return _vendorRecord;
			}
			set
			{
				if (_vendorRecord == value)
				{
					return;
				}
				_vendorRecord = value;
				PropertySet(this);
			}
		}

		public Vendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
