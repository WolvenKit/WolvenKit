using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MultipleParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("parentsTransform")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>> ParentsTransform
		{
			get => GetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>>>();
			set => SetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>>>(value);
		}

		[Ordinal(13)] 
		[RED("parentsWeight")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_Float>> ParentsWeight
		{
			get => GetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_Float>>>();
			set => SetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_Float>>>(value);
		}

		[Ordinal(14)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("parentsTransforms")] 
		public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms
		{
			get => GetPropertyValue<CArray<animAnimNode_MultipleParentConstraint_ParentInfo>>();
			set => SetPropertyValue<CArray<animAnimNode_MultipleParentConstraint_ParentInfo>>(value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(17)] 
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animEInterpolationType>>();
			set => SetPropertyValue<CEnum<animEInterpolationType>>(value);
		}

		[Ordinal(18)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(19)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_MultipleParentConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			ParentsTransform = new();
			ParentsWeight = new();
			ParentsTransforms = new();
			TransformIndex = new();
			InterpolationType = Enums.animEInterpolationType.Slerp;
			Weight = 1.000000F;
			WeightFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
