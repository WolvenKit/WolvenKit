using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AimConstraint_ObjectUp : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("upTransform")] 
		public animTransformIndex UpTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(16)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(17)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(18)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_AimConstraint_ObjectUp()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TargetTransform = new animTransformIndex();
			UpTransform = new animTransformIndex();
			TransformIndex = new animTransformIndex();
			ForwardAxisLS = new Vector3 { X = 1.000000F };
			UpAxisLS = new Vector3 { Y = 1.000000F };
			Weight = 1.000000F;
			WeightFloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
