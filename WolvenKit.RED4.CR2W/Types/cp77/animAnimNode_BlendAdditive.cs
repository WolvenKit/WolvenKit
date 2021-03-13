using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendAdditive : animAnimNode_Base
	{
		[Ordinal(11)] [RED("biasValue")] public CFloat BiasValue { get; set; }
		[Ordinal(12)] [RED("scaleValue")] public CFloat ScaleValue { get; set; }
		[Ordinal(13)] [RED("additiveType")] public CEnum<animEAnimGraphAdditiveType> AdditiveType { get; set; }
		[Ordinal(14)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(15)] [RED("blendTracks")] public CEnum<animEBlendTracksMode> BlendTracks { get; set; }
		[Ordinal(16)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(17)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(18)] [RED("addedInputNode")] public animPoseLink AddedInputNode { get; set; }
		[Ordinal(19)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(20)] [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }
		[Ordinal(21)] [RED("weightPreviousFrameFloatTrack")] public animNamedTrackIndex WeightPreviousFrameFloatTrack { get; set; }
		[Ordinal(22)] [RED("weightPreviousFrameFloatTrackDefaultValue")] public CFloat WeightPreviousFrameFloatTrackDefaultValue { get; set; }
		[Ordinal(23)] [RED("maskName")] public CName MaskName { get; set; }

		public animAnimNode_BlendAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
