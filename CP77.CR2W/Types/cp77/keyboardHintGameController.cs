using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class keyboardHintGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("TopElementName")] public CName TopElementName { get; set; }
		[Ordinal(8)]  [RED("BottomElementName")] public CName BottomElementName { get; set; }
		[Ordinal(9)]  [RED("Layout")] public inkBasePanelWidgetReference Layout { get; set; }
		[Ordinal(10)]  [RED("UIItems")] public CArray<wCHandle<KeyboardHintItemController>> UIItems { get; set; }
		[Ordinal(11)]  [RED("Player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(12)]  [RED("QuickSlotsManager")] public wCHandle<QuickSlotsManager> QuickSlotsManager { get; set; }
		[Ordinal(13)]  [RED("UiQuickItemsBlackboard")] public CHandle<gameIBlackboard> UiQuickItemsBlackboard { get; set; }
		[Ordinal(14)]  [RED("KeyboardCommandBBID")] public CUInt32 KeyboardCommandBBID { get; set; }

		public keyboardHintGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
