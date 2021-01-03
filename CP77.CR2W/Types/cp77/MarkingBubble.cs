using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MarkingBubble : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("delayAdditionalRandomDelayMax")] public CFloat DelayAdditionalRandomDelayMax { get; set; }
		[Ordinal(1)]  [RED("delaySecondsPerMeterOfDistance")] public CFloat DelaySecondsPerMeterOfDistance { get; set; }

		public MarkingBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
