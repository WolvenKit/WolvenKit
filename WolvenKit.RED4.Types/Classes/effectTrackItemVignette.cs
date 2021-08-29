using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemVignette : effectTrackItem
	{
		private CBool _overrideRadiusAndExp;
		private CBool _overrideColor;
		private effectEffectParameterEvaluatorFloat _vignetteRadius;
		private effectEffectParameterEvaluatorFloat _vignetteExp;
		private effectEffectParameterEvaluatorColor _color;

		[Ordinal(3)] 
		[RED("overrideRadiusAndExp")] 
		public CBool OverrideRadiusAndExp
		{
			get => GetProperty(ref _overrideRadiusAndExp);
			set => SetProperty(ref _overrideRadiusAndExp, value);
		}

		[Ordinal(4)] 
		[RED("overrideColor")] 
		public CBool OverrideColor
		{
			get => GetProperty(ref _overrideColor);
			set => SetProperty(ref _overrideColor, value);
		}

		[Ordinal(5)] 
		[RED("vignetteRadius")] 
		public effectEffectParameterEvaluatorFloat VignetteRadius
		{
			get => GetProperty(ref _vignetteRadius);
			set => SetProperty(ref _vignetteRadius, value);
		}

		[Ordinal(6)] 
		[RED("vignetteExp")] 
		public effectEffectParameterEvaluatorFloat VignetteExp
		{
			get => GetProperty(ref _vignetteExp);
			set => SetProperty(ref _vignetteExp, value);
		}

		[Ordinal(7)] 
		[RED("color")] 
		public effectEffectParameterEvaluatorColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}
	}
}
