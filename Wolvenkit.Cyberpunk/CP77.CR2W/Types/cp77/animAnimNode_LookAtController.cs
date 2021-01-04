using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtController : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("E3_HACK_offset")] public animVectorLink E3_HACK_offset { get; set; }
		[Ordinal(1)]  [RED("bodyPartsDependencies")] public CArray<animLookAtPartsDependency> BodyPartsDependencies { get; set; }
		[Ordinal(2)]  [RED("isFacial")] public CBool IsFacial { get; set; }
		[Ordinal(3)]  [RED("orderedBodyParts")] public CArray<animLookAtPartInfo> OrderedBodyParts { get; set; }
		[Ordinal(4)]  [RED("stateMachinesSettings")] public CArray<animLookAtStateMachineSettings> StateMachinesSettings { get; set; }
		[Ordinal(5)]  [RED("substepTime")] public CFloat SubstepTime { get; set; }

		public animAnimNode_LookAtController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
