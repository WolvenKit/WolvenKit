using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemExposureScale : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("scale")] 
		public effectEffectParameterEvaluatorFloat Scale
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(4)] 
		[RED("useInitialCameraPosDirForFadeout")] 
		public CBool UseInitialCameraPosDirForFadeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("fullEffectRadius")] 
		public CFloat FullEffectRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("fadeOutRadius")] 
		public CFloat FadeOutRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("fullyVisibleAngle")] 
		public CFloat FullyVisibleAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("fadeOutAngle")] 
		public CFloat FadeOutAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public effectTrackItemExposureScale()
		{
			TimeDuration = 1.000000F;
			Scale = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
