using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("delayDuration")] public CFloat DelayDuration { get; set; }
		[Ordinal(2)]  [RED("trap")] public wCHandle<gamedataMiniGame_Trap_Record> Trap { get; set; }

		public gameuiTrapTooltipDisplayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
