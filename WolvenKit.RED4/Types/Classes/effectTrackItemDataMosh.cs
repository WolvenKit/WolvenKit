using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemDataMosh : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("useGlitch")] 
		public CBool UseGlitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("glitchColor")] 
		public effectEffectParameterEvaluatorVector GlitchColor
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(7)] 
		[RED("usePixelsort")] 
		public CBool UsePixelsort
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("pixelsortOverride")] 
		public CBool PixelsortOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("pixelsortIntensity")] 
		public effectEffectParameterEvaluatorFloat PixelsortIntensity
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(10)] 
		[RED("pixelsortStencil")] 
		public CBool PixelsortStencil
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("pixelsortVfx")] 
		public CBool PixelsortVfx
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public effectTrackItemDataMosh()
		{
			TimeDuration = 1.000000F;
			Intensity = new effectEffectParameterEvaluatorFloat();
			GlitchColor = new effectEffectParameterEvaluatorVector();
			PixelsortIntensity = new effectEffectParameterEvaluatorFloat();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
