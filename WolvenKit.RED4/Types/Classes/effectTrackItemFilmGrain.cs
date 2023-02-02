using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemFilmGrain : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("luminanceBias")] 
		public effectEffectParameterEvaluatorFloat LuminanceBias
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("strength")] 
		public effectEffectParameterEvaluatorVector Strength
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		public effectTrackItemFilmGrain()
		{
			TimeDuration = 1.000000F;
			LuminanceBias = new();
			Strength = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
