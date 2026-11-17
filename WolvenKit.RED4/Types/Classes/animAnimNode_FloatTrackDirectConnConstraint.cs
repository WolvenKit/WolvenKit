using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatTrackDirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(3)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get => GetPropertyValue<CEnum<animTransformChannel>>();
			set => SetPropertyValue<CEnum<animTransformChannel>>(value);
		}

		[Ordinal(5)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(8)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatTrackDirectConnConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			FloatTrackIndex = new animNamedTrackIndex();
			TransformIndex = new animTransformIndex();
			MulFactor = 1.000000F;
			Weight = 1.000000F;
			WeightNode = new animFloatLink();
			MulFactorNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
