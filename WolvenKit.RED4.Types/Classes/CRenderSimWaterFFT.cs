using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		private CFloat _windDir;
		private CFloat _windSpeed;
		private CFloat _windScale;
		private CFloat _amplitude;
		private CFloat _lambda;

		[Ordinal(0)] 
		[RED("windDir")] 
		public CFloat WindDir
		{
			get => GetProperty(ref _windDir);
			set => SetProperty(ref _windDir, value);
		}

		[Ordinal(1)] 
		[RED("windSpeed")] 
		public CFloat WindSpeed
		{
			get => GetProperty(ref _windSpeed);
			set => SetProperty(ref _windSpeed, value);
		}

		[Ordinal(2)] 
		[RED("windScale")] 
		public CFloat WindScale
		{
			get => GetProperty(ref _windScale);
			set => SetProperty(ref _windScale, value);
		}

		[Ordinal(3)] 
		[RED("amplitude")] 
		public CFloat Amplitude
		{
			get => GetProperty(ref _amplitude);
			set => SetProperty(ref _amplitude, value);
		}

		[Ordinal(4)] 
		[RED("lambda")] 
		public CFloat Lambda
		{
			get => GetProperty(ref _lambda);
			set => SetProperty(ref _lambda, value);
		}

		public CRenderSimWaterFFT()
		{
			_windSpeed = 8.000000F;
			_windScale = 1.000000F;
			_amplitude = 20.000000F;
			_lambda = 0.500000F;
		}
	}
}
