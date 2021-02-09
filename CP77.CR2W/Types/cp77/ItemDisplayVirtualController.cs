using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(0)]  [RED("itemDisplayWidget")] public inkWidgetReference ItemDisplayWidget { get; set; }
		[Ordinal(1)]  [RED("widgetToSpawn")] public CName WidgetToSpawn { get; set; }
		[Ordinal(2)]  [RED("wrappedData")] public CHandle<WrappedInventoryItemData> WrappedData { get; set; }
		[Ordinal(3)]  [RED("data")] public InventoryItemData Data { get; set; }
		[Ordinal(4)]  [RED("spawnedWidget")] public wCHandle<inkWidget> SpawnedWidget { get; set; }

		public ItemDisplayVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
