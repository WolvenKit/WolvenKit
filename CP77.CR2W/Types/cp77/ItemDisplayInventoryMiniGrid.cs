using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayInventoryMiniGrid : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("gridData")] public CArray<CHandle<InventoryItemDisplayController>> GridData { get; set; }
		[Ordinal(1)]  [RED("gridList")] public inkCompoundWidgetReference GridList { get; set; }
		[Ordinal(2)]  [RED("gridWidth")] public CInt32 GridWidth { get; set; }
		[Ordinal(3)]  [RED("label")] public inkTextWidgetReference Label { get; set; }

		public ItemDisplayInventoryMiniGrid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
