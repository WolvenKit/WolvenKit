using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultipleParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("parentsTransform")] public CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>> ParentsTransform { get; set; }
		[Ordinal(13)] [RED("parentsWeight")] public CArray<CHandle<animIAnimNodeSourceChannel_Float>> ParentsWeight { get; set; }
		[Ordinal(14)] [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
		[Ordinal(15)] [RED("parentsTransforms")] public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms { get; set; }
		[Ordinal(16)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(17)] [RED("interpolationType")] public CEnum<animEInterpolationType> InterpolationType { get; set; }
		[Ordinal(18)] [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }
		[Ordinal(19)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(20)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }

		public animAnimNode_MultipleParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
