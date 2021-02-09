using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorDataManager : IScriptable
	{
		[Ordinal(0)]  [RED("VendorObject")] public wCHandle<gameObject> VendorObject { get; set; }
		[Ordinal(1)]  [RED("BuyingCart")] public CArray<VendorShoppingCartItem> BuyingCart { get; set; }
		[Ordinal(2)]  [RED("SellingCart")] public CArray<VendorShoppingCartItem> SellingCart { get; set; }
		[Ordinal(3)]  [RED("VendorID")] public TweakDBID VendorID { get; set; }
		[Ordinal(4)]  [RED("VendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }
		[Ordinal(5)]  [RED("TimeToCompletePurchase")] public CFloat TimeToCompletePurchase { get; set; }
		[Ordinal(6)]  [RED("UIBBEquipmentBlackboard")] public CHandle<gameIBlackboard> UIBBEquipmentBlackboard { get; set; }
		[Ordinal(7)]  [RED("UIBBEquipment")] public CHandle<UI_EquipmentDef> UIBBEquipment { get; set; }
		[Ordinal(8)]  [RED("InventoryBBID")] public CUInt32 InventoryBBID { get; set; }
		[Ordinal(9)]  [RED("EquipmentBBID")] public CUInt32 EquipmentBBID { get; set; }
		[Ordinal(10)]  [RED("openTime")] public GameTime OpenTime { get; set; }

		public VendorDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
