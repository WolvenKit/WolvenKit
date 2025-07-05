using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemChromaticAberration : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationOffset")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationExp
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemChromaticAberration()
		{
			TimeDuration = 1.000000F;
			ChromaticAberrationOffset = new effectEffectParameterEvaluatorFloat();
			ChromaticAberrationExp = new effectEffectParameterEvaluatorFloat();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
