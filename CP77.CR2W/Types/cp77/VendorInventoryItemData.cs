using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorInventoryItemData : WrappedInventoryItemData
	{
		[Ordinal(0)]  [RED("ItemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)]  [RED("ComparisonState")] public CEnum<gameItemComparisonState> ComparisonState { get; set; }
		[Ordinal(2)]  [RED("IsNew")] public CBool IsNew { get; set; }
		[Ordinal(3)]  [RED("ItemTemplate")] public CUInt32 ItemTemplate { get; set; }
		[Ordinal(4)]  [RED("DisplayContext")] public CEnum<gameItemDisplayContext> DisplayContext { get; set; }
		[Ordinal(5)]  [RED("IsVendorItem")] public CBool IsVendorItem { get; set; }
		[Ordinal(6)]  [RED("IsEnoughMoney")] public CBool IsEnoughMoney { get; set; }
		[Ordinal(7)]  [RED("IsBuybackStack")] public CBool IsBuybackStack { get; set; }

		public VendorInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
