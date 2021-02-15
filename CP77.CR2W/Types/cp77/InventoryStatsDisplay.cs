using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("StatsRoot")] public inkCompoundWidgetReference StatsRoot { get; set; }
		[Ordinal(2)] [RED("StatItemName")] public CName StatItemName { get; set; }
		[Ordinal(3)] [RED("StatItems")] public CArray<wCHandle<InventoryStatItemV2>> StatItems { get; set; }

		public InventoryStatsDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
