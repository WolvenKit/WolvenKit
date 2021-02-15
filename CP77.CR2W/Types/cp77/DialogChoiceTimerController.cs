using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DialogChoiceTimerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(2)] [RED("timerValue")] public inkTextWidgetReference TimerValue { get; set; }
		[Ordinal(3)] [RED("progressAnimDef")] public CHandle<inkanimDefinition> ProgressAnimDef { get; set; }
		[Ordinal(4)] [RED("timerAnimDef")] public CHandle<inkanimDefinition> TimerAnimDef { get; set; }
		[Ordinal(5)] [RED("ProgressAnimInterpolator")] public CHandle<inkanimScaleInterpolator> ProgressAnimInterpolator { get; set; }
		[Ordinal(6)] [RED("timerAnimInterpolator")] public CHandle<inkanimTransparencyInterpolator> TimerAnimInterpolator { get; set; }
		[Ordinal(7)] [RED("timerAnimProxy")] public CHandle<inkanimProxy> TimerAnimProxy { get; set; }
		[Ordinal(8)] [RED("timerBarAnimProxy")] public CHandle<inkanimProxy> TimerBarAnimProxy { get; set; }
		[Ordinal(9)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(10)] [RED("time")] public CFloat Time { get; set; }

		public DialogChoiceTimerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
