using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBoneOrientation : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(13)] [RED("orientationMs")] public animQuaternionLink OrientationMs { get; set; }

		public animAnimNode_SetBoneOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
