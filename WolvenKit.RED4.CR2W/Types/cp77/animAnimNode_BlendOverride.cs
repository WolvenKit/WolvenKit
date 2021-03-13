using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendOverride : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(12)] [RED("overrideInputNode")] public animPoseLink OverrideInputNode { get; set; }
		[Ordinal(13)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(14)] [RED("bones")] public CArray<animOverrideBlendBoneInfo> Bones { get; set; }
		[Ordinal(15)] [RED("blendAllTracks")] public CBool BlendAllTracks { get; set; }
		[Ordinal(16)] [RED("blendTrackMode")] public CEnum<animEBlendTracksMode> BlendTrackMode { get; set; }
		[Ordinal(17)] [RED("tracks")] public CArray<animOverrideBlendTrackInfo> Tracks { get; set; }
		[Ordinal(18)] [RED("getDeltaMotionFromOverride")] public CBool GetDeltaMotionFromOverride { get; set; }
		[Ordinal(19)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(20)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(21)] [RED("blendMethod")] public CHandle<animIPoseBlendMethod> BlendMethod { get; set; }
		[Ordinal(22)] [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }

		public animAnimNode_BlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
