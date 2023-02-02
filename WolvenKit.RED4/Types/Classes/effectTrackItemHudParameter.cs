using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemHudParameter : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("glitchParameter")] 
		public effectEffectParameterEvaluator GlitchParameter
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("glitchParameter1")] 
		public effectEffectParameterEvaluator GlitchParameter1
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		public effectTrackItemHudParameter()
		{
			TimeDuration = 1.000000F;
			Scale = 1.000000F;
			GlitchParameter = new();
			Scale1 = 1.000000F;
			GlitchParameter1 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
