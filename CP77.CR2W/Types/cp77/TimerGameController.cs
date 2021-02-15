using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("value")] public inkTextWidgetReference Value { get; set; }
		[Ordinal(10)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(11)] [RED("timerBB")] public CHandle<gameIBlackboard> TimerBB { get; set; }
		[Ordinal(12)] [RED("timerDef")] public CHandle<UIGameDataDef> TimerDef { get; set; }
		[Ordinal(13)] [RED("activeBBID")] public CUInt32 ActiveBBID { get; set; }
		[Ordinal(14)] [RED("progressBBID")] public CUInt32 ProgressBBID { get; set; }

		public TimerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
