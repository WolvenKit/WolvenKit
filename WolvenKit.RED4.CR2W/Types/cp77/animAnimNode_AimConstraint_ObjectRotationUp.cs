using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AimConstraint_ObjectRotationUp : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
		[Ordinal(13)] [RED("upTransform")] public animTransformIndex UpTransform { get; set; }
		[Ordinal(14)] [RED("upTransformVector")] public Vector3 UpTransformVector { get; set; }
		[Ordinal(15)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(16)] [RED("forwardAxisLS")] public Vector3 ForwardAxisLS { get; set; }
		[Ordinal(17)] [RED("upAxisLS")] public Vector3 UpAxisLS { get; set; }
		[Ordinal(18)] [RED("weightMode")] public CEnum<animConstraintWeightMode> WeightMode { get; set; }
		[Ordinal(19)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(20)] [RED("weightFloatTrack")] public animNamedTrackIndex WeightFloatTrack { get; set; }

		public animAnimNode_AimConstraint_ObjectRotationUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
