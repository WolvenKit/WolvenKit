using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MultipleParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("parentsTransform")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>> ParentsTransform
		{
			get => GetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>>>();
			set => SetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>>>(value);
		}

		[Ordinal(3)] 
		[RED("parentsWeight")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_Float>> ParentsWeight
		{
			get => GetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_Float>>>();
			set => SetPropertyValue<CArray<CHandle<animIAnimNodeSourceChannel_Float>>>(value);
		}

		[Ordinal(4)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("parentsTransforms")] 
		public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms
		{
			get => GetPropertyValue<CArray<animAnimNode_MultipleParentConstraint_ParentInfo>>();
			set => SetPropertyValue<CArray<animAnimNode_MultipleParentConstraint_ParentInfo>>(value);
		}

		[Ordinal(6)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animEInterpolationType>>();
			set => SetPropertyValue<CEnum<animEInterpolationType>>(value);
		}

		[Ordinal(8)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(9)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_MultipleParentConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ParentsTransform = new();
			ParentsWeight = new();
			ParentsTransforms = new();
			TransformIndex = new animTransformIndex();
			InterpolationType = Enums.animEInterpolationType.Slerp;
			Weight = 1.000000F;
			WeightFloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
