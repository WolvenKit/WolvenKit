using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimuliEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("stimuliEventName")] public CName StimuliEventName { get; set; }
		[Ordinal(1)] [RED("targetPoint")] public Vector4 TargetPoint { get; set; }

		public StimuliEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
