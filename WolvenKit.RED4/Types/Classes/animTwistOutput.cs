using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animTwistOutput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positiveScale")] 
		public CFloat PositiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("negativeScale")] 
		public CFloat NegativeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("twistAxis")] 
		public CEnum<animAxis> TwistAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(3)] 
		[RED("twistedTransform")] 
		public animTransformIndex TwistedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("outputAngleTrack")] 
		public animNamedTrackIndex OutputAngleTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animTwistOutput()
		{
			PositiveScale = 1.000000F;
			NegativeScale = 1.000000F;
			TwistedTransform = new animTransformIndex();
			OutputAngleTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
