using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ParentConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("parentTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> ParentTransform
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>(value);
		}

		[Ordinal(3)] 
		[RED("isParentTransformResaved")] 
		public CBool IsParentTransformResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("parentTransformIndex")] 
		public animTransformIndex ParentTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animEInterpolationType>>();
			set => SetPropertyValue<CEnum<animEInterpolationType>>(value);
		}

		[Ordinal(7)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(9)] 
		[RED("useBoneReferencePoseAsDefaultOffset")] 
		public CBool UseBoneReferencePoseAsDefaultOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(11)] 
		[RED("offsetTranslationLS")] 
		public animVectorLink OffsetTranslationLS
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(12)] 
		[RED("offsetEulerRotationLS")] 
		public animVectorLink OffsetEulerRotationLS
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_ParentConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ParentTransformIndex = new animTransformIndex();
			TransformIndex = new animTransformIndex();
			InterpolationType = Enums.animEInterpolationType.Slerp;
			Weight = 1.000000F;
			WeightFloatTrack = new animNamedTrackIndex();
			WeightNode = new animFloatLink();
			OffsetTranslationLS = new animVectorLink();
			OffsetEulerRotationLS = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
