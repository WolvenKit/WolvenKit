using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemInventoryMiniGrid : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("gridList")] public inkCompoundWidgetReference GridList { get; set; }
		[Ordinal(2)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)] [RED("gridWidth")] public CInt32 GridWidth { get; set; }
		[Ordinal(4)] [RED("gridData")] public CArray<CHandle<InventoryItemDisplay>> GridData { get; set; }

		public ItemInventoryMiniGrid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
