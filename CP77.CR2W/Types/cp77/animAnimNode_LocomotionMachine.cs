using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		[Ordinal(0)]  [RED("distance")] public CName Distance { get; set; }
		[Ordinal(1)]  [RED("duration")] public CName Duration { get; set; }
		[Ordinal(2)]  [RED("group")] public CName Group { get; set; }
		[Ordinal(3)]  [RED("logic")] public CName Logic { get; set; }
		[Ordinal(4)]  [RED("motion")] public CName Motion { get; set; }
		[Ordinal(5)]  [RED("numVariants")] public CUInt32 NumVariants { get; set; }
		[Ordinal(6)]  [RED("requestId")] public CName RequestId { get; set; }
		[Ordinal(7)]  [RED("state")] public CName State { get; set; }
		[Ordinal(8)]  [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(9)]  [RED("usePlanner")] public CBool UsePlanner { get; set; }

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
