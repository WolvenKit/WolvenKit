using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtController_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("E3_HACK_offset")] public animVectorLink E3_HACK_offset { get; set; }
		[Ordinal(13)] [RED("orderedBodyParts")] public CArray<animLookAtPartInfo> OrderedBodyParts { get; set; }
		[Ordinal(14)] [RED("stateMachinesSettings")] public CArray<animLookAtStateMachineSettings> StateMachinesSettings { get; set; }
		[Ordinal(15)] [RED("bodyPartsDependencies")] public CArray<animLookAtPartsDependency> BodyPartsDependencies { get; set; }
		[Ordinal(16)] [RED("substepTime")] public CFloat SubstepTime { get; set; }
		[Ordinal(17)] [RED("isFacial")] public CBool IsFacial { get; set; }

		public animAnimNode_LookAtController_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
