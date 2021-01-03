using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Vendor : IScriptable
	{
		[Ordinal(0)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(1)]  [RED("inventoryInit")] public CBool InventoryInit { get; set; }
		[Ordinal(2)]  [RED("inventoryReinitWithPlayerStats")] public CBool InventoryReinitWithPlayerStats { get; set; }
		[Ordinal(3)]  [RED("lastInteractionTime")] public CFloat LastInteractionTime { get; set; }
		[Ordinal(4)]  [RED("priceMultiplier")] public CFloat PriceMultiplier { get; set; }
		[Ordinal(5)]  [RED("stock")] public CArray<gameSItemStack> Stock { get; set; }
		[Ordinal(6)]  [RED("stockInit")] public CBool StockInit { get; set; }
		[Ordinal(7)]  [RED("tweakID")] public TweakDBID TweakID { get; set; }
		[Ordinal(8)]  [RED("vendorObject")] public wCHandle<gameObject> VendorObject { get; set; }
		[Ordinal(9)]  [RED("vendorPersistentID")] public gamePersistentID VendorPersistentID { get; set; }
		[Ordinal(10)]  [RED("vendorRecord")] public wCHandle<gamedataVendor_Record> VendorRecord { get; set; }

		public Vendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
