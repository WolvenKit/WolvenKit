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
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public wCHandle<gameObject> VendorObject
		{
			get => GetProperty(ref _vendorObject);
			set => SetProperty(ref _vendorObject, value);
		}

		[Ordinal(2)] 
		[RED("tweakID")] 
		public TweakDBID TweakID
		{
			get => GetProperty(ref _tweakID);
			set => SetProperty(ref _tweakID, value);
		}

		[Ordinal(3)] 
		[RED("lastInteractionTime")] 
		public CFloat LastInteractionTime
		{
			get => GetProperty(ref _lastInteractionTime);
			set => SetProperty(ref _lastInteractionTime, value);
		}

		[Ordinal(4)] 
		[RED("stock")] 
		public CArray<gameSItemStack> Stock
		{
			get => GetProperty(ref _stock);
			set => SetProperty(ref _stock, value);
		}

		[Ordinal(5)] 
		[RED("priceMultiplier")] 
		public CFloat PriceMultiplier
		{
			get => GetProperty(ref _priceMultiplier);
			set => SetProperty(ref _priceMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("vendorPersistentID")] 
		public gamePersistentID VendorPersistentID
		{
			get => GetProperty(ref _vendorPersistentID);
			set => SetProperty(ref _vendorPersistentID, value);
		}

		[Ordinal(7)] 
		[RED("stockInit")] 
		public CBool StockInit
		{
			get => GetProperty(ref _stockInit);
			set => SetProperty(ref _stockInit, value);
		}

		[Ordinal(8)] 
		[RED("inventoryInit")] 
		public CBool InventoryInit
		{
			get => GetProperty(ref _inventoryInit);
			set => SetProperty(ref _inventoryInit, value);
		}

		[Ordinal(9)] 
		[RED("inventoryReinitWithPlayerStats")] 
		public CBool InventoryReinitWithPlayerStats
		{
			get => GetProperty(ref _inventoryReinitWithPlayerStats);
			set => SetProperty(ref _inventoryReinitWithPlayerStats, value);
		}

		[Ordinal(10)] 
		[RED("vendorRecord")] 
		public wCHandle<gamedataVendor_Record> VendorRecord
		{
			get => GetProperty(ref _vendorRecord);
			set => SetProperty(ref _vendorRecord, value);
		}

		public Vendor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
