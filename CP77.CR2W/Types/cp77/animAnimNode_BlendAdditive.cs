using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendAdditive : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("biasValue")] public CFloat BiasValue { get; set; }
		[Ordinal(1)]  [RED("scaleValue")] public CFloat ScaleValue { get; set; }
		[Ordinal(2)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(3)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(4)]  [RED("additiveType")] public CEnum<animEAnimGraphAdditiveType> AdditiveType { get; set; }
		[Ordinal(5)]  [RED("blendTracks")] public CEnum<animEBlendTracksMode> BlendTracks { get; set; }
		[Ordinal(6)]  [RED("postProcess")] public CHandle<animIAnimNode_PostProcess> PostProcess { get; set; }
		[Ordinal(7)]  [RED("weightPreviousFrameFloatTrack")] public animNamedTrackIndex WeightPreviousFrameFloatTrack { get; set; }
		[Ordinal(8)]  [RED("weightPreviousFrameFloatTrackDefaultValue")] public CFloat WeightPreviousFrameFloatTrackDefaultValue { get; set; }
		[Ordinal(9)]  [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(10)]  [RED("addedInputNode")] public animPoseLink AddedInputNode { get; set; }
		[Ordinal(11)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(12)]  [RED("maskName")] public CName MaskName { get; set; }

		public animAnimNode_BlendAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
