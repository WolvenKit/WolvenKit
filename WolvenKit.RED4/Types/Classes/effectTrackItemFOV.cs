using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemFOV : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("FOV")] 
		public effectEffectParameterEvaluatorFloat FOV
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemFOV()
		{
			TimeDuration = 1.000000F;
			FOV = new effectEffectParameterEvaluatorFloat();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
