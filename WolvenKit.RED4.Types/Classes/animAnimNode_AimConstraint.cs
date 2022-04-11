using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AimConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("targetTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> TargetTransforms
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>(value);
		}

		[Ordinal(14)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("upTransform")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> UpTransform
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_Vector>>(value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(17)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(18)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(19)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(20)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_AimConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			TargetTransforms = new();
			TargetTransform = new();
			TransformIndex = new();
			ForwardAxisLS = new() { X = 1.000000F };
			UpAxisLS = new() { Y = 1.000000F };
			Weight = 1.000000F;
			WeightFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
