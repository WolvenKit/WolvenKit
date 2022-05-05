using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatTrackDirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(13)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get => GetPropertyValue<CEnum<animTransformChannel>>();
			set => SetPropertyValue<CEnum<animTransformChannel>>(value);
		}

		[Ordinal(15)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(18)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatTrackDirectConnConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			FloatTrackIndex = new();
			TransformIndex = new();
			MulFactor = 1.000000F;
			Weight = 1.000000F;
			WeightNode = new();
			MulFactorNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
