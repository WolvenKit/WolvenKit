using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STonemappingACESParams : RedBaseClass
	{
		private CFloat _minStops;
		private CFloat _maxStops;
		private CFloat _midGrayScale;
		private CFloat _surroundGamma;
		private CFloat _toneCurveSaturation;
		private CBool _adjustWhitePoint;
		private CBool _desaturate;
		private CBool _dimSurround;
		private CBool _tonemapLuminance;
		private CBool _applyAfterLUT;

		[Ordinal(0)] 
		[RED("minStops")] 
		public CFloat MinStops
		{
			get => GetProperty(ref _minStops);
			set => SetProperty(ref _minStops, value);
		}

		[Ordinal(1)] 
		[RED("maxStops")] 
		public CFloat MaxStops
		{
			get => GetProperty(ref _maxStops);
			set => SetProperty(ref _maxStops, value);
		}

		[Ordinal(2)] 
		[RED("midGrayScale")] 
		public CFloat MidGrayScale
		{
			get => GetProperty(ref _midGrayScale);
			set => SetProperty(ref _midGrayScale, value);
		}

		[Ordinal(3)] 
		[RED("surroundGamma")] 
		public CFloat SurroundGamma
		{
			get => GetProperty(ref _surroundGamma);
			set => SetProperty(ref _surroundGamma, value);
		}

		[Ordinal(4)] 
		[RED("toneCurveSaturation")] 
		public CFloat ToneCurveSaturation
		{
			get => GetProperty(ref _toneCurveSaturation);
			set => SetProperty(ref _toneCurveSaturation, value);
		}

		[Ordinal(5)] 
		[RED("adjustWhitePoint")] 
		public CBool AdjustWhitePoint
		{
			get => GetProperty(ref _adjustWhitePoint);
			set => SetProperty(ref _adjustWhitePoint, value);
		}

		[Ordinal(6)] 
		[RED("desaturate")] 
		public CBool Desaturate
		{
			get => GetProperty(ref _desaturate);
			set => SetProperty(ref _desaturate, value);
		}

		[Ordinal(7)] 
		[RED("dimSurround")] 
		public CBool DimSurround
		{
			get => GetProperty(ref _dimSurround);
			set => SetProperty(ref _dimSurround, value);
		}

		[Ordinal(8)] 
		[RED("tonemapLuminance")] 
		public CBool TonemapLuminance
		{
			get => GetProperty(ref _tonemapLuminance);
			set => SetProperty(ref _tonemapLuminance, value);
		}

		[Ordinal(9)] 
		[RED("applyAfterLUT")] 
		public CBool ApplyAfterLUT
		{
			get => GetProperty(ref _applyAfterLUT);
			set => SetProperty(ref _applyAfterLUT, value);
		}
	}
}
