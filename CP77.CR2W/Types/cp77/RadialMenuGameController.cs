using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadialMenuGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("containerRef")] public inkCompoundWidgetReference ContainerRef { get; set; }
		[Ordinal(1)]  [RED("highlightRef")] public inkWidgetReference HighlightRef { get; set; }
		[Ordinal(2)]  [RED("inputAxisCallbackId")] public CUInt32 InputAxisCallbackId { get; set; }
		[Ordinal(3)]  [RED("itemListRef")] public CArray<inkWidgetReference> ItemListRef { get; set; }
		[Ordinal(4)]  [RED("quickSlotsBoard")] public CHandle<gameIBlackboard> QuickSlotsBoard { get; set; }
		[Ordinal(5)]  [RED("quickSlotsDef")] public CHandle<UI_QuickSlotsDataDef> QuickSlotsDef { get; set; }

		public RadialMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
