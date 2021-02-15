using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("trap")] public wCHandle<gamedataMiniGame_Trap_Record> Trap { get; set; }
		[Ordinal(2)] [RED("delayDuration")] public CFloat DelayDuration { get; set; }
		[Ordinal(3)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public gameuiTrapTooltipDisplayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
