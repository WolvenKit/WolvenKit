using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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

		public effectTrackItemDataMosh()
		{
			TimeDuration = 1.000000F;
			Intensity = new();
			GlitchColor = new();
		}
	}
}
