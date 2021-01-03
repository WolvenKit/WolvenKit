using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("IntroAnimation")] public CHandle<inkanimProxy> IntroAnimation { get; set; }
		[Ordinal(1)]  [RED("IntroWasPlayed")] public CBool IntroWasPlayed { get; set; }
		[Ordinal(2)]  [RED("LoopAnimation")] public CHandle<inkanimProxy> LoopAnimation { get; set; }
		[Ordinal(3)]  [RED("OutroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }
		[Ordinal(4)]  [RED("activeBBID")] public CUInt32 ActiveBBID { get; set; }
		[Ordinal(5)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(6)]  [RED("completed")] public inkTextWidgetReference Completed { get; set; }
		[Ordinal(7)]  [RED("failed")] public inkTextWidgetReference Failed { get; set; }
		[Ordinal(8)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(9)]  [RED("headerBBID")] public CUInt32 HeaderBBID { get; set; }
		[Ordinal(10)]  [RED("percent")] public inkTextWidgetReference Percent { get; set; }
		[Ordinal(11)]  [RED("progressBBID")] public CUInt32 ProgressBBID { get; set; }
		[Ordinal(12)]  [RED("progressBarBB")] public CHandle<gameIBlackboard> ProgressBarBB { get; set; }
		[Ordinal(13)]  [RED("progressBarDef")] public CHandle<UI_HUDProgressBarDef> ProgressBarDef { get; set; }
		[Ordinal(14)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(15)]  [RED("valueSaved")] public CFloat ValueSaved { get; set; }

		public HUDProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
