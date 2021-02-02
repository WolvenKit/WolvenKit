using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("inputSpeed")] public animFloatLink InputSpeed { get; set; }
		[Ordinal(1)]  [RED("weight")] public animFloatLink Weight { get; set; }
		[Ordinal(2)]  [RED("hipsIndex")] public animTransformIndex HipsIndex { get; set; }
		[Ordinal(3)]  [RED("leftFootIKIndex")] public animTransformIndex LeftFootIKIndex { get; set; }
		[Ordinal(4)]  [RED("rightFootIKIndex")] public animTransformIndex RightFootIKIndex { get; set; }
		[Ordinal(5)]  [RED("Params")] public animfssBodyOfflineParams Params { get; set; }

		public animAnimNode_FootStepScaling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
