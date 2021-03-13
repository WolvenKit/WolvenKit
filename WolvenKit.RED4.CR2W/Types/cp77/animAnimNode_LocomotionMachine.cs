using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		[Ordinal(19)] [RED("usePlanner")] public CBool UsePlanner { get; set; }
		[Ordinal(20)] [RED("group")] public CName Group { get; set; }
		[Ordinal(21)] [RED("logic")] public CName Logic { get; set; }
		[Ordinal(22)] [RED("requestId")] public CName RequestId { get; set; }
		[Ordinal(23)] [RED("distance")] public CName Distance { get; set; }
		[Ordinal(24)] [RED("duration")] public CName Duration { get; set; }
		[Ordinal(25)] [RED("motion")] public CName Motion { get; set; }
		[Ordinal(26)] [RED("state")] public CName State { get; set; }
		[Ordinal(27)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(28)] [RED("numVariants")] public CUInt32 NumVariants { get; set; }

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
