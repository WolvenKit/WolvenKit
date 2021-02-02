using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendOverride : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("getDeltaMotionFromOverride")] public CBool GetDeltaMotionFromOverride { get; set; }
		[Ordinal(1)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(2)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(3)]  [RED("blendMethod")] public CHandle<animIPoseBlendMethod> BlendMethod { get; set; }
		[Ordinal(4)]  [RED("bones")] public CArray<animOverrideBlendBoneInfo> Bones { get; set; }
		[Ordinal(5)]  [RED("tracks")] public CArray<animOverrideBlendTrackInfo> Tracks { get; set; }
		[Ordinal(6)]  [RED("blendTrackMode")] public CEnum<animEBlendTracksMode> BlendTrackMode { get; set; }
		[Ordinal(7)]  [RED("blendAllTracks")] public CBool BlendAllTracks { get; set; }
		[Ordinal(8)]  [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }
		[Ordinal(9)]  [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(10)]  [RED("overrideInputNode")] public animPoseLink OverrideInputNode { get; set; }
		[Ordinal(11)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_BlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
