using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealStateChangedEvent : redEvent
	{
		[Ordinal(0)]  [RED("reason")] public gameVisionModeSystemRevealIdentifier Reason { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<ERevealState> State { get; set; }
		[Ordinal(2)]  [RED("transitionTime")] public CFloat TransitionTime { get; set; }

		public RevealStateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
