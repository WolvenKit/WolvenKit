using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemColorGradeV2 : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("contrast")] 
		public effectEffectParameterEvaluatorFloat Contrast
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(4)] 
		[RED("contrastPivot")] 
		public effectEffectParameterEvaluatorFloat ContrastPivot
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("saturation")] 
		public effectEffectParameterEvaluatorFloat Saturation
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("hue")] 
		public effectEffectParameterEvaluatorFloat Hue
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("brightness")] 
		public effectEffectParameterEvaluatorFloat Brightness
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(8)] 
		[RED("lowRange")] 
		public effectEffectParameterEvaluatorFloat LowRange
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(9)] 
		[RED("highRange")] 
		public effectEffectParameterEvaluatorFloat HighRange
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(10)] 
		[RED("lift")] 
		public effectEffectParameterEvaluatorVector Lift
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(11)] 
		[RED("gamma")] 
		public effectEffectParameterEvaluatorVector Gamma
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(12)] 
		[RED("gain")] 
		public effectEffectParameterEvaluatorVector Gain
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(13)] 
		[RED("offset")] 
		public effectEffectParameterEvaluatorVector Offset
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(14)] 
		[RED("shadow")] 
		public effectEffectParameterEvaluatorVector Shadow
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(15)] 
		[RED("midtone")] 
		public effectEffectParameterEvaluatorVector Midtone
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		[Ordinal(16)] 
		[RED("highlight")] 
		public effectEffectParameterEvaluatorVector Highlight
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorVector>();
			set => SetPropertyValue<effectEffectParameterEvaluatorVector>(value);
		}

		public effectTrackItemColorGradeV2()
		{
			TimeDuration = 1.000000F;
			Contrast = new effectEffectParameterEvaluatorFloat();
			ContrastPivot = new effectEffectParameterEvaluatorFloat();
			Saturation = new effectEffectParameterEvaluatorFloat();
			Hue = new effectEffectParameterEvaluatorFloat();
			Brightness = new effectEffectParameterEvaluatorFloat();
			LowRange = new effectEffectParameterEvaluatorFloat();
			HighRange = new effectEffectParameterEvaluatorFloat();
			Lift = new effectEffectParameterEvaluatorVector();
			Gamma = new effectEffectParameterEvaluatorVector();
			Gain = new effectEffectParameterEvaluatorVector();
			Offset = new effectEffectParameterEvaluatorVector();
			Shadow = new effectEffectParameterEvaluatorVector();
			Midtone = new effectEffectParameterEvaluatorVector();
			Highlight = new effectEffectParameterEvaluatorVector();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
