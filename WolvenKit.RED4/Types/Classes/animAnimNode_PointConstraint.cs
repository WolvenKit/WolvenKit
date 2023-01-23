using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PointConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("inputTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> InputTransforms
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>>(value);
		}

		[Ordinal(14)] 
		[RED("preprocessedWeights")] 
		public CArray<CFloat> PreprocessedWeights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("inputWeightedTransforms")] 
		public CArray<animAnimNode_PointConstraint_WeightedTransform> InputWeightedTransforms
		{
			get => GetPropertyValue<CArray<animAnimNode_PointConstraint_WeightedTransform>>();
			set => SetPropertyValue<CArray<animAnimNode_PointConstraint_WeightedTransform>>(value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
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

		public animAnimNode_PointConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			InputTransforms = new();
			PreprocessedWeights = new();
			InputWeightedTransforms = new();
			TransformIndex = new();
			Weight = 1.000000F;
			WeightFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
