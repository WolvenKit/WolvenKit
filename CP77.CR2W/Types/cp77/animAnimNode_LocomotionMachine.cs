using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		[Ordinal(0)]  [RED("usePlanner")] public CBool UsePlanner { get; set; }
		[Ordinal(1)]  [RED("group")] public CName Group { get; set; }
		[Ordinal(2)]  [RED("logic")] public CName Logic { get; set; }
		[Ordinal(3)]  [RED("distance")] public CName Distance { get; set; }
		[Ordinal(4)]  [RED("duration")] public CName Duration { get; set; }
		[Ordinal(5)]  [RED("motion")] public CName Motion { get; set; }
		[Ordinal(6)]  [RED("state")] public CName State { get; set; }
		[Ordinal(7)]  [RED("requestId")] public CName RequestId { get; set; }
		[Ordinal(8)]  [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(9)]  [RED("numVariants")] public CUInt32 NumVariants { get; set; }

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
