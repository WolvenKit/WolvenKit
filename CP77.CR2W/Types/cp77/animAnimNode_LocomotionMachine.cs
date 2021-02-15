using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		[Ordinal(9)] [RED("usePlanner")] public CBool UsePlanner { get; set; }
		[Ordinal(10)] [RED("group")] public CName Group { get; set; }
		[Ordinal(11)] [RED("logic")] public CName Logic { get; set; }
		[Ordinal(12)] [RED("requestId")] public CName RequestId { get; set; }
		[Ordinal(13)] [RED("distance")] public CName Distance { get; set; }
		[Ordinal(14)] [RED("duration")] public CName Duration { get; set; }
		[Ordinal(15)] [RED("motion")] public CName Motion { get; set; }
		[Ordinal(16)] [RED("state")] public CName State { get; set; }
		[Ordinal(17)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(18)] [RED("numVariants")] public CUInt32 NumVariants { get; set; }

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
