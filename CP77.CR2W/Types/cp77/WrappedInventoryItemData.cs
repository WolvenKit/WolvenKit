using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WrappedInventoryItemData : IScriptable
	{
		[Ordinal(0)] [RED("ItemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)] [RED("ComparisonState")] public CEnum<gameItemComparisonState> ComparisonState { get; set; }
		[Ordinal(2)] [RED("IsNew")] public CBool IsNew { get; set; }
		[Ordinal(3)] [RED("ItemTemplate")] public CUInt32 ItemTemplate { get; set; }
		[Ordinal(4)] [RED("DisplayContext")] public CEnum<gameItemDisplayContext> DisplayContext { get; set; }

		public WrappedInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
