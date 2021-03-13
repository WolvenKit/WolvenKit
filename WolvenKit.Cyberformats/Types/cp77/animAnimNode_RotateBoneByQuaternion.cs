using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RotateBoneByQuaternion : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(12)] [RED("quaternionNode")] public animQuaternionLink QuaternionNode { get; set; }
		[Ordinal(13)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(14)] [RED("useIncrementalMode")] public CBool UseIncrementalMode { get; set; }
		[Ordinal(15)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }

		public animAnimNode_RotateBoneByQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
