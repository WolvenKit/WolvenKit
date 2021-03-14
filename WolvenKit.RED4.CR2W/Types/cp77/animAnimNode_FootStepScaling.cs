using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("hipsIndex")] public animTransformIndex HipsIndex { get; set; }
		[Ordinal(13)] [RED("leftFootIKIndex")] public animTransformIndex LeftFootIKIndex { get; set; }
		[Ordinal(14)] [RED("rightFootIKIndex")] public animTransformIndex RightFootIKIndex { get; set; }
		[Ordinal(15)] [RED("inputSpeed")] public animFloatLink InputSpeed { get; set; }
		[Ordinal(16)] [RED("weight")] public animFloatLink Weight { get; set; }
		[Ordinal(17)] [RED("Params")] public animfssBodyOfflineParams Params { get; set; }

		public animAnimNode_FootStepScaling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
