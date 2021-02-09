using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemStatList : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(1)]  [RED("container")] public wCHandle<inkCompoundWidget> Container { get; set; }
		[Ordinal(2)]  [RED("data")] public CArray<InventoryTooltipData_StatData> Data { get; set; }
		[Ordinal(3)]  [RED("itemsList")] public CArray<wCHandle<inkWidget>> ItemsList { get; set; }

		public InventoryItemStatList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
