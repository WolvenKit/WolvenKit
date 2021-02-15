using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemCompareBuilder : IScriptable
	{
		[Ordinal(0)] [RED("item1")] public InventoryItemData Item1 { get; set; }
		[Ordinal(1)] [RED("item2")] public InventoryItemData Item2 { get; set; }
		[Ordinal(2)] [RED("compareBuilder")] public CHandle<CompareBuilder> CompareBuilder { get; set; }

		public ItemCompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
