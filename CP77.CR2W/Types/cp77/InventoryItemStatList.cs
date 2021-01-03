using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemStatList : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("container")] public wCHandle<inkCompoundWidget> Container { get; set; }
		[Ordinal(1)]  [RED("data")] public CArray<InventoryTooltipData_StatData> Data { get; set; }
		[Ordinal(2)]  [RED("itemsList")] public CArray<wCHandle<inkWidget>> ItemsList { get; set; }
		[Ordinal(3)]  [RED("libraryItemName")] public CName LibraryItemName { get; set; }

		public InventoryItemStatList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
