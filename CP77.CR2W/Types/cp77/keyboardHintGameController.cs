using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class keyboardHintGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("TopElementName")] public CName TopElementName { get; set; }
		[Ordinal(10)] [RED("BottomElementName")] public CName BottomElementName { get; set; }
		[Ordinal(11)] [RED("Layout")] public inkBasePanelWidgetReference Layout { get; set; }
		[Ordinal(12)] [RED("UIItems")] public CArray<wCHandle<KeyboardHintItemController>> UIItems { get; set; }
		[Ordinal(13)] [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(14)] [RED("QuickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(15)] [RED("UiQuickItemsBlackboard")] public CHandle<gameIBlackboard> UiQuickItemsBlackboard { get; set; }
		[Ordinal(16)] [RED("KeyboardCommandBBID")] public CUInt32 KeyboardCommandBBID { get; set; }

		public keyboardHintGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
