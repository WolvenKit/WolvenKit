using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("parentTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> ParentTransform { get; set; }
		[Ordinal(13)] [RED("isParentTransformResaved")] public CBool IsParentTransformResaved { get; set; }
		[Ordinal(14)] [RED("parentTransformIndex")] public animTransformIndex ParentTransformIndex { get; set; }
		[Ordinal(15)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(16)] [RED("interpolationType")] public CEnum<animEInterpolationType> InterpolationType { get; set; }
		[Ordinal(17)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(18)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }
		[Ordinal(19)] [RED("useBoneReferencePoseAsDefaultOffset")] public CBool UseBoneReferencePoseAsDefaultOffset { get; set; }
		[Ordinal(20)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(21)] [RED("offsetTranslationLS")] public animVectorLink OffsetTranslationLS { get; set; }
		[Ordinal(22)] [RED("offsetEulerRotationLS")] public animVectorLink OffsetEulerRotationLS { get; set; }

		public animAnimNode_ParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
