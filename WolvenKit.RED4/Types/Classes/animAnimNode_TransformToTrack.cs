using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TransformToTrack : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("floatTrack")] 
		public CInt32 FloatTrack
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(14)] 
		[RED("outputTransform")] 
		public CInt16 OutputTransform
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get => GetPropertyValue<CEnum<animTransformChannel>>();
			set => SetPropertyValue<CEnum<animTransformChannel>>(value);
		}

		[Ordinal(17)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(20)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_TransformToTrack()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			FloatTrack = -1;
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
