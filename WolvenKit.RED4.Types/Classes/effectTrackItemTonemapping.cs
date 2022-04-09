using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemTonemapping : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("maxStopsSDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsSDR
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("midGrayScaleSDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleSDR
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxStopsHDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsHDR
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("midGrayScaleHDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleHDR
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemTonemapping()
		{
			TimeDuration = 1.000000F;
			MaxStopsSDR = new();
			MidGrayScaleSDR = new();
			MaxStopsHDR = new();
			MidGrayScaleHDR = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
