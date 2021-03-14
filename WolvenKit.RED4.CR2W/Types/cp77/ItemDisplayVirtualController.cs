using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] [RED("itemDisplayWidget")] public inkWidgetReference ItemDisplayWidget { get; set; }
		[Ordinal(16)] [RED("widgetToSpawn")] public CName WidgetToSpawn { get; set; }
		[Ordinal(17)] [RED("wrappedData")] public CHandle<WrappedInventoryItemData> WrappedData { get; set; }
		[Ordinal(18)] [RED("data")] public InventoryItemData Data { get; set; }
		[Ordinal(19)] [RED("spawnedWidget")] public wCHandle<inkWidget> SpawnedWidget { get; set; }

		public ItemDisplayVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
