using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadialMenuGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("containerRef")] public inkCompoundWidgetReference ContainerRef { get; set; }
		[Ordinal(10)] [RED("highlightRef")] public inkWidgetReference HighlightRef { get; set; }
		[Ordinal(11)] [RED("itemListRef")] public CArray<inkWidgetReference> ItemListRef { get; set; }
		[Ordinal(12)] [RED("quickSlotsBoard")] public CHandle<gameIBlackboard> QuickSlotsBoard { get; set; }
		[Ordinal(13)] [RED("quickSlotsDef")] public CHandle<UI_QuickSlotsDataDef> QuickSlotsDef { get; set; }
		[Ordinal(14)] [RED("inputAxisCallbackId")] public CUInt32 InputAxisCallbackId { get; set; }

		public RadialMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
