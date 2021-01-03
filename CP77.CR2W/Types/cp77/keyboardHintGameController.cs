using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class keyboardHintGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("BottomElementName")] public CName BottomElementName { get; set; }
		[Ordinal(1)]  [RED("KeyboardCommandBBID")] public CUInt32 KeyboardCommandBBID { get; set; }
		[Ordinal(2)]  [RED("Layout")] public inkBasePanelWidgetReference Layout { get; set; }
		[Ordinal(3)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(4)]  [RED("QuickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(5)]  [RED("TopElementName")] public CName TopElementName { get; set; }
		[Ordinal(6)]  [RED("UIItems")] public CArray<wCHandle<KeyboardHintItemController>> UIItems { get; set; }
		[Ordinal(7)]  [RED("UiQuickItemsBlackboard")] public CHandle<gameIBlackboard> UiQuickItemsBlackboard { get; set; }

		public keyboardHintGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
