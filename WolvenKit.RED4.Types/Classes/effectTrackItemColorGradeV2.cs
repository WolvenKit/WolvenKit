using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemColorGradeV2 : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _contrast;
		private effectEffectParameterEvaluatorFloat _contrastPivot;
		private effectEffectParameterEvaluatorFloat _saturation;
		private effectEffectParameterEvaluatorFloat _hue;
		private effectEffectParameterEvaluatorFloat _brightness;
		private effectEffectParameterEvaluatorFloat _lowRange;
		private effectEffectParameterEvaluatorFloat _highRange;
		private effectEffectParameterEvaluatorVector _lift;
		private effectEffectParameterEvaluatorVector _gamma;
		private effectEffectParameterEvaluatorVector _gain;
		private effectEffectParameterEvaluatorVector _offset;
		private effectEffectParameterEvaluatorVector _shadow;
		private effectEffectParameterEvaluatorVector _midtone;
		private effectEffectParameterEvaluatorVector _highlight;

		[Ordinal(3)] 
		[RED("contrast")] 
		public effectEffectParameterEvaluatorFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(4)] 
		[RED("contrastPivot")] 
		public effectEffectParameterEvaluatorFloat ContrastPivot
		{
			get => GetProperty(ref _contrastPivot);
			set => SetProperty(ref _contrastPivot, value);
		}

		[Ordinal(5)] 
		[RED("saturation")] 
		public effectEffectParameterEvaluatorFloat Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		[Ordinal(6)] 
		[RED("hue")] 
		public effectEffectParameterEvaluatorFloat Hue
		{
			get => GetProperty(ref _hue);
			set => SetProperty(ref _hue, value);
		}

		[Ordinal(7)] 
		[RED("brightness")] 
		public effectEffectParameterEvaluatorFloat Brightness
		{
			get => GetProperty(ref _brightness);
			set => SetProperty(ref _brightness, value);
		}

		[Ordinal(8)] 
		[RED("lowRange")] 
		public effectEffectParameterEvaluatorFloat LowRange
		{
			get => GetProperty(ref _lowRange);
			set => SetProperty(ref _lowRange, value);
		}

		[Ordinal(9)] 
		[RED("highRange")] 
		public effectEffectParameterEvaluatorFloat HighRange
		{
			get => GetProperty(ref _highRange);
			set => SetProperty(ref _highRange, value);
		}

		[Ordinal(10)] 
		[RED("lift")] 
		public effectEffectParameterEvaluatorVector Lift
		{
			get => GetProperty(ref _lift);
			set => SetProperty(ref _lift, value);
		}

		[Ordinal(11)] 
		[RED("gamma")] 
		public effectEffectParameterEvaluatorVector Gamma
		{
			get => GetProperty(ref _gamma);
			set => SetProperty(ref _gamma, value);
		}

		[Ordinal(12)] 
		[RED("gain")] 
		public effectEffectParameterEvaluatorVector Gain
		{
			get => GetProperty(ref _gain);
			set => SetProperty(ref _gain, value);
		}

		[Ordinal(13)] 
		[RED("offset")] 
		public effectEffectParameterEvaluatorVector Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(14)] 
		[RED("shadow")] 
		public effectEffectParameterEvaluatorVector Shadow
		{
			get => GetProperty(ref _shadow);
			set => SetProperty(ref _shadow, value);
		}

		[Ordinal(15)] 
		[RED("midtone")] 
		public effectEffectParameterEvaluatorVector Midtone
		{
			get => GetProperty(ref _midtone);
			set => SetProperty(ref _midtone, value);
		}

		[Ordinal(16)] 
		[RED("highlight")] 
		public effectEffectParameterEvaluatorVector Highlight
		{
			get => GetProperty(ref _highlight);
			set => SetProperty(ref _highlight, value);
		}
	}
}
