using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSAnimationBufferBitwiseCompressionSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("translationTolerance")] 
		public CFloat TranslationTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("translationSkipFrameTolerance")] 
		public CFloat TranslationSkipFrameTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("orientationTolerance")] 
		public CFloat OrientationTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("orientationCompressionMethod")] 
		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod
		{
			get => GetPropertyValue<CEnum<SAnimationBufferOrientationCompressionMethod>>();
			set => SetPropertyValue<CEnum<SAnimationBufferOrientationCompressionMethod>>(value);
		}

		[Ordinal(4)] 
		[RED("orientationSkipFrameTolerance")] 
		public CFloat OrientationSkipFrameTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("scaleTolerance")] 
		public CFloat ScaleTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("scaleSkipFrameTolerance")] 
		public CFloat ScaleSkipFrameTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("trackTolerance")] 
		public CFloat TrackTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("trackSkipFrameTolerance")] 
		public CFloat TrackSkipFrameTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSAnimationBufferBitwiseCompressionSettings()
		{
			TranslationTolerance = 0.010000F;
			TranslationSkipFrameTolerance = 0.010000F;
			OrientationTolerance = 0.002000F;
			OrientationCompressionMethod = Enums.SAnimationBufferOrientationCompressionMethod.ABOCM_PackIn48bitsW;
			OrientationSkipFrameTolerance = 0.010000F;
			ScaleTolerance = 0.010000F;
			ScaleSkipFrameTolerance = 0.010000F;
			TrackTolerance = 0.001000F;
			TrackSkipFrameTolerance = 0.001000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
