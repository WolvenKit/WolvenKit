using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(8)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(9)]  [RED("percent")] public inkTextWidgetReference Percent { get; set; }
		[Ordinal(10)]  [RED("completed")] public inkTextWidgetReference Completed { get; set; }
		[Ordinal(11)]  [RED("failed")] public inkTextWidgetReference Failed { get; set; }
		[Ordinal(12)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(13)]  [RED("progressBarBB")] public CHandle<gameIBlackboard> ProgressBarBB { get; set; }
		[Ordinal(14)]  [RED("progressBarDef")] public CHandle<UI_HUDProgressBarDef> ProgressBarDef { get; set; }
		[Ordinal(15)]  [RED("activeBBID")] public CUInt32 ActiveBBID { get; set; }
		[Ordinal(16)]  [RED("headerBBID")] public CUInt32 HeaderBBID { get; set; }
		[Ordinal(17)]  [RED("progressBBID")] public CUInt32 ProgressBBID { get; set; }
		[Ordinal(18)]  [RED("OutroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }
		[Ordinal(19)]  [RED("LoopAnimation")] public CHandle<inkanimProxy> LoopAnimation { get; set; }
		[Ordinal(20)]  [RED("IntroAnimation")] public CHandle<inkanimProxy> IntroAnimation { get; set; }
		[Ordinal(21)]  [RED("IntroWasPlayed")] public CBool IntroWasPlayed { get; set; }
		[Ordinal(22)]  [RED("valueSaved")] public CFloat ValueSaved { get; set; }

		public HUDProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
