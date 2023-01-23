using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemLightParameter : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("intensityMultiplier")] 
		public effectEffectParameterEvaluatorFloat IntensityMultiplier
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("radius")] 
		public effectEffectParameterEvaluatorFloat Radius
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemLightParameter()
		{
			TimeDuration = 1.000000F;
			Scale = 1.000000F;
			IntensityMultiplier = new();
			Intensity = new();
			Radius = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
