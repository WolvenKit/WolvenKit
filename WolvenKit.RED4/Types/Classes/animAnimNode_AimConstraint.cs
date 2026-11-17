using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AimConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("targetTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> TargetTransforms
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>(value);
		}

		[Ordinal(4)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("upTransform")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> UpTransform
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>(value);
		}

		[Ordinal(6)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(10)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_AimConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TargetTransforms = new();
			TargetTransform = new animTransformIndex();
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
