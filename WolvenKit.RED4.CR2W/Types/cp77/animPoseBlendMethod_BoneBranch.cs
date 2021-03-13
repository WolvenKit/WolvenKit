using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		[Ordinal(0)] [RED("bones")] public CArray<animOverrideBlendBoneInfo> Bones { get; set; }

		public animPoseBlendMethod_BoneBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
