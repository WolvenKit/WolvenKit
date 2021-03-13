using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SharedMetaPoseAdditive : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("weightLink")] public animFloatLink WeightLink { get; set; }
		[Ordinal(13)] [RED("additiveType")] public CEnum<animEAnimGraphAdditiveType> AdditiveType { get; set; }
		[Ordinal(14)] [RED("blendTracks")] public CEnum<animEBlendTracksMode> BlendTracks { get; set; }
		[Ordinal(15)] [RED("convertParentPoseToAdditive")] public CBool ConvertParentPoseToAdditive { get; set; }

		public animAnimNode_SharedMetaPoseAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
