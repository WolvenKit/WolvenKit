using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemMotionBlurScale : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("scale")] 
		public effectEffectParameterEvaluatorFloat Scale
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemMotionBlurScale()
		{
			TimeDuration = 1.000000F;
			Scale = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
