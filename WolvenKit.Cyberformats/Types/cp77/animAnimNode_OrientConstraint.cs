using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_OrientConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
		[Ordinal(13)] [RED("inputTransforms")] public CArray<CHandle<animAnimNodeSourceChannel_WeightedQuat>> InputTransforms { get; set; }
		[Ordinal(14)] [RED("preprocessedWeights")] public CArray<CFloat> PreprocessedWeights { get; set; }
		[Ordinal(15)] [RED("inputWeightedTransforms")] public CArray<animAnimNode_OrientConstraint_WeightedTransform> InputWeightedTransforms { get; set; }
		[Ordinal(16)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(17)] [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }
		[Ordinal(18)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(19)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }

		public animAnimNode_OrientConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
