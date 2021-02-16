using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealStateChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<ERevealState> State { get; set; }
		[Ordinal(1)] [RED("reason")] public gameVisionModeSystemRevealIdentifier Reason { get; set; }
		[Ordinal(2)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }

		public RevealStateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
