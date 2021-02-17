using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SharedMetaPoseAdditive : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }
		[Ordinal(3)] [RED("additiveType")] public CEnum<animEAnimGraphAdditiveType> AdditiveType { get; set; }
		[Ordinal(4)] [RED("blendTracks")] public CEnum<animEBlendTracksMode> BlendTracks { get; set; }
		[Ordinal(5)] [RED("convertParentPoseToAdditive")] public CBool ConvertParentPoseToAdditive { get; set; }

		public animAnimNode_SharedMetaPoseAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
