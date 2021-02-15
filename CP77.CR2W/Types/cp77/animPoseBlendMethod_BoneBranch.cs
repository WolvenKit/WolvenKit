using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		[Ordinal(0)] [RED("bones")] public CArray<animOverrideBlendBoneInfo> Bones { get; set; }

		public animPoseBlendMethod_BoneBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
