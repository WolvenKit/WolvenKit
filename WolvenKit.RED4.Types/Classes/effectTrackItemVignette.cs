using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemVignette : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("overrideRadiusAndExp")] 
		public CBool OverrideRadiusAndExp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("overrideColor")] 
		public CBool OverrideColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("vignetteRadius")] 
		public effectEffectParameterEvaluatorFloat VignetteRadius
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("vignetteExp")] 
		public effectEffectParameterEvaluatorFloat VignetteExp
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public effectEffectParameterEvaluatorColor Color
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorColor>();
			set => SetPropertyValue<effectEffectParameterEvaluatorColor>(value);
		}

		public effectTrackItemVignette()
		{
			TimeDuration = 1.000000F;
			VignetteRadius = new();
			VignetteExp = new();
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
