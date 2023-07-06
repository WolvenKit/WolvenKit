using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemBloom : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("sceneColorScale")] 
		public effectEffectParameterEvaluatorFloat SceneColorScale
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public effectEffectParameterEvaluatorFloat BloomColorScale
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemBloom()
		{
			TimeDuration = 1.000000F;
			SceneColorScale = new effectEffectParameterEvaluatorFloat();
			BloomColorScale = new effectEffectParameterEvaluatorFloat();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
