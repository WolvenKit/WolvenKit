using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotateBoneByQuaternion : animAnimNode_Base
	{
		[Ordinal(1)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(2)] [RED("quaternionNode")] public animQuaternionLink QuaternionNode { get; set; }
		[Ordinal(3)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(4)] [RED("useIncrementalMode")] public CBool UseIncrementalMode { get; set; }
		[Ordinal(5)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }

		public animAnimNode_RotateBoneByQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
