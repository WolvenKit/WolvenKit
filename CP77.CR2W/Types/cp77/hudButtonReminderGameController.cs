using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudButtonReminderGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("Button1")] public inkCompoundWidgetReference Button1 { get; set; }
		[Ordinal(8)]  [RED("Button2")] public inkCompoundWidgetReference Button2 { get; set; }
		[Ordinal(9)]  [RED("Button3")] public inkCompoundWidgetReference Button3 { get; set; }
		[Ordinal(10)]  [RED("uiHudButtonHelpBB")] public CHandle<gameIBlackboard> UiHudButtonHelpBB { get; set; }
		[Ordinal(11)]  [RED("interactingWithDeviceBBID")] public CUInt32 InteractingWithDeviceBBID { get; set; }

		public hudButtonReminderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
